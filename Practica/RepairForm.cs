using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class RepairForm : Form
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int failureId { get; set; }
        public string serialNumber { get; set; }
        public DateTime failureDate { get; set; }
        public string failureDescription { get; set; }

        public RepairForm(int failureId, string serialNumber, DateTime failureDate, string failureDescription)
        {
            InitializeComponent();
            this.failureId = failureId;
            this.serialNumber = serialNumber;
            this.failureDate = failureDate;
            this.failureDescription = failureDescription;

            lbl_ser_num.Text = $"Серийный номер: {serialNumber}";
            lbl_date_fail.Text = failureDate.ToString("dd.MM.yyyy");
            txt_opis.Text = failureDescription;  
            txt_opis.ReadOnly = true;       
            dtp_repair.Value = DateTime.Now;
            LoadMasters();
        }

        private void LoadMasters()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT id, fio FROM public.users WHERE role_id = (SELECT id FROM roles WHERE roles_name = 'Инженер') ORDER BY fio";
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Fio", typeof(string));
                using (var cmd = new NpgsqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
                cmb_master.DataSource = dt;
                cmb_master.DisplayMember = "Fio";
                cmb_master.ValueMember = "Id";
                cmb_master.DropDownStyle = ComboBoxStyle.DropDownList;
                if (cmb_master.Items.Count > 0) cmb_master.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_opis.Text))
            {
                MessageBox.Show("Введите описание работ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmb_master.SelectedValue == null)
            {
                MessageBox.Show("Выберите мастера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int masterId = Convert.ToInt32(cmb_master.SelectedValue);

            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = @"INSERT INTO public.repairs (fail_id, repair_date, work_description, replaced_components, user_id)
                               VALUES (@fail_id, @repair_date, @work_desc, @replaced_comp, @user_id)";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@fail_id", failureId);
                    cmd.Parameters.AddWithValue("@repair_date", dtp_repair.Value);
                    cmd.Parameters.AddWithValue("@work_desc", txt_opis.Text);
                    cmd.Parameters.AddWithValue("@replaced_comp", string.IsNullOrWhiteSpace(txt_zam_compon.Text) ? DBNull.Value : (object)txt_zam_compon.Text);
                    cmd.Parameters.AddWithValue("@user_id", masterId);
                    cmd.ExecuteNonQuery();
                }
            }

            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string updateStatus = @"UPDATE controllers SET status = 'На складе' 
                                        FROM fail WHERE fail.id = @fail_id AND controllers.id = fail.controller_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(updateStatus, con))
                {
                    cmd.Parameters.AddWithValue("@fail_id", failureId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Ремонт зарегистрирован. Статус контроллера изменён на 'На складе'.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

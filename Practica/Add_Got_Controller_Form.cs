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
    public partial class Add_Got_Controller_Form : Form
    {
        List<Control> controls = new List<Control>();
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";


        public Add_Got_Controller_Form()
        {
            InitializeComponent();
            LoadModels();
            controls.Add(txt_ser_num);
            controls.Add(cmb_model);
            foreach (var c in controls)
                c.Click += (s, e) => c.BackColor = SystemColors.Window;
        }

        private void LoadModels()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = "SELECT id, model_name FROM public.controller_models ORDER BY model_name";
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("ModelName", typeof(string));
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
                cmb_model.DataSource = dt;
                cmb_model.DisplayMember = "ModelName";
                cmb_model.ValueMember = "Id";
                cmb_model.DropDownStyle = ComboBoxStyle.DropDownList;
                if (cmb_model.Items.Count > 0) 
                    cmb_model.SelectedIndex = 0;
            }
        }

        private void AddGotControl()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string checkSql = "SELECT COUNT(*) FROM public.controllers WHERE serial_number = @sn";
                using (var checkCmd = new NpgsqlCommand(checkSql, con))
                {
                    checkCmd.Parameters.AddWithValue("@sn", txt_ser_num.Text.Trim());
                    int exists = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (exists > 0)
                    {
                        MessageBox.Show("Контроллер с таким серийным номером уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string sql = @"INSERT INTO public.controllers (serial_number, model_id, production_date, status)
                               VALUES (@sn, @model_id, @prod_date, @status)";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@sn", txt_ser_num.Text.Trim());
                    cmd.Parameters.AddWithValue("@model_id", cmb_model.SelectedValue);
                    cmd.Parameters.AddWithValue("@prod_date", dtp_vipuska.Value);
                    cmd.Parameters.AddWithValue("@status", cmb_status.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btn_add_got_controll_Click(object sender, EventArgs e)
        {
            bool hasError = false;
            foreach (var c in controls)
            {
                if (c is TextBox tb && string.IsNullOrWhiteSpace(tb.Text))
                {
                    hasError = true;
                    c.BackColor = Color.Red;
                }
                else if (c is ComboBox cb && cb.SelectedValue == null)
                {
                    hasError = true;
                    c.BackColor = Color.Red;
                }
                else
                {
                    c.BackColor = SystemColors.Window;
                }
            }
            if (cmb_status.SelectedItem == null)
            {
                hasError = true;
                cmb_status.BackColor = Color.Red;
            }
            else
            {
                cmb_status.BackColor = SystemColors.Window;
            }

            if (hasError)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                AddGotControl();
                MessageBox.Show("Контроллер успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                (Application.OpenForms["MainForm"] as MainForm)?.Controller();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка БД: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

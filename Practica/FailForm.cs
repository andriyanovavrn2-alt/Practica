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
    public partial class FailForm : Form
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        private int controllerId;
        private string serialNumber;
        public FailForm(int controllerId, string serialNumber, string modelName)
        {
            InitializeComponent();
            this.controllerId = controllerId;
            this.serialNumber = serialNumber;

            lbl_ser_num.Text = serialNumber;
            txt_model.Text = modelName;

            dtp_otkaz.Value = DateTime.Now;
            cmb_critical.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_opis.Text))
            {
                MessageBox.Show("Введите описание неисправности", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string criticality = cmb_critical.SelectedItem.ToString();

            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = @"INSERT INTO public.fail (controller_id, failure_date, description, criticality)
                               VALUES (@cid, @date, @desc, @crit)";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@cid", controllerId);
                    cmd.Parameters.AddWithValue("@date", dtp_otkaz.Value);
                    cmd.Parameters.AddWithValue("@desc", txt_opis.Text);
                    cmd.Parameters.AddWithValue("@crit", criticality);
                    cmd.ExecuteNonQuery();
                }
            }

            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string updateStatus = "UPDATE public.controllers SET status = 'В ремонте' WHERE id = @id";
                using (var cmd = new NpgsqlCommand(updateStatus, con))
                {
                    cmd.Parameters.AddWithValue("@id", controllerId);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Отказ зарегистрирован. Статус 'В ремонте'.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

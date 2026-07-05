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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Practica
{
    public partial class Autoriz : Form
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public Autoriz()
        {
            InitializeComponent();
        }
        public void Aut()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                var sql = $@"SELECT roles.roles_name, fio, login, password
	                            FROM public.users 
	                            JOIN roles ON roles.id = users.role_id
                            WHERE login = @login AND password = crypt(@password, password)";
                using (NpgsqlCommand com = new NpgsqlCommand(sql, con))
                {
                    com.Parameters.AddWithValue("@login", txt_log.Text);
                    com.Parameters.AddWithValue("@password", txt_pass.Text);
                    using (NpgsqlDataReader reader = com.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            MessageBox.Show("Успешное подключение!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            MainForm mainForm = new MainForm(reader.GetString(0), reader.GetString(1));
                            mainForm.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Повторите попытку!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Aut();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPass.Checked == true)
                txt_pass.UseSystemPasswordChar = false;
            if (checkBoxPass.Checked == false)
                txt_pass.UseSystemPasswordChar = true;
        }
    }
}

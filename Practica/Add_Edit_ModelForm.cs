using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Add_Edit_ModelForm : Form
    {
        List<Control> controls = new List<Control>();
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int Id { get; set; }
        public Add_Edit_ModelForm(int id)  // Для редактирования
        {
            InitializeComponent();
            Id = id;
            LoadModel();
            btn_add.Visible = false;
            this.Text = "Редактирование модели";
        }

        private void LoadModel()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT model_name, description
	                            FROM public.controller_models 
                                WHERE id = @id";
                using (var command = new NpgsqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_name.Text = reader.GetString(0);
                            txt_opis.Text = reader.GetString(1);
                        }
                    }
                }
            }
        }

        public void UpdateModel()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"UPDATE public.controller_models
	SET model_name=@model_name, description=@description
	WHERE id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@model_name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@description", txt_opis.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Модель контроллера обновлёна!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                    mainForm.ModelController();
                    this.Close();
                }
            }
        }

        public Add_Edit_ModelForm()  // Для добавления
        {
            InitializeComponent();
            this.Text = "Добавление модели";
            controls.Add(txt_name);
            controls.Add(txt_opis);
            btn_save.Visible = false;
            controls.ForEach(control => control.Click += (sen, ev) =>
            {
                control.BackColor = Color.Black;
                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
            });
        }

        private void AddModel()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                try
                {
                    con.Open();
                    string sql = $@"INSERT INTO public.controller_models(
	                                model_name, description)
	                                VALUES (@model_name, @description);";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@model_name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@description", txt_opis.Text);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch
                {
                    MessageBox.Show("Ошибка запроса к БД", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            UpdateModel();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool HasError = false;
            controls.ForEach(control =>
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    HasError = true;
                    control.BackColor = Color.Red;
                }
            });
            if (HasError)
            {
                MessageBox.Show("Ошибка вывода данных", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                AddModel();
                MessageBox.Show("Модель контроллера успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MainForm main = (MainForm)Application.OpenForms["MainForm"];
                main.ModelController();
            }
        }
    }
}

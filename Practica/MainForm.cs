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
    public partial class MainForm : Form
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public string Role { get; set; }
        public string Fio { get; set; }
        public string Filter = "";
        public string Sort = "";
        public MainForm(string Role, string Fio)
        {
            InitializeComponent();
            this.Role = Role;
            this.Fio = Fio;
            lbl_adm.Text = Role;
            lbl_fio.Text = Fio;
            txt_poisk.TextChanged += (t, e) => Component();
            if (Role == "Инженер")
            {
                panelVisible.Visible = false;
                //ТУТ НАДО ДОПИСАТЬ!
            }
            Component();
        }

        public void Component() //  Комплектующие
            //ДОПИСАТЬ ПОИСК И ПР!!!!!!!!!!!!!!!!!!!!
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT c.id, c.name, c.part_number, ct.type_name,
                              c.manufacturer, c.quantity, c.min_stock, c.price, c.picture
                       FROM public.component c
                       JOIN public.component_type ct ON ct.id = c.type_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();
                        while (reader.Read())
                        {
                            ComponentControl1 component = new ComponentControl1(Role);
                            component.Id = reader.GetInt32(0);
                            component.NameConponent = reader.GetString(1);
                            component.Article = reader.GetString(2);
                            component.Type = reader.GetString(3);
                            component.Proizvoditel = reader.GetString(4);
                            component.Quantity = reader.GetInt32(5);
                            component.MinStock = reader.GetInt32(6);
                            component.Sale = reader.GetDouble(7);
                            component.Photo = reader.IsDBNull(8) ? "picture.jpg" : reader.GetString(8);
                            component.SetLabel();
                            flowLayoutPanel1.Controls.Add(component);
                        }
                    }
                    con.Close();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Component();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autoriz autoriz = new Autoriz();
            autoriz.ShowDialog();
            this.Close();
        }

        private void btn_add_component_Click(object sender, EventArgs e)
        {
            Add_Edit_Component_Formcs add_Edit_Component_Formcs = new Add_Edit_Component_Formcs();
            add_Edit_Component_Formcs.ShowDialog();
        }
        
        public void ModelController()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT id, model_name, description
	                            FROM public.controller_models;";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();
                        while (reader.Read())
                        {
                            ModelCardControl1 modelCardControl1 = new ModelCardControl1(Role);
                            modelCardControl1.Id = reader.GetInt32(0);
                            modelCardControl1.Name = reader.GetString(1);
                            modelCardControl1.Opis = reader.GetString(2);
                            modelCardControl1.SetLabel();
                            flowLayoutPanel1.Controls.Add(modelCardControl1);
                        }
                    }
                    con.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ModelController();
        }

        private void btn_add_model_Click(object sender, EventArgs e)
        {
            Add_Edit_ModelForm add_Edit_ModelForm = new Add_Edit_ModelForm();
            add_Edit_ModelForm.ShowDialog();
        }
    }
}

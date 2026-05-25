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
            }
            Component();
        }

        public void Component() //  Комплектующие
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT c.id, c.name, c.part_number, ct.type_name,
                      c.manufacturer, c.quantity, c.min_stock, c.price, c.picture
               FROM public.component c
               JOIN public.component_type ct ON ct.id = c.type_id
               WHERE (c.name ILIKE '%{txt_poisk.Text}%' 
                   OR c.part_number ILIKE '%{txt_poisk.Text}%' 
                   OR ct.type_name ILIKE '%{txt_poisk.Text}%') AND ('%{Filter}%' IS NULL OR ct.type_name ILIKE '%{Filter}%')
                                ORDER BY c.quantity {Sort}";
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
            if (rad_vozr.Checked == true)
            {
                Sort = "ASC";
                Component();
            }
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
	                            FROM public.controller_models
                                WHERE (model_name ILIKE '%{txt_poisk.Text}%')";
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

        public void Controller()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT c.id, c.serial_number, cm.model_name, c.production_date, c.status
                       FROM public.controllers c
                       JOIN controller_models cm ON c.model_id = cm.id
                        WHERE (c.serial_number ILIKE '%{txt_poisk.Text}%' OR cm.model_name ILIKE '%{txt_poisk.Text}%' OR c.status ILIKE '%{txt_poisk.Text}%')";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();
                        while (reader.Read())
                        {
                            ControllerControl controller = new ControllerControl();
                            controller.Id = reader.GetInt32(0);
                            controller.SerNum = reader.GetString(1);
                            controller.ModelController = reader.GetString(2);
                            controller.DateVipuska = reader.GetDateTime(3);
                            controller.Status = reader.GetString(4);
                            controller.SetLabel();
                            flowLayoutPanel1.Controls.Add(controller);
                        }
                    }
                    con.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Controller();
        }

        public void Fail()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT f.id, c.serial_number, f.failure_date, f.description, f.criticality
	                            FROM public.fail f
	                            JOIN controllers c ON f.controller_id=c.id
                                WHERE (c.serial_number ILIKE '%{txt_poisk.Text}%' OR f.description ILIKE '%{txt_poisk.Text}%' OR f.criticality ILIKE '%{txt_poisk.Text}%')";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();
                        while (reader.Read())
                        {
                            FailControl1 fail = new FailControl1();
                            fail.Id = reader.GetInt32(0);
                            fail.SerNum = reader.GetString(1);
                            fail.DateOtkaza = reader.GetDateTime(2);
                            fail.Opis = reader.GetString(3);
                            fail.Critich = reader.GetString(4);
                            fail.SetLabel();
                            flowLayoutPanel1.Controls.Add(fail);
                        }
                    }
                    con.Close();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Fail();
        }

        private void btn_add_got_controller_Click(object sender, EventArgs e)
        {
            Add_Got_Controller_Form add_Got_Controller_Form = new Add_Got_Controller_Form();
            add_Got_Controller_Form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Repair();
        }

        public void Repair()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT r.id, c.serial_number, r.repair_date, u.fio, r.work_description, r.replaced_components
                FROM public.repairs r
                JOIN public.fail f ON r.fail_id = f.id
                JOIN public.controllers c ON f.controller_id = c.id
                LEFT JOIN public.users u ON r.user_id = u.id
                WHERE (c.serial_number ILIKE '%{txt_poisk.Text}%' OR r.repair_date::text ILIKE '%{txt_poisk.Text}%' OR u.fio ILIKE '%{txt_poisk.Text}%')
                ORDER BY r.repair_date DESC";
                using (var cmd = new NpgsqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    flowLayoutPanel1.Controls.Clear();
                    while (reader.Read())
                    {
                        RepairControl1 repair = new RepairControl1();
                        repair.Id = reader.GetInt32(0);
                        repair.SerNum = reader.GetString(1);
                        repair.DateRepair = reader.GetDateTime(2);
                        repair.Master = reader.IsDBNull(3) ? "Не указан" : reader.GetString(3);
                        repair.Opis = reader.GetString(4);
                        repair.Component = reader.IsDBNull(5) ? "Не указаны" : reader.GetString(5);
                        repair.SetLabel();
                        flowLayoutPanel1.Controls.Add(repair);
                    }
                }
            }
        }

        private void rad_ubiv_CheckedChanged(object sender, EventArgs e)
        {
            if (rad_ubiv.Checked == true)
            {
                Sort = "DESC";
                Component();
            }
        }

        private void cmb_type_name_TextChanged(object sender, EventArgs e)
        {
            if (cmb_type_name.Text == "Все типы")
            {
                Filter = "";
                Component();
            }
            else
            {
                Filter = cmb_type_name.Text;
                Component();
            }
        }
    }
}

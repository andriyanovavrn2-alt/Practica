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
    public partial class Specifikacia_Form : Form
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public string Role { get; set; }
        public int ModelId { get; set; }
        public string ModelName { get; set; }
        public Specifikacia_Form(string role, int modelId, string modelName)
        {
            InitializeComponent();
            Role = role;
            ModelId = modelId;
            ModelName = modelName;
            lbl_name_model.Text = modelName;
            LoadSpecifikacia();
            if (Role == "Инженер")
            {
                btn_dobavit.Visible = false;
                btn_save.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddComponentForm addComponentForm = new AddComponentForm(ModelId);
            addComponentForm.ShowDialog();
            LoadSpecifikacia();
        }

        public void LoadSpecifikacia()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT s.id, c.name, s.quantity_one
                       FROM public.specifikacia s
                       JOIN public.component c ON s.component_id = c.id
                       WHERE s.model_id = @model_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@model_id", ModelId);
                    using (NpgsqlDataReader reader = cmd.ExecuteReader())
                    {
                        flowLayoutPanel1.Controls.Clear();
                        while (reader.Read())
                        {
                            SpecifikaciaControl1 spec = new SpecifikaciaControl1(Role);
                            spec.Id = reader.GetInt32(0);
                            spec.Name = reader.GetString(1);
                            spec.QuantityOne = reader.GetInt32(2);
                            spec.ModelId = ModelId;
                            spec.SetLabel();
                            flowLayoutPanel1.Controls.Add(spec);
                        }
                    }
                    con.Close();
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

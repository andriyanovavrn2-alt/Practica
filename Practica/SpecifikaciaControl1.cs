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
    public partial class SpecifikaciaControl1 : UserControl
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public string Role { get; set; }
        public string Name { get; set; }
        public int QuantityOne { get; set; }
        public int Id { get; set; }
        public int ModelId { get; set; }
        public SpecifikaciaControl1(string role)
        {
            InitializeComponent();
            this.Role = role;
            if (Role == "Инженер")
            {
                btn_del.Visible = false;
                btn_red.Visible = false;
            }
        }

        public void SetLabel()
        {
            lbl_name.Text = "Название компонента: " + Name;
            lbl_quantity_one.Text = "Количество на единицу: " + QuantityOne;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                if (MessageBox.Show($"Удалить компонент \"{Name}\" из спецификации?", "Подтверждение",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string deleteSql = "DELETE FROM public.specifikacia WHERE id = @id";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(deleteSql, con))
                    {
                        cmd.Parameters.AddWithValue("@id", Id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Запись спецификации удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form parentForm = this.FindForm();
                    if (parentForm is Specifikacia_Form specForm)
                        specForm.LoadSpecifikacia();
                    this.Parent.Controls.Remove(this);
                }
            }
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            AddComponentForm addComponentForm = new AddComponentForm(ModelId, Id, Name, QuantityOne);
            addComponentForm.ShowDialog();
            Form parentForm = this.FindForm();
            if (parentForm is Specifikacia_Form specForm)
                specForm.LoadSpecifikacia();
        }
    }
}

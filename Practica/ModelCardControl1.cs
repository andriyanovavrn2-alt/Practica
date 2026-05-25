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
    public partial class ModelCardControl1 : UserControl
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";

        public string Name { get; set; }
        public string Opis { get; set; }
        public int Id { get; set; }
        public string Role { get; set; }
        public ModelCardControl1(string Role)
        {
            InitializeComponent();
            this.Role = Role;
            if (Role == "Инженер")
            {
                btn_red.Visible = false;
                btn_del.Visible = false;
            }
        }
        public void SetLabel()
        {
            lbl_name.Text = "Название модели: " + Name;
            lbl_opis.Text = "Описание: " + Opis;
        }

        private void btn_red_Click(object sender, EventArgs e)
        {
            Add_Edit_ModelForm add_Edit_ModelForm = new Add_Edit_ModelForm(Id);
            add_Edit_ModelForm.ShowDialog();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string proverka = $@"SELECT COUNT(*) FROM public.specifikacia WHERE model_id = @id;";
                using (NpgsqlCommand cmd = new NpgsqlCommand(proverka, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    int orderCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (orderCount > 0)
                    {
                        MessageBox.Show("Невозможно удалить модель контроллера так как она используется в спецификации", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Вы точно хотите удалить модель контроллера?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string delete = $@"DELETE FROM public.controller_models
                                                WHERE id = @id ; ";
                            using (NpgsqlCommand command = new NpgsqlCommand(delete, con))
                            {
                                command.Parameters.AddWithValue("@id", Id);
                                command.ExecuteNonQuery();
                                {
                                    con.Close();
                                }
                                MessageBox.Show("Модель контроллера успешно удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Parent.Controls.Remove(this);
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void btn_spec_Click(object sender, EventArgs e)
        {
            Specifikacia_Form specifikacia_Form = new Specifikacia_Form(Role, Id, Name);
            specifikacia_Form.ShowDialog();
        }
    }
}

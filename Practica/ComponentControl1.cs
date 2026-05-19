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
    public partial class ComponentControl1 : UserControl
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int Id { get; set; }
        public string NameConponent { get; set; }
        public string Article { get; set; }
        public string Type { get; set; }
        public string Proizvoditel { get; set; }
        public int Quantity { get; set; }
        public int MinStock { get; set; }
        public double Sale { get; set; }
        public string Photo { get; set; }
        public string Role { get; set; }

        public ComponentControl1(string Role)
        {
            InitializeComponent();
            this.Role = Role;
            if (Role == "Инженер")
            {
                btn_delete.Visible = false;
                btn_update.Visible = false;
                btn_prihod.Visible = false;
                btn_rashod.Visible = false;
            }
        }

        public void SetLabel()
        {
            lbl_name.Text ="Название: " + NameConponent;
            lbl_art.Text = "Артикул: " + Article;
            lbl_type.Text = "Тип: " + Type;
            lbl_proizvod.Text = "Производитель: " + Proizvoditel;
            lbl_quantity.Text = "Количество на складе: " + Quantity;
            lbl_sale.Text = "Цена\n " + Sale.ToString() + " руб.";
            lbl_minstock.Text = "Минимальный остаток: " + MinStock.ToString();
            if (Quantity == 0)
                lbl_quantity.ForeColor = Color.Red;
            pic_box_component.ImageLocation = Path.Combine(Application.StartupPath, "image") + "\\" + Photo;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Add_Edit_Component_Formcs add_Edit_Component_Formcs = new Add_Edit_Component_Formcs(Id, Photo);
            add_Edit_Component_Formcs.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string proverka = $@"SELECT EXISTS (SELECT 1 FROM public.production_order WHERE component_id = @id)
                            OR EXISTS (SELECT 1 FROM public.specifikacia WHERE component_id = @id)";
                using (NpgsqlCommand cmd = new NpgsqlCommand(proverka, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    int orderCount = Convert.ToInt32(cmd.ExecuteScalar());
                    if (orderCount > 0)
                    {
                        MessageBox.Show("Невозможно удалить компонент: он используется в заказах или спецификациях", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Вы точно хотите удалить компонент?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string delete = $@"DELETE FROM public.component WHERE id = @id";
                            using (NpgsqlCommand command = new NpgsqlCommand(delete, con))
                            {
                                command.Parameters.AddWithValue("@id", Id);
                                command.ExecuteNonQuery();
                                {
                                    con.Close();
                                }
                                MessageBox.Show("Компонент успешно удалён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Parent.Controls.Remove(this);
                                return;
                            }
                        }
                    }
                }
            }
        }

        private void btn_rashod_Click(object sender, EventArgs e)
        {
            Stock_Operation_Formcs stock_Operation_Formcs = new Stock_Operation_Formcs(Id, NameConponent, Quantity, "Расход");
            stock_Operation_Formcs.ShowDialog();
        }

        private void btn_prihod_Click(object sender, EventArgs e)
        {
            Stock_Operation_Formcs stock_Operation_Formcs = new Stock_Operation_Formcs(Id, NameConponent, Quantity, "Приход");
            stock_Operation_Formcs.ShowDialog();
        }
    }
}

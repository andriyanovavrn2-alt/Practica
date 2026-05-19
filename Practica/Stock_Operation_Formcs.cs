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
    public partial class Stock_Operation_Formcs : Form
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int Id { get; set; }
        public string Name { get; set; }
        public int CurrentQuantity { get; set; }
        public string Operation { get; set; }


        public Stock_Operation_Formcs(int Id, string Name, int CurrentQuantity, string Operation)
        {
            InitializeComponent(); 
            this.Id = Id;
            this.Name = Name;
            this.CurrentQuantity = CurrentQuantity;
            this.Operation = Operation;
            num_quantity.Maximum = 100000;
            num_quantity.Minimum = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(num_quantity.Value);
            if(quantity <= 0)
            {
                MessageBox.Show("Количество должно быть больше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int newQuantity = CurrentQuantity;
            if (Operation == "Приход")
                newQuantity = CurrentQuantity + quantity;
            else if (Operation == "Расход")
                newQuantity = CurrentQuantity - quantity;

            if (Operation == "Расход" && newQuantity < 0)
            {
                MessageBox.Show("Недостаточно комплектующих на складе!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = "UPDATE public.component SET quantity = @newQuantity WHERE id = @id";
                using (var cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@newQuantity", newQuantity);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show($"Успешно выполнен {Operation.ToLower()} на {quantity} шт.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            (Application.OpenForms["MainForm"] as MainForm)?.Component();
        }

        private void Stock_Operation_Formcs_Load(object sender, EventArgs e)
        {

        }
    }
}

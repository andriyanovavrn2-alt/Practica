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
    public partial class AddComponentForm : Form
    {
        List<Control> controls = new List<Control>();
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int ModelId { get; set; }
        public int SpecId { get; set; }
        public string OldComponentName { get; set; }
        public int OldQuantity { get; set; }

        public AddComponentForm(int modelId)
        {
            InitializeComponent();
            this.Text = "Добавление комплектующих";
            ModelId = modelId;
            LoadComponents();
            btn_save.Visible = false;
            controls.Add(cmb_name);
            controls.Add(num_quantity);
            num_quantity.Maximum = 100000;
            num_quantity.Minimum = 1;
            num_quantity.Value = 1;
        }

        public AddComponentForm(int modelId, int specId, string componentName, int quantity)
        {
            InitializeComponent();
            this.Text = "Редактирование комплектующих";
            ModelId = modelId;
            SpecId = specId;
            OldComponentName = componentName;
            OldQuantity = quantity;
            LoadComponents();
            btn_add.Visible = false;
            controls.Add(cmb_name);
            controls.Add(num_quantity);
            num_quantity.Maximum = 100000;
            num_quantity.Minimum = 1;
            num_quantity.Value = quantity;
            cmb_name.Text = componentName;
        }

        private void LoadComponents()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = "SELECT id, name FROM public.component ORDER BY name";
                DataTable dt = new DataTable();
                dt.Columns.Add("Id", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                using (var cmd = new NpgsqlCommand(sql, con))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        dt.Rows.Add(reader.GetInt32(0), reader.GetString(1));
                }
                cmb_name.DataSource = dt;
                cmb_name.DisplayMember = "Name";
                cmb_name.ValueMember = "Id";
                cmb_name.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void AddRecord()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                int componentId = (int)cmb_name.SelectedValue;
                int quantity = (int)num_quantity.Value;
                string checkSql = "SELECT COUNT(*) FROM public.specifikacia WHERE model_id = @model_id AND component_id = @component_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(checkSql, con))
                {
                    cmd.Parameters.AddWithValue("@model_id", ModelId);
                    cmd.Parameters.AddWithValue("@component_id", componentId);
                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    if (cnt > 0)
                    {
                        MessageBox.Show("Этот компонент уже добавлен в спецификацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string insertSql = "INSERT INTO public.specifikacia (model_id, component_id, quantity_one) VALUES (@model_id, @component_id, @quantity)";
                using (var cmd = new NpgsqlCommand(insertSql, con))
                {
                    cmd.Parameters.AddWithValue("@model_id", ModelId);
                    cmd.Parameters.AddWithValue("@component_id", componentId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateRecord()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                int componentId = (int)cmb_name.SelectedValue;
                int quantity = (int)num_quantity.Value;
                string checkSql = "SELECT COUNT(*) FROM public.specifikacia WHERE model_id = @model_id AND component_id = @component_id AND id != @spec_id";
                using (var cmd = new NpgsqlCommand(checkSql, con))
                {
                    cmd.Parameters.AddWithValue("@model_id", ModelId);
                    cmd.Parameters.AddWithValue("@component_id", componentId);
                    cmd.Parameters.AddWithValue("@spec_id", SpecId);
                    int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                    if (cnt > 0)
                    {
                        MessageBox.Show("Этот компонент уже добавлен в спецификацию", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string updateSql = "UPDATE public.specifikacia SET component_id = @component_id, quantity_one = @quantity WHERE id = @spec_id";
                using (var cmd = new NpgsqlCommand(updateSql, con))
                {
                    cmd.Parameters.AddWithValue("@component_id", componentId);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@spec_id", SpecId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool HasError = false;
            controls.ForEach(control =>
            {
                if (control is ComboBox cb && cb.SelectedValue == null)
                {
                    HasError = true;
                    control.BackColor = Color.Red;
                }
            });
            if (num_quantity.Value <= 0)
            {
                HasError = true;
                num_quantity.BackColor = Color.Red;
            }
            else
            {
                num_quantity.BackColor = SystemColors.Window;
            }

            if (HasError)
            {
                MessageBox.Show("Выберите компонент и укажите количество больше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    AddRecord();
                    MessageBox.Show("Компонент добавлен в спецификацию", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    (Application.OpenForms["Specifikacia_Form"] as Specifikacia_Form)?.LoadSpecifikacia();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка БД: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            bool HasError = false;
            controls.ForEach(control =>
            {
                if (control is ComboBox cb && cb.SelectedValue == null)
                {
                    HasError = true;
                    control.BackColor = Color.Red;
                }
            });
            if (num_quantity.Value <= 0)
            {
                HasError = true;
                num_quantity.BackColor = Color.Red;
            }
            else
            {
                num_quantity.BackColor = SystemColors.Window;
            }

            if (HasError)
            {
                MessageBox.Show("Выберите компонент и укажите количество больше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                try
                {
                    UpdateRecord();
                    MessageBox.Show("Запись спецификации обновлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    (Application.OpenForms["Specifikacia_Form"] as Specifikacia_Form)?.LoadSpecifikacia();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка БД: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

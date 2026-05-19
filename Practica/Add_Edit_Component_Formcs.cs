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
    public partial class Add_Edit_Component_Formcs : Form
    {
        List<Control> controls = new List<Control>();
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int Id { get; set; }
        public string Photo { get; set; }
        public Add_Edit_Component_Formcs(int id, string photo)  // Для редактирования
        {
            InitializeComponent();
            Id = id;
            Photo = photo;
            LoadComponent();
            btn_add_tov_add.Visible = false;
            num_quantity.Maximum = 100000;
            num_minstock.Maximum = 100000;
            //здесь надо поменять название бортика у формы
        }

        private void LoadComponent()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"SELECT component.part_number, component.name, component_type.type_name, component.manufacturer, component.quantity, component.min_stock, component.price, component.picture
	                            FROM public.component
	                            JOIN component_type ON component_type.id = component.type_id
                                WHERE component.id = @id";
                using (var command = new NpgsqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@id", Id);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txt_art.Text = reader.GetString(0);
                            txt_name.Text = reader.GetString(1);
                            cmb_type.Text = reader.GetString(2);
                            txt_proizv.Text = reader.GetString(3);
                            num_quantity.Value = reader.GetInt32(4);
                            num_minstock.Value = reader.GetInt32(5);
                            mas_sale.Text = reader.GetDecimal(6).ToString();
                            if (string.IsNullOrEmpty(Photo))
                            {
                                string path = Path.Combine(Application.StartupPath, "image") + "\\" + "picture.png";
                                picture_component.Image = Image.FromFile(path);
                            }
                            else
                            {
                                string path = Path.Combine(Application.StartupPath, "image") + "\\" + Photo;
                                picture_component.Image = Image.FromFile(path);
                            }
                        }
                    }
                }
            }
        }

        public void UpdateComponent()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                con.Open();
                string sql = $@"UPDATE public.component
	SET part_number=@part_number, name=@name, type_id=(select id from component_type where type_name = @type_name), manufacturer=@manufacturer, quantity=@quantity, min_stock=@min_stock, price=@price, picture=@picture
	WHERE component.id = @id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.Parameters.AddWithValue("@part_number", txt_art.Text);
                    cmd.Parameters.AddWithValue("@name", txt_name.Text);
                    cmd.Parameters.AddWithValue("@type_name", cmb_type.SelectedItem);
                    cmd.Parameters.AddWithValue("@manufacturer", txt_proizv.Text);
                    cmd.Parameters.AddWithValue("@quantity", num_quantity.Value);
                    cmd.Parameters.AddWithValue("@min_stock", num_minstock.Value);
                    cmd.Parameters.AddWithValue("@price", Convert.ToDecimal(mas_sale.Text));
                    cmd.Parameters.AddWithValue("@picture", Photo);
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Компонент обновлён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
                    mainForm.Component();
                    this.Close();
                }
            }
        }

        public Add_Edit_Component_Formcs()  // Для добавления
        {
            InitializeComponent();
            btn_save_update.Visible = false;
            controls.Add(txt_art);
            controls.Add(txt_name);
            controls.Add(cmb_type);
            controls.Add(txt_proizv);
            controls.Add(num_quantity);
            controls.Add(num_minstock);
            controls.Add(mas_sale);
            num_quantity.Maximum = 100000;
            num_minstock.Maximum = 100000;
            mas_sale.Text = "0";
            controls.ForEach(control => control.Click += (sen, ev) =>
            {
                control.BackColor = Color.Black;
                if (control is MaskedTextBox)
                {
                    ((MaskedTextBox)control).Clear();
                }
            });
        }

        private void AddComponent()
        {
            using (NpgsqlConnection con = new NpgsqlConnection(connectionDB))
            {
                try
                {
                    con.Open();
                    string sql = $@"INSERT INTO public.component(
	part_number, name, type_id, manufacturer, quantity, min_stock, price, picture)
	VALUES (@part_number, @name, (select id from component_type where type_name = @type_name), @manufacturer, @quantity, @min_stock, @price, @picture);";
                    using (NpgsqlCommand cmd = new NpgsqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@part_number", txt_art.Text);
                        cmd.Parameters.AddWithValue("@name", txt_name.Text);
                        cmd.Parameters.AddWithValue("@type_name", cmb_type.SelectedItem);
                        cmd.Parameters.AddWithValue("@manufacturer", txt_proizv.Text);
                        cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(num_quantity.Value));
                        cmd.Parameters.AddWithValue("@min_stock", Convert.ToInt32(num_minstock.Value));
                        cmd.Parameters.AddWithValue("@price", Convert.ToDouble(mas_sale.Text));
                        if (btn_photo.Text == "Загрузить фото")
                        {
                            cmd.Parameters.AddWithValue("@picture", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@picture", btn_photo.Text);
                        }
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

        private void Add_Edit_Component_Formcs_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
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
                AddComponent();
                MessageBox.Show("Компонент успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                MainForm main = (MainForm)Application.OpenForms["MainForm"];
                main.Component();
            }
        }

        private void btn_photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog picture = new OpenFileDialog() { Filter = "image Files| *.jpg; *.png; *.jpg; *tmp" };
            if (picture.ShowDialog() == DialogResult.OK)
            {
                string path = Path.Combine(Path.Combine(Application.StartupPath, "image"), picture.SafeFileName);
                File.Copy(picture.FileName, path, true);
                picture_component.Image?.Dispose();
                picture_component.Image = Image.FromFile(path);
                btn_photo.Text = picture.SafeFileName;
                Photo = btn_photo.Text;
                MessageBox.Show($"Файл успешно загружен!");
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            UpdateComponent();
        }

        private void btn_back_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

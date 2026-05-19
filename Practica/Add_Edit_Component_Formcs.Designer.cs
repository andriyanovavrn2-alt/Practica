namespace Practica
{
    partial class Add_Edit_Component_Formcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Edit_Component_Formcs));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_proizv = new System.Windows.Forms.TextBox();
            this.num_quantity = new System.Windows.Forms.NumericUpDown();
            this.num_minstock = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_add_tov_add = new System.Windows.Forms.Button();
            this.btn_photo = new System.Windows.Forms.Button();
            this.btn_save_update = new System.Windows.Forms.Button();
            this.picture_component = new System.Windows.Forms.PictureBox();
            this.txt_art = new System.Windows.Forms.TextBox();
            this.mas_sale = new System.Windows.Forms.MaskedTextBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_component)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(15, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Артикул";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(15, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Название";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.txt_name.Location = new System.Drawing.Point(167, 80);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(351, 28);
            this.txt_name.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label6.Location = new System.Drawing.Point(15, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "Тип";
            // 
            // cmb_type
            // 
            this.cmb_type.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.cmb_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "Резисторы",
            "Конденсаторы",
            "Микросхемы",
            "Разъёмы",
            "Блоки питания",
            "Реле и оптопары"});
            this.cmb_type.Location = new System.Drawing.Point(167, 124);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(351, 28);
            this.cmb_type.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label7.Location = new System.Drawing.Point(15, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 24);
            this.label7.TabIndex = 21;
            this.label7.Text = "Производитель";
            // 
            // txt_proizv
            // 
            this.txt_proizv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.txt_proizv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proizv.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_proizv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.txt_proizv.Location = new System.Drawing.Point(167, 168);
            this.txt_proizv.Name = "txt_proizv";
            this.txt_proizv.Size = new System.Drawing.Size(351, 28);
            this.txt_proizv.TabIndex = 20;
            // 
            // num_quantity
            // 
            this.num_quantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.num_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.num_quantity.Location = new System.Drawing.Point(247, 234);
            this.num_quantity.Name = "num_quantity";
            this.num_quantity.Size = new System.Drawing.Size(120, 22);
            this.num_quantity.TabIndex = 22;
            // 
            // num_minstock
            // 
            this.num_minstock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.num_minstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.num_minstock.Location = new System.Drawing.Point(247, 271);
            this.num_minstock.Name = "num_minstock";
            this.num_minstock.Size = new System.Drawing.Size(120, 22);
            this.num_minstock.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label8.Location = new System.Drawing.Point(15, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(203, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Количество на складе";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label9.Location = new System.Drawing.Point(15, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Минимальный остаток";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label10.Location = new System.Drawing.Point(15, 308);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 24);
            this.label10.TabIndex = 27;
            this.label10.Text = "Цена";
            // 
            // btn_add_tov_add
            // 
            this.btn_add_tov_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_add_tov_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_tov_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_tov_add.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_tov_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_add_tov_add.Location = new System.Drawing.Point(545, 306);
            this.btn_add_tov_add.Name = "btn_add_tov_add";
            this.btn_add_tov_add.Size = new System.Drawing.Size(117, 50);
            this.btn_add_tov_add.TabIndex = 30;
            this.btn_add_tov_add.Text = "Добавить компонент";
            this.btn_add_tov_add.UseVisualStyleBackColor = false;
            this.btn_add_tov_add.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_photo
            // 
            this.btn_photo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_photo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_photo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_photo.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_photo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_photo.Location = new System.Drawing.Point(686, 306);
            this.btn_photo.Name = "btn_photo";
            this.btn_photo.Size = new System.Drawing.Size(114, 50);
            this.btn_photo.TabIndex = 29;
            this.btn_photo.Text = "Загрузить фото";
            this.btn_photo.UseVisualStyleBackColor = false;
            this.btn_photo.Click += new System.EventHandler(this.btn_photo_Click);
            // 
            // btn_save_update
            // 
            this.btn_save_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_save_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save_update.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_save_update.Location = new System.Drawing.Point(689, 375);
            this.btn_save_update.Name = "btn_save_update";
            this.btn_save_update.Size = new System.Drawing.Size(114, 54);
            this.btn_save_update.TabIndex = 31;
            this.btn_save_update.Text = "Сохранить изменения";
            this.btn_save_update.UseVisualStyleBackColor = false;
            this.btn_save_update.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // picture_component
            // 
            this.picture_component.Image = global::Practica.Properties.Resources.picture;
            this.picture_component.Location = new System.Drawing.Point(545, 35);
            this.picture_component.Name = "picture_component";
            this.picture_component.Size = new System.Drawing.Size(255, 255);
            this.picture_component.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_component.TabIndex = 28;
            this.picture_component.TabStop = false;
            this.picture_component.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // txt_art
            // 
            this.txt_art.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.txt_art.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_art.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_art.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.txt_art.Location = new System.Drawing.Point(167, 35);
            this.txt_art.Name = "txt_art";
            this.txt_art.Size = new System.Drawing.Size(351, 28);
            this.txt_art.TabIndex = 13;
            // 
            // mas_sale
            // 
            this.mas_sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.mas_sale.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mas_sale.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.mas_sale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.mas_sale.Location = new System.Drawing.Point(247, 311);
            this.mas_sale.Name = "mas_sale";
            this.mas_sale.Size = new System.Drawing.Size(120, 21);
            this.mas_sale.TabIndex = 32;
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_back.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_back.Location = new System.Drawing.Point(12, 396);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(114, 33);
            this.btn_back.TabIndex = 38;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // Add_Edit_Component_Formcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(812, 438);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.mas_sale);
            this.Controls.Add(this.btn_save_update);
            this.Controls.Add(this.btn_add_tov_add);
            this.Controls.Add(this.btn_photo);
            this.Controls.Add(this.picture_component);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.num_minstock);
            this.Controls.Add(this.num_quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_proizv);
            this.Controls.Add(this.cmb_type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_art);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_Edit_Component_Formcs";
            this.Text = "Добавление/редактирование комплектующих";
            this.Load += new System.EventHandler(this.Add_Edit_Component_Formcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_minstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_component)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_proizv;
        private System.Windows.Forms.NumericUpDown num_quantity;
        private System.Windows.Forms.NumericUpDown num_minstock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picture_component;
        private System.Windows.Forms.Button btn_add_tov_add;
        private System.Windows.Forms.Button btn_photo;
        private System.Windows.Forms.Button btn_save_update;
        private System.Windows.Forms.TextBox txt_art;
        private System.Windows.Forms.MaskedTextBox mas_sale;
        private System.Windows.Forms.Button btn_back;
    }
}
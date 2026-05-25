namespace Practica
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl_fio = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_adm = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txt_poisk = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_type_name = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rad_vozr = new System.Windows.Forms.RadioButton();
            this.rad_ubiv = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_add_component = new System.Windows.Forms.Button();
            this.btn_add_model = new System.Windows.Forms.Button();
            this.btn_add_got_controller = new System.Windows.Forms.Button();
            this.panelVisible = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelVisible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_fio
            // 
            this.lbl_fio.AutoSize = true;
            this.lbl_fio.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_fio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_fio.Location = new System.Drawing.Point(12, 108);
            this.lbl_fio.Name = "lbl_fio";
            this.lbl_fio.Size = new System.Drawing.Size(355, 40);
            this.lbl_fio.TabIndex = 6;
            this.lbl_fio.Text = "Фамилия Имя Отчество";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 152);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1032, 549);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // lbl_adm
            // 
            this.lbl_adm.AutoSize = true;
            this.lbl_adm.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_adm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_adm.Location = new System.Drawing.Point(632, 108);
            this.lbl_adm.Name = "lbl_adm";
            this.lbl_adm.Size = new System.Drawing.Size(85, 40);
            this.lbl_adm.TabIndex = 8;
            this.lbl_adm.Text = "Роль";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button1.Location = new System.Drawing.Point(1057, 386);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Комплектующие";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button2.Location = new System.Drawing.Point(1057, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(233, 33);
            this.button2.TabIndex = 10;
            this.button2.Text = "Модели контроллеров";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button4.Location = new System.Drawing.Point(1057, 487);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(233, 33);
            this.button4.TabIndex = 12;
            this.button4.Text = "Готовые контроллеры";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button5.Location = new System.Drawing.Point(1057, 536);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(233, 33);
            this.button5.TabIndex = 13;
            this.button5.Text = "Ремонты";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button6.Location = new System.Drawing.Point(1055, 668);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(233, 33);
            this.button6.TabIndex = 14;
            this.button6.Text = "Назад";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txt_poisk
            // 
            this.txt_poisk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.txt_poisk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_poisk.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_poisk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.txt_poisk.Location = new System.Drawing.Point(1055, 152);
            this.txt_poisk.Name = "txt_poisk";
            this.txt_poisk.Size = new System.Drawing.Size(233, 28);
            this.txt_poisk.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(1052, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Поиск";
            // 
            // cmb_type_name
            // 
            this.cmb_type_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.cmb_type_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_type_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_type_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_type_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.cmb_type_name.FormattingEnabled = true;
            this.cmb_type_name.Items.AddRange(new object[] {
            "Все типы",
            "Резисторы",
            "Конденсаторы",
            "Микросхемы",
            "Разъёмы",
            "Блоки питания",
            "Реле и оптопары"});
            this.cmb_type_name.Location = new System.Drawing.Point(1055, 224);
            this.cmb_type_name.Name = "cmb_type_name";
            this.cmb_type_name.Size = new System.Drawing.Size(232, 28);
            this.cmb_type_name.TabIndex = 17;
            this.cmb_type_name.Text = "Все типы";
            this.cmb_type_name.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.cmb_type_name.TextChanged += new System.EventHandler(this.cmb_type_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(1050, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Тип комплектующих";
            // 
            // rad_vozr
            // 
            this.rad_vozr.AutoSize = true;
            this.rad_vozr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad_vozr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rad_vozr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.rad_vozr.Location = new System.Drawing.Point(1055, 268);
            this.rad_vozr.Name = "rad_vozr";
            this.rad_vozr.Size = new System.Drawing.Size(239, 52);
            this.rad_vozr.TabIndex = 19;
            this.rad_vozr.Text = "По возрастанию \r\nостатка комплектующих";
            this.rad_vozr.UseVisualStyleBackColor = true;
            this.rad_vozr.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rad_ubiv
            // 
            this.rad_ubiv.AutoSize = true;
            this.rad_ubiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rad_ubiv.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rad_ubiv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.rad_ubiv.Location = new System.Drawing.Point(1055, 327);
            this.rad_ubiv.Name = "rad_ubiv";
            this.rad_ubiv.Size = new System.Drawing.Size(239, 52);
            this.rad_ubiv.TabIndex = 20;
            this.rad_ubiv.Text = "По убыванию \r\nостатка комплектующих";
            this.rad_ubiv.UseVisualStyleBackColor = true;
            this.rad_ubiv.CheckedChanged += new System.EventHandler(this.rad_ubiv_CheckedChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button7.Location = new System.Drawing.Point(1055, 587);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(233, 33);
            this.button7.TabIndex = 21;
            this.button7.Text = "Отказы";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_add_component
            // 
            this.btn_add_component.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_add_component.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_component.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_component.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_component.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_add_component.Location = new System.Drawing.Point(3, 4);
            this.btn_add_component.Name = "btn_add_component";
            this.btn_add_component.Size = new System.Drawing.Size(40, 33);
            this.btn_add_component.TabIndex = 22;
            this.btn_add_component.Text = "+";
            this.btn_add_component.UseVisualStyleBackColor = false;
            this.btn_add_component.Click += new System.EventHandler(this.btn_add_component_Click);
            // 
            // btn_add_model
            // 
            this.btn_add_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_add_model.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_model.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_model.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_add_model.Location = new System.Drawing.Point(3, 53);
            this.btn_add_model.Name = "btn_add_model";
            this.btn_add_model.Size = new System.Drawing.Size(40, 33);
            this.btn_add_model.TabIndex = 23;
            this.btn_add_model.Text = "+";
            this.btn_add_model.UseVisualStyleBackColor = false;
            this.btn_add_model.Click += new System.EventHandler(this.btn_add_model_Click);
            // 
            // btn_add_got_controller
            // 
            this.btn_add_got_controller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_add_got_controller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_got_controller.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add_got_controller.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_add_got_controller.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_add_got_controller.Location = new System.Drawing.Point(3, 105);
            this.btn_add_got_controller.Name = "btn_add_got_controller";
            this.btn_add_got_controller.Size = new System.Drawing.Size(40, 33);
            this.btn_add_got_controller.TabIndex = 26;
            this.btn_add_got_controller.Text = "+";
            this.btn_add_got_controller.UseVisualStyleBackColor = false;
            this.btn_add_got_controller.Click += new System.EventHandler(this.btn_add_got_controller_Click);
            // 
            // panelVisible
            // 
            this.panelVisible.Controls.Add(this.btn_add_component);
            this.panelVisible.Controls.Add(this.btn_add_got_controller);
            this.panelVisible.Controls.Add(this.btn_add_model);
            this.panelVisible.Location = new System.Drawing.Point(1296, 382);
            this.panelVisible.Name = "panelVisible";
            this.panelVisible.Size = new System.Drawing.Size(46, 249);
            this.panelVisible.TabIndex = 28;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica.Properties.Resources.bazis;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1353, 713);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.rad_ubiv);
            this.Controls.Add(this.rad_vozr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_type_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_poisk);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_adm);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_fio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelVisible);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Главная форма";
            this.panelVisible.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_fio;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbl_adm;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox txt_poisk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_type_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rad_vozr;
        private System.Windows.Forms.RadioButton rad_ubiv;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_add_component;
        private System.Windows.Forms.Button btn_add_model;
        private System.Windows.Forms.Button btn_add_got_controller;
        private System.Windows.Forms.Panel panelVisible;
    }
}
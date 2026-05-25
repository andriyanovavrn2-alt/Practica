namespace Practica
{
    partial class RepairForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepairForm));
            this.lbl_ser_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_opis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_master = new System.Windows.Forms.ComboBox();
            this.lbl_zamen_compl = new System.Windows.Forms.Label();
            this.txt_zam_compon = new System.Windows.Forms.TextBox();
            this.dtp_repair = new System.Windows.Forms.DateTimePicker();
            this.lbl_date_fail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ser_num
            // 
            this.lbl_ser_num.AutoSize = true;
            this.lbl_ser_num.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ser_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_ser_num.Location = new System.Drawing.Point(12, 9);
            this.lbl_ser_num.Name = "lbl_ser_num";
            this.lbl_ser_num.Size = new System.Drawing.Size(227, 35);
            this.lbl_ser_num.TabIndex = 44;
            this.lbl_ser_num.Text = "Серийный номер";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label1.Location = new System.Drawing.Point(14, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Дата отказа";
            // 
            // txt_opis
            // 
            this.txt_opis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.txt_opis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_opis.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_opis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.txt_opis.Location = new System.Drawing.Point(176, 228);
            this.txt_opis.Multiline = true;
            this.txt_opis.Name = "txt_opis";
            this.txt_opis.Size = new System.Drawing.Size(289, 126);
            this.txt_opis.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label3.Location = new System.Drawing.Point(14, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 48);
            this.label3.TabIndex = 49;
            this.label3.Text = "Описание\r\nнеисправности";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label4.Location = new System.Drawing.Point(14, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Дата ремонта";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button3.Location = new System.Drawing.Point(351, 521);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 33);
            this.button3.TabIndex = 53;
            this.button3.Text = "Назад";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button1.Location = new System.Drawing.Point(231, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 33);
            this.button1.TabIndex = 52;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.label5.Location = new System.Drawing.Point(14, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 54;
            this.label5.Text = "Мастер";
            // 
            // cmb_master
            // 
            this.cmb_master.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.cmb_master.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_master.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_master.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_master.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.cmb_master.FormattingEnabled = true;
            this.cmb_master.Items.AddRange(new object[] {
            "Резисторы",
            "Конденсаторы",
            "Микросхемы",
            "Разъёмы",
            "Блоки питания",
            "Реле и оптопары"});
            this.cmb_master.Location = new System.Drawing.Point(176, 176);
            this.cmb_master.Name = "cmb_master";
            this.cmb_master.Size = new System.Drawing.Size(289, 28);
            this.cmb_master.TabIndex = 55;
            // 
            // lbl_zamen_compl
            // 
            this.lbl_zamen_compl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_zamen_compl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_zamen_compl.Location = new System.Drawing.Point(14, 375);
            this.lbl_zamen_compl.Name = "lbl_zamen_compl";
            this.lbl_zamen_compl.Size = new System.Drawing.Size(158, 58);
            this.lbl_zamen_compl.TabIndex = 56;
            this.lbl_zamen_compl.Text = "Заменённые \r\nкомплектующие";
            // 
            // txt_zam_compon
            // 
            this.txt_zam_compon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.txt_zam_compon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_zam_compon.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_zam_compon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.txt_zam_compon.Location = new System.Drawing.Point(178, 360);
            this.txt_zam_compon.Multiline = true;
            this.txt_zam_compon.Name = "txt_zam_compon";
            this.txt_zam_compon.Size = new System.Drawing.Size(289, 126);
            this.txt_zam_compon.TabIndex = 57;
            // 
            // dtp_repair
            // 
            this.dtp_repair.Location = new System.Drawing.Point(176, 125);
            this.dtp_repair.Name = "dtp_repair";
            this.dtp_repair.Size = new System.Drawing.Size(289, 22);
            this.dtp_repair.TabIndex = 58;
            // 
            // lbl_date_fail
            // 
            this.lbl_date_fail.AutoSize = true;
            this.lbl_date_fail.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_date_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_date_fail.Location = new System.Drawing.Point(174, 76);
            this.lbl_date_fail.Name = "lbl_date_fail";
            this.lbl_date_fail.Size = new System.Drawing.Size(0, 24);
            this.lbl_date_fail.TabIndex = 59;
            // 
            // RepairForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(525, 566);
            this.Controls.Add(this.lbl_date_fail);
            this.Controls.Add(this.dtp_repair);
            this.Controls.Add(this.txt_zam_compon);
            this.Controls.Add(this.lbl_zamen_compl);
            this.Controls.Add(this.cmb_master);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_opis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_ser_num);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RepairForm";
            this.Text = "Выполнение ремонта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ser_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_opis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_master;
        private System.Windows.Forms.Label lbl_zamen_compl;
        private System.Windows.Forms.TextBox txt_zam_compon;
        private System.Windows.Forms.DateTimePicker dtp_repair;
        private System.Windows.Forms.Label lbl_date_fail;
    }
}
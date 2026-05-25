namespace Practica
{
    partial class FailControl1
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_repair = new System.Windows.Forms.Button();
            this.lbl_critich = new System.Windows.Forms.Label();
            this.lbl_opis = new System.Windows.Forms.Label();
            this.lbl_date_otk = new System.Windows.Forms.Label();
            this.lbl_ser_num = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_repair);
            this.panel1.Controls.Add(this.lbl_critich);
            this.panel1.Controls.Add(this.lbl_opis);
            this.panel1.Controls.Add(this.lbl_date_otk);
            this.panel1.Controls.Add(this.lbl_ser_num);
            this.panel1.Location = new System.Drawing.Point(33, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 181);
            this.panel1.TabIndex = 23;
            // 
            // btn_repair
            // 
            this.btn_repair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_repair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_repair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_repair.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_repair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_repair.Location = new System.Drawing.Point(784, 111);
            this.btn_repair.Name = "btn_repair";
            this.btn_repair.Size = new System.Drawing.Size(148, 33);
            this.btn_repair.TabIndex = 22;
            this.btn_repair.Text = "Выполнить ремонт";
            this.btn_repair.UseVisualStyleBackColor = false;
            this.btn_repair.Click += new System.EventHandler(this.btn_repair_Click);
            // 
            // lbl_critich
            // 
            this.lbl_critich.AutoSize = true;
            this.lbl_critich.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_critich.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_critich.Location = new System.Drawing.Point(57, 144);
            this.lbl_critich.Name = "lbl_critich";
            this.lbl_critich.Size = new System.Drawing.Size(123, 24);
            this.lbl_critich.TabIndex = 20;
            this.lbl_critich.Text = "Критичность ";
            // 
            // lbl_opis
            // 
            this.lbl_opis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_opis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_opis.Location = new System.Drawing.Point(57, 84);
            this.lbl_opis.Name = "lbl_opis";
            this.lbl_opis.Size = new System.Drawing.Size(574, 60);
            this.lbl_opis.TabIndex = 19;
            this.lbl_opis.Text = "Описание ";
            // 
            // lbl_date_otk
            // 
            this.lbl_date_otk.AutoSize = true;
            this.lbl_date_otk.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_date_otk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_date_otk.Location = new System.Drawing.Point(56, 45);
            this.lbl_date_otk.Name = "lbl_date_otk";
            this.lbl_date_otk.Size = new System.Drawing.Size(112, 24);
            this.lbl_date_otk.TabIndex = 18;
            this.lbl_date_otk.Text = "Дата отказа";
            // 
            // lbl_ser_num
            // 
            this.lbl_ser_num.AutoSize = true;
            this.lbl_ser_num.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ser_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_ser_num.Location = new System.Drawing.Point(56, 9);
            this.lbl_ser_num.Name = "lbl_ser_num";
            this.lbl_ser_num.Size = new System.Drawing.Size(162, 24);
            this.lbl_ser_num.TabIndex = 17;
            this.lbl_ser_num.Text = "Серийный номер";
            // 
            // FailControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel1);
            this.Name = "FailControl1";
            this.Size = new System.Drawing.Size(1029, 199);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_repair;
        private System.Windows.Forms.Label lbl_critich;
        private System.Windows.Forms.Label lbl_opis;
        private System.Windows.Forms.Label lbl_date_otk;
        private System.Windows.Forms.Label lbl_ser_num;
    }
}

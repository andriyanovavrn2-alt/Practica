namespace Practica
{
    partial class RepairControl1
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
            this.lbl_master = new System.Windows.Forms.Label();
            this.lbl_zamen_compl = new System.Windows.Forms.Label();
            this.lbl_opis = new System.Windows.Forms.Label();
            this.lbl_date_repair = new System.Windows.Forms.Label();
            this.lbl_ser_num = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbl_master);
            this.panel1.Controls.Add(this.lbl_zamen_compl);
            this.panel1.Controls.Add(this.lbl_opis);
            this.panel1.Controls.Add(this.lbl_date_repair);
            this.panel1.Controls.Add(this.lbl_ser_num);
            this.panel1.Location = new System.Drawing.Point(23, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(986, 240);
            this.panel1.TabIndex = 24;
            // 
            // lbl_master
            // 
            this.lbl_master.AutoSize = true;
            this.lbl_master.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_master.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_master.Location = new System.Drawing.Point(8, 78);
            this.lbl_master.Name = "lbl_master";
            this.lbl_master.Size = new System.Drawing.Size(74, 24);
            this.lbl_master.TabIndex = 26;
            this.lbl_master.Text = "Мастер";
            // 
            // lbl_zamen_compl
            // 
            this.lbl_zamen_compl.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_zamen_compl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_zamen_compl.Location = new System.Drawing.Point(8, 174);
            this.lbl_zamen_compl.Name = "lbl_zamen_compl";
            this.lbl_zamen_compl.Size = new System.Drawing.Size(789, 44);
            this.lbl_zamen_compl.TabIndex = 20;
            this.lbl_zamen_compl.Text = "Заменённые комплектующие";
            // 
            // lbl_opis
            // 
            this.lbl_opis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_opis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_opis.Location = new System.Drawing.Point(8, 113);
            this.lbl_opis.Name = "lbl_opis";
            this.lbl_opis.Size = new System.Drawing.Size(789, 61);
            this.lbl_opis.TabIndex = 19;
            this.lbl_opis.Text = "Описание ";
            // 
            // lbl_date_repair
            // 
            this.lbl_date_repair.AutoSize = true;
            this.lbl_date_repair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_date_repair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_date_repair.Location = new System.Drawing.Point(8, 44);
            this.lbl_date_repair.Name = "lbl_date_repair";
            this.lbl_date_repair.Size = new System.Drawing.Size(131, 24);
            this.lbl_date_repair.TabIndex = 18;
            this.lbl_date_repair.Text = "Дата ремонта";
            // 
            // lbl_ser_num
            // 
            this.lbl_ser_num.AutoSize = true;
            this.lbl_ser_num.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ser_num.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_ser_num.Location = new System.Drawing.Point(8, 8);
            this.lbl_ser_num.Name = "lbl_ser_num";
            this.lbl_ser_num.Size = new System.Drawing.Size(162, 24);
            this.lbl_ser_num.TabIndex = 17;
            this.lbl_ser_num.Text = "Серийный номер";
            // 
            // RepairControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel1);
            this.Name = "RepairControl1";
            this.Size = new System.Drawing.Size(1029, 270);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_opis;
        private System.Windows.Forms.Label lbl_date_repair;
        private System.Windows.Forms.Label lbl_ser_num;
        private System.Windows.Forms.Label lbl_zamen_compl;
        private System.Windows.Forms.Label lbl_master;
    }
}

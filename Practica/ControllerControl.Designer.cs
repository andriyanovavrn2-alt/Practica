namespace Practica
{
    partial class ControllerControl
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
            this.btn_fail = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_date_vipuska = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_ser_num = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_fail);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.lbl_date_vipuska);
            this.panel1.Controls.Add(this.lbl_model);
            this.panel1.Controls.Add(this.lbl_ser_num);
            this.panel1.Location = new System.Drawing.Point(47, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 154);
            this.panel1.TabIndex = 22;
            // 
            // btn_fail
            // 
            this.btn_fail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_fail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fail.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_fail.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_fail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_fail.Location = new System.Drawing.Point(718, 106);
            this.btn_fail.Name = "btn_fail";
            this.btn_fail.Size = new System.Drawing.Size(198, 33);
            this.btn_fail.TabIndex = 22;
            this.btn_fail.Text = "Зарегистрировать отказ";
            this.btn_fail.UseVisualStyleBackColor = false;
            this.btn_fail.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_status.Location = new System.Drawing.Point(9, 115);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(69, 24);
            this.lbl_status.TabIndex = 20;
            this.lbl_status.Text = "Статус ";
            // 
            // lbl_date_vipuska
            // 
            this.lbl_date_vipuska.AutoSize = true;
            this.lbl_date_vipuska.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_date_vipuska.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_date_vipuska.Location = new System.Drawing.Point(9, 83);
            this.lbl_date_vipuska.Name = "lbl_date_vipuska";
            this.lbl_date_vipuska.Size = new System.Drawing.Size(128, 24);
            this.lbl_date_vipuska.TabIndex = 19;
            this.lbl_date_vipuska.Text = "Дата выпуска";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_model.Location = new System.Drawing.Point(8, 44);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(81, 24);
            this.lbl_model.TabIndex = 18;
            this.lbl_model.Text = "Модель";
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
            // ControllerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel1);
            this.Name = "ControllerControl";
            this.Size = new System.Drawing.Size(1029, 172);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_fail;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_date_vipuska;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_ser_num;
    }
}

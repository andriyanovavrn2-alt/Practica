namespace Practica
{
    partial class ModelCardControl1
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
            this.btn_spec = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.btn_del = new System.Windows.Forms.Button();
            this.lbl_opis = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_spec);
            this.panel1.Controls.Add(this.btn_red);
            this.panel1.Controls.Add(this.btn_del);
            this.panel1.Controls.Add(this.lbl_opis);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(20, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 194);
            this.panel1.TabIndex = 24;
            // 
            // btn_spec
            // 
            this.btn_spec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_spec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_spec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_spec.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_spec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_spec.Location = new System.Drawing.Point(857, 146);
            this.btn_spec.Name = "btn_spec";
            this.btn_spec.Size = new System.Drawing.Size(114, 33);
            this.btn_spec.TabIndex = 16;
            this.btn_spec.Text = "Спецификация";
            this.btn_spec.UseVisualStyleBackColor = false;
            this.btn_spec.Click += new System.EventHandler(this.btn_spec_Click);
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_red.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_red.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_red.Location = new System.Drawing.Point(857, 68);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(114, 33);
            this.btn_red.TabIndex = 15;
            this.btn_red.Text = "Редактировать";
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_del.Location = new System.Drawing.Point(857, 107);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(114, 33);
            this.btn_del.TabIndex = 13;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // lbl_opis
            // 
            this.lbl_opis.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_opis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_opis.Location = new System.Drawing.Point(17, 70);
            this.lbl_opis.Name = "lbl_opis";
            this.lbl_opis.Size = new System.Drawing.Size(798, 103);
            this.lbl_opis.TabIndex = 7;
            this.lbl_opis.Text = "Описание";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_name.Location = new System.Drawing.Point(47, 22);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(233, 35);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Название модели";
            // 
            // ModelCardControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.panel1);
            this.Name = "ModelCardControl1";
            this.Size = new System.Drawing.Size(1029, 231);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label lbl_opis;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_spec;
    }
}

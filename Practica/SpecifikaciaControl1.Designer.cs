namespace Practica
{
    partial class SpecifikaciaControl1
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
            this.lbl_quantity_one = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_quantity_one
            // 
            this.lbl_quantity_one.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_quantity_one.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_quantity_one.Location = new System.Drawing.Point(12, 48);
            this.lbl_quantity_one.Name = "lbl_quantity_one";
            this.lbl_quantity_one.Size = new System.Drawing.Size(382, 41);
            this.lbl_quantity_one.TabIndex = 9;
            this.lbl_quantity_one.Text = "Количество на единицу";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_name.Location = new System.Drawing.Point(12, 15);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(79, 21);
            this.lbl_name.TabIndex = 8;
            this.lbl_name.Text = "Название";
            // 
            // btn_del
            // 
            this.btn_del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_del.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_del.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_del.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_del.Location = new System.Drawing.Point(647, 56);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(114, 33);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "Удалить";
            this.btn_del.UseVisualStyleBackColor = false;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_red.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_red.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_red.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_red.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_red.Location = new System.Drawing.Point(647, 17);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(114, 33);
            this.btn_red.TabIndex = 15;
            this.btn_red.Text = "Редактировать";
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // SpecifikaciaControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.Controls.Add(this.btn_red);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.lbl_quantity_one);
            this.Controls.Add(this.lbl_name);
            this.Name = "SpecifikaciaControl1";
            this.Size = new System.Drawing.Size(774, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_quantity_one;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Button btn_red;
    }
}

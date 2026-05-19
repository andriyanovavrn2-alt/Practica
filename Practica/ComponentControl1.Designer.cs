namespace Practica
{
    partial class ComponentControl1
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
            this.btn_prihod = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_rashod = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_minstock = new System.Windows.Forms.Label();
            this.lbl_quantity = new System.Windows.Forms.Label();
            this.lbl_proizvod = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_art = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_sale = new System.Windows.Forms.Label();
            this.pic_box_component = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_component)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_prihod);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_rashod);
            this.panel1.Controls.Add(this.btn_delete);
            this.panel1.Controls.Add(this.lbl_minstock);
            this.panel1.Controls.Add(this.lbl_quantity);
            this.panel1.Controls.Add(this.lbl_proizvod);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.lbl_art);
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Location = new System.Drawing.Point(234, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 224);
            this.panel1.TabIndex = 1;
            // 
            // btn_prihod
            // 
            this.btn_prihod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_prihod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prihod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_prihod.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_prihod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_prihod.Location = new System.Drawing.Point(379, 181);
            this.btn_prihod.Name = "btn_prihod";
            this.btn_prihod.Size = new System.Drawing.Size(114, 33);
            this.btn_prihod.TabIndex = 16;
            this.btn_prihod.Text = "Приход";
            this.btn_prihod.UseVisualStyleBackColor = false;
            this.btn_prihod.Click += new System.EventHandler(this.btn_prihod_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_update.Location = new System.Drawing.Point(499, 142);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(114, 33);
            this.btn_update.TabIndex = 15;
            this.btn_update.Text = "Редактировать";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_rashod
            // 
            this.btn_rashod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_rashod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rashod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rashod.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rashod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_rashod.Location = new System.Drawing.Point(379, 142);
            this.btn_rashod.Name = "btn_rashod";
            this.btn_rashod.Size = new System.Drawing.Size(114, 33);
            this.btn_rashod.TabIndex = 14;
            this.btn_rashod.Text = "Расход";
            this.btn_rashod.UseVisualStyleBackColor = false;
            this.btn_rashod.Click += new System.EventHandler(this.btn_rashod_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(132)))), ((int)(((byte)(132)))));
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btn_delete.Location = new System.Drawing.Point(499, 181);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(114, 33);
            this.btn_delete.TabIndex = 13;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_minstock
            // 
            this.lbl_minstock.AutoSize = true;
            this.lbl_minstock.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_minstock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_minstock.Location = new System.Drawing.Point(8, 190);
            this.lbl_minstock.Name = "lbl_minstock";
            this.lbl_minstock.Size = new System.Drawing.Size(208, 24);
            this.lbl_minstock.TabIndex = 11;
            this.lbl_minstock.Text = "Минимальный остаток";
            this.lbl_minstock.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbl_quantity
            // 
            this.lbl_quantity.AutoSize = true;
            this.lbl_quantity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_quantity.Location = new System.Drawing.Point(8, 151);
            this.lbl_quantity.Name = "lbl_quantity";
            this.lbl_quantity.Size = new System.Drawing.Size(198, 24);
            this.lbl_quantity.TabIndex = 10;
            this.lbl_quantity.Text = "Количество на складе";
            // 
            // lbl_proizvod
            // 
            this.lbl_proizvod.AutoSize = true;
            this.lbl_proizvod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_proizvod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_proizvod.Location = new System.Drawing.Point(8, 113);
            this.lbl_proizvod.Name = "lbl_proizvod";
            this.lbl_proizvod.Size = new System.Drawing.Size(142, 24);
            this.lbl_proizvod.TabIndex = 9;
            this.lbl_proizvod.Text = "Производитель";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_type.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_type.Location = new System.Drawing.Point(8, 76);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(40, 24);
            this.lbl_type.TabIndex = 8;
            this.lbl_type.Text = "Тип";
            // 
            // lbl_art
            // 
            this.lbl_art.AutoSize = true;
            this.lbl_art.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_art.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_art.Location = new System.Drawing.Point(8, 42);
            this.lbl_art.Name = "lbl_art";
            this.lbl_art.Size = new System.Drawing.Size(79, 24);
            this.lbl_art.TabIndex = 7;
            this.lbl_art.Text = "Артикул";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_name.Location = new System.Drawing.Point(8, 9);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(94, 24);
            this.lbl_name.TabIndex = 6;
            this.lbl_name.Text = "Название";
            // 
            // lbl_sale
            // 
            this.lbl_sale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(16)))));
            this.lbl_sale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_sale.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_sale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(17)))));
            this.lbl_sale.Location = new System.Drawing.Point(871, 4);
            this.lbl_sale.Name = "lbl_sale";
            this.lbl_sale.Size = new System.Drawing.Size(147, 224);
            this.lbl_sale.TabIndex = 17;
            this.lbl_sale.Text = "Цена";
            this.lbl_sale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_box_component
            // 
            this.pic_box_component.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_box_component.Location = new System.Drawing.Point(4, 4);
            this.pic_box_component.Name = "pic_box_component";
            this.pic_box_component.Size = new System.Drawing.Size(224, 224);
            this.pic_box_component.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_box_component.TabIndex = 0;
            this.pic_box_component.TabStop = false;
            // 
            // ComponentControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(39)))), ((int)(((byte)(45)))));
            this.Controls.Add(this.lbl_sale);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_box_component);
            this.Name = "ComponentControl1";
            this.Size = new System.Drawing.Size(1023, 231);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_box_component)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_box_component;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_minstock;
        private System.Windows.Forms.Label lbl_quantity;
        private System.Windows.Forms.Label lbl_proizvod;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_art;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_prihod;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_rashod;
        private System.Windows.Forms.Label lbl_sale;
    }
}

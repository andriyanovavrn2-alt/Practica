using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class ControllerControl : UserControl
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int Id { get; set; }
        public string SerNum { get; set; }
        public string ModelController { get; set; }
        public DateTime DateVipuska { get; set; }
        public string Status { get; set; }
        public ControllerControl()
        {
            InitializeComponent();
        }

        public void SetLabel()
        {
            lbl_ser_num.Text = "Серийный номер: "+SerNum;
            lbl_model.Text = "Модель: "+ModelController;
            lbl_date_vipuska.Text = "Дата выпуска: "+DateVipuska.ToString("dd.MM.yyyy");
            lbl_status.Text = "Статус: "+Status;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            FailForm failForm = new FailForm(Id, SerNum, ModelController);
            failForm.ShowDialog();
            (this.FindForm() as MainForm)?.Controller();
        }
    }
}

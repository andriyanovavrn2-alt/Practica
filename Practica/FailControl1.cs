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
    public partial class FailControl1 : UserControl
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int Id { get; set; }
        public string SerNum{ get; set; }
        public DateTime DateOtkaza { get; set; }
        public string Opis { get; set; }
        public string Critich { get; set; }

        public FailControl1()
        {
            InitializeComponent();
        }
        public void SetLabel()
        {
            lbl_ser_num.Text = "Серийный номер: " + SerNum;
            lbl_date_otk.Text = "Дата отказа: " + DateOtkaza.ToString("dd.MM.yyyy");
            lbl_opis.Text = "Описание: " + Opis;
            lbl_critich.Text = "Критичность: "+Critich;
        }

        private void btn_repair_Click(object sender, EventArgs e)
        {
            RepairForm repairForm = new RepairForm(Id, SerNum, DateOtkaza, Opis);
            repairForm.ShowDialog();
        }
    }
}

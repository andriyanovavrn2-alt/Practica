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
    public partial class RepairControl1 : UserControl
    {
        string connectionDB = "Host = localhost; Username = postgres; Password = 123; Port = 5432; Database = CONTROLLERS";
        public int Id { get; set; }
        public string SerNum { get; set; }
        public DateTime DateRepair { get; set; }
        public string Master { get; set; }
        public string Opis { get; set; }
        public string Component { get; set; }
        public RepairControl1()
        {
            InitializeComponent();
        }
        public void SetLabel()
        {
            lbl_ser_num.Text = "Серийный номер: "+SerNum;
            lbl_date_repair.Text = "Дата ремонта: "+DateRepair.ToString("dd.MM.yyyy");
            lbl_master.Text = "Мастер: "+Master;
            lbl_opis.Text = "Описание: "+Opis;
            lbl_zamen_compl.Text = "Заменённые комплектующие: "+Component;

        }
    }
}

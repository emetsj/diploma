using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class Passengers : Form
    {
        public Passengers()
        {
            InitializeComponent();
        }

       private void Passengers_Load(object sender, EventArgs e)
        {
            пассажирTableAdapter.Fill(database1DataSet.Пассажир);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            var p = new PassengersNewAdd();
            p.ShowDialog();
            Close();
            пассажирTableAdapter.Update(database1DataSet.Пассажир);
        }
    }
}
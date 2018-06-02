using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class Train : Form
    {
        public Train()
        {
            InitializeComponent();
        }

        private void Train_Load(object sender, EventArgs e)
        {
	        поездаTableAdapter.Fill(database1DataSet.Поезда);
	        место_в_вагонеTableAdapter.Fill(database1DataSet.Место_в_вагоне);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var t = new TrainNew();
			t.ShowDialog();
			Close();
            место_в_вагонеTableAdapter.Update(database1DataSet.Место_в_вагоне);
        }
	}
}

using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class PlaceTrain : Form
    {
        public PlaceTrain()
        {
            InitializeComponent();
        }
		
        private void PlaceTrain_Load(object sender, EventArgs e)
        {
            место_в_вагонеTableAdapter.Fill(database1DataSet.Место_в_вагоне);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var ptr = new PlaceTrainNew();
			ptr.ShowDialog();
			Close();
            место_в_вагонеTableAdapter.Update(database1DataSet.Место_в_вагоне);
        }
	}
}
using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class Stations : Form
    {
        public Stations()
        {
            InitializeComponent();
        }

        private void Stations_Load(object sender, EventArgs e)
        {
            this.станцииTableAdapter.Fill(this.database1DataSet.Станции);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var t = new StationsNew();
			t.ShowDialog();
			Close();
            станцииTableAdapter.Update(database1DataSet.Станции);
        }
	}
}

using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class Route : Form
    {
        public Route()
        {
            InitializeComponent();
        }

	    private void Route_Load(object sender, EventArgs e)
        {
            маршрутTableAdapter.Fill(database1DataSet.Маршрут);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var t = new RouteNew();
			t.ShowDialog();
			Close();
            маршрутTableAdapter.Update(database1DataSet.Маршрут);
        }
	}
}

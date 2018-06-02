using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class Trace : Form
    {
        public Trace()
        {
            InitializeComponent();
        }
		
        private void Trace_Load(object sender, EventArgs e)
        {
	        рейсTableAdapter.Fill(database1DataSet.Рейс);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var t = new TraceNew();
			t.ShowDialog();
			Close();
            рейсTableAdapter.Update(database1DataSet.Рейс);
        }
	}
}

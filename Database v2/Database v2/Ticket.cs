using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            билетTableAdapter.Fill(database1DataSet.Билет);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var t = new TicketSell();
			t.ShowDialog();
			Close();
            билетTableAdapter.Update(database1DataSet.Билет);
        }
	}
}
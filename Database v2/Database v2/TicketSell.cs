using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_v2
{
	public partial class TicketSell : Form
	{
		public TicketSell()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e1)
		{
			int a = Convert.ToInt32(textBox8.Text),
				b = Convert.ToInt32(textBox9.Text),
				c = Convert.ToInt32(textBox10.Text),
				d = Convert.ToInt32(textBox11.Text),
				e = Convert.ToInt32(textBox12.Text);
			var f = textBox13.Text;
			var g = Convert.ToDecimal(textBox14.Text);
			using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
															Data Source=Database1.accdb"))
			using (var comm = conn.CreateCommand())
			{
				comm.CommandText = "INSERT Пассажир ([Код пассажира], [ФИО], [Паспорт]) " +
								   "VALUES (id, fio, pass) GO";
				comm.CommandType = CommandType.Text;
				conn.Open();

				билетTableAdapter1.Connection = conn;
				билетTableAdapter1.Insert(a,b,c,d,e,f,g);
				билетTableAdapter1.Update(database1DataSet1.Билет);
			}
			MessageBox.Show(@"Запис додано!");
			Close();
		}
	}
}

using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_v2
{
	public partial class TraceNew : Form
	{
		public TraceNew()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e1)
		{
			int a = Convert.ToInt32(textBox6.Text),
				b = Convert.ToInt32(textBox7.Text);
			var c = Convert.ToDateTime(textBox8.Text);
			var d = textBox9.Text;
			var e = Convert.ToInt32(textBox10.Text);

			using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
															Data Source=Database1.accdb"))
			using (var comm = conn.CreateCommand())
			{
				conn.Open();

				рейсTableAdapter1.Connection = conn;
				рейсTableAdapter1.Insert(a,b,c,d,e);
				рейсTableAdapter1.Update(database1DataSet1.Рейс);
			}
			MessageBox.Show(@"Запис додано!");
			Close();
		}
	}
}

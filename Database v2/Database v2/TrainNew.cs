using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_v2
{
	public partial class TrainNew : Form
	{
		public TrainNew()
		{
			InitializeComponent();
		}

		private void TrainNew_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e1)
		{
			var a = Convert.ToInt32(textBox9.Text);
			var b = textBox10.Text;
			var c = Convert.ToInt32(textBox11.Text);
			var d = Convert.ToInt32(textBox12.Text);
			var e = Convert.ToDateTime(textBox13.Text);
			var f = Convert.ToInt32(textBox14.Text);
			var g = Convert.ToDateTime(textBox15.Text);
			var h = Convert.ToInt32(textBox16.Text);
			var i = textBox17.Text;

			using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
															Data Source=Database1.accdb"))
			using (conn.CreateCommand())
			{
				conn.Open();

				поездаTableAdapter1.Connection = conn;
				поездаTableAdapter1.Insert(a, b, c, d, e, f, g, i, h);
				поездаTableAdapter1.Update(database1DataSet1.Поезда);
			}
			MessageBox.Show(@"Запис додано!");
			Close();
		}
	}
}

using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_v2
{
	public partial class StationsNew : Form
	{
		public StationsNew()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var m = Convert.ToInt32(textBox3.Text);
				var m1 = textBox4.Text;

				using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
															Data Source=Database1.accdb"))
				using (var comm = conn.CreateCommand())
				{
					conn.Open();

					станцииTableAdapter1.Connection = conn;
					станцииTableAdapter1.Insert(m, m1);
					станцииTableAdapter1.Update(database1DataSet1.Станции);
				}
				MessageBox.Show(@"Запис додано!");
				Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString() + exception.HelpLink);
			}
		}
	}
}

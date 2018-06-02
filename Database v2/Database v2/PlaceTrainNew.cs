using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_v2
{
	public partial class PlaceTrainNew : Form
	{
		public PlaceTrainNew()
		{
			InitializeComponent();
		}
		
		private void PlaceTrainNew_Load(object sender, EventArgs e)
		{
			место_в_вагонеTableAdapter.Fill(database1DataSet.Место_в_вагоне);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int m = Convert.ToInt32(textBox5.Text),
					v = Convert.ToInt32(textBox6.Text);
				var m1 = textBox7.Text;
				var nm = Convert.ToInt32(textBox8.Text);

				using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=Database1.accdb"))
				using (conn.CreateCommand())
				{
					место_в_вагонеTableAdapter.Connection = conn;
					место_в_вагонеTableAdapter.Insert(m, v, m1, nm);
					место_в_вагонеTableAdapter.Update(database1DataSet.Место_в_вагоне);
				}
				MessageBox.Show(@"Запис додано до таблиці", "", MessageBoxButtons.OK);
				Close();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.ToString() + exception.HelpLink);
			}
		}
	}
}

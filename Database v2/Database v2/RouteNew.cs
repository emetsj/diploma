using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_v2
{
	public partial class RouteNew : Form
	{
		public RouteNew()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e2)
		{
			try
			{
				int a = Convert.ToInt32(textBox6.Text),
					b = Convert.ToInt32(textBox7.Text);
				string c = textBox8.Text,
					d = textBox9.Text;
				var e = Convert.ToInt32(textBox10.Text);

				using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
															Data Source=Database1.accdb"))
				using (var comm = conn.CreateCommand())
				{
					comm.CommandText = "INSERT Пассажир ([Код пассажира], [ФИО], [Паспорт]) " +
									   "VALUES (id, fio, pass) GO";
					comm.CommandType = CommandType.Text;
					conn.Open();

					маршрутTableAdapter1.Connection = conn;
					маршрутTableAdapter1.Insert(a,b, Convert.ToDateTime(c), Convert.ToDateTime(d), e);
					маршрутTableAdapter1.Update(database1DataSet1.Маршрут);
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

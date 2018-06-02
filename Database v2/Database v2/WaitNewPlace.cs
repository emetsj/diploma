using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_v2
{
	public partial class WaitNewPlace : Form
	{
		public WaitNewPlace()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var a = Convert.ToInt32(textBox3.Text);
			var b = textBox4.Text;
			
			using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
															Data Source=Database1.accdb"))
			using (conn.CreateCommand())
			{
				conn.Open();

				зал_ожидания_местаTableAdapter1.Connection = conn;
				зал_ожидания_местаTableAdapter1.Insert(a, b);
				зал_ожидания_местаTableAdapter1.Update(database1DataSet1.Зал_ожидания_места);
			}
			MessageBox.Show(@"Запис додано!");
			Close();
		}
	}
}

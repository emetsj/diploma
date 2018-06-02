using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class WaitNewPass : Form
    {
        public WaitNewPass()
        {
            InitializeComponent();
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var a = Convert.ToInt32(textBox4.Text);
			var b = Convert.ToInt32(textBox5.Text);
			var c = Convert.ToInt32(textBox6.Text);

			using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
															Data Source=Database1.accdb"))
			using (conn.CreateCommand())
			{
				conn.Open();

				зал_ожидания_занятоTableAdapter1.Connection = conn;
				зал_ожидания_занятоTableAdapter1.Insert(a, b, c);
				зал_ожидания_занятоTableAdapter1.Update(database1DataSet1.Зал_ожидания_занято);
			}
			MessageBox.Show(@"Запис додано!");
			Close();
		}
	}
}

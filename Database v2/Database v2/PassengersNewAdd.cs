using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class PassengersNewAdd : Form
    {
        public PassengersNewAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
	        try
	        {
				string fio = textBox5.Text,
				 pass = textBox6.Text;
				int id = Convert.ToInt16(textBox4.Text);

				using (var conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;
															Data Source=Database1.accdb"))
				using (conn.CreateCommand())
				{
					conn.Open();
					пассажирTableAdapter.Connection = conn;
					пассажирTableAdapter.Insert(id, fio, pass);
					пассажирTableAdapter.Update(database1DataSet.Пассажир);
				}
				MessageBox.Show(@"Запис додано до таблиці", "", MessageBoxButtons.OK);
				Close();
	        }
	        catch (Exception exception)
	        {
		        MessageBox.Show(exception.ToString() + exception.HelpLink);
	        }
        }

        private void PassengersNewAdd_Load(object sender, EventArgs e)
        {
	        пассажирTableAdapter.Fill(database1DataSet.Пассажир);
        }

        private void PassengersNewAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}

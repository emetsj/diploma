using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class Wait : Form
    {
        public Wait()
        {
            InitializeComponent();
        }

        private void Wait_Load(object sender, EventArgs e)
        {
            зал_ожидания_местаTableAdapter.Update(database1DataSet.Зал_ожидания_места);
            зал_ожидания_местаTableAdapter.Fill(database1DataSet.Зал_ожидания_места);
            зал_ожидания_занятоTableAdapter.Update(database1DataSet.Зал_ожидания_занято);
            зал_ожидания_занятоTableAdapter.Fill(database1DataSet.Зал_ожидания_занято);
        }

        private void зал_ожидания_занятоDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            var ptr = new WaitNewPass();
            ptr.ShowDialog();
            зал_ожидания_занятоTableAdapter.Update(database1DataSet.Зал_ожидания_занято);
			Close();
        }

		private void button2_Click(object sender, EventArgs e)
		{
			var ptr = new WaitNewPlace();
			ptr.ShowDialog();
			зал_ожидания_местаTableAdapter.Update(database1DataSet.Зал_ожидания_места);
			Close();
		}
	}
}
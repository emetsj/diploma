using System;
using System.Windows.Forms;

namespace Database_v2
{
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }

        private void Type_Load(object sender, EventArgs e)
        {
	        тип_вагонаTableAdapter.Fill(database1DataSet.Тип_вагона);
        }

		private void button1_Click(object sender, EventArgs e)
		{
			var t = new Type();
			t.ShowDialog();
			Close();
            тип_вагонаTableAdapter.Update(database1DataSet.Тип_вагона);
        }
	}
}
using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2 {
    public partial class Form1 : Form {
        private const string _conStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\valen\source\repos\WinFormsApp1\Lab2\bin\Debug\Repository.mdf;Integrated Security = True; Connect Timeout = 30";

        public Form1() {
            InitializeComponent();
            Width = 1000;
            Height = 600;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            using TvDbContext tvDb = new TvDbContext(_conStr);
            var vTvs = new ViewTVs(_conStr);
            vTvs.MdiParent = this;
            //використовуємо Ado.net клас для того що б взнати кількість записів
            //Міняємо назву дочірньої MDI-форми яка відображає всі записи в БД
            vTvs.Text = "В БД " + tvDb.TVs.Count() + " записів!!!!";
            vTvs.Show();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e) {
            AddTV aTv = new AddTV(_conStr);
            aTv.MdiParent = this;
            aTv.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e) {
            DeleteTV dTv = new DeleteTV(_conStr);
            dTv.MdiParent = this;
            dTv.Show();

        }

        private void byIdToolStripMenuItem_Click(object sender, EventArgs e) {
            SearchById sbID = new SearchById(_conStr);
            sbID.MdiParent = this;
            sbID.Show();

        }
    }
}

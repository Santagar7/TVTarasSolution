using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2 {
    public partial class DeleteTV : Form {
        private readonly string _conStr;
        public DeleteTV(string conStr) {
            InitializeComponent();
            _conStr = conStr;
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            try {

                using var dbContext = new TvDbContext(_conStr);
                int id;
                id = Convert.ToInt32(textBox1.Text);
                dbContext.TVs.Remove(dbContext.TVs.FirstOrDefault(tv => tv.Id == id));
                dbContext.SaveChanges();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e) {
            textBox1.Clear();
        }
    }
}

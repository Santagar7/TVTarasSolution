using System;
using System.Windows.Forms;

namespace Lab2 {
    public partial class AddTV : Form {
        private readonly string _conStr;
        public AddTV(string conStr) {
            InitializeComponent();
            _conStr = conStr;
        }

        private void addButton_Click(object sender, EventArgs e) {
            try {
                using var dbContext = new TvDbContext(_conStr);
                TV tv = new TV();
                int row;
                tv.Manufacturer = manufacturerTextBox.Text;
                tv.Type = typeTextBox.Text;
                tv.Power = Convert.ToDouble(powerTextBox.Text);
                tv.Diagonal = Convert.ToDouble(diagonalTextBox.Text);
                dbContext.TVs.Add(tv);
                dbContext.SaveChanges();
            } catch (Exception exception) {
                MessageBox.Show(exception.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e) {
            manufacturerTextBox.Clear();
            typeTextBox.Clear();
            powerTextBox.Clear();
            diagonalTextBox.Clear();
        }
    }
}

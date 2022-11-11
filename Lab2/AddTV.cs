using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2 {
    public partial class AddTV : Form {
        private readonly string _conStr;
        public AddTV(string conStr) {
            InitializeComponent();
            _conStr = conStr;
            InitializeCombobox();
        }

        private void addButton_Click(object sender, EventArgs e) {
            try {
                using var dbContext = new TvDbContext(_conStr);
                TV tv = new TV();
                tv.Manufacturer = manufacturerTextBox.Text;
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
            powerTextBox.Clear();
            diagonalTextBox.Clear();
        }

        private void InitializeCombobox()
        {
            using var dbContext = new TvDbContext(_conStr);
            comboBox1.DataSource = dbContext.TvTypes.ToList();
        }
    }
}

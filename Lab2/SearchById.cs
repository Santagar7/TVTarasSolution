using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2 {
    public partial class SearchById : Form {
        private readonly string _conStr;
        public SearchById(string conStr) {
            InitializeComponent();
            _conStr = conStr;
        }

        private void searchButton_Click(object sender, EventArgs e) {
            using var dbContext = new TvDbContext(_conStr);
            int id;
            id = Convert.ToInt32(textBox1.Text);
            dataGridView1.DataSource = dbContext.TVs.FirstOrDefault(t => t.Id == id);
            
        }
    }
}

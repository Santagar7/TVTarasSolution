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
            var tv = dbContext.TVs.FirstOrDefault(t => t.Id == id);
            string str = "";
            str = str + String.Format("{0,-7}", tv.Id.ToString()) + "| " + String.Format("{0,-25}", tv.Manufacturer) + "| " + String.Format("{0,-28}", tv.Diagonal) + "| " + String.Format("{0,-10}", tv.Type) + "| " + String.Format("{0,-7}", tv.Power) + "\r\n";

            textBox2.Text = str;
        }
    }
}

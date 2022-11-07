using System;
using System.Windows.Forms;

namespace Lab2 {
    public partial class ViewTVs : Form {

        private readonly string _conStr;
        public ViewTVs(string conStr) {
            InitializeComponent();
            _conStr = conStr;
            InitializeTextBox();
        }

        private void InitializeTextBox() {
            using var dbContext = new TvDbContext(_conStr);
            String str = "";
            this.textBox1.Clear();
            str = str + "|    ID  |   Manufacturer  |     Diagonal      |    Type    |   Power   |\r\n"; str = str + "|===========================================================================|\r\n";
            foreach (var tv in dbContext.TVs) {
                str = str + String.Format("{0,-7}", tv.Id.ToString()) + "| " + String.Format("{0,-25}", tv.Manufacturer) + "| " + String.Format("{0,-28}", tv.Diagonal) + "| " + String.Format("{0,-10}", tv.Type) + "| " + String.Format("{0,-7}", tv.Power) + "\r\n";
            }
            textBox1.Text = str;

        }
    }
}

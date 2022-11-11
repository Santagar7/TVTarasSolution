using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab2 {
    public partial class ViewTVs : Form
    {

        private readonly string _conStr;

        public ViewTVs(string conStr)
        {
            InitializeComponent();
            _conStr = conStr;
            InitializeDataGridView();
            InitializeTreeView();
        }

        private void InitializeDataGridView()
        {
            using var dbContext = new TvDbContext(_conStr);
            dataGridView1.DataSource = dbContext.TVs.ToList();
        }

        private void InitializeTreeView()
        {
            using var dbContext = new TvDbContext(_conStr);
            treeView1.Nodes.Add("TVs", "Televisions");
            treeView1.Nodes["TVs"].Nodes.Add("QLED", "QLED");
            treeView1.Nodes["TVs"].Nodes.Add("OLED", "OLED");

        }

    }
}

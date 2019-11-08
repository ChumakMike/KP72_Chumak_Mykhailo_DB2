using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_databases {
    public partial class StaticViewSearch : Form {

        Controller controller = new Controller();
        public StaticViewSearch() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            controller.crossSearchStatic(dataGridView1, bool.Parse(comboBox1.Text), textBox1.Text);
        }
    }
}

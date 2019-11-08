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
    public partial class FullTextViewSearch : Form {

        Controller controller = new Controller();
        public FullTextViewSearch() {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {
            controller.changeComboBox(comboBox1 ,comboBox2);
        }

        private void button1_Click(object sender, EventArgs e) {
            controller.fullTextSearch(comboBox2.Text, comboBox1.Text, textBox1.Text, dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e) {
            controller.fullTextWordIsNotContained(comboBox2.Text, comboBox1.Text, textBox1.Text, dataGridView1);
        }
    }
}

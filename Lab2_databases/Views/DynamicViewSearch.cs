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
    public partial class DynamicViewSearch : Form {
        Controller controller = new Controller();

        public DynamicViewSearch() {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            controller.setDynamicGrid(dataGridView1, comboBox1.Text, comboBox2.Text, textBox1.Text, textBox2.Text, "", "", comboBox3.Text, comboBox4.Text);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e) {
            controller.setComboBox(comboBox1, comboBox2, comboBox3);
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e) {
            controller.changeComboBox(comboBox2, comboBox4);
        }
    }
}

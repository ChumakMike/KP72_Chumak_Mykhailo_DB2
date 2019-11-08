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
    public partial class DeliveryAddView : Form {
        Controller controller = new Controller();

        public DeliveryAddView() {
            InitializeComponent();
            controller.fillBuyersComboBox(buyersComboBox);
            controller.fillProductsComboBox(productComboBox);
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            controller.addDelivery(Int32.Parse(buyersComboBox.Text), Int32.Parse(productComboBox.Text), dateTimePicker1.Value.ToString("dd.MM.yyyy"), 
                                    dateTimePicker2.Value.ToString("dd.MM.yyyy"), bool.Parse(isDeliveredComboBox.Text));
            this.Close();
        }
    }
}

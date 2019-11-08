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
    public partial class DeliveryViewForm : Form {
        Controller controller = new Controller();

        public DeliveryViewForm() {
            InitializeComponent();
            controller.getAllDeliveries(DeliveriesGrid);
        }

        private void All_Click(object sender, EventArgs e) {
            controller.getAllDeliveries(DeliveriesGrid);
        }

        private void Add_Click(object sender, EventArgs e) {
            DeliveryAddView deliveryAddView = new DeliveryAddView();
            deliveryAddView.Show();
        }

        private void Remove_Click(object sender, EventArgs e) {
            controller.deleteDelivery(Int32.Parse((DeliveriesGrid.Rows[DeliveriesGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            controller.getAllDeliveries(DeliveriesGrid);
        }

        private void button4_Click(object sender, EventArgs e) {
            DeliveryUpdView deliveryUpdView = new DeliveryUpdView(Int32.Parse((DeliveriesGrid.Rows[DeliveriesGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            deliveryUpdView.Show();
        }

        private void DeliveriesGrid_SelectionChanged(object sender, EventArgs e) {
            controller.activateRemBtn(Remove);
        }

        private void RandomFill_Click(object sender, EventArgs e) {
            controller.InsertRandomDeliveries();
            controller.getAllDeliveries(DeliveriesGrid);
        }
    }
}

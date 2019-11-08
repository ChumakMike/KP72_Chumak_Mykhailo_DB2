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
    public partial class DeliveryUpdView : Form {
        Controller controller = new Controller();
        public int Id { get; set; }
        
        public DeliveryUpdView(int id) {
            Id = id;
            InitializeComponent();
        }

        private void upd_but_Click(object sender, EventArgs e) {
            controller.updateDelivery(Id, bool.Parse(comboBox1.Text));
            this.Close();
        }
    }
}

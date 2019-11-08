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
    public partial class ProvidersAddViewcs : Form {
        Controller controller = new Controller();

        public ProvidersAddViewcs() {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e) {
            controller.addProvider(name.Text, adr.Text, phone.Text);
            this.Close();
        }
    }
}

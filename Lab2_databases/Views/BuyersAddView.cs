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
    public partial class BuyersAddView : Form {
        Controller controller = new Controller();
        public BuyersAddView() {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e) {
            controller.addBuyer(name.Text, surname.Text, login.Text);
            this.Close();
        }
    }
}

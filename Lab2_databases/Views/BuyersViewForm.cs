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
    public partial class BuyersViewForm : Form {

        Controller controller = new Controller();
        public BuyersViewForm() {
            InitializeComponent();
            controller.getAllBuyers(BuyersGrid);
        }

        private void button4_Click(object sender, EventArgs e) {
            BuyersUpdView buyersUpdView = new BuyersUpdView(Int32.Parse((BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[0].Value).ToString()),
                (BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[1].Value).ToString(),
                (BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[2].Value).ToString(), 
                (BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[3].Value).ToString());
            buyersUpdView.Show();
        }

        private void All_Click(object sender, EventArgs e) {
            controller.getAllBuyers(BuyersGrid);
        }

        private void Add_Click(object sender, EventArgs e) {
            BuyersAddView buyersAddView = new BuyersAddView();
            buyersAddView.Show();
        }

        private void Remove_Click(object sender, EventArgs e) {
            controller.deleteBuyer(Int32.Parse((BuyersGrid.Rows[BuyersGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            controller.getAllBuyers(BuyersGrid);
        }

        private void BuyersGrid_SelectionChanged(object sender, EventArgs e) {
            controller.activateRemBtn(Remove);
        }

        private void BuyersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void RandomFill_Click(object sender, EventArgs e) {
            controller.InsertRandomBuyers();
            controller.getAllBuyers(BuyersGrid);
        }
    }
}

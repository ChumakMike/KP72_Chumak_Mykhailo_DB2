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
    public partial class ProductViewForm : Form {
        Controller controller = new Controller();

        public ProductViewForm() {
            InitializeComponent();
            controller.getAllProducts(ProductsGrid);
        }

        private void All_Click(object sender, EventArgs e) {
            controller.getAllProducts(ProductsGrid);
        }

        private void Add_Click(object sender, EventArgs e) {
            ProductAddView productAddView = new ProductAddView();
            productAddView.Show();
        }

        private void Remove_Click(object sender, EventArgs e) {
            controller.deleteProduct(Int32.Parse((ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            controller.getAllProducts(ProductsGrid);
        }

        private void Update_Click(object sender, EventArgs e) {
            ProductUpdView productUpdView = new ProductUpdView(Int32.Parse((ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[0].Value).ToString()),
                (ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[1].Value).ToString(),
                (ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[2].Value).ToString(),
                Int32.Parse((ProductsGrid.Rows[ProductsGrid.CurrentRow.Index].Cells[3].Value).ToString()));
            productUpdView.Show();
        }

        private void ProductsGrid_SelectionChanged(object sender, EventArgs e) {
            controller.activateRemBtn(Remove);
        }

        private void RandomFill_Click(object sender, EventArgs e) {
            controller.InsertRandomProducts();
        }
    }
}

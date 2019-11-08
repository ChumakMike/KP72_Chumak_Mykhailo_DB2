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
    public partial class ProvidersViewForm : Form {
        Controller controller = new Controller();

        public ProvidersViewForm() {
            InitializeComponent();
            controller.getAllProviders(ProvidersGrid);
        }


        private void All_Click(object sender, EventArgs e) {
            controller.getAllProviders(ProvidersGrid);
        }

        private void Add_Click(object sender, EventArgs e) {
            ProvidersAddViewcs providersAddViewcs = new ProvidersAddViewcs();
            providersAddViewcs.Show();
        }

        private void Remove_Click(object sender, EventArgs e) {
            controller.deleteProvider(Int32.Parse((ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[0].Value).ToString()));
            controller.getAllProviders(ProvidersGrid);
        }

        private void Update_Click(object sender, EventArgs e) {
            ProvidersUpdView providersUpdView = new ProvidersUpdView(Int32.Parse((ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[0].Value).ToString()),
                (ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[1].Value).ToString(),
                (ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[2].Value).ToString(),
                (ProvidersGrid.Rows[ProvidersGrid.CurrentRow.Index].Cells[3].Value).ToString());
            providersUpdView.Show();
        }

        private void ProvidersGrid_SelectionChanged(object sender, EventArgs e) {
            controller.activateRemBtn(Remove);
        }

        private void RandomFill_Click(object sender, EventArgs e) {
            controller.InsertRandomProviders();
            controller.getAllProviders(ProvidersGrid);
        }
    }
}

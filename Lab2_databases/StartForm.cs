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
    public partial class StartForm : Form {

        Controller controller = new Controller();
        RandomPackageClass randomPackageClass = new RandomPackageClass();


        public StartForm() {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e) {
            BuyersViewForm buyersViewForm = new BuyersViewForm();
            buyersViewForm.Show();
        }

        private void Providers_Click(object sender, EventArgs e) {
            ProvidersViewForm providersViewForm = new ProvidersViewForm();
            providersViewForm.Show();
        }

        private void Products_Click(object sender, EventArgs e) {
            ProductViewForm productViewForm = new ProductViewForm();
            productViewForm.Show();
        }

        private void Deliveries_Click(object sender, EventArgs e) {
            DeliveryViewForm deliveryViewForm = new DeliveryViewForm();
            deliveryViewForm.Show();
        }

        private void button2_Click(object sender, EventArgs e) {
            StaticViewSearch staticViewSearch = new StaticViewSearch();
            staticViewSearch.Show();
        }

        private void DynamicSearch_Click(object sender, EventArgs e) {
            DynamicViewSearch dynamicViewSearch = new DynamicViewSearch();
            dynamicViewSearch.Show();
        }

        private void fullTxtSearch_Click(object sender, EventArgs e) {
            FullTextViewSearch fullTextViewSearch = new FullTextViewSearch();
            fullTextViewSearch.Show();
        }
    }
}

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
    public partial class BuyersUpdView : Form {
        Controller controller = new Controller();
        #region Properties
        public int Id { private get; set; }
        #endregion

        public BuyersUpdView(int id, string nam, string surnam, string log) {
            InitializeComponent();
            Id = id;
            name.Text = nam;
            surname.Text = surnam;
            login.Text = log;
        }

        

        private void Update_btn_Click(object sender, EventArgs e) {
            controller.updateBuyer(this.Id, name.Text, surname.Text, login.Text);
            this.Close();
        }
    }
}

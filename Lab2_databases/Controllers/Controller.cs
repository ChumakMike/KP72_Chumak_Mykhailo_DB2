using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_databases {

    public class Controller {
        RandomPackageClass RandomPackageClass = new RandomPackageClass();

        #region Models
        private Buyer buyer = new Buyer();
        private Delivery del = new Delivery();
        private Product prod = new Product();
        private Provider prov = new Provider();
        #endregion

        #region Views
        #endregion

        public Controller() { }

        public void activateRemBtn(Button rem) {
            rem.Enabled = true;
        }

        public void getAllBuyers(DataGridView buyersGrid) {
            buyersGrid.DataSource = buyer.getAllBuyers();
            buyersGrid.Columns[0].Visible = false;
        }

        public void addBuyer(string name, string sur, string log) {
            buyer.addBuyer(name, sur, log);
        }

        public void deleteBuyer(int id) {
            buyer.removeBuyer(id);
        }

        public void updateBuyer(int id, string name, string surname, string login) {
            buyer.updateBuyer(id, name, surname, login);
        }

        public void getAllProviders(DataGridView provGrid) {
            provGrid.DataSource = prov.getAllProviders();
            provGrid.Columns[0].Visible = false;
        }

        public void deleteProvider(int id) {
            prov.removeProvider(id);
        }

        public void addProvider(string name, string adress, string phone) {
            prov.addProvider(name, adress, phone);
        }

        public void updateProvider(int id, string name, string adress, string phone) {
            prov.updateProvider(id, name, adress, phone);
        }

        public void getAllProducts(DataGridView ProductsGrid) {
            ProductsGrid.DataSource = prod.getAllProducts();
            ProductsGrid.Columns[0].Visible = false;
        }

        public void addProduct(string name, string category, int prodId) {
            prod.addProduct(name, category, prodId);
        }

        public void deleteProduct(int id) {
            prod.removeProduct(id);
        }

        public void fillComboBox(ComboBox b) {
            List<Provider> p = prov.getAllProviders();
            foreach(var i in p) {
                b.Items.Add(i.Id);
            }
        }

        public void updateProduct(int id, string name, string cat, int provId) {
            prod.updateProduct(id, name, cat, provId);
        }

        public void getAllDeliveries(DataGridView grid) {
            grid.DataSource = del.getAllDeliveries();
            grid.Columns[0].Visible = false;
        }

        public void deleteDelivery(int id) {
            del.removeDelivery(id);
        }

        public void addDelivery(int buyid, int prodid, string order, string delivery, bool isdel) {
            del.addDelivery(buyid, prodid, order, delivery, isdel);
        }

        public void fillBuyersComboBox(ComboBox b) {
            List<Buyer> p = buyer.getAllBuyers();
            foreach (var i in p) {
                b.Items.Add(i.Id);
            }
        }

        public void fillProductsComboBox(ComboBox b) {
            List<Product> p = prod.getAllProducts();
            foreach (var i in p) {
                b.Items.Add(i.Id);
            }
        }

        public void updateDelivery(int id, bool isdel) {
            del.updateDelivery(id, isdel);
        }

        public void InsertRandomBuyers() {
            List<string> names = RandomPackageClass.getMalesNames();
            List<string> surnames = RandomPackageClass.getSurnames();
            for(int i = 0; i < 10000; i++) {
                if(i < names.Capacity && i < surnames.Capacity) {
                    buyer.addBuyer(names.ElementAt(i), surnames.ElementAt(i), RandomPackageClass.RandomString());
                } else {
                    int[] arr = RandomPackageClass.RandomNumber(0, names.Capacity, 1);
                    buyer.addBuyer(names.ElementAt(arr[0]), surnames.ElementAt(arr[0]), RandomPackageClass.RandomString());
                }
            }
        }

        public void InsertRandomProviders() { 
            for (int i = 0; i < 10000; i++) {
                prov.addProvider(RandomPackageClass.RandomString(), RandomPackageClass.RandomString(), RandomPackageClass.RandomStringPhone());
            }
        }

        public void InsertRandomProducts() { 
            var res = prov.getAllProviders().Select(x => x.Id);
            List<int> l = new List<int>();
            foreach(var i in res) l.Add(i);
            for(int i = 0; i < 10000; i++)
                prod.addProduct(RandomPackageClass.RandomString(), RandomPackageClass.RandomString(), RandomPackageClass.getRandomNumberFromArray(l));
        }

        public void InsertRandomDeliveries() {
            var resBuyers = buyer.getAllBuyers().Select(x => x.Id);
            var resProducts = prod.getAllProducts().Select(x => x.Id);
            List<int> buyersList = new List<int>();
            List<int> productsList = new List<int>();
            foreach (var i in resBuyers) buyersList.Add(i);
            foreach (var j in resProducts) productsList.Add(j);
            for(int i = 0; i < 10000; i++) {
                del.addDelivery(RandomPackageClass.getRandomNumberFromArray(buyersList), RandomPackageClass.getRandomNumberFromArray(productsList),
                    RandomPackageClass.getRandomPastDate(), RandomPackageClass.getRandomFutureDate(), RandomPackageClass.getRandomBoolean());
            }
        }

        public void crossSearchStatic(DataGridView grid, bool isdel, string name) {
            List<object> l = del.crossSearchStatic(isdel, name);
            grid.DataSource = l;
            grid.Columns[0].Visible = false;
        }

        public void fullTextSearch(string atr, string table, string phrase, DataGridView grid) {
            string id = "";
            if (table == "Product") {
                id = "productid";
            } else if(table == "Buyer") {
                id = "buyerid";
            } else if(table == "Provider") {
                id = "providerid";
            }
            List<object> l = prod.fullTextSearch(id, atr, table, phrase);
            grid.DataSource = l;

        }

        public void changeComboBox(ComboBox combo1, ComboBox combo2) {
            if(combo1.Text == "Product") {
                combo2.Items.Clear();
                combo2.Items.Add("name");
                combo2.Items.Add("category");
            } else if(combo1.Text == "Buyer") {
                combo2.Items.Clear();
                combo2.Items.Add("name");
                combo2.Items.Add("surname");
                combo2.Items.Add("login");
            } else if(combo1.Text == "Provider") {
                combo2.Items.Clear();
                combo2.Items.Add("name");
                combo2.Items.Add("adress");
            } else if(combo1.Text == "Delivery") {
                combo2.Items.Clear();
                combo2.Items.Add("isdelivered");
            }
        }

        public void setComboBox(ComboBox combo1, ComboBox combo2, ComboBox combo3) {
            if (combo1.Text == "Product") {
                combo2.Items.Clear();
                combo3.Items.Clear();
                combo2.Items.Add("Delivery");
                combo3.Items.Add("name");
                combo3.Items.Add("category");
            }
            else if (combo1.Text == "Buyer") {
                combo2.Items.Clear();
                combo3.Items.Clear();
                combo2.Items.Add("Delivery");
                combo3.Items.Add("name");
                combo3.Items.Add("surname");
                combo3.Items.Add("login");
            }
            else if (combo1.Text == "Provider") {
                combo2.Items.Clear();
                combo3.Items.Clear();
                combo2.Items.Add("Product");
                combo3.Items.Add("name");
                combo3.Items.Add("adress");
            } else if(combo1.Text == "Delivery") {
                combo2.Items.Clear();
                combo3.Items.Clear();
                combo2.Items.Add("Buyer");
                combo2.Items.Add("Product");
                combo3.Items.Add("isdelivered");
            }
        }

        public void setDynamicGrid(DataGridView dataGridView, string firstTable,
                                    string secondTable, string first,
                                    string second, string firstId, string secId, 
                                    string firstField, string secField) {
            DataBaseManager db = new DataBaseManager();
            if (firstTable == "Product") {
                firstId = "productid";
                secId = "product_id";
            } else if (firstTable == "Buyer") {
                firstId = "buyerid";
                secId = "buyer_id";
            } else if (firstTable == "Provider") {
                firstId = "providerid";
                secId = "prod_provider";
            }
            List<object> l = db.getDynamicSearchResults(firstTable, secondTable, first, second, firstId, secId, firstField, secField);
            dataGridView.DataSource = l;
        }

        public void fullTextWordIsNotContained(string atr, string table, string phrase, DataGridView grid) {
            DataBaseManager db = new DataBaseManager();
            string id = "";
            if (table == "Product") {
                id = "productid";
            }
            else if (table == "Buyer") {
                id = "buyerid";
            }
            else if (table == "Provider") {
                id = "providerid";
            }
            List<object> l = db.getAllWithNotIncludedWord(id, atr, table, phrase);
            grid.DataSource = l;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_databases {

    public class Product {
        DataBaseManager dbman = new DataBaseManager();
        private int id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int ProdviderId { get; set; }

        public Product() { }

        public Product(int id, string name, string cat, int prId) {
            Id = id;
            Name = name;
            Category = cat;
            ProdviderId = prId;
        }

        public Product(string name, string cat, int prId) {
            Name = name;
            Category = cat;
            ProdviderId = prId;
        }

        public void addProduct(string name, string category, int provId) {
            Product p = new Product(name, category, provId);
            dbman.InsertProduct(p);
        }

        public List<Product> getAllProducts() {
            return dbman.GetAllProducts();
        }

        public void removeProduct(int id) {
            dbman.RemoveProduct(id);
        }

        public void updateProduct(int id, string name, string cat, int provId) {
            dbman.UpdateProduct(id, name, cat, provId);
        }

        public List<object> fullTextSearch(string id, string atr, string table, string phrase) {
            return dbman.getFullPhrase(id, atr, table, phrase);
        }
    }
}

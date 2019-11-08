using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_databases {

    public class Provider {
        DataBaseManager dbman = new DataBaseManager();
        private int id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }

        public Provider() { }

        public Provider(int id, string name, string adr, string phone) {
            Id = id;
            Name = name;
            Adress = adr;
            Phone = phone;
        }

        public Provider(string name, string adr, string phone) {
            Name = name;
            Adress = adr;
            Phone = phone;
        }

        public void addProvider(string name, string adress, string phone) {
            Provider p = new Provider(name, adress, phone);
            dbman.InsertProvider(p);
        }

        public List<Provider> getAllProviders() {
            return dbman.GetAllProviders();
        }

        public void removeProvider(int id) {
            dbman.RemoveProvider(id);
        }

        public void updateProvider(int id, string name, string adress, string phone) {
            dbman.UpdateProvider(id, name, adress, phone);
        }

    }
}

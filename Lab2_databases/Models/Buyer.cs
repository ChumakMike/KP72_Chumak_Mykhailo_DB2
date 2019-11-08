using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_databases {

    public class Buyer {
        DataBaseManager dbman = new DataBaseManager();
        private int id;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }

        public Buyer() { }

        public Buyer(int id, string name, string sur, string log) {
            Id = id;
            Name = name;
            Surname = sur;
            Login = log;
        }

        public Buyer(string name, string sur, string log) {
            Name = name;
            Surname = sur;
            Login = log;
        }

        public void addBuyer(string name, string sur, string log) {
            Buyer b = new Buyer(name, sur, log);
            dbman.InsertBuyer(b);
        }

        public void removeBuyer(int id) {
            dbman.RemoveBuyer(id);
        }

        public List<Buyer> getAllBuyers() {
            return dbman.GetAllBuyers();
        }

        public void updateBuyer(int id, string name, string surname, string login) {
            dbman.UpdateBuyer(id, name, surname, login);
        }

    }
}

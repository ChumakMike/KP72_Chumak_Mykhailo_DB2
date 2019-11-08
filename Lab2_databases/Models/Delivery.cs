using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_databases {

    public class Delivery {
        DataBaseManager dbman = new DataBaseManager();
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public int ProdId { get; set; }
        public string OrderDate { get; set; }
        public string DelDate { get; set; }
        public bool IsDelivered { get; set; } 

        public Delivery() { }

        public Delivery(int id, int buyid, int prodid, bool isdel, string order, string delivery ) {
            Id = id;
            BuyerId = buyid;
            ProdId = prodid;
            OrderDate = order;
            DelDate = delivery;
            IsDelivered = isdel;
        }

        public Delivery(int buyid, int prodid, bool isdel, string order, string delivery) {
            BuyerId = buyid;
            ProdId = prodid;
            OrderDate = order;
            DelDate = delivery;
            IsDelivered = isdel;
        }

        public void addDelivery(int buyid, int prodid, string order, string delivery, bool isdel) {
            Delivery d = new Delivery(buyid, prodid, isdel, order, delivery);
            dbman.InsertDelivery(d);
        }

        public void removeDelivery(int id) {
            dbman.RemoveDelivery(id);
        }

        public List<Delivery> getAllDeliveries() {
            return dbman.GetAllDeliveries();
        }

        public void updateDelivery(int id, bool isdel) {
            dbman.UpdateDelivery(id, isdel);
        }

        public List<object> crossSearchStatic(bool isdel, string name) {
            return dbman.getCrossSearchResults(isdel, name);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;

namespace Lab2_databases {

    public class DataBaseManager {

        #region CONNECTION
        private NpgsqlConnection conn = new NpgsqlConnection("Server=127.0.0.1; Port=5555; User Id=postgres; Password=Mi19621ke; Database=Internet-Shop;");
        #endregion

        #region BUYERS
        public void InsertBuyer(Buyer b) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO public.\"Buyer\" (Name, Surname, Login) Values (:Name, :Surname, :Login)";
            command.Parameters.Add(new NpgsqlParameter("Name", b.Name));
            command.Parameters.Add(new NpgsqlParameter("Surname", b.Surname));
            command.Parameters.Add(new NpgsqlParameter("Login", b.Login));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<Buyer> GetAllBuyers() {
            List<Buyer> list = new List<Buyer>();
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM public.\"Buyer\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Buyer b = new Buyer(Int32.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                list.Add(b);
            }
            conn.Close();
            return list;
        }

        public void UpdateBuyer(int id, string name, string surname, string login) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE public.\"Buyer\" SET Name = :Name, Surname = :Surname, Login = :Login WHERE buyerid = :id";
            command.Parameters.Add(new NpgsqlParameter("Name", name));
            command.Parameters.Add(new NpgsqlParameter("Surname", surname));
            command.Parameters.Add(new NpgsqlParameter("Login", login));
            command.Parameters.Add(new NpgsqlParameter("id", id));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void RemoveBuyer(int id) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM public.\"Buyer\" WHERE buyerid = :id";
            command.Parameters.Add(new NpgsqlParameter("id", id));
            command.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region PRODUCTS
        public void InsertProduct(Product p) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO public.\"Product\" (name, category, prod_provider) Values (:name, :category, :prod_provider)";
            command.Parameters.Add(new NpgsqlParameter("name", p.Name));
            command.Parameters.Add(new NpgsqlParameter("category", p.Category));
            command.Parameters.Add(new NpgsqlParameter("prod_provider", p.ProdviderId));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<Product> GetAllProducts() {
            List<Product> list = new List<Product>();
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM public.\"Product\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Product p = new Product(Int32.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), Int32.Parse(reader.GetValue(3).ToString()));
                list.Add(p);
            }
            conn.Close();
            return list;
        }

        public void RemoveProduct(int id) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM public.\"Product\" WHERE productid = :id";
            command.Parameters.Add(new NpgsqlParameter("id", id));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateProduct(int id, string name, string category, int provId) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE public.\"Product\" SET Name = :Name, category = :Category, prod_provider = :provId WHERE productid = :id";
            command.Parameters.Add(new NpgsqlParameter("Name", name));
            command.Parameters.Add(new NpgsqlParameter("Category", category));
            command.Parameters.Add(new NpgsqlParameter("provId", provId));
            command.Parameters.Add(new NpgsqlParameter("id", id));
            command.ExecuteNonQuery();
            conn.Close();
        }
        #endregion

        #region PROVIDERS
        public void InsertProvider(Provider p) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO public.\"Provider\" (name, adress, phone) Values (:name, :adr, :phone)";
            command.Parameters.Add(new NpgsqlParameter("name", p.Name));
            command.Parameters.Add(new NpgsqlParameter("adr", p.Adress));
            command.Parameters.Add(new NpgsqlParameter("phone", p.Phone));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<Provider> GetAllProviders() {
            List<Provider> list = new List<Provider>();
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM public.\"Provider\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Provider p = new Provider(Int32.Parse(reader.GetValue(0).ToString()), reader.GetValue(1).ToString(), reader.GetValue(2).ToString(), reader.GetValue(3).ToString());
                list.Add(p);
            }
            conn.Close();
            return list;
        }

        public void RemoveProvider(int id) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM public.\"Provider\" WHERE providerid = :id";
            command.Parameters.Add(new NpgsqlParameter("id", id));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateProvider(int id, string name, string adr, string phone) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE public.\"Provider\" SET name = :Name, adress = :Adr, phone = :phone WHERE providerid = :id";
            command.Parameters.Add(new NpgsqlParameter("Name", name));
            command.Parameters.Add(new NpgsqlParameter("Adr", adr));
            command.Parameters.Add(new NpgsqlParameter("phone", phone));
            command.Parameters.Add(new NpgsqlParameter("id", id));
            command.ExecuteNonQuery();
            conn.Close();
        }

        #endregion

        #region DELIVERIES
        public void InsertDelivery(Delivery d) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "INSERT INTO public.\"Delivery\" (buyer_id, product_id, isdelivered, date_of_order, date_of_delivery) " +
                "Values (:buyerid, :productid, :isdelivered, :dateoforder, :dateofdelivery)";
            command.Parameters.Add(new NpgsqlParameter("buyerid", d.BuyerId));
            command.Parameters.Add(new NpgsqlParameter("productid", d.ProdId));
            command.Parameters.Add(new NpgsqlParameter("isdelivered", d.IsDelivered));
            command.Parameters.Add(new NpgsqlParameter("dateoforder", d.OrderDate));
            command.Parameters.Add(new NpgsqlParameter("dateofdelivery", d.DelDate));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void RemoveDelivery(int id) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "DELETE FROM public.\"Delivery\" WHERE deliveryid = :id";
            command.Parameters.Add(new NpgsqlParameter("id", id));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateDelivery(int id, bool isdel) {
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "UPDATE public.\"Delivery\" SET isdelivered = :isdel WHERE deliveryid = :id";
            command.Parameters.Add(new NpgsqlParameter("isdel", isdel));
            command.Parameters.Add(new NpgsqlParameter("id", id));
            command.ExecuteNonQuery();
            conn.Close();
        }

        public List<Delivery> GetAllDeliveries() {
            List<Delivery> list = new List<Delivery>();
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM public.\"Delivery\"";
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                Delivery p = new Delivery(Int32.Parse(reader.GetValue(0).ToString()), Int32.Parse(reader.GetValue(1).ToString()), Int32.Parse(reader.GetValue(2).ToString()), bool.Parse(reader.GetValue(3).ToString()),
                    reader.GetValue(4).ToString(), reader.GetValue(5).ToString());
                list.Add(p);
            }
            conn.Close();
            return list;
        }

        #endregion

        public List<object> getCrossSearchResults(bool isdel, string name) {
            List<object> list = new List<object>();
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM public.\"Delivery\" INNER JOIN public.\"Product\" " +
                "ON public.\"Delivery\".product_id = public.\"Product\".productid WHERE public.\"Delivery\".isdelivered = :isdel AND public.\"Product\".name = :nameof";
            command.Parameters.Add(new NpgsqlParameter("isdel", isdel));
            command.Parameters.Add(new NpgsqlParameter("nameof", name));
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                object o = new {
                    Id = Int32.Parse(reader.GetValue(0).ToString()),
                    buyerId = Int32.Parse(reader.GetValue(1).ToString()),
                    prodId = Int32.Parse(reader.GetValue(2).ToString()),
                    isdel = bool.Parse(reader.GetValue(3).ToString()),
                    dateOfOrder = reader.GetValue(4).ToString(),
                    dateOfDel = reader.GetValue(5).ToString(),
                    nameOfProd = reader.GetValue(7).ToString(),
                    categ = reader.GetValue(8).ToString(),
                    provider = reader.GetValue(9).ToString()
                };
                list.Add(o);
            }
            conn.Close();
            return list;
        }

        public List<object> getFullPhrase(string id, string atr, string table, string phrase) {
            List<object> list = new List<object>();
            conn.Open();
            table = $"public.\"{table}\"";
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = $"SELECT {id}, {atr}, ts_headline(\"{atr}\", q) FROM {table}, phraseto_tsquery('{phrase}') AS q WHERE to_tsvector({table}.{atr}) @@ q";
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                object o = new {
                    Id = Int32.Parse(reader.GetValue(0).ToString()),
                    atr =reader.GetValue(1).ToString(),
                    ts_headline = reader.GetValue(2).ToString()
                };
                list.Add(o);
            }
            conn.Close();
            return list;
        }

        public List<object> getDynamicSearchResults(string firstTable, string secondTable, string first, string second, string firstId, string secId, string firstField, string secField) {
            List<object> list = new List<object>();
            conn.Open();
            NpgsqlCommand command = conn.CreateCommand();
            firstTable = $"public.\"{firstTable}\"";
            secondTable = $"public.\"{secondTable}\"";
            command.CommandText = $"SELECT * FROM {firstTable} INNER JOIN {secondTable} " +
                $"ON {firstTable}.{firstId} = {secondTable}.{secId} WHERE {firstTable}.{firstField} = '{first}' AND {secondTable}.{secField} = '{second}'";
            NpgsqlDataReader reader = command.ExecuteReader();
            int count = reader.FieldCount;
            while (reader.Read()) {
                if(count == 10) {
                    object o = new {
                        Id = Int32.Parse(reader.GetValue(0).ToString()),
                        SecondField = reader.GetValue(1).ToString(),
                        ThirdField = reader.GetValue(2).ToString(),
                        fourthField = reader.GetValue(3).ToString(),
                        fifthField = reader.GetValue(4).ToString(),
                        sixField = reader.GetValue(5).ToString(),
                        sevenField = reader.GetValue(6).ToString(),
                        eightField = reader.GetValue(7).ToString(),
                        ninthField = reader.GetValue(8).ToString(),
                        tenthField = reader.GetValue(9).ToString()
                    };
                    list.Add(o);
                } else if(count == 8) {
                    object o = new {
                        Id = Int32.Parse(reader.GetValue(0).ToString()),
                        SecondField = reader.GetValue(1).ToString(),
                        ThirdField = reader.GetValue(2).ToString(),
                        fourthField = reader.GetValue(3).ToString(),
                        fifthField = reader.GetValue(4).ToString(),
                        sixField = reader.GetValue(5).ToString(),
                        sevenField = reader.GetValue(6).ToString(),
                        eightField = reader.GetValue(7).ToString(),
                    };
                    list.Add(o);
                }
            }
            conn.Close();
            return list;
        }

        public List<object> getAllWithNotIncludedWord(string id, string atr, string table, string phrase) {
            List<object> list = new List<object>();
            conn.Open();
            table = $"public.\"{table}\"";
            NpgsqlCommand command = conn.CreateCommand();
            command.CommandText = $"SELECT {id}, {atr} FROM {table} WHERE NOT(to_tsvector({table}.{atr}) @@ to_tsquery('{phrase}'))";
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                object o = new {
                    Id = Int32.Parse(reader.GetValue(0).ToString()),
                    atr = reader.GetValue(1).ToString()
                };
                list.Add(o);
            }
            conn.Close();
            return list;
        }
    }
}

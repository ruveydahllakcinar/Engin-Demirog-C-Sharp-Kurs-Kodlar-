using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    public class ProductDal
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog = ETrade;integrated security=true"); //Bağlantı nesnesini oluşturduk
        public List<Product> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();//Komutu çalıştırmak için önce Sql komutu girilir sonrasında bu komut yazılır.

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {//Burada ürünü oluşturduk henüz listeye ekleme yapmadık
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product); //Burada listeleme yaptık ve çalıştrdık

            }

            reader.Close();
            _connection.Close();
            return products;
        }

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed) //Bağlantıyı açmak için connection.Open(); yazarız. Bunu direkt yazarsak sorun olabilir diye if e yazdık
            {
                _connection.Open();
            }
        }

        public DataTable GetAll2()
        {
            if (_connection.State == ConnectionState.Closed) //Bağlantıyı açmak için connection.Open(); yazarız. Bunu direkt yazarsak sorun olabilir diye if e yazdık
            {
                _connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", _connection);

            SqlDataReader reader = command.ExecuteReader();//Komutu çalıştırmak için önce Sql komutu girilir sonrasında bu komut yazılır.

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitPrice,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();


        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name=@name, UnitPrice=@unitPrice, StockAmount=@stockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery();

            _connection.Close();


        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _connection);
            
            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();

            _connection.Close();


        }
    }
}

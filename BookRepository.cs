using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp19
{
    public class BookRepository
    {
        private readonly string connectionString;
        public BookRepository(string connectionString) {
            this.connectionString = connectionString;

        }
        public IEnumerable<Books> GetBooks()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                return dbConnection.Query<Books>("Select * from Books");
            }
        }
        public Books GetBooksById(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                return dbConnection.QuerySingleOrDefault<Books>("Select * from Book WHERE ID=@ID",
                    new { Id = id });
            }
        }
        public void InsertBooks(Books book)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string Insertquery = "INSERT INTO Books (Title,Author,PublicationYear,ISBN,Genre,Price,InStock) VALUES(@Title," +
                    "@Author,@PublicationYear,@ISBN,@Genre,@Price,@InStock)";
                dbConnection.Open();
                dbConnection.Execute(Insertquery, book);
            }
        }
        public void UpdateBooks(Books book)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string updatequery = "UPDATE Books SET Title=@Title,Author=@Author,PublicationYear=@PublicationYear,ISBN=@ISBN,Genre=@Genre,Price=@Price,InStock=@InStock WHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(updatequery, book);

            }
        }
        public void DeleteBooks(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string deletequery = "DELETE FROM Books WHERE ID=@ID";
                dbConnection.Open();
                dbConnection.Execute(deletequery, new { Id = id });
            }

        }
    }
}

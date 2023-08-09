using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ConsoleApp18
{

    public class PersonRepository
    {
        private readonly string connectionString;
        public PersonRepository(string connectionString)
        {
            this.connectionString=connectionString;
        }
        public IEnumerable<Person>GetAllPeople()
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                var query = @"Select p.id as personid,p.Name as personname,from Person p inner
                join children c on a.id=c.id";
                return dbConnection.Query<Person>("Select * from Person");
            }
        }
        public Person GetPersonById(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                dbConnection.Open();
                return dbConnection.QuerySingleOrDefault<Person>("Select * from Person WHERE ID=@ID",
                    new { Id = id });
            }
        }
        public void InsertPerson(Person person)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string Insertquery = "INSERT INTO PERSON(Id,Name,Email,GenderId)VALUES(@Id,@Name,@Email,@GenderId)";
                dbConnection.Open();
                dbConnection.Execute(Insertquery, person);
            }
        }
        public void UpdatePerson(Person person)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string updatequery = "UPDATE PERSON SET Name=@Name,Email=@Email,GenderId=GenderId wHERE Id=@Id";
                dbConnection.Open();
                dbConnection.Execute(updatequery, person);

            }
        }
        public void DeletePerson(int id)
        {
            using (IDbConnection dbConnection = new SqlConnection(connectionString))
            {
                string deletequery = "DELETE FROM PERSON WHERE ID=@ID";
                dbConnection.Open();
                dbConnection.Execute(deletequery, new { Id = id });
            }

        }
    }
    }
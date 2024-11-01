using System;
using System.Data.SqlClient;


internal class Program
{

    static string ConnectionString = "Server = .; Database = ContactsDB; User Id = sa; Password = sa123456;";

    static void PrintAllData()
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);
        string Query = "SELECT * FROM Contacts";

        SqlCommand Command = new SqlCommand(Query, Connection);

        try
        {
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ContactID = (int)Reader["ContactID"];
                string FirstName = (string)Reader["FirstName"];
                string LastName = (string)Reader["LastName"];
                string Email = (string)Reader["Email"];
                string Phone = (string)Reader["Phone"];
                string Address = (string)Reader["Address"];
                int CountryID = (int)Reader["CountryID"];

                //int ContactID = (int)Reader[0];
                //string FirstName = (string)Reader[1];
                //string LastName = (string)Reader[2];
                //string Email = (string)Reader[3];
                //string Phone = (string)Reader[4];
                //string Address = (string)Reader[5];
                //int CountryID = (int)Reader[7];

                Console.WriteLine($"Contact ID: {ContactID}");
                Console.WriteLine($"FirstName: {FirstName}");
                Console.WriteLine($"LastName: {LastName}");
                Console.WriteLine($"Email: {Email}");
                Console.WriteLine($"Phone: {Phone}");
                Console.WriteLine($"Address: {Address}");
                Console.WriteLine($"Country ID: {CountryID}");
                Console.WriteLine();
            }

            Reader.Close();
            Connection.Close();
        }
        catch (Exception ex)
        {

            Console.WriteLine("Error: ", ex.Message);
        }
    }
    static void Main(string[] args)
    {

        PrintAllData();

        Console.ReadKey();
    }
}


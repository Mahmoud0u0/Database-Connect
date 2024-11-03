using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;


internal class Program
{

    static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";

    public struct stContact
    {
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryID { get; set; }
    }


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

    static void PrintAllContactsWithFirstName(string FirstName)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);
        string Query = "SELECT * FROM Contacts WHERE FirstName = @FirstName";

        SqlCommand Command = new SqlCommand(Query, Connection);
        
        Command.Parameters.AddWithValue("@FirstName", FirstName);

        try
        {
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ContactID = (int)Reader["ContactID"];
                string firstName = (string)Reader["FirstName"];
                string lastName = (string)Reader["LastName"];
                string email = (string)Reader["Email"];
                string phone = (string)Reader["Phone"];
                string address = (string)Reader["Address"];
                int countryID = (int)Reader["CountryID"];

                Console.WriteLine($"Contact ID: {ContactID}");
                Console.WriteLine($"FirstName: {firstName}");
                Console.WriteLine($"LastName: {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
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

    static void PrintAllContactsWithFirstNameAndCountry(string FirstName, int CountryID)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);
        string Query = "SELECT * FROM Contacts WHERE FirstName = @FirstName AND CountryID = @CountryID";

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@FirstName", FirstName);
        Command.Parameters.AddWithValue("@CountryID", CountryID);

        try
        {
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ContactID = (int)Reader["ContactID"];
                string firstName = (string)Reader["FirstName"];
                string lastName = (string)Reader["LastName"];
                string email = (string)Reader["Email"];
                string phone = (string)Reader["Phone"];
                string address = (string)Reader["Address"];
                int countryID = (int)Reader["CountryID"];

                Console.WriteLine($"Contact ID: {ContactID}");
                Console.WriteLine($"FirstName: {firstName}");
                Console.WriteLine($"LastName: {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
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

    static void SearchContactsStartWith(string Contains)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string Query = "SELECT * FROM Contacts WHERE FirstName LIKE '' + @Contains + '%'";

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@Contains", Contains);


        try
        {
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ContactID = (int)Reader["ContactID"];
                string firstName = (string)Reader["FirstName"];
                string lastName = (string)Reader["LastName"];
                string email = (string)Reader["Email"];
                string phone = (string)Reader["Phone"];
                string address = (string)Reader["Address"];
                int countryID = (int)Reader["CountryID"];

                Console.WriteLine($"Contact ID: {ContactID}");
                Console.WriteLine($"FirstName: {firstName}");
                Console.WriteLine($"LastName: {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
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

    static void SearchContactsEndWith(string Contains)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string Query = "SELECT * FROM Contacts WHERE FirstName LIKE '%' + @Contains + ''";

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@Contains", Contains);


        try
        {
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ContactID = (int)Reader["ContactID"];
                string firstName = (string)Reader["FirstName"];
                string lastName = (string)Reader["LastName"];
                string email = (string)Reader["Email"];
                string phone = (string)Reader["Phone"];
                string address = (string)Reader["Address"];
                int countryID = (int)Reader["CountryID"];

                Console.WriteLine($"Contact ID: {ContactID}");
                Console.WriteLine($"FirstName: {firstName}");
                Console.WriteLine($"LastName: {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
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

    static void SearchContactsContains(string Contains)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string Query = "SELECT * FROM Contacts WHERE FirstName LIKE '%' + @Contains + '%'";

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@Contains", Contains);
        

        try
        {
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();

            while (Reader.Read())
            {
                int ContactID = (int)Reader["ContactID"];
                string firstName = (string)Reader["FirstName"];
                string lastName = (string)Reader["LastName"];
                string email = (string)Reader["Email"];
                string phone = (string)Reader["Phone"];
                string address = (string)Reader["Address"];
                int countryID = (int)Reader["CountryID"];

                Console.WriteLine($"Contact ID: {ContactID}");
                Console.WriteLine($"FirstName: {firstName}");
                Console.WriteLine($"LastName: {lastName}");
                Console.WriteLine($"Email: {email}");
                Console.WriteLine($"Phone: {phone}");
                Console.WriteLine($"Address: {address}");
                Console.WriteLine($"Country ID: {countryID}");
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

    static string GetFirstName(int ContactID)
    {

        string FirstName = "";

        SqlConnection Connection = new SqlConnection(ConnectionString);
       
        string Query = "SELECT FirstName FROM Contacts WHERE ContactID = @ContactID";

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@ContactID", ContactID);


        try
        {
            Connection.Open();
            Object result = Command.ExecuteScalar();

           if(result != null)
            {
                FirstName = result.ToString();
            }
            else
            {
                FirstName = "";
            }

            Connection.Close();
        }
        catch (Exception ex)
        {

            Console.WriteLine("Error: ", ex.Message);
        }

        return FirstName;
    }

    static bool FindContactByID(int ContactID, ref stContact ContactInfo)
    {
        bool isFound = false;

        SqlConnection Connection = new SqlConnection(ConnectionString);

        string Query = "SELECT * FROM Contacts WHERE ContactID = @ContactID";

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@ContactID", ContactID);


        try
        {
            Connection.Open();
            SqlDataReader Reader = Command.ExecuteReader();

            if (Reader.Read())
            {
                isFound = true;
                ContactInfo.ContactID = (int)Reader["ContactID"];
                ContactInfo.FirstName = (string)Reader["FirstName"];
                ContactInfo.LastName = (string)Reader["LastName"];
                ContactInfo.Email = (string)Reader["Email"];
                ContactInfo.Phone = (string)Reader["Phone"];
                ContactInfo.Address = (string)Reader["Address"];
                ContactInfo.CountryID = (int)Reader["CountryID"];
            }
            else
            {
                isFound = false;
            }

            Reader.Close();
            Connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: ", ex.Message);
        }

        return isFound;
    }

    static void PrintContactInfo(int ContactID, stContact ContactInfo)
    {
        if (FindContactByID(ContactID, ref ContactInfo)) {
            Console.WriteLine($"Contact ID: {ContactInfo.ContactID}");
            Console.WriteLine($"FirstName: {ContactInfo.FirstName}");
            Console.WriteLine($"LastName: {ContactInfo.LastName}");
            Console.WriteLine($"Email: {ContactInfo.Email}");
            Console.WriteLine($"Phone: {ContactInfo.Phone}");
            Console.WriteLine($"Address: {ContactInfo.Address}");
            Console.WriteLine($"Country ID: {ContactInfo.CountryID}");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Contact Not Found!");
        }
    }

    static void AddNewContact(stContact Contact)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string Query = @"INSERT INTO Contacts(FirstName, LastName, Email, Phone, Address, CountryID) 
                            VALUES(@FirstName, @LastName, @Email, @Phone, @Address, @CountryID);
                            SELECT SCOPE_IDENTITY()";

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
        Command.Parameters.AddWithValue("@LastName", Contact.LastName);
        Command.Parameters.AddWithValue("@Email", Contact.Email);
        Command.Parameters.AddWithValue("@Phone", Contact.Phone);
        Command.Parameters.AddWithValue("@Address", Contact.Address);
        Command.Parameters.AddWithValue("@CountryID", Contact.CountryID);

        try
        {
            Connection.Open();
            object Result = Command.ExecuteScalar();

            if(Result != null && int.TryParse(Result.ToString(), out int insetrdID))
            {
                Console.WriteLine($"Newly Inserted ID: {insetrdID}");
                Connection.Close();
            }
            else
            {
                Console.WriteLine("Record Insertion Failed");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine("Error", ex.Message);
        }
    }

    static void UpdateContact(int ContactID, stContact Contact)
    {
        SqlConnection Connection = new SqlConnection(ConnectionString);

        string Query = @"UPDATE Contacts SET
                                FirstName = @FirstName,
                                LastName = @LastName,
                                Email = @Email,
                                Phone = @Phone,
                                Address = @Address,
                                CountryID = @CountryID 
                                WHERE ContactID = @ContactID";
                            

        SqlCommand Command = new SqlCommand(Query, Connection);

        Command.Parameters.AddWithValue("@ContactID", ContactID);
        Command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
        Command.Parameters.AddWithValue("@LastName", Contact.LastName);
        Command.Parameters.AddWithValue("@Email", Contact.Email);
        Command.Parameters.AddWithValue("@Phone", Contact.Phone);
        Command.Parameters.AddWithValue("@Address", Contact.Address);
        Command.Parameters.AddWithValue("@CountryID", Contact.CountryID);

        try
        {
            Connection.Open();
            int rowsaffected = Command.ExecuteNonQuery();

            if (rowsaffected > 0)
            {
                Console.WriteLine("New UPDATE ");
                Connection.Close();
            }
            else
            {
                Console.WriteLine("Record Insertion Failed");
            }
        }
        catch (Exception ex)
        {

            Console.WriteLine("Error", ex.Message);
        }
    }


    static void Main(string[] args)
    {
        stContact ContactInfo = new stContact();

        //PrintAllData();
        //PrintAllContactsWithFirstName("Khaled2");
        //PrintAllContactsWithFirstNameAndCountry("Khaled2", 1);
        //SearchContactsStartWith("M");
        //SearchContactsEndWith("d");
        //SearchContactsContains("ed");
        //Console.WriteLine(GetFirstName(1));
        //PrintContactInfo(2, ContactInfo);

        //====== Add New Contact ======//

        stContact Contact = new stContact
        {
            FirstName = "Adam",
            LastName = "Ali11",
            Email = "Email@Email.com",
            Phone = "0988883838",
            Address = "Beer Sheva",
            CountryID = 1
        };

        //AddNewContact(Contact);
        UpdateContact(1, Contact);











        Console.ReadKey();
    }
}


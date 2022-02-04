namespace ClassLibrary
{
    public class Student
    {
        //fields
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        //properties
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Id { get { return _id; } set { _id = value; } }
        public float Gpa { get { return _gpa; } set { _gpa = value; } }


        //constructors

        //FQ 
        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            Gpa = gpa;
        }

        //Empty
        public Student() { }


        //methods
        public override string ToString()
        {
            return $"Student ID: {Id} \n" +
                $"First Name: {FirstName} \n" +
                $"Last Name: {LastName} \n" +
                $"GPA: {Gpa}";
        }
    }

    public class Vehicle
    {
        //this class does not need fields

        // Properties
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public float Weight { get; set; }

        //Constructors
        //FQ
        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public Vehicle()
        {

        }

        public override string ToString()
        {
            return $"Vehicle Make: {Make} \n" +
                $"Vehicle Model: {Model} \n" +
                $"Vehicle Year: {Year} \n" +
                $"Vehicle Weight: {Weight}lbs";
        }
    }

    public class MotorHome : Vehicle
    {
        //This class has no fields

        //Properties
        public int NumberOfBeds { get; set; }

        //ctors
        public MotorHome() { }

        public MotorHome(int numberOfBeds, string make, string model, int year, float weight)
            : base(make, model, year, weight)
        {
            NumberOfBeds = numberOfBeds;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nNumber of Beds: {NumberOfBeds}";
        }

    }

    public class Truck : Vehicle
    {
        //No Fields

        //Properties
        public float LoadCapacityLbs { get; set; }

        //Ctors

        public Truck() { }

        public Truck(string make, string model, int year, float weight, float loadCapacityLbs)
            : base(make, model, year, weight)
        {
            LoadCapacityLbs = loadCapacityLbs;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nLoad Capacity (In Pounds): {LoadCapacityLbs}lbs";
        }
    }

    public class Login
    {
        //This class does not need fields

        public string Username { get; set; }
        public string Password { get; set; }

        //ctor
        //FQ
        public Login(string username, string password)
        {
            Username = username;
            Password = password;
        }

        public Login() { }

        public override string ToString()
        {
            return $"Username: {Username} \n" +
                $"Password: {Password}";
        }

    }

    public class ContactInfo
    {

        //This class doesn't need fields

        //Properties
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        //ctor
        public ContactInfo() { }

        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Address: {StreetAddress}, {City}, {State} {Zip} \n" +
                $"Phone Number: {Phone} \n" +
                $"Email: {Email}";
        }
    }

    public class Customer
    {
        //properties
        public string Customerid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }

        //Ctors
        public Customer() { }

        public Customer(string customerid, string firstName, string lastName, ContactInfo contactInformation)
        {
            Customerid = customerid;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        public override string ToString()
        {
            return $"Customer ID: {Customerid}\n" +
                $"First Name: {FirstName}\n" +
                $"Last Name: {LastName}\n\n" +
                $"Contact Information:\n\n{ContactInformation}";
        }
    }

    public class CreditCardAccount
    {
        //this class has no fields


        //properties
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualInterestRate { get; set; }

        //constructors
        public CreditCardAccount() { }

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualInterestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualInterestRate = annualInterestRate;
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\n" +
                $"\n{CustomerInfo} \n" +
                $"Balance: {Balance} \n" +
                $"Past Due: {IsPastDue} \n" +
                $"Annual Interest Rate: {AnnualInterestRate / 100}";
        }
    }

    public class Book
    {
        //This Class doesn't require fields

        //properties
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        //Constructors
        public Book() { }

        public Book(string title, string author, int numberOfPages)
        {
            Title = title;
            Author = author;
            NumberOfPages = numberOfPages;
        }

        public override string ToString()
        {

            return $"Title: {Title}\n" +
                $"Author: {Author}\n" +
                $"Number of pages: {NumberOfPages}";
        }
    }

    public class Library
    {
        //This class has no fields

        //Properties
        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //Constructors
        public Library() { }

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
        }

        public override string ToString()
        {
            string booksInLibrary = "";

            foreach (Book b in Books)
            {
                booksInLibrary += b + "\n\n";
            }

            return $"Books:\n\n{booksInLibrary}" +
                $"Library Name: {LibraryName}\n" +
                $"Address: {StreetAddress}, {City}, {State} {Zip}";
        }
    }

    public class Song
    {
        //This class doesn't need fields

        //Properties
        public string Artist { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //Constructors
        public Song() { }

        public Song(string artist, string title, string genre)
        {
            Artist = artist;
            Title = title;
            Genre = genre;
        }

        public override string ToString()
        {
            return $"Artist: {Artist}\n" +
                $"Title: {Title}\n" +
                $"Genre: {Genre}\n";
        }
    }

    public class Artist
    {
        //This class has no fields

        //Properties
        public Song[] Tracks { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        //Ctors
        public Artist()
        {

        }

        public Artist(Song[] tracks, string title, string genre)
        {
            Tracks = tracks;
            Title = title;
            Genre = genre;
        }

        public override string ToString()
        {
            string tracksByArtist = "";

            foreach (Song s in Tracks)
            {
                tracksByArtist += s + "\n";
            }

            return $"Tracks: {tracksByArtist} \n" +
                $"Title: {Title}\n" +
                $"Genre: {Genre}\n";
        }

    }

}

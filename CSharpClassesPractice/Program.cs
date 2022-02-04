using ClassLibrary;


//Global Variables
#region Variables
// People
ContactInfo Person1 = new ContactInfo("1421 E 15th St", "Independence", "MO", "64052", "(816) 231-3412", "edwardiiibarrier@gmail.com");

//Customers
Customer customer = new Customer("1", "Edward", "Barrier", Person1);

//Books
Book lordLoss = new Book("Lord Loss", "Darren Shan", 224);
Book harryPotter = new Book("Harry Pooter and the Deathly Hallows", "J.K. Rowling", 523);

//Songs
Song moonlight = new Song("Ariana Grande", "Moonlight", "Pop");
Song doYouBelieve = new Song("Ali Gatie", "Do You Believe", "Pop");
#endregion


//Main Workspace
#region Call Methods
// ********** Student Class ********** //
//StudentClass();

// ********** Vehicle Class ********** //
//VehicleClass();

// ********** Login Class ********** //
//LoginClass();

// ********** Contact Info ********** // 
//ContactInfo();

// *********** Customer Info ********** //
//Customer();

// ********** Credit Card Account *********** //
//CreditCardAccount();

// ********** Book ********** //
//Book();

// ********** Library ********** //
//Library();

// *********** Song *********** //
//Song();

// ********** Artist ********** //
//Artist();

// ********** MotorHome ********** //
//MotorHome();

// *********** Truck *********** //
//Truck();

#endregion


//Created Methods
#region Methods
void StudentClass()
{
    Student studentOne = new Student("Edward", "Barrier", "1", 4);
    Console.WriteLine(studentOne);
}

void VehicleClass()
{
    Vehicle fordMustang = new Vehicle("Ford", "Mustang GT", 2003, 3000);
    Console.WriteLine(fordMustang);
}

void LoginClass()
{
    Login credentials = new Login("edwardiiibarrier@gmail.com", "123");
    Console.WriteLine(credentials);
}

void ContactInfo()
{
    Console.WriteLine(Person1);
}

void Customer()
{
    Console.WriteLine(customer);
}

void CreditCardAccount()
{
    CreditCardAccount edward = new CreditCardAccount(1, customer, 321.12m, false, 5 );
    Console.WriteLine(edward);
}

void Book()
{
    Console.WriteLine(lordLoss);
}

void Library()
{
    List<Book> books = new List<Book>() { lordLoss, harryPotter };
    Library kansasCity = new Library(books, "Kansas City Library", "3242 E 24th St", "Kansas City", "MO", "64115");

    Console.WriteLine(kansasCity);
}

void Song()
{
    Console.WriteLine(moonlight);
}

void Artist()
{
    Song[] songs = { moonlight, doYouBelieve };
    Artist arianaGrande = new Artist(songs, "The best album", "Pop");
    Console.WriteLine(arianaGrande);
}

void MotorHome()
{
    MotorHome truckOne = new MotorHome(1, "Ford", "Ranger", 2021, 4500);
    Console.WriteLine(truckOne);
}

void Truck()
{
    Truck chevy = new Truck("Chevy", "Silverado", 2017, 5500, 2300);
    Console.WriteLine(chevy);
}
#endregion

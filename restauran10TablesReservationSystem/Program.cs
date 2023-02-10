// See https://aka.ms/new-console-template for more information

/*
 * 1.Validar si el usuario existe o si se debe registar.Generar un sistema de registro o login.
 * 2.El programa debe ser capaz de darle la bienvenida si el usuario exite.
 * 3.El programa debe repetirse hasta que se registren 10 personas.
 */

using System.Security;

string[] userNames = new string[10]{ "","","","","","","","","",""};
int currentIndex = 0;
bool userType;

Console.WriteLine("Welcome to the best restaurant in the world");
while (true)
{
    if (currentIndex == 10)
    {
        Console.WriteLine("The restaurant is full, try again next year.");
        Environment.Exit(0);
    }
    Console.WriteLine("\n Are you a registered user? Write true, or false to register.");
    userType = Convert.ToBoolean(Console.ReadLine());
    if (userType == true)
    {
        Console.WriteLine("\n Hello, you are a registered user, please enter your exact user name.");
        string userToSearch = Console.ReadLine();
        int index = Array.IndexOf(userNames, userToSearch);
        if (index == -1)
        {
            Console.WriteLine("User not found, try again or register.");
        }
        else
        {
            Console.WriteLine("Welcome {0}, it is a pleasure to serve you.", userNames[index]);
        }
    } 
    else if (userType == false)
    {
        Console.WriteLine("Please write and remember your user name");
        userNames[currentIndex] = Console.ReadLine();
        Console.WriteLine("Your user has been saved succesfully\n" + "Your user name is {0}", userNames[currentIndex]);
        currentIndex++;
    }
}
// See https://aka.ms/new-console-template for more information

/*
 * 1.Validar si el usuario existe o si se debe registar.Generar un sistema de registro o login.
 * 2.El programa debe ser capaz de darle la bienvenida si el usuario exite.
 * 3.El programa debe repetirse hasta que se registren 10 personas.
 */

string[] userNames = new string[10]{ "Miguel","","","","","","","","",""};
int currentIndex = 1;
bool userType;

Console.WriteLine("Welcome to the best restaurant in the world");
while (true)
{
    Console.WriteLine("Are you a registered user? Write true, or false to register.");
    userType = Convert.ToBoolean(Console.ReadLine());
    if (userType == true)
    {
        Console.WriteLine("Hello, you are a registered user, please enter your exact user name");
        string userToSearch = Console.ReadLine();
        Console.WriteLine("The user you searched is {0}",userToSearch);
    }
}
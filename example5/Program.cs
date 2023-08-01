// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username == "Маша")
{
    Console.WriteLine("УРА ЭТО ЖЕ МАША");
}
else
{
    Console.WriteLine("привет,");
    Console.WriteLine(username);
}
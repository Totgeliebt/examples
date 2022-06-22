Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if( username.ToLower() == "маша")
{
    Console.WriteLine("ура, Маша!");
}
else 
{
    Console.WriteLine("ПРивет, ");
    Console.WriteLine(username);
}
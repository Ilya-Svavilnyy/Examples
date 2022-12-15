Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "катя")
{
    Console.WriteLine("Опа опа опа-па...это же Катя!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
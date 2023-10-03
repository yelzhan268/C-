Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "айза")
{
    Console.WriteLine("Ура, это же Айза!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
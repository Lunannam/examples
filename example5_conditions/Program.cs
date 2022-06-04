Console.WriteLine("Введите имя пользователя:");
string unsername = Console.ReadLine();

if(unsername.ToLower() == "Маша")
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(unsername);
}
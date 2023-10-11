Console.Write("Enter username: ");
string username = Console.ReadLine();

if(username.ToLower() == "admin")
{
    Console.WriteLine("Hi, my dear friend");
}
else
{
    Console.Write("Hello, ");
    Console.WriteLine(username);
}

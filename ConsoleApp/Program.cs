using ConsoleApp.Models;

class Program
{
    static void Main(string[] args)
    {
        User user = new User();
        user.Id = 1;
        user.Name = "Damien";
        user.LastName = "Gaschy";
        user.Old = 20;
        user.AnnualSalaryBrut = 6000;
        user.Tax = 0.2;

        Console.WriteLine($"Id: " +
            $"{user.Id}, " +
            $"\nName: {user.Name}, " +
            $"\nLast Name: {user.LastName}, " +
            $"\nAge: {user.Old}, " +
            $"\nAnnual Salary: {user.AnnualSalaryBrut}, " +
            $"\nTax: {user.Tax}");
    }
}
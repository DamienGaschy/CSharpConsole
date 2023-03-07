using ProjetCSharp.Models.User;


class Program2
{


    static double calculateSalary(int salary, double taxes)
    {
        return salary * (1 - taxes / 100);
    }

    static void Main(string[] args)
    {
        string[] month = new string[] { "Janvier", "F�vrier", "Mars", "Avril", "Mai", "Juin", "juillet", "Aout", "Septembre", "Octobre", "Novembre", "D�cembre" };
        string closedMonth = "Aout";
        double tauxPrime = 0;

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("\nQuel est votre Pr�nom : ");
        string firstname = Console.ReadLine();
        Console.WriteLine("\nQuel est votre Nom : ");
        string lastname = Console.ReadLine();
        Console.WriteLine("\nQuel est votre �ge : ");
        int old = int.Parse(Console.ReadLine());
        Console.WriteLine("Quel est votre Salaire annuel Brut : ");
        bool salaryInInt = int.TryParse(Console.ReadLine().Replace("�", ""), out int salary);
        Console.WriteLine("\nQuel est votre Taux d'imposition : ");
        double taxes = double.Parse(Console.ReadLine().Replace("%", ""));
        Console.WriteLine("\nQuel est le Taux de la prime de fin d'ann�e : ");
        try
        {
            tauxPrime = double.Parse(Console.ReadLine().Replace("%", ""));
        }
        catch (FormatException)
        {
            Console.WriteLine("Le taux de la Prime de fin d'ann�e doit �tre un entier");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("La division ne peux pas �tre par 0");
        }
        User user1 = new User(1, firstname, lastname, old, salary, taxes);
        User user2 = new User(2, "Yanis", "Ezzannati", 18, 125, 95);

        Console.WriteLine("\n" + user1.Firstname + " " + user1.LastName + " Vous avez un salaire de : " + salary + "� Brut" + "\nImposable a " + taxes + "%" + "\n avec une prime de fin d'ann�e de : " + tauxPrime + "%");
        double salaryNet = Math.Round(calculateSalary(salary, taxes), 2);
        Console.WriteLine("\nVous gagnez donc : " + salaryNet + "� Net");
        switch (salary)
        {
            case >= 50000:
                Console.WriteLine("Je vous conseille de faire des dons � des associations tels que l'Oeuvre des Pupilles pour r�duire votre Imposition");
                break;

            case <= 1500 * 12:
                Console.WriteLine("Ce salaire est normal pour un alternant");
                break;

            case <= 40000 when salary >= 30000:
                Console.WriteLine("Venez travailler chez CESI vous gagnerez 100000� brut");
                break;

            default:
                Console.WriteLine("Vous avez un salaire correct");
                break;
        }

        foreach (string eachMonth in month)
        {
            if (eachMonth != closedMonth)
            {
                if (eachMonth == "D�cembre")
                {
                    Console.WriteLine("\n" + eachMonth + " : " + ((salaryNet / 12) * (1 + tauxPrime)));
                }
                else
                {
                    Console.WriteLine("\n" + eachMonth + " : " + salaryNet / 12);
                }
            }
        }


        Console.ReadLine();
    }
}
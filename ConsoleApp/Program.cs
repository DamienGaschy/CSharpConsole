using System.Transactions;

class Programm
{

    //Exercice 2

    static double Taxes(double salary, double taxe)
    {
        return (salary * (1 - taxe / 100));
    }




    static void Main(string[] args)
    {
        //Exercice 1

        Console.WriteLine("Exercice 1\n\n");
        int number = 10;
        string name = "Damien Gaschy";
        double percentage = 10.23;
        char gender = 'M';
        bool isVerified = true;
        Console.WriteLine("Id : " + number);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Percentage : " + percentage);
        Console.WriteLine("Gender : " + gender);
        Console.WriteLine("Verified : " + isVerified);
        Console.WriteLine("---------------------------------------------");
        Console.ReadLine();
        //------------------------------------------------------

        //Exercice 2

        string[] Months = new string[] { "Janvier", "Fevrier", "Mars", "Avril", "Mai", "Juin", "Juillet", "Aout", "Septembre", "Octobre", "Novembre", "Decembre" };
        Console.WriteLine("Exercice 2\n\n");
        Console.Write("Salaire brut : ");

        //Vérification salary
        bool salaryIsDouble = Double.TryParse(Console.ReadLine(), out double salary);
        if (salaryIsDouble)
        {
            switch (salary)
            {
                case > 50000:
                    Console.WriteLine("T'es trop riche , fait des dons pour réduire tes impots !\n");
                    break;
                case < (1500 * 12):
                    Console.WriteLine("tkt mon reuf c'est la rue la vraie pour un alternant\n");
                    break;
                case > 30000 when salary < 40000:
                    Console.WriteLine("Viens au CESI tkt c la vie !\n");
                    break;
                default:
                    break;
            }
        }
        else
        {
            Console.WriteLine("Le Salaire n'est pas une donnée\n");
        }
        Console.Write("Taxe : ");

        //Vérification taxe
        bool taxeIsDouble = Double.TryParse(Console.ReadLine(), out double taxe);
        if (taxeIsDouble)
        {
            Console.WriteLine("La taxe est une donnée \n");
        }
        else
        {
            Console.WriteLine("La taxe n'est pas une donnée\n");
        }
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Salaire Brut : " + salary + " euros\nTaxe : " + taxe + " %");
        Console.WriteLine("");
        //Afficher mois (salaire)
        double salaireNet = 0;
        for (int i = 0; i < 12; i++)
        {
            //Aout
            if (i == 7)
            {
                Console.Write("");
            }
            //Decembre
            else if (i == 11)
            {
                Console.Write("Prime de Décembre : ");
                bool bonusIsDouble = Double.TryParse(Console.ReadLine(), out double bonus);
                try
                {
                    Console.WriteLine(Months[i] + " : " + ((salary / 11) + ((salary * bonus) / 100)));
                    salaireNet = salaireNet + (((salary / 11) + ((salary * bonus) / 100)));
                }
                catch (FormatException)
                {
                    Console.WriteLine("La prime n'est pas dans le bon format");
                }
                catch (Exception)
                {
                    Console.WriteLine("La prime vaux 0");
                }
            }
            else
            {
                Console.WriteLine(Months[i] + " : " + (salary / 11));
                salaireNet = salaireNet + (salary / 11);
            }
        }

        //Fin
        salary = Taxes(salary, taxe);
        Console.WriteLine("\nSalaire Net : " + salaireNet + " euros");
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("\nPressEnterKeyToExit");
        Console.ReadLine();
        //------------------------------------------------------
    }
}
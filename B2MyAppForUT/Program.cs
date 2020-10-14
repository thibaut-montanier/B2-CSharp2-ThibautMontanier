using B2MyLibForUT.Services;
using System;

namespace B2MyAppForUT {
    class Program {
        static void Main(string[] args) {

            MathsService ms = new MathsService();
            Console.WriteLine("num1 : ");

            decimal num1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("num2 : ");
            decimal num2 = decimal.Parse(Console.ReadLine());


            try {
                decimal resultat = ms.Divise(num1, num2);

                Console.WriteLine("Le résultat est " + resultat);
            } catch (DivideByZeroException e) {
                Console.WriteLine("La division par 0 n'est pas possible");
            } catch (Exception e) {
                Console.WriteLine("Une erreur inattendue a eu lieu");
                Console.WriteLine(e.Message);
            }
        }
    }
}

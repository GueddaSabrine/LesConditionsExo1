using System;

namespace LesConditionsExo1
{
    class Program
    {

/*Créer une variable rainy puis lui attribuer une valeur booléenne.
            Dans la console, selon la valeur de rainy, afficher un des messages suivants:
            « Bonjour, il ne pleut pas aujourd’hui, bonne journée. »
            « Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie. »*/
        static void Main(string[] args)
        {
            bool rainy = true;

            if(rainy)
            {
                Console.WriteLine("Bonjour, il pleut aujourd’hui, vous devriez prendre votre parapluie");
            }                
                else
            {
                Console.WriteLine(" Bonjour, il ne pleut pas aujourd’hui, bonne journée");
            }
        }
    }
}

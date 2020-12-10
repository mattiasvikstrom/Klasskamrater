using System;
using System.Collections.Generic;

namespace Klasskamrater
{
    class Metoder
    {
        //Huvudmetoden för programmet. 
        public static void Run()
        {
            List<KlassKamrat> people = MedlemsHanterare.LoadSampleData();
            
            Loggin();
            
            int menyVal = 0;
            do
            {
                Console.WriteLine("\n1. Visa detaljer om medlemmen");
                Console.WriteLine("2. Ta bort en person");
                Console.WriteLine("3. Lista alla medlemmar");
                Console.WriteLine("4. Avsluta\n");

                menyVal = Convert.ToInt32(Console.ReadLine());

                switch (menyVal)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("\nVem vill du se mer om");
                        ListMembers(people);

                        //tar in user input för att kunna ta fram informationen om rätt person
                        int nummer = Convert.ToInt32(Console.ReadLine()); //lägg till felhantering för om någon skriver in namnet.
                        KlassKamrat People = people[nummer - 1];          
                        Console.WriteLine(People);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nVem vill du ta bort?");
                        ListMembers(people);

                        nummer = Convert.ToInt32(Console.ReadLine()); //lägg till felhantering för om någon skriver in namnet.
                        var användare = people[nummer - 1];

                        people.Remove(användare);
                        break;
                    case 3:
                        Console.Clear();
                        ListMembers(people);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            } while (menyVal != 4);
        }

        // listar alla medlemmar i KlassKamrat med numrering.
        private static void ListMembers(List<KlassKamrat> People)
        {
            int i = 1;
            
            foreach (var item in People) 
            {
                Console.WriteLine($"{i++}. {item.Namn}");
            }
        }

        // jämför lösenordet if success annars felmeddelande och validerar lösenordet
        public static void Loggin()
        {
            bool loginSuccess = false;

            
            while (loginSuccess == false)
            {
                Console.WriteLine("Hej och välkommen! vänligen skriv in lösenordet nedan: ");
                string lösenord = Console.ReadLine().Trim();

                if (lösenord == "norrlänningarna")
                {
                    loginSuccess = true;
                }
                else
                {
                    Console.WriteLine("Fel lösenord. Försök igen");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace Klasskamrater
{
    class Metoder
    {
        //Huvudmenyn för programmet. 
        public static void Run()
        {
            //Kallar på PopuleraLista som lägger till våra klasskamrater i people
            List<KlassKamrat> people = MedlemsHanterare.PopuleraLista();
            Loggin();
            int menyVal;

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
                        ListSpecific(people);
                        break;
                    case 2:
                        DeleteSpecific(people);
                        break;
                    case 3:
                        ListMembers(people);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            } while (menyVal != 4);
        }
        // Tar bort vald person från listan, validering sker för att hålla valen inom ramarna för listan, att det är en int och ifall listan inte är tom.
        private static void DeleteSpecific(List<KlassKamrat> people)
        {
            Console.Clear();
            Console.WriteLine("\nVem vill du ta bort?");
            ListMembers(people);
            Console.Write("input: ");
            string stringNummer = Console.ReadLine();
            int intNummer;
            if (Int32.TryParse(stringNummer, out intNummer) && intNummer >= 1 && intNummer <= people.Count && people.Count != 0)
            {
                var användare = people[intNummer - 1];
                Console.Clear();
                Console.WriteLine(people[intNummer - 1].Deleted());
                people.Remove(användare);
            }
            else
            {
                Console.WriteLine("Ojdå. där fanns det ingen klasskamrat.");
            }
        }
        // Listar en specifk person från listan, validering sker för att hålla valen inom ramarna för listan, att det är en int och ifall listan inte är tom.
        private static void ListSpecific(List<KlassKamrat> people)
        {
            Console.Clear();
            Console.WriteLine("\nVem vill du se mer om");
            ListMembers(people);
            Console.Write("input: ");
            string stringNummer = Console.ReadLine();

            int intNummer;
            if (Int32.TryParse(stringNummer, out intNummer) && intNummer >= 1 && intNummer <= people.Count && people.Count != 0)
            {
                KlassKamrat People = people[intNummer - 1];
                Console.WriteLine(People);
            }
            else
            {
                Console.WriteLine("Ojdå. välj en klasskamrat i listan");
            }
        }

        // listar alla medlemmar i KlassKamrat med numrering för att underlätta val av medlem
        private static void ListMembers(List<KlassKamrat> People)
        {
            Console.Clear();
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
                string lösenord = Console.ReadLine();
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

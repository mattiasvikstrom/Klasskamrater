using System;
using System.Collections.Generic;
using System.Threading;

namespace Klasskamrater
{
    class Methods
    {
         //Här initieras List för klasskamrater, hantras inloggning för användren och om lyckad körs MainMenu
        public static void Run()
        {
            //Kallar på PopuleraLista som lägger till våra klasskamrater i people
            List<ClassMates> people = MemberHandler.PopulateList();
            Loggin();
            MainMenu(people);
        }
        //Huvudmenyn för programmet.
        private static void MainMenu(List<ClassMates> people)
        {
            int menuChoice;
            do
            {
                Console.WriteLine("\n1. Visa detaljer om medlemmen");
                Console.WriteLine("2. Ta bort en person");
                Console.WriteLine("3. Lista alla medlemmar");
                Console.WriteLine("4. Avsluta\n");

                menuChoice = Convert.ToInt32(Console.ReadLine());

                switch (menuChoice)
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
            } while (menuChoice != 4);
        }

        // Tar bort vald person från listan, validering sker för att hålla valen inom ramarna för listan, att det är en int och ifall listan inte är tom.
        private static void DeleteSpecific(List<ClassMates> people)
        {
            Console.Clear();
            Console.WriteLine("\nVem vill du ta bort?");
            ListMembers(people);
            Console.Write(">> ");
            string stringNumber = Console.ReadLine();
            int intNumber;
            if (Int32.TryParse(stringNumber, out intNumber) && intNumber >= 1 && intNumber <= people.Count && people.Count != 0)
            {
                var user = people[intNumber - 1];
                Console.Clear();
                Console.WriteLine(people[intNumber - 1].Deleted());
                people.Remove(user);
            }
            else
            {
                Console.WriteLine("Ojdå. där fanns det ingen klasskamrat.");
            }

        }
        // Listar en specifik person från listan, validering sker för att hålla valen inom ramarna för listan, att det är en int och ifall listan inte är tom.
        private static void ListSpecific(List<ClassMates> people)
        {
            Console.Clear();
            Console.WriteLine("\nVem vill du se mer om");
            ListMembers(people);
            Console.Write(">> ");
            string stringNumber = Console.ReadLine();

            int intNumber;
            if (Int32.TryParse(stringNumber, out intNumber) && intNumber >= 1 && intNumber <= people.Count && people.Count != 0)
            {
                ClassMates People = people[intNumber - 1];
                Console.WriteLine(People);
            }
            else
            {
                Console.WriteLine("Ojdå. välj en klasskamrat i listan");
            }
        }

        // listar alla medlemmar i KlassKamrat med numrering för att underlätta val av medlem
        private static void ListMembers(List<ClassMates> People)
        {
            Console.Clear();
            int i = 1;
            if (People.Count != 0)
            {
                foreach (var member in People)
                {
                    Console.WriteLine($"{i++}. {member.Name}");
                }
            }
            //ifall listan är tom så slipper användaren gå vidare i menyerna för att skriva in input då den ändå är tom.
            else
            {
                Console.WriteLine("Listan är helt tom, nu finns inte så mycket mer att göra nu");
                MainMenu(People);
            }
        }

        // jämför lösenordet if success annars felmeddelande. Validerar lösenordet mot en exakt sträng.
        //användaren får 5 försök på sig annars avslutas programmet efter meddelande om detta. counter räknar antal försök från användaren
        public static void Loggin()
        {
            Console.WriteLine("Hej och välkommen! vänligen skriv in lösenordet nedan: ");
            int counter = 0;
            bool loginSuccess = false;
            while (loginSuccess == false)
            {
                Console.Write(">> ");
                string password = Console.ReadLine();
                counter++;
                if (password == "norrlänningarna")
                {
                    loginSuccess = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Välkommen! Du loggas nu in");
                    Console.ResetColor();
                    Thread.Sleep(2000);
                }
                else if(counter >= 5)
                {
                    Console.WriteLine("Du verkar inte ha åtkomst till detta program.. det kommer avslutas om 3 sekunder");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Fel lösenord. Försök igen");
                    Console.WriteLine($"försök: {counter}");
                }
            }
        }
    }
}

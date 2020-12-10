using System;
using System.Collections.Generic;
using System.Text;

namespace Klasskamrater
{
    class Metoder : KlassKamrat
    {
        public static void Run()
        {
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
                        ListMembers(medlemmar);
                        Console.WriteLine("\nVem vill du ha information om?");
                        string personVal = Console.ReadLine().ToLower().Trim(); // säkra input genom borttagande av mellanslag och gör om text till lowercase för att tillåta stora bokstäver i input.
                        switch (personVal) // kan det optimeras. istället för en lång switch? bättre sätt att läsa inputs. kan detta lösas med en metod att valet gör att en specifik lista läses från.
                        {
                            case "emil":
                                Console.WriteLine(emil.Describe());
                                break;
                            case "tina":
                                Console.WriteLine(tina.Describe());
                                break;
                            case "benny":
                                Console.WriteLine(benny.Describe());
                                break;
                            case "josefine":
                                Console.WriteLine(josefine.Describe());
                                break;
                            case "fredrik":
                                Console.WriteLine(fredrik.Describe());
                                break;
                            case "dennis":
                                Console.WriteLine(dennis.Describe());
                                break;
                            case "håkan":
                                Console.WriteLine(håkan.Describe());
                                break;
                            case "tobias":
                                Console.WriteLine(tobias.Describe());
                                break;
                            case "nicklas":
                                Console.WriteLine(nicklas.Describe());
                                break;
                            case "mattias":
                                Console.WriteLine(mattias.Describe());
                                break;
                        }

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("\nAnge nummret på personen du vill ta bort?");
                        ListMembers(medlemmar);

                        int nummer = Convert.ToInt32(Console.ReadLine()); //TODO: lägg till felhantering för om någon skriver in namnet.
                        var användare = medlemmar[nummer - 1];
                        //TODO: lägga till verifiering på borttagningen
                        medlemmar.Remove(användare);
                        break;
                    case 3:
                        Console.Clear();
                        ListMembers(medlemmar);
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            } while (menyVal != 4);
        }

        private static void ListMembers(List<KlassKamrat> medlemmar)
        {
            int i = 1;
            
            foreach (var item in medlemmar) // listar alla medlemmar i KlassKamrat med numrering.
            {
                //Console.Write(item.namn); // separering med ', ' . vill dock stapla lista för mer tydlighet kring medlemmarna och valet man sen ska göra.
                //for (i = 0; i < medlemmar.Count - 1; i++)
                //{
                //    Console.Write(", ");
                //}
                Console.WriteLine($"{i++}. {item.namn}");
            }
        }
        public static void Loggin() // inloggningsmetod
        {
            bool loginSuccess = false;

            // jämför lösenordet if success annars felmeddelande.
            // validerar lösenordet
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

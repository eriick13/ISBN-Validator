using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISBN_validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("---ISBN Validátor---"); // nazev programu
            Console.WriteLine();
            Console.ResetColor();
            bool b = true;





            while (b) // cyklus ktery zajistuje opakovani programu dokud ho uzivatel enterem neukonci
            {
                try // osetreni vyjimek, ohlaseni chybneho zadani uzivateli
                {
                    Console.WriteLine("Zvolte si, který typ ISBN kódu chcete ověřit: ");
                    Console.WriteLine("(nebo ENTER pro ukončení programu)");
                    Console.WriteLine("ISBN-10 = 1");
                    Console.WriteLine("ISBN-13 = 2");
                    Console.Write("Vaše volba: ");
                    string s;
                    s = Console.ReadLine();
                    if (s == String.Empty)
                    {
                        b = false; // konec programu
                        break;
                    }
                    else
                    {
                        int n = int.Parse(s);
                        switch (n) // tri ruzne moznosti, dva pripady a jeden defaultni ktery vyjadruje chybu
                        {
                            case 1:
                                Console.WriteLine();
                                Console.WriteLine("Zadejte kód ISBN-10 který chcete ověřit, ve tvaru: XX-XXX-XXXX-X ");
                                string vstupISBN = System.Console.ReadLine();
                                string ISBN;
                                ISBN = vstupISBN.Remove(2, 1);
                                ISBN = ISBN.Remove(5, 1);
                                ISBN = ISBN.Remove(9, 1); // nacteni ISBN + odstraneni pomlcek
                                if (ISBN.Length > 13) // osetreni chyby
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Chybné zadání!");
                                    Console.WriteLine("");
                                    Console.ResetColor();
                                }
                                else // samotny algoritmus pro validaci kodu ISBN(10)
                                {
                                    int skupina1;
                                    skupina1 = (Convert.ToInt32(ISBN[0])) - 48;
                                    int skupina2;
                                    skupina2 = (Convert.ToInt32(ISBN[1])) - 48;
                                    int vydavatel1;
                                    vydavatel1 = (Convert.ToInt32(ISBN[2])) - 48;
                                    int vydavatel2;
                                    vydavatel2 = (Convert.ToInt32(ISBN[3])) - 48;
                                    int vydavatel3;
                                    vydavatel3 = (Convert.ToInt32(ISBN[4])) - 48;
                                    int vydani1;
                                    vydani1 = (Convert.ToInt32(ISBN[5])) - 48;
                                    int vydani2;
                                    vydani2 = (Convert.ToInt32(ISBN[6])) - 48;
                                    int vydani3;
                                    vydani3 = (Convert.ToInt32(ISBN[7])) - 48;
                                    int vydani4;
                                    vydani4 = (Convert.ToInt32(ISBN[8])) - 48;
                                    int kontrola;
                                    if ((ISBN[9]) == 'X') kontrola = 10;
                                    if ((ISBN[9]) == 'x') kontrola = 10;
                                    else
                                    {
                                        kontrola = (Convert.ToInt32(ISBN[9])) - 48;
                                    }

                                    skupina1 = skupina1 * 10;
                                    skupina2 = skupina2 * 9;
                                    vydavatel1 = vydavatel1 * 8;
                                    vydavatel2 = vydavatel2 * 7;
                                    vydavatel3 = vydavatel3 * 6;
                                    vydani1 = vydani1 * 5;
                                    vydani2 = vydani2 * 4;
                                    vydani3 = vydani3 * 3;
                                    vydani4 = vydani4 * 2;

                                    int soucet = skupina1 + skupina2 + vydavatel1 + vydavatel2 + vydavatel3 + vydani1 + vydani2 + vydani3 + vydani4 + kontrola;
                                    if ((soucet % 11) == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Green;
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Vámi zadaný ISBN-10 kód: " + vstupISBN + " je platný.");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Vámi zadaný ISBN-10 kód: " + vstupISBN + " je neplatný! (může být také chybně zadán)");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                }
                                break;

                            case 2:
                                Console.WriteLine();
                                Console.WriteLine("Zadejte kód ISBN-13 který chcete ověřit, ve tvaru: XXX-XX-XXXX-XXX-X ");
                                string vstupISBN2 = System.Console.ReadLine();
                                string ISBN2;
                                ISBN2 = vstupISBN2.Remove(3, 1);
                                ISBN2 = ISBN2.Remove(5, 1);
                                ISBN2 = ISBN2.Remove(9, 1);
                                ISBN2 = ISBN2.Remove(12, 1); // nacteni ISBN + odstraneni pomlcek
                                if (ISBN2.Length > 17) // osetreni chyby
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.WriteLine("Chybné zadání!");
                                    Console.WriteLine("");
                                    Console.ResetColor();
                                }
                                else // samotny algoritmus pro validaci kodu ISBN(13)
                                {
                                    int prefix1;
                                    prefix1 = (Convert.ToInt32(ISBN2[0])) - 48;
                                    int prefix2;
                                    prefix2 = (Convert.ToInt32(ISBN2[1])) - 48;
                                    int prefix3;
                                    prefix3 = (Convert.ToInt32(ISBN2[2])) - 48;
                                    int skupina12;
                                    skupina12 = (Convert.ToInt32(ISBN2[3])) - 48;
                                    int skupina22;
                                    skupina22 = (Convert.ToInt32(ISBN2[4])) - 48;
                                    int vydavatel12;
                                    vydavatel12 = (Convert.ToInt32(ISBN2[5])) - 48;
                                    int vydavatel22;
                                    vydavatel22 = (Convert.ToInt32(ISBN2[6])) - 48;
                                    int vydavatel32;
                                    vydavatel32 = (Convert.ToInt32(ISBN2[7])) - 48;
                                    int vydavatel42;
                                    vydavatel42 = (Convert.ToInt32(ISBN2[8])) - 48;
                                    int vydani12;
                                    vydani12 = (Convert.ToInt32(ISBN2[9])) - 48;
                                    int vydani22;
                                    vydani22 = (Convert.ToInt32(ISBN2[10])) - 48;
                                    int vydani32;
                                    vydani32 = (Convert.ToInt32(ISBN2[11])) - 48;
                                    int kontrola2;
                                    kontrola2 = (Convert.ToInt32(ISBN2[12])) - 48;

                                    prefix1 = prefix1 * 1;
                                    prefix2 = prefix2 * 3;
                                    prefix3 = prefix3 * 1;
                                    skupina12 = skupina12 * 3;
                                    skupina22 = skupina22 * 1;
                                    vydavatel12 = vydavatel12 * 3;
                                    vydavatel22 = vydavatel22 * 1;
                                    vydavatel32 = vydavatel32 * 3;
                                    vydavatel42 = vydavatel42 * 1;
                                    vydani12 = vydani12 * 3;
                                    vydani22 = vydani22 * 1;
                                    vydani32 = vydani32 * 3;

                                    int soucet2 = prefix1 + prefix2 + prefix3 + skupina12 + skupina22 + vydavatel12 + vydavatel22 + vydavatel32 + vydavatel42 + vydani12 + vydani22 + vydani32 + kontrola2;
                                    if ((soucet2 % 10) == 0)
                                    {
                                        Console.BackgroundColor = ConsoleColor.Green;
                                        Console.ForegroundColor = ConsoleColor.Blue;
                                        Console.WriteLine("Vámi zadaný ISBN-13 kód: " + vstupISBN2 + " je platný.");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                        Console.WriteLine("Vámi zadaný ISBN-13 kód: " + vstupISBN2 + " je neplatný! (může být také chybně zadán)");
                                        Console.ResetColor();
                                        Console.WriteLine();
                                    }
                                }
                                break;

                            default:
                                Console.WriteLine();
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.WriteLine("Neplatná volba. Prosím zvolte 1 nebo 2.");
                                Console.ResetColor();
                                Console.WriteLine();
                                continue;


                        }
                    }
                }

                catch (Exception) // chybove hlaseni
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Chybné zadání!");
                    Console.WriteLine("");
                    Console.ResetColor();
                }

            }
        }

    }
}

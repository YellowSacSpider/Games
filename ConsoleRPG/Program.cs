using System;
using System.Threading;

namespace ConsoleRPG
{
    class Program
    {
        private Character character = new Character();
        private Monsters monster = new Monsters();

        public static void Main(string[] args)
        {
            new Program().Start();
        }

        public void Start()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Witaj w grze RPG!");
            Console.WriteLine("-----------------");
            Thread.Sleep(1000);
            Console.Clear();
            //--------------------------------------
            Console.Write("Wpisz swój nick: ");
            string nick = Console.ReadLine();
            //--------------------------------------
            Console.Clear();
            Console.WriteLine("-----------------");
            Console.WriteLine("Twój nick: " + nick);
            Console.WriteLine("-----------------");
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            //--------------------------------------
            while (character.Klasa == null)
            {
                Console.WriteLine("Wybierz swoją klase: ");
                Console.WriteLine("1. Wojownik");
                Console.WriteLine("2. Łucznik");
                Console.WriteLine("3. Zabójca");
                Console.WriteLine("4. Mag");
                Console.WriteLine("5. Czarnoksiężnik");
                Console.WriteLine("6. Templariusz");
                Console.WriteLine("7. Wampir");
                Console.WriteLine("8. Łupieżca");
                Console.Write("> ");

                string selectClass = Console.ReadLine();

                switch (selectClass)
                {
                    case "1":
                        character.Klasa = "Wojownik";
                        Console.WriteLine("Wybrałeś klase: " + character.Klasa);
                        character.weapon = "Laga";
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "2":
                        character.Klasa = "Łucznik";
                        Console.WriteLine("Wybrałeś klase: " + character.Klasa);
                        character.weapon = "Łuk";
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "3":
                        character.Klasa = "Zabójca";
                        Console.WriteLine("Wybrałeś klase: " + character.Klasa);
                        character.weapon = "Nóż Kuchenny";
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "4":
                        character.Klasa = "Mag";
                        Console.WriteLine("Wybrałeś klase: " + character.Klasa);
                        character.weapon = "Mop";
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "5":
                        character.Klasa = "Czarnoksiężnik";
                        Console.WriteLine("Wybrałeś klase: " + character.Klasa);
                        character.weapon = "Kij";
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "6":
                        character.Klasa = "Templariusz";
                        Console.WriteLine("Wybrałeś klase: " + character.Klasa);
                        character.weapon = "Drewniana Buława";
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "7":
                        character.Klasa = "Wampir";
                        Console.WriteLine("Wybrałeś klase: " + character.Klasa);
                        character.weapon = "Kastet";
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    case "8":
                        character.Klasa = "Łupieżca";
                        Console.WriteLine("Wybrałeś klase: " + character.Klasa);
                        character.weapon = "Długi kij";
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowa komenda.");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }

            }
            Console.WriteLine("Komendy: menu");
            Console.Write("> ");
            while (true)
            {
                string select = Console.ReadLine();

                switch (select)
                {
                    case "menu":
                        Console.Clear();
                        Console.WriteLine("Nick: " + nick + " " + "Złoto: " + character.gold + " " + "Exp: " + character.exp + " " + "Poziom: " + character.lvl + " " + "Klasa: " + character.Klasa);
                        Console.WriteLine("1. Przygoda");
                        Console.WriteLine("2. Arena");
                        Console.WriteLine("3. Kowal");
                        Console.WriteLine("4. Dungeony");
                        Console.WriteLine("5. Statystyki");
                        Console.WriteLine("6. Ekwipunek");
                        Console.WriteLine("7. Sklep");
                        Console.Write("> ");
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Walczysz z Gladiatorem Klasa: [Wojownik]");
                        Console.WriteLine(" ");
                        System.Threading.Thread.Sleep(1000);

                        while(true)
                        {
                            Console.WriteLine("<" + nick + " HP: " + character.hp + "> " + "Atakuje " + "<" + "Gladiatora" + " HP: " + character.zdrowieGladiatora + "> " + " \nZadając: " + character.dmg + " " + "Obrażenia Broni: " + character.dmgBroni);
                            Console.WriteLine(" ");
                            character.zdrowieGladiatora -= character.dmg + character.dmgBroni;
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine("<" + "Gladiator" + " HP: " + character.zdrowieGladiatora + "> " + "Atakuje " + "<" + nick + " HP: " + character.hp + "> " + "\nZadając: " + character.dmgGladiatora);
                            Console.WriteLine(" ");
                            character.hp -= character.dmgGladiatora;
                            System.Threading.Thread.Sleep(1000);

                            if (character.hp <= 0)
                            {

                                Console.WriteLine("Przegrałeś!");
                                System.Threading.Thread.Sleep(1000);
                                break;
                            }

                            if (character.zdrowieGladiatora <= 0)
                            {

                                Console.WriteLine("Wygrałeś!");
                                character.gold = character.gold + 5;
                                character.exp = character.exp + 10;
                                System.Threading.Thread.Sleep(1000);
                                break;
                            }
                        }

                        Console.ReadKey();
                        goto case "menu";

                    default:
                        Console.WriteLine("Nieprawidłowa komenda. Powracanie do menu głównego...");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        goto case "menu";
                    case "5":
                        Console.Clear();
                        Console.WriteLine("|Życie: " + character.hp + "|" + "\n|Mana: " + character.mana + "|" + "\n|Obrażenia: " + character.dmg + "|" + "\n|Obrażenia Broni: " + character.dmgBroni + "|" + "\n|INT: " + character.inta + "|" + "\n|STR: " + character.str + "|" + "\n|DEX: " + character.dex + "|");
                        Console.Write("> ");
                        break;
                    case "6":
                        Console.Clear();
                        for (int indeks = 0; indeks < character.Ekwipunek.Length; indeks++)
                        {
                            Console.WriteLine(character.Ekwipunek[indeks]);
                        }
                        Console.WriteLine("Kliknij dowolny klawisz by powrócic do menu głównego");
                        Console.ReadKey();
                        goto case "menu";

                    case "add hp":
                        character.hp = character.hp + 10;
                        goto case "5";

                    case "set weapon null":
                        character.weapon = null;
                        goto case "menu";

                    case "set weapon 1":
                        character.weapon = "Laga";
                        goto case "menu";

                    case "set inta 10":
                        character.inta += 10;
                        goto case "menu";

                    case "set str 10":
                        character.str += 10;
                        goto case "menu";

                    case "set dex 10":
                        character.dex += 10;
                        goto case "menu";

                }
                character.Ekwipunek[0] = "Broń: " + character.weapon;
                character.Ekwipunek[1] = "Zbroja: " + character.armor;
                character.Ekwipunek[2] = "Artefakt: " + character.artifacts;
                character.Ekwipunek[3] = "Pierścień: " + character.ring;
                character.Ekwipunek[4] = "Kryształ Mocy: " + character.CrystalOfPower;
                character.Ekwipunek[5] = "Hełm: " + character.helmet;
                character.Ekwipunek[6] = "Esencja: " + character.essence;



                //Potwory
                monster._Monsters[0] = "Pająk"; monster._MonstersHP[0] = 100; monster._MonstersDMG[0] = 10;
                monster._Monsters[1] = "Pająk2"; monster._MonstersHP[0] = 200; monster._MonstersDMG[0] = 20;

                while (character.weapon == null)
                {
                    character.dmgBroni = 0;
                    break;
                }
                while (character.weapon == "Laga")
                {
                    character.dmgBroni = 5;
                    break;
                }

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRPG
{
    public class Character
    {
        public int gold = 0;
        public int exp = 100;
        public int lvl = 1;
        public int hp = 100;
        public int dmgBroni = 0;
        public int dmg = 10;
        public int mana = 100;
        public int inta = 1;

        public string Klasa = null;

        //-----Itemy-----//
        public string weapon = null;
        public string armor = null;
        public string artifacts = null;
        public string ring = null;
        public string CrystalOfPower = null;
        public string helmet = null;
        public string essence = null;

        public string[] Ekwipunek = new string[7];

        public int zdrowieGladiatora = 100;
        public int dmgGladiatora = 0;
    }
}

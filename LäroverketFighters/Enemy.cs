using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LäroverketFighters
{
    //En class funkar som en beskrivning av någonting
    //Här beskriver vi hur en fiende fungerar och
    //vilka egenskaper den har
    class Enemy
    {
        public int hp;
        public int dmg;
        public string name;

        //Initialize, sätt värden på variablerna
        public void Setup()
        {
            Random randomness = new Random();

            hp = randomness.Next(5, 10);
            dmg = randomness.Next(1, 5);

            string[] namesToPick =
            {
                "Christina",//0
                "Anton Larsson",//1
                "Frimp",//2
                "Gunnar",//3
                "Boooose",//4
                "Ringo",//5
                "Bajjan"//6
            };

            name = namesToPick[randomness.Next(0, namesToPick.Length)];
        }
    }
}

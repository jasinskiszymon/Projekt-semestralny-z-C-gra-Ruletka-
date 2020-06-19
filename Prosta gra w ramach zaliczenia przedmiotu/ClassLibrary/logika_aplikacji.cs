using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class logika
    {


        public List<string> licznik_wygranych;

        public logika()
        {
            licznik_wygranych = new List<string>();
        }
    
        public static int losowa()
        {
            Random ran = new Random();
            int roll = ran.Next(0, 100);
            return roll;
        }
        public static string losowykolor()
        {
            string[] color = { "Czerwony", "Czarny" };
            var r = new Random();
            string ranColor = color[r.Next(color.Length)];
            return ranColor;
        }
        public void DodajDoListy(string wynik)
        {
            licznik_wygranych.Add(wynik);
        }
        public void WyswietlListe()
        {
            for (int i = 0; i < licznik_wygranych.Count; i++)
            {

                
                Console.WriteLine($"{i} | {licznik_wygranych[i]}");
                
            }
            
        }


        
        
           

        

    }

}

using System;

namespace ClassLibrary
{
    public class logika
    {

        public static int losowa()
        {
            Random ran = new Random();
            int roll = ran.Next(0, 100);
            return roll;
        }
        public static string losowykolor()
        {
            string[] color = { "Red", "Black" };
            var r = new Random();
            string ranColor = color[r.Next(color.Length)];
            return ranColor;
        }



    }
}

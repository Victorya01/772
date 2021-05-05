using System;
using System.IO;



namespace _77
{
    class Program
    {
        
        public void PointClass(string[] EOnigin)
        {
            string v = "Но поздно.Тихо спит Одесса;";
            for (int i = 0; i < EOnigin.Length; i++)
            {
                if(v == EOnigin[i])
                {
                    Console.WriteLine("Строка найдена");
                }
            }


        }


        static void Main(string[] args)
        {
            string[] file_name = File.ReadAllLines("avidreadersevgeniy-onegin.txt");
            Console.WriteLine(file_name[10]);
            string[] EOnegin = file_name;
           


        }
    }
}

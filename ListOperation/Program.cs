using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>number = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            string command = "End";
            while (command == "End")
            {
                Console.WriteLine(command);

            }
            if (command == "Add")
            { 
                number.Add(int.Parse(Console.ReadLine()));
            }
            else if (command == "Remove")
            {
                number.Remove(int.Parse(Console.ReadLine()));
            }
            else if (command == "RemoveAt")
            {
                number.RemoveAt(int.Parse(Console.ReadLine()));
            }
            else if (command == "Insert")
            {
                string[] input = Console.ReadLine().Split(' ');
                int value = int.Parse(input[0]);
                int index = int.Parse(input[1]);
                number.Insert(index, value);
            }
            else if (command == "End")
            {
                Console.WriteLine(string.Join(" ", number));
            }
        }
}

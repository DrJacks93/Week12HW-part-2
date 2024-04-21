using System;
using static System.Console;

namespace Week12HW_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numParts;

            WriteLine("How many parts do you wish to enter?");

            numParts = Convert.ToInt32(Console.ReadLine());

            Parts[] partArray = new Parts[numParts];

            for (int x = 0; x < partArray.Length; x++)
            {
                populatePart(ref partArray[x]);

            }


            static void populatePart(ref Parts e)
            {
                WriteLine("Please enter part number");
                int pNumb = Convert.ToInt32(Console.ReadLine());

                WriteLine("Please enter part name");
                string pn = ReadLine();

                WriteLine("Please enter part description");
                string pd = ReadLine();

                WriteLine("Please enter part cost");
                double c = Convert.ToDouble(Console.ReadLine());


                e = new Parts(pNumb, pn, pd, c);

            }

            WriteLine("Which part would you like to view the data on?");

            for (int z = 0; z < partArray.Length; z++)
            {
                WriteLine(z + 1 + " " + partArray[z].PName);


            }

            int selectedPosition = Convert.ToInt32(Console.ReadLine());

            Parts selectedPart = partArray[selectedPosition - 1];


            WriteLine("{0,20},{1,20},{2,20},{3,20 }", "Part Number", "Part Name" ,"Part Description", "Part Cost");

           

            WriteLine("{0,20},{1,20},{2,20},{3,20}", selectedPart.PartNumber, selectedPart.PName, selectedPart.PDescription, selectedPart.Cost);







        }
    }
}

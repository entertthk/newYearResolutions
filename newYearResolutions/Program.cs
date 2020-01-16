using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newYearResolutions
{
    class Resolution
    {
        public string description;

        public Resolution(string _description)
        {
            description = _description;
        }
        public Resolution()
        {
          
        }


    }
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Create an empty.txt file
            string filePath = @"C:\demo\newYearResolutions.txt";
 
            // 2. Ask the user to add a New Years Resolution(at first, the user might add it in one line separated by a comma)
            
            Console.WriteLine("Write your new year resolutions: (separate with comma)");
            var enter = Console.ReadLine();
            string[]reso = enter.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<string> resolutions = reso.ToList();

            Start:
            // 3. Write resolutions to the file
            File.WriteAllLines(filePath, resolutions);
            
            // 4. Read the resolutions form the file and use the data that has been read from the file to create the instances(objects) of the Resolution class.
            //List<string> listFromFile = File.ReadAllLines(filePath).ToList();

            // 5. Create a new Class Resolution.The class has got only one property public string Description
            //Resolution resolution1 = new Resolution();

            

            // 8. Let the user add a new resolution.Display the result.Write it to the file.
            

            printList(resolutions);
            Options(resolutions);
            
            File.WriteAllLines(filePath, resolutions);

            // 9. Let the user delete a resolution from the list.Display the result.Write it to the file.

            
            Console.Clear();

            // 6. Add the objects to the list of New Years Resolutions
            List<Resolution> resolutionsOnList = new List<Resolution>();

            foreach (string item in resolutions)
            {

                Resolution tempReso = new Resolution(item);

                resolutionsOnList.Add(tempReso);
                File.WriteAllLines(filePath, resolutions);
            }

            // 7. Display the items from the list of New Years Resolutions.

            
            
            goto Start;


            Console.ReadLine();
        }
        public static List<String> addResolutions(List<String> resolutions)
        {
            Console.Write("Add resolution: ");
            var enter = Console.ReadLine();
            resolutions.Add(enter);
            
       
            return new List<String>();
        }

        public static List<String> removeResolutions(List<String> resoList)
        {
            Console.WriteLine(" Remove from the list.");
            string remove = Console.ReadLine();
            resoList.Remove(remove);
            return new List<String>();

        }

        public static void printList(List<String> resolist)
        {
            int i = 1;
            foreach (string item in resolist)

            {
                Console.WriteLine($" {i}  {item}");
                i++;
            }
            Console.WriteLine("\n");
        }

        public static void Options(List<string> resolutions)
        {
            Console.WriteLine("Add/Remove list (a/r)");
            string userAnswer = Console.ReadLine();

            if (userAnswer == "a")
            {
                addResolutions(resolutions);

            }
            else if (userAnswer == "r")
            {
                removeResolutions(resolutions);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Bye!");
            }
        }

    }
}

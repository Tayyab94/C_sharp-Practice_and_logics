using System;
using System.Collections.Generic;
using System.Text;

namespace c_Sharp
{

    public class ClassicCar
    {
        public string m_Make;
        public string m_Model;

        public int m_year;
        public int m_value;

        public ClassicCar(string make,string model, int year, int value)
        {
            this.m_Make = make;
            this.m_Model = model;
            this.m_year = year; this.m_value = value;
        }
        
    }

   
    class Dictionary_Praactice
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> file = new Dictionary<string, string>();

            file.Add("html", "This is html file");

            file.Add("css", "This is css file");
            file.Add("php", "This is php file");
            file.Add("json", "This is json file");

            try
            {

                file.Add("html", "This is html file");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            foreach (KeyValuePair<string,string> k in file)
            {
                Console.WriteLine($"Key => {k.Key}, value =>{k.Value}");
            }
            Console.ReadKey();



            List<ClassicCar> carList = new List<ClassicCar>();

            populateData(carList);

            Console.WriteLine($"Total Element => {carList.Count}");

            //List<ClassicCar> alfa = carList.FindAll(s => s.m_Make.Contains("Alfa"));
            //Console.WriteLine($"No of alfa {alfa.Count}");
            List<ClassicCar> alfa = carList.FindAll(findAlfa);
            Console.WriteLine($"No of alfa {alfa.Count}");

        }

        static bool findAlfa(ClassicCar classicCar)
        {
            if(classicCar.m_Make.Contains("Alfa"))
            {
                return true;
            }
            return false;
        }
        static void populateData(List<ClassicCar> theList)
        {
            theList.Add(new ClassicCar("Alfa Romeo", "Spider ovoid", 2001, 1500));
            theList.Add(new ClassicCar("altf Romeo", "Spider ovoid", 2201, 2300));
            theList.Add(new ClassicCar("Alfa Romeo", "Spider ovoid", 2401, 1500));
            theList.Add(new ClassicCar("Alfa Romeo", "Spider Bhai", 2011, 152300));
            theList.Add(new ClassicCar("Alfa", "Spider ovoid", 2101, 150120));
            theList.Add(new ClassicCar("Akbar Romeo", "Spider ovoid", 2111, 150210));
            theList.Add(new ClassicCar("Romeo", "Spider ovoid", 2001, 15050));
            theList.Add(new ClassicCar("Alfa Romeo", "Spider ovoid", 2201, 15300));
            theList.Add(new ClassicCar("Testing", "Spider testing void", 2401, 15200));
        }
    }
}

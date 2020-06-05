using System;
using System.IO;

namespace ConsoleApp1
{
    struct MechanicalWorkshop
    {
        public string surname;
        public char firstName;
        public char patronymic;
        public string grade;
        public string job;
        public int amountOfDetails;

        public MechanicalWorkshop(string lineWithAllData)
        {
            string[] linesWiThDataAboutOneWorker = lineWithAllData.Split(' ');

            this.surname = linesWiThDataAboutOneWorker[0];
            this.firstName = Convert.ToChar(linesWiThDataAboutOneWorker[1]);
            this.patronymic = Convert.ToChar(linesWiThDataAboutOneWorker[2]);
            this.grade = linesWiThDataAboutOneWorker[3];
            this.job = linesWiThDataAboutOneWorker[4];
            this.amountOfDetails = Convert.ToInt32(linesWiThDataAboutOneWorker[5]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = @"input.txt";

            MechanicalWorkshop[] workers = ReadData(path);

            runMenu(workers);
            Console.ReadKey();
        }
        static void runMenu(MechanicalWorkshop[] workers)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].job == "Tokar" && workers[i].grade == "1")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "150");
                }

                else if (workers[i].job == "Tokar" && workers[i].grade == "2")
                {
                        Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "200");
                }

                else if (workers[i].job == "Tokar" && workers[i].grade == "3")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "250");
                }

                else if (workers[i].job == "Naladchyk" && workers[i].grade == "1")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "125");
                }

                else if (workers[i].job == "Naladchyk" && workers[i].grade == "2")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "175");
                }

                else if (workers[i].job == "Naladchyk" && workers[i].grade == "3")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "225");
                }

                else if (workers[i].job == "Frezyruval'nyk" && workers[i].grade == "1")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "240");
                }

                else if (workers[i].job == "Frezyruval'nyk" && workers[i].grade == "2")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "260");
                }

                else if (workers[i].job == "Frezyruval'nyk" && workers[i].grade == "3")
                {
                    Console.WriteLine(workers[i].surname + " " + " " + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "280");
                }

                else if (workers[i].job == "Slyusar" && workers[i].grade == "1")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "140");
                }

                else if (workers[i].job == "Slyusar" && workers[i].grade == "2")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "200");
                }

                else if (workers[i].job == "Slyusar" && workers[i].grade == "3")
                {
                    Console.WriteLine(workers[i].surname + " " + workers[i].firstName + " " + workers[i].patronymic + " " + "260");
                }
            }
        }

        static MechanicalWorkshop[] ReadData(string fileName)
        {
            string[] pathForFile = File.ReadAllLines(fileName);
            MechanicalWorkshop[] ArrayOfMechanicalWorkshop = new MechanicalWorkshop[pathForFile.Length];
           
            for(int i = 0; i < pathForFile.Length; i++)
            {
                ArrayOfMechanicalWorkshop[i] = new MechanicalWorkshop(pathForFile[i]);
            }
            return ArrayOfMechanicalWorkshop;
        }
    }
}

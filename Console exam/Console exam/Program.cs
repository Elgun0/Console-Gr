using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInp;
            do
            {
                Console.ResetColor();
                Console.WriteLine("Select one of the below");
                Console.WriteLine("1.Creat group and group list");
                Console.WriteLine("2.Create student");
                Console.WriteLine("3.Create teacher");
                Console.WriteLine("4.Select group name and add student");
                Console.WriteLine("5.Add student in group");
                Console.WriteLine("6.Show teacher's information and group");
                Console.WriteLine("7.Show Groups");
                Console.WriteLine("8.Exit");
                string userInput = Console.ReadLine();
                if(int.TryParse(userInput, out userInp))
                {
                    switch (userInp)
                    {
                        case 1:
                            Group.AddGruop();
                            break;
                        case 2:
                            Student.AddStudent();
                            break;
                        case 3:
                            Teacher.AddTeacher();
                            break;
                        case 4:
                            Group.ShowGroupandAdd();
                            break;
                        case 5:
                            ;
                            break;
                        case 8:
                            break;
                        default:
                            Console.WriteLine("Please enter only above number");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("**************");
                    Console.WriteLine("Please enter only numeric number! \n");
                    Console.WriteLine("**************");
                }

            } while (userInp!=8);

        }
    }
}

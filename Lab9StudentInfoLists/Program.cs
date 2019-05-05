using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9StudentInfoLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our class!");
            bool run = true;
            bool proceed = true;
            bool go = true;
            int answer1;
            string input;

            List<string> names = new List<string>() { "Bruce Banner", "Clint Barton", "Natasha Romanoff", "Steve Rogers", "Tony Stark", "Thor Odinson" };
            List<string> hometown = new List<string>() { "Dayton", "Waverly", "Stalingrad", "Brooklyn", "Manhattan", "Asgard" };
            List<string> food = new List<string>() { "Tacos", "Pizza", "Pad Thai", "Grilled Chicken", "Vegetarian Lasagna", "Steak" };
            List<string> nickname = new List<string>() { "Hulk", "Hawkeye", "Black Widow", "Captain America", "Iron Man", "Thor" };

            while (run)
            {
                int number = 1;

                foreach (string student in names)
                {
                    Console.WriteLine($"{number}: {student}");
                    number++;
                }
                Console.WriteLine("Would you like to learn about a student or add a student? Press 1 to learn.  Press 2 to add.  Press any key to exit.");
                answer1 = int.Parse(Console.ReadLine());
                    
                if (answer1 == 1)
                {

                    try
                    {
                        while (proceed)
                        {
                            Console.WriteLine("Which student would you like to learn about today(enter the number next to their name)?  ");
                            int index = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Would you like learn to more about {names[index - 1]}? Enter: y/n ");
                            string response = Console.ReadLine().ToLower();

                            if (response == "y")
                            {
                                while (go)
                                {

                                    Console.WriteLine("Would you like to know their hometown, favorite food or nickname? Enter: home/food/nick");
                                    string answer = Console.ReadLine().ToLower();

                                    if (answer == "home")
                                    {
                                        Console.WriteLine($"{ names[index - 1]} hometown is {hometown[index - 1]}");
                                        Console.WriteLine($"Would you like to learn more about {names[index - 1]}? Enter: y/n ");
                                        string option = Console.ReadLine().ToLower();

                                        if (option == "y")
                                        {
                                            proceed = true;
                                        }
                                        else if (option == "n")
                                        {
                                            Console.WriteLine("Would you like to return to the main menu or exit the program?" +
                                            " \nPress 1 for Main Menu or Press 2 to exit the program");
                                            string selection = Console.ReadLine();

                                            if (selection == "1")
                                            {
                                                break;
                                            }
                                            else if (selection == "2")
                                            {
                                                Console.WriteLine("Have a great day!  ");
                                                System.Environment.Exit(0);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Entry");
                                                run = true;
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid Entry");
                                            run = true;
                                        }
                                    }

                                    else if (answer == "food")
                                    {
                                        Console.WriteLine($"{ names[index - 1]} favorite food is {food[index - 1]}");
                                        Console.WriteLine($"Would you like to learn more about {names[index - 1]}? Enter: y/n ");
                                        string reply = Console.ReadLine().ToLower();
                                        if (reply == "y")
                                        {
                                            proceed = true;
                                        }
                                        else if (reply == "n")
                                        {
                                            Console.WriteLine("Would you like to return to the main menu or exit the program?" +
                                            " \nPress 1 for Main Menu or Press 2 to exit the program");
                                            string selection = Console.ReadLine();

                                            if (selection == "1")
                                            {
                                                break;
                                            }
                                            else if (selection == "2")
                                            {
                                                Console.WriteLine("Have a great day!  ");
                                                System.Environment.Exit(0);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Entry");
                                                run = true;
                                            }
                                        }
                                    }
                                    else if (answer == "nick")
                                    {
                                        Console.WriteLine($"{ names[index - 1]} nickname is {nickname[index - 1]}");
                                        Console.WriteLine($"Would you like to learn more about {names[index - 1]}? Enter: y/n ");
                                        string choice = Console.ReadLine().ToLower();
                                        if (choice == "y")
                                        {
                                            proceed = true;
                                        }
                                        else if (choice == "n")
                                        {
                                            Console.WriteLine("Would you like to return to the main menu or exit the program?" +
                                            " \nPress 1 for Main Menu or Press 2 to exit the program");
                                            string selection = Console.ReadLine();

                                            if (selection == "1")
                                            {
                                                break;
                                            }
                                            else if (selection == "2")
                                            {
                                                Console.WriteLine("Have a great day!  ");
                                                System.Environment.Exit(0);
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("Invalid Entry");
                                                proceed = false;
                                                run = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid Entry ");
                                        proceed = true;
                                    }
                                }
                                break;
                            }
                            else if (response == "n")
                            {
                                Console.WriteLine("Would you like to return to the main menu or exit the program?" +
                                " \nPress 1 to return to the main menu or Press 2 to exit the program");
                                string selection = Console.ReadLine();
                                if (selection == "1")
                                {
                                    run = true;
                                }
                                else if (selection == "2")
                                {
                                    Console.WriteLine("Have a great day!  ");
                                    System.Environment.Exit(0);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid Entry");
                                    run = true;
                                }
                            }

                            else
                            {
                                Console.WriteLine("invalid entry");
                                run = true;
                            }
                            break;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        Console.WriteLine("That student does not exist. Please try again.");
                        run = true;
                    }

                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid entry.  Please try again.");
                        run = true;
                    }
                }
                else if (answer1 == 2)
                {
                    Console.WriteLine("Please enter new student name: ");
                    names.Add(input = AddStudent.ValidateNewStudent("Please enter new student name: "));

                    Console.WriteLine("Please enter new student hometown: ");
                    hometown.Add(input = AddStudent.ValidateNewStudent("Please enter new student hometown: "));

                    Console.WriteLine("Please enter new student favorite food: ");
                    food.Add(input = AddStudent.ValidateNewStudent("Please enter new student favorite food: "));

                    Console.WriteLine("Please enter new student nickname: ");
                    nickname.Add(input = AddStudent.ValidateNewStudent("Please enter new student nickname: "));

                    Console.WriteLine("New student has been added");

                    run = true;
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                    run = true;
                }   
            }
        }
    }  
}

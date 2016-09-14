using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo;

namespace Todo_Console
{
    public class Program
    {
       /// <summary>
       /// A list to hode enrites.
       /// </summary>
        private static List<string> _entries = new List<string> { };
       
        public static void Main(string[] args)
        {
            // TODO: Implement the Todo console app.
            Console.WriteLine("To Do");
            Console.WriteLine("=====");
            Console.WriteLine("No entry to display");
            Console.WriteLine("No active entries");
            Menu();

            // this is uesed inside while loop to indicate if the program would run or not. 
            bool _exit = false;
            
            while (!_exit)
            {
                Console.Write("Enter selection(1..7): ");
                int selection = Int32.Parse(Console.ReadLine());

                if (selection == 2)
                {
                    Console.WriteLine("here!!!");
                    TwoSelected();
                    Console.WriteLine("finished!!!");
                    
                }
                else if (selection == 1)
                {
                    OneSelected();
                    
                }
                else  if (selection == 3)
                {
                    ThreeSelected();
                }
                else if (selection == 4)
                {
                    FourSelected();
                }
                else if (selection == 5)
                {
                    FiveSelected();
                }
                else if (selection == 6)
                {
                    SixSelected();
                }
                else if (selection == 7)
                {
                    _exit = true;
                    Console.WriteLine("Good bye!");
                }

            }

        }

        /// <summary>
        /// this method shows the entries that it currently has
        /// </summary>
        public static void View()
        {
            int temp = 0;
            Console.WriteLine("To Do");
            Console.WriteLine("=====");
            while (temp < _entries.Count)
            {
                Console.WriteLine((temp + 1) + "." + _entries[temp]);
                temp++;
            }
            if (_entries.Count == 1)
            {
                Console.WriteLine(_entries.Count + " " + "active entry");
            }
            else
            {
                Console.WriteLine(_entries.Count + " " + "active entries");
            }
            Menu();

        }

        /// <summary>
        /// this method shows the seven choices.
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("----");
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Edit Entry Description");
            Console.WriteLine("3. Toggle Entry Status");
            Console.WriteLine("4. Delete Entry");
            Console.WriteLine("5. Delete Completed Entries");
            Console.WriteLine("6. Set View Mode");
            Console.WriteLine("7. Exit");
        }

        /// <summary>
        /// this method deal with the case when 1 is selected.
        /// </summary>
        public static void OneSelected()
        {
            Console.Write("Enter description (empty to cancel): ");
            string description = Console.ReadLine();
            if (description != "")
            {
                _entries.Add(description);
            }
            View();
        }
        /// <summary>
        /// this method deal with the case when 2 is selected.
        /// </summary>

        public static void TwoSelected()
        {
            Console.Write("Enter entry number to edit(1..5; 0 to cancel): ");
               int select = Int32.Parse(Console.ReadLine());
            if (select <= _entries.Count && select >= 1)
            {
                Console.Write("Enter a new description (empty to cancle): ");
                string des = Console.ReadLine();
                if (des != "")
                {
                    _entries[select - 1] = des;
                }
            }
        
            View();
        }

        /// <summary>
        /// this method deal with the case when 3 is selected.
        /// </summary>
        public static void ThreeSelected()
        {
            Console.Write("Enter entry number to toggle (1..5; 0 to cancel) ");
            int select = Int32.Parse(Console.ReadLine());
            if (select != 0 && select <= _entries.Count && select >= 1)
            {
                _entries[select - 1] = _entries[select - 1] + " (completed)";

            }
            View();
        }

        /// <summary>
        /// this method deal with the case when 4 is selected.
        /// </summary>
        public static void FourSelected()
        {
            Console.Write("Enter number to delete (1..5; 0 to cancel): ");
            int select = Int32.Parse(Console.ReadLine());
            if (select != 0 && select <= _entries.Count && select >= 1)
            {
                _entries.RemoveAt(select - 1);
            }
            View();
        }

        /// <summary>
        /// this method deal with the case when 5 is selected.
        /// </summary>
        public static void FiveSelected()
        {
            Console.Write("Are you sure you want to delete all completed entries (type 'yes' to confirm)? ");
            if (Console.ReadLine() == "yes")
            {
                
            }
            else if (_entries.Count == 0)
            {
                Console.WriteLine("Completed Entries");
                Console.WriteLine("=================");
                Console.WriteLine("No entry to display");
                Console.WriteLine(_entries.Count + " active entries");
            }
            else
            {
                View();
            }
        }

        /// <summary>
        /// this method deal with the case when 6 is selected.
        /// </summary>
        public static void SixSelected()
        {
            Console.WriteLine("View Mode");
            Console.WriteLine("---------");
            Console.WriteLine("1. Show all enrites");
            Console.WriteLine("2. Show active entries only");
            Console.WriteLine("3. Show completed entries only");
            Console.WriteLine("Enter selection (1..3): ");
            int temp = Int32.Parse(Console.ReadLine());
            if (temp == 1)
            {
                View();
            }
            else if (temp == 2)
            {
                ShowActiveEntries();
            }
            else if (temp == 3)
            {
                ShowCompletedEntries();
            }

        }

        /// <summary>
        /// this method shows the active entries.
        /// </summary>
        public static void ShowActiveEntries()
        {
            int j = 0;
            Console.WriteLine("Active Entries");
            Console.WriteLine("================");
            for (int i = 0; i < _entries.Count; i++)
            {
                if (!_entries[i].Substring(_entries[i].Length - 11, 11).Equals("(completed)"))
                {
                    j++;
                    Console.WriteLine(j + ". " + _entries[i]);
                }

            }
            if (j == 0)
            {
                Console.WriteLine("No Active entry.");
            }
            if (j == 1)
            {
                Console.WriteLine("active entry");
            }
            else
            {
                Console.WriteLine(j + "active entries");
            }
            Menu();

        }
        /// <summary>
        /// this method shows completed entries.
        /// </summary>
        public static void ShowCompletedEntries()
        {
            int j = _entries.Count;
            int c = 0;
            Console.WriteLine("Completed Entries");
            Console.WriteLine("================");
            for (int i = 0; i < _entries.Count; i++)
            {
                if (_entries[i].Contains("(completed)"))
                {
                    if (_entries[i].Substring(_entries[i].Length - 11, 11).Equals("(completed)"))
                    {
                        j--;
                        c++;
                        _entries[i] = _entries[i].Substring(0, _entries[i].Length - 11);
                        Console.WriteLine(c + ". " + _entries[i]);
                    }
                }
            }

            if (c == 0)
            {
                Console.WriteLine("No entry to display");
            }
            if (j == 0)
            {
                Console.WriteLine("No Active entry.");
            }
            if (j == 1)
            {
                Console.WriteLine("1 active entry");
            }
            else
            {
                Console.WriteLine(j + "active entries");
            }
            Menu();
        }



    }
}

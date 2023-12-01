using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int run = 1;
        List<Goal> goals = new List<Goal>();
        while (run != 6) {
            System.Console.WriteLine("Menu options:");

            System.Console.WriteLine("\t1. New Goal");
            System.Console.WriteLine("\t2. List Goals");
            System.Console.WriteLine("\t3. Save Goals");
            System.Console.WriteLine("\t4. Load Goals");
            System.Console.WriteLine("\t5. Record Event");
            System.Console.WriteLine("\t6. Quit");

            System.Console.Write("Select an option: ");
            string optionString = Console.ReadLine();
            int option = int.Parse(optionString);

            switch (option) {
                case 1:
                    Console.Clear();
                    System.Console.WriteLine("Goal options: ");
                    System.Console.WriteLine("\t1. Simple Goal");
                    System.Console.WriteLine("\t2. Eternal Goal");
                    System.Console.WriteLine("\t3. Checklist Goal");
                    System.Console.Write("Select an option: ");

                    string goal = Console.ReadLine();
                    int goalSel = int.Parse(goal);
                    
                    if (goalSel == 1) {
                        SimpleGoal simpleGoal1 = new SimpleGoal();
                        
                        System.Console.Write("Enter the name of the goal: ");
                        string name = Console.ReadLine();
                        
                        System.Console.Write("Enter the amount of points for the goal: ");
                        string pointsString = Console.ReadLine();
                        int points = int.Parse(pointsString);
                        
                        System.Console.Write("Enter a description of the goal: ");
                        string desc = Console.ReadLine();
                        
                        simpleGoal1.NewGoal(name, desc, points);
                        goals.Add(simpleGoal1);
                    }
                    if (goalSel == 2) {
                        EternalGoal eternalGoal1 = new EternalGoal();

                        System.Console.Write("Enter the name of the goal: ");
                        string name = Console.ReadLine();
                        
                        System.Console.Write("Enter the amount of points for the goal: ");
                        string pointsString = Console.ReadLine();
                        int points = int.Parse(pointsString);
                        
                        System.Console.Write("Enter a description of the goal: ");
                        string desc = Console.ReadLine();
                        
                        eternalGoal1.NewGoal(name, desc, points);
                        goals.Add(eternalGoal1);
                    }
                    if (goalSel == 3) {
                        ChecklistGoal checklistGoal1 = new ChecklistGoal();

                        System.Console.Write("Enter the name of the goal: ");
                        string name = Console.ReadLine();
                        
                        System.Console.Write("Enter the amount of points for the goal: ");
                        string pointsString = Console.ReadLine();
                        int points = int.Parse(pointsString);
                        
                        System.Console.Write("Enter the amount of bonus points for the goal: ");
                        string bonusPointsString = Console.ReadLine();
                        int bonusPoints = int.Parse(pointsString);

                        System.Console.Write("Enter the completions required to obtain bonus points: ");
                        string completionsRequiredString = Console.ReadLine();
                        int completionsRequired = int.Parse(completionsRequiredString);
                        
                        System.Console.Write("Enter a description of the goal: ");
                        string desc = Console.ReadLine();
                        bool status = false;

                        checklistGoal1.NewGoal(name, desc, points, status, completionsRequired, bonusPoints);
                        goals.Add(checklistGoal1);
                    }
                    break;
                case 2:
                    Console.Clear();
                    int totalPoints = Goal.DisplayGoals(goals);
                    System.Console.WriteLine($"Total points: {totalPoints}");
                    break;
                case 3:
                Console.Clear();
                    Console.Write("Enter the filepath: ");
                    string filepath = Console.ReadLine();
                    System.IO.File.WriteAllText(@filepath,string.Empty);

                    foreach (Goal item in goals) {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filepath, true)) 
                        {
                            string name = item.GetName();
                            totalPoints = Goal.DisplayGoals(goals);
                            if (item is SimpleGoal) {
                                string type = "Simple";
                                string status = item.GetStatus() ? "true" : "false";
                                file.WriteLine(type + "," + name + "," + status + "," + totalPoints + "," + "0");
                            }
                            if (item is EternalGoal) {
                                string type = "Eternal";
                                string status = "false";
                                file.WriteLine(type + "," + name + "," + status + "," + totalPoints + "," + "0");
                            }
                            if (item is ChecklistGoal) {
                                string type = "Checklist";
                                string status = item.GetStatus() ? "true" : "false";
                                int timesCompleted = item.GetTimesCompleted();
                                file.WriteLine(type + "," + name + "," + status + "," + totalPoints + "," + timesCompleted);
                            }
                        }
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Enter the filepath: ");
                    filepath = Console.ReadLine();
                    goals.RemoveRange(0,goals.Count());
                    using (System.IO.StreamReader reader = new StreamReader(filepath)) {
                            string line;
                            while ((line = reader.ReadLine()) != null) {
                                string[] lineArray = line.Split(",");
                                string type = lineArray[0];
                                string name = lineArray[1];
                                string status = lineArray[2];
                                string timesCompleted = lineArray[3];
                                string totalPoints2 = lineArray[4];
                                int pointsInt = 10;
                                if (type == "Simple") {
                                    SimpleGoal simpleGoal2 = new SimpleGoal();
                                    simpleGoal2.NewGoal(name,"",pointsInt);

                                    goals.Add(simpleGoal2);
                                }
                                if (type == "Eternal") {
                                    EternalGoal eternalGoal2 = new EternalGoal();
                                    eternalGoal2.NewGoal(name, "", pointsInt);

                                    goals.Add(eternalGoal2);
                                }
                                if (type == "Checklist") {
                                    ChecklistGoal checklistGoal2 = new ChecklistGoal();
                                    checklistGoal2.NewGoal(name, "", pointsInt);

                                    goals.Add(checklistGoal2);
                                }
                            }

                    }
                    break;
                case 5:
                    Console.Clear();
                    Goal.DisplayGoals(goals);
                    Console.WriteLine("Which of the above goals would you like to update? ");
                    string selectionString = Console.ReadLine();
                    int selection = int.Parse(selectionString);

                    goals[selection-1].UpdateStatus();

                    break;
                default:
                    run = 6;
                    break;
            }
        }
    }
}
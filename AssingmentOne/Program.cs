// WSUTECH: AssingmentOne v1.0.
// Build date 11/11/2022.
// By: jcmurphy.
// For educational purposes only.


using System;


namespace AssignmentOne
{



    public class Program
    {


        // Datatype for storing values.
        public class HumanHours
        {
            public string Name { get; set; }
            public string Class { get; set; }
            public int Hours { get; set; }
            public int Weeks { get; set; }
            public int Students { get; set; }
            public int Instructors { get; set; }
        }
        static void Main(string[] args)
        {

            // Variable datatype for return from console.
            var classInfo = new HumanHours();

            // Arrays for If, Try, Catch, and Finally.
            bool[] success = { true, true, true, true, true };
            bool[] exception = { false, false, false, false, false };

            // Reset Arrays.
            bool[] successReset = { true, true, true, true, true };
            bool[] exceptionReset = { false, false, false, false, false };

            // Terminal response time.
            int timeSleep = 1000;

            // Variable for total human hours.
            int totalHours;

            // Question #1, Terminal OUT #1.
            Console.WriteLine("What is your name?");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(timeSleep);

            // Answer #1, Terminal IN #1.
            classInfo.Name = Console.ReadLine();
            Console.WriteLine("");

            // Question #2, Terminal OUT #2.
            Console.WriteLine("What is the name of your class?");
            Console.WriteLine("");
            System.Threading.Thread.Sleep(timeSleep);

            // Answer #2, Terminal IN #2.
            classInfo.Class = Console.ReadLine();
            Console.WriteLine("");

            // Loop to continously update.
            while (true)
            {

                // Question #3.
                if (success[0])
                {

                    // Terminal OUT #3.
                    Console.WriteLine("How many weeks is your class scheduled for?");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(timeSleep);
                    try
                    {
                        // Reset exeptions and question loop.
                        exception[0] = false;

                        // Return int from Console string, Terminal IN #3.
                        classInfo.Weeks = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        // Catch exception and write error message, Terminal OUT 3.1.
                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(timeSleep);
                        Console.WriteLine("Answer can only contain numeric responses. Please try again.");
                        System.Threading.Thread.Sleep(timeSleep);
                        exception[0] = true;
                        Console.WriteLine("");
                    }
                    finally
                    {
                        // If no excepetion: Advance to next Question.
                        if (!exception[0])
                        {
                            success[0] = false;
                        }
                    }
                    Console.WriteLine("");
                }
                // Question #4.
                else if (success[1])
                {
                    // Termianl OUT #4.
                    Console.WriteLine("How many hours per week does your class meet?");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(timeSleep);
                    try
                    {

                        // Reset exeptions and question loop.
                        exception[1] = false;
                        // Return int from Console string, Terminal IN #4.
                        classInfo.Hours = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        // Catch exception and write error message, Terminal OUT 4.1.
                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(timeSleep);
                        Console.WriteLine("Answer can only contain numeric responses. Please try again.");
                        System.Threading.Thread.Sleep(timeSleep);
                        exception[1] = true;
                        Console.WriteLine("");
                    }
                    finally
                    {

                        // If no excepetion: Advance to next Question.
                        if (!exception[1])
                        {
                            success[1] = false;
                        }
                    }
                    Console.WriteLine("");
                }
                // Question #5.
                else if (success[2])
                {
                    // Terminal OUT #5.
                    Console.WriteLine("How many students are attending the class?");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(timeSleep);
                    try
                    {
                        // Reset exeptions and question loop.
                        exception[2] = false;
                        // Return int from Console string, Terminal IN #5.
                        classInfo.Students = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        // Catch exception and write error message, Terminal OUT 5.1.
                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(timeSleep);
                        Console.WriteLine("Answer can only contain numeric responses. Please try again.");
                        System.Threading.Thread.Sleep(timeSleep);
                        exception[2] = true;
                        Console.WriteLine("");
                    }
                    finally
                    {
                        // If no excepetion: Advance to next Question.  
                        if (!exception[2])
                        {
                            success[2] = false;
                        }
                    }
                    Console.WriteLine("");
                }
                // Question #6.
                else if (success[3])
                {
                    // Terminal OUT #6.
                    Console.WriteLine("How many instructors are teaching the class?");
                    Console.WriteLine("");
                    System.Threading.Thread.Sleep(timeSleep);
                    try
                    {
                        // Reset exeptions and question loop.
                        exception[3] = false;
                        // Return int from Console string, Terminal IN #6.
                        classInfo.Instructors = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        // Catch exception and write error message, Terminal OUT 6.1.
                        Console.WriteLine("");
                        System.Threading.Thread.Sleep(timeSleep);
                        Console.WriteLine("Answer can only contain numeric responses. Please try again.");
                        System.Threading.Thread.Sleep(timeSleep);
                        exception[3] = true;
                        Console.WriteLine("");
                    }
                    finally
                    {
                        // If no excepetion: Advance to next Question.    
                        if (!exception[3])
                        {
                            success[3] = false;
                        }
                    }
                    Console.WriteLine("");
                }
                // Calculate hours and print message.
                else if (success[4])
                {
                    // Total Human Hours Calcualtion, Terminal OUT 7.
                    totalHours = classInfo.Weeks * classInfo.Hours * (classInfo.Instructors + classInfo.Students);
                    Console.WriteLine(classInfo.Name + "'s class, " + classInfo.Class + ", has ");
                    Console.WriteLine(classInfo.Students + " students and " + classInfo.Instructors + " instructors.");
                    Console.WriteLine("This class will consume " + totalHours + " hours of human life!");
                    Console.WriteLine("We better make the most of it!");
                    // Show message for 15 seconds.
                    System.Threading.Thread.Sleep(15000);
                    // Clear Console. //
                    Console.Clear();
                    // Restart question loop, Question #1, Terminal OUT #1.
                    Console.WriteLine("What is your name?");
                    Console.WriteLine("");
                    // Answer #1, Terminal IN #1.
                    classInfo.Name = Console.ReadLine();
                    Console.WriteLine("");
                    // Question #2, Terminal OUT #2.
                    Console.WriteLine("What is the name of your class?");
                    Console.WriteLine("");
                    // Answer #2, Terminal IN #2.
                    classInfo.Class = Console.ReadLine();
                    Console.WriteLine("");
                    // Reset Arrays for while loop.
                    success = successReset;
                    exception = exceptionReset;

                }
            }
        }
    }
}

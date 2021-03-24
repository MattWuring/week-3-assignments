using System;

namespace opdract_1
{
    class Program
    {
        enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        enum Direction {North, East, South, West, Stay }

        static void Main(string[] args)
        {
            #region daysoftheweek

            WeekDays today = WeekDays.Wednesday;

            switch (today)
            {
                case WeekDays.Monday:
                    Console.WriteLine("Today its Monday");
                    break;

                case WeekDays.Tuesday:
                    Console.WriteLine("Today its Tuesday");
                    break;

                case WeekDays.Wednesday:
                    Console.WriteLine("Today its Wednesday");
                    break;

                case WeekDays.Thursday:
                    Console.WriteLine("Today its Thursday");
                    break;

                case WeekDays.Friday:
                    Console.WriteLine("Today its Friday");
                    break;

                case WeekDays.Saturday:
                    Console.WriteLine("Today its Saturday");
                    break;

                case WeekDays.Sunday:
                    Console.WriteLine("Today its Sunday");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Press [Enter] to continue!");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region Directions

            string choice;
            Direction PlayerDirection;

            Console.WriteLine("Chose a direction that you want to move to:");
            Console.WriteLine();
            Console.WriteLine("Option 1: Move North");
            Console.WriteLine("Option 2: Move East");
            Console.WriteLine("Option 3: Move South");
            Console.WriteLine("Option 4: Move West");
            Console.WriteLine();
            Console.WriteLine("chose one of the options that are given above:");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    PlayerDirection = Direction.North;
                    break;
                case "2":
                    PlayerDirection = Direction.East;
                    break;
                case "3":
                    PlayerDirection = Direction.South;
                    break;
                case "4":
                    PlayerDirection = Direction.West;
                    break;
                case "5":
                    PlayerDirection = Direction.Stay;
                    break;
                default:
                    goto case "5";
                    break;
            }

            switch (PlayerDirection)
            {
                case Direction.North:
                    Console.WriteLine("You have chosen to move North,");
                    Console.WriteLine("Goodluck with your adventures!");
                    break;
                case Direction.East:
                    Console.WriteLine("You have chosen to move East,");
                    Console.WriteLine("Goodluck with your adventures!");
                    break;
                case Direction.South:
                    Console.WriteLine("You have chosen to move South,");
                    Console.WriteLine("Goodluck with your adventures!");
                    break;
                case Direction.West:
                    Console.WriteLine("You have chosen to move West,");
                    Console.WriteLine("Goodluck with your adventures!");
                    break;
                case Direction.Stay:
                    Console.WriteLine("you have chosen to stay in the same spot!");
                    break;
                default:
                    break;
            }
            #endregion
        }

    }
}

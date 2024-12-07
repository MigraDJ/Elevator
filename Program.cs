using static Elevator.ElevatorClass;

namespace Elevator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ElevatorClass elevator = new ElevatorClass();
            try
            {
                Start:

                // Application start or re-start after reaching a new floor            
                Console.WriteLine("Welcome to Gabriel Burrola's HeadQuarter Offices (5 Floors)!");
                Console.WriteLine($"-- Elevator State is: {elevator.elevatorState} --");
                Console.WriteLine($"-- Doors State are: {elevator.doorsState} --");
                Console.WriteLine($"You're now on the floor no. {elevator.currentFloor}, what floor would you like to go to?");

                // Getting the floor target number from user input
                string? target = Console.ReadLine();

                // Validation for a positive integer and non-string value
                bool isInteger = int.TryParse(target, out elevator.targetFloor);
                if (!isInteger)
                {
                    Console.WriteLine("Invalid value, please try again");
                    Console.Beep();
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto Start;
                }

                // Validation for a valid range floor (1 - 5)
                if (elevator.isValidDestinationFloor(elevator.targetFloor))
                {
                    if (elevator.targetFloor == elevator.currentFloor)
                    {
                        Console.WriteLine($"You're already on that floor, please choose a different value");
                        Thread.Sleep(2000);
                        Console.Clear();
                        goto Start;
                    }
                    else
                    {
                        // Prepares elevator to go to target floor
                        elevator.doorsState = DoorsState.Closing.ToString();
                        Console.WriteLine($"-- Doors State are: {elevator.doorsState} --");
                        Thread.Sleep(3000);
                        elevator.doorsState = DoorsState.Closed.ToString();
                        Console.WriteLine($"-- Doors State are: {elevator.doorsState} --");
                        Console.WriteLine($"We're taking you to floor {elevator.targetFloor}, please wait 5 seconds.....");

                        // Validation to know if elevator goes up or down | Updates the elevator state
                        if (elevator.targetFloor < elevator.currentFloor)
                            elevator.Down(elevator.targetFloor);
                        else
                            elevator.Up(elevator.targetFloor);

                        Console.WriteLine($"-- Elevator State is: going {elevator.elevatorState} --");
                        Thread.Sleep(5000);

                        // Arrival to target floor
                        elevator.elevatorState = ElevatorState.Stopped.ToString();
                        elevator.doorsState = DoorsState.Opening.ToString();
                        Console.WriteLine($"-- Elevator State is: {elevator.elevatorState} --");
                        Console.WriteLine($"-- Doors State are: {elevator.doorsState} --");
                        Thread.Sleep(3000);
                        elevator.doorsState = DoorsState.Opened.ToString();
                        Console.WriteLine($"-- Doors State are: {elevator.doorsState} --");
                        Console.Beep();
                        Console.WriteLine($"You're now on floor {elevator.currentFloor}, have a nice day!");
                        Thread.Sleep(5000);
                        Console.Clear();
                        goto Start;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid floor, please try with a value between 1 and 5");
                    Console.Beep();
                    Thread.Sleep(2000);
                    Console.Clear();
                    goto Start;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
        }

        public static string GoToFloorTest(int current, string target)
        {
            ElevatorClass elevator = new ElevatorClass();
            elevator.currentFloor = current;
            try
            {
                // Validation for a positive integer and non-string value
                bool isInteger = int.TryParse(target, out elevator.targetFloor);
                if (!isInteger)
                {
                    return "Invalid value, please try again";
                }

                // Validation for a valid range floor (1 - 5)
                if (elevator.isValidDestinationFloor(elevator.targetFloor))
                {
                    if (elevator.targetFloor == elevator.currentFloor)
                    {
                        return $"You're already on that floor, please choose a different value";
                    }
                    else
                    {
                        // Validation to know if elevator goes up or down | Updates the elevator state
                        if (elevator.targetFloor < elevator.currentFloor)
                            { elevator.Down(elevator.targetFloor); }
                        else
                            { elevator.Up(elevator.targetFloor); }
                        Thread.Sleep(2000);

                        // Arrival to target floor
                        return $"You're now on floor {elevator.currentFloor}, have a nice day!";
                    }
                }
                else
                {
                    return "Invalid floor, please try with a value between 1 and 5";
                }
            }
            catch (Exception e)
            {
                return $"{e.Message} {e.InnerException}";
            }  
        }
  
    }
}

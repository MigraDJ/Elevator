namespace Elevator
{
    public class ElevatorClass
    {
        // Global variables
        public const int totalFloors = 5;
        public int currentFloor = 1;
        public int targetFloor;
        public string elevatorState = ElevatorState.Stopped.ToString();
        public string doorsState = DoorsState.Closed.ToString();

        public bool isValidDestinationFloor(int targetFloor)
        {
            if (targetFloor >= 1 && targetFloor <= totalFloors)
            {
                return true;
            }
            return false;
        }

        public enum ElevatorState
        {
            Stopped,
            Up,
            Down
        }

        public enum DoorsState
        {
            Opened,
            Opening,
            Closed,
            Closing
        }

        public void Up(int targetFloor)
        {
            int temp = currentFloor;
            elevatorState = ElevatorState.Up.ToString();
            for (int i = temp; i <= targetFloor; i++)
            {
                currentFloor = i;
            }
        }

        public void Down(int targetFloor)
        {
            int temp = currentFloor;
            elevatorState = ElevatorState.Down.ToString();
            for (int i = temp; i >= targetFloor; i--)
            {
                currentFloor = i;
            }
        }

    }
}

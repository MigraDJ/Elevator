namespace Tests;

[TestClass]
public class InvalidFloor
{
    [TestMethod]
    public void InvalidFloorNegativeTest()
    {
        //Assign
        string value = "-1"; //Change to any negative, zero or above five value

        //Act
        string response = Elevator.Program.GoToFloorTest(1, value);

        //Assert
        Assert.AreEqual($"Invalid floor, please try with a value between 1 and 5", response);
    }

    [TestMethod]
    public void InvalidFloorZeroTest()
    {
        //Assign
        string value = "0"; //Change to any negative, zero or above five value

        //Act
        string response = Elevator.Program.GoToFloorTest(1, value);

        //Assert
        Assert.AreEqual($"Invalid floor, please try with a value between 1 and 5", response);
    }

    [TestMethod]
    public void InvalidFloorAboveFiveTest()
    {
        //Assign
        string value = "6"; //Change to any negative, zero or above five value

        //Act
        string response = Elevator.Program.GoToFloorTest(1, value);

        //Assert
        Assert.AreEqual($"Invalid floor, please try with a value between 1 and 5", response);
    }
}

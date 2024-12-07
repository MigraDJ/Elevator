namespace Tests;

[TestClass]
public class InvalidValue
{
    [TestMethod]
    public void InvalidValueTest()
    {
        //Assign
        string value = "ABC|1.15"; //Change to any random string or decimal value

        //Act
        string response = Elevator.Program.GoToFloorTest(1, value);

        //Assert
        Assert.AreEqual($"Invalid value, please try again", response);
    }

    [TestMethod]
    public void InvalidFloorNegativeValueTest()
    {
        //Assign
        string value = "-2"; // For negative or decimal number
        //Act
        string response = Elevator.Program.GoToFloorTest(1, value);

        //Assert
        Assert.AreEqual($"Invalid floor, please try with a value between 1 and 5", response);
    }

}

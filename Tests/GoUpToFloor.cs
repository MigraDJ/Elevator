namespace Tests;

[TestClass]
public class GoUpToFloor
{
    [TestMethod]
    public void GoToFloorFiveFromOne()
    {
        //Assign
        string value = "5"; // Goes UP

        //Act
        string response = Elevator.Program.GoToFloorTest(1, value);

        //Assert
        Assert.AreEqual($"You're now on floor 5, have a nice day!", response);
    }

    [TestMethod]
    public void GoToFloorFiveFromThree()
    {
        //Assign
        string value = "5"; // Goes UP

        //Act
        string response = Elevator.Program.GoToFloorTest(3, value);

        //Assert
        Assert.AreEqual($"You're now on floor 5, have a nice day!", response);
    }

}

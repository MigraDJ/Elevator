using Elevator;
namespace Tests;

[TestClass]
public class GoDownToFloor
{
    
    [TestMethod]
    public void GoToFloorOneFromFive()
    {
        //Assign
        string value = "1"; // Goes DOWN

        //Act
        string response = Program.GoToFloorTest(5, value);

        //Assert
        Assert.AreEqual($"You're now on floor 1, have a nice day!", response);
    }

    [TestMethod]
    public void GoToFloorTwoFromFour()
    {
        //Assign
        string value = "2"; // Goes DOWN

        //Act
        string response = Program.GoToFloorTest(4, value);

        //Assert
        Assert.AreEqual($"You're now on floor 2, have a nice day!", response);
    }
}

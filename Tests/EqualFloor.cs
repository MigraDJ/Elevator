namespace Tests
{
    [TestClass]
    public sealed class EqualFloor
    {
        [TestMethod]
        public void EqualFloorTestOne()
        {
            //Assign
            string value = "1";

            //Act
            string response = Elevator.Program.GoToFloorTest(1, value);

            //Assert
            Assert.AreEqual($"You're already on that floor, please choose a different value", response);
        }

        [TestMethod]
        public void EqualFloorTestThree()
        {
            //Assign
            string value = "3";

            //Act
            string response = Elevator.Program.GoToFloorTest(3, value);

            //Assert
            Assert.AreEqual($"You're already on that floor, please choose a different value", response);
        }

        [TestMethod]
        public void EqualFloorTestFive()
        {
            //Assign
            string value = "5";

            //Act
            string response = Elevator.Program.GoToFloorTest(5, value);

            //Assert
            Assert.AreEqual($"You're already on that floor, please choose a different value", response);
        }

    }
}

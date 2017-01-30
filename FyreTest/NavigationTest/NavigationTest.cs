using FyreTest.NavigationTest.Actions;
using FyreTest.NavigationTest.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FyreTest.NavigationTest
{
    [TestClass]
    public class NavigationTest
    {
        [TestMethod]
        public void BeginTest()
        {
            // Location of Store A.
            Building storeA;
            storeA.name = "K-citymarket";
            storeA.x = 10;
            storeA.y = 5;

            // Location of Store B.
            Building storeB;
            storeB.name = "Lidl";
            storeB.x = 20;
            storeB.y = 20;

            // Move to the closest Store.
            MoveSelector movement = new MoveSelector();
            movement.AddAction(new MoveTo(storeA));
            movement.AddAction(new MoveTo(storeB));

            // Choose the closest store and move to it.
            movement.PickAction();
        }
    }
}

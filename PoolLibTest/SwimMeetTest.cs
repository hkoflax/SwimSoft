using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolLib;
using PoolLib.Managers;

namespace PoolLibTest
{
    /// <summary>
    /// Summary description for SwimMeetTest
    /// </summary>
    [TestClass]
    public class SwimMeetTest
    {
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void Display_Event_List_In_Meet()
        {
            // arrange  
            string expectedResult = "";
            SwimMeet aSwimMeet = new SwimMeet();

            // act  
            string actual = aSwimMeet.DisplayEventsList();

            // assert  
            Assert.AreEqual(expectedResult, actual, "Error in Display");
        }
    }
}

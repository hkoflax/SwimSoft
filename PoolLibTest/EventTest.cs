using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolLib;
using PoolLib.Managers;

namespace PoolLibTest
{
    /// <summary>
    /// Summary description for EventTest
    /// </summary>
    [TestClass]
    public class EventTest
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
        public void Display_Empty_Event_Registrant_List()
        {
            // arrange  
            string expectedResult = "";
            Event anEvent = new Event();

            // act  
            string actual = anEvent.DisplayEventList();

            // assert  
            Assert.AreEqual(expectedResult, actual, "Error in Display");
        }
        [TestMethod]
        public void Enter_Swimmers_Time_For_Non_Registrant_InEvent()
        {
            // arrange  
            Registrant aRegistrant = new Registrant();
            Event anEvent = new Event();

            // act  
            try
            {
                anEvent.EnterSwimmersTime(aRegistrant,"00:00.00");
            }
            catch (Exception e)
            {
                // assert  
                StringAssert.Contains(e.Message, aRegistrant.Name + " has not entered " + anEvent.Name);
                return;
            }
            Assert.Fail();
        }
    }
}

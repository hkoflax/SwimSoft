using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PoolLib;
using PoolLib.Managers;

namespace PoolLibTest
{
    /// <summary>
    /// Summary description for SwimmersManagerTest
    /// </summary>
    [TestClass]
    public class SwimmersManagerTest
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
        public void Get_Non_Existant_Swimmer()
        {
            // arrange  
            Registrant expectedResult = null;
            ClubsManager aClubManager = new ClubsManager();
            SwimmersManager aSwimmersManager = new SwimmersManager(aClubManager);

            // act  
            Registrant actual = aSwimmersManager.GetByRegNum(0);

            // assert  
            Assert.AreEqual(expectedResult, actual, "Get Swimmer fail");
        }
        [TestMethod]
        public void Load_swimmers_From_Non_Existing_File()
        {
            // arrange  
            string filename = "not existing";
            ClubsManager aClubManager = new ClubsManager();
            SwimmersManager aSwimmersManager = new SwimmersManager(aClubManager);

            // act  
            try
            {
                aSwimmersManager.Load(filename, "|");
            }
            catch (Exception e)
            {
                // assert  
                StringAssert.Contains(e.Message, "Could not find file");
                return;
            }
            Assert.Fail();
        }
    }
}

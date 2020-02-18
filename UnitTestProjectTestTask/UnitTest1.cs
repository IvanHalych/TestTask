using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestTask;

namespace UnitTestProjectTestTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string str = "Test.txt";
            bool t = Program.Verify( str);
            Assert.AreEqual(t, true);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string[] str = new string[] { "Testtxt", "eee", "Iau","dsda" };
            char[] VowelsCharacters = new char[] { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u', 'Y', 'y' };
            int t = Program.Count(str,VowelsCharacters);
            Assert.AreEqual(t, 2);
        }
    }
}

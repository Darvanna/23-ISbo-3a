using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class Var14_ClassesTests
    {
        [TestMethod]
        public void TestToString()
        {
            var testName = "������������";
            var var14Classes = new Var14_Classes(testName);

            var result = var14Classes.ToString();

            Assert.AreEqual($"��� �������:{testName}", result);
        }
        [TestMethod]
        public void TestConstructor()
        {
            
            var testName = "������������";

            
            var var14Classes = new Var14_Classes(testName);

           
            Assert.AreEqual(testName, var14Classes.name);
        }
    }
}
    

using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class Var14_ClassesTests
    {
        [TestMethod]
        public void TestToString()
        {
            var testName = "Тестирование";
            var var14Classes = new Var14_Classes(testName);

            var result = var14Classes.ToString();

            Assert.AreEqual($"Вид занятия:{testName}", result);
        }
        [TestMethod]
        public void TestConstructor()
        {
            
            var testName = "Тестирование";

            
            var var14Classes = new Var14_Classes(testName);

           
            Assert.AreEqual(testName, var14Classes.name);
        }
    }
}
    

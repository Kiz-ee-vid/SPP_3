namespace TestLib
{
    public class TestClass
    {
        public string type = "Test";

        public int CoolProperty { get; set; }

        public bool One(int a, string b) => false;
        public double Two(double c, double d) => c + d;
    }
}

namespace TestingNamespace
{
    public static class Wow
    {
        public static void ExtensionMethod(string str)
        {

        }
    }
}


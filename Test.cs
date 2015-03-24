using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OSiSP_Lab1;

namespace UnitTestProject1
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            IContravariation<Child> obj = new Contravariation<Base<string>>();
        }

        [TestMethod]
        public void TestMethod2()
        {
            ICovariation<Base<string>> obj = new Covariation<Child>();
        }

        [TestMethod]
        [ExpectedException(typeof(Child))]
        public void TestMethod3()
        {
            IContravariation<Child> obj = new Contravariation<Base<string>>();
            obj = (Contravariation<Child>)obj;
        }

        [TestMethod]
        [ExpectedException(typeof(Child))]
        public void TestMethod4()
        {
            ICovariation<Base<string>> obj = new Covariation<Child>();
            obj = (Covariation<Child>)obj;
        }
    }
}

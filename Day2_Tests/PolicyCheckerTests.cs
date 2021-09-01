using Day2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day2_Tests
{
    [TestClass]
    public class PolicyCheckerTests
    {
        [TestMethod]
        public void PolicyCheckerTest_InputProcessing()
        {
            string input = "15-16 p: ppppppppppplppppp";
            var policyChecker = new PolicyChecker(input);

            Assert.AreEqual(15, policyChecker.Min);
            Assert.AreEqual(16, policyChecker.Max);
            Assert.AreEqual('p', policyChecker.ReqChar);
            Assert.AreEqual("ppppppppppplppppp", policyChecker.Password);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckPass()
        {
            string input = "10-20 p: ppppppppppplppppp";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.Check();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckPass_Min()
        {
            string input = "1-3 p: almap";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.Check();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckPass_Max()
        {
            string input = "1-3 p: almappp";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.Check();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckFail_Min()
        {
            string input = "1-3 p: alma";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.Check();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckFail_Max()
        {
            string input = "1-3 p: almapppp";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.Check();

            Assert.IsFalse(result);
        }
    }
}

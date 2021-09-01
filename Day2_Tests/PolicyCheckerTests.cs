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
        public void PolicyCheckerTest_CheckOldPolicyPass()
        {
            string input = "10-20 p: ppppppppppplppppp";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckOldPolicy();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckOldPolicyPass_Min()
        {
            string input = "1-3 p: almap";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckOldPolicy();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckOldPolicyPass_Max()
        {
            string input = "1-3 p: almappp";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckOldPolicy();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckOldPolicyFail_Min()
        {
            string input = "1-3 p: alma";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckOldPolicy();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckOldPolicyFail_Max()
        {
            string input = "1-3 p: almapppp";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckOldPolicy();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckNewPolicyPass_1stIndex()
        {
            string input = "1-3 p: palma";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckNewPolicy();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckNewPolicyPass_2ndIndex()
        {
            string input = "1-3 p: alpma";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckNewPolicy();

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckNewPolicyFail_NotIn()
        {
            string input = "1-3 p: alma";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckNewPolicy();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckNewPolicyFail_SomewhereElse()
        {
            string input = "1-3 p: almap";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckNewPolicy();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void PolicyCheckerTest_CheckNewPolicyFail_DoubleOccurrence()
        {
            string input = "1-3 p: paplma";
            var policyChecker = new PolicyChecker(input);
            var result = policyChecker.CheckNewPolicy();

            Assert.IsFalse(result);
        }
    }
}

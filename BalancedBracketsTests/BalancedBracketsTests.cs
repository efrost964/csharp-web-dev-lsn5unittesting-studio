using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }
        [TestMethod]
        public void TestOnlyBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }
        [TestMethod]
        public void TestOnlyBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]"));
        }
        [TestMethod]
        public void TestMultipleBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]"));
        }
        [TestMethod]
        public void TestCloseBracketFirstIsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }
        [TestMethod]
        public void TestNoBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(""));
        }
        [TestMethod]
        public void TestMultipleClosedBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }
        [TestMethod]
        public void TestNestedBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[]]"));
        }
        [TestMethod]
        public void TestMisNestedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[]]["));
        }
        [TestMethod]
        public void TestDifferentEnclosingCharacters()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("{}"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("()"));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("<>"));
        }
        [TestMethod]
        public void TestTextInBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[AHHHHHHHH]"));
        }
        [TestMethod]
        public void TestNonBracketCharacters()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("abcdABCD1234!@#$"));
        }
    }
}

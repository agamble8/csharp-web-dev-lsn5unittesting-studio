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
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //Test that no brackets returns true
        [TestMethod]
        public void NoBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //Test that brackets fully enclosing string returns true
        [TestMethod] 
        public void BracketsEnclosesFullStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"));
        }

        //Test that brackets enclosing a portion but not all of string returns true
        [TestMethod]
        public void BracketsEnclosesPartialStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }

        //Test that brackets preceding a string and enclosing no letters returns true
        [TestMethod]
        public void BracketsPrecedesStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]LaunchCode"));
        }

        //Test that nested brackets returns true
        [TestMethod]
        public void NestedBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[[LaunchCode]is]the]best!]"));
        }

        //Test that only 1 bracket and no other string returns false
        [TestMethod]
        public void OnlyOneBracketReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        //Test that 1 bracket AND other characters returns false
        [TestMethod]
        public void OneBracketWithStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        //Test that outfacing bracketswith no other strings returns false
        [TestMethod]
        public void BracketsOutfacingReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        //Test that brackets the wrong way with another string returns false
        [TestMethod]
        public void BracketsOutfacingWithinStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        //Test that nested odd number of brackts returns false
        [TestMethod]
        public void OddNumberOfBracketsWithStringReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[[sdf]sdf[sdfs]sdfs]sdf"));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                              $"Expected for '{word}': true; Actual: {result}");
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                               "1234", ".", ";", " " };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,
                               $"Expected for '{word}': false; Actual: {result}");
            }
        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            string[] words = { String.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word);
                Assert.IsFalse(result,
                               $"Expected for '{(word == null ? "<null>" : word)}': " +
                               $"false; Actual: {result}");

                //result = StringLibrary.StartsWithLower(word);
                //Assert.IsFalse(result,
                //               $"Expected for '{(word == null ? "<null>" : word)}': " +
                //               $"false; Actual: {result}");
            }
        }

        //[TestMethod]
        //public void TestStartsWithLower()
        //{
        //    // Tests that we expect to return false.
        //    string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство" };
        //    foreach (var word in words)
        //    {
        //        bool result = word.StartsWithLower();
        //        Assert.IsTrue(result,
        //                      $"Expected for '{word}': true; Actual: {result}");
        //    }
        //}

        //[TestMethod]
        //public void TestDoesNotStartWithLower()
        //{
        //    // Tests that we expect to return true.
        //    string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва",
        //                       "1234", ".", ";", " "};
        //    foreach (var word in words)
        //    {
        //        bool result = word.StartsWithLower();
        //        Assert.IsFalse(result,
        //                      $"Expected for '{word}': false; Actual: {result}");
        //    }
        //}

        //[TestMethod]
        //public void TestHasEmbeddedSpaces()
        //{
        //    // Tests that we expect to return true.
        //    string[] phrases = { "one car", "Name\u0009Description",
        //                         "Line1\nLine2", "Line3\u000ALine4",
        //                         "Line5\u000BLine6", "Line7\u000CLine8",
        //                         "Line0009\u000DLine10", "word1\u00A0word2" };
        //    foreach (var phrase in phrases)
        //    {
        //        bool result = phrase.HasEmbeddedSpaces();
        //        Assert.IsTrue(result,
        //                      $"Expected for '{phrase}': true; Actual: {result}");
        //    }
        //}
    }
}

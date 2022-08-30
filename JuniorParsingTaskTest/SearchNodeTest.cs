using Xunit;
using JuniorParsingTask;

namespace JuniorParsingTaskTest
{
    public class SearchNodeTest 
    {
        [Fact]
        public void TestDataedo()
        {
            //arrange 
            SearchNode s = new SearchNode();
            Node? node = null;

            //act

            bool result = s.TryGetNode("dataedo", out node);

            //assert
            Assert.NotNull(node);
            Assert.True(result);

        }
        [Fact]
        public void Testxyz()
        {
            //arrange 
            SearchNode s = new SearchNode();
            Node? node = null;

            //act

            bool result = s.TryGetNode("xyz", out node);

            //assert

            Assert.NotNull(node);
            Assert.True(result);

        }
        [Fact]
        public void Testsql()
        {
            //arrange 
            SearchNode s = new SearchNode();
            Node? node = null;

            //act

            bool result = s.TryGetNode("sql", out node);

            //assert
             
            Assert.NotNull(node);
            Assert.True(result);

        }
        [Fact]
        public void Testlearning()
        {
            //arrange 
            SearchNode s = new SearchNode();
            Node? node = null;

            //act

            bool result = s.TryGetNode("learning", out node);

            //assert

            Assert.NotNull(node);
            Assert.True(result);

        }
        [Fact]
        public void TestFake()
        {
            //arrange 
            SearchNode s = new SearchNode();
            Node? node = null;

            //act

            bool result = s.TryGetNode("fake", out node);

            //assert

            Assert.Null(node);
            Assert.False(result);

        }


        [Fact]
        public void TestNotFound()
        {
            //arrange 
            SearchNode s = new SearchNode();
            Node? node = null;

            //act

            bool result = s.TryGetNode("fake", out node);

            //assert

            Assert.False(result);
            Assert.Null(node);

        }







    }
}
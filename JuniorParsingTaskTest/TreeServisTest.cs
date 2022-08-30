using Xunit;
using JuniorParsingTask;

namespace JuniorParsingTaskTest
{
    public class TreeServisTest
    {
        [Fact]
        public void CreateTest()
        {
            //arrange 
            //act

            var tree = TreeService.Create();

            //assert
            Assert.NotNull(tree);
            Assert.NotEmpty(tree.Root.Children);

        }
    }
}

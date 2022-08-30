
namespace JuniorParsingTask
{

    public class SearchNode
    {

        public bool TryGetNode(string value, out Node node)
        {
            var tree = TreeService.Create();
            node = tree.Root;

            foreach (var item in node.Children)
                {
                    if (item.Value == value)
                    {
                        node = item;
                        return true;

                    }
                    else
                    {
                        foreach (var i in item.Children)
                        {
                        node = item;
                            return true;
                        }
                    }
                }
//            }
            //else
            //{
                node = null;
                System.Console.WriteLine("Tree is empty!");
                return false;
            //}




        }

    
    }
}


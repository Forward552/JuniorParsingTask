
namespace JuniorParsingTask
{

    public class SearchNode
    {
        private bool result;

        public bool TryGetNode(string value, out Node? node)
        {
            var tree = TreeService.Create();
            node = tree.Root;
            result = false; 
            TryGetNodeRec(value, node);
            if (result == false) node = null;
            return result;
        }
        private void TryGetNodeRec(string value, Node node)
        {
            foreach (var item in node.Children)
            {
                node = item;
                if (item.Value == value)
                {
                    result = true;
                    break;
                }
                else if (item.Children != null)
                    TryGetNodeRec(value, node);
            }
        }
    }
}


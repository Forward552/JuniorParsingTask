using JuniorParsingTask;

//tree for searching
var tree = TreeService.Create();
string value = "dataedo";

Tree t = new Tree(new Node("root"));
 

foreach (var item in t)
{
    if(item.Value == value) Console.WriteLine("Coś wyszło");
    Console.WriteLine("test");
}















//SearchNode s = new SearchNode();
//Node node = tree.Root;
//bool resault = s.TryGetNode(value,out node);
Console.WriteLine(value);



Console.ReadKey();
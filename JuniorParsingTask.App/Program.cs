using JuniorParsingTask;

SearchNode s = new SearchNode();
Node? node = null;
//tree for searching
//var tree = TreeService.Create();


string value = "dataedo";
Console.WriteLine(value + " " + s.TryGetNode(value, out node).ToString() + "\n");


value = "learning";
Console.WriteLine(value + " " + s.TryGetNode(value, out node).ToString() + "\n");


value = "Brak";
Console.WriteLine(value + " " + s.TryGetNode(value, out node).ToString() + "\n");

Console.ReadKey();
// See https://aka.ms/new-console-template for more information
using DesginPattern.src.Behavioral.command.Undoable
;

var history = new History();
var document = new HtmlDocument();
document.Content = "Hello World";

Console.WriteLine(document.Content);



var italicCommand = new ItalicCommand(document, history);
italicCommand.Execute();
Console.WriteLine(document.Content);
italicCommand.Unexecute();

Console.WriteLine(document.Content);



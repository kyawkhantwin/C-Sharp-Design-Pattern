// See https://aka.ms/new-console-template for more information
using DesginPattern.src.Behavioral.State.GoodSolution;

var doc = new Document(UserRoles.Admin);
System.Console.WriteLine(doc.State);

doc.Publish();

System.Console.WriteLine(doc.State);
doc.Publish();

System.Console.WriteLine(doc.State);

doc.Publish();

doc.State = new DraftState(doc);
System.Console.WriteLine(doc.State);




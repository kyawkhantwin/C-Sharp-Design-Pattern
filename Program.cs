// See https://aka.ms/new-console-template for more information
using DesginPattern.src.Behavioral.Iterator.GoodSolution;

ShoppingList list = new ShoppingList();
list.Push("Milk");
list.Push("Bread");
list.Push("Steak");

var iterator = list.CreateIterator();

while(iterator.HasNext()){
    Console.WriteLine(iterator.Current());
    iterator.Next();
}


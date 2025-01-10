// See https://aka.ms/new-console-template for more information
using DesginPattern.src.Behavioral.Memento;

namespace DesginPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var editor = new Editor();
            var history = new History(editor);

    
            editor.Title = "Haha This";
            history.Backup();

            editor.Content = "Content I Am";
            history.Backup();

              editor.Title = "Edit";
            history.Backup();

            System.Console.WriteLine("Title: " + editor.Title );
            System.Console.WriteLine("Content: " +editor.Content );

            history.Undo();

            System.Console.WriteLine("Title: " + editor.Title );
            System.Console.WriteLine("Content: " + editor.Content );

        }
    }
}

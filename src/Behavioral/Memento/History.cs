namespace DesginPattern.src.Behavioral.Memento
{
    public class History
    {
        private List<EditorState> _states = new List<EditorState>();
        private Editor _editor;
        public History(Editor editor){
            _editor  = editor;
        }
        public void Backup(){
            _states.Add(_editor.CreateState());
        
        }
      public void Undo(){
        if(_states.Count == 0){
        return;
      }
         EditorState lastState = _states.Last();
            _states.Remove(lastState);
            
     EditorState prevState = _states.Last();
     _editor.Restore(prevState);
    }

     public void ShowHistory(){
     System.Console.WriteLine("\n History of mementos:");

     foreach(var state in _states){
     System.Console.WriteLine(state.GetState());
     }
    }
    }
}
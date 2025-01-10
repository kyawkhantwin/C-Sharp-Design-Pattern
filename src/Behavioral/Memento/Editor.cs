namespace DesginPattern.src.Behavioral.Memento
{
    public class Editor
    {
        public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;

        public EditorState CreateState(){
            return new EditorState(Title, Content);
        }

        public void Restore(EditorState state){
            Title = state.GetTitle();
            Content = state.GetContent();
        }

        public string GetState(EditorState state){
           return state.GetState();
        }
        
    }
}
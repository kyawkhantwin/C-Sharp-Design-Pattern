namespace DesginPattern.src.Behavioral.State
{
    public class Document
    {
        public DocumentStates States { get; set; }
        public UserRoles CurrentUserRole{ get; set; }

        public void Publish (){
            
        }
    }
}
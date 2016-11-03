namespace Samples2
{    
    public class Book    
    {        
        private readonly string _Title;
 
        public Book(string title)        
        {            
            if (title == null)                
                throw new ArgumentNullException("title", "title cannot be a null reference (Nothing in Visual Basic)");
 
            _Title = title;        }
 
        public string Title        
        {            
            get { return _Title; }        
        }
    }
}
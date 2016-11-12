using namespace System;
 
namespace Samples2 
{    
	public ref class Book    
	{
     private: initonly String^ _Title;
 
    public:
        Book(String^ title)        
		{            
			if (title == nullptr)                
				throw gcnew ArgumentNullException(("title", "title cannot be a null reference (Nothing in Visual Basic)"));
 
            _Title = title;        
		}
 
        property String^ Title        
		{            
			String^ get()            
			{                
				return _Title;            
			}        
		}    
	};
}
using namespace System;
 
namespace Samples
{
    public ref class Book    
    {
    public:
        Book()        
        {           
        }
        static Book^ CreateBook()        
        {            
            return gcnew Book();        
        }            
    };
}
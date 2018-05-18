using namespace System;
using namespace System::Collections;

namespace UsageLibrary
{
   public ref class WritableCollection
   {
   public:
      // This property violates rule CA2227.
      property ArrayList^ SomeStrings;

      WritableCollection()
      {
         SomeStrings = gcnew ArrayList(
            gcnew array<String^> {"IEnumerable", "ICollection", "IList"} );
      }
   };
}

using namespace UsageLibrary;

void main()
{
   ArrayList^ newCollection = gcnew ArrayList(
      gcnew array<String^> {"a", "new", "collection"} );

   WritableCollection^ collection = gcnew WritableCollection();
   // This line of code demonstrates how the entire collection
   // can be replaced by a property that's not read-only.
   collection->SomeStrings = newCollection;

   // If the intent is to replace an entire collection,
   // implement Clear() and AddRange() methods instead.
   collection->SomeStrings->Clear();
   collection->SomeStrings->AddRange(newCollection);
}
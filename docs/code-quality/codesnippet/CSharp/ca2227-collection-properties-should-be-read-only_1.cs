using System;
using System.Collections;

namespace UsageLibrary
{
   public class WritableCollection
   {
      ArrayList strings;

      public ArrayList SomeStrings
      {
         get { return strings; }

         // This property violates rule CA2227.
         set { strings = value; }
      }

      public WritableCollection()
      {
         strings = new ArrayList(
            new string[] {"IEnumerable", "ICollection", "IList"} );
      }
   }

   class ReplaceWritableCollection
   {
      static void Main()
      {
         ArrayList newCollection = new ArrayList(
            new string[] {"a", "new", "collection"} );

         WritableCollection collection = new WritableCollection();
         // This line of code demonstrates how the entire collection
         // can be replaced by a property that's not read-only.
         collection.SomeStrings = newCollection;

         // If the intent is to replace an entire collection,
         // implement Clear() and AddRange() methods instead.
         collection.SomeStrings.Clear();
         collection.SomeStrings.AddRange(newCollection);
      }
   }
}
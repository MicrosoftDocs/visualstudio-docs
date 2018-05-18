Imports System
Imports System.Collections

Namespace UsageLibrary

   Public Class WritableCollection

      Dim strings As ArrayList

      Property SomeStrings As ArrayList
         Get
            Return strings
         End Get

         ' This property violates rule CA2227.
         Set
            strings = Value
         End Set
      End Property

      Sub New()
         strings = New ArrayList(New String() {"IEnumerable", "ICollection", "IList"} )
      End Sub

   End Class

   Class ViolatingVersusPreferred

      Shared Sub Main()
         Dim newCollection As New ArrayList(New String() {"a", "new", "collection"} )

         Dim collection As New WritableCollection()
         ' This line of code demonstrates how the entire collection
         ' can be replaced by a property that's not read-only.
         collection.SomeStrings = newCollection

         ' If the intent is to replace an entire collection,
         ' implement Clear() and AddRange() methods instead.
         collection.SomeStrings.Clear()
         collection.SomeStrings.AddRange(newCollection)
      End Sub

   End Class

End Namespace
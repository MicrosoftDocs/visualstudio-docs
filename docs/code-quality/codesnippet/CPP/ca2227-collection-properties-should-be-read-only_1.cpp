#include "stdafx.h"
using namespace System;
using namespace System::Collections;

namespace UsageLibrary
{
	public ref class WritableCollection
	{
	public:
		property ArrayList^ SomeStrings
		{
			ArrayList^ get() { return someStrings; }

			// This set accessor violates rule CA2227.
			// To fix the code, remove this set accessor.
			void set(ArrayList^ value) { someStrings = value; }
		}

		WritableCollection()
		{
			someStrings = gcnew ArrayList(gcnew array<String^> {"one", "two", "three"});
		}

	private:
		ArrayList ^ someStrings;
	};
}

using namespace UsageLibrary;

void main()
{
	ArrayList^ newCollection = gcnew ArrayList(gcnew array<String^> {"a", "new", "collection"});

	WritableCollection^ collection = gcnew WritableCollection();

	// This line of code demonstrates how the entire collection
	// can be replaced by a property that's not read only.
	collection->SomeStrings = newCollection;

	// If the intent is to replace an entire collection,
	// implement and/or use the Clear() and AddRange() methods instead.
	collection->SomeStrings->Clear();
	collection->SomeStrings->AddRange(newCollection);
}
---
title: "Expressions in the debugger"
description: Explore language expressions supported by the expression evaluators in the Visual Studio debugger, and review limitations of expression evaluation.
ms.date: "02/22/2024"
ms.topic: article
f1_keywords:
  - "vs.debug.expressions"
helpviewer_keywords:
  - "expressions [debugger]"
  - "debugging [Visual Studio], expressions"
  - "expression evaluation, debugger evaluator"
  - "native expression evaluation"
  - "expression evaluators"
  - "debugger, evaluating expressions"
  - "debugging [Visual Studio], expression evaluation"
  - "debugging [Visual Studio], variable evaluation"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Expressions in the Visual Studio debugger

The Visual Studio debugger includes expression evaluators that work when you enter an expression in the **QuickWatch** dialog box, **Watch** window, or **Immediate** window. The expression evaluators are also at work in the **Breakpoints** window and many other places in the debugger.

The following sections describes limitations of expression evaluation for languages supported by Visual Studio.

## F# expressions aren't supported
F# expressions aren't recognized. If you are debugging F# code, you need to translate your expressions into C# syntax before entering the expressions into a debugger window or dialog box. When you translate expressions from F# to C#, be sure to remember that C# uses the `==` operator to test for equality, while F# uses the single `=`.

## C++ Expressions
For information about using context operators with expressions in C++, see [Context Operator (C++)](../debugger/context-operator-cpp.md).

### Unsupported Expressions in C++

#### Constructors, destructors, and conversions
You can't call a constructor or destructor for an object, either explicitly or implicitly. For example, the following expression explicitly calls a constructor and results in an error message:

```cpp
my_date( 2, 3, 1985 )
```

You can't call a conversion function if the destination of the conversion is a class. Such a conversion involves the construction of an object. For example, if `myFraction` is an instance of `CFraction`, which defines the conversion function operator `FixedPoint`, the following expression results in an error:

```cpp
(FixedPoint)myFraction
```

You can't call the new or delete operators. For example, the following expression isn't supported:

```cpp
new Date(2,3,1985)
```

#### Preprocessor Macros
Preprocessor macros aren't supported in the debugger. For instance, if a constant `VALUE` is declared as: `#define VALUE 3`, you can't use `VALUE` in the **Watch** window. To avoid this limitation, you should replace `#define`'s with enums and functions whenever possible.

### using namespace declarations
You can't use `using namespace` declarations.  In order to access a type name or variable outside of the current namespace, you must use the fully-qualified name.

### Anonymous namespaces
Anonymous namespaces aren't supported. If you have the following code, you can't add `test` to the watch window:

```cpp
namespace mars
{
    namespace
    {
        int test = 0;
    }
}
int main()
{
    // Adding a watch on test doesn't work.
    mars::test++;
    return 0;
}

```

### <a name="BKMK_Using_debugger_intrinisic_functions_to_maintain_state"></a> Using debugger intrinsic functions to maintain state
The debugger intrinsic functions give you a way to call certain C/C++ functions in expressions without changing the state of the application.

Debugger intrinsic functions:

- Are guaranteed to be safe: executing a debugger intrinsic function won't corrupt the process that is being debugged.

- Are allowed in all expressions , even in scenarios where side effects and function evaluation aren't allowed.

- Work in scenarios where the regular function calls aren't possible, such as debugging a minidump.

  Debugger intrinsic functions can also make evaluating expressions more convenient. For example, `strcmp(str, "asd")` is much easier to write in a breakpoint condition than `str[0] == 'a' && str[1] == 's' && str[2] == 'd'`. )

|Area|Intrinsic functions|
|----------|-------------------------|
|**String length**|[strlen, wcslen](/cpp/c-runtime-library/reference/strlen-wcslen-mbslen-mbslen-l-mbstrlen-mbstrlen-l), [strnlen, wcsnlen](/cpp/c-runtime-library/reference/strnlen-strnlen-s)|
|**String comparison**|[strcmp, wcscmp](/cpp/c-runtime-library/reference/strcmp-wcscmp-mbscmp), [stricmp, wcsicmp](/cpp/c-runtime-library/reference/stricmp-wcsicmp), [_stricmp, _strcmpi, _wcsicmp, _wcscmpi](/cpp/c-runtime-library/reference/stricmp-wcsicmp-mbsicmp-stricmp-l-wcsicmp-l-mbsicmp-l), [strncmp, wcsncmp](/cpp/c-runtime-library/reference/strncmp-wcsncmp-mbsncmp-mbsncmp-l), [strnicmp, wcsnicmp](/cpp/c-runtime-library/reference/strnicmp-wcsnicmp), [_strnicmp, _wcsnicmp](/cpp/c-runtime-library/reference/strnicmp-wcsnicmp-mbsnicmp-strnicmp-l-wcsnicmp-l-mbsnicmp-l)|
|**String search**|[strchr, wcschr](/cpp/c-runtime-library/reference/strchr-wcschr-mbschr-mbschr-l), [memchr, wmemchr](/cpp/c-runtime-library/reference/memchr-wmemchr), [strstr, wcsstr](/cpp/c-runtime-library/reference/strstr-wcsstr-mbsstr-mbsstr-l)|
|**Win32**|[CoDecodeProxy](/windows/win32/api/combaseapi/nf-combaseapi-codecodeproxy), [DecodePointer](/previous-versions/bb432242(v=vs.85)), [GetLastError](/windows/win32/api/errhandlingapi/nf-errhandlingapi-getlasterror), [TlsGetValue](/windows/win32/api/processthreadsapi/nf-processthreadsapi-tlsgetvalue)|
|**Windows 8**|[RoInspectCapturedStackBackTrace](/windows/win32/api/roerrorapi/nf-roerrorapi-roinspectcapturedstackbacktrace), [WindowsCompareStringOrdinal](/windows/win32/api/winstring/nf-winstring-windowscomparestringordinal), [WindowsGetStringLen](/windows/win32/api/winstring/nf-winstring-windowsgetstringlen), [WindowsGetStringRawBuffer](/windows/win32/api/winstring/nf-winstring-windowsgetstringrawbuffer)<br /><br /> These functions require the process that is being debugged to be running on Windows 8. Debugging dump files generated from a Windows 8 device also requires that the Visual Studio computer be running Windows 8. However, if you are debugging a Windows 8 device remotely, the Visual Studio computer can be running Windows 7.<br />`WindowsGetStringLen` and `WindowsGetStringRawBuffer` are used only by the execution engine (EE) on the source level.|
|**Miscellaneous**|**__log2** - Returns the log base 2 of a specified integer, rounded to the nearest lower integer.<br /><br />**__findNonNull** - Searches an array of pointers, returning the index of the first non-null element.<br />- Parameters: (1) Pointer to first element in array (void*), (2) Size of array (unsigned int).<br />- Return values: (1) 0-based index of first non-null element in array or -1 if not found.<br /><br />**DecodeHString** - Helper function to format the value of an HSTRING. Pops the HSTRING value off the stack, pushes the bytes of a StringInfo structure that the EE can use to tell where the string is located. This is only used internally by the EE; it isn't available to the user to call directly.<br /><br />**DecodeWinRTRestrictedException** - Decodes a WinRT restricted exception to get the restricted description.<br />- Parameters: (1) characters of a null-terminated string representing the restricted reference string.<br />- Return value: Characters of a null-terminated string containing the actual error message to show.<br /><br />**DynamicCast** - Implements dynamic_cast.<br />- Parameters: (1) Pointer to object to cast.<br />- Data items: A CDynamicCastData object should be associated as a data item to the corresponding ExecuteIntrinsic() instruction. The data item encodes the type we're casting from and to, as well as whether or not we're evaluating a natvis expression (needed for diagnostics to break infinite recursion).<br />- Return value: (1) A pointer to the object, cast to the correct type, or NULL if the object being cast isn't an instance of the correct type.<br /><br />**DynamicMemberLookup** - Helper function to get the value of a class member dynamically<br /><br />**GetEnvBlockLength** - Helper function to get length of an environment block, in characters.  Used for $env.<br /><br />**Stdext_HashMap_Int_OperatorBracket_idx** - Operator[] for stdext::hash_map.  Assumes default hash function with a key of 'int'.  Returns the value. The intrinsic operator[] only supports retrieving existing items from the hashtable - it doesn't support inserting new items into the table, as that could involve unwanted complexity, such as memory allocation.  However, operator[] may be used to modify the value associated with a key already in the table.<br />- Stack Parameters: (1) The address of the stdext::hash_map object, (2) The key into the table (int), (3) a HashMapPdb structure that specifies the field offsets of members that the function implementation needs to do the lookup.  This is required because direct access to symbols isn't available on the remote side.<br />- Return values: (1) If the key is in the table, the address of the value which corresponds to the key.  Otherwise, NULL.<br /><br />**Std_UnorderedMap_Int_OperatorBracket_idx** - std::unordered_map works the same way as stdext::hash_map, except the hash function is different.<br /><br />**ConcurrencyArray_OperatorBracket_idx** // Concurrency::array<>::operator[index<>] and operator(index<>)<br /><br />**ConcurrencyArray_OperatorBracket_int** // Concurrency::array<>::operator(int, int, ...)<br /><br />**ConcurrencyArray_OperatorBracket_tidx** // Concurrency::array<>::operator[tiled_index<>] and operator(tiled_index<>)<br /><br />**ConcurrencyArrayView_OperatorBracket_idx** // Concurrency::array_view<>::operator[index<>] and operator(index<>)<br /><br />**ConcurrencyArrayView_OperatorBracket_int** // Concurrency::array_view<>::operator(int, int, ...)<br /><br />**ConcurrencyArrayView_OperatorBracket_tidx** // Concurrency::array_view<>::operator[tiled_index<>] and operator(tiled_index<>)<br /><br />**TreeTraverse_Init** - Initializes a new tree traversal. <br />Supports extension-based visualizers, not intended to be used in *.natvis* files.<br /><br />**TreeTraverse_Next** - Retrieves nodes from a pending tree traversal.<br />Supports extension-based visualizers, not intended to be used in *.natvis* files.<br /><br />**TreeTraverse_Skip** - Skips nodes in a pending tree traversal.<br />Supports extension-based visualizers, not intended to be used in *.natvis* files.|

## C++/CLI - Unsupported Expressions

- Casts that involve pointers, or user-defined casts, aren't supported.

- Object comparison and assignment aren't supported.

- Overloaded operators and overloaded functions aren't supported.

- Boxing and unboxing aren't supported.

- `Sizeof` operator isn't supported.

## C# - Unsupported Expressions

### Dynamic Objects
You can use variables in debugger expressions that are statically typed as dynamic. When objects that implement <xref:System.Dynamic.IDynamicMetaObjectProvider> are evaluated in the Watch window, a Dynamic View node is added. The Dynamic View node shows object members but doesn't allow editing the values of the members.

The following features of dynamic objects aren't supported:

- The compound operators `+=`, `-=`, `%=`, `/=`, and `*=`

- Many casts, including numeric casts and type-argument casts

- Method calls with more than two arguments

- Property getters with more than two arguments

- Property setters with arguments

- Assigning to an indexer

- Boolean operators `&&` and `||`

### Anonymous Methods
Creation of new anonymous methods isn't supported.

## Visual Basic - Unsupported Expressions

### Dynamic Objects
You can use variables in debugger expressions that are statically typed as dynamic. When objects that implement the <xref:System.Dynamic.IDynamicMetaObjectProvider> are evaluated in the Watch window, a Dynamic View node is added. The Dynamic View node shows object members but doesn't allow editing the values of the members.

The following features of dynamic objects aren't supported:

- The compound operators `+=`, `-=`, `%=`, `/=`, and `*=`

- Many casts, including numeric casts and type-argument casts

- Method calls with more than two arguments

- Property getters with more than two arguments

- Property setters with arguments

- Assigning to an indexer

- Boolean operators `&&` and `||`

### Local Constants
Local constants aren't supported.

### Import Aliases
Import aliases aren't supported.

### Variable Declarations
You can't declare explicit new variables in debugger windows. However, you can assign new implicit variables inside the **Immediate** window. These implicit variables are scoped to the debug session and aren't accessible outside of the debugger. For example, the statement `o = 5` implicitly creates a new variable `o` and assign the value 5 to it. Such implicit variables are of type **Object** unless the type can be inferred by the debugger.

### Unsupported Keywords

- `AddressOf`

- `End`

- `Error`

- `Exit`

- `Goto`

- `On Error`

- `Resume`

- `Return`

- `Select/Case`

- `Stop`

- `SyncLock`

- `Throw`

- `Try/Catch/Finally`

- `With`

- Namespace or module level keywords, such as `End Sub` or `Module`.

## Related content
- [Format Specifiers in C++](../debugger/format-specifiers-in-cpp.md)
- [Context Operator (C++)](../debugger/context-operator-cpp.md)
- [Format Specifiers in C#](../debugger/format-specifiers-in-csharp.md)
- [Pseudovariables](../debugger/pseudovariables.md)

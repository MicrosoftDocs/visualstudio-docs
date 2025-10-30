---
title: Use C++ assertion statements for debugging
description: Read about how C/C++ assertions work in Visual Studio debugging. An assertion specifies a condition that you expect to be true at a point in your program.
ms.date: "11/04/2016"
ms.topic: how-to
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugging [MFC], assertions"
  - "results, checking"
  - "result checking"
  - "Call Stack window, assertion failures"
  - "debugging [C++], assertions"
  - "VERIFY macro"
  - "assertions, side effects"
  - "assertions"
  - "ASSERT macro"
  - "errors [C++], catching with assertions"
  - "testing, error conditions with assertion statements"
  - "_DEBUG macro"
  - "Assertion Failed dialog box"
  - "failures, finding locations"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# C/C++ Assertions

An assertion statement specifies a condition that you expect to be true at a point in your program. If that condition is not true, the assertion fails, execution of your program is interrupted, and the [Assertion Failed dialog box](../debugger/assertion-failed-dialog-box.md) appears.

Visual Studio supports C++ assertion statements that are based on the following constructs:

- MFC assertions for MFC programs.

- [ATLASSERT](/cpp/atl/reference/debugging-and-error-reporting-macros#atlassert) for programs that use ATL.

- CRT assertions for programs that use the C run-time library.

- The ANSI [assert function](/cpp/c-runtime-library/reference/assert-macro-assert-wassert) for other C/C++ programs.

  You can use assertions to catch logic errors, check results of an operation, and Test error conditions that should have been handled.

## <a name="BKMK_In_this_topic"></a> In this topic

[How assertions work](#BKMK_How_assertions_work)

[Assertions in Debug and Release builds](#BKMK_Assertions_in_Debug_and_Release_builds)

[Side effects of using assertions](#BKMK_Side_effects_of_using_assertions)

[CRT assertions](#BKMK_CRT_assertions)

[MFC assertions](#BKMK_MFC_assertions)

- [MFC ASSERT_VALID and CObject::AssertValid](#BKMK_MFC_ASSERT_VALID_and_CObject__AssertValid)

- [Limitations of AssertValid](#BKMK_Limitations_of_AssertValid)

  [Using assertions](#BKMK_Using_assertions)

- [Catching logic errors](#BKMK_Catching_logic_errors)

- [Checking results](#BKMK_Checking_results_)

- [Finding unhandled errors](#BKMK_Testing_error_conditions_)

## <a name="BKMK_How_assertions_work"></a> How assertions work

When the debugger halts because of an MFC or C run-time library assertion, then if the source is available, the debugger navigates to the point in the source file where the assertion occurred. The assertion message appears in both the [Output window](../ide/reference/output-window.md) and the **Assertion Failed** dialog box. You can copy the assertion message from the **Output** window to a text window if you want to save it for future reference. The **Output** window might contain other error messages as well. Examine these messages carefully, because they provide clues to the cause of the assertion failure.

Use assertions to detect errors during development. As a rule, use one assertion for each assumption. For example, if you assume that an argument is not NULL, use an assertion to test that assumption.

[In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Assertions_in_Debug_and_Release_builds"></a> Assertions in Debug and Release builds

Assertion statements compile only if `_DEBUG` is defined. Otherwise, the compiler treats assertions as null statements. Therefore, assertion statements impose no overhead or performance cost in your final Release program, and allow you to avoid using `#ifdef` directives.

## <a name="BKMK_Side_effects_of_using_assertions"></a> Side effects of using assertions

When you add assertions to your code, make sure the assertions do not have side effects. For example, consider the following assertion that modifies the `nM` value:

```cpp
ASSERT(nM++ > 0); // Don't do this!
```

Because the `ASSERT` expression is not evaluated in the Release version of your program, `nM` will have different values in the Debug and Release versions. To avoid this problem in MFC, you can use the [VERIFY](/cpp/mfc/reference/diagnostic-services#verify) macro instead of `ASSERT`. `VERIFY` evaluates the expression in all versions but does not check the result in the Release version.

Be especially careful about using function calls in assertion statements, because evaluating a function can have unexpected side effects.

```cpp
ASSERT ( myFnctn(0)==1 ) // unsafe if myFnctn has side effects
VERIFY ( myFnctn(0)==1 ) // safe
```

`VERIFY` calls `myFnctn` in both the Debug and Release versions, so it is acceptable to use. However, using `VERIFY` imposes the overhead of an unnecessary function call in the Release version.

[In this topic](#BKMK_In_this_topic)

## <a name="BKMK_CRT_assertions"></a> CRT assertions

The `CRTDBG.H` header file defines the [`_ASSERT` and `_ASSERTE` macros](/cpp/c-runtime-library/reference/assert-asserte-assert-expr-macros) for assertion checking.

| Macro | Result |
|------------| - |
| `_ASSERT` | If the specified expression evaluates to FALSE, the file name and line number of the `_ASSERT`. |
| `_ASSERTE` | Same as `_ASSERT`, plus a string representation of the expression that was asserted. |

`_ASSERTE` is more powerful because it reports the asserted expression that turned out to be FALSE. This might be enough to identify the problem without referring to the source code. However, the Debug version of your application will contain a string constant for each expression asserted using `_ASSERTE`. If you use many `_ASSERTE` macros, these string expressions take up a significant amount of memory. If that proves to be a problem, use `_ASSERT` to save memory.

When `_DEBUG` is defined, the `_ASSERTE` macro is defined as follows:

```cpp
#define _ASSERTE(expr) \
    do { \
        if (!(expr) && (1 == _CrtDbgReport( \
            _CRT_ASSERT, __FILE__, __LINE__, #expr))) \
            _CrtDbgBreak(); \
    } while (0)
```

If the asserted expression evaluates to FALSE, [_CrtDbgReport](/cpp/c-runtime-library/reference/crtdbgreport-crtdbgreportw) is called to report the assertion failure (using a message dialog box by default). If you choose **Retry** in the message dialog box, `_CrtDbgReport` returns 1 and `_CrtDbgBreak` calls the debugger through `DebugBreak`.

If you need to temporarily disable all assertions, use [_CtrSetReportMode](/cpp/c-runtime-library/reference/crtsetreportmode).

### Checking for Heap Corruption

The following example uses [_CrtCheckMemory](/cpp/c-runtime-library/reference/crtcheckmemory) to check for corruption of the heap:

```cpp
_ASSERTE(_CrtCheckMemory());
```

### Checking Pointer Validity

The following example uses [_CrtIsValidPointer](/cpp/c-runtime-library/reference/crtisvalidpointer) to verify that a given memory range is valid for reading or writing.

```cpp
_ASSERTE(_CrtIsValidPointer( address, size, TRUE );
```

The following example uses [_CrtIsValidHeapPointer](/cpp/c-runtime-library/reference/crtisvalidheappointer) to verify a pointer points to memory in the local heap (the heap created and managed by this instance of the C run-time library — a DLL can have its own instance of the library, and therefore its own heap, outside of the application heap). This assertion catches not only null or out-of-bounds addresses, but also pointers to static variables, stack variables, and any other nonlocal memory.

```cpp
_ASSERTE(_CrtIsValidHeapPointer( myData );
```

### Checking a Memory Block

The following example uses [_CrtIsMemoryBlock](/cpp/c-runtime-library/reference/crtismemoryblock) to verify that a memory block is in the local heap and has a valid block type.

```cpp
_ASSERTE(_CrtIsMemoryBlock (myData, size, &requestNumber, &filename, &linenumber));
```

[In this topic](#BKMK_In_this_topic)

## <a name="BKMK_MFC_assertions"></a> MFC assertions

MFC defines the [ASSERT](/previous-versions/ew16s3zc(v=vs.140)) macro for assertion checking. It also defines the `MFC ASSERT_VALID` and `CObject::AssertValid` methods for checking the internal state of a `CObject`-derived object.

If the argument of the MFC `ASSERT` macro evaluates to zero or false, the macro halts program execution and alerts the user; otherwise, execution continues.

When an assertion fails, a message dialog box shows the name of the source file and the line number of the assertion. If you choose Retry in the dialog box, a call to [AfxDebugBreak](/cpp/mfc/reference/diagnostic-services#afxdebugbreak) causes execution to break to the debugger. At that point, you can examine the call stack and use other debugger facilities to determine why the assertion failed. If you have enabled [Just-in-time debugging](../debugger/just-in-time-debugging-in-visual-studio.md), and the debugger was not already running, the dialog box can launch the debugger.

The following example shows how to use `ASSERT` to check the return value of a function:

```cpp
int x = SomeFunc(y);
ASSERT(x >= 0);   //  Assertion fails if x is negative
```

You can use ASSERT with the [IsKindOf](/cpp/mfc/reference/cobject-class#iskindof) function to provide type checking of function arguments:

```cpp
ASSERT( pObject1->IsKindOf( RUNTIME_CLASS( CPerson ) ) );
```

The `ASSERT` macro produces no code in the Release version. If you need to evaluate the expression in the Release version, use the [VERIFY](/cpp/mfc/reference/diagnostic-services#verify) macro instead of ASSERT.

### <a name="BKMK_MFC_ASSERT_VALID_and_CObject__AssertValid"></a> MFC ASSERT_VALID and CObject::AssertValid

The [CObject::AssertValid](/cpp/mfc/reference/cobject-class#assertvalid) method provides run-time checks of the internal state of an object. Although you are not required to override `AssertValid` when you derive your class from `CObject`, you can make your class more reliable by doing this. `AssertValid` should perform assertions on all of the object's member variables to verify that they contain valid values. For example, it should check that pointer member variables are not NULL.

The following example shows how to declare an `AssertValid` function:

```cpp
class CPerson : public CObject
{
protected:
    CString m_strName;
    float   m_salary;
public:
#ifdef _DEBUG
    // Override
    virtual void AssertValid() const;
#endif
    // ...
};
```

When you override `AssertValid`, call the base class version of `AssertValid` before you perform your own checks. Then use the ASSERT macro to check the members unique to your derived class, as shown here:

```cpp
#ifdef _DEBUG
void CPerson::AssertValid() const
{
    // Call inherited AssertValid first.
    CObject::AssertValid();

    // Check CPerson members...
    // Must have a name.
    ASSERT( !m_strName.IsEmpty());
    // Must have an income.
    ASSERT( m_salary > 0 );
}
#endif
```

If any of your member variables store objects, you can use the `ASSERT_VALID` macro to test their internal validity (if their classes override `AssertValid`).

For example, consider a class `CMyData`, which stores a [CObList](/cpp/mfc/reference/coblist-class) in one of its member variables. The `CObList` variable, `m_DataList`, stores a collection of `CPerson` objects. An abbreviated declaration of `CMyData` looks like this:

```cpp
class CMyData : public CObject
{
    // Constructor and other members ...
    protected:
        CObList* m_pDataList;
    // Other declarations ...
    public:
#ifdef _DEBUG
        // Override:
        virtual void AssertValid( ) const;
#endif
    // And so on ...
};
```

The `AssertValid` override in `CMyData` looks like this:

```cpp
#ifdef _DEBUG
void CMyData::AssertValid( ) const
{
    // Call inherited AssertValid.
    CObject::AssertValid( );
    // Check validity of CMyData members.
    ASSERT_VALID( m_pDataList );
    // ...
}
#endif
```

`CMyData` uses the `AssertValid` mechanism to test the validity of the objects stored in its data member. The overriding `AssertValid` of `CMyData` invokes the `ASSERT_VALID` macro for its own m_pDataList member variable.

Validity testing does not stop at this level because the class `CObList` also overrides `AssertValid`. This override performs additional validity testing on the internal state of the list. Thus, a validity test on a `CMyData` object leads to additional validity tests for the internal states of the stored `CObList` list object.

With some more work, you could add validity tests for the `CPerson` objects stored in the list also. You could derive a class `CPersonList` from `CObList` and override `AssertValid`. In the override, you would call `CObject::AssertValid` and then iterate through the list, calling `AssertValid` on each `CPerson` object stored in the list. The `CPerson` class shown at the beginning of this topic already overrides `AssertValid`.

This is a powerful mechanism when you build for debugging. When you subsequently build for release, the mechanism is turned off automatically.

### <a name="BKMK_Limitations_of_AssertValid"></a> Limitations of AssertValid

A triggered assertion indicates that the object is definitely bad and execution will stop. However, a lack of assertion indicates only that no problem was found, but the object is not guaranteed to be good.

[In this topic](#BKMK_In_this_topic)

## <a name="BKMK_Using_assertions"></a> Using assertions

### <a name="BKMK_Catching_logic_errors"></a> Catching logic errors

You can set an assertion on a condition that must be true according to the logic of your program. The assertion has no effect unless a logic error occurs.

For example, suppose you are simulating gas molecules in a container, and the variable `numMols` represents the total number of molecules. This number cannot be less than zero, so you might include an MFC assertion statement like this:

```cpp
ASSERT(numMols >= 0);
```

Or you might include a CRT assertion like this:

```cpp
_ASSERT(numMols >= 0);
```

These statements do nothing if your program is operating correctly. If a logic error causes `numMols` to be less than zero, however, the assertion halts the execution of your program and displays the [Assertion Failed Dialog Box](../debugger/assertion-failed-dialog-box.md).

[In this topic](#BKMK_In_this_topic)

### <a name="BKMK_Checking_results_"></a> Checking results

Assertions are valuable for testing operations whose results are not obvious from a quick visual inspection.

For example, consider the following code, which updates the variable `iMols` based on the contents of the linked list pointed to by `mols`:

```cpp
/* This code assumes that type has overloaded the != operator
 with const char *
It also assumes that H2O is somewhere in that linked list.
Otherwise we'll get an access violation... */
while (mols->type != "H2O")
{
    iMols += mols->num;
    mols = mols->next;
}
ASSERT(iMols<=numMols); // MFC version
_ASSERT(iMols<=numMols); // CRT version
```

The number of molecules counted by `iMols` must always be less than or equal to the total number of molecules, `numMols`. Visual inspection of the loop does not show that this will necessarily be the case, so an assertion statement is used after the loop to test for that condition.

[In this topic](#BKMK_In_this_topic)

### <a name="BKMK_Testing_error_conditions_"></a> Finding unhandled errors

You can use assertions to test for error conditions at a point in your code where any errors should have been handled. In the following example, a graphic routine returns an error code or zero for success.

```cpp
myErr = myGraphRoutine(a, b);

/* Code to handle errors and
   reset myErr if successful */

ASSERT(!myErr); -- MFC version
_ASSERT(!myErr); -- CRT version
```

If the error-handling code works properly, the error should be handled and `myErr` reset to zero before the assertion is reached. If `myErr` has another value, the assertion fails, the program halts, and the [Assertion Failed Dialog Box](../debugger/assertion-failed-dialog-box.md) appears.

Assertion statements are not a substitute for error-handling code, however. The following example shows an assertion statement that can lead to problems in the final release code:

```cpp
myErr = myGraphRoutine(a, b);

/* No Code to handle errors */

ASSERT(!myErr); // Don't do this!
_ASSERT(!myErr); // Don't do this, either!
```

This code relies on the assertion statement to handle the error condition. As a result, any error code returned by `myGraphRoutine` will be unhandled in the final release code.

[In this topic](#BKMK_In_this_topic)

## Related content

- [Debugger Security](../debugger/debugger-security.md)
- [Debugging Native Code](../debugger/debugging-native-code.md)
- [Assertions in Managed Code](../debugger/assertions-in-managed-code.md)

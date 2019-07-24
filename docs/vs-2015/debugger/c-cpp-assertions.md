---
title: "C-C++ Assertions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
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
ms.assetid: 2d7b0121-71aa-414b-bbb6-ede1093d0bfc
caps.latest.revision: 25
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# C/C++ Assertions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

An assertion statement specifies a condition that you expect to be true at a point in your program. If that condition is not true, the assertion fails, execution of your program is interrupted, and the [Assertion Failed dialog box](../debugger/assertion-failed-dialog-box.md) appears.  

 Visual C++ supports assertion statements that are based on the following constructs:  

- MFC assertions for MFC programs.  

- [ATLASSERT](https://msdn.microsoft.com/library/98e3e0fc-77e2-499b-a6f6-b17a21c6fbd3) for programs that use ATL.  

- CRT assertions for programs that use the C run-time library.  

- The ANSI [assert function](https://msdn.microsoft.com/library/a9ca031a-648b-47a6-bdf1-65fc7399dd40) for other C/C++ programs.  

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
 When the debugger halts because of an MFC or C run-time library assertion, then if the source is available, the debugger navigates to the point in the source file where the assertion occurred. The assertion message appears in both the [Output window](../ide/reference/output-window.md) and the **Assertion Failed** dialog box. You can copy the assertion message from the **Output** window to a text window if you want to save it for future reference. The **Output** window may contain other error messages as well. Examine these messages carefully, because they provide clues to the cause of the assertion failure.  

 Use assertions to detect errors during development. As a rule, use one assertion for each assumption. For example, if you assume that an argument is not NULL, use an assertion to test that assumption.  

 [In this topic](#BKMK_In_this_topic)  

## <a name="BKMK_Assertions_in_Debug_and_Release_builds"></a> Assertions in Debug and Release builds  
 Assertion statements compile only if `_DEBUG` is defined. Otherwise, the compiler treats assertions as null statements. Therefore, assertion statements impose no overhead or performance cost in your final Release program, and allow you to avoid using `#ifdef` directives.  

## <a name="BKMK_Side_effects_of_using_assertions"></a> Side effects of using assertions  
 When you add assertions to your code, make sure the assertions do not have side effects. For example, consider the following assertion that modifies the `nM` value:  

```  
ASSERT(nM++ > 0); // Don't do this!  

```  

 Because the `ASSERT` expression is not evaluated in the Release version of your program, `nM` will have different values in the Debug and Release versions. To avoid this problem in MFC, you can use the [VERIFY](https://msdn.microsoft.com/library/3e1ab4ee-cbc7-4290-a777-c92f42ce7b96) macro instead of `ASSERT`.  `VERIFY` evaluates the expression in all versions but does not check the result in the Release version.  

 Be especially careful about using function calls in assertion statements, because evaluating a function can have unexpected side effects.  

```  
ASSERT ( myFnctn(0)==1 ) // unsafe if myFnctn has side effects  
VERIFY ( myFnctn(0)==1 ) // safe  
```  

 `VERIFY` calls `myFnctn` in both the Debug and Release versions, so it is acceptable to use. However, using `VERIFY` imposes the overhead of an unnecessary function call in the Release version.  

 [In this topic](#BKMK_In_this_topic)  

## <a name="BKMK_CRT_assertions"></a> CRT assertions  
 The CRTDBG.H header file defines the [_ASSERT and _ASSERTE macros](https://msdn.microsoft.com/library/e98fd2a6-7f5e-4aa8-8fe8-e93490deba36) for assertion checking.  

|   Macro    |                                             Result                                              |
|------------|-------------------------------------------------------------------------------------------------|
| `_ASSERT`  | If the specified expression evaluates to FALSE, the file name and line number of the `_ASSERT`. |
| `_ASSERTE` |      Same as `_ASSERT`, plus a string representation of the expression that was asserted.       |

 `_ASSERTE` is more powerful because it reports the asserted expression that turned out to be FALSE. This may be enough to identify the problem without referring to the source code. However, the Debug version of your application will contain a string constant for each expression asserted using `_ASSERTE`. If you use many `_ASSERTE` macros, these string expressions take up a significant amount of memory. If that proves to be a problem, use `_ASSERT` to save memory.  

 When `_DEBUG` is defined, the `_ASSERTE` macro is defined as follows:  

```  
#define _ASSERTE(expr) \  
   do { \  
      if (!(expr) && (1 == _CrtDbgReport( \  
         _CRT_ASSERT, __FILE__, __LINE__, #expr))) \  
         _CrtDbgBreak(); \  
   } while (0)  
```  

 If the asserted expression evaluates to FALSE, [_CrtDbgReport](https://msdn.microsoft.com/library/6e581fb6-f7fb-4716-9432-f0145d639ecc) is called to report the assertion failure (using a message dialog box by default). If you choose **Retry** in the message dialog box, `_CrtDbgReport` returns 1 and `_CrtDbgBreak` calls the debugger through `DebugBreak`.  

### Checking for Heap Corruption  
 The following example uses [_CrtCheckMemory](https://msdn.microsoft.com/library/457cc72e-60fd-4177-ab5c-6ae26a420765) to check for corruption of the heap:  

```  
_ASSERTE(_CrtCheckMemory());  
```  

### Checking Pointer Validity  
 The following example uses [_CrtIsValidPointer](https://msdn.microsoft.com/library/91c35590-ea5e-450f-a15d-ad8d62ade1fa) to verify that a given memory range is valid for reading or writing.  

```  
_ASSERTE(_CrtIsValidPointer( address, size, TRUE );  
```  

 The following example uses [_CrtIsValidHeapPointer](https://msdn.microsoft.com/library/caf597ce-1b05-4764-9f37-0197a982bec5) to verify a pointer points to memory in the local heap (the heap created and managed by this instance of the C run-time library — a DLL can have its own instance of the library, and therefore its own heap, outside of the application heap). This assertion catches not only null or out-of-bounds addresses, but also pointers to static variables, stack variables, and any other nonlocal memory.  

```  
_ASSERTE(_CrtIsValidPointer( myData );  
```  

### Checking a Memory Block  
 The following example uses [_CrtIsMemoryBlock](https://msdn.microsoft.com/library/f7cbbc60-3690-4da0-a07b-68fd7f250273) to verify that a memory block is in the local heap and has a valid block type.  

```  
_ASSERTE(_CrtIsMemoryBlock (myData, size, &requestNumber, &filename, &linenumber));  
```  

 [In this topic](#BKMK_In_this_topic)  

## <a name="BKMK_MFC_assertions"></a> MFC assertions  
 MFC defines the [ASSERT](https://msdn.microsoft.com/library/1e70902d-d58c-4e7b-9f69-2aeb6cbe476c) macro for assertion checking. It also defines the `MFC ASSERT_VALID` and `CObject::AssertValid` methods for checking the internal state of a `CObject`-derived object.  

 If the argument of the MFC `ASSERT` macro evaluates to zero or false, the macro halts program execution and alerts the user; otherwise, execution continues.  

 When an assertion fails, a message dialog box shows the name of the source file and the line number of the assertion. If you choose Retry in the dialog box, a call to [AfxDebugBreak](https://msdn.microsoft.com/library/c4cd79b9-9327-4db5-a9d6-c4004a92aa30) causes execution to break to the debugger. At that point, you can examine the call stack and use other debugger facilities to determine why the assertion failed. If you have enabled [Just-in-time debugging](../debugger/just-in-time-debugging-in-visual-studio.md), and the debugger was not already running, the dialog box can launch the debugger.  

 The following example shows how to use `ASSERT` to check the return value of a function:  

```  
int x = SomeFunc(y);  
ASSERT(x >= 0);   //  Assertion fails if x is negative  
```  

 You can use ASSERT with the [IsKindOf](https://msdn.microsoft.com/library/7c87c748-b7e0-4c6d-9694-6035e62fdfd6) function to provide type checking of function arguments:  

```  
ASSERT( pObject1->IsKindOf( RUNTIME_CLASS( CPerson ) ) );  
```  

 The `ASSERT` macro produces no code in the Release version. If you need to evaluate the expression in the Release version, use the [VERIFY](https://msdn.microsoft.com/library/3e1ab4ee-cbc7-4290-a777-c92f42ce7b96) macro instead of ASSERT.  

### <a name="BKMK_MFC_ASSERT_VALID_and_CObject__AssertValid"></a> MFC ASSERT_VALID and CObject::AssertValid  
 The [CObject::AssertValid](https://msdn.microsoft.com/library/534a0744-4ab6-423d-b492-b4058b3d5157) method provides run-time checks of the internal state of an object. Although you are not required to override `AssertValid` when you derive your class from `CObject`, you can make your class more reliable by doing this. `AssertValid` should perform assertions on all of the object's member variables to verify that they contain valid values. For example, it should check that pointer member variables are not NULL.  

 The following example shows how to declare an `AssertValid` function:  

```  
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

```  
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

 For example, consider a class `CMyData`, which stores a [CObList](https://msdn.microsoft.com/library/80699c93-33d8-4f8b-b8cf-7b58aeab64ca) in one of its member variables. The `CObList` variable, `m_DataList`, stores a collection of `CPerson` objects. An abbreviated declaration of `CMyData` looks like this:  

```  
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

```  
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

```  
ASSERT(numMols >= 0);  

```  

 Or you might include a CRT assertion like this:  

```  
_ASSERT(numMols >= 0);  
```  

 These statements do nothing if your program is operating correctly. If a logic error causes `numMols` to be less than zero, however, the assertion halts the execution of your program and displays the [Assertion Failed Dialog Box](../debugger/assertion-failed-dialog-box.md).  

 [In this topic](#BKMK_In_this_topic)  

### <a name="BKMK_Checking_results_"></a> Checking results  
 Assertions are valuable for testing operations whose results are not obvious from a quick visual inspection.  

 For example, consider the following code, which updates the variable `iMols` based on the contents of the linked list pointed to by `mols`:  

```  
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

```  
myErr = myGraphRoutine(a, b);  

/* Code to handle errors and  
   reset myErr if successful */  

ASSERT(!myErr); -- MFC version  
_ASSERT(!myErr); -- CRT version  
```  

 If the error-handling code works properly, the error should be handled and `myErr` reset to zero before the assertion is reached. If `myErr` has another value, the assertion fails, the program halts, and the [Assertion Failed Dialog Box](../debugger/assertion-failed-dialog-box.md) appears.  

 Assertion statements are not a substitute for error-handling code, however. The following example shows an assertion statement that can lead to problems in the final release code:  

```  
myErr = myGraphRoutine(a, b);  

/* No Code to handle errors */  

ASSERT(!myErr); // Don't do this!  
_ASSERT(!myErr); // Don't do this, either!  
```  

 This code relies on the assertion statement to handle the error condition. As a result, any error code returned by `myGraphRoutine` will be unhandled in the final release code.  

 [In this topic](#BKMK_In_this_topic)  

## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Debugging Native Code](../debugger/debugging-native-code.md)   
 [Assertions in Managed Code](../debugger/assertions-in-managed-code.md)

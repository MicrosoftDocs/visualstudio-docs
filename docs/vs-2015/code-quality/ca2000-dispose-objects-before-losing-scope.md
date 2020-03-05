---
title: "CA2000: Dispose objects before losing scope | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2000"
  - "Dispose objects before losing scope"
  - "DisposeObjectsBeforeLosingScope"
helpviewer_keywords:
  - "CA2000"
  - "DisposeObjectsBeforeLosingScope"
ms.assetid: 0c3d7d8d-b94d-46e8-aa4c-38df632c1463
caps.latest.revision: 32
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2000: Dispose objects before losing scope
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DisposeObjectsBeforeLosingScope|
|CheckId|CA2000|
|Category|Microsoft.Reliability|
|Breaking Change|Non-breaking|

## Cause
 A local object of a <xref:System.IDisposable> type is created but the object is not disposed before all references to the object are out of scope.

## Rule Description
 If a disposable object is not explicitly disposed before all references to it are out of scope, the object will be disposed at some indeterminate time when the garbage collector runs the finalizer of the object. Because an exceptional event might occur that will prevent the finalizer of the object from running, the object should be explicitly disposed instead.

## How to Fix Violations
 To fix a violation of this rule, call <xref:System.IDisposable.Dispose%2A> on the object before all references to it are out of scope.

 Note that you can use the `using` statement (`Using` in [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]) to wrap objects that implement `IDisposable`. Objects that are wrapped in this manner will automatically be disposed at the close of the `using` block.

 The following are some situations where the using statement is not enough to protect IDisposable objects and can cause CA2000 to occur.

- Returning a disposable object requires that the object is constructed in a try/finally block outside a using block.

- Initializing members of a disposable object should not be done in the constructor of a using statement.

- Nesting constructors that are protected only by one exception handler. For example,

    ```
    using (StreamReader sr = new StreamReader(new FileStream("C:\myfile.txt", FileMode.Create)))
    { ... }
    ```

     causes CA2000 to occur because a failure in the construction of the StreamReader object can result in the FileStream object never being closed.

- Dynamic objects should use a shadow object to implement the Dispose pattern of IDisposable objects.

## When to Suppress Warnings
 Do not suppress a warning from this rule unless you have called a method on your object that calls `Dispose`, such as <xref:System.IO.Stream.Close%2A>, or if the method that raised the warning returns an IDisposable object wraps your object.

## Related Rules
 [CA2213: Disposable fields should be disposed](../code-quality/ca2213-disposable-fields-should-be-disposed.md)

 [CA2202: Do not dispose objects multiple times](../code-quality/ca2202-do-not-dispose-objects-multiple-times.md)

## Example
 If you are implementing a method that returns a disposable object, use a try/finally block without a catch block to make sure that the object is disposed. By using a try/finally block, you allow exceptions to be raised at the fault point and make sure that object is disposed.

 In the OpenPort1 method, the call to open the ISerializable object SerialPort or the call to SomeMethod can fail. A CA2000 warning is raised on this implementation.

 In the OpenPort2 method, two SerialPort objects are declared and set to null:

- `tempPort`, which is used to test that the method operations succeed.

- `port`, which is used for the return value of the method.

  The `tempPort` is constructed and opened in a `try` block, and any other required work is performed in the same `try` block. At the end of the `try` block, the opened port is assigned to the `port` object that will be returned and the `tempPort` object is set to `null`.

  The `finally` block checks the value of `tempPort`. If it is not null, an operation in the method has failed, and `tempPort` is closed to make sure that any resources are released. The returned port object will contain the opened SerialPort object if the operations of the method succeeded, or it will be null if an operation failed.

  [!code-csharp[FxCop.Reliability.CA2000.DisposeObjectsBeforeLosingScope#1](../snippets/csharp/VS_Snippets_CodeAnalysis/fxcop.reliability.ca2000.disposeobjectsbeforelosingscope/cs/fxcop.reliability.ca2000.disposeobjectsbeforelosingscope.cs#1)]
  [!code-vb[FxCop.Reliability.CA2000.DisposeObjectsBeforeLosingScope#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/fxcop.reliability.ca2000.disposeobjectsbeforelosingscope/vb/fxcop.reliability.ca2000.disposeobjectsbeforelosingscope.vb#1)]
  [!code-vb[FxCop.Reliability.CA2000.DisposeObjectsBeforeLosingScope#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/fxcop.reliability.ca2000.disposeobjectsbeforelosingscope/vb/fxcop.reliability.ca2000.disposeobjectsbeforelosingscope.vboverflow.vb#1)]

## Example
 By default, the [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] compiler has all arithmetic operators check for overflow. Therefore, any Visual Basic arithmetic operation might throw an <xref:System.OverflowException>. This could lead to unexpected violations in rules such as CA2000. For example, the following CreateReader1 function will produce a CA2000 violation because the Visual Basic compiler is emitting an overflow checking instruction for the addition that could throw an exception that would cause the StreamReader not to be disposed.

 To fix this, you can disable the emitting of overflow checks by the Visual Basic compiler in your project or you can modify your code as in the following CreateReader2 function.

 To disable the emitting of overflow checks, right-click the project name in Solution Explorer and then click **Properties**. Click **Compile**, click **Advanced Compile Options**, and then check **Remove integer overflow checks**.

<!-- TODO: review snippet reference  [!CODE [FxCop.Reliability.CA2000.DisposeObjectsBeforeLosingScope.VBOverflow#1](FxCop.Reliability.CA2000.DisposeObjectsBeforeLosingScope.VBOverflow#1)]  -->

## See Also
 <xref:System.IDisposable>
 [Dispose Pattern](https://msdn.microsoft.com/library/31a6c13b-d6a2-492b-9a9f-e5238c983bcb)
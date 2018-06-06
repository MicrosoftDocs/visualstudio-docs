---
title: MSTest assert classes and methods
ms.date: 06/07/2018
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
ms.topic: reference
helpviewer_keywords:
  - "Assert classes"
  - "Assert methods"
  - "unit tests, Assert classes"
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
author: gewarren
---
# Use Assert classes for unit testing

Use the Assert classes of the <xref:Microsoft.VisualStudio.TestTools.UnitTesting> namespace to verify specific functionality. A unit test method exercises the code of a method in your application's code, but it reports the correctness of the code's behavior only if you include Assert statements.

## Kinds of asserts

The <xref:Microsoft.VisualStudio.TestTools.UnitTesting> namespace provides several kinds of Assert classes.

In your test method, you can call any number of methods of the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert?displayProperty=nameWithType> class, <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual%2A?displayProperty=nameWithType>. The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert> class has many [methods](<xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert#methods>) to choose from, and many of those methods have several overloads.

Use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert?displayProperty=nameWithType> class to compare collections of objects, and to verify the state of one or more collections.

Use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert?displayProperty=nameWithType> class to compare strings. This class contains a variety of useful methods, such as <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert.Contains%2A?displayProperty=nameWithType>, <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert.Matches%2A?displayProperty=nameWithType>, and <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert.StartsWith%2A?displayProperty=nameWithType>.

The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException?displayProperty=nameWithType> exception is thrown whenever a test fails. A test fails if it times out, throws an unexpected exception, or contains an assert statement that produces a **Failed** result.

The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException?displayProperty=nameWithType> is thrown whenever a test produces a result of **Inconclusive**. Typically, you add an <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive%2A?displayProperty=nameWithType> statement to a test that you are still working on, to indicate it's not yet ready to be run.

> [!NOTE]
> An alternative strategy is to mark a test that is not ready to run with the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute?displayProperty=nameWithType> attribute. However, this has the disadvantage that you can't easily generate a report on the number of tests that aren't implemented.

If you write a new assert exception class, inherit from the base class <xref:Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException?displayProperty=nameWithType> to make it easier to identify the exception as an assertion failure instead of an unexpected exception thrown from your test or production code.

Decorate a test method with the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.ExpectedExceptionAttribute?displayProperty=nameWithType> attribute when you want the test method to verify that an exception you expect to be thrown by a method in your application code is actually thrown.

## See also

- <xref:Microsoft.VisualStudio.TestTools.UnitTesting>
- [Unit test your code](../test/unit-test-your-code.md)
---
title: MSTest assert classes and methods
description: Learn how to use Assert statements to test the correctness of your code behavior during a unit test of your application code.
ms.custom: SEO-VS-2020
ms.date: 06/07/2018
ms.topic: reference
helpviewer_keywords:
- Assert classes
- Assert methods
- unit tests, Assert classes
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload:
- multiple
author: mikejo5000
---
# Use Assert classes for unit testing

Use the Assert classes of the <xref:Microsoft.VisualStudio.TestTools.UnitTesting> namespace to verify specific functionality. A unit test method exercises the code of a method in your application's code, but it reports the correctness of the code's behavior only if you include Assert statements.

## Kinds of asserts

The <xref:Microsoft.VisualStudio.TestTools.UnitTesting> namespace provides several kinds of Assert classes.

In your test method, you can call any methods of the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert?displayProperty=fullName> class, such as <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual%2A?displayProperty=nameWithType>. The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert> class has many methods to choose from, and many of the methods have several overloads.

### Compare strings and collections

Use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.CollectionAssert> class to compare collections of objects, or to verify the state of a collection.

Use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert> class to compare and examine strings. This class contains a variety of useful methods, such as <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert.Contains%2A?displayProperty=nameWithType>, <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert.Matches%2A?displayProperty=nameWithType>, and <xref:Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert.StartsWith%2A?displayProperty=nameWithType>.

### Exceptions

The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException> exception is thrown whenever a test fails. A test fails if it times out, throws an unexpected exception, or contains an assert statement that produces a **Failed** result.

The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssertInconclusiveException> is thrown whenever a test produces a result of **Inconclusive**. Typically, you add an <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.Inconclusive%2A?displayProperty=nameWithType> statement to a test that you are still working on, to indicate it's not yet ready to be run.

> [!NOTE]
> An alternative strategy is to mark a test that is not ready to run with the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.IgnoreAttribute> attribute. However, this has the disadvantage that you can't easily generate a report on the number of tests that aren't implemented.

If you write a new assert exception class, inherit from the base class <xref:Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException> to make it easier to identify the exception as an assertion failure instead of an unexpected exception thrown from your test or production code.

To verify that an exception you expect to be thrown by a method in your application code is actually thrown, use the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.ThrowsException%2A?displayProperty=nameWithType> method.

## See also

- [Unit test your code](../test/unit-test-your-code.md)

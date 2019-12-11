---
title: "CA2153: Avoid Handling Corrupted State Exceptions | Microsoft Docs"
ms.date: 11/15/2016
ms.technology: vs-ide-code-analysis
ms.topic: reference
ms.assetid: 418cc9cb-68ad-47e9-a6c8-a48b9c35db45
caps.latest.revision: 7
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2153: Avoid Handling Corrupted State Exceptions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|AvoidHandlingCorruptedStateExceptions|
|CheckId|CA2153|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause
 [Corrupted State Exceptions (CSE)](https://msdn.microsoft.com/magazine/dd419661.aspx) indicate that memory corruption exists in your process. Catching these rather than allowing the process to crash can lead to security vulnerabilities if an attacker can place an exploit into the corrupted memory region.

## Rule Description
 CSE indicates that the state of a process has been corrupted and not caught by the system. In the corrupted state scenario, a general handler only catches the exception if you mark your method with the proper `HandleProcessCorruptedStateExceptions` attribute. By default, the [Common Language Runtime (CLR)](https://msdn.microsoft.com/library/8bs2ecf4.aspx) will not invoke catch handlers for CSEs.

 Allowing the process to crash without catching these kinds of exceptions is the safest option, as even logging code can allow attackers to exploit memory corruption bugs.

 This warning triggers when catching CSEs with a general handler that catches all exceptions, such as catch(exception) or catch(no exception specification).

## How to Fix Violations
 To resolve this warning you should do one of the following:

 1. Remove the `HandleProcessCorruptedStateExceptions` attribute. This reverts to the default runtime behavior where CSEs are not passed to catch handlers.

 2. Remove the general catch handler in preference of handlers that catch specific exception types.  This may include CSEs assuming the handler code can safely handle them (very rare).

 3. Re-throw the CSE in the catch handler which ensures the exception is passed to the caller and will result in ending the running process.

## When to Suppress Warnings
 Do not suppress a warning from this rule.

## Pseudo-code Example

### Violation
 The following pseudo-code illustrates the pattern detected by this rule.

```
[HandleProcessCorruptedStateExceptions]
//method to handle and log CSE exceptions
void TestMethod1()
{
    try
    {
        FileStream fileStream = new FileStream("name", FileMode.Create);
    }
    catch (Exception e)
    {
        // Handle error
    }
}
```

### Solution 1
 Removing the HandleProcessCorruptedExceptions attribute ensures that the exceptions will be not handled.

```
void TestMethod1()
{
    try
    {
        FileStream fileStream = new FileStream("name", FileMode.Create);
    }
    catch (IOException e)
    {
        // Handle error
    }
    catch (UnauthorizedAccessException e)
    {
        // Handle error
    }
}
```

### Solution 2
 Remove the general catch handler and catch only specific exception types.

```
void TestMethod1()
{
    try
    {
        FileStream fileStream = new FileStream("name", FileMode.Create);
    }
    catch (IOException e)
    {
        // Handle error
    }
    catch (UnauthorizedAccessException e)
    {
        // Handle error
    }
}
```

### Solution 3
 Re-throw the exception.

```
void TestMethod1()
{
    try
    {
        FileStream fileStream = new FileStream("name", FileMode.Create);
    }
    catch (Exception e)
    {
        // Handle error
        throw;
    }
}
```

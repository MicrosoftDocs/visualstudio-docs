---
title: "CA2153: Avoid Handling Corrupted State Exceptions"
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.topic: reference
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# CA2153: Avoid Handling Corrupted State Exceptions

|||
|-|-|
|TypeName|AvoidHandlingCorruptedStateExceptions|
|CheckId|CA2153|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

[Corrupted State Exceptions (CSE)](https://msdn.microsoft.com/magazine/dd419661.aspx) indicate that memory corruption exists in your process. Catching these rather than allowing the process to crash can lead to security vulnerabilities if an attacker can place an exploit into the corrupted memory region.

## Rule description

CSE indicates that the state of a process has been corrupted and not caught by the system. In the corrupted state scenario, a general handler only catches the exception if you mark your method with the proper `HandleProcessCorruptedStateExceptions` attribute. By default, the [Common Language Runtime (CLR)](/dotnet/standard/clr) will not invoke catch handlers for CSEs.

Allowing the process to crash without catching these kinds of exceptions is the safest option, as even logging code can allow attackers to exploit memory corruption bugs.

This warning triggers when catching CSEs with a general handler that catches all exceptions, such as catch(exception) or catch(no exception specification).

## How to fix violations

To resolve this warning, do one of the following:

- Remove the `HandleProcessCorruptedStateExceptions` attribute. This reverts to the default runtime behavior where CSEs are not passed to catch handlers.

- Remove the general catch handler in preference of handlers that catch specific exception types. This may include CSEs assuming the handler code can safely handle them (rare).

- Rethrow the CSE in the catch handler, which ensures the exception is passed to the caller and will result in ending the running process.

## When to suppress warnings

Do not suppress a warning from this rule.

## Pseudo-code example

### Violation

The following pseudo-code illustrates the pattern detected by this rule.

```csharp
[HandleProcessCorruptedStateExceptions]
// Method to handle and log CSE exceptions.
void TestMethod1()
{
    try
    {
        FileStream fileStream = new FileStream("name", FileMode.Create);
    }
    catch (Exception e)
    {
        // Handle error.
    }
}
```

### Solution 1

Removing the HandleProcessCorruptedExceptions attribute ensures that the exceptions will be not handled.

```csharp
void TestMethod1()
{
    try
    {
        FileStream fileStream = new FileStream("name", FileMode.Create);
    }
    catch (IOException e)
    {
        // Handle error.
    }
    catch (UnauthorizedAccessException e)
    {
        // Handle error.
    }
}
```

### Solution 2

Remove the general catch handler and catch only specific exception types.

```csharp
void TestMethod1()
{
    try
    {
        FileStream fileStream = new FileStream("name", FileMode.Create);
    }
    catch (IOException e)
    {
        // Handle error.
    }
    catch (UnauthorizedAccessException e)
    {
        // Handle error.
    }
}
```

### Solution 3

Rethrow the exception.

```csharp
void TestMethod1()
{
    try
    {
        FileStream fileStream = new FileStream("name", FileMode.Create);
    }
    catch (Exception e)
    {
        // Handle error.
        throw;
    }
}
```
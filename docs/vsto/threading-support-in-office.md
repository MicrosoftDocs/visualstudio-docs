---
title: "Threading support in Office"
description: Threading is supported in the Microsoft Office object model. The Office object model isn't thread safe, but can work with multiple threads in an Office solution.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "multiple threads [Office development in Visual Studio]"
  - "threading [Office development in Visual Studio]"
  - "Office applications [Office development in Visual Studio], threading support"
  - "object models [Office development in Visual Studio], threading support"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Threading support in Office

  This article provides information about how threading is supported in the Microsoft Office object model. The Office object model is not thread safe, but it is possible to work with multiple threads in an Office solution. Office applications are Component Object Model (COM) servers. COM allows clients to call COM servers on arbitrary threads. For COM servers that are not thread safe, COM provides a mechanism to serialize concurrent calls so that only one logical thread executes on the server at any time. This mechanism is known as the single-threaded apartment (STA) model. Because calls are serialized, callers might be blocked for periods of time while the server is busy or is handling other calls on a background thread.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## Knowledge required when using multiple threads
 To work with multiple threads, you must have at least basic knowledge of the following aspects of multithreading:

- Windows APIs

- COM multithreaded concepts

- Concurrency

- Synchronization

- Marshaling

  For general information about multithreading, see [Managed threading](/dotnet/standard/threading/).

  Office runs in the main STA. Understanding the implications of this makes it possible to understand how to use multiple threads with Office.

## Basic multithreading scenario
 Code in Office solutions always runs on the main UI thread. You might want to smooth out application performance by running a separate task on a background thread. The goal is to complete two tasks seemingly at once instead of one task followed by the other, which should result in smoother execution (the main reason to use multiple threads). For example, you might have your event code on the main Excel UI thread, and on a background thread you might run a task that gathers data from a server and updates cells in the Excel UI with the data from the server.

## Background threads that call into the Office object model
 When a background thread makes a call to the Office application, the call is automatically marshaled across the STA boundary. However, there is no guarantee that the Office application can handle the call at the time the background thread makes it. There are several possibilities:

1. The Office application must pump messages for the call to have the opportunity to enter. If it is doing heavy processing without yielding this could take time.

2. If another logical thread is already in the apartment, the new thread cannot enter. This often happens when a logical thread enters the Office application and then makes a reentrant call back to the caller's apartment. The application is blocked waiting for that call to return.

3. Excel might be in a state such that it cannot immediately handle an incoming call. For example, the Office application might be displaying a modal dialog.

   For possibilities 2 and 3, COM provides the [IMessageFilter](/windows/desktop/api/objidl/nn-objidl-imessagefilter) interface. If the server implements it, all calls enter through the [HandleIncomingCall](/windows/desktop/api/objidl/nf-objidl-imessagefilter-handleincomingcall) method. For possibility 2, calls are automatically rejected. For possibility 3, the server can reject the call, depending on the circumstances. If the call is rejected, the caller must decide what to do. Normally, the caller implements [IMessageFilter](/windows/desktop/api/objidl/nn-objidl-imessagefilter), in which case it would be notified of the rejection by the [RetryRejectedCall](/windows/desktop/api/objidl/nf-objidl-imessagefilter-retryrejectedcall) method.

   However, in the case of solutions created by using the Office development tools in Visual Studio, COM interop converts all rejected calls to a <xref:System.Runtime.InteropServices.COMException> ("The message filter indicated that the application is busy"). Whenever you make an object model call on a background thread, you must be prepared to handle this exception. Typically, that involves retrying for a certain amount of time and then displaying a dialog. However, you can also create the background thread as STA and then register a message filter for that thread to handle this case.

## Start the thread correctly
 When you create a new STA thread, set the apartment state to STA before you start the thread. The following code example demonstrates how to do this.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreCreatingExcelCS/ThisWorkbook.cs" id="Snippet5":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreCreatingExcelVB/ThisWorkbook.vb" id="Snippet5":::
 ---

 For more information, see [Managed threading best practices](/dotnet/standard/threading/managed-threading-best-practices).

## Modeless forms
 A modeless form allows some type of interaction with the application while the form is displayed. The user interacts with the form, and the form interacts with the application without closing. The Office object model supports managed modeless forms; however, they should not be used on a background thread.

## Related content
- [Threading (C#)](/dotnet/csharp/programming-guide/concepts/threading/index)
- [Threading (Visual Basic)](/dotnet/visual-basic/programming-guide/concepts/threading/index)
- [Use threads and threading](/dotnet/standard/threading/using-threads-and-threading)
- [Design and create Office solutions](../vsto/designing-and-creating-office-solutions.md)

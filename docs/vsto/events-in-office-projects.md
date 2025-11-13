---
title: "Events in Office projects"
description: Learn how each Office project template generates several event handlers and how those event handlers are slightly different from event handlers for VSTO Add-ins.
ms.date: "02/02/2017"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Sheet1_Startup"
  - "ThisDocument_Shutdown"
  - "ThisDocument_Startup"
  - "application-level add-ins [Office development in Visual Studio], events"
  - "event handlers [Office development in Visual Studio]"
  - "ThisWorkbook_Startup"
  - "Sheet2_Startup"
  - "ThisWorkbook_Shutdown"
  - "document-level customizations [Office development in Visual Studio], events"
  - "Sheet2_Shutdown"
  - "Startup event"
  - "Sheet3_Shutdown"
  - "add-ins [Office development in Visual Studio], events"
  - "Shutdown event"
  - "ThisAddIn_Startup"
  - "Sheet3_Startup"
  - "Startup method [Office development in Visual Studio]"
  - "Shutdown method [Office development in Visual Studio]"
  - "Sheet1_Shutdown"
  - "events [Office development in Visual Studio]"
  - "ThisAddIn_Shutdown"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Events in Office projects

  Each Office project template automatically generates several event handlers. The event handlers for document-level customizations are slightly different from event handlers for VSTO Add-ins.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

## Document-level projects
 Visual Studio provides generated code behind new or existing documents or worksheets in document-level customizations. This code raises two different events: **Startup** and **Shutdown**.

### Startup event
 The **Startup** event is raised for each of the host items (document, workbook or worksheet) after the document is running and all the initialization code in the assembly has been run. It is the last thing to run in the constructor of the class that your code is running in. For more information about host items, see [Host items and host controls overview](../vsto/host-items-and-host-controls-overview.md).

 When you create a document-level project, Visual Studio creates event handlers for the **Startup** event in the generated code files:

- For Microsoft Office Word projects, the event handler is named `ThisDocument_Startup`.

- For Microsoft Office Excel projects, the event handlers have the following names:

  - `Sheet1_Startup`

  - `Sheet2_Startup`

  - `Sheet3_Startup`

  - `ThisWorkbook_Startup`

### Shutdown event
 The **Shutdown** event is raised for each of the host items (document or worksheet) when the application domain that your code is loaded in is about to unload. It is the last thing to be called in the class as it unloads.

 When you create a document-level project, Visual Studio creates event handlers for the **Shutdown** event in the generated code files:

- For Microsoft Office Word projects, the event handler is named `ThisDocument_Shutdown`.

- For Microsoft Office Excel projects, the event handlers have the following names:

  - `Sheet1_Shutdown`

  - `Sheet2_Shutdown`

  - `Sheet3_Shutdown`

  - `ThisWorkbook_Shutdown`

> [!NOTE]
> Do not programmatically remove controls during the **Shutdown** event handler of the document. The UI elements of the document are no longer available when the **Shutdown** event occurs. If you want to remove controls before the application closes, add your code to another event handler, such as **BeforeClose** or **BeforeSave**.

### Event handler method declarations
 Every event handler method declaration has the same arguments passed to it: *sender* and *e*. In Excel, the *sender* argument refers to the sheet, such as `Sheet1` or `Sheet2`; in Word, the *sender* argument refers to the document. The *e* argument refers to the standard arguments for an event, which are not used in this case.

 The following code example shows the default event handlers in document-level projects for Word.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreWordAutomationCS/ThisDocument.cs" id="Snippet121":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreWordAutomationVB/ThisDocument.vb" id="Snippet121":::
 ---

 The following code example shows the default event handlers in document-level projects for Excel.

> [!NOTE]
> The following code example shows the event handlers in the `Sheet1` class. The names of the event handlers in other host item classes correspond to the class name. For example, in the `Sheet2` class, the **Startup** event handler is named `Sheet2_Startup`. In the `ThisWorkbook` class, the **Startup** event handler is named `ThisWorkbook_Startup`.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../vsto/codesnippet/CSharp/Trin_VstcoreExcelAutomationCS/Sheet1.cs" id="Snippet83":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../vsto/codesnippet/VisualBasic/Trin_VstcoreExcelAutomation/Sheet1.vb" id="Snippet83":::
 ---

### Order of events in document-level Excel projects
 The **Startup** event handlers in Excel projects are called in this order:

1. `ThisWorkbook_Startup`.

2. `Sheet1_Startup`.

3. `Sheet2_Startup`.

4. `Sheet3_Startup`.

5. Other sheets in order.

   The **Shutdown** event handlers in a workbook solution are called in this order:

6. `ThisWorkbook_Shutdown`.

7. `Sheet1_Shutdown`.

8. `Sheet2_Shutdown`.

9. `Sheet3_Shutdown`.

10. Other sheets in order.

    The order is determined when the project is compiled. If the user rearranges the sheets at run time, it does not change the order that the events are raised the next time the workbook is opened or closed.

## VSTO Add-in projects
 Visual Studio provides generated code in VSTO Add-ins. This code raises two different events: <xref:Microsoft.Office.Tools.AddInBase.Startup> and <xref:Microsoft.Office.Tools.AddInBase.Shutdown>.

### Startup event
 The <xref:Microsoft.Office.Tools.AddIn.Startup> event is raised after the VSTO Add-in is loaded and all the initialization code in the assembly has been run. This event is handled by the `ThisAddIn_Startup` method in the generated code file.

 Code in the `ThisAddIn_Startup` event handler is the first user code to run, unless your VSTO Add-in overrides the <xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService%2A> method. In this case, the `ThisAddIn_Startup` event handler is called after <xref:Microsoft.Office.Tools.AddInBase.RequestComAddInAutomationService%2A>.

 Don't add code in the `ThisAdd-In_Startup` event handler if the code requires a document to be open. Instead, add that code to an event that the Office application raises when a user creates or opens a document. For more information, see [Access a document when the Office application starts](../vsto/programming-vsto-add-ins.md#AccessingDocuments).

 For more information about the startup sequence of VSTO Add-ins, see [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md).

### Shutdown event
 The <xref:Microsoft.Office.Tools.AddInBase.Shutdown> event is raised when the application domain that your code is loaded in is about to be unloaded. This event is handled by the `ThisAddIn_Shutdown` method in the generated code file. This event handler is the last user code to run when the VSTO Add-in is unloaded.

#### Shutdown event in Outlook VSTO Add-ins
 The <xref:Microsoft.Office.Tools.AddInBase.Shutdown> event is raised only when the user disables the VSTO Add-in by using the COM Add-ins dialog box in Outlook. It is not raised when Outlook exits. If you have code that must run when Outlook exits, handle either of the following events:

- The <xref:Microsoft.Office.Interop.Outlook.ApplicationEvents_11_Event.Quit> event of the <xref:Microsoft.Office.Interop.Outlook.Application> object.

- The <xref:Microsoft.Office.Interop.Outlook.ExplorerEvents_10_Event.Close> event of the <xref:Microsoft.Office.Interop.Outlook.Explorer> object.

> [!NOTE]
> You can force Outlook to raise the <xref:Microsoft.Office.Tools.AddInBase.Shutdown> event when it exits by modifying the registry. However, if an administrator reverts this setting, any code that you add to the `ThisAddIn_Shutdown` method no longer runs when Outlook exits. For more information, see [Shutdown changes for Outlook 2010](/previous-versions/office/developer/office-2010/ee720183(v=office.14)).

## Related content
- [Develop Office solutions](../vsto/developing-office-solutions.md)
- [How to: Create Office projects in Visual Studio](../vsto/how-to-create-office-projects-in-visual-studio.md)
- [Program document-level customizations](../vsto/programming-document-level-customizations.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)
- [Office project templates overview](../vsto/office-project-templates-overview.md)

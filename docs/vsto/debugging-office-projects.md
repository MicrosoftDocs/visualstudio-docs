---
title: "Debug Office projects"
description: Learn how you can debug Office projects by using the same Microsoft Visual Studio tools you use for other Visual Studio projects. 
ms.date: "08/14/2019"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Excel projects [Office development in Visual Studio], debugging"
  - "Word projects [Office development in Visual Studio], debugging"
  - "Outlook [Office development in Visual Studio], debugging"
  - "debugging [Office development in Visual Studio], Outlook projects"
  - "Office projects [Office development in Visual Studio], debugging"
  - "Outlook [Office development in Visual Studio], projects"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Debug Office projects

  You can debug Office projects by using the same Microsoft Visual Studio tools you use for other Visual Studio projects. Visual Studio debugger features, such as the ability to insert breakpoints and view variables in the **Locals** window, are also available when you debug Office projects. For more information about Visual Studio debugging tools, see [Debug in Visual Studio](../debugger/debugger-feature-tour.md).

> [!TIP]
> To simplify debugging, close any open instances of the Office application before you build and debug it.

 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

## Start and stop the debugger
 You can start debugging an Office project just like you start debugging other Visual Studio projects; for example, you can press the **F5** key. When you start debugging a VSTO Add-in project, a new process for the targeted Office application is started and the VSTO Add-in is loaded.

 When you start debugging a document-level project, the document or workbook opens in a new Word or Excel process.

 When you stop the debugger, the debugger terminates the application process abruptly, or detaches if you have the debugger set to detach. All other documents that are opened in the terminated Office application process are also closed without warning, and any unsaved changes are lost. This might include all documents or workbooks that are opened while the debugger is running.

 Typically, it is better to detach from the process before stopping the debugger, so that you can quit the Office application in the normal way. You can also detach from the process first if you still want to work with an open document or worksheet after stopping the debugger.

 If you are debugging a document-level customization for Word, repeatedly stopping the debugger and causing Word to close suddenly can lead to the Normal template becoming corrupted. If this happens, you can delete the corrupted Normal template and it will automatically be recreated the next time you open Word. However, any macros that were stored in the Normal template are not recreated.

### Debug Office 2013 VSTO Add-ins by using either Office 2013 or Office 2016
 If you're using Visual Studio 2015, and you have both versions of Office installed side-by-side, Visual Studio starts Office 2016. If you're using Visual Studio 2013, Visual Studio starts Office 2013.

 If you want to debug your VSTO Add-in by using a different version of Office (2013 or 2016), open the **Project Designer**, and in the **Debug** tab, choose the **Start external program** option button. Then, browse to the location of the appropriate Office application executable.

## F10 and F11 behavior
 When you start debugging an Office project, **F10** and **F11** do not have the same behavior as when you start debugging other Visual Basic or C# projects. In Visual Basic or C# projects, the debugger stops on the main function; in Office projects, Visual Studio does not have control over the Office application's main function. However, during debugging, **F10** and **F11** do have the same functions as in Visual Basic and C# projects.

## Display exceptions
 Because of the way that managed code interacts with unmanaged code, Visual Studio does not display errors that are thrown by Microsoft Office applications. For example, if a VSTO Add-in created by using Office development tools in Visual Studio throws an exception, the Microsoft Office application continues without displaying an error. To see these errors, set the debugger to break on common language runtime exceptions. For more information, see [Manage exceptions with the debugger](../debugger/managing-exceptions-with-the-debugger.md).

 If you set the debugger to break on common language runtime exceptions, all exceptions will now break into the debugger, including ones that you have handled and some first-chance exceptions from the runtime itself, which might not be relevant to your project. Errors referring to msosec not being found appear in every project, but are safe to ignore. These msosec exceptions will not affect your solution.

 You can also use **Try...Catch** statements around your methods to catch exceptions.

 By default, Visual Studio also does not display Just-In-Time debugging errors for Office projects; however, you can enable this feature so that you can see the errors that are raised. For more information, see [Just-In-Time debugging in Visual Studio](../debugger/just-in-time-debugging-in-visual-studio.md).

## Command-line arguments
 If the **Start Action** on the **Debug** property page is set to **Start Project**, Visual Studio does not use command-line arguments when debugging the project, even if you have specified command-line arguments as start options. If you want to use command-line arguments when you start debugging, you must select a **Start Action** other than **Start Project**.

## Source control
 Debug properties are not shared among multiple users under source control. Visual Basic and C# projects store the debugging properties in a user-specific file (*ProjectName*.vbproj.user or *ProjectName*.csproj.user), and this file is not under source control. If more than one person is debugging, each person must enter debug properties manually.

## Debug cached datasets in a document-level project
 Every time you build a project, the dataset is emptied and recreated. If you want to debug a cached dataset, you must open the document outside of Visual Studio and then attach the debugger.

## Debug Word document projects based on the Word 97-2003 Document (*.doc) format
 To debug a Word Document project based on Word 97-2003 Document (*/*.doc*) format, you must add the project folder to the trusted folder list. For more information on how to do this, see [Grant trust to documents](../vsto/granting-trust-to-documents.md).

## Debug disabled add-ins
 Microsoft Office applications can disable VSTO Add-ins that behave unexpectedly. A Microsoft Office application disables VSTO Add-ins to prevent problematic code from loading every time that the application starts. However, it is also easy to cause unexpected behavior during typical debugging. For information about how to re-enable VSTO Add-ins, see [How to: Re-enable a VSTO Add-in that has been disabled](../vsto/how-to-re-enable-a-vsto-add-in-that-has-been-disabled.md).

 There are two types of disabling that Microsoft Office applications use for VSTO Add-ins: hard disabling and soft disabling.

### Hard disabling
 Hard disabling can occur when a VSTO Add-in causes the application to close unexpectedly. It might also occur on your development computer if you stop the debugger while the <xref:Microsoft.Office.Tools.AddIn.Startup> event handler in your VSTO Add-in is executing. When a VSTO Add-in is hard disabled, it appears in the **Disabled Items** list in the application.

 If an Office application hard disables a VSTO Add-in created by using Office development tools in Visual Studio, the application disables only the VSTO Add-in that caused the failure. Other VSTO Add-ins created by using Office development tools in Visual Studio for that Office application will continue to load.

### Soft disabling
 Soft disabling can occur when a VSTO Add-in produces an error that does not cause the application to unexpectedly close. For example, an application might soft disable a VSTO Add-in if it throws an unhandled exception while the <xref:Microsoft.Office.Tools.AddIn.Startup> event handler is executing. When a VSTO Add-in is soft disabled, it appears in the **Inactive Application Add-ins** list in the application, and the application changes the value of the **LoadBehavior** registry entry for the VSTO Add-in to indicate that it is unloaded. For more information about the **LoadBehavior** registry entry, see [Registry entries for VSTO Add-ins](../vsto/registry-entries-for-vsto-add-ins.md).

## Troubleshoot installation errors by using the Event Viewer
 The  Visual Studio Tools for Office runtime  writes messages to the Event Viewer in Windows for all exceptions that are thrown when you install or uninstall Office solutions. You can use these messages to resolve installation and deployment problems.

## Troubleshoot startup errors by using a log file and error messages
 The  Visual Studio Tools for Office runtime  can write all errors that occur during startup to a log file or display each error in a message box. By default, these options are turned off. You can turn on the options by creating environment variables.

 To display each error in a message box, create an environment variable named `VSTO_SUPPRESSDISPLAYALERTS` and set it to 0 (zero). You can suppress the messages by deleting the environment variable or setting it to 1 (one).

 To write the errors to a log file, create an environment variable named `VSTO_LOGALERTS` and set it to 1 (one). The  Visual Studio Tools for Office runtime  creates the log file in the folder that contains the deployment manifest for the VSTO Add-in, or in the folder that contains the document or workbook that is associated with the customization. If that fails, the  Visual Studio Tools for Office runtime  creates the log file in  the local *%TEMP%* folder. For application-level VSTO Add-ins, the default name is *add-in name*.vsto.log. For document-level projects, the name of the log file is *document name*.*extension*.log, such as ExcelWorkbook1.xlsx.log. To stop logging errors, delete the environment variable or set it to 0 (zero).

## Related content

- [Build Office solutions](../vsto/building-office-solutions.md)
- [How to: Re-enable a VSTO Add-in that has been disabled](../vsto/how-to-re-enable-a-vsto-add-in-that-has-been-disabled.md)
- [Program VSTO Add-ins](../vsto/programming-vsto-add-ins.md)

---
title: "Debugging Office Projects | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Debugging Office Projects
  You can debug Office projects by using the same Microsoft [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] tools you use for other [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] projects. [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] debugger features, such as the ability to insert breakpoints and view variables in the **Locals** window, are also available when you debug Office projects. For more information about [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] debugging tools, see [Debugging in Visual Studio](/visualstudio/debugger/debugging-in-visual-studio).  
  
> [!TIP]  
>  To simplify debugging, close any open instances of the Office application before you build and debug it.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
> [!NOTE]  
>  Interested in developing solutions that extend the Office experience across [multiple platforms](https://dev.office.com/add-in-availability)? Check out the new [Office Add-ins model](https://dev.office.com/docs/add-ins/overview/office-add-ins). Office Add-ins have a small footprint compared to VSTO add-ins and solutions, and you can build them by using almost any web programming technology, such as HTML5, JavaScript, CSS3, and XML.  
  
## Starting and Stopping the Debugger  
 You can start debugging an Office project just like you start debugging other [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] projects; for example, you can press the F5 key. When you start debugging an VSTO Add-in project, a new process for the targeted Office application is started and the VSTO Add-in is loaded.  
  
 When you start debugging a document-level project, the document or workbook opens in a new Word or Excel process.  
  
 When you stop the debugger, the debugger terminates the application process abruptly, or detaches if you have the debugger set to detach. All other documents that are opened in the terminated Office application process are also closed without warning, and any unsaved changes are lost. This might include all documents or workbooks that are opened while the debugger is running.  
  
 Typically, it is better to detach from the process before stopping the debugger, so that you can quit the Office application in the normal way. You can also detach from the process first if you still want to work with an open document or worksheet after stopping the debugger.  
  
 If you are debugging a document-level customization for Word, repeatedly stopping the debugger and causing Word to close suddenly can lead to the Normal template becoming corrupted. If this happens, you can delete the corrupted Normal template and it will automatically be recreated the next time you open Word. However, any macros that were stored in the Normal template are not recreated.  
  
### Debug Office 2013 VSTO Add-ins by using either Office 2013 or Office 2016  
 If you're using Visual Studio 2015, and you have both versions of Office installed side-by-side, Visual Studio starts Office 2016. If you're using Visual Studio 2013, Visual Studio starts Office 2013.  
  
 If you want to debug your VSTO Add-in by using a different version of Office (2013 or 2016), open the **Project Designer**, and in the **Debug** tab, choose the **Start external program** option button. Then, browse to the location of the appropriate Office application executable.  
  
## F10 and F11 Behavior  
 When you start debugging an Office project, F10 and F11 do not have the same behavior as when you start debugging other Visual Basic or C# projects. In Visual Basic or C# projects, the debugger stops on the main function; in Office projects, Visual Studio does not have control over the Office application's main function. However, during debugging, F10 and F11 do have the same functions as in Visual Basic and C# projects.  
  
## Displaying Exceptions  
 Because of the way that managed code interacts with unmanaged code, Visual Studio does not display errors that are thrown by Microsoft Office applications. For example, if an VSTO Add-in created by using Office development tools in Visual Studio throws an exception, the Microsoft Office application continues without displaying an error. To see these errors, set the debugger to break on common language runtime exceptions. For more information, see [Managing exceptions with the debugger](/visualstudio/debugger/managing-exceptions-with-the-debugger).  
  
 If you set the debugger to break on common language runtime exceptions, all exceptions will now break into the debugger, including ones that you have handled and some first-chance exceptions from the runtime itself, which might not be relevant to your project. Errors referring to msosec not being found appear in every project, but are safe to ignore. These msosec exceptions will not affect your solution.  
  
 You can also use **Try...Catch** statements around your methods to catch exceptions.  
  
 By default, Visual Studio also does not display Just-In-Time debugging errors for Office projects; however, you can enable this feature so that you can see the errors that are raised. For more information, see [Just-In-Time Debugging in Visual Studio](/visualstudio/debugger/just-in-time-debugging-in-visual-studio).  
  
## Command Line Arguments  
 If the **Start Action** on the **Debug** property page is set to **Start Project**, Visual Studio does not use command line arguments when debugging the project, even if you have specified command line arguments as start options. If you want to use command line arguments when you start debugging, you must select a **Start Action** other than **Start Project**.  
  
## Source Control  
 Debug properties are not shared among multiple users under source control. Visual Basic and C# projects store the debugging properties in a user-specific file (*ProjectName*.vbproj.user or *ProjectName*.csproj.user), and this file is not under source control. If more than one person is debugging, each person must enter debug properties manually.  
  
## Debugging Cached Datasets in a Document-Level Project  
 Every time you build a project, the dataset is emptied and recreated. If you want to debug a cached dataset, you must open the document outside of Visual Studio and then attach the debugger.  
  
## Debugging Word Document Projects Based on the Word 97-2003 Document (*.doc) Format  
 To debug a Word Document project based on Word 97-2003 Document (*.doc) format, you must add the project folder to the trusted folder list. For more information on how to do this, see [Granting Trust to Documents](../vsto/granting-trust-to-documents.md)..  
  
## Debugging Disabled Add-ins  
 Microsoft Office applications can disable VSTO Add-ins that behave unexpectedly. A Microsoft Office application disables VSTO Add-ins to prevent problematic code from loading every time that the application starts. However, it is also easy to cause unexpected behavior during typical debugging. For information about how to re-enable VSTO Add-ins, see [How to: Re-enable a VSTO Add-in That Has Been Disabled](../vsto/how-to-re-enable-a-vsto-add-in-that-has-been-disabled.md).  
  
 There are two types of disabling that Microsoft Office applications use for VSTO Add-ins: hard disabling and soft disabling.  
  
### Hard Disabling  
 Hard disabling can occur when an VSTO Add-in causes the application to close unexpectedly. It might also occur on your development computer if you stop the debugger while the <xref:Microsoft.Office.Tools.AddIn.Startup> event handler in your VSTO Add-in is executing. When an VSTO Add-in is hard disabled, it appears in the **Disabled Items** list in the application.  
  
 If an Office application hard disables an VSTO Add-in created by using Office development tools in Visual Studio, the application disables only the VSTO Add-in that caused the failure. Other VSTO Add-ins created by using Office development tools in Visual Studio for that Office application will continue to load.  
  
### Soft Disabling  
 Soft disabling can occur when an VSTO Add-in produces an error that does not cause the application to unexpectedly close. For example, an application might soft disable an VSTO Add-in if it throws an unhandled exception while the <xref:Microsoft.Office.Tools.AddIn.Startup> event handler is executing. When an VSTO Add-in is soft disabled, it appears in the **Inactive Application Add-ins** list in the application, and the application changes the value of the **LoadBehavior** registry entry for the VSTO Add-in to indicate that it is unloaded. For more information about the **LoadBehavior** registry entry, see [Registry Entries for VSTO Add-ins](../vsto/registry-entries-for-vsto-add-ins.md).  
  
## Troubleshooting Installation Errors by Using the Event Viewer  
 The [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] writes messages to the Event Viewer in Windows for all exceptions that are thrown when you install or uninstall Office solutions. You can use these messages to resolve installation and deployment problems.  
  
## Troubleshooting Startup Errors by Using a Log File and Error Messages  
 The [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] can write all errors that occur during startup to a log file or display each error in a message box. By default, these options are turned off. You can turn the options on by creating environment variables.  
  
 To display each error in a message box, create an environment variable named `VSTO_SUPPRESSDISPLAYALERTS` and set it to 0 (zero). You can suppress the messages by deleting the environment variable or setting it to 1 (one).  
  
 To write the errors to a log file, create an environment variable named `VSTO_LOGALERTS` and set it to 1 (one). The [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] creates the log file in the folder that contains the deployment manifest for the VSTO Add-in, or in the folder that contains the document or workbook that is associated with the customization. If that fails, the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] creates the log file in  the local %TEMP% folder. For application-level VSTO Add-ins, the default name is *add-in name*.vsto.log. For document-level projects, the name of the log file is *document name*.*extension*.log, such as ExcelWorkbook1.xlsx.log. To stop logging errors, delete the environment variable or set it to 0 (zero).  
  
## See Also  
 [Building Office Solutions](../vsto/building-office-solutions.md)   
 [How to: Re-enable a VSTO Add-in That Has Been Disabled](../vsto/how-to-re-enable-a-vsto-add-in-that-has-been-disabled.md)   
 [Programming VSTO Add-Ins](../vsto/programming-vsto-add-ins.md)  
  
  
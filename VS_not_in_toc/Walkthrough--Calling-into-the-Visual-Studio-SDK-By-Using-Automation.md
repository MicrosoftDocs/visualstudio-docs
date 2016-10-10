---
title: "Walkthrough: Calling into the Visual Studio SDK By Using Automation"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ca4dab48-632c-4c2a-8c84-57c027e37987
caps.latest.revision: 31
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Walkthrough: Calling into the Visual Studio SDK By Using Automation
This walkthrough illustrates how to create a Visual Studio add-in that consumes a Visual Studio service. The add-in you create gets a service provider and uses it to obtain a service. You can use this same technique to obtain any proffered Visual Studio service. For more information on services and service providers, see [Using and Providing Services](../Topic/Using%20and%20Providing%20Services.md). The procedures below demonstrate how to create an add-in and then obtain a service from the add-in.  
  
## Creating an Add-In  
 In this section, you create a Visual Studio add-in using the Visual Studio Add-In project template.  
  
#### To create an add-in  
  
1.  Create a new Visual Studio project (**File/New/Project**).  
  
2.  In the left pane of the **New Project** dialog box, expand the **Other Project Types** node and then click the **Extensibility** node. Select **Visual Studio Add-in**.  
  
3.  Create a new add-in project named `Addin`.  
  
     In the Visual Studio Add-In wizard, click **Next**.  
  
4.  On the **Select a Programming Language**  page, select **Create an Add-In using Visual C#** or **Create an Add-In using Visual Basic**.  
  
5.  On the **Select an Application Host** page, select **Microsoft Visual Studio <version\>**.  
  
6.  On the **Enter a Name and Description** page, type `MyAddin` in the **Name** box and `MyAddin Walkthrough` in the **Description** box.  
  
7.  On the **Choose Add-In Options** page, select the option for a Tools menu item under **Would you like to create command bar UI for your Add-In?**. Clear the other check boxes.  
  
8.  Accept all other defaults.  
  
9. Build the solution and verify that it compiles without errors.  
  
## Obtaining a Service from an Add-In  
 The following steps guide you through acquiring a service from your add-in.  
  
#### To obtain a service  
  
1.  Open the file Connect.cs or Connect.vb and add these lines to the `using` (C#) or `Imports` (Visual Basic) statements:  
  
     [!CODE [VSSDKAddin#1](../CodeSnippet/VS_Snippets_VSSDK/vssdkaddin#1)]  
  
2.  Right-click the project node in **Solution Explorer** and add these .NET references:  
  
    ```  
    Microsoft.VisualStudio.OLE.Interop  
    Microsoft.VisualStudio.Shell.Interop  
    ```  
  
3.  Add these lines of code to the `if(commandName == "Addin.Connect.Addin")` or `If commandName = "Addin.Connect.Addin" Then` clause of the `Exec` method:  
  
     [!CODE [VSSDKAddin#2](../CodeSnippet/VS_Snippets_VSSDK/vssdkaddin#2)]  
  
     This code casts the current application object (type `DTE2`) into an `IOleServiceProvider`, then calls `QueryService` to obtain the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShell?qualifyHint=False> service. This service provides an <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell?qualifyHint=False> interface. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ShowMessageBox?qualifyHint=False> method displays a message box when the add-in runs.  
  
4.  Build and start the Addin project in debug mode by pressing F5.  
  
     This starts another instance of Visual Studio.  
  
5.  In the new Visual Studio instance, on the **Tools** menu, click **Addin**. The message box displays this:  
  
    ```  
    MyAddin  
    Inside Addin.Connect  
    ```  
  
## See Also  
 [How to: Deactivate and Remove an Add-In](../Topic/How%20to:%20Deactivate%20and%20Remove%20an%20Add-In.md)
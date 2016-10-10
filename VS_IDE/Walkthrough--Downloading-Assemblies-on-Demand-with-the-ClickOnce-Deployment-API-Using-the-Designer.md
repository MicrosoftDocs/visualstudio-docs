---
title: "Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API Using the Designer"
ms.custom: na
ms.date: 10/05/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 59a0dd5f-1cab-4f2f-b780-0ab7399905d5
caps.latest.revision: 18
manager: wpickett
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
# Walkthrough: Downloading Assemblies on Demand with the ClickOnce Deployment API Using the Designer
By default, all the assemblies included in a ClickOnce application are downloaded when the application is first run. However, there might be parts of your application that are used by a small set of the users. In this case, you want to download an assembly only when you create one of its types. The following walkthrough demonstrates how to mark certain assemblies in your application as "optional", and how to download them by using classes in the <xref:System.Deployment.Application?qualifyHint=False> namespace when the common language runtime demands them.  
  
> [!NOTE]
>  Your application will have to run in full trust to use this procedure.  
  
> [!NOTE]
>  The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, click **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](assetId:///22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
## Creating the Projects  
  
#### To create a project that uses an on-demand assembly with Visual Studio  
  
1.  Create a new Windows Forms project in Visual Studio. On the **File** menu, point to **Add**, and then click **New Project**. Choose a **Class Library** project in the dialog box and name it `ClickOnceLibrary`.  
  
    > [!NOTE]
    >  In Visual Basic, we recommend that you modify the project properties to change the root namespace for this project to `Microsoft.Samples.ClickOnceOnDemand` or to a namespace of your choice. For simplicity, the two projects in this walkthrough are in the same namespace.  
  
2.  Define a class named `DynamicClass` with a single property named `Message`.  
  
     [!CODE [ClickOnceLibrary#1](../CodeSnippet/VS_Snippets_Winforms/ClickOnceLibrary#1)]  
  
3.  Select the Windows Forms project in **Solution Explorer**. Add a reference to the <xref:System.Deployment.Application?qualifyHint=False> assembly and a project reference to the `ClickOnceLibrary` project.  
  
    > [!NOTE]
    >  In Visual Basic, we recommend that you modify the project properties to change the root namespace for this project to `Microsoft.Samples.ClickOnceOnDemand` or to a namespace of your choice. For simplicity, the two projects in this walkthrough are located in the same namespace.  
  
4.  Right-click the form, click **View Code** from the menu, and add the following references to the form.  
  
     [!CODE [ClickOnceOnDemand#1](../CodeSnippet/VS_Snippets_Winforms/ClickOnceOnDemand#1)]  
  
5.  Add the following code to download this assembly on demand. This code shows how to map a set of assemblies to a group name using a generic <xref:System.Collections.DictionaryBase.Dictionary?qualifyHint=False> class. Because we are only downloading a single assembly in this walkthrough, there is only one assembly in our group. In a real application, you would likely want to download all assemblies related to a single feature in your application at the same time. The mapping table enables you to do this easily by associating all the DLLs that belong to a feature with a download group name.  
  
     [!CODE [ClickOnceOnDemand#2](../CodeSnippet/VS_Snippets_Winforms/ClickOnceOnDemand#2)]  
  
6.  On the **View** menu, click **Toolbox**. Drag a <xref:System.Windows.Forms.Button?qualifyHint=False> from the **Toolbox** onto the form. Double-click the button and add the following code to the <xref:System.Windows.Forms.Control.Click?qualifyHint=False> event handler.  
  
     [!CODE [ClickOnceOnDemand#3](../CodeSnippet/VS_Snippets_Winforms/ClickOnceOnDemand#3)]  
  
## Marking Assemblies as Optional  
  
#### To mark assemblies as optional in your ClickOnce application by using Visual Studio  
  
1.  Right-click the Windows Forms project in **Solution Explorer** and click **Properties**. Select the **Publish** tab.  
  
2.  Click the **Application Files** button.  
  
3.  Find the listing for ClickOnceLibrary.dll. Set the **Publish Status** drop-down box to **Include**.  
  
4.  Expand the **Group** drop-down box and select **New**. Enter the name `ClickOnceLibrary` as the new group name.  
  
5.  Continue publishing your application as described in [How to: Publish a ClickOnce Application using the Publish Wizard](../VS_IDE/How-to--Publish-a-ClickOnce-Application-using-the-Publish-Wizard.md).  
  
#### To mark assemblies as optional in your ClickOnce application by using Manifest Generation and Editing Tool — Graphical Client (MageUI.exe)  
  
1.  Create your ClickOnce manifests as described in [Walkthrough: Manually Deploying a ClickOnce Application](../VS_IDE/Walkthrough--Manually-Deploying-a-ClickOnce-Application.md).  
  
2.  Before closing MageUI.exe, select the tab that contains your deployment's application manifest, and within that tab select the **Files** tab.  
  
3.  Find ClickOnceLibrary.dll in the list of application files and set its **File Type** column to **None**. For the **Group** column, type `ClickOnceLibrary.dll`.  
  
## Testing the New Assembly  
  
#### To test your on-demand assembly  
  
1.  Start your application deployed with ClickOnce.  
  
2.  When your main form appears, press the <xref:System.Windows.Forms.Button?qualifyHint=False>. You should see a string in a message box window that reads, "Hello, World!"  
  
## See Also  
 <xref:System.Deployment.Application.ApplicationDeployment?qualifyHint=False>
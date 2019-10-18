---
title: "References Page, Project Designer (Visual Basic) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "vb.ProjectPropertiesReference"
  - "vb.ProjectPropertiesUnusedReference"
  - "vb.ProjectPropertiesReferencePaths"
helpviewer_keywords: 
  - "References page in Project Designer"
  - "Project Designer, References page"
  - "Unused References dialog box"
ms.assetid: 5a47c595-e084-401c-86e1-74e0bf74fd86
caps.latest.revision: 40
author: gewarren
ms.author: gewarren
manager: jillfra
---
# References Page, Project Designer (Visual Basic)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use the **References** page of the **Project Designer** to manage references, Web references, and imported namespaces in your project. Projects can contain references to COM components, XML Web services, .NET Framework class libraries or assemblies, or other class libraries. For more information on using references, see [Managing references in a project](../../ide/managing-references-in-a-project.md).  
  
 To access the **References** page, choose a project node (not the **Solution** node) in **Solution Explorer**. Then choose **Project**, **Properties** on the menu bar. When the Project Designer appears, click the **References** tab.  
  
## UIElement List  
 The following options allow you to select or remove references and imported namespaces in your project.  
  
 **Unused References**  
 Click this button to access the **Unused References** dialog box.  
  
 The **Unused References** dialog box allows you to remove references that are included in your project but not actually used by the code. It contains a grid that lists the **Reference Name**, the **Path**, and other information about the unused namespace references in your project. In the grid, select the namespace references that you want to remove from your project and click **Remove**.  
  
 **Reference Paths**  
 Click this button to access the **Reference Paths** dialog box.  
  
> [!NOTE]
> When the project system finds an assembly reference, the system resolves the reference by looking in the following locations, in the following order:  
> 
> 1. The project folder. The project folder files appear in **Solution Explorer** when **Show All Files** isn't in effect.  
>    2. Folders that are specified in the **Reference Paths** dialog box.  
>    3. Folders that display files in the **Add Reference** dialog box.  
>    4. The project's obj folder. (When you add a COM reference to your project, one or more assemblies may be added to the project's obj folder.)  
  
 **References**  
 This list shows all references in the project, used or unused.  
  
 **Add**  
 Click this button to add a reference or Web reference to the **References** list.  
  
 Choose **Reference** to add a reference to your project using the Add Reference dialog box.  
  
 Choose **Web Reference** to add a Web reference to your project using the Add Web Reference dialog box.  
  
 **Remove**  
 Select one or more references in the **References** list, then click this button to delete it.  
  
 **Update Web Reference**  
 Select a Web reference in the **References** list and click this button to update it.  
  
 **Imported namespaces**  
 You can type your own namespace in this box and click **Add User Import** to add it to the namespaces list.  
  
 You can create aliases for user-imported namespaces. To do this, enter the alias and the namespace in the format *alias*=*namespace*. This is useful if you are using long namespaces, for example: `Http= MyOrg.ObjectLib.Internet.WebRequestMethods.Http`.  
  
 **Add User Import**  
 Click this button to add the namespace specified in the **Imported namespaces** box to the list of imported namespaces. The button is active only if the specified namespace is not already in the list.  
  
 **Namespaces list**  
 This list shows all available namespaces. The check boxes for namespaces included in your project are selected.  
  
 **Update User Import**  
 Select a user-specified namespace in the namespaces list, type the name that you want to replace it with in the **Imported namespaces** box, and then click this button to change to the new namespace. The button is active only if the selected namespace is one that you added to the list by using the **Add User Import** button. You can add:  
  
- Classes or namespaces, such as <xref:System.Math?displayProperty=fullName>.  
  
- Aliased imports, such as `VB=Microsoft.VisualBasic`.  
  
- XML namespaces, such as `<xmlns:xsl="http://www.w3.org/1999/XSL/Transform">`.  
  
## See also  
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9)   
 [How to: Add or Remove Imported Namespaces (Visual Basic)](../../ide/how-to-add-or-remove-imported-namespaces-visual-basic.md)   
 [NIB: Add Web Reference Dialog Box](https://msdn.microsoft.com/bdf05776-c591-40af-bfd7-e1e2aa1e87b5)   
 [Imports Statement (XML Namespace)](https://msdn.microsoft.com/library/1f4d50a6-08c7-4c2e-8206-ccae35fcd1b4)

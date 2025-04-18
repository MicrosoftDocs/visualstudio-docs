---
title: References Page, Project Designer (Visual Basic)
description: Learn how to use the References page of the Project Designer to manage your project's references, web references, and imported namespaces.
ms.date: 06/21/2017
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesReference
- vb.ProjectPropertiesUnusedReference
- vb.ProjectPropertiesReferencePaths
helpviewer_keywords:
- References page in Project Designer
- Project Designer, References page
ms.custom: "ide-ref"
author:ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
monikerRange: 'vs-2019'
---
# References Page, Project Designer (Visual Basic)

Use the **References** page of the **Project Designer** to manage references, web references, and imported namespaces in your project. Projects can contain references to COM components, XML web services, .NET libraries or assemblies, or other class libraries. For more information on using references, see [Managing references in a project](../../ide/managing-references-in-a-project.md).

To access the **References** page, choose a project node (not the **Solution** node) in **Solution Explorer**. Then choose **Project**, **Properties** on the menu bar. When the Project Designer appears, click the **References** tab.

## UIElement List

The following options allow you to select or remove references and imported namespaces in your project.

**Reference Paths**

Click this button to access the **Reference Paths** dialog box.

> [!NOTE]
> When the project system finds an assembly reference, the system resolves the reference by looking in the following locations, in the following order:
>
> 1. The project folder. The project folder files appear in **Solution Explorer** when **Show All Files** isn't in effect.
> 2. Folders that are specified in the **Reference Paths** dialog box.
> 3. Folders that display files in the **Add Reference** dialog box.
> 4. The project's obj folder. (When you add a COM reference to your project, one or more assemblies may be added to the project's obj folder.)

 **References**

This list shows all references in the project, used or unused.

 **Add**

Click this button to add a reference or web reference to the **References** list.

Choose **Reference** to add a reference to your project using the Add Reference dialog box.

Choose **Web Reference** to add a web reference to your project using the **Add Web Reference** dialog box.

 **Remove**

Select one or more references in the **References** list, then click this button to delete it.

 **Update Web Reference**

Select a web reference in the **References** list and click this button to update it.

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

- [Managing references in a project](../../ide/managing-references-in-a-project.md)
- [How to: Add or Remove Imported Namespaces (Visual Basic)](../../ide/how-to-add-or-remove-imported-namespaces-visual-basic.md)
- [Imports Statement (XML Namespace)](/dotnet/visual-basic/language-reference/statements/imports-statement-xml-namespace)

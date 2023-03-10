---
title: Troubleshoot broken references
description: Learn how to troubleshoot broken references that might be caused by something other than your application's inability to find the referenced component.
ms.date: 07/01/2022
ms.topic: troubleshooting
helpviewer_keywords:
- C# projects, references
- Visual Basic projects, references
- troubleshooting references
- referencing files from projects
- referencing components, troubleshooting
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Troubleshoot broken references

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

If your application attempts to use a broken reference, an exception error is generated. The inability to find the referenced component is the primary trigger for the error, but there are several situations in which a reference can be considered broken. These instances are included in the following list:

- The project's reference path is incorrect or incomplete.

- The file being referenced has been deleted.

- The file being referenced has been renamed.

- The network connection or authentication has failed.

- The reference is to a COM component that isn't installed on the computer.

The following are remedies to these problems.

> [!NOTE]
> Files in assemblies are referenced with absolute paths in the project file. Therefore, users who work in a multi-developer environment might find that they're missing a referenced assembly in their local environment. To avoid these errors, it's better to add project-to-project references. For more information, see [Assemblies in .NET](/dotnet/standard/assembly/).

## Reference path is incorrect

If projects are shared on different computers, some references might not be found when a component is located in a different directory on each computer. References are stored under the name of the component file (for example, *MyComponent*). When a reference is added to a project, the folder location of the component file (for example, *C:\MyComponents*) is appended to the **ReferencePath** project property.

When the project is opened, Visual Studio attempts to locate these referenced component files by looking in the directories on the reference path. If the project is opened on a computer that stores the component in a different directory, such as *D:\MyComponents*, the reference can't be found and an error appears in the **Task List**.

To fix this problem, you can delete the broken reference and then replace it by using the **Add Reference** dialog box. Another solution is to use the **Reference Path** item in the project's property pages and modify the folders in the list to point to the correct locations. The **Reference Path** property is persisted for each user on each computer. Therefore, modifying your reference path doesn't affect other users of the project.

> [!TIP]
> Project-to-project references don't have these problems. For this reason, use them instead of file references, if you can.

### To fix a broken project reference by correcting the reference path

1. In **Solution Explorer**, right-click your project node, and then select **Properties**.

   The **Project Designer** appears.

1. If you're using Visual Basic, select the References page, and then click the **Reference Paths** button. In the **Reference Paths** dialog box, type the path of the folder that contains the item you want to reference in the **Folder** field, and then click the **Add Folder** button.

    If you're using C#, select the **Reference Paths** page. In the **Folder** field, type the path of the folder that contains the item you want to reference, and then click the **Add Folder** button.

## Referenced file was deleted

Here are two options to fix a broken project reference for a deleted file that no longer exists on your drive:

- Delete the reference.

- If the reference exists in another location on your computer, read it from that location.

## Referenced file was renamed

Here are two options to fix a broken reference for a file that was renamed:

- Delete the reference, and then add a reference to the renamed file.

- If the reference exists in another location on your computer, read it from that location.

## Network connection or authentication has failed

There can be many possible causes for inaccessible files. For example, there might be a failed network connection or a failed authentication. Conversely, each cause might have a unique means of recovery. For example, you might have to contact the local administrator for access to the required resources. However, deleting the reference and fixing the code that used it is always an option.

## COM component isn't installed on computer

If a user adds a reference to a COM component and a second user tries to run the code on a computer that doesn't have this component installed, the second user receives an error that the reference is broken. Installing the component on the second computer corrects the error. For more information about how to use references to COM components in your projects, see [COM interoperability in .NET Framework applications](/dotnet/visual-basic/programming-guide/com-interop/com-interoperability-in-net-framework-applications).

## See also

- [References Page, Project Designer (Visual Basic)](../ide/reference/references-page-project-designer-visual-basic.md)
- [What is the .NET Project Designer?](reference/project-properties-reference.md)

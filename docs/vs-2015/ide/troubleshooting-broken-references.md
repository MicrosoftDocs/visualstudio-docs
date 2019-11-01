---
title: "Troubleshooting Broken References | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: troubleshooting
helpviewer_keywords:
  - "Visual C# projects, references"
  - "Visual Basic projects, references"
  - "troubleshooting references"
  - "referencing files from projects"
  - "referencing components, troubleshooting"
ms.assetid: 00a9ade9-652e-40de-8ada-85f63cd183ee
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# Troubleshooting Broken References
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If your application attempts to use a broken reference, an exception error is generated. The inability to find the referenced component is the primary trigger for the error, but there are several situations in which a reference can be considered broken. These instances are shown in the following list:

- The project's reference path is incorrect or incomplete.

- The file being referenced has been deleted.

- The file being referenced has been renamed.

- The network connection or authentication has failed.

- The reference is to a COM component that is not installed on the computer.

  The following are remedies to these problems.

> [!NOTE]
> Files in assemblies are referenced with absolute paths in the project file. Therefore, it is possible for users who work in a multideveloper environment to be missing a referenced assembly in their local environment. To avoid these errors, it is better in these cases to add project-to-project references. For more information, see [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9) and [Programming with Assemblies](https://msdn.microsoft.com/library/25918b15-701d-42c7-95fc-c290d08648d6).

## Reference Path Is Incorrect
 If projects are shared on different computers, some references might not be found when a component is located in a different directory on each computer. References are stored under the name of the component file (for example, MyComponent). When a reference is added to a project, the folder location of the component file (for example, C:\MyComponents\\) is appended to the **ReferencePath** project property.

 When the project is opened, it attempts to locate these referenced component files by looking in the directories on the reference path. If the project is opened on a computer that stores the component in a different directory, such as D:\MyComponents\\, the reference cannot be found and an error appears in the Task List.

 To fix this problem, you can delete the broken reference and then replace it using the Add Reference dialog box. Another solution is to use the **Reference Path** item in the project's property pages and modify the folders in the list to point to the correct locations. The **Reference Path** property is persisted for each user on each computer. Therefore, modifying your reference path does not affect other users of the project.

> [!TIP]
> Project-to-project references do not have these problems. For this reason, use them instead of file references, if you can.

#### To fix a broken project reference by correcting the reference path

1. In **Solution Explorer**, right-click your project node and click **Properties**.

2. The **Project Designer** appears.

3. If you are using Visual Basic, select the **References** page and click the **Reference Paths** button. In the **Reference Paths** dialog box, type the path of the folder that contains the item you want to reference in the **Folder** field, and then click the **Add Folder** button.

     -or-

     If you are using Visual C#, select the **Reference Paths** page. In the **Folder** field, type the path of the folder that contains the item you want to reference, and then click the **Add Folder** button.

## Referenced File Has Been Deleted
 It is possible that the file being referenced has been deleted and no longer exists on the drive.

#### To fix a broken project reference for a file that no longer exists on your drive

- Delete the reference.

- If the reference exists in another location on your computer, read it from that location.

- For more information, see [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9).

## Referenced File Has Been Renamed
 It is possible that the file being referenced has been renamed.

#### To fix a broken reference for a file that has been renamed

- Delete the reference, and then add a reference to the renamed file.

- If the reference exists in another location on your computer, you have to read it in from that location. For more information, see [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9).

## Network Connection or Authentication Has Failed
 There can be many possible causes for inaccessible files: a failed network connection or a failed authentication, for example. Each cause might have a unique means of recovery; for example, you might have to contact the local administrator for access to the required resources. However, deleting the reference and fixing the code which used it is always an option. For more information, see [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9).

## COM Component Is Not Installed on Computer
 If a user has added a reference to a COM component and a second user tries to run the code on a computer that does not have this component installed, the second user will receive an error that the reference is broken. Installing the component on the second computer will correct the error. For more information about how to use references to COM components in your projects, see [COM Interoperability in .NET Framework Applications](https://msdn.microsoft.com/library/f5a72143-c268-4dff-a019-974ad940e17d).

## See Also
 [Introduction to the Project Designer](https://msdn.microsoft.com/898dd854-c98d-430c-ba1b-a913ce3c73d7)
 [References Page, Project Designer (Visual Basic)](../ide/reference/references-page-project-designer-visual-basic.md)
 [NIB How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9)

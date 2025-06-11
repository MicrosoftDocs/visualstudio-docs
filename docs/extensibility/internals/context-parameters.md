---
title: Context Parameters
description: Learn about context parameters in the Visual Studio integrated development environment (IDE) that define the state of a project when you add or implement a wizard. 
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- wizards, context parameters
- context parameters
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Context parameters

In the Visual Studio integrated development environment (IDE), you can add wizards to the **New Project**, **Add New Item**, or **Add Sub Project** dialog boxes. The added wizards are available on the **File** menu or by right-clicking a project in **Solution Explorer**. The IDE passes context parameters to the implementation of the wizard. The context parameters define the state of the project when the IDE calls the wizard.

 The IDE starts wizards by setting the <xref:Microsoft.VisualStudio.Shell.Interop.VSADDITEMOPERATION> flag in the IDE's call to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.AddItem%2A> method for the project. When set, the project must cause the `IVsExtensibility::RunWizardFile` method to be executed by using the registered wizard name or GUID and other context parameters that the IDE passes to it.

## Context parameters for new project

| Parameter | Description |
|-------------------------| - |
| `WizardType` | Registered wizard type (<xref:EnvDTE.Constants.vsWizardNewProject>) or the GUID that indicates the type of wizard. In the Visual Studio SDK implementation, the GUID for the wizard is {0F90E1D0-4999-11D1-B6D1-00A0C90F2744}. |
| `ProjectName` | A string that is the unique Visual Studio project name. |
| `LocalDirectory` | Local location of working project files. |
| `InstallationDirectory` | Directory path of the Visual Studio is installation. |
| `FExclusive` | Boolean flag that indicates that the project should close open solutions. |
| `SolutionName` | Name of the solution file without the directory portion or the *.sln* extension. The *.suo* file name is also created by using `SolutionName`. When this argument is not an empty string, the wizard uses <xref:EnvDTE._Solution.Create%2A> before adding the project with <xref:EnvDTE._Solution.AddFromTemplate%2A>. If this name is an empty string, use <xref:EnvDTE._Solution.AddFromTemplate%2A> without calling <xref:EnvDTE._Solution.Create%2A>. |
| `Silent` | Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (`TRUE`). |

## Context parameters for Add New Item

| Parameter | Description |
|-------------------------| - |
| `WizardType` | Registered wizard type (<xref:EnvDTE.Constants.vsWizardAddItem>) or the GUID that indicates the type of wizard. In the Visual Studio SDK implementation, the GUID for the wizard is {0F90E1D1-4999-11D1-B6D1-00A0C90F2744}. |
| `ProjectName` | A string that is the unique Visual Studio project name. |
| `ProjectItems` | Local location that contains working project files. |
| `ItemName` | Name of the item that is to be added. This name is either the default file name or the file name that the user types from the **Add Items** dialog box. The name is based on the flags that are set in the *.vsdir* file. The name can be a null value. |
| `InstallationDirectory` | Directory path of the Visual Studio is installation. |
| `Silent` | Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (`TRUE`). |

## Context parameters for Add Sub Project

| Parameter | Description |
|-------------------------| - |
| `WizardType` | Registered wizard type (<xref:EnvDTE.Constants.vsWizardAddSubProject>) or the GUID that indicates the type of wizard. In the Visual Studio SDK implementation, the GUID for the wizard is {0F90E1D2-4999-11D1-B6D1-00A0C90F2744}. |
| `ProjectName` | A string that is the unique Visual Studio project name. |
| `ProjectItems` | Pointer to the `ProjectItems` collection on which the wizard operates. This pointer is passed to the wizard based on the project hierarchy selection. A user typically selects a folder in which to put the item and then calls the project's **Add Item** dialog box. |
| `LocalDirectory` | Local location of working project files. |
| `ItemName` | Name of the item that is to be added. This name is either the default file name or the file name that the user types from the **Add Items** dialog box. The name is based on the flags that are set in the *.vsdir* file. The name can be a null value. |
| `InstallationDirectory` | Directory path of the Visual Studio installation. |
| `Silent` | Boolean that indicates whether the wizard should run silently as if **Finish** were clicked (`TRUE`). |

## See also
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject>
- <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject2>
- [Custom parameters](../../extensibility/internals/custom-parameters.md)
- [Wizards](../../extensibility/internals/wizards.md)
- [Wizard (.vsz) file](../../extensibility/internals/wizard-dot-vsz-file.md)
- [Context parameters for launching wizards](/previous-versions/tz690efs(v=vs.140))
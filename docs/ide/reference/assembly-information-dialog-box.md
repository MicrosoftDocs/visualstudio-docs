---
title: Assembly Information Dialog Box
description: Learn about the Assembly Information dialog box and how it is used to specify the values of the .NET Framework global assembly attributes.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesAssemblyInfo
helpviewer_keywords:
- Assembly Information dialog box
ms.custom: "ide-ref"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
monikerRange: 'vs-2019'
---
# Assembly Information dialog box

The Assembly Information dialog box is used to specify the values of the .NET Framework global assembly attributes, which are stored in the AssemblyInfo file created automatically with your project. In Solution Explorer, the AssemblyInfo file is located in the **My Project** node for Visual Basic projects (click **Show All files** to view it). For C# projects, it's located under **Properties**. For more information, see [Attributes (C#)](/dotnet/csharp/programming-guide/concepts/attributes/index).

To access this dialog box, select a project node in **Solution Explorer**, and then, on the **Project** menu, select **Properties**. On the **Application** page, select the **Assembly Information** button.

> [!NOTE]
> The information in this topic only applies to .NET Framework projects, not .NET Core or .NET 5 and later projects. For those projects, edit the AssemblyInfo file directly.

## UIElement list

**Title**\
Specifies a title for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyTitleAttribute>.

**Description**\
Specifies an optional description for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyDescriptionAttribute>.

**Company**\
Specifies a company name for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyCompanyAttribute>.

You can set or change the default value for Company in the registry. Look for the **RegisteredOrganization** value under the **Computer\HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Microsoft\Windows NT\CurrentVersion** or **Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion** key, depending on your version of Windows.

**Product**\
Specifies a product name for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyProductAttribute>.

**Copyright**\
Specifies a copyright notice for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyCopyrightAttribute>.

**Trademark**\
Specifies a trademark for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyTrademarkAttribute>.

**Assembly Version**\
Specifies the version of the assembly. Corresponds to <xref:System.Reflection.AssemblyVersionAttribute>.

**File Version**\
Specifies a version number that instructs the compiler to use a specific version for the Win32 file version resource. Corresponds to <xref:System.Reflection.AssemblyFileVersionAttribute>.

**GUID**\
A unique GUID that identifies the assembly. When you create a project, Visual Studio generates a GUID for the assembly. Corresponds to <xref:System.Guid>.

**Neutral Language**\
Specifies which culture the assembly supports. Corresponds to <xref:System.Resources.NeutralResourcesLanguageAttribute>. The default is **(None)**.

**Make assembly COM-Visible**\
Specifies whether types in the assembly will be available to COM. Corresponds to <xref:System.Runtime.InteropServices.ComVisibleAttribute>.

> [!NOTE]
> For more information on setting these properties when generating a NuGet package in a .NET Framework class library, see [Configure project properties for the package](/nuget/quickstart/create-and-publish-a-package-using-visual-studio-net-framework#configure-project-properties-for-the-package). And for more information about Licensing and Expressions as they relate to a NuGet package, see [licenses.nuget.org](/nuget/nuget-org/licenses.nuget.org/).

## See also

- [Application Page, Project Designer (Visual Basic)](../../ide/reference/application-page-project-designer-visual-basic.md)
- [Attributes](/previous-versions/z0w1kczw(v=vs.140))

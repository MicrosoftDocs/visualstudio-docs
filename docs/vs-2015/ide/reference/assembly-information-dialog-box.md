---
title: "Assembly Information Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "vb.ProjectPropertiesAssemblyInfo"
helpviewer_keywords:
  - "Assembly Information dialog box"
ms.assetid: 8f1f6449-e03d-4a5b-9076-d3b1f84ada48
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Assembly Information Dialog Box
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The **Assembly Information** dialog box is used to specify the values of the [!INCLUDE[dnprdnshort](../../includes/dnprdnshort-md.md)] global assembly attributes, which are stored in the AssemblyInfo file created automatically with your project. In **Solution Explorer**, the file is located in the **My Project** node in [!INCLUDE[vbprvb](../../includes/vbprvb-md.md)] (click **Show All files** to view it); it is located under **Properties** in [!INCLUDE[csprcs](../../includes/csprcs-md.md)]. For more information about assembly attributes, see [Attributes](https://msdn.microsoft.com/library/ae334cee-d96c-4243-a5e3-06dd7fcaf205).

 To access this dialog box, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Application** tab. On the **Application** page, click the **Assembly Information** button.

## UIElement List
 **Title**
 Specifies a title for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyTitleAttribute>.

 **Description**
 Specifies an optional description for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyDescriptionAttribute>.

 **Company**
 Specifies a company name for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyCompanyAttribute>.

 **Product**
 Specifies a product name for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyProductAttribute>.

 **Copyright**
 Specifies a copyright notice for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyCopyrightAttribute>.

 **Trademark**
 Specifies a trademark for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyTrademarkAttribute>.

 **Assembly Version**
 Specifies the version of the assembly. Corresponds to <xref:System.Reflection.AssemblyVersionAttribute>.

 **File Version**
 Specifies a version number that instructs the compiler to use a specific version for the Win32 file version resource. Corresponds to <xref:System.Reflection.AssemblyFileVersionAttribute>.

 **GUID**
 A unique GUID that identifies the assembly. When you create a project, Visual Studio generates a GUID for the assembly. Corresponds to <xref:System.Guid>.

 **Neutral Language**
 Specifies which culture the assembly supports. Corresponds to <xref:System.Resources.NeutralResourcesLanguageAttribute>. The default is **(None)**.

 **Make assembly COM-Visible**
 Specifies whether types in the assembly will be available to COM. Corresponds to <xref:System.Runtime.InteropServices.ComVisibleAttribute>.

## See Also
 [Application Page, Project Designer (Visual Basic)](../../ide/reference/application-page-project-designer-visual-basic.md)
 [Attributes](https://msdn.microsoft.com/library/ae334cee-d96c-4243-a5e3-06dd7fcaf205)

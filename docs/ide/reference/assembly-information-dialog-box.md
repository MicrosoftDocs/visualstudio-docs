---
title: "Assembly Information Dialog Box | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vb.ProjectPropertiesAssemblyInfo"
helpviewer_keywords: 
  - "Assembly Information dialog box"
ms.assetid: 8f1f6449-e03d-4a5b-9076-d3b1f84ada48
caps.latest.revision: 13
author: "kempb"
ms.author: "kempb"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Assembly Information Dialog Box
The **Assembly Information** dialog box is used to specify the values of the [!INCLUDE[dnprdnshort](../../code-quality/includes/dnprdnshort_md.md)] global assembly attributes, which are stored in the AssemblyInfo file created automatically with your project. In **Solution Explorer**, the file is located in the **My Project** node in [!INCLUDE[vbprvb](../../code-quality/includes/vbprvb_md.md)] (click **Show All files** to view it); it is located under **Properties** in [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)]. For more information about assembly attributes, see [Attributes](../Topic/Attributes%20\(C%23%20and%20Visual%20Basic\).md).  
  
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
 [Attributes](../Topic/Attributes%20\(C%23%20and%20Visual%20Basic\).md)
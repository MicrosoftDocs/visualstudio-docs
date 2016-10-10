---
title: "Assembly Information Dialog Box"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8f1f6449-e03d-4a5b-9076-d3b1f84ada48
caps.latest.revision: 13
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Assembly Information Dialog Box
The **Assembly Information** dialog box is used to specify the values of the .NET Framework global assembly attributes, which are stored in the AssemblyInfo file created automatically with your project. In **Solution Explorer**, the file is located in the **My Project** node in Visual Basic (click **Show All files** to view it); it is located under **Properties** in Visual C#. For more information about assembly attributes, see [Attributes](../Topic/Attributes%20\(C%23%20and%20Visual%20Basic\).md).  
  
 To access this dialog box, select a project node in **Solution Explorer**, and then, on the **Project** menu, click **Properties**. When the **Project Designer** appears, click the **Application** tab. On the **Application** page, click the **Assembly Information** button.  
  
## UIElement List  
 **Title**  
 Specifies a title for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyTitleAttribute?qualifyHint=False>.  
  
 **Description**  
 Specifies an optional description for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyDescriptionAttribute?qualifyHint=False>.  
  
 **Company**  
 Specifies a company name for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyCompanyAttribute?qualifyHint=False>.  
  
 **Product**  
 Specifies a product name for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyProductAttribute?qualifyHint=False>.  
  
 **Copyright**  
 Specifies a copyright notice for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyCopyrightAttribute?qualifyHint=False>.  
  
 **Trademark**  
 Specifies a trademark for the assembly manifest. Corresponds to <xref:System.Reflection.AssemblyTrademarkAttribute?qualifyHint=False>.  
  
 **Assembly Version**  
 Specifies the version of the assembly. Corresponds to <xref:System.Reflection.AssemblyVersionAttribute?qualifyHint=False>.  
  
 **File Version**  
 Specifies a version number that instructs the compiler to use a specific version for the Win32 file version resource. Corresponds to <xref:System.Reflection.AssemblyFileVersionAttribute?qualifyHint=False>.  
  
 **GUID**  
 A unique GUID that identifies the assembly. When you create a project, Visual Studio generates a GUID for the assembly. Corresponds to <xref:System.Guid?qualifyHint=False>.  
  
 **Neutral Language**  
 Specifies which culture the assembly supports. Corresponds to <xref:System.Resources.NeutralResourcesLanguageAttribute?qualifyHint=False>. The default is **(None)**.  
  
 **Make assembly COM-Visible**  
 Specifies whether types in the assembly will be available to COM. Corresponds to <xref:System.Runtime.InteropServices.ComVisibleAttribute?qualifyHint=False>.  
  
## See Also  
 [Application Page, Project Designer (Visual Basic)](../VS_IDE/Application-Page--Project-Designer--Visual-Basic-.md)   
 [Attributes](../Topic/Attributes%20\(C%23%20and%20Visual%20Basic\).md)
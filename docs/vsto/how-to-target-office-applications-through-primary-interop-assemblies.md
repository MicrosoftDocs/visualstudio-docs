---
title: "How to: Target Office Applications Through Primary Interop Assemblies | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "assemblies [Office development in Visual Studio], PIA references"
  - "primary interop assemblies [Office development in Visual Studio], adding references to"
  - "Office primary interop assemblies in Visual Studio, adding references to"
  - "Office applications [Office development in Visual Studio], automating"
  - "application development [Office development in Visual Studio], automating"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Target Office Applications Through Primary Interop Assemblies
  When you create a new Office project, Visual Studio automatically adds references to the Microsoft Office primary interop assemblies (PIAs) that are required to build your project. You must add references to other PIAs in the following scenarios:  
  
-   You want to use features of other Microsoft Office applications in your project. For example, you might want to use features of Microsoft Office Excel in a project for Microsoft Office Word.  
  
-   You want to automate Microsoft Office applications that do not have dedicated projects in Visual Studio, such as Microsoft Office Access.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]  
  
### To add a reference to a primary interop assembly  
  
1.  Open your Office project and select the project name in **Solution Explorer**.  
  
2.  On the **Project** menu, click **Add Reference**.  
  
3.  On the **Framework** tab, select the PIA you want in the **Component Name** list. For more information about the available Microsoft Office primary interop assemblies, see [Office Primary Interop Assemblies](../vsto/office-primary-interop-assemblies.md).  
  
     If the project targets the [!INCLUDE[net_v40_short](../sharepoint/includes/net-v40-short-md.md)] or later, the **Embed Interop Types** property for the assembly reference is set to **True** by default. By using this setting, your solution does not require the PIA on end-user computers. For more information, see [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md).  
  
    > [!NOTE]  
    >  In Office projects, always add references to Office PIAs by using the **.NET** tab of the **Add Reference** dialog rather than the **COM** tab. For more information, see [Office Primary Interop Assemblies](../vsto/office-primary-interop-assemblies.md).  
  
4.  Click **OK**.  
  
     The assembly name appears in the **References** folder of **Solution Explorer**.  
  
## See Also  
 [Office Primary Interop Assemblies](../vsto/office-primary-interop-assemblies.md)   
 [Writing Code in Office Solutions](../vsto/writing-code-in-office-solutions.md)   
 [Developing Office Solutions](../vsto/developing-office-solutions.md)   
 [How to: Install Office Primary Interop Assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md)  
  
  
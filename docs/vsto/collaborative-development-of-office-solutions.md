---
title: "Collaborative Development of Office Solutions | Microsoft Docs"
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
  - "Office applications [Office development in Visual Studio], collaborative development"
  - "Office development in Visual Studio, collaboration"
  - "source control [Office development in Visual Studio]"
  - "collaborative development [Office development in Visual Studio]"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# Collaborative Development of Office Solutions
  Multiple developers can work on an Office project in the same way that they collaborate on other Visual Studio projects. Visual Studio correctly locates the Microsoft Office installation on each computer, even if Office is installed in different locations. However, there are some important considerations to be aware of.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
## Debug Properties Are Not Shared  
 Debug properties are not shared among multiple users under source control. Visual Basic and Visual C# projects store the debugging properties in a user-specific file (*ProjectName*.vbproj.user or *ProjectName*.csproj.user), and this file is not under source control. If more than one person is debugging, each person must enter debug properties manually.  
  
 If the project is housed on a network share instead of in source control, some extra steps must be taken to enable the collaborating developers to open the solution and test the assembly.  
  
## Source Control Requires Checking Out All Files  
 If you use source control for your projects, you should check out all of the files under a code file in **Solution Explorer** (such as the ThisDocument, ThisWorkbook, or ThisAddIn code files) every time you change the code file, even the files that are hidden by default. If you check out only the top-level code file, your changes might be lost.  
  
 After you make your changes, check all of the files back in. For more information about hidden code files in projects, see [Office Projects in the Visual Studio Environment](../vsto/office-projects-in-the-visual-studio-environment.md).  
  
## Security for Informal Collaboration on a Network  
 For all document-level solutions that are in a network location (such as \\\\*Servername*\\*Sharename*), the fully qualified location must be added to the trusted folder list in the Microsoft Office application that you are working with. Select the option to include the subdirectories under the main folder, or specifically add debug and build folders to the trusted folder list. For more information about how to do this, see [Granting Trust to Documents](../vsto/granting-trust-to-documents.md).  
  
 The temporary certificates that are automatically generated at build time are not secured by passwords. The certificates contain the developer's login name and other personal information. If you deploy customizations that are signed by temporary certificates, others might be able to access this information.  
  
## See Also  
 [Securing Office Solutions](../vsto/securing-office-solutions.md)   
 [Designing and Creating Office Solutions](../vsto/designing-and-creating-office-solutions.md)   
 [Building Office Solutions](../vsto/building-office-solutions.md)  
  
  
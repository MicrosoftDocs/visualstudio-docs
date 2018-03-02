---
title: "How to: Target the Office Multilingual User Interface | Microsoft Docs"
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
  - "globalization [Office development in Visual Studio], user interface targeting"
  - "MUI [Office development in Visual Studio]"
  - "Office applications [Office development in Visual Studio], localization"
  - "Multilingual User Interface [Office development in Visual Studio]"
  - "localization [Office development in Visual Studio], user interface targeting"
  - "Office applications [Office development in Visual Studio], globalization"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Target the Office Multilingual User Interface
  The Multilingual User Interface (MUI) is a Microsoft Office feature that gives the end user the ability to change the language of the user interface (UI). For example, an end user working with an English UI can change the language of the UI to Spanish.  
  
 [!INCLUDE[appliesto_all](../vsto/includes/appliesto-all-md.md)]  
  
 If your application will be used by people who use multiple languages of Office, you can add code to automatically change the language of your UI strings to match the language being used by Office on the user's computer (if the user has the correct resources installed).  
  
### To check the current Office UI setting  
  
1.  Use the <xref:System.Threading.Thread.CurrentUICulture%2A> property of the current thread. Set the language of your UI strings to match the language being used by the version of Office currently running on the user's computer.  
  
     [!code-vb[Trin_VstcoreCreatingExcel#10](../vsto/codesnippet/VisualBasic/Trin_VstcoreCreatingExcelVB/Sheet1.vb#10)]
     [!code-csharp[Trin_VstcoreCreatingExcel#10](../vsto/codesnippet/CSharp/Trin_VstcoreCreatingExcelCS/Sheet1.cs#10)]  
  
## See Also  
 [How to: Target Office Applications Through Primary Interop Assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md)   
 [Late Binding in Office Solutions](../vsto/late-binding-in-office-solutions.md)  
  
  
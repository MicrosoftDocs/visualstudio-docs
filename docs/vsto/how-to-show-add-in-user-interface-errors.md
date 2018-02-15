---
title: "How to: Show Add-in User Interface Errors | Microsoft Docs"
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
  - "add-ins [Office development in Visual Studio], user interface errors"
  - "errors [Office development in Visual Studio], user interface errors"
  - "user interfaces [Office development in Visual Studio], errors"
  - "application-level add-ins [Office development in Visual Studio], user interface errors"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Show Add-in User Interface Errors
  By default, if an VSTO Add-in attempts to manipulate the Microsoft Office user interface (UI) and fails, no error message is displayed. However, you can configure Microsoft Office applications to display messages for errors that relate to the UI. You can use these messages to help determine why a custom Ribbon does not appear, or why a Ribbon appears but no controls appear.  
  
 [!INCLUDE[appliesto_ribbon](../vsto/includes/appliesto-ribbon-md.md)]  
  
### To show VSTO Add-in user interface errors  
  
1.  Start the application.  
  
2.  Click the **File** tab.  
  
3.  Click **Options**.  
  
4.  In the categories pane, click **Advanced**.  
  
5.  In the details pane, select **Show VSTO Add-in user interface errors**, and then click **OK**.  
  
    > [!NOTE]  
    >  For Outlook, the **Show VSTO Add-in user interface errors** checkbox is located in the **Developer** section of the details pane. For other applications, the checkbox is located in the **General** section of the details pane.  
  
## See Also  
 [Office UI Customization](../vsto/office-ui-customization.md)   
 [Creating Outlook Form Regions](../vsto/creating-outlook-form-regions.md)   
 [Ribbon Overview](../vsto/ribbon-overview.md)   
 [Actions Pane Overview](../vsto/actions-pane-overview.md)  
  
  
---
title: "How to: Add a Creator Method | Microsoft Docs"
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
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "BDC [SharePoint development in Visual Studio], Creator"
  - "BDC [SharePoint development in Visual Studio], adding entity instances"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], adding entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], adding entity instances"
  - "BDC [SharePoint development in Visual Studio], adding entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Creator"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add a Creator Method
  A Creator method adds new data to the data source of an entity. The Business Data Connectivity (BDC) service calls this method when users choose the **New Item** button on the Ribbon of a list that is based on the model. For more information, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).  
  
### To add a Creator method  
  
1.  On the BDC designer, choose an entity.  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The **BDC Method Details** window opens. For more information about that window, see [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md).  
  
3.  In the **Add a Method** list, choose **Create Creator Method**.  
  
     Visual Studio adds the following elements to the model, and these elements appear in the **BDC Method Details** window.  
  
    -   A method named **Create**.  
  
    -   An input parameter for the method.  
  
    -   A return parameter for the method.  
  
    -   Type descriptors for the parameters.  
  
    -   A method instance for the method.  
  
     For more information, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).  
  
4.  In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.  
  
     The entity service code file opens in the Code Editor. For more information about the entity service code file, see [Creating a Business Data Connectivity Model](../sharepoint/creating-a-business-data-connectivity-model.md).  
  
5.  Add code to the Creator method that adds data to the data source. The following example adds a contact to the AdventureWorks sample database for SQL Server.  
  
    > [!NOTE]  
    >  Replace the value of the `ServerName` field with the name of your server.  
  
     [!code-csharp[SP_BDC#4](../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs#4)]
     [!code-vb[SP_BDC#4](../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb#4)]  
  
## See Also  
 [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md)   
 [How to: Add a Finder Method](../sharepoint/how-to-add-a-finder-method.md)   
 [How to: Add a Specific Finder Method](../sharepoint/how-to-add-a-specific-finder-method.md)   
 [How to: Add a Deleter Method](../sharepoint/how-to-add-a-deleter-method.md)   
 [How to: Add an Updater Method](../sharepoint/how-to-add-an-updater-method.md)   
 [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md)   
 [How to: Add a Parameter to a Method](../sharepoint/how-to-add-a-parameter-to-a-method.md)   
 [How to: Define a Method Instance](../sharepoint/how-to-define-a-method-instance.md)  
  
  
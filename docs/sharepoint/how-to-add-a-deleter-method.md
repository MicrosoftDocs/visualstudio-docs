---
title: "How to: Add a Deleter Method | Microsoft Docs"
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
  - "BDC [SharePoint development in Visual Studio], deleting data"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Deleter"
  - "BDC [SharePoint development in Visual Studio], Deleter"
  - "BDC [SharePoint development in Visual Studio], removing data"
  - "BDC [SharePoint development in Visual Studio], deleting entity instances"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], deleting entity instances"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], deleting data"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], removing data"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add a Deleter Method
  You can enable an end user to delete a data record from an external list on a SharePoint site by adding a *Deleter* method to the model. For more information, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).  
  
### To create a Deleter method  
  
1.  On the BDC designer, choose an entity.  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The **BDC Method Details** window opens. For more information about this window, see [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md).  
  
3.  In the **Add a Method** list, choose **Create a Deleter Method**.  
  
     Visual Studio adds the following elements to the model. These elements appear in the **BDC Method Details** window.  
  
    -   A method named **Delete**.  
  
    -   An input parameter for the method.  
  
    -   A type descriptor for the parameter.  
  
    -   A method instance for the method.  
  
     For more information, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).  
  
4.  In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.  
  
     The entity service code file opens in the Code Editor. For more information about the entity service code file, see [Creating a Business Data Connectivity Model](../sharepoint/creating-a-business-data-connectivity-model.md).  
  
5.  Add code to the Deleter method to delete a record. The following example deletes a line item from a sales order by using the AdventureWorks sample database for SQL Server.  
  
    > [!NOTE]  
    >  The method in this example uses two input parameters.  
  
    > [!NOTE]  
    >  Replace the value of the `ServerName` field with the name of your server.  
  
     [!code-csharp[SP_BDC#6](../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/salesorderdetailservice.cs#6)]
     [!code-vb[SP_BDC#6](../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/salesorderdetailservice.vb#6)]  
  
## See Also  
 [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md)   
 [How to: Add a Finder Method](../sharepoint/how-to-add-a-finder-method.md)   
 [How to: Add a Specific Finder Method](../sharepoint/how-to-add-a-specific-finder-method.md)   
 [How to: Add a Creator Method](../sharepoint/how-to-add-a-creator-method.md)   
 [How to: Add an Updater Method](../sharepoint/how-to-add-an-updater-method.md)   
 [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md)   
 [How to: Add a Parameter to a Method](../sharepoint/how-to-add-a-parameter-to-a-method.md)   
 [How to: Define a Method Instance](../sharepoint/how-to-define-a-method-instance.md)  
  
  
---
title: "How to: Add a Specific Finder Method | Microsoft Docs"
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
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Specific Finder"
  - "BDC [SharePoint development in Visual Studio], return an entity"
  - "BDC [SharePoint development in Visual Studio], get an entity"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], return an entity"
  - "BDC [SharePoint development in Visual Studio], Specific Finder"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], get an entity"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add a Specific Finder Method
  You can return a single entity instance by creating a *Specific Finder* method. The Business Data Connectivity (BDC) service executes the Specific Finder method when a user chooses an entity in a business data web part or external list. For more information, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).  
  
### To create a Specific Finder method  
  
1.  On the BDC designer, choose an entity.  
  
     For information about how to add an entity to the BDC designer in Visual Studio, see [How to: Add an Entity to a Model](../sharepoint/how-to-add-an-entity-to-a-model.md).  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The **BDC Method Details** window opens. For more information about that window, see [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md).  
  
3.  In the **Add a Method** list, choose **Create Specific Finder Method**.  
  
     Visual Studio adds the following elements to the model. These elements appear in the **BDC Method Details** window.  
  
    -   A method.  
  
    -   An input parameter for the method.  
  
    -   A return parameter for the method.  
  
    -   A type descriptor for each parameter.  
  
    -   A method instance for the method.  
  
     For more information, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).  
  
4.  Open the Visual Studio **Properties** window.  
  
5.  Configure the type descriptor of the return parameter as an entity type descriptor. For information about how to create an entity type descriptor, see [How to: Define the Type Descriptor of a Parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md).  
  
    > [!NOTE]  
    >  You don't have to perform this step if you have added a Finder method to the entity. Visual Studio uses the type descriptor that you defined in the Finder method.  
  
    > [!NOTE]  
    >  If the identifier field of the entity type represents a field in a database table that's automatically generated, set the **Read-only** property of the identifier field to **True**.  
  
6.  In the **Method Details** window, choose the method instance of the method.  
  
7.  In the **Properties Window**, set the **Return Parameter Name** property to the name of the return parameter of the method. For more information about method instance properties, see [MethodInstance](http://go.microsoft.com/fwlink/?LinkID=169282).  
  
8.  In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.  
  
     The entity service code file opens in the Code Editor. For more information about the entity service code file, see [Creating a Business Data Connectivity Model](../sharepoint/creating-a-business-data-connectivity-model.md).  
  
9. Add code to the Specific Finder method. This code performs the following tasks:  
  
    -   Retrieves a record from a data source.  
  
    -   Returns an entity to the BDC service.  
  
     The following example returns a contact from the AdventureWorks sample database for SQL Server.  
  
    > [!NOTE]  
    >  Replace the value of the `ServerName` field with the name of your server.  
  
     [!code-csharp[SP_BDC#3](../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs#3)]
     [!code-vb[SP_BDC#3](../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb#3)]  
  
## See Also  
 [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md)   
 [How to: Add a Finder Method](../sharepoint/how-to-add-a-finder-method.md)   
 [How to: Add a Creator Method](../sharepoint/how-to-add-a-creator-method.md)   
 [How to: Add a Deleter Method](../sharepoint/how-to-add-a-deleter-method.md)   
 [How to: Add an Updater Method](../sharepoint/how-to-add-an-updater-method.md)   
 [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md)   
 [How to: Add a Parameter to a Method](../sharepoint/how-to-add-a-parameter-to-a-method.md)   
 [How to: Define a Method Instance](../sharepoint/how-to-define-a-method-instance.md)  
  
  
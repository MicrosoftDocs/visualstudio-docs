---
title: "How to: Create an Association between Entities | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "AssociationGroupTool"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "BDC [SharePoint development in Visual Studio], create an assocation"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], associations between entities"
  - "BDC [SharePoint development in Visual Studio], associations between entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], create an assocation"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], associate external content types"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], relate entities"
  - "BDC [SharePoint development in Visual Studio], relate entities"
  - "BDC [SharePoint development in Visual Studio], associate external content types"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Create an Association between Entities
  You can define relationships between entities in your Business Data Connectivity (BDC) model by creating associations. Visual Studio generates methods that provide consumers of the model with information about each association. These methods can be consumed by SharePoint web parts, lists, or custom applications to display data relationships in a user interface (UI).  
  
 You can create two types of associations in the BDC designer: foreign key-based associations and foreign keyless associations. For more information, see [Creating an Association Between Entities](../sharepoint/creating-an-association-between-entities.md).  
  
### To create an association between entities  
  
1.  On the **BusinessDataConnectivity** tab of the **Toolbox**, choose the **Association** item.  
  
2.  On the BDC Designer, choose the source entity, and then choose the destination entity.  
  
     The **Association Editor** appears.  
  
3.  If you want to create a foreign key-based association, select the **Is Foreign Key Association** check box.  
  
    1.  In the **Source ID** column of the **Identifier Mapping** table, choose the identifier next to each matching type descriptor that appears in the **Field** column.  
  
         For example, In the **Source ID** column, select `ContactID` next to the `ReadList.salesOrderList.SalesOrderList.SalesOrder.ContactID` type descriptor and the `ReadItem.salesOrder.SalesOrder.ContactID` type descriptor.  
  
4.  If you want to create a foreign keyless association, clear the **Is Foreign Key Association** check box.  
  
5.  Choose the **OK** button.  
  
6.  On the BDC Designer, a line that represents the association appears between the source entity and the destination entity.  
  
     Visual Studio adds an Association Navigator method to the service class of the destination entity and the service class of the source entity. For more information about Association Navigation methods, see [Supported Operations](http://go.microsoft.com/fwlink/?LinkId=169286).  
  
7.  In the Association Navigator method of the source entity, add code that returns a collection of destination entities.  
  
8.  In the Association Navigator method of the destination entity, add code that returns the related source entity.  
  
     For examples of Association Navigator methods, see [Creating an Association Between Entities](../sharepoint/creating-an-association-between-entities.md).  
  
## See Also  
 [Creating an Association Between Entities](../sharepoint/creating-an-association-between-entities.md)   
 [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md)   
 [How to: Add a Finder Method](../sharepoint/how-to-add-a-finder-method.md)   
 [How to: Add a Specific Finder Method](../sharepoint/how-to-add-a-specific-finder-method.md)   
 [How to: Add a Creator Method](../sharepoint/how-to-add-a-creator-method.md)   
 [How to: Add a Deleter Method](../sharepoint/how-to-add-a-deleter-method.md)   
 [How to: Add an Updater Method](../sharepoint/how-to-add-an-updater-method.md)   
 [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md)   
 [How to: Add a Parameter to a Method](../sharepoint/how-to-add-a-parameter-to-a-method.md)   
 [How to: Define a Method Instance](../sharepoint/how-to-define-a-method-instance.md)   
 [How to: Define the Type Descriptor of a Parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md)   
 [Walkthrough: Creating an External List in SharePoint by Using Business Data](../sharepoint/walkthrough-creating-an-external-list-in-sharepoint-by-using-business-data.md)  
  
  
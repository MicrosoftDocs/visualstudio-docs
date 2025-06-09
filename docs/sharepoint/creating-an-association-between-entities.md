---
title: "About Association Between Entities"
description: Create an association between entities in your Business Data Connectivity (BDC) model. Learn about association methods and types of associations.
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VS.SharePointTools.BDC.Association_Dialog"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "BDC [SharePoint development in Visual Studio], create an association"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], associations between entities"
  - "BDC [SharePoint development in Visual Studio], associations between entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], create an association"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], associate external content types"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], relate entities"
  - "BDC [SharePoint development in Visual Studio], relate entities"
  - "BDC [SharePoint development in Visual Studio], associate external content types"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Associations between entities

  You can define relationships between entities in your Business Data Connectivity (BDC) model by creating associations. Visual Studio generates methods that provide consumers of the model with information about each association. These methods can be consumed by SharePoint web parts, lists, or custom applications to display data relationships in a user interface (UI).

## Create an association
 Create an association by choosing the **Association** control in the Visual Studio **Toolbox**, choosing the first entity (called the source entity), and then choosing the second entity (called the destination entity). You can define the details of the association in the **Association Editor**. For more information, see [How to: Create an association between entities](../sharepoint/how-to-create-an-association-between-entities.md).

## Association methods
 Applications such as SharePoint business data web parts consume associations by calling methods in the service class of an entity. You can add methods to the service class of an entity by selecting them in the **Association Editor**.

 By default, the **Association Editor** adds an Association Navigation method to the source and destination entities. An Association Navigation method in the source entity enables consumers to retrieve a list of destination entities. An Association Navigation method in the destination entity enables consumers to retrieve the source entity that relates to a destination entity.

 You must add the code to each of these methods to return the appropriate information. You can also add other types of methods to support more advanced scenarios. For more information about each of these methods, see [Supported Operations](/previous-versions/office/developer/sharepoint-2010/ee557363(v=office.14)).

## Types of associations
 You can create two types of associations in the BDC designer: foreign key-based associations and foreign keyless associations.

### Foreign key-based association
 You can create a foreign key-based association by relating an identifier in the source entity to type descriptors defined in the destination entity. This relationship enables consumers of the model to provide an enhanced UI for their users. For example, a form in Outlook that enables a user to create a sales order that can display customers in a drop-down list; or a list of sales orders in SharePoint that enables users to open a profile page for a customer.

 To create a foreign key-based association, relate identifiers and type descriptors that share the same name and type. For example, you might create a foreign key-based association between a `Contact` entity and a `SalesOrder` entity. The `SalesOrder` entity returns a `ContactID` type descriptor as part of the return parameter of Finder or Specific Finder methods. Both type descriptors appear in the **Association Editor**. To create a foreign key-based relationship between the `Contact` entity and `SalesOrder` entity, choose the `ContactID` identifier next to each of these fields.

 Add code to the Association Navigator method of the source entity that returns a collection of destination entities. The following example returns the sales orders for a contact.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs" id="Snippet7":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb" id="Snippet7":::
 ---

 Add code to the Association Navigator method of the destination entity that returns a source entity. The following example returns the contact that is related to the sales order.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/salesorderservice.cs" id="Snippet8":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/salesorderservice.vb" id="Snippet8":::
 ---

### Foreign keyless association
 You can create an association without mapping identifiers to field type descriptors. Create this kind of association when the source entity does not have a direct relationship with the destination entity. For example, a `SalesOrderDetail` table does not have a foreign key that maps to a primary key in a `Contact` table.

 If you want to display information in the `SalesOrderDetail` table that relates to a `Contact`, you can create a foreign keyless association between the `Contact` entity and `SalesOrderDetail` entity.

 In the Association Navigation method of the `Contact` entity, return the `SalesOrderDetail` entities by joining tables, or by calling a stored procedure.

 The following example returns details of all sales orders by joining tables.

 ### [C#](#tab/csharp)
 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs" id="Snippet9":::

 ### [VB](#tab/vb)
 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb" id="Snippet9":::
 ---

 In the Association Navigation method of the `SalesOrderDetail` entity, return the related `Contact`. The following example demonstrates this.
                                                                            
 ### [C#](#tab/csharp)                                                                            
 :::code language="csharp" source="../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/salesorderdetailservice.cs" id="Snippet10":::
                                                                            
 ### [VB](#tab/vb)                                                                            
 :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/salesorderdetailservice.vb" id="Snippet10":::                                                                            
 ---

## Related content
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
- [How to: Create an association between entities](../sharepoint/how-to-create-an-association-between-entities.md)

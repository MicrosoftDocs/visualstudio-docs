---
title: "Create an Association between Entities"
description: Define relationships between entities in your Business Data Connectivity (BDC) model by creating associations in Visual Studio.
ms.date: "02/02/2017"
ms.topic: how-to
f1_keywords:
  - "AssociationGroupTool"
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
# Create an association between entities

  You can define relationships between entities in your Business Data Connectivity (BDC) model by creating associations. Visual Studio generates methods that provide consumers of the model with information about each association. These methods can be consumed by SharePoint web parts, lists, or custom applications to display data relationships in a user interface (UI).

 You can create two types of associations in the BDC designer: foreign key-based associations and foreign keyless associations. For more information, see [Create an association between entities](../sharepoint/creating-an-association-between-entities.md).

### To create an association between entities

1. On the **BusinessDataConnectivity** tab of the **Toolbox**, choose the **Association** item.

2. On the BDC Designer, choose the source entity, and then choose the destination entity.

     The **Association Editor** appears.

3. If you want to create a foreign key-based association, select the **Is Foreign Key Association** check box.

    1. In the **Source ID** column of the **Identifier Mapping** table, choose the identifier next to each matching type descriptor that appears in the **Field** column.

         For example, In the **Source ID** column, select `ContactID` next to the `ReadList.salesOrderList.SalesOrderList.SalesOrder.ContactID` type descriptor and the `ReadItem.salesOrder.SalesOrder.ContactID` type descriptor.

4. If you want to create a foreign keyless association, clear the **Is Foreign Key Association** check box.

5. Choose the **OK** button.

6. On the BDC Designer, a line that represents the association appears between the source entity and the destination entity.

     Visual Studio adds an Association Navigator method to the service class of the destination entity and the service class of the source entity. For more information about Association Navigation methods, see [Supported Operations](/previous-versions/office/developer/sharepoint-2010/ee557363(v=office.14)).

7. In the Association Navigator method of the source entity, add code that returns a collection of destination entities.

8. In the Association Navigator method of the destination entity, add code that returns the related source entity.

     For examples of Association Navigator methods, see [Create an association between entities](../sharepoint/creating-an-association-between-entities.md).

## Related content
- [Create an association between entities](../sharepoint/creating-an-association-between-entities.md)
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
- [How to: Add a Finder method](../sharepoint/how-to-add-a-finder-method.md)
- [How to: Add a specific Finder method](../sharepoint/how-to-add-a-specific-finder-method.md)
- [How to: Add a Creator method](../sharepoint/how-to-add-a-creator-method.md)
- [How to: Add a Deleter method](../sharepoint/how-to-add-a-deleter-method.md)
- [How to: Add an Updater method](../sharepoint/how-to-add-an-updater-method.md)
- [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define a method instance](../sharepoint/how-to-define-a-method-instance.md)
- [How to: Define the type descriptor of a parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md)
- [Walkthrough: Create an external list in SharePoint by using business data](../sharepoint/walkthrough-creating-an-external-list-in-sharepoint-by-using-business-data.md)

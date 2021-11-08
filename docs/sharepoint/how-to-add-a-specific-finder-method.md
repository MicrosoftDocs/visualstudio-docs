---
title: "How to: Add a Specific Finder Method | Microsoft Docs"
description: Get an entity instance by adding a Finder method. The BDC service calls the method when a user picks an entity in a business data web part or external list.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Specific Finder"
  - "BDC [SharePoint development in Visual Studio], return an entity"
  - "BDC [SharePoint development in Visual Studio], get an entity"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], return an entity"
  - "BDC [SharePoint development in Visual Studio], Specific Finder"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], get an entity"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add a specific Finder method
  You can return a single entity instance by creating a *Specific Finder* method. The Business Data Connectivity (BDC) service executes the Specific Finder method when a user chooses an entity in a business data web part or external list. For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

### To create a specific Finder method

1. On the **BDC Designer**, choose an entity.

    For information about how to add an entity to the **BDC Designer** in Visual Studio, see [How to: Add an entity to a model](../sharepoint/how-to-add-an-entity-to-a-model.md).

2. On the menu bar, choose **View** > **Other Windows**, **BDC Method Details**.

    The **BDC Method Details** window opens. For more information about that window, see [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md).

3. In the **Add a Method** list, choose **Create Specific Finder Method**.

    Visual Studio adds the following elements to the model. These elements appear in the **BDC Method Details** window.

   - A method.

   - An input parameter for the method.

   - A return parameter for the method.

   - A type descriptor for each parameter.

   - A method instance for the method.

     For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

4. Open the Visual Studio **Properties** window.

5. Configure the type descriptor of the return parameter as an entity type descriptor. For information about how to create an entity type descriptor, see [How to: Define the type descriptor of a parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md).

   > [!NOTE]
   > You don't have to perform this step if you have added a Finder method to the entity. Visual Studio uses the type descriptor that you defined in the Finder method.

   > [!NOTE]
   > If the identifier field of the entity type represents a field in a database table that's automatically generated, set the **Read-only** property of the identifier field to **True**.

6. In the **Method Details** window, choose the method instance of the method.

7. In the **Properties Window**, set the **Return Parameter Name** property to the name of the return parameter of the method. For more information about method instance properties, see [MethodInstance](/previous-versions/office/developer/sharepoint-2010/ee556838(v=office.14)).

8. In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.

    The entity service code file opens in the Code Editor. For more information about the entity service code file, see [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md).

9. Add code to the Specific Finder method. This code performs the following tasks:

   - Retrieves a record from a data source.

   - Returns an entity to the BDC service.

     The following example returns a contact from the AdventureWorks sample database for SQL Server.

     > [!NOTE]
     > Replace the value of the `ServerName` field with the name of your server.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs" id="Snippet3":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb" id="Snippet3":::

## See also
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
- [How to: Add a Finder method](../sharepoint/how-to-add-a-finder-method.md)
- [How to: Add a Creator method](../sharepoint/how-to-add-a-creator-method.md)
- [How to: Add a Deleter method](../sharepoint/how-to-add-a-deleter-method.md)
- [How to: Add an Updater method](../sharepoint/how-to-add-an-updater-method.md)
- [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define a method instance](../sharepoint/how-to-define-a-method-instance.md)

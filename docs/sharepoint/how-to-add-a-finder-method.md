---
title: "How to: Add a Finder Method | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "BDC [SharePoint development in Visual Studio], get entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], return entities"
  - "BDC [SharePoint development in Visual Studio], return entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Finder method"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], get entities"
  - "BDC [SharePoint development in Visual Studio], Finder method"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add a Finder method
  To enable the Business Data Connectivity (BDC) service to display a list of entities in a web part or list, you must create a *Finder* method. A Finder method is a special method that returns a collection of entity instances. For more information, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).

### To create a Finder method

1. On the **BDC Designer**, choose an entity.

    For more information, see [How to: Add an entity to a model](../sharepoint/how-to-add-an-entity-to-a-model.md).

2. On the menu bar, choose **View** > **Other Windows** > **BDC Method Details**.

    The **BDC Method Details** window opens. For more information about the **BDC Method Details** window, see [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md).

3. In the **Add a Method** list, choose **Create Finder Method**.

    Visual Studio adds a method, a return parameter, and a type descriptor.

4. Configure the type descriptor as an entity collection type descriptor. For more information about how to create an entity collection type descriptor, see [How to: Define the type descriptor of a parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md).

   > [!NOTE]
   > You do not have to perform this step if you have added a Specific Finder method to the entity. Visual Studio uses the type descriptor that you defined in the Specific Finder method.

5. In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**. For more information about the service code file, see [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md).

6. Add code to the Finder method. This code performs the following tasks:

   - Retrieves data from a data source.

   - Returns a list of entities to the BDC service.

     The following example returns a collection of `Contact` entities by using data from the AdventureWorks sample database for SQL Server.

   > [!NOTE]
   > Replace the value of the `ServerName` field with the name of your server.

    [!code-csharp[SP_BDC#2](../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs#2)]
    [!code-vb[SP_BDC#2](../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb#2)]

## See also
- [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
- [How to: Add a specific Finder method](../sharepoint/how-to-add-a-specific-finder-method.md)
- [How to: Add a Creator method](../sharepoint/how-to-add-a-creator-method.md)
- [How to: Add a Deleter method](../sharepoint/how-to-add-a-deleter-method.md)
- [How to: Add an Updater method](../sharepoint/how-to-add-an-updater-method.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define a method instance](../sharepoint/how-to-define-a-method-instance.md)

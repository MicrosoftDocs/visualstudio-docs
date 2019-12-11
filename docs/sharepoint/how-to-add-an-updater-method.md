---
title: "How to: Add an Updater Method | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "BDC [SharePoint development in Visual Studio], updating data"
  - "BDC [SharePoint development in Visual Studio], Updater"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], updating data"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Updater"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], updating entity instances"
  - "BDC [SharePoint development in Visual Studio], updating entity instances"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add an Updater method
  You can enable users to update business data in a SharePoint external list by creating an *Updater* method. For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

### To create an Updater method

1. On the BDC designer, choose an entity.

2. On the menu bar, choose **View** > **Other Windows** > **BDC Method Details**.

    The BDC Method Details window opens. For more information about this window, see [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md).

3. In the **Add a Method** list, choose **Create Updater Method**.

    Visual Studio adds the following elements to the model. These elements appear in the BDC Method Details window.

   - A method that's named **Update**.

   - An input parameter for the method.

   - A type descriptor for the parameter. By default, Visual Studio uses the entity type descriptor that you defined for the Finder method (for example: Contact).

   - A method instance for the method.

     For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

   > [!NOTE]
   > If the identifier of the entity type represents a field in a database table that's not automatically generated, set the **Pre-Updater Field** property to **True**.

4. In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.

    The entity service code file opens in the **Code Editor**. For more information about that file, see [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md).

5. Add code to the Update method to update data. The following example updates information for a contact in the AdventureWorks sample database for SQL Server.

   > [!NOTE]
   > Replace the value of the `ServerName` field with the name of your server.

    [!code-csharp[SP_BDC#5](../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs#5)]
    [!code-vb[SP_BDC#5](../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb#5)]

## See also
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
- [How to: Add a Finder method](../sharepoint/how-to-add-a-finder-method.md)
- [How to: Add a specific Finder method](../sharepoint/how-to-add-a-specific-finder-method.md)
- [How to: Add a Creator method](../sharepoint/how-to-add-a-creator-method.md)
- [How to: Add an Updater method](../sharepoint/how-to-add-an-updater-method.md)
- [How to: Add a Deleter method](../sharepoint/how-to-add-a-deleter-method.md)
- [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define a method instance](../sharepoint/how-to-define-a-method-instance.md)

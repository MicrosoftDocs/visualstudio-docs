---
title: "How to: Add a Creator Method | Microsoft Docs"
description: Know how to add a Creator method, which adds new data to the data source of an entity in the Business Data Connectivity (BDC) service in SharePoint.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "BDC [SharePoint development in Visual Studio], Creator"
  - "BDC [SharePoint development in Visual Studio], adding entity instances"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], adding entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], adding entity instances"
  - "BDC [SharePoint development in Visual Studio], adding entities"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], Creator"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add a Creator method
  A Creator method adds new data to the data source of an entity. The Business Data Connectivity (BDC) service calls this method when users choose the **New Item** button on the **Ribbon** of a list that is based on the model. For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

### To add a Creator method

1. On the **BDC Designer**, choose an entity.

2. On the menu bar, choose **View** > **Other Windows** >**BDC Method Details**.

    The **BDC Method Details** window opens. For more information about that window, see [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md).

3. In the **Add a Method** list, choose **Create Creator Method**.

    Visual Studio adds the following elements to the model, and these elements appear in the **BDC Method Details** window.

   - A method named **Create**.

   - An input parameter for the method.

   - A return parameter for the method.

   - Type descriptors for the parameters.

   - A method instance for the method.

     For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

4. In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.

    The entity service code file opens in the Code Editor. For more information about the entity service code file, see [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md).

5. Add code to the Creator method that adds data to the data source. The following example adds a contact to the AdventureWorks sample database for SQL Server.

   > [!NOTE]
   > Replace the value of the `ServerName` field with the name of your server.

    :::code language="csharp" source="../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/contactservice.cs" id="Snippet4":::
    :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/contactservice.vb" id="Snippet4":::

## See also
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
- [How to: Add a Finder method](../sharepoint/how-to-add-a-finder-method.md)
- [How to: Add a specific Finder method](../sharepoint/how-to-add-a-specific-finder-method.md)
- [How to: Add a Deleter method](../sharepoint/how-to-add-a-deleter-method.md)
- [How to: Add an Updater method](../sharepoint/how-to-add-an-updater-method.md)
- [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define a method instance](../sharepoint/how-to-define-a-method-instance.md)

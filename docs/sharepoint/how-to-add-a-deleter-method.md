---
title: "How to: Add a Deleter Method | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
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
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Add a Deleter method
  You can enable an end user to delete a data record from an external list on a SharePoint site by adding a Deleter method to the model. For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

### To create a Deleter method

1. On the **BDC Designer**, choose an entity.

2. On the menu bar, choose **View** > **Other Windows** > **BDC Method Details**.

    The **BDC Method Details** window opens. For more information about this window, see [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md).

3. In the **Add a Method** list, choose **Create a Deleter Method**.

    Visual Studio adds the following elements to the model. These elements appear in the **BDC Method Details** window.

   - A method named **Delete**.

   - An input parameter for the method.

   - A type descriptor for the parameter.

   - A method instance for the method.

     For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

4. In **Solution Explorer**, open the shortcut menu of the service code file that was generated for the entity, and then choose **View Code**.

    The entity service code file opens in the Code Editor. For more information about the entity service code file, see [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md).

5. Add code to the Deleter method to delete a record. The following example deletes a line item from a sales order by using the AdventureWorks sample database for SQL Server.

   > [!NOTE]
   > The method in this example uses two input parameters.

   > [!NOTE]
   > Replace the value of the `ServerName` field with the name of your server.

    [!code-csharp[SP_BDC#6](../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/salesorderdetailservice.cs#6)]
    [!code-vb[SP_BDC#6](../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/salesorderdetailservice.vb#6)]

## See also
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
- [How to: Add a Finder method](../sharepoint/how-to-add-a-finder-method.md)
- [How to: Add a specific Finder method](../sharepoint/how-to-add-a-specific-finder-method.md)
- [How to: Add a Creator method](../sharepoint/how-to-add-a-creator-method.md)
- [How to: Add an Updater method](../sharepoint/how-to-add-an-updater-method.md)
- [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define a method instance](../sharepoint/how-to-define-a-method-instance.md)

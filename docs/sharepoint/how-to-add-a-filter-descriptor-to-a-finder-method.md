---
title: "How to: Add a Filter Descriptor to a Finder Method | Microsoft Docs"
description: Know how to add a filter descriptor to a Finder method using the BDC Method Details window in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], filter descriptors"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], add a filter"
  - "BDC [SharePoint development in Visual Studio], add a filter"
  - "BDC [SharePoint development in Visual Studio], filter descriptors"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Add a filter descriptor to a Finder method
  Filter descriptors enable consumers of the model to pass values to methods before they execute. For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

 One common scenario is that users in SharePoint want to retrieve instances of an external content type that match some criteria. You can support this scenario by adding a filter descriptor to a Finder method.

### To add a filter descriptor to a Finder method

1. In the **BDC Method Details** window, expand the node of a Finder method, expand the **Parameters** node, and then add an input parameter. For more information, see [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md).

2. In the **Method Details** window, choose the type descriptor of the parameter.

3. On the menu bar, choose **View** > **Properties Window**.

4. In the **Properties** window, set the **Type Name** property to a data type that is appropriate for the filter.

     For example, a filter might use an order date to limit the number of sales orders returned by the method. To support that filter, the **Type Name** property of the type descriptor must be set to **System.DateTime**.

5. In the **Method Details** window, expand the **Filter Descriptors** node.

6. In **Add a Filter Descriptor** list, choose **Create Filter Descriptor**.

     A new filter descriptor appears underneath the **Filter Descriptors** node.

7. On the menu bar, choose **View** > **Properties Window**.

8. In the **Properties** window, choose the **Type** property.

9. In the list that appears for the **Type** property, choose the filtering pattern that you want.

     For example, to create a filter that uses an order date to limit the number of sales orders returned in a Finder method, choose **Comparison**. A Comparison filter ensures that a finder method returns only instances that meet a specific condition. For more information about each filtering pattern, see [Types of Filters Supported by the BDC](/previous-versions/office/developer/sharepoint-2010/ee556392(v=office.14)).

10. In the **Properties** window, choose the **Associated Type Descriptors** property.

11. In the list that appears for the **Associated Type Descriptors** property, choose the type descriptor that you created earlier in this procedure. This relates the filter to the input parameter of the Finder method.

12. Add code to the Finder method that returns data. You can use the input parameter as a condition in a select query.

     The following example returns sales orders that have the specified order date.

    > [!NOTE]
    > Replace the value of the `ServerName` field with the name of your server.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/SP_BDC/bdcmodel1/salesorderservice.cs" id="Snippet11":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/sp_bdc/bdcmodel1/salesorderservice.vb" id="Snippet11":::

## See also
- [How to: Add a Finder method](../sharepoint/how-to-add-a-finder-method.md)
- [How to: Add a specific Finder method](../sharepoint/how-to-add-a-specific-finder-method.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define the type descriptor of a parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md)
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)
- [Integrating business data into SharePoint](../sharepoint/integrating-business-data-into-sharepoint.md)

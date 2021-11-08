---
title: "How to: Define a Method Instance | Microsoft Docs"
description: Understand how to define a method instance for a method in your business data connectivity (BDC) model.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method instance"
  - "BDC [SharePoint development in Visual Studio], method instance"
  - "BDC [SharePoint development in Visual Studio], method"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Define a method instance
  You must define at least one method instance for every method in your model.

 Add a method instance by using the **BDC Method Details** window. When you add the method instance, Visual Studio adds a `<MethodInstance>` element to the XML of the model file in your project. For more information about the attributes of a `<MethodInstance>` element, see [MethodInstance](/previous-versions/office/developer/sharepoint-2010/ee556838(v=office.14)).

### To define a method instance

1. In the **BDC Method Details** window, expand the node of a method, and then expand the **Instances** node.

2. In the **Add a Method Instance** list, choose **Create Finder Instance**.

     A new method instance appears beneath the **Instances** node.

3. On the menu bar, choose **View** > **Properties Window**.

4. In the **Properties** window, set the properties of the method instance. For more information about each property, see [MethodInstance](/previous-versions/office/developer/sharepoint-2010/ee556838(v=office.14)).

## See also
- [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md)
- [How to: Add an entity to a model](../sharepoint/how-to-add-an-entity-to-a-model.md)
- [How to: Add a parameter to a method](../sharepoint/how-to-add-a-parameter-to-a-method.md)
- [How to: Define the type descriptor of a parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md)
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)

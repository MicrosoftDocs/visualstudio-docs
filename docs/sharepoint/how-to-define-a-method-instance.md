---
title: "How to: Define a Method Instance | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method instance"
  - "BDC [SharePoint development in Visual Studio], method instance"
  - "BDC [SharePoint development in Visual Studio], method"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Define a Method Instance
  You must define at least one method instance for every method in your model.  
  
 Add a method instance by using the **BDC Method Details** window. When you add the method instance, Visual Studio adds a `<MethodInstance>` element to the XML of the model file in your project. For more information about the attributes of a `<MethodInstance>` element, see [MethodInstance](http://go.microsoft.com/fwlink/?LinkID=169282).  
  
### To define a method instance  
  
1.  In the **BDC Method Details** window, expand the node of a method, and then expand the **Instances** node.  
  
2.  In the **Add a Method Instance** list, choose **Create Finder Instance**.  
  
     A new method instance appears beneath the **Instances** node.  
  
3.  On the menu bar, choose **View**, choose **Properties Window**.  
  
4.  In the **Properties** window, set the properties of the method instance. For more information about each property, see [MethodInstance](http://go.microsoft.com/fwlink/?LinkID=169282).  
  
## See Also  
 [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md)   
 [How to: Add an Entity to a Model](../sharepoint/how-to-add-an-entity-to-a-model.md)   
 [How to: Add a Parameter to a Method](../sharepoint/how-to-add-a-parameter-to-a-method.md)   
 [How to: Define the Type Descriptor of a Parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md)   
 [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md)  
  
  
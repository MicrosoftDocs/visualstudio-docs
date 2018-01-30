---
title: "How to: Add a Parameter to a Method | Microsoft Docs"
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
  - "Business Data Connectivity service [SharePoint development in Visual Studio], adding a method to a parameter"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], parameter"
  - "BDC [SharePoint development in Visual Studio], adding a method to a parameter"
  - "BDC [SharePoint development in Visual Studio], parameter"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method parameters"
  - "BDC [SharePoint development in Visual Studio], method parameters"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Add a Parameter to a Method
  Use a parameter to pass information into the method or to return information from a method. All methods must have at least one parameter. For more information about how to design a parameter to support the type of method that you want to create, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).  
  
 When you add a parameter to a method, Visual Studio adds the `<Parameter>` element to the XML of the model file in your project. For more information about the attributes of a `<Parameter>` element, see [Parameter](http://go.microsoft.com/fwlink/?LinkId=169284).  
  
### To add a parameter to a method  
  
1.  Add a method to an entity.  
  
2.  On the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
     The **BDC Method Details** window opens. For more information, see [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md).  
  
3.  In the **BDC Method Details** window, expand the node of the method, and then expand the **Parameters** node.  
  
4.  In the **Add a Parameter** list, choose **Create Parameter**.  
  
     A new parameter appears beneath the **Parameters** node.  
  
5.  On the menu bar, choose **View**, **Properties Window**.  
  
6.  In the **Properties** window, set the **Name** property to any name that makes sense. For example, if the method will return customers, you might name the method **GetCustomers**.  
  
7.  In the **BDC Method Details** window, open the list that appears for the direction of the parameter, and then choose **In**, **InOut**, **Out**, or **Return**.  
  
     For more information about which direction to choose for the type method that you are creating, see [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md).  
  
8.  Modify the type descriptor of the parameter. For more information, see [How to: Define the Type Descriptor of a Parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md).  
  
## See Also  
 [BDC Model Design Tools Overview](../sharepoint/bdc-model-design-tools-overview.md)   
 [How to: Add an Entity to a Model](../sharepoint/how-to-add-an-entity-to-a-model.md)   
 [How to: Define the Type Descriptor of a Parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md)   
 [How to: Define a Method Instance](../sharepoint/how-to-define-a-method-instance.md)   
 [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md)  
  
  
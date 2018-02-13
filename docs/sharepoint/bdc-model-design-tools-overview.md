---
title: "BDC Model Design Tools Overview | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.SharePointTools.BDC.Method_Details"
  - "VS.SharePointTools.BDC.Explorer"
  - "VS.SharePointTools.BDC.Diagram"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "BDC [SharePoint development in Visual Studio], visual tools"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], visual tools"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], BDC Explorer"
  - "BDC [SharePoint development in Visual Studio], method details"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], designer"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], method details"
  - "BDC [SharePoint development in Visual Studio], BDC Explorer"
  - "BDC [SharePoint development in Visual Studio], designer"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# BDC Model Design Tools Overview
  You can design a Business Data Connectivity (BDC) model by using the BDC Designer, the **BDC Method Details** window, and the **BDC Explorer**.  
  
 The **BDC Explorer** enables you to browse the model, search the model, and define type descriptors.  
  
## BDC Designer  
 The BDC Designer enables you to define the entities in your model and to visually arrange their relationships with one another. Use the BDC Designer to accomplish the following tasks:  
  
-   Add entities to the model.  
  
-   Remove entities from the model.  
  
-   Define relationships between entities.  
  
 To open the BDC Designer, double-click the model file in your project, or open the shortcut menu for the model file and then choose **Open**. Add an entity to the model by dragging or copying an **Entity** from the **Toolbox** onto the designer. To create an association between two entities, choose the **Association** control in the **Toolbox**, choose the first entity, and then choose the second entity.  
  
## BDC Method Details Window  
 Use the **BDC Method Details** window to define the parameters, instances, and filter descriptors of a method.  
  
 You can quickly generate Finder, Specific Finder, Creator, Updater, and Deleter methods in the **BDC Method Details** window. When you generate these methods, Visual Studio adds metadata, such as parameters, instances, and type descriptors, to the method. You can modify this metadata to satisfy your specific scenario.  
  
 To open the **BDC Method Details** window, on the menu bar, choose **View**, **Other Windows**, **BDC Method Details**.  
  
 To view methods in the **BDC Method Details** window, choose the entity in the BDC Designer. The methods of the selected entity appear in the **BDC Method Details** window. If you do not choose an entity in the BDC Designer, the **BDC Method Details** window displays no information.  
  
 Expand or collapse nodes in the **BDC Method Details** window to define parameters, instances, and filter descriptors. Use the **BDC Explorer** to define type descriptors.  
  
## BDC Explorer  
 The **BDC Explorer** displays the elements that make up the model. To open the **BDC Explorer**, on the menu bar, choose **View**, **Other Windows**, **BDC Explorer**. To browse the model, expand nodes in the **BDC Explorer**. Each node represents an element in the XML of the model file.  
  
 As you choose nodes in the **BDC Explorer**, the properties of each node that you choose appear in the **Properties** window. Many of these properties correspond to attributes in the model file. You can search the model by using the search box at the top of the **BDC Explorer**.  
  
> [!NOTE]  
>  The **BDC Explorer** does not display identifiers, custom properties, localized strings, association groups, actions, filter descriptors, action control lists, and the default parameter values.  
  
### Defining Type Descriptors  
 Use the **BDC Explorer** to define type descriptors. The BDC Explorer enables you to define a type descriptor one time and then reuse that type descriptor elsewhere in your model. To accomplish this, copy a type descriptor and paste it onto any other parameter or type descriptor.  
  
> [!NOTE]  
>  Changes to an original type descriptor do not affect the copies of that type descriptor.  
  
 For more information, see [How to: Define the Type Descriptor of a Parameter](../sharepoint/how-to-define-the-type-descriptor-of-a-parameter.md).  
  
## See Also  
 [How to: Create a BDC Model](../sharepoint/how-to-create-a-bdc-model.md)   
 [How to: Add an Entity to a Model](../sharepoint/how-to-add-an-entity-to-a-model.md)   
 [How to: Add a Finder Method](../sharepoint/how-to-add-a-finder-method.md)   
 [How to: Add a Specific Finder Method](../sharepoint/how-to-add-a-specific-finder-method.md)   
 [How to: Add a Creator Method](../sharepoint/how-to-add-a-creator-method.md)   
 [How to: Add a Deleter Method](../sharepoint/how-to-add-a-deleter-method.md)   
 [How to: Add an Updater Method](../sharepoint/how-to-add-an-updater-method.md)   
 [Creating an Association Between Entities](../sharepoint/creating-an-association-between-entities.md)   
 [Walkthrough: Creating an External List in SharePoint by Using Business Data](../sharepoint/walkthrough-creating-an-external-list-in-sharepoint-by-using-business-data.md)   
 [Integrating Business Data into SharePoint](../sharepoint/integrating-business-data-into-sharepoint.md)   
 [Creating a Business Data Connectivity Model](../sharepoint/creating-a-business-data-connectivity-model.md)   
 [Designing a Business Data Connectivity Model](../sharepoint/designing-a-business-data-connectivity-model.md)  
  
  
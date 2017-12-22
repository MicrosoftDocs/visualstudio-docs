---
title: "How to: Visualize a Collection Association (Class Designer) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.classdesigner.collectionassociationline"
  - "vs.classdesigner.ShowAssociationException"
helpviewer_keywords: 
  - "collection associations"
  - "collections, collection associations"
  - "Class Designer [Visual Studio], collection associations"
ms.assetid: 54e39838-2fc9-4dc2-85b6-7e88a743108e
caps.latest.revision: 6
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# How to: Visualize a Collection Association (Class Designer)
Properties and fields that are collections of other types can be displayed on the class diagram as a collection association. Unlike a regular association, which displays a field or property as a line linking the owning class to the field's type, a collection association is displayed as a line linking the owning class to the collected type.  
  
### To create a collection association  
  
1.  In code, create a property or field whose type is itself a strongly-typed collection.  
  
2.  In the class diagram, expand the class so that properties and fields are shown.  
  
3.  In the class, right-click the field or property and choose **Show as Collection Association**.  
  
     The property or field is shown as an association line linking to the collected type.  
  
## See also
[How to: Create Associations Between Types](how-to-create-associations-between-types.md)   
[Designing Classes and Types](designing-classes-and-types.md)   
[Viewing Types and Relationships](viewing-types-and-relationships.md)
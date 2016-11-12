---
title: "Adding Extensions to DSL Definitions | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 07e133be-92ab-4936-a02b-45d2012bd0a6
caps.latest.revision: 6
author: "alancameronwills"
ms.author: "awills"
manager: "douge"
---
# Adding Extensions to DSL Definitions
DSL Definition extension allows you to create a package of extensions to a domain-specific language (DSL). The DSL extension, which is contained in a Visual Studio Integration Extension (VSIX), can be installed on a user's computer in the same manner as a DSL. The additional features can be dynamically enabled and disabled at run time. DSLs do not have to be explicitly designed for extension, and extensions can be designed later or by third parties without altering the extended DSL.  
  
 The additional features can include the following:  
  
-   Properties for model and presentation elements  
  
-   Decorators for shapes and connectors  
  
-   Classes, relationships, shapes and connectors  
  
-   Validation constraints  
  
-   Toolbox items and tabs  
  
 A user of an extended DSL can create and save a model that contains instances of the additional features, and these can be read by other users who have installed the appropriate extension. Users who have not installed the extension cannot use the additional features, but they can update and save a model without losing the additional features.  
  
 For sample code and more information about this feature, see the [Visual Studio Visualization and Modeling SDK](http://go.microsoft.com/fwlink/?LinkID=186128) Web site.  
  
## See Also  
 [Visual Studio Visualization and Modeling SDK](http://go.microsoft.com/fwlink/?LinkID=186128)
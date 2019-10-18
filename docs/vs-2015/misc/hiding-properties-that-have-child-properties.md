---
title: "Hiding Properties That Have Child Properties | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "properties [Visual Studio SDK], hiding"
  - "Properties window, hiding properties that have child properties"
ms.assetid: 6003607e-fc19-4bf9-a299-9f6adf8e92eb
caps.latest.revision: 13
manager: jillfra
---
# Hiding Properties That Have Child Properties
You would want to hide properties that have child properties:  
  
- If you have nested projects where the parent project programmatically controls some aspects of the child project.  
  
- If you use a control with a specialized designer and you do not want to give developers full access to all the properties of the control.  
  
- If you have scope ownership of an object and want to limit the view of properties.  
  
### To hide properties that have child properties  
  
1. Set the `pfDisplay` parameter in <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.DisplayChildProperties%2A> to `FALSE`.  
  
2. Set the `pfHide` parameter in <xref:Microsoft.VisualStudio.Shell.Interop.IVsPerPropertyBrowsing.HideProperty%2A> to `TRUE`.  
  
## See also  
 [Properties Display Grid](../extensibility/internals/properties-display-grid.md)
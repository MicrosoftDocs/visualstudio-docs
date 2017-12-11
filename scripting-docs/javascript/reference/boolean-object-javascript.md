---
title: "Boolean Object (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "boolean_JavaScriptKeyword"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "Boolean object"
  - "Boolean data type, Boolean object"
ms.assetid: d67748f2-7bf5-4889-8269-e777616cc5f0
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Boolean Object (JavaScript)
Creates a new Boolean value.  
  
## Syntax  
  
```  
  
boolObj = new Boolean([boolValue])  
```  
  
## Parameters  
 `boolObj`  
 Required. The variable name to which the `Boolean` object is assigned.  
  
 `boolValue`  
 Optional. The initial Boolean value for the new object. If `boolvalue` is omitted, or is `false`, 0, `null`, `NaN`, or an empty string, the initial value of the Boolean object is `false`. Otherwise, the initial value is `true`.  
  
## Remarks  
 The `Boolean` object is a wrapper for the Boolean data type. [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] implicitly uses the `Boolean` object whenever a Boolean data type is converted to a `Boolean` object.  
  
 You rarely instantiate the `Boolean` object explicitly.  
  
## Properties  
 The following table lists the properties of the `Boolean` object.  
  
|Property|Description|  
|--------------|-----------------|  
|[constructor Property](../../javascript/reference/constructor-property-boolean.md)|Specifies the function that creates a Boolean.|  
|[prototype Property](../../javascript/reference/prototype-property-boolean.md)|Returns a reference to the prototype for a Boolean.|  
  
<a name="js56jsobjarraymeth"></a>   
## Methods  
 The following table lists the methods of the `Boolean` object.  
  
|Method|Description|  
|------------|-----------------|  
|[toString Method](../../javascript/reference/tostring-method-boolean-1.md)|Returns a string representation of a Boolean.|  
|[valueOf Method](../../javascript/reference/valueof-method-boolean.md)|Gets a reference to the Boolean.|  
  
## Requirements  
 [!INCLUDE[jsv2](../../javascript/reference/includes/jsv2-md.md)]
---
title: "Compiler Error CS1514"
ms.custom: na
ms.date: 10/01/2016
ms.devlang: 
  - CSharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 61c25e0e-84b1-4b94-b790-ef1e4ff9fc4e
caps.latest.revision: 6
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Compiler Error CS1514
{ expected  
  
 The compiler expected an opening curly brace (`{`) that was not found.  
  
 The following sample generates CS1514:  
  
```  
// CS1514.cs  
namespace x  
// CS1514, no open curly brace  
```
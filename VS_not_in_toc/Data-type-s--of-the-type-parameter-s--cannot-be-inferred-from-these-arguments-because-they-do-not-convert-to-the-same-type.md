---
title: "Data type(s) of the type parameter(s) cannot be inferred from these arguments because they do not convert to the same type"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0aa809da-3b44-4d78-b3c5-0a148bdf7ce8
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
# Data type(s) of the type parameter(s) cannot be inferred from these arguments because they do not convert to the same type
Data type(s) of the type parameter(s) cannot be inferred from these arguments because they do not convert to the same type. Specifying the data type(s) explicitly might correct this error.  
  
 This error occurs when overload resolution has failed. It occurs as a subordinate message that states why a particular overload candidate has been eliminated. The error explains that the compiler cannot use type inference to find data types for the type parameters that are compatible with the arguments.  
  
> [!NOTE]
>  When specifying arguments is not an option (for example, for query operators in query expressions), the error message appears without the second sentence.  
  
 For more information and examples, see [Data type(s) of the type parameter(s) in method '<methodname\>' cannot be inferred from these arguments because they do not convert to the same type](../VS_not_in_toc/Data-type-s--of-the-type-parameter-s--in-method---methodname---cannot-be-inferred-from-these-arguments-because-they-do-not-convert-to-the-same-type.md).  
  
 **Error ID:** BC36659 and BC36656  
  
## See Also  
 [Relaxed Delegate Conversion](../Topic/Relaxed%20Delegate%20Conversion%20\(Visual%20Basic\).md)   
 [Generic Procedures in Visual Basic](../Topic/Generic%20Procedures%20in%20Visual%20Basic.md)   
 [Overload Resolution](../Topic/Overload%20Resolution%20\(Visual%20Basic\).md)
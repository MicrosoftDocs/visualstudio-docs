---
title: "Restrictions on String Lengths | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "source control plug-ins, restrictions on string lengths"
ms.assetid: 877173d2-ca27-43b3-b1f4-8379f7c5e268
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# Restrictions on String Lengths
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Source Control Plug-in API limits the lengths of strings used in various functions.  
  
## String Length Values  
  
|Constant|Value|  
|--------------|-----------|  
|`SCC_NAME_LEN`|31|  
|`SCC_AUXLABEL_LEN`|31|  
|`SCC_USER_LEN`|31|  
|`SCC_PRJPATH_LEN`|300|  
  
> [!NOTE]
> Length does not include the terminating `null`. Other constants with a "_SIZE" suffix instead of "_LEN" do include space for the terminating `null`.  
  
|Constant|Value|  
|--------------|-----------|  
|SCC_NAME_SIZE|32|  
|SCC_AUXLABEL_SIZE|32|  
|SCC_USER_SIZE|32|  
|SCC_PRJPATH_SIZE|301|  
  
## See Also  
 [Source Control Plug-ins](../extensibility/source-control-plug-ins.md)

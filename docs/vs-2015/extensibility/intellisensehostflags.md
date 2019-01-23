---
title: "IntelliSenseHostFlags | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
f1_keywords: 
  - "IntellisenseHostFlags"
helpviewer_keywords: 
  - "IntelliSense, IntellisenseHostFlags enumeration"
  - "IntellisenseHostFlags enumeration"
ms.assetid: 0930640b-eb84-48ef-a8f7-d4268f55c99c
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# IntelliSenseHostFlags
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies IntelliSense host flags.  
  
## Syntax  
  
```cpp#  
enum IntellisenseHostFlags  
{  
    IHF_READONLYCONTEXT      = 0x00000001  
    IHF_NOSEPARATESUBJECT    = 0x00000002  
    IHF_SINGLELINESUBJECT    = 0x00000004  
    IHF_FORCECOMMITTOCONTEXT = 0x00000008  
    IHF_OVERTYPE             = 0x00000010  
};  
```  
  
#### Parameters  
  
|Members|Description|  
|-------------|-----------------|  
|`IHF_READONLYCONTEXT`|Context buffer is read-only.|  
|`IHF_NOSEPARATESUBJECT`|No subject text. Context buffer contains IntelliSense-target (implies `!IHF_READONLYCONTEXT`).|  
|`IHF_SINGLELINESUBJECT`|Subject text is not multi-line-capable.|  
|`IHF_FORCECOMMITTOCONTEXT`|Same as `CanCommitIntoReadOnlyBuffer`.|  
|`IHF_OVERTYPE`|Editing (in subject or context) should be done in overtype mode.|  
  
## Requirements  
 SingleFileeditor.idl  
  
## See Also  
 <xref:Microsoft.VisualStudio.TextManager.Interop>

---
title: "IntelliSenseHostFlags | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IntellisenseHostFlags"
helpviewer_keywords: 
  - "IntelliSense, IntellisenseHostFlags enumeration"
  - "IntellisenseHostFlags enumeration"
ms.assetid: 0930640b-eb84-48ef-a8f7-d4268f55c99c
caps.latest.revision: 6
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IntelliSenseHostFlags
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
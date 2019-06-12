---
title: "MODULE_INFO | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "MODULE_INFO"
helpviewer_keywords: 
  - "MODULE_INFO structure"
ms.assetid: f2e06180-1ab3-4eb5-a428-7994cceb61b6
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# MODULE_INFO
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Describes a particular module (DLL, EXE, or assembly).  
  
## Syntax  
  
```cpp#  
typedef struct tagMODULE_INFO {   
   MODULE_INFO_FIELDS dwValidFields;  
   BSTR               m_bstrName;  
   BSTR               m_bstrUrl;  
   BSTR               m_bstrVersion;  
   BSTR               m_bstrDebugMessage;  
   UINT64             m_addrLoadAddress;  
   UINT64             m_addrPreferredLoadAddress;  
   DWORD              m_dwSize;  
   DWORD              m_dwLoadOrder;  
   FILETIME           m_TimeStamp;  
   BSTR               m_bstrUrlSymbolLocation;  
   MODULE_FLAGS       m_dwModuleFlags;  
} MODULE_INFO;  
```  
  
```csharp  
public struct MODULE_INFO {   
   public uint     dwValidFields;  
   public string   m_bstrName;  
   public string   m_bstrUrl;  
   public string   m_bstrVersion;  
   public string   m_bstrDebugMessage;  
   public ulong    m_addrLoadAddress;  
   public ulong    m_addrPreferredLoadAddress;  
   public uint     m_dwSize;  
   public uint     m_dwLoadOrder;  
   public FILETIME m_TimeStamp;  
   public string   m_bstrUrlSymbolLocation;  
   public uint     m_dwModuleFlags;  
};  
```  
  
## Members  
 dwValidFields  
 A combination of flags from the [MODULE_INFO_FIELDS](../../../extensibility/debugger/reference/module-info-fields.md) enumeration that specifies which fields are filled out.  
  
 m_bstrName  
 The module name.  
  
 m_bstrUrl  
 The module URL.  
  
 m_bstrVersion  
 The module version.  
  
 m_bstrDebugMessage  
 An optional message about the module, for example, "Symbols cannot be loaded."  
  
 m_addrLoadAddress  
 The module load address.  
  
 m_addrPreferredLoadAddress  
 The preferred load address of the module.  
  
 m_dwSize  
 The module size.  
  
 m_dwLoadOrder  
 The module load order.  
  
 m_TimeStamp  
 The time the symbol file was last modified.  
  
 m_bstrUrlSymbolLocation  
 The location of the symbol file (for example, ".\\") specified in the module. Used as a starting location to find symbols for a module.  
  
 m_dwModuleFlags  
 A combination of flags from the [MODULE_FLAGS](../../../extensibility/debugger/reference/module-flags.md) enumeration that describes the module.  
  
## Remarks  
 This structure is passed to the [GetInfo](../../../extensibility/debugger/reference/idebugmodule2-getinfo.md) method where it is filled in.  
  
 This structure corresponds to each module listed in the **Modules** window.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [MODULE_INFO_FIELDS](../../../extensibility/debugger/reference/module-info-fields.md)   
 [MODULE_FLAGS](../../../extensibility/debugger/reference/module-flags.md)   
 [GetInfo](../../../extensibility/debugger/reference/idebugmodule2-getinfo.md)

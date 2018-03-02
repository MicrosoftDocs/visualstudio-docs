---
title: "IManagedAddin::Load | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# IManagedAddin::Load
  Called when a managed VSTO Add-in is loaded.  
  
## Syntax  
  
```  
HRESULT Load([in] BSTR bstrManifestURL,   
             [in] IDispatch *pdispApplication);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*bstrManifestURL*|The full path of the manifest for the VSTO Add-in.|  
|*pdispApplication*|A pointer to an IDispatch that represents the host application that is loading the VSTO Add-in.|  
  
## Return Value  
 An HRESULT value that indicates whether the method completed successfully.  
  
## Remarks  
 A manifest is a file (typically, an XML file) that provides information that is used to help load the VSTO Add-in. For example, a manifest can specify the location of the VSTO Add-in assembly and the entry point class to instantiate when the VSTO Add-in is loaded.  
  
 The *bstrManifestURL* parameter contains the value of the `Manifest` entry under the HKEY_CURRENT_USER\Software\Microsoft\Office\\*\<application name>*\Addins\\*\<add-in ID>* registry key for the VSTO Add-in. For more information, see [IManagedAddin Interface](../vsto/imanagedaddin-interface.md).  
  
 Implement the [IManagedAddIn::Load](../vsto/imanagedaddin-load.md) method to perform tasks such as configuring the application domain and security policy for the VSTO Add-in that is being loaded.  
  
## See Also  
 [IManagedAddin Interface](../vsto/imanagedaddin-interface.md)   
 [IManagedAddin::Unload](../vsto/imanagedaddin-unload.md)  
  
  
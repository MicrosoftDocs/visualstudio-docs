---
title: "LocalizedDescription Element (VSIX Language Pack Schema) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
ms.assetid: 766a1732-bbaf-4875-b276-feb42169633a
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# LocalizedDescription Element (VSIX Language Pack Schema)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Required. Provides a localized description of the extension.  
  
## Syntax  
  
```  
<LocalizedDescription>Localized description of the extension</LocalizedDescription>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|None||  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None||  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[VSIX LanguagePack Element](../extensibility/vsixlanguagepack-element-vsix-language-pack-schema.md)|Required. Provides the root element for a VSIX language pack.|  
  
## Text Value  
 Required. A text description of the extension in the target language.  
  
## Element Information  
  
|                 |                                                           |
|-----------------|-----------------------------------------------------------|
|    Namespace    | http://schemas.microsoft.com/developer/vsx-schema-lp/2010 |
|   Schema Name   |                 VSIX Language Pack Schema                 |
| Validation File |                VSIXLanguagePackSchema.xsd                 |
|  Can be Empty   |                      Not applicable                       |
  
## See Also  
 [VSX Language Pack Schema Reference](../extensibility/vsx-language-pack-schema-reference.md)   
 [Localizing VSIX Packages](../extensibility/localizing-vsix-packages.md)   
 [VSIX Extension Schema 1.0 Reference](https://msdn.microsoft.com/76e410ec-b1fb-4652-ac98-4a4c52e09a2b)

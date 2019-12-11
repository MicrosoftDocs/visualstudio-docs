---
title: "License Element (VSIX Language Pack Schema) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
ms.assetid: 57dac3b7-0cdd-405c-9af5-30ed9ca45e53
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# License Element (VSIX Language Pack Schema)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Optional. The path of a localized version of the license file for the extension.  
  
## Syntax  
  
```  
<License>FilePath\license.txt</License>  
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
 The relative path of the localized license file to be displayed.  
  
## Remarks  
 If the `License` element is defined, then the text of the designated license file is displayed during setup and the user must accept the license to continue.  
  
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

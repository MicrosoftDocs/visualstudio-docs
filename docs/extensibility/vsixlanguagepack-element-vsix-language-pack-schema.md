---
title: "VSIXLanguagePack Element (VSIX Language Pack Schema) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 767f5c22-8b87-49ca-92aa-a7a3f026469f
caps.latest.revision: 8
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
# VSIXLanguagePack Element (VSIX Language Pack Schema)
Required. Provides the root element for a VSIX language pack. The VSIX language pack provides localized installation information for a VSIX package.  
  
## Syntax  
  
```  
<VSIXLanguagePack>  
  <LocalizedName>...</LocalizedName>  
  <LocalizedDescription>...</LocalizedDescription>  
  <MoreInfoURL>...</MoreInfoURL>  
  <License>...</License>  
</VSIXLanguagePack>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`xmlns`|The XML namespace in which the VSIX Language Pack schema is defined.|  
  
## xmlns Attribute  
  
|Value|Description|  
|-----------|-----------------|  
|`http://schemas.microsoft.com/developer/vsx-schema-lp/2010`|Required. The location of the file that defines the schema for language packs.|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[LocalizedName Element](../extensibility/localizedname-element-vsix-language-pack-schema.md)|Required. The localized name of the extension to be installed.|  
|[LocalizedDescription Element](../extensibility/localizeddescription-element-vsix-language-pack-schema.md)|Required. The localized description of the extension to be installed.|  
|[MoreInfoURL Element](../extensibility/moreinfourl-element-vsix-language-pack-schema.md)|Optional. A link to localized information about the extension.|  
|[License Element](../extensibility/license-element-vsix-language-pack-schema.md)|Optional. The path of a localized version of the license file for the extension.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None||  
  
## Element Information  
  
|||  
|-|-|  
|Namespace|http://schemas.microsoft.com/developer/vsx-schema-lp/2010|  
|Schema Name|VSIX Language Pack Schema|  
|Validation File|VSIXLanguagePackSchema.xsd|  
|Can be Empty|No|  
  
## See Also  
 [VSX Language Pack Schema Reference](../extensibility/vsx-language-pack-schema-reference.md)   
 [Localizing VSIX Packages](../extensibility/localizing-vsix-packages.md)   
 [VSIX Extension Schema 1.0 Reference](http://msdn.microsoft.com/en-us/76e410ec-b1fb-4652-ac98-4a4c52e09a2b)
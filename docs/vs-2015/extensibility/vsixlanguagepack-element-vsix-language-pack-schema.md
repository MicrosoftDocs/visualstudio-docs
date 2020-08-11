---
title: "VSIXLanguagePack Element (VSIX Language Pack Schema) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
ms.assetid: 767f5c22-8b87-49ca-92aa-a7a3f026469f
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# VSIXLanguagePack Element (VSIX Language Pack Schema)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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

:::row:::
    :::column:::
        Namespace
    :::column-end:::
    :::column:::
        `http://schemas.microsoft.com/developer/vsx-schema-lp/2010`
    :::column-end:::
:::row-end:::
:::row:::
    :::column:::
        Schema Name
    :::column-end:::
    :::column:::
        VSIX Language Pack Schema
    :::column-end:::
:::row-end:::
:::row:::
    :::column:::
        Validation File
    :::column-end:::
    :::column:::
        VSIXLanguagePackSchema.xsd
    :::column-end:::
:::row-end:::
:::row:::
    :::column:::
        Can be Empty
    :::column-end:::
    :::column:::
        No
    :::column-end:::
:::row-end:::
  
## See Also  
 [VSX Language Pack Schema Reference](../extensibility/vsx-language-pack-schema-reference.md)
 [Localizing VSIX Packages](../extensibility/localizing-vsix-packages.md)
 [VSIX Extension Schema 1.0 Reference](/previous-versions/dd393700(v=vs.110))

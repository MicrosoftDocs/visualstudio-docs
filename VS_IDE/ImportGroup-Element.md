---
title: "ImportGroup Element"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: dac3fa2d-6678-4017-af35-93686f53f302
caps.latest.revision: 4
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# ImportGroup Element
Contains a collection of `Import` elements that are grouped under an optional condition. For more information, see [Import Element (MSBuild)](../VS_IDE/Import-Element--MSBuild-.md).  
  
 <Project\>  
 <ImportGroup\>  
  
## Syntax  
  
```  
<ImportGroup Condition="'String A' == 'String B'">  
    <Import ... />  
    <Import ... />  
</ImportGroup>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Condition`|Optional attribute.<br /><br /> The condition to be evaluated. For more information, see [Conditions](../VS_IDE/MSBuild-Conditions.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Import](../VS_IDE/Import-Element--MSBuild-.md)|Imports the contents of one project file into another project file.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Project](../VS_IDE/Project-Element--MSBuild-.md)|Required root element of an MSBuild project file.|  
  
## Remarks  
  
## Example  
 The following code example shows the `ImportGroup` element.  
  
```  
<Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
    <ImportGroup>  
        <Import Project="$(Targets1.targets) />  
        <Import Project="$(Targets2.targets) />  
    </ImportGroup>  
...  
</Project>  
```  
  
## See Also  
 [Project File Schema Reference](../VS_IDE/MSBuild-Project-File-Schema-Reference.md)   
 [Items](../VS_IDE/MSBuild-Items.md)
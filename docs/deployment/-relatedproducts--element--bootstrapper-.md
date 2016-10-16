---
title: "&lt;RelatedProducts&gt; Element (Bootstrapper)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-deployment"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "MSBuild.GenerateBootstrapper.MissingDependency"
  - "MSBuild.GenerateBootstrapper.DuplicateItems"
  - "MSBuild.GenerateBootstrapper.IncludedProductIncluded"
  - "MSBuild.GenerateBootstrapper.DependencyNotFound"
  - "MSBuild.GenerateBootstrapper.PackageFileNotFound"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<RelatedProducts> element [bootstrapper]"
ms.assetid: bf152712-4c1e-48bd-9b7f-311cf0fdb832
caps.latest.revision: 12
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
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
# &lt;RelatedProducts&gt; Element (Bootstrapper)
The `RelatedProducts` element defines other products that either depend upon or are included in the current product.  
  
## Syntax  
  
```  
<RelatedProducts>  
    <DependsOnProduct  
        Code  
    />  
    <EitherProducts>  
        <DependsOnProduct  
            Code  
        />  
    </EitherProducts>  
    <IncludesProduct  
        Code  
    />  
</RelatedProducts>  
```  
  
## Elements and Attributes  
 The `RelatedProducts` element is a child of the `Product` element. It has no attributes.  
  
## DependsOnProduct  
 The `DependsOnProduct` element signifies that the current product depends upon the named product, and that the named product should be installed before the current one. It is a child of the `RelatedProducts` element. A `RelatedProducts` element might have one or more `DependsOnProduct` elements.  
  
 `DependsOnProduct` has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Code`|The code name of the included product, as specified by the `ProductCode` attribute of the `Product` element. For more information, see [\<Product> Element](../deployment/-product--element--bootstrapper-.md).|  
  
## EitherProducts  
 The `EitherProducts` element defines zero or more `DependsOnProduct` elements, and has no attributes. At least one `DependsOnProduct` in this set must be installed before the current product. A `RelatedProducts` element can have zero or more `EitherProducts` elements.  
  
## IncludesProduct  
 The `IncludesProduct` element signifies that a product is included with the current install, and does not require a separate installation. It is a child of the `RelatedProducts` element. A `RelatedProducts` element might have one or more `IncludesProduct` elements.  
  
 `IncludesProduct` has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Code`|The code name of the included product, as specified by the `ProductCode` attribute of the `Product` element. For more information, see [\<Product> Element](../deployment/-product--element--bootstrapper-.md).|  
  
## Example  
 The following code example specifies that the Microsoft Installer is installed with the [!INCLUDE[dnprdnshort](../codequality/includes/dnprdnshort_md.md)], and therefore will not need a separate installation.  
  
```  
<RelatedProducts>  
    <IncludesProduct Code="Microsoft.Windows.Installer.2.0" />  
</RelatedProducts>  
```  
  
## See Also  
 [\<Product> Element](../deployment/-product--element--bootstrapper-.md)
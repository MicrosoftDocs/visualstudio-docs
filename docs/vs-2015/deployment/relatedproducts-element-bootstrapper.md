---
title: "&lt;RelatedProducts&gt; Element (Bootstrapper) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
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
caps.latest.revision: 14
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# &lt;RelatedProducts&gt; Element (Bootstrapper)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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
|`Code`|The code name of the included product, as specified by the `ProductCode` attribute of the `Product` element. For more information, see [\<Product> Element](../deployment/product-element-bootstrapper.md).|  
  
## EitherProducts  
 The `EitherProducts` element defines zero or more `DependsOnProduct` elements, and has no attributes. At least one `DependsOnProduct` in this set must be installed before the current product. A `RelatedProducts` element can have zero or more `EitherProducts` elements.  
  
## IncludesProduct  
 The `IncludesProduct` element signifies that a product is included with the current install, and does not require a separate installation. It is a child of the `RelatedProducts` element. A `RelatedProducts` element might have one or more `IncludesProduct` elements.  
  
 `IncludesProduct` has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Code`|The code name of the included product, as specified by the `ProductCode` attribute of the `Product` element. For more information, see [\<Product> Element](../deployment/product-element-bootstrapper.md).|  
  
## Example  
 The following code example specifies that the Microsoft Installer is installed with the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)], and therefore will not need a separate installation.  
  
```  
<RelatedProducts>  
    <IncludesProduct Code="Microsoft.Windows.Installer.2.0" />  
</RelatedProducts>  
```  
  
## See Also  
 [\<Product> Element](../deployment/product-element-bootstrapper.md)

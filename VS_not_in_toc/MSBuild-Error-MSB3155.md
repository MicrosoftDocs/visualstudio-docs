---
title: "MSBuild Error MSB3155"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 59bf2293-ef13-4bb1-8f29-5d6966bbe313
caps.latest.revision: 11
manager: douge
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
# MSBuild Error MSB3155
**MSBuild Error MSB3155: Item '<package\>' could not be located in '<path\>'**  
  
 This warning occurs when a package with the specified <xref:Microsoft.Build.Tasks.Deployment.Bootstrapper.Product.ProductCode?qualifyHint=False> cannot be found in the bootstrapper cache.  
  
> [!NOTE]
>  Microsoft Data Access Components (MDAC) are no longer included as a bootstrapper package. They can be downloaded from the [Microsoft Windows Update](http://go.microsoft.com/fwlink/?LinkId=86676) Web site.  
  
### To correct this error  
  
-   Remove the package from the list of packages to install, or add the package to the cache. Also, make sure that the manifest is formatted correctly with valid XML tags.  
  
## See Also  
 [Product and Package Schema Reference](../VS_IDE/Product-and-Package-Schema-Reference.md)   
 [<PackageFiles\> Element](../VS_IDE/-PackageFiles--Element--Bootstrapper-.md)   
 [Prerequisites Dialog Box](../VS_IDE/Prerequisites-Dialog-Box.md)   
 [Creating Bootstrapper Packages](../VS_IDE/Creating-Bootstrapper-Packages.md)
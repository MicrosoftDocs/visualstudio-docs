---
title: "&lt;customErrorReporting&gt; Element (ClickOnce Deployment)"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-deployment
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7d31816e-c692-46b5-9cc9-753284b3bcda
caps.latest.revision: 6
manager: wpickett
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
# &lt;customErrorReporting&gt; Element (ClickOnce Deployment)
Specifies a URI to show when an error occurs.  
  
## Syntax  
  
```  
<customErrorReporting  
   uri  
/>  
```  
  
## Remarks  
 This element is optional. Without it, ClickOnce displays an error dialog box showing the exception stack. If the `customErrorReporting` element is present, ClickOnce will instead display the URI indicated by the `uri` parameter. The target URI will include the outer exception class, the inner exception class, and the inner exception message as parameters.  
  
 Use this element to add error reporting functionality to your application. Since the generated URI includes information about the type of error, your Web site can parse that information and display, for example, an appropriate troubleshooting screen.  
  
## Example  
 The following snippet shows the `customErrorReporting` element, together with the generated URI it might produce.  
  
```  
<customErrorReporting uri=http://www.contoso.com/applications/error.asp />  
  
Example Generated Error:  
http://www.contoso.com/applications/error.asp? outer=System.Deployment.Application.InvalidDeploymentException&&inner=System.Deployment.Application.InvalidDeploymentException&&msg=The%20application%20manifest%20is%20signed,%20but%20the%20deployment%20manifest%20is%20unsigned.%20Both%20manifests%20must%20be%20either%20signed%20or%20unsigned.  
```  
  
## See Also  
 [ClickOnce Deployment Manifest](../VS_IDE/ClickOnce-Deployment-Manifest.md)
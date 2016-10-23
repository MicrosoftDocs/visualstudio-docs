---
title: "Adding Web Services to Project Systems"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8efa078b-68b2-45a2-9be2-44f807bc0d7f
caps.latest.revision: 8
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Adding Web Services to Project Systems
XML Web services are, in general, URL-addressable resources that return programmatic information to the project system using the SOAP (Simple Object Access Protocol) protocol. You can integrate Web services to your VSPackage project system by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddProjectItemDlg2?qualifyHint=False> interface.  
  
### To add a Web service to your project system  
  
1.  Call `QueryService` for <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddProjectItemDlg2?qualifyHint=False> interface through <xref:Microsoft.VisualStudio.Shell.Interop.SVsAddWebReferenceDlg?qualifyHint=False> service.  
  
2.  Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddWebReferenceDlg2.AddWebReferenceDlg?qualifyHint=False> method. If you pass in `pDiscoverySession` parameter as `NULL`, a discovery session is created for you, and the session is cached so that it is available for subsequent use by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddWebReferenceDlg2?qualifyHint=False> interface. <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddWebReferenceDlg2.AddWebReferenceDlg?qualifyHint=False> method returns a pointer to <xref:Microsoft.VisualStudio.Shell.Interop.IDiscoveryResult2?qualifyHint=False>.  
  
3.  Call the <xref:Microsoft.VisualStudio.Shell.Interop.IDiscoveryResult.AddWebReference?qualifyHint=False> method. Pass in the automation object for the Web service references folder as the `pUnkWebReferenceFolder` parameter. The Visual Studio environment then checks if the Web service is already present. If the Web service is not present, the environment downloads and adds the Web service to a folder and any additional files (such as .wsdl files) to the child nodes of the folder.  
  
## See Also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddWebReferenceDlg2?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IDiscoveryResult?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IDiscoverySession?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsDiscoveryService?qualifyHint=False>
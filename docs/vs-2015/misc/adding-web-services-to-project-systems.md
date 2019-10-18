---
title: "Adding Web Services to Project Systems | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "devlang-csharp"
ms.topic: conceptual
helpviewer_keywords: 
  - "project systems, adding Web services"
  - "Web services, adding to VSPackage project systems"
ms.assetid: 8efa078b-68b2-45a2-9be2-44f807bc0d7f
caps.latest.revision: 8
manager: jillfra
---
# Adding Web Services to Project Systems
XML Web services are, in general, URL-addressable resources that return programmatic information to the project system using the SOAP (Simple Object Access Protocol) protocol. You can integrate Web services to your VSPackage project system by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddProjectItemDlg2> interface.  
  
### To add a Web service to your project system  
  
1. Call `QueryService` for <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddProjectItemDlg2> interface through <xref:Microsoft.VisualStudio.Shell.Interop.SVsAddWebReferenceDlg> service.  
  
2. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddWebReferenceDlg2.AddWebReferenceDlg%2A> method. If you pass in `pDiscoverySession` parameter as `NULL`, a discovery session is created for you, and the session is cached so that it is available for subsequent use by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddWebReferenceDlg2> interface. <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddWebReferenceDlg2.AddWebReferenceDlg%2A> method returns a pointer to <xref:Microsoft.VisualStudio.Shell.Interop.IDiscoveryResult2>.  
  
3. Call the <xref:Microsoft.VisualStudio.Shell.Interop.IDiscoveryResult.AddWebReference%2A> method. Pass in the automation object for the Web service references folder as the `pUnkWebReferenceFolder` parameter. The Visual Studio environment then checks if the Web service is already present. If the Web service is not present, the environment downloads and adds the Web service to a folder and any additional files (such as .wsdl files) to the child nodes of the folder.  
  
## See also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsAddWebReferenceDlg2>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IDiscoveryResult>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IDiscoverySession>   
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsDiscoveryService>
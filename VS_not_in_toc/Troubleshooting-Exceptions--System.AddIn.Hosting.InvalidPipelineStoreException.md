---
title: "Troubleshooting Exceptions: System.AddIn.Hosting.InvalidPipelineStoreException"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d12556bc-5cfd-481c-a27b-46ee2571e646
caps.latest.revision: 4
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
# Troubleshooting Exceptions: System.AddIn.Hosting.InvalidPipelineStoreException
The <xref:System.AddIn.Hosting.InvalidPipelineStoreException?qualifyHint=False> exception is thrown when a directory is not found and the user does not have permission to access the pipeline root path or an add-in path.  
  
## Remarks  
 Unlike <xref:System.IO.DirectoryNotFoundException?qualifyHint=False>, this exception does not provide any path information. This prevents a malicious user from deliberately specifying erroneous paths and using the information returned by the exception to determine actual paths.  
  
 The exception is thrown by the following discovery methods that build and update the store of add-in and pipeline information: <xref:System.AddIn.Hosting.AddInStore.FindAddIns?qualifyHint=False>,<xref:System.AddIn.Hosting.AddInStore.Rebuild?qualifyHint=False>, <xref:System.AddIn.Hosting.AddInStore.RebuildAddIns?qualifyHint=False>, <xref:System.AddIn.Hosting.AddInStore.Update?qualifyHint=False>, and <xref:System.AddIn.Hosting.AddInStore.UpdateAddIns?qualifyHint=False>.  
  
## See Also  
 <xref:System.AddIn.Hosting.InvalidPipelineStoreException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)
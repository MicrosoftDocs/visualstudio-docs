---
title: "Troubleshooting Exceptions: System.ServiceModel.ServerTooBusyException"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 80eb606a-ab3c-48af-b747-c9902989a059
caps.latest.revision: 6
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
# Troubleshooting Exceptions: System.ServiceModel.ServerTooBusyException
A <xref:System.ServiceModel.ServerTooBusyException?qualifyHint=False> exception is thrown when a server is too busy to accept a message.  
  
## Remarks  
 This exception derives from the <xref:System.ServiceModel.CommunicationException?qualifyHint=False> that represents a class of recoverable errors that might be thrown during communication between endpoints. Robust client and service Windows Communication Foundation (WCF) applications are expected to handle these exceptions. To prevent a handler for <xref:System.ServiceModel.CommunicationException?qualifyHint=False> from catching the more specific <xref:System.ServiceModel.ServerTooBusyException?qualifyHint=False>, catch this exception prior to handling <xref:System.ServiceModel.CommunicationException?qualifyHint=False>.  
  
## See Also  
 <xref:System.ServiceModel.ServerTooBusyException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)
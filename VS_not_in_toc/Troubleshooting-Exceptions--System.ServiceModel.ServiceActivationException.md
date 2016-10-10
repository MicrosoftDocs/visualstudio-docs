---
title: "Troubleshooting Exceptions: System.ServiceModel.ServiceActivationException"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 32a3ea87-d6da-40bf-ba04-e862ac122391
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
# Troubleshooting Exceptions: System.ServiceModel.ServiceActivationException
A <xref:System.ServiceModel.ServiceActivationException?qualifyHint=False> exception is thrown when a service fails to activate.  
  
## Remarks  
 This exception derives from <xref:System.ServiceModel.CommunicationException?qualifyHint=False>, which represents a class of recoverable errors that may be thrown during communication between endpoints, and which Windows Communication Foundation (WCF) robust client and service applications are expected to handle. To prevent the more generic <xref:System.ServiceModel.CommunicationException?qualifyHint=False> handler from catching the more specific <xref:System.ServiceModel.ActionNotSupportedException?qualifyHint=False>, catch this exception prior to handling <xref:System.ServiceModel.CommunicationException?qualifyHint=False>.  
  
## See Also  
 <xref:System.ServiceModel.ServiceActivationException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)
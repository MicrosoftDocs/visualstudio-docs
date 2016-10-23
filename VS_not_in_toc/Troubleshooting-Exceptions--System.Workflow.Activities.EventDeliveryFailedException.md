---
title: "Troubleshooting Exceptions: System.Workflow.Activities.EventDeliveryFailedException"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 85ee2cb8-5cd1-4878-9421-2a78614e819f
caps.latest.revision: 7
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
# Troubleshooting Exceptions: System.Workflow.Activities.EventDeliveryFailedException
An <xref:System.Workflow.Activities.EventDeliveryFailedException?qualifyHint=False> exception is thrown when an event that is raised from the host cannot be delivered to the workflow instance. Typically, the event is raised from an <xref:System.Workflow.Activities.ExternalDataExchangeService?qualifyHint=False> on a workflow instance. This class cannot be inherited.  
  
## Remarks  
 The following string is added to the event log when this exception is thrown: `Event '{1}' on interface type '{0}' for instance id '{2}' cannot be delivered`.  
  
 When using a state machine workflow, you may get an exception with the message `Queue '{0}' is not enabled`. This happens when the current state of the state machine is not able to handle a specific event. For example, the message occurs when a state other than the current state contains the <xref:System.Workflow.Activities.EventDrivenActivity?qualifyHint=False> that contains the <xref:System.Workflow.Activities.HandleExternalEventActivity?qualifyHint=False> that is represented by the queue `'{0}'`.  
  
## See Also  
 <xref:System.Workflow.Activities.EventDeliveryFailedException?qualifyHint=False>   
 [Use the Exception Assistant](../Topic/How%20to:%20Use%20the%20Exception%20Assistant.md)
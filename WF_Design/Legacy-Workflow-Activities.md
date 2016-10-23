---
title: "Legacy Workflow Activities"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 4af7a06b-1e82-43c8-aec8-0dc5fb63d08a
caps.latest.revision: 8
manager: erikre
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
# Legacy Workflow Activities
Windows Workflow Foundation (WF) includes a default set of activities that provide functionality for control flow, conditions, event handling, state management, and communicating with applications and services. When designing workflows, you can use the system-provided activities that are provided by the Windows Workflow Designer, or you can create your own custom activities.  
  
 The following table lists the Windows Workflow Foundation framework out-of-box activity set. Many, but not all, of these activities are represented by activity designers that can be accessed from the **Toolbox** of the Workflow Designer. To create an activity, drag its designer from the **Toolbox** and drop it on the design surface.  
  
|Activity|Description|  
|--------------|-----------------|  
|[CallExternalMethodActivity](http://go.microsoft.com/fwlink?LinkID=65025)|Used with the **HandleExternalEventActivity** activity for input and output communications with a local service. For more information, see[Using the CallExternalMethodActivity Activity](http://go.microsoft.com/fwlink?LinkID=65060).|  
|[CancellationHandlerActivity](http://go.microsoft.com/fwlink?LinkID=65050)|Used to contain cleanup logic for a composite activity canceled before all the composite activity's children are finished executing. For more information, see[Using the CancellationHandlerActivity Activity](http://go.microsoft.com/fwlink?LinkID=65061).|  
|[CodeActivity](http://go.microsoft.com/fwlink?LinkID=65026)|Enables you to add Visual Basic or C# code to your workflow. For more information, see[Using the CodeActivity Activity](http://go.microsoft.com/fwlink?LinkID=65062).|  
|[CompensatableSequenceActivity](http://go.microsoft.com/fwlink?LinkID=65027)|A compensatable version of [SequenceActivity](http://go.microsoft.com/fwlink?LinkID=65020). For more information, see[Using the CompensatableSequenceActivity Activity](http://go.microsoft.com/fwlink?LinkID=65002).|  
|[CompensatableTransactionScopeActivity](http://go.microsoft.com/fwlink?LinkID=65051)|A compensatable version of **TransactionScopeActivity**. For more information, see[Using the CompensatableTransactionScopeActivity Activity](http://go.microsoft.com/fwlink?LinkID=65063).|  
|[CompensateActivity](http://go.microsoft.com/fwlink?LinkID=65052)|Enables you to call code to undo or to compensate for operations already performed by the workflow when an error occurs. For more information, see[Using the CompensateActivity Activity](http://go.microsoft.com/fwlink?LinkID=65064).|  
|[CompensationHandlerActivity](http://go.microsoft.com/fwlink?LinkID=65053)|A wrapper for one or more activities that perform compensation for a completed TransactionScopeActivity activity For more information, see[Using the CompensationHandlerActivity Activity](http://go.microsoft.com/fwlink?LinkID=65065).|  
|[ConditionedActivityGroup](http://go.microsoft.com/fwlink?LinkID=65017)|Executes child activities based on a condition that applies to the [ConditionedActivityGroup](http://go.microsoft.com/fwlink?LinkID=65017) activity itself and based on conditions that apply separately to each child. For more information, see[Using the ConditionedActivityGroup Activity](http://go.microsoft.com/fwlink?LinkID=65066).|  
|[DelayActivity](http://go.microsoft.com/fwlink?LinkID=65028)|Enables you to build delays in your workflow that are based on a time-out interval. For more information, see[Using the DelayActivity Activity](http://go.microsoft.com/fwlink?LinkID=65067).|  
|[EventDrivenActivity](http://go.microsoft.com/fwlink?LinkID=65029)|Wraps one or more activities that are executed when a specified event occurs. For more information, see[Using the EventDrivenActivity Activity](http://go.microsoft.com/fwlink?LinkID=65068).|  
|[EventHandlersActivity](http://go.microsoft.com/fwlink?LinkID=65018)|Provides a framework for associating events with an activity. For more information, see[Using the EventHandlersActivity Activity](http://go.microsoft.com/fwlink?LinkID=65069).|  
|[EventHandlingScopeActivity](http://go.microsoft.com/fwlink?LinkID=65030)|Executes its main child activity concurrently with an [EventHandlersActivity](http://go.microsoft.com/fwlink?LinkID=65018). For more information, see[Using the EventHandlingScopeActivity Activity](http://go.microsoft.com/fwlink?LinkID=65070).|  
|[FaultHandlerActivity](http://go.microsoft.com/fwlink?LinkID=65054)|Used to handle an exception of a type that you specify. For more information, see[Using the FaultHandlerActivity Activity](http://go.microsoft.com/fwlink?LinkID=65071).|  
|[FaultHandlersActivity](http://go.microsoft.com/fwlink?LinkID=65055)|Represents a composite activity that has an ordered list of child activities of type [FaultHandlerActivity](http://go.microsoft.com/fwlink?LinkID=65054). For more information, see[Using the FaultHandlersActivity Activity](http://go.microsoft.com/fwlink?LinkID=65072).|  
|[HandleExternalEventActivity](http://go.microsoft.com/fwlink?LinkID=65031)|Used in conjunction with the [CallExternalMethodActivity](http://go.microsoft.com/fwlink?LinkID=65025) activity for input and output communications with a local service. For more information, see[Using the HandleExternalEventActivity Activity](http://go.microsoft.com/fwlink?LinkID=65073).|  
|[IfElseActivity](http://go.microsoft.com/fwlink?LinkID=65033)|Tests a condition on each branch and performs activities on the first branch for which the condition equals **true**. For more information, see[Using the IfElseActivity Activity](http://go.microsoft.com/fwlink?LinkID=65074).|  
|[IfElseBranchActivity](http://go.microsoft.com/fwlink?LinkID=65034)|Represents a branch of an [IfElseActivity](http://go.microsoft.com/fwlink?LinkID=65033). For more information, see[Using the IfElseBranchActivity Activity](http://go.microsoft.com/fwlink?LinkID=65075).|  
|[InvokeWebServiceActivity](http://go.microsoft.com/fwlink?LinkID=65035)|Enables your workflow to invoke a Web service. For more information, see[Using the InvokeWebServiceActivity Activity](http://go.microsoft.com/fwlink?LinkID=65076).|  
|[InvokeWorkflowActivity](http://go.microsoft.com/fwlink?LinkID=65036)|Enables your workflow to invoke another workflow. For more information, see[Using the InvokeWorkflowActivity Activity](http://go.microsoft.com/fwlink?LinkID=65077).|  
|[ListenActivity](http://go.microsoft.com/fwlink?LinkID=65037)|A composite activity that contains only [EventDrivenActivity](http://go.microsoft.com/fwlink?LinkID=65029) child activities. For more information, see[Using the ListenActivity Activity](http://go.microsoft.com/fwlink?LinkID=65078).|  
|[ParallelActivity](http://go.microsoft.com/fwlink?LinkID=65038)|Provides a way to schedule two or more child **SequenceActivity** activity branches for processing at the same time. For more information, see[Using the ParallelActivity Activity](http://go.microsoft.com/fwlink?LinkID=65079).|  
|[PolicyActivity](http://go.microsoft.com/fwlink?LinkID=65019)|Use to represent a collection of rules. A rule consists of conditions and resulting actions. For more information, see[Using the PolicyActivity Activity](http://go.microsoft.com/fwlink?LinkID=65004).|  
|[ReplicatorActivity](http://go.microsoft.com/fwlink?LinkID=65039)|Creates multiple instances of a single child activity. For more information, see[Using the ReplicatorActivity Activity](http://go.microsoft.com/fwlink?LinkID=65080).|  
|[SequenceActivity](http://go.microsoft.com/fwlink?LinkID=65020)|Provides a simple way to link multiple activities together for sequential execution. For more information, see[Using the SequenceActivity Activity](http://go.microsoft.com/fwlink?LinkID=65081).|  
|[SetStateActivity](http://go.microsoft.com/fwlink?LinkID=65041)|Specifies a transition to a new state. For more information, see[Using the SetStateActivity Activity](http://go.microsoft.com/fwlink?LinkID=65082).|  
|[StateActivity](http://go.microsoft.com/fwlink?LinkID=65042)|Represents a state in a state machine workflow. For more information, see[Using the StateActivity Activity](http://go.microsoft.com/fwlink?LinkID=65083).|  
|[StateFinalizationActivity](http://go.microsoft.com/fwlink?LinkID=65043)|Used in a [StateActivity](http://go.microsoft.com/fwlink?LinkID=65042) activity as a container for child activities that are executed when leaving the **StateActivity** activity. For more information, see[Using the StateFinalizationActivity Activity](http://go.microsoft.com/fwlink?LinkID=65008).|  
|[StateInitializationActivity](http://go.microsoft.com/fwlink?LinkID=65044)|Used in a [StateActivity](http://go.microsoft.com/fwlink?LinkID=65042) activity as a container for child activities that are executed when entering the **StateActivity** activity. For more information, see[Using the StateInitializationActivity Activity](http://go.microsoft.com/fwlink?LinkID=65006).|  
|[SuspendActivity](http://go.microsoft.com/fwlink?LinkID=65056)|Suspends the operation of your workflow to enable intervention in the event of some error condition that requires special attention. For more information, see[Using the SuspendActivity Activity](http://go.microsoft.com/fwlink?LinkID=65084).|  
|[SynchronizationScopeActivity](http://go.microsoft.com/fwlink?LinkID=65057)|Executes contained activities sequentially in a synchronized domain. For more information, see[Using the SynchronizationScopeActivity Activity](http://go.microsoft.com/fwlink?LinkID=65085).|  
|[TerminateActivity](http://go.microsoft.com/fwlink?LinkID=65058)|Enables you to immediately end the operation of your workflow in the event of an error condition. For more information, see[Using the TerminateActivity Activity](http://go.microsoft.com/fwlink?LinkID=65086).|  
|[ThrowActivity](http://go.microsoft.com/fwlink?LinkID=65059)|Enables you to capture business exceptions thrown as part of the process metadata for a workflow. For more information, see[Using the ThrowActivity Activity](http://go.microsoft.com/fwlink?LinkID=65087).|  
|[TransactionScopeActivity](http://go.microsoft.com/fwlink?LinkID=65093)|Provides a framework for transactions and exception handling. For more information, see [Using the TransactionScopeActivity Activity](http://go.microsoft.com/fwlink?LinkID=65088).|  
|[WebServiceFaultActivity](http://go.microsoft.com/fwlink?LinkID=65046)|Enables you to model the occurrence of a Web service fault. For more information, see[Using the WebServiceFaultActivity Activity](http://go.microsoft.com/fwlink?LinkID=65089).|  
|[WebServiceInputActivity](http://go.microsoft.com/fwlink?LinkID=65047)|Receives data from a Web service. For more information, see[Using the WebServiceInputActivity Activity](http://go.microsoft.com/fwlink?LinkID=65090).|  
|[WebServiceOutputActivity](http://go.microsoft.com/fwlink?LinkID=65048)|Responds to a Web service request made to a workflow. For more information, see[Using the WebServiceOutputActivity Activity](http://go.microsoft.com/fwlink?LinkID=65092).|  
|[WhileActivity](http://go.microsoft.com/fwlink?LinkID=65049)|Enables your workflow to loop until a condition is met. For more information, see[Using the WhileActivity Activity](http://go.microsoft.com/fwlink?LinkID=65091).|  
  
 For more information about how to create custom activities, see [Developing Custom Activities](http://go.microsoft.com/fwlink?LinkID=65023) and [Using the Legacy Activity Designer](../WF_Design/Using-the-Legacy-Activity-Designer.md).  
  
## In This Section  
 [Activity Views (Legacy)](../WF_Design/Activity-Views--Legacy-.md)  
 Describes the different design views of activities.  
  
 [How to: Add Activities to the Toolbox (Legacy)](../WF_Design/How-to--Add-Activities-to-the-Toolbox--Legacy-.md)  
 Shows how to add activities to the toolbox.  
  
 [How to: Create a Declarative Rule Condition (Legacy)](../WF_Design/How-to--Create-a-Declarative-Rule-Condition--Legacy-.md)  
 Shows the steps to create a declarative rule condition.  
  
 [How to: Create a PolicyActivity Rule Set (Legacy)](../WF_Design/How-to--Create-a-PolicyActivity-Rule-Set--Legacy-.md)  
 Shows the steps to create a PolicyActivity rule set.  
  
 [How to: Implement a WCF Contract Operation (Legacy)](../WF_Design/How-to--Implement-a-Windows-Communication-Foundation-Contract-Operation--Legacy-.md)  
 Shows the steps to implement a WCF contract operation.  
  
 [How to: Invoke a WCF Contract Operation (Legacy)](../WF_Design/How-to--Invoke-a-Windows-Communication-Foundation-Contract-Operation--Legacy-.md)  
 Shows the steps to invoke a WCF contract operation.  
  
## See Also  
 [Windows Workflow Foundation Activities](http://go.microsoft.com/fwlink?LinkID=65005)   
 [Developing Workflows](http://go.microsoft.com/fwlink?LinkID=65010)   
 [Developing Workflow Activities](http://go.microsoft.com/fwlink?LinkID=65023)
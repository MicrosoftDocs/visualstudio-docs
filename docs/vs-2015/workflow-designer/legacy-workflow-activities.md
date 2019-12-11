---
title: "Legacy Workflow Activities | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "workflows, activities"
  - "activities"
  - "workflow activities"
ms.assetid: 4af7a06b-1e82-43c8-aec8-0dc5fb63d08a
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# Legacy Workflow Activities
[!INCLUDE[wf](../includes/wf-md.md)] includes a default set of activities that provide functionality for control flow, conditions, event handling, state management, and communicating with applications and services. When designing workflows, you can use the system-provided activities that are provided by the [!INCLUDE[wfd1](../includes/wfd1-md.md)], or you can create your own custom activities.

 The following table lists the [!INCLUDE[wf2](../includes/wf2-md.md)] framework out-of-box activity set. Many, but not all, of these activities are represented by activity designers that can be accessed from the **Toolbox** of the [!INCLUDE[wfd2](../includes/wfd2-md.md)]. To create an activity, drag its designer from the **Toolbox** and drop it on the design surface.

|Activity|Description|
|--------------|-----------------|
|[CallExternalMethodActivity](https://go.microsoft.com/fwlink?LinkID=65025)|Used with the **HandleExternalEventActivity** activity for input and output communications with a local service. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CallExternalMethodActivity Activity](https://go.microsoft.com/fwlink?LinkID=65060).|
|[CancellationHandlerActivity](https://go.microsoft.com/fwlink?LinkID=65050)|Used to contain cleanup logic for a composite activity canceled before all the composite activity's children are finished executing. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CancellationHandlerActivity Activity](https://go.microsoft.com/fwlink?LinkID=65061).|
|[CodeActivity](https://go.microsoft.com/fwlink?LinkID=65026)|Enables you to add Visual Basic or C# code to your workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CodeActivity Activity](https://go.microsoft.com/fwlink?LinkID=65062).|
|[CompensatableSequenceActivity](https://go.microsoft.com/fwlink?LinkID=65027)|A compensatable version of [SequenceActivity](https://go.microsoft.com/fwlink?LinkID=65020). [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CompensatableSequenceActivity Activity](https://go.microsoft.com/fwlink?LinkID=65002).|
|[CompensatableTransactionScopeActivity](https://go.microsoft.com/fwlink?LinkID=65051)|A compensatable version of **TransactionScopeActivity**. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CompensatableTransactionScopeActivity Activity](https://go.microsoft.com/fwlink?LinkID=65063).|
|[CompensateActivity](https://go.microsoft.com/fwlink?LinkID=65052)|Enables you to call code to undo or to compensate for operations already performed by the workflow when an error occurs. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CompensateActivity Activity](https://go.microsoft.com/fwlink?LinkID=65064).|
|[CompensationHandlerActivity](https://go.microsoft.com/fwlink?LinkID=65053)|A wrapper for one or more activities that perform compensation for a completed TransactionScopeActivity activity [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CompensationHandlerActivity Activity](https://go.microsoft.com/fwlink?LinkID=65065).|
|[ConditionedActivityGroup](https://go.microsoft.com/fwlink?LinkID=65017)|Executes child activities based on a condition that applies to the [ConditionedActivityGroup](https://go.microsoft.com/fwlink?LinkID=65017) activity itself and based on conditions that apply separately to each child. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ConditionedActivityGroup Activity](https://go.microsoft.com/fwlink?LinkID=65066).|
|[DelayActivity](https://go.microsoft.com/fwlink?LinkID=65028)|Enables you to build delays in your workflow that are based on a time-out interval. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the DelayActivity Activity](https://go.microsoft.com/fwlink?LinkID=65067).|
|[EventDrivenActivity](https://go.microsoft.com/fwlink?LinkID=65029)|Wraps one or more activities that are executed when a specified event occurs. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the EventDrivenActivity Activity](https://go.microsoft.com/fwlink?LinkID=65068).|
|[EventHandlersActivity](https://go.microsoft.com/fwlink?LinkID=65018)|Provides a framework for associating events with an activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the EventHandlersActivity Activity](https://go.microsoft.com/fwlink?LinkID=65069).|
|[EventHandlingScopeActivity](https://go.microsoft.com/fwlink?LinkID=65030)|Executes its main child activity concurrently with an [EventHandlersActivity](https://go.microsoft.com/fwlink?LinkID=65018). [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the EventHandlingScopeActivity Activity](https://go.microsoft.com/fwlink?LinkID=65070).|
|[FaultHandlerActivity](https://go.microsoft.com/fwlink?LinkID=65054)|Used to handle an exception of a type that you specify. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the FaultHandlerActivity Activity](https://go.microsoft.com/fwlink?LinkID=65071).|
|[FaultHandlersActivity](https://go.microsoft.com/fwlink?LinkID=65055)|Represents a composite activity that has an ordered list of child activities of type [FaultHandlerActivity](https://go.microsoft.com/fwlink?LinkID=65054). [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the FaultHandlersActivity Activity](https://go.microsoft.com/fwlink?LinkID=65072).|
|[HandleExternalEventActivity](https://go.microsoft.com/fwlink?LinkID=65031)|Used in conjunction with the [CallExternalMethodActivity](https://go.microsoft.com/fwlink?LinkID=65025) activity for input and output communications with a local service. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the HandleExternalEventActivity Activity](https://go.microsoft.com/fwlink?LinkID=65073).|
|[IfElseActivity](https://go.microsoft.com/fwlink?LinkID=65033)|Tests a condition on each branch and performs activities on the first branch for which the condition equals **true**. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the IfElseActivity Activity](https://go.microsoft.com/fwlink?LinkID=65074).|
|[IfElseBranchActivity](https://go.microsoft.com/fwlink?LinkID=65034)|Represents a branch of an [IfElseActivity](https://go.microsoft.com/fwlink?LinkID=65033). [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the IfElseBranchActivity Activity](https://go.microsoft.com/fwlink?LinkID=65075).|
|[InvokeWebServiceActivity](https://go.microsoft.com/fwlink?LinkID=65035)|Enables your workflow to invoke a Web service. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the InvokeWebServiceActivity Activity](https://go.microsoft.com/fwlink?LinkID=65076).|
|[InvokeWorkflowActivity](https://go.microsoft.com/fwlink?LinkID=65036)|Enables your workflow to invoke another workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the InvokeWorkflowActivity Activity](https://go.microsoft.com/fwlink?LinkID=65077).|
|[ListenActivity](https://go.microsoft.com/fwlink?LinkID=65037)|A composite activity that contains only [EventDrivenActivity](https://go.microsoft.com/fwlink?LinkID=65029) child activities. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ListenActivity Activity](https://go.microsoft.com/fwlink?LinkID=65078).|
|[ParallelActivity](https://go.microsoft.com/fwlink?LinkID=65038)|Provides a way to schedule two or more child **SequenceActivity** activity branches for processing at the same time. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ParallelActivity Activity](https://go.microsoft.com/fwlink?LinkID=65079).|
|[PolicyActivity](https://go.microsoft.com/fwlink?LinkID=65019)|Use to represent a collection of rules. A rule consists of conditions and resulting actions. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the PolicyActivity Activity](https://go.microsoft.com/fwlink?LinkID=65004).|
|[ReplicatorActivity](https://go.microsoft.com/fwlink?LinkID=65039)|Creates multiple instances of a single child activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ReplicatorActivity Activity](https://go.microsoft.com/fwlink?LinkID=65080).|
|[SequenceActivity](https://go.microsoft.com/fwlink?LinkID=65020)|Provides a simple way to link multiple activities together for sequential execution. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the SequenceActivity Activity](https://go.microsoft.com/fwlink?LinkID=65081).|
|[SetStateActivity](https://go.microsoft.com/fwlink?LinkID=65041)|Specifies a transition to a new state. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the SetStateActivity Activity](https://go.microsoft.com/fwlink?LinkID=65082).|
|[StateActivity](https://go.microsoft.com/fwlink?LinkID=65042)|Represents a state in a state machine workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the StateActivity Activity](https://go.microsoft.com/fwlink?LinkID=65083).|
|[StateFinalizationActivity](https://go.microsoft.com/fwlink?LinkID=65043)|Used in a [StateActivity](https://go.microsoft.com/fwlink?LinkID=65042) activity as a container for child activities that are executed when leaving the **StateActivity** activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the StateFinalizationActivity Activity](https://go.microsoft.com/fwlink?LinkID=65008).|
|[StateInitializationActivity](https://go.microsoft.com/fwlink?LinkID=65044)|Used in a [StateActivity](https://go.microsoft.com/fwlink?LinkID=65042) activity as a container for child activities that are executed when entering the **StateActivity** activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the StateInitializationActivity Activity](https://go.microsoft.com/fwlink?LinkID=65006).|
|[SuspendActivity](https://go.microsoft.com/fwlink?LinkID=65056)|Suspends the operation of your workflow to enable intervention in the event of some error condition that requires special attention. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the SuspendActivity Activity](https://go.microsoft.com/fwlink?LinkID=65084).|
|[SynchronizationScopeActivity](https://go.microsoft.com/fwlink?LinkID=65057)|Executes contained activities sequentially in a synchronized domain. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the SynchronizationScopeActivity Activity](https://go.microsoft.com/fwlink?LinkID=65085).|
|[TerminateActivity](https://go.microsoft.com/fwlink?LinkID=65058)|Enables you to immediately end the operation of your workflow in the event of an error condition. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the TerminateActivity Activity](https://go.microsoft.com/fwlink?LinkID=65086).|
|[ThrowActivity](https://go.microsoft.com/fwlink?LinkID=65059)|Enables you to capture business exceptions thrown as part of the process metadata for a workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ThrowActivity Activity](https://go.microsoft.com/fwlink?LinkID=65087).|
|[TransactionScopeActivity](https://go.microsoft.com/fwlink?LinkID=65093)|Provides a framework for transactions and exception handling. For more information, see [Using the TransactionScopeActivity Activity](https://go.microsoft.com/fwlink?LinkID=65088).|
|[WebServiceFaultActivity](https://go.microsoft.com/fwlink?LinkID=65046)|Enables you to model the occurrence of a Web service fault. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the WebServiceFaultActivity Activity](https://go.microsoft.com/fwlink?LinkID=65089).|
|[WebServiceInputActivity](https://go.microsoft.com/fwlink?LinkID=65047)|Receives data from a Web service. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the WebServiceInputActivity Activity](https://go.microsoft.com/fwlink?LinkID=65090).|
|[WebServiceOutputActivity](https://go.microsoft.com/fwlink?LinkID=65048)|Responds to a Web service request made to a workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the WebServiceOutputActivity Activity](https://go.microsoft.com/fwlink?LinkID=65092).|
|[WhileActivity](https://go.microsoft.com/fwlink?LinkID=65049)|Enables your workflow to loop until a condition is met. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the WhileActivity Activity](https://go.microsoft.com/fwlink?LinkID=65091).|

 [!INCLUDE[crabout](../includes/crabout-md.md)] how to create custom activities, see [Developing Custom Activities](https://go.microsoft.com/fwlink?LinkID=65023) and [Using the Legacy Activity Designer](../workflow-designer/using-the-legacy-activity-designer.md).

## In This Section
 [Activity Views (Legacy)](../workflow-designer/activity-views-legacy.md)
 Describes the different design views of activities.

 [How to: Add Activities to the Toolbox (Legacy)](../workflow-designer/how-to-add-activities-to-the-toolbox-legacy.md)
 Shows how to add activities to the toolbox.

 [How to: Create a Declarative Rule Condition (Legacy)](../workflow-designer/how-to-create-a-declarative-rule-condition-legacy.md)
 Shows the steps to create a declarative rule condition.

 [How to: Create a PolicyActivity Rule Set (Legacy)](../workflow-designer/how-to-create-a-policyactivity-rule-set-legacy.md)
 Shows the steps to create a PolicyActivity rule set.

 [How to: Implement a WCF Contract Operation (Legacy)](../workflow-designer/how-to-implement-a-windows-communication-foundation-contract-operation-legacy.md)
 Shows the steps to implement a [!INCLUDE[indigo2](../includes/indigo2-md.md)] contract operation.

 [How to: Invoke a WCF Contract Operation (Legacy)](../workflow-designer/how-to-invoke-a-windows-communication-foundation-contract-operation-legacy.md)
 Shows the steps to invoke a [!INCLUDE[indigo2](../includes/indigo2-md.md)] contract operation.

## See Also
 [Windows Workflow Foundation Activities](https://go.microsoft.com/fwlink?LinkID=65005)
 [Developing Workflows](https://go.microsoft.com/fwlink?LinkID=65010)
 [Developing Workflow Activities](https://go.microsoft.com/fwlink?LinkID=65023)
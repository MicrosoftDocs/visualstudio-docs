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
|[CallExternalMethodActivity](https://msdn2.microsoft.com/library/system.workflow.activities.callexternalmethodactivity.aspx)|Used with the **HandleExternalEventActivity** activity for input and output communications with a local service. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CallExternalMethodActivity Activity](https://msdn2.microsoft.com/library/bb628493.aspx).|
|[CancellationHandlerActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.cancellationhandleractivity.aspx)|Used to contain cleanup logic for a composite activity canceled before all the composite activity's children are finished executing. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CancellationHandlerActivity Activity](https://msdn2.microsoft.com/library/bb628604.aspx).|
|[CodeActivity](https://msdn2.microsoft.com/library/system.workflow.activities.codeactivity.aspx)|Enables you to add Visual Basic or C# code to your workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CodeActivity Activity](https://msdn2.microsoft.com/library/bb675249.aspx).|
|[CompensatableSequenceActivity](https://msdn2.microsoft.com/library/system.workflow.activities.compensatablesequenceactivity.aspx)|A compensatable version of [SequenceActivity](https://msdn2.microsoft.com/library/system.workflow.activities.sequenceactivity.aspx). [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CompensatableSequenceActivity Activity](https://msdn2.microsoft.com/library/bb675224.aspx).|
|[CompensatableTransactionScopeActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.compensatabletransactionscopeactivity.aspx)|A compensatable version of **TransactionScopeActivity**. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CompensatableTransactionScopeActivity Activity](https://msdn2.microsoft.com/library/bb628592.aspx).|
|[CompensateActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.compensateactivity.aspx)|Enables you to call code to undo or to compensate for operations already performed by the workflow when an error occurs. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CompensateActivity Activity](https://msdn2.microsoft.com/library/bb628608.aspx).|
|[CompensationHandlerActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.compensationhandleractivity.aspx)|A wrapper for one or more activities that perform compensation for a completed TransactionScopeActivity activity [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the CompensationHandlerActivity Activity](https://msdn2.microsoft.com/library/bb675279.aspx).|
|[ConditionedActivityGroup](https://msdn2.microsoft.com/library/system.workflow.activities.conditionedactivitygroup.aspx)|Executes child activities based on a condition that applies to the [ConditionedActivityGroup](https://msdn2.microsoft.com/library/system.workflow.activities.conditionedactivitygroup.aspx) activity itself and based on conditions that apply separately to each child. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ConditionedActivityGroup Activity](https://msdn2.microsoft.com/library/bb675237.aspx).|
|[DelayActivity](https://msdn2.microsoft.com/library/system.workflow.activities.delayactivity.aspx)|Enables you to build delays in your workflow that are based on a time-out interval. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the DelayActivity Activity](https://msdn2.microsoft.com/library/bb628484.aspx).|
|[EventDrivenActivity](https://msdn2.microsoft.com/library/system.workflow.activities.eventdrivenactivity.aspx)|Wraps one or more activities that are executed when a specified event occurs. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the EventDrivenActivity Activity](https://msdn2.microsoft.com/library/bb628466.aspx).|
|[EventHandlersActivity](https://msdn2.microsoft.com/library/system.workflow.activities.eventhandlersactivity.aspx)|Provides a framework for associating events with an activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the EventHandlersActivity Activity](https://msdn2.microsoft.com/library/bb628537.aspx).|
|[EventHandlingScopeActivity](https://msdn2.microsoft.com/library/system.workflow.activities.eventhandlingscopeactivity.aspx)|Executes its main child activity concurrently with an [EventHandlersActivity](https://msdn2.microsoft.com/library/system.workflow.activities.eventhandlersactivity.aspx). [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the EventHandlingScopeActivity Activity](https://msdn2.microsoft.com/library/bb628463.aspx).|
|[FaultHandlerActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.faulthandleractivity.aspx)|Used to handle an exception of a type that you specify. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the FaultHandlerActivity Activity](https://msdn2.microsoft.com/library/bb628479.aspx).|
|[FaultHandlersActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.faulthandlersactivity.aspx)|Represents a composite activity that has an ordered list of child activities of type [FaultHandlerActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.faulthandleractivity.aspx). [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the FaultHandlersActivity Activity](https://msdn2.microsoft.com/library/bb675252.aspx).|
|[HandleExternalEventActivity](https://msdn2.microsoft.com/library/system.workflow.activities.handleexternaleventactivity.aspx)|Used in conjunction with the [CallExternalMethodActivity](https://msdn2.microsoft.com/library/system.workflow.activities.callexternalmethodactivity.aspx) activity for input and output communications with a local service. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the HandleExternalEventActivity Activity](https://msdn2.microsoft.com/library/bb628446.aspx).|
|[IfElseActivity](https://msdn2.microsoft.com/library/system.workflow.activities.ifelseactivity.aspx)|Tests a condition on each branch and performs activities on the first branch for which the condition equals **true**. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the IfElseActivity Activity](https://msdn2.microsoft.com/library/bb628472.aspx).|
|[IfElseBranchActivity](https://msdn2.microsoft.com/library/system.workflow.activities.ifelsebranchactivity.aspx)|Represents a branch of an [IfElseActivity](https://msdn2.microsoft.com/library/system.workflow.activities.ifelseactivity.aspx). [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the IfElseBranchActivity Activity](https://msdn2.microsoft.com/library/bb628465.aspx).|
|[InvokeWebServiceActivity](https://msdn2.microsoft.com/library/system.workflow.activities.invokewebserviceactivity.aspx)|Enables your workflow to invoke a Web service. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the InvokeWebServiceActivity Activity](https://msdn2.microsoft.com/library/bb628576.aspx).|
|[InvokeWorkflowActivity](https://msdn2.microsoft.com/library/system.workflow.activities.invokeworkflowactivity.aspx)|Enables your workflow to invoke another workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the InvokeWorkflowActivity Activity](https://msdn2.microsoft.com/library/bb628557.aspx).|
|[ListenActivity](https://msdn2.microsoft.com/library/system.workflow.activities.listenactivity.aspx)|A composite activity that contains only [EventDrivenActivity](https://msdn2.microsoft.com/library/system.workflow.activities.eventdrivenactivity.aspx) child activities. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ListenActivity Activity](https://msdn2.microsoft.com/library/bb628468.aspx).|
|[ParallelActivity](https://msdn2.microsoft.com/library/system.workflow.activities.parallelactivity.aspx)|Provides a way to schedule two or more child **SequenceActivity** activity branches for processing at the same time. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ParallelActivity Activity](https://msdn2.microsoft.com/library/bb628494.aspx).|
|[PolicyActivity](https://msdn2.microsoft.com/library/system.workflow.activities.policyactivity.aspx)|Use to represent a collection of rules. A rule consists of conditions and resulting actions. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the PolicyActivity Activity](https://msdn2.microsoft.com/library/bb675229.aspx).|
|[ReplicatorActivity](https://msdn2.microsoft.com/library/system.workflow.activities.replicatoractivity.aspx)|Creates multiple instances of a single child activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ReplicatorActivity Activity](https://msdn2.microsoft.com/library/bb628544.aspx).|
|[SequenceActivity](https://msdn2.microsoft.com/library/system.workflow.activities.sequenceactivity.aspx)|Provides a simple way to link multiple activities together for sequential execution. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the SequenceActivity Activity](https://msdn2.microsoft.com/library/bb628551.aspx).|
|[SetStateActivity](https://msdn2.microsoft.com/library/system.workflow.activities.setstateactivity.aspx)|Specifies a transition to a new state. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the SetStateActivity Activity](https://msdn2.microsoft.com/library/bb628469.aspx).|
|[StateActivity](https://msdn2.microsoft.com/library/system.workflow.activities.stateactivity.aspx)|Represents a state in a state machine workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the StateActivity Activity](https://msdn2.microsoft.com/library/bb628612.aspx).|
|[StateFinalizationActivity](https://msdn2.microsoft.com/library/system.workflow.activities.statefinalizationactivity.aspx)|Used in a [StateActivity](https://msdn2.microsoft.com/library/system.workflow.activities.stateactivity.aspx) activity as a container for child activities that are executed when leaving the **StateActivity** activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the StateFinalizationActivity Activity](https://msdn2.microsoft.com/library/bb675278.aspx).|
|[StateInitializationActivity](https://msdn2.microsoft.com/library/system.workflow.activities.stateinitializationactivity.aspx)|Used in a [StateActivity](https://msdn2.microsoft.com/library/system.workflow.activities.stateactivity.aspx) activity as a container for child activities that are executed when entering the **StateActivity** activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the StateInitializationActivity Activity](https://msdn2.microsoft.com/library/bb675253.aspx).|
|[SuspendActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.suspendactivity.aspx)|Suspends the operation of your workflow to enable intervention in the event of some error condition that requires special attention. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the SuspendActivity Activity](https://msdn2.microsoft.com/library/bb628533.aspx).|
|[SynchronizationScopeActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.synchronizationscopeactivity.aspx)|Executes contained activities sequentially in a synchronized domain. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the SynchronizationScopeActivity Activity](https://msdn2.microsoft.com/library/bb675276.aspx).|
|[TerminateActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.terminateactivity.aspx)|Enables you to immediately end the operation of your workflow in the event of an error condition. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the TerminateActivity Activity](https://msdn2.microsoft.com/library/bb675261.aspx).|
|[ThrowActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.throwactivity.aspx)|Enables you to capture business exceptions thrown as part of the process metadata for a workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the ThrowActivity Activity](https://msdn2.microsoft.com/library/bb628490.aspx).|
|[TransactionScopeActivity](https://msdn2.microsoft.com/library/system.workflow.componentmodel.transactionscopeactivity.aspx)|Provides a framework for transactions and exception handling. For more information, see [Using the TransactionScopeActivity Activity](https://msdn2.microsoft.com/library/bb675241.aspx).|
|[WebServiceFaultActivity](https://msdn2.microsoft.com/library/system.workflow.activities.webservicefaultactivity.aspx)|Enables you to model the occurrence of a Web service fault. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the WebServiceFaultActivity Activity](https://msdn2.microsoft.com/library/bb628568.aspx).|
|[WebServiceInputActivity](https://msdn2.microsoft.com/library/system.workflow.activities.webserviceinputactivity.aspx)|Receives data from a Web service. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the WebServiceInputActivity Activity](https://msdn2.microsoft.com/library/bb628508.aspx).|
|[WebServiceOutputActivity](https://msdn2.microsoft.com/library/system.workflow.activities.webserviceoutputactivity.aspx)|Responds to a Web service request made to a workflow. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the WebServiceOutputActivity Activity](https://msdn2.microsoft.com/library/bb628594.aspx).|
|[WhileActivity](https://msdn2.microsoft.com/library/system.workflow.activities.whileactivity.aspx)|Enables your workflow to loop until a condition is met. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Using the WhileActivity Activity](https://msdn2.microsoft.com/library/bb628552.aspx).|

 [!INCLUDE[crabout](../includes/crabout-md.md)] how to create custom activities, see [Developing Custom Activities](https://msdn2.microsoft.com/library/bb675248.aspx) and [Using the Legacy Activity Designer](../workflow-designer/using-the-legacy-activity-designer.md).

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
 [Windows Workflow Foundation Activities](https://msdn2.microsoft.com/library/bb675247.aspx)
 [Developing Workflows](https://msdn2.microsoft.com/library/bb628448.aspx)
 [Developing Workflow Activities](https://msdn2.microsoft.com/library/bb675248.aspx)

---
title: "StateMachine Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "StateMachine Designer"
  - "System.Activities.Statements.StateMachine.UI"
ms.assetid: 474d5fb3-1049-4b3f-bc6b-7524dbbe1672
caps.latest.revision: 5
author: "steved0x"
ms.author: jillfra
manager: jillfra
---
# StateMachine Activity Designer
The <xref:System.Activities.Statements.StateMachine> activity contains a collection of states and models workflows using the familiar state machine paradigm.

## Using the StateMachine Activity Designer
 To add a <xref:System.Activities.Statements.StateMachine> activity, drag the **StateMachine** activity designer from the **State Machine** section of the **Toolbox** and drop it on to the [!INCLUDE[wfd1](../includes/wfd1-md.md)] surface. To add a child state to this <xref:System.Activities.Statements.StateMachine> activity, drag a <xref:System.Activities.Statements.State> or <xref:System.Activities.Core.Presentation.FinalState> from the **Toolbox** and drop it onto the **StateMachine**.

### StateMachine Activity Properties in the Workflow Designer
 The following table shows the <xref:System.Activities.Statements.StateMachine> properties that can be set using the workflow designer and describes how they are used in the designer. These properties can be edited in the property grid and some can be edited on the designer surface.

|Property Name|Required|Usage|
|-------------------|--------------|-----------|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the friendly name of the <xref:System.Activities.Statements.StateMachine> activity designer in the header. The default value is **StateMachine**. The value can be edited in the property grid or directly on the header of the activity designer. The <xref:System.Activities.Activity.DisplayName%2A> is used in the breadcrumb navigation that is displayed at the top of the workflow designer.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it is a best practice to use one.|

## See Also
 [Flowchart](../workflow-designer/flowchart-activity-designer.md)
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)
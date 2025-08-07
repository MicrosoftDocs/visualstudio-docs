---
title: Workflow Designer - InvokeMethod Activity Designer
description: Learn about the InvokeMethod activity and how you can use the InvokeMethod activity designer to create and configure an InvokeMethod activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- System.Activities.Statements.InvokeMethod.UI
author: sayedihashimi
ms.author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# InvokeMethod Activity Designer

**InvokeMethod** designer is used to create and configure an <xref:System.Activities.Statements.InvokeMethod> activity.

## The InvokeMethod activity

The <xref:System.Activities.Statements.InvokeMethod> calls a public method of a specified object or type.

### Use the InvokeMethod Activity Designer

Access the **InvokeMethod** activity designer in the **Primitives** category of the **Toolbox**. The **InvokeMethod** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface where ever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. Dropping the activity designer creates an <xref:System.Activities.Statements.InvokeMethod> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of InvokeMethod. The <xref:System.Activities.Activity.DisplayName%2A> can be edited in the header of the **InvokeMethod** activity designer or in the **DisplayName** box of the property grid.

### The InvokeMethod properties

The following table shows the <xref:System.Activities.Statements.InvokeMethod> properties and describes how they're used in the designer. These properties can be edited in property grid, and some can be edited on Workflow Designer surface.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.InvokeMethod> activity. The default value is InvokeMethod.<br /><br /> Although the <xref:System.Activities.Activity.DisplayName%2A> is not strictly required, it's best to use one.|
|<xref:System.Activities.Statements.InvokeMethod.MethodName%2A>|True|The name of the method to be called when the activity executes. The called method must be declared as **public**. This property can be edited on designer surface, and is mandatory.|
|<xref:System.Activities.Statements.InvokeMethod.Parameters%2A>|False|The parameter collection of the called method. The parameters must be added to the collection in the same order that they appear in the method signature. To display the **Parameters** dialog where you can set this property, click the ellipsis button in the **Parameters** field of the property grid. Click the **Create Argument** button to add the parameters.|
|<xref:System.Activities.Statements.InvokeMethod.Result%2A>|False|The return value of the method call.|
|<xref:System.Activities.Statements.InvokeMethod.RunAsynchronously%2A>|True|Specifies whether the method is called asynchronously. The default value is **False**.|
|<xref:System.Activities.Statements.InvokeMethod.TargetObject%2A>|False|The object that contains the method to call. This property can be edited on designer surface.<br /><br /> Either the <xref:System.Activities.Statements.InvokeMethod.TargetObject%2A> or the <xref:System.Activities.Statements.InvokeMethod.TargetType%2A> is required to be set.|
|<xref:System.Activities.Statements.InvokeMethod.TargetType%2A>|False|The type of <xref:System.Activities.Statements.InvokeMethod.TargetObject%2A>. This property can be edited on the designer surface. This property must only be set if the method called is static.|

To pass parameters as a C# **out** parameter (for example, `Method1(out myParam))`, use **OutArgument** instead of **InOutArgument**

Methods with arguments called **TargetObject** or **Result** can't be invoked using the <xref:System.Activities.Statements.InvokeMethod> activity. The reason for this is that <xref:System.Activities.Statements.InvokeMethod> activity registers the <xref:System.Activities.Statements.InvokeMethod.GenericTypeArguments%2A>, <xref:System.Activities.Statements.InvokeMethod.TargetObject%2A> and <xref:System.Activities.Statements.InvokeMethod.Result%2A> in <xref:System.Activities.Activity.CacheMetadata%2A>.

The algorithm for registering the parameters in <xref:System.Activities.Activity.CacheMetadata%2A> is shown in the following list:

1. Register <xref:System.Activities.Statements.InvokeMethod.TargetObject%2A> argument.

2. Register <xref:System.Activities.Statements.InvokeMethod.Result%2A> argument.

3. Iterate through the <xref:System.Activities.Statements.InvokeMethod.Parameters%2A> collection and register each argument.

The resulting exception is of type <xref:System.Activities.InvalidWorkflowException> with the following message: 'InvokeMethod': A variable, RuntimeArgument or a DelegateArgument already exists with the name 'TargetObject'. Names must be unique within an environment scope.

This restriction doesn't apply to <xref:System.Activities.Statements.InvokeMethod.TargetType%2A> and <xref:System.Activities.Statements.InvokeMethod.RunAsynchronously%2A>. They're not workflow arguments and therefore aren't registered in the <xref:System.Activities.Statements.InvokeMethod.GenericTypeArguments%2A> collection of the <xref:System.Activities.Statements.InvokeMethod> activity in the <xref:System.Activities.Activity.CacheMetadata%2A> method.

## See also

- [Primitives](../workflow-designer/primitives-activity-designers.md)
- [Assign](../workflow-designer/assign-activity-designer.md)
- [Delay](../workflow-designer/delay-activity-designer.md)
- [WriteLine](../workflow-designer/writeline-activity-designer.md)

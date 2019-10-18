---
title: "ForEach&lt;T&gt; Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.ForEach`1.UI"
ms.assetid: 67097b3a-fcf5-4a72-beb1-2c7784151a86
caps.latest.revision: 5
author: gewarren
ms.author: gewarren
manager: jillfra
---
# ForEach&lt;T&gt; Activity Designer
The <xref:System.Activities.Statements.ForEach%601> activity executes the activity contained in its <xref:System.Activities.Statements.ForEach%601.Body%2A> for each item in a specified <xref:System.Activities.Statements.ForEach%601.Values%2A> collection.  
  
## ForEach\<T> Properties in the Workflow Designer  
 The following table shows the most useful <xref:System.Activities.Statements.ForEach%601> activity properties and describes how to use them in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.ForEach%601> activity. The default is ForEach\<Int32>. Although the <xref:System.Activities.Activity.DisplayName%2A> value is not strictly required, it is a best practice to use one.|  
|<xref:System.Activities.Statements.ForEach%601.Values%2A>|True|The collection of items to iterate over. To set the <xref:System.Activities.Statements.ForEach%601.Values%2A>, type a [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] expression in the **Values** box on the **ForEach\<T>** activity designer or in the property grid.|  
|*TypeArgument*|True|The type of the items in the <xref:System.Activities.Statements.ForEach%601.Values%2A> collection specified by the generic parameter *T*. By default, *TypeArgument* is set to **Int32**. To change the type, change the value of the *TypeArgument* combo box in the property grid.|  
  
 By default, the loop iterator is named **item**. You can change the name of the iterator variable in the <xref:System.Activities.Statements.ForEach%601> activity designer. The loop iterator can be used in expressions in the children of the <xref:System.Activities.Statements.ForEach%601> activity.  
  
## See also  
 [ParallelForEach\<T>](../workflow-designer/parallelforeach-t-activity-designer.md)   
 [Control Flow](../workflow-designer/control-flow-activity-designers.md)
---
title: "TryCatch Activity Designer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords: 
  - "System.Activities.Statements.TryCatch.UI"
  - "System.Activities.Statements.Catch`1.UI"
ms.assetid: 02a326c2-4009-442f-b7cb-e42121fd2992
caps.latest.revision: 8
author: gewarren
ms.author: gewarren
manager: jillfra
---
# TryCatch Activity Designer
The **TryCatch** activity designer is used to create and configure a <xref:System.Activities.Statements.TryCatch> activity.  
  
## The TryCatch Activity  
 The <xref:System.Activities.Statements.TryCatch> activity contains a <xref:System.Activities.Statements.TryCatch.Try%2A> activity, a collection of **Catch\<TException>** and a <xref:System.Activities.Statements.TryCatch.Finally%2A> activity. A <xref:System.Activities.Statements.Catch%601> of type **TException** contains an <xref:System.Activities.Statements.Catch%601.ExceptionType%2A> and an <xref:System.Activities.Statements.Catch%601.Action%2A>. Together they are used to implement a typical exception-based error handling mechanism. A <xref:System.Activities.Statements.TryCatch> activity tries to execute its <xref:System.Activities.Statements.TryCatch.Try%2A> activity. If the <xref:System.Activities.Statements.TryCatch.Try%2A> activity throws any exception, the <xref:System.Activities.Statements.TryCatch> activity uses its **Catch<TException\>** collection to match the exception. If there is a match, then the <xref:System.Activities.Statements.Catch%601.Action%2A> of the corresponding **Catch\<TException>** is executed, serving as the error handling logic for the exception. If the activities in the <xref:System.Activities.Statements.TryCatch.Try%2A> section successfully complete or the activities in the <xref:System.Activities.Statements.TryCatch.Catches%2A> successfully complete, the <xref:System.Activities.Statements.TryCatch> activity executes its <xref:System.Activities.Statements.TryCatch.Finally%2A> activity. [!INCLUDE[crdefault](../includes/crdefault-md.md)][Exceptions](https://msdn.microsoft.com/library/065205cc-52dd-4f30-9578-b17d8d113136).  
  
### Using the TryCatch Activity Designer  
 The **TryCatch** activity designer can be found in the **Error Handling** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab on the left side of the [!INCLUDE[wfd2](../includes/wfd2-md.md)] (Alternatively, select **Toolbar** from the **View** menu, or CTLR+ALT+X.)  
  
 The **TryCatch** activity designer can be dragged from the **Toolbox** and dropped on to the [!INCLUDE[wfd2](../includes/wfd2-md.md)] surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.TryCatch> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of TryCatch. The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **TryCatch** activity designer or in the **DisplayName** box of the property grid. The other properties must be edited on the surface of the **TryCatch** activity designer.  
  
 Click the expand button on the right top corner of **TryCatch** designer to see the **Try**, **Catches**, and **Finally** boxes in the expanded view. To add a catch, click the **Add new catch** button on **TryCatch** designer. The button changes to a type combo box. Select an exception type and press ENTER to add the catch. After adding a **Catch**, the catch area expands and an activity can be dropped into the catch to define the execution logic for the catch. Note that there is a text box on the right side of the expanded catch area. You can name the exception variable using this text box. The exception variable can only be used for activities within the same **Catch**.  
  
 The **TryCatch** designer does not support editing **Catch**. If you want to change the exception type, you have to delete the **Catch** and add a new one. A **Catch** can be deleted by selecting it and deleting it or by using the **Delete** menu on the context menu accessed by right clicking.  
  
### The TryCatch Properties  
 The following table shows the <xref:System.Activities.Statements.TryCatch>properties and describes how they are used in the designer.  
  
|Property Name|Required|Usage|  
|-------------------|--------------|-----------|  
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.TryCatch> activity. The default is TryCatch.|  
|<xref:System.Activities.Statements.TryCatch.Try%2A>|False|The activity first executed when the <xref:System.Activities.Statements.TryCatch> executes.|  
|<xref:System.Activities.Statements.TryCatch.Catches%2A>|False|The collection of **Catch** elements to be checked when the <xref:System.Activities.Statements.TryCatch.Try%2A> activity throws an exception.<br /><br /> You need at least add one activity in <xref:System.Activities.Statements.TryCatch.Catches%2A> or an activity in the <xref:System.Activities.Statements.TryCatch.Finally%2A> block.|  
|<xref:System.Activities.Statements.TryCatch.Finally%2A>|False|The activity to be executed when the <xref:System.Activities.Statements.TryCatch.Try%2A> and any necessary activities in the <xref:System.Activities.Statements.TryCatch.Catches%2A> collection complete execution.<br /><br /> You need at least add one activity in <xref:System.Activities.Statements.TryCatch.Catches%2A> or an activity in the <xref:System.Activities.Statements.TryCatch.Finally%2A> block.|  
  
## See also  
 [Collection](../workflow-designer/collection-activity-designers.md)   
 [Rethrow](../workflow-designer/rethrow-activity-designer.md)   
 [Throw](../workflow-designer/throw-activity-designer.md)
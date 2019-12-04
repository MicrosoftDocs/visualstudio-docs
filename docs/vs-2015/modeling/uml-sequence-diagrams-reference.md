---
title: "UML Sequence Diagrams: Reference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.teamarch.sequencediagram.diagram"
  - "vs.teamarch.UMLModelExplorer.sequencediagram"
  - "vs.teamarch.sequencediagram.toolbox"
helpviewer_keywords:
  - "diagrams - modeling, sequence"
  - "sequence diagrams"
  - "UML diagrams, sequence"
  - "diagrams - modeling, UML sequence"
  - "UML, sequence diagrams"
ms.assetid: 366fc324-aeeb-4894-bd13-ec2e40754b8e
caps.latest.revision: 43
author: jillre
ms.author: jillfra
manager: jillfra
---
# UML Sequence Diagrams: Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, a *sequence diagram* shows an interaction, which represents the sequence of messages between instances of classes, components, subsystems, or actors. Time flows down the diagram, and it shows the flow of control from one participant to another. Use sequence diagrams to visualize instances and events, instead of classes and methods. More than one instance of the same type can appear on the diagram. More than one occurrence of the same message can also appear.

 UML sequence diagrams are part of a UML model and exist only within UML modeling projects. To create a UML sequence diagram, on the **Architecture** menu, click **New UML or Layer Diagram**. Find out more about how to create and draw [UML sequence diagrams](../modeling/uml-sequence-diagrams-guidelines.md) or [UML modeling diagrams](../modeling/edit-uml-models-and-diagrams.md) in general.

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Reading Sequence Diagrams
 The following table describes the elements that you can see on a sequence diagram. Find out more about these [elements' properties](../modeling/properties-of-elements-on-uml-sequence-diagrams.md).

 ![Parts of a sequence diagram](../modeling/media/uml-sequence.png "UML_Sequence")

|**Shape**|**Element**|**Description**|
|---------------|-----------------|---------------------|
|1|**Lifeline**|A vertical line that represents the sequence of events that occur in a participant during an interaction, while time progresses down the line. This participant can be an instance of a class, component, or actor.|
|2|**Actor**|A participant that is external to the system that you are developing.<br /><br /> You can make an actor symbol appear at the top of a lifeline by setting its **Actor** property.|
|3|**Synchronous message**|The sender waits for a response to a synchronous message before it continues. The diagram shows both the call and the return. Synchronous messages are used to represent ordinary function calls within a program, as well as other kinds of message that behave in the same way.|
|4|**Asynchronous message**|A message that does not require a response before the sender continues. An asynchronous message shows only a call from the sender. Use to represent communication between separate threads or the creation of a new thread.|
|5|**Execution occurrence**|A vertical shaded rectangle that appears on a participant's lifeline and represents the period when the participant is executing an operation.<br /><br /> The execution begins where the participant receives a message. If the initiating message was a synchronous message, the execution ends with a «return» arrow back to the sender.|
|6|**Callback message**|A message that returns back to a participant that is waiting for the return from an earlier call. The resulting execution occurrence appears on top of the existing one.|
|7|**Self message**|A message from a participant to itself. The resulting execution occurrence appears on top of the sending execution.|
|8|**Create message**|A message that creates a participant. If a participant receives a create message, it should be the first it receives.|
|9|**Found message**|An asynchronous message from an unknown or an unspecified participant.|
|10|**Lost message**|An asynchronous message to an unknown or an unspecified participant.|
|11|**Comment**|A comment can be attached to any point on a lifeline.|
|12|**Interaction Use**|Encloses a sequence of messages that are defined in another diagram.<br /><br /> To create an **Interaction Use**, click the tool and then drag across the lifelines you want to include.|
|13|**Combined Fragment**|A collection of fragments. Each fragment can enclose one or more messages. There are different kinds of combined fragments. For more information, see [Describe control flow with fragments on UML sequence diagrams](../modeling/describe-control-flow-with-fragments-on-uml-sequence-diagrams.md).<br /><br /> To create a fragment, right-click a message, point to **Surround With**, and then click a fragment type.|
|14|**Fragment Guard**|Can be used to state a condition relevant to whether the fragment will occur.<br /><br /> To set the guard, select a fragment, then select the guard, and type a value.|
|**X**|**Destruction Event**|Represents the point at which the object is deleted or no longer accessible. Appears at the bottom of every lifeline.|
||**Interaction**|The collection of messages and lifelines that is displayed in the sequence diagram. To view the properties of an Interaction, you must select it in **UML Model Explorer**.|
||**Sequence Diagram**|The diagram that displays an Interaction. To view its properties, click on an empty part of the diagram. **Note:**  The names of the Sequence Diagram, the Interaction that it displays, and the file that contains the diagram can all be different.|

## See Also
 [UML Sequence Diagrams: Guidelines](../modeling/uml-sequence-diagrams-guidelines.md)
 [Edit UML models and diagrams](../modeling/edit-uml-models-and-diagrams.md)
 [UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md)
 [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)
 [UML Component Diagrams: Reference](../modeling/uml-component-diagrams-reference.md)
 [UML Component Diagrams: Reference](../modeling/uml-component-diagrams-reference.md)

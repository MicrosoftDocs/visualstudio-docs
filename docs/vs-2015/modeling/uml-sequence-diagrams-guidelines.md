---
title: "UML Sequence Diagrams: Guidelines | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
f1_keywords:
  - "vs.teamarch.sequencediagram.linktosequencediagram"
  - "vs.teamarch.logicalclassdiagram.createlifeline"
  - "vs.teamarch.componentdiagram.createlifeline"
helpviewer_keywords:
  - "diagrams - modeling, sequence"
  - "sequence diagrams"
  - "UML diagrams, sequence"
  - "interactions, UML"
  - "diagrams - modeling, UML sequence"
  - "UML interactions"
  - "UML, sequence diagrams"
  - "UML sequence diagrams"
  - "behaviors, UML"
ms.assetid: 5990ef7c-ba60-4e20-a36d-e29c1fa6c8bb
caps.latest.revision: 55
author: jillre
ms.author: jillfra
manager: jillfra
---
# UML Sequence Diagrams: Guidelines
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, you can draw a *sequence diagram* to show an interaction. An interaction is a sequence of messages between typical instances of classes, components, subsystems, or actors.

 UML sequence diagrams are part of a UML model and exist only within UML modeling projects. To create a UML sequence diagram, on the **Architecture** menu, click **New UML or Layer Diagram**. Find out more about [UML sequence diagram elements](../modeling/uml-sequence-diagrams-reference.md) or [UML modeling diagrams](../modeling/edit-uml-models-and-diagrams.md) in general. For a video demonstration, see [Sketching Interactions by using Sequence Diagrams (2010)](https://channel9.msdn.com/Blogs/clinted/UML-with-VS-2010-Part-7-Sketching-Interactions-with-Sequence-Diagrams).

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## In this topic
 [Using UML Sequence Diagrams](#Using)

 [Basic Steps for Drawing Sequence Diagrams](#BasicSteps)

 [Creating and Using Simple Sequence Diagrams](#Simple)

 [Classes and Lifelines](#ClassesAndLifelines)

 [Creating Reusable Interaction Sequences](#Multiple)

 [Collapsing Groups of Lifelines](#Collapse)

 [Describing Control Structures with Fragments](#Fragments)

## <a name="Using"></a> Using UML Sequence Diagrams
 You can use sequence diagrams for a variety of purposes at different levels of program detail. Typical occasions for drawing a sequence diagram are as follows:

- If you have a use case diagram that summarizes your system's users and their goals, you can draw sequence diagrams to describe how the main components of the system interact to fulfill the goal of each use case. For more information, see [UML Use Case Diagrams: Guidelines](../modeling/uml-use-case-diagrams-guidelines.md).

- If you have identified messages arriving at an interface of a component, you can draw sequence diagrams to describe how the internal parts of the component interact to achieve the result required for each incoming message. For more information, see [UML Component Diagrams: Guidelines](../modeling/uml-component-diagrams-guidelines.md).

  Drawing sequence diagrams has several benefits:

- You can easily see how tasks are distributed between components.

- You can identify patterns of interaction that make it difficult to update the software.

## Relationship to other diagrams
 You can use UML sequence diagrams together with other diagrams in several ways.

#### Lifelines and types
 The lifelines you draw in a sequence diagram can represent typical instances of the components or classes in your system. You can create lifelines from types, and types from lifelines, and show the types on UML class diagrams and UML component diagrams. For more information, see [Classes and Lifelines](#ClassesAndLifelines).

#### Parameter types
 You can also describe in a UML class diagram the types of parameters and returned values that were used in the messages sent between the lifelines.

#### Use case details
 A use case represents a user's goal, together with a sequence of steps for achieving the goal. The sequence of steps can be described in several ways. One option is to draw a sequence diagram that shows the interactions between the users and the system's major components. For more information, see [UML Use Case Diagrams: Guidelines](../modeling/uml-use-case-diagrams-guidelines.md).

## <a name="BasicSteps"></a> Basic Steps for Drawing Sequence Diagrams
 For a complete list of elements on sequence diagrams, see [UML Sequence Diagrams: Reference](../modeling/uml-sequence-diagrams-reference.md).

> [!NOTE]
> Detailed steps for how to create any of the modeling diagrams are described in [Edit UML models and diagrams](../modeling/edit-uml-models-and-diagrams.md).

#### To create a sequence diagram

1. On the **Architecture** menu, click **New UML or Layer Diagram**.

2. Under **Templates**, click **UML Sequence Diagram**.

3. Name the diagram.

4. In **Add to Modeling Project**, select an existing modeling project in your solution, or **Create a new modeling project**, and then click **OK**.

    A new sequence diagram appears with the **Sequence Diagram** toolbox. The toolbox contains the required elements and connectors.

   ![Parts of a sequence diagram](../modeling/media/uml-sequence.png "UML_Sequence")

#### To draw a sequence diagram

1. Drag **Lifelines** (1) from the **Toolbox** onto the diagram to represent instances of classes, components, actors, or devices.

    > [!NOTE]
    > You can also create a lifeline by dragging an existing class, interface, actor or component from **UML Model Explorer** onto the diagram. This creates a lifeline representing an instance of the chosen type.

2. Draw messages to show how the lifelines collaborate to achieve a specific goal.

     To create a message (3, 4, 6, 7), click a message tool. Then click the sending lifeline at the point where you want the message to start, and then click the receiving lifeline.

     An execution occurrence (5) appears at the receiving lifeline. The execution occurrence represents a period of time during which the instance is executing a method. You can create other messages that start from an execution occurrence.

3. To show a message that comes from an unknown event source (9), or broadcasts to unknown recipients (10), draw an asynchronous message from or to blank space on the diagram. These messages are called *found messages* (9) and *lost messages* (10).

    > [!NOTE]
    > To move a group of lifelines that have lost or found messages, follow these steps to select the lifelines before you move them: Draw a rectangle around those lifelines, or press and hold the **CTRL** key while you click each lifeline. If you use **Select All** or **CTRL**+**A** to select all lifelines, and then move them, any lost or found messages attached to these lifelines will not move. If this scenario occurs, you can move these messages separately.

4. Draw sequence diagrams for each major message to the same component or system.

#### To change the order of messages

- Drag a message up or down in its lifeline. You can drag it over other messages, or into or out of an execution block.

     \- or -

- Click the message and use the **UP ARROW** and **DOWN ARROW** keys to adjust message positions. Use **SHIFT+UP ARROW** and **SHIFT+DOWN ARROW** to change the order of the messages.

#### To move or copy message sequences on the sequence diagram

1. Right-click a message (3, 4) and then click **Copy**.

2. Right-click the execution occurrence (5) or a lifeline (1) from which you want the new message to be sent, and then click **Paste**. The new sender can be on a different diagram if you want.

     A copy of the message and all its subsidiary messages is added to the end of the execution occurrence, or to the end of the lifeline.

    > [!NOTE]
    > The pasted message always appears at the end of the execution occurrence or lifeline. After you have pasted it, you can drag it up to an earlier position.

#### To display and edit the signature text for a message

- The target lifeline must be bound or mapped to types for the signature text to be visible. To accomplish this task, perform one of the following steps:

  - Right-click the lifeline, and then choose **Create Class**.

     -or-

  - Select the lifeline, press **F4**, and then in the **Properties** window, set the **Type** property to an existing type or specify the name for a new type. Right-click the message label, and then choose **Create Operation**.

    The signature text appears below the message label. You can now edit the signature text. For more information, see [Classes and Lifelines](#ClassesAndLifelines).

#### To improve the layout of a sequence diagram

- Right-click a blank part of the diagram, and then click **Rearrange Layout**.

- To undo the operation, click **Edit**, and then click **Undo**.

#### To change the package that owns the interaction

1. In **UML Model Explorer**, find the Interaction that the sequence diagram displays.

    > [!NOTE]
    > The interaction will not appear in **UML Model Explorer** until you add the first lifeline to the sequence diagram.

2. Drag the Interaction into the Package.

     \- or -

     Right-click the Interaction, and then click **Cut**. Right-click the Package, and then click **Paste**.

## <a name="Simple"></a> Creating and Using Simple Sequence Diagrams
 The simplest and most widely-used form of sequence diagram contains just lifelines and messages. A diagram of this kind lets you show clearly a typical sequence of interactions between objects in your design, or between your system and its users. This is frequently enough to help you discuss and communicate your design.

 Here are some things to consider when you draw a simple sequence diagram.

### Types of message
 There are three tools that you can use to create messages.

- Use the **Synchronous** tool to describe an interaction in which the sender waits for the receiver to return a response (3).

     A **<\<return>>** arrow will be shown at the end of the execution occurrence. It indicates return of control to the sender.

- Use the **Asynchronous** tool to describe an interaction in which the sender can continue immediately without waiting for the receiver (4).

- Use the **Create** tool to describe an interaction in which the sender creates the receiver (8).

     A create message should be the first message that the receiver receives.

### Annotating the interactions
 To describe more detail about the sequence, you can place a **Comment** anywhere on the diagram.

 Using **Comment Links**, you can link a comment to lifelines, executions, interaction uses, and fragments.

> [!CAUTION]
> When you want to attach a comment to a particular point in the sequence, link it to an execution occurrence, interaction use, or fragment. Do not link it to a lifeline, because in that case, it does not remain attached at the correct point in the sequence.

 Use a comment to:

- Note what has been achieved at key points in the sequence. This helps readers to see the objectives of the interactions.

- Describe the overall objective of the whole sequence. Attach the comment to the initial execution occurrence or leave it unattached. For example, "Customer has chosen items from the menu and has been given a price."

- Describe the responsibilities of each lifeline. Attach the comment to the lifeline. For example, "Ordering Manager collects the customer's menu choices."

- Note exceptions or alternatives that might be performed as an alternative to the typical sequence shown. For example "Customer can choose to skip the rest of this sequence."

  - Consider using fragments as a more formal alternative to this kind of note. See [Describing Control Structures with Fragments](#Fragments)

## Deciding the Scope of the Diagram
 It is important to be clear about what the diagram is intended to show.

#### Initiating event
 Each diagram should show the sequence of interactions that results from one initiating event. This might be, for example:

- A user initiating a use case, for example, opening the Web page for buying a meal.

- A message from one system component to another, for example, querying the availability of items that a customer wants to buy.

- An event triggered by a change of state, for example, stocks of an item falling below a threshold.

#### Level of detail
 Sequence diagrams can show different levels of detail. You can decide the level of detail in two separate dimensions almost independently:

 Lifelines can represent one of these levels of detail:

- Objects in the program code, which either exists, or you are developing.

- Components or their subcomponents, usually omitting facades, proxies, and other connective mechanisms.

- Your system and external actors

  Messages can represent one of these levels of detail:

- Software messages in the program code, at an API, or Web interface.

- Transactions or sub-transactions, for example, between users and the system, or between code and database.

- Use cases - major interactions between users and the system.

  Whether you are exploring existing code or describing a new design, it is frequently useful to draw and discuss the less detailed views.

## Describing variations
 The diagram shows a single, typical sequence of events. If you want to show alternative possibilities such as failure scenarios, you can either use either of these options:

- Draw separate sequence diagrams to describe those scenarios

- Use [Describing Control Structures with Fragments](#Fragments) to show loops, alternatives, and so on.

## Assessing the Design
 You can use the diagram to assess the distribution of tasks between its objects or components. Consider refactoring if you see these patterns:

- One lifeline seems to do everything, making calls to everything else, whereas the other lifelines just respond passively.

- Many messages cross lifelines. Each lifeline should send messages to just a few neighbors, and should not communicate with its neighbors' neighbors. It should usually be possible to arrange the lifelines so that there are only a few places where messages cross lifelines; and where there are crossings, the target lifeline should not also exchange messages that have the crossed lifelines.

- Some lifelines seem to handle more than one kind of task. It should easy to find one succinct sentence that describes the responsibilities of each lifeline, summarizing the work it does in response to each message that it receives.

## <a name="ClassesAndLifelines"></a> Classes and Lifelines
 The lifelines in your sequence diagrams show instances of classes or component interfaces. You can name a lifeline in two ways:

|**For this purpose**|**Use this format**|
|--------------------------|-------------------------|
|Anonymous instance of a type.<br /><br /> Use this if you have only one lifeline of each type.|*typeName*|
|Named instance of a type.<br /><br /> Use this if you want to show a sequence that involves more than one instance of the same type.|*objectName*:*typeName*|

### Creating Lifelines from Types
 You can create new lifelines from classes that you have already defined, for example on a class diagram.

> [!NOTE]
> Make sure you have an existing sequence diagram before you perform this task.

##### To create a lifeline from an existing type

- Drag a class, component, or interface from UML Model Explorer onto a sequence diagram.

   \- or -

  1. Right-click the class, component, or interface on its respective diagram, and then click **Create Lifeline**.

  2. In the **Create Lifeline** dialog box, select a sequence diagram, and then click **OK**.

     A new named-instance lifeline appears whose type is the type you dragged.

  > [!NOTE]
  > You can repeat this action as many times as you like. This will create lifelines with different instance names.

##### To change the type of a lifeline

1. Right-click a lifeline, and then click **Properties**.

2. In the **Properties** window, set the **Type** property. You can either select a type from the drop-down menu, or type a new name.

### Creating Classes from Lifelines
 When you have created one or more sequence diagrams, you can summarize the lifelines by creating classes or interfaces from them.

##### To create a class or interface from a lifeline

1. Right-click the lifeline, and then click **Create Class** or **Create Interface**.

     A new class or interface appears in UML Model Explorer.

2. Create operations in the class or interface for each message that the lifeline receives:

    1. Select all the messages that you want to include.

    2. Right-click one of the messages, and then click **Create Method**.

         The new class or interface has operations for each selected message.

         The operation name appears below each message arrow, and in the **Operation** property of the message.

         If your message included parameters in the form "(parameter : type)", they will appear in the parameter list of the new operation.

        > [!NOTE]
        > You must repeat this step if you add new messages in the sequence diagram.

3. To view the new class or interface in detail, add it to a class or component diagram.

    1. Open or create a class or component diagram.

    2. Drag the new class or interface from **UML Model Explorer** to a class diagram.

         The class or interface appears in the class diagram.

         \- or -

    3. Drag the new interface from **UML Model Explorer** onto a component or port in a component diagram.

         The interface appears on the component as a lollipop.

### Creating classes for parameters
 You can include parameters in the messages on a sequence diagram. You can use a UML class diagram to describe the parameter types.

## <a name="Multiple"></a> Creating Reusable Interaction Sequences
 You can use a separate diagram to describe a sequence that contains detail that you want to separate out, or that is common between several diagrams.

 You can create an Interaction Use rectangle (12) on one diagram that points to the details in another diagram.

 Double-click an Interaction Use to open the sequence diagram that is linked to it.

#### To create a reusable interaction sequence from existing lifelines

1. In the **Toolbox**, click **Interaction Use**.

2. On the sequence diagram, hold the mouse button down while you drag across the lifelines that you want to include in the reusable sequence. Start at the vertical position where you want to insert the interaction use.

     An interaction use appears across the selected lifelines on the sequence diagram.

3. Double-click the name on the interaction use, and rename it to describe the effect of the reusable sequence in this diagram.

     \- or -

     Write the name like a function call, with parameters.

4. Link the interaction use to another sequence diagram. Right-click the interaction use, and then either:

     Click **Create New Sequence** to create a new sequence diagram

     \- or -

     Click **Link to Sequence** to link to an existing diagram.

     Visual Studio creates a link between the interaction use and the new interaction sequence.

     A new sequence diagram appears in your solution. It contains the lifelines that you used to create the interaction use.

    > [!NOTE]
    > Only the lifelines you used to create the interaction use will be included. The new diagram will not include lifelines that you created after the interaction use, even if the interaction use now covers them.

#### To create a reusable sequence from existing messages

- Right-click the message that you want to move, and then click **Move to Diagram**.

  Visual Studio:

  - Replaces with an interaction use the selected message and any subsidiary messages.

  - Moves the replaced messages to a new sequence diagram.

  - Creates a link between the interaction use and the new sequence diagram.

#### To navigate to the sequence referenced by an interaction use

- Double-click the interaction use.

     \- or -

     Right-click the interaction use and then click **Go to Sequence**.

### Creating a Placeholder with an Interaction Use
 You can create an interaction use without linking it to another diagram. You can use this as a placeholder for a part of the sequence whose details are yet to be worked out. Use the name of the interaction use to indicate the outcome that you want.

## <a name="Collapse"></a> Collapsing Groups of Lifelines
 You can collapse a set of lifelines together, so that the group appears as one lifeline. This helps you visualize a group of objects as a single component. Messages and interaction uses between lifelines in a collapsed group are hidden. Messages and interaction sequences that include other lifelines are shown.

#### To collapse a group of lifelines together

1. Select two or more lifelines.

2. Right-click one of them, and then click **Collapse**.

     The separate lifelines are replaced by a single lifeline.

     Messages and interaction uses that involve only members of the group are hidden.

3. To rename the group, click the name.

    > [!NOTE]
    > The group name will be lost when you expand the group.

#### To expand a collapsed group

- Right-click the collapsed lifeline, and then click **Expand**.

    > [!NOTE]
    > The name of the group will be lost, together with any links from the group to comments or work items.

## <a name="Fragments"></a> Describing Control Structures with Fragments
 You can use combined fragments (13) to define loops, branches and concurrent processing in a sequence diagram. Alternatively, consider using an activity diagram instead. The activity diagram is not as useful at showing messages between actors, but in some cases is better at showing loops, branches, and concurrency.

 For a full list of the types of fragment, see [Describe control flow with fragments on UML sequence diagrams](../modeling/describe-control-flow-with-fragments-on-uml-sequence-diagrams.md).

#### To create a combined fragment

1. Select a message, or a sequence of messages all starting on the same execution occurrence or lifeline.

    > [!NOTE]
    > Select the message arrows, not the execution occurrences that the messages point to.

2. Right-click one of the messages, point to **Surround With**, and then click the type of fragment that you require.

     A new fragment appears. It contains the messages that you selected.

     If the combined fragment type allows multiple fragments, an empty fragment also appears.

3. To set the guard of a fragment, right-click the fragment border, and then click **Properties**. Set the **Guard** property.

     The guard is used to define the condition for a branch or a loop.

4. To add a new fragment to a kind that allows multiple fragments, right-click the boundary of a fragment, and point to **Add**. Click either **Interaction Operand Before** or **Interaction Operand After**.

5. To add new messages to a fragment, use the message tools, or copy and paste.

## See Also
 [UML Sequence Diagrams: Reference](../modeling/uml-sequence-diagrams-reference.md)
 [Edit UML models and diagrams](../modeling/edit-uml-models-and-diagrams.md)
 [UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md)
 [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)
 [UML Component Diagrams: Reference](../modeling/uml-component-diagrams-reference.md)
 [UML Component Diagrams: Reference](../modeling/uml-component-diagrams-reference.md)
 [Video: Sketching Interactions by using Sequence Diagrams](https://go.microsoft.com/fwlink/?LinkId=201113)

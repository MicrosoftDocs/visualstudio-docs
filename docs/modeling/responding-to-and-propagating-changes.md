---
title: Responding to and Propagating Changes
description: Learn that when an element is created, deleted, or updated, you can write code that propagates the change to other parts of the model, or to external resources.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- Domain-Specific Language, events
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Respond to and propagate changes

When an element is created, deleted or updated, you can write code that propagates the change to other parts of the model, or to external resources such as files, databases, or other components.

## Reference

As a guideline, consider these techniques in the following order:

|Technique|Scenarios|For more information|
|-|-|-|
|Define a Calculated domain property.|A domain property whose value is calculated from other properties in the model. For example, a price that is the sum of prices of related elements.|[Calculated and Custom Storage Properties](../modeling/calculated-and-custom-storage-properties.md)|
|Define a Custom Storage domain property.|A domain property stored in other parts of the model or externally. For example, you could parse an expression string into a tree in the model.|[Calculated and Custom Storage Properties](../modeling/calculated-and-custom-storage-properties.md)|
|Override change handlers such as OnValueChanging and OnDeleting|Keep different elements in sync, and keep external values in sync with the model.<br /><br /> Constrain values to defined ranges.<br /><br /> Called immediately before and after property value and other changes. You can terminate the change by throwing an exception.|[Domain Property Value Change Handlers](../modeling/domain-property-value-change-handlers.md)|
|Rules|You can define rules that are queued for execution just before the end of a transaction in which a change has happened. They are not executed on Undo or Redo. Use them to keep one part of the store in synch with another.|[Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md)|
|Store Events|The modeling store provides notifications of events such as adding or deleting an element or link, or changing the value of a property. The event is also executed on Undo and Redo. Use store events to update values that are not in the store.|[Event Handlers Propagate Changes Outside the Model](../modeling/event-handlers-propagate-changes-outside-the-model.md)|
|.NET Events|Shapes have event handlers that respond to mouse clicks and other gestures. You have to register for these events for each object. Registration is typically done in an override of InitializeInstanceResources, and must be done for each element.<br /><br /> These events usually occur outside a transaction.|[How to: Intercept a Click on a Shape or Decorator](../modeling/how-to-intercept-a-click-on-a-shape-or-decorator.md)|
|Bounds Rules|A bounds rule is used specifically to constrain the bounds of a shape.|[BoundsRules Constrain Shape Location and Size](/previous-versions/visualstudio/visual-studio-2015/modeling/boundsrules-constrain-shape-location-and-size?preserve-view=true&view=vs-2015)|
|Selection rules|Selection rules specifically constrain what the user can select.|[How to: Access and Constrain the Current Selection](../modeling/how-to-access-and-constrain-the-current-selection.md)|
|OnAssocatedPropertyChanged|Indicate the model elements' states using features of shapes and connectors such as shadow, arrowheads, color, and line widths and style.|[Updating Shapes and Connectors to Reflect the Model](../modeling/updating-shapes-and-connectors-to-reflect-the-model.md)|

## Compare rules and store events

Change notifiers, rules, and events are run when changes occur in a model.

Rules are usually applied at the end transaction in which the change has occurred, and events are applied after changes in a transaction are committed.

Use store events to synchronize the model with objects outside the Store, and rules to maintain consistency within the Store.

- **Creating Custom Rules** You create a custom rule as a derived class from an abstract rule. You must also notify the framework about the custom rule. For more information, see [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).

- **Subscribing to Events** Before you can subscribe to an event, create an event handler and delegate. Then use the <xref:Microsoft.VisualStudio.Modeling.Store.EventManagerDirectory%2A>property to subscribe to the event. For more information, see [Event Handlers Propagate Changes Outside the Model](../modeling/event-handlers-propagate-changes-outside-the-model.md).

- **Undoing Changes** When you undo a transaction, events are raised, but rules are not applied. If a rule changes a value and you undo that change, the value is reset to the original value during the undo action. When an event is raised, you must manually change the value back to its original value. To learn more about transactions and undo, see [How to: Use Transactions to Update the Model](../modeling/how-to-use-transactions-to-update-the-model.md).

- **Passing Event Arguments to Rules and Events** Both events and rules are passed an `EventArgs` parameter that has information about how the model changed.

## Related content

- [How to: Intercept a Click on a Shape or Decorator](../modeling/how-to-intercept-a-click-on-a-shape-or-decorator.md)
- [Writing Code to Customize a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)

---
title: 'Use Transactions to Update the Model'
description: Learn that transactions make sure that changes that were made to the store are treated as a group and how to use transactions to update the model.
ms.date: 11/04/2016
ms.topic: how-to
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Use Transactions to Update the Model

Transactions make sure that changes that were made to the store are treated as a group. Changes that are grouped can be committed or rolled back as a single unit.

 Whenever your program code modifies, adds, or deletes any element in the Store in Visual Studio Visualization and Modeling SDK, it must do so inside a transaction. There must be an active instance of <xref:Microsoft.VisualStudio.Modeling.Transaction> associated with the Store when the change happens. This applies to all model elements, relationships, shapes, diagrams, and their properties.

 The transaction mechanism helps you avoid inconsistent states. If an error occurs during a transaction, all the changes are rolled back. If the user performs an Undo command, each recent transaction is treated as a single step. The user cannot undo parts of a recent change, unless you explicitly put them in separate transactions.

## Opening a transaction
 The most convenient method of managing a transaction is with a `using` statement enclosed in a `try...catch` statement:

```csharp
Store store; ...
try
{
  using (Transaction transaction =
    store.TransactionManager.BeginTransaction("update model"))
    // Outermost transaction must always have a name.
  {
    // Make several changes in Store:
    Person p = new Person(store);
    p.FamilyTreeModel = familyTree;
    p.Name = "Edward VI";
    // end of changes to Store

    transaction.Commit(); // Don't forget this!
  } // transaction disposed here
}
catch (Exception ex)
{
  // If an exception occurs, the Store will be
  // rolled back to its previous state.
}
```

 If an exception that prevents the final `Commit()` occurs during the changes, the Store will be reset to its previous state. This helps you make sure that errors do not leave the model in an inconsistent state.

 You can make any number of changes inside one transaction. You can open new transactions inside an active transaction. The nested transactions must commit or roll back before the containing transaction ends. For more information, see the example for the <xref:Microsoft.VisualStudio.Modeling.Transaction.TransactionDepth%2A> property.

 To make your changes permanent, you should `Commit` the transaction before it is disposed. If an exception occurs that is not caught inside the transaction, the Store will be reset to its state before the changes.

## Rolling back a transaction
 To ensure that the Store remains in or reverts to its state before the transaction, you can use either of these tactics:

1. Raise an exception that is not caught inside the scope of the transaction.

2. Explicitly roll back the transaction:

    ```csharp
    this.Store.TransactionManager.CurrentTransaction.Rollback();
    ```

## Transactions Do Not Affect Non-Store Objects
 Transactions only govern the state of the Store. They cannot undo partial changes that have been made to external items such as files, databases, or objects that you have declared with ordinary types outside the DSL definition.

 If an exception might leave such a change inconsistent with the Store, you should deal with that possibility in the exception handler. One way to make sure that external resources remain synchronized with the Store objects is to couple each external object to an in-store element by using event handlers. For more information, see [Event Handlers Propagate Changes Outside the Model](../modeling/event-handlers-propagate-changes-outside-the-model.md).

## Rules Fire at the End of a Transaction
 At the end of a transaction, before the transaction is disposed, the rules attached to elements in the store are fired. Each rule is a method that is applied to a model element that has changed. For example, there are "fix up" rules that update the state of a Shape when its model element has changed, and which create a Shape when a model element is created. There is no specified firing order. A change made by a rule can fire another rule.

 You can define your own rules. For more information about rules, see [Responding to and Propagating Changes](../modeling/responding-to-and-propagating-changes.md).

 Rules do not fire after an undo, a redo, or a rollback command.

## Transaction Context
 Each transaction has a dictionary in which you can store any information you want:

 `store.TransactionManager`

 `.CurrentTransaction.TopLevelTransaction`

 `.Context.Add(aKey, aValue);`

 This is especially useful for transferring information between rules.

## Transaction state
 In some cases you need to avoid propagating a change if the change is caused by undoing or redoing a transaction. This can happen, for example, if you write a property value handler that can update another value in the Store. Because the undo operation resets all the values in the Store to their previous states, it is not necessary to compute updated values. Use this code:

```csharp
if (!this.Store.InUndoRedoOrRollback) {...}
```

 Rules can fire when the store is initially being loaded from a file. To avoid responding to these changes, use:

```csharp
if (!this.Store.InSerializationTransaction) {...}
```

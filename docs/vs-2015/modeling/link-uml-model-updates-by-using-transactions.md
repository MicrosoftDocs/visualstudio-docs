---
title: "Link UML model updates by using transactions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML API, transactions"
ms.assetid: a1df6c38-a3d1-4a3f-82bc-c8f363ab916e
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# Link UML model updates by using transactions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you define an extension to the UML designers in Visual Studio, you can group several changes into a single transaction called a *linked undo context*. To see which versions of Visual Studio support UML models, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

 By default, each modification that your code makes to a model can be separately undone by the user. For example, if you define a menu command that swaps the names of two UML classes, a user could invoke the command, and then perform a single undo. This would undo the change to one name, but not the other, leaving your model in an unintended state.

 To avoid this, your code can perform a series of changes within a transaction. This makes the changes look like a single change to the user. A subsequent undo command will undo the whole series.

 An additional benefit is that your code can undo a partially-complete set of changes by throwing an exception or by aborting the transaction.

## To group changes into a single transaction
 Ensure your project References include this .NET assembly:

 **Microsoft.VisualStudio.Modeling.Sdk.[version].dll**

 Inside your class, declare an imported property that has type <xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement.ILinkedUndoContext>:

 `using Microsoft.VisualStudio.Modeling.ExtensionEnablement;`

 `...`

 `class … {`

 `[Import]`

 `public ILinkedUndoContext LinkedUndoContext { get; set; }`

 In a method that modifies the model, enclose your changes in a transaction:

 `using (ILinkedUndoTransaction transaction =`

 `LinkedUndoContext.BeginTransaction("my updates"))`

 `{`

 `// code to update model elements or shapes goes here`

 `transaction.Commit();`

 `}`

 Notice the following:

- You must always include `Commit()` at the end of the transaction. If a transaction is disposed without being committed, the transaction will be rolled back. That is, the model will be restored to its state at the start of the transaction.

- If an exception occurs that is not caught inside the transaction, the transaction will be rolled back. It is a frequent pattern to enclose the `using` block of the transaction inside a `try…catch` block.

- You can nest transactions.

- You can provide any non-blank name to `BeginTransaction()`.

- Only the UML Model Store is affected by these transactions. Modeling transactions do not affect: variables, external stores such as files and databases, layer diagrams, and code models.

## Example

```
    using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
    using Microsoft.VisualStudio.Uml.Interfaces;
    using Microsoft.VisualStudio.Uml.Classes;
    using Microsoft.VisualStudio.Uml.Extensions;
    using System.Linq;
    using System.ComponentModel.Composition;
 ...
  [Import]
  public ILinkedUndoContext LinkedUndoContext { get; set; }

  /// <summary>
  /// Swap the names of the currently selected elements.
  /// </summary>
  public void Execute(IMenuCommand command)
  {
    var selectedShapes =
      Context.CurrentDiagram.GetSelectedShapes<IClassifier>();
    if (selectedShapes.Count() < 2) return;
    IClassifier firstElement = selectedShapes.First().Element;
    IClassifier lastElement = selectedShapes.Last().Element;
    string firstName = firstElement.Name;
    // Perform changes inside a transaction so that undo
    // works as a single change.
    using (ILinkedUndoTransaction transaction =
      LinkedUndoContext.BeginTransaction("Swap names"))
    {
        firstElement.Name = lastElement.Name;
        lastElement.Name = firstName;
        transaction.Commit();
    }
 }
```

## See Also
 [Programming with the UML API](../modeling/programming-with-the-uml-api.md)
 [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)
 [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)

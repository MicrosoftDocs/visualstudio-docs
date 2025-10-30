---
title: Customize a domain-specific language
description: Learn how to use custom code to access, modify, or create a model in a domain-specific language (DSL).
ms.date: 06/22/2022
ms.topic: how-to
helpviewer_keywords:
  - "Domain-Specific Language, programming"
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---

# Write code to customize a domain-specific language

This section shows you how to use custom code to access, modify, or create a model in a domain-specific language (DSL).

## Context for writing code for a DSL

There are several contexts in which you can write code that works with a DSL:

- **Custom commands.** You can create a command that users can invoke by right-clicking on the diagram, and which can modify the model. For more information, see [How to: Add a Command to the Shortcut Menu](../modeling/how-to-add-a-command-to-the-shortcut-menu.md).

- **Validation.** You can write code that verifies that the model is in a correct state. For more information, see [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md).

- **Overriding the default behavior.** You can modify many aspects of the code that is generated from DslDefinition.dsl. For more information, see [Overriding and Extending the Generated Classes](../modeling/overriding-and-extending-the-generated-classes.md).

- **Text Transformation.** You can write text templates that contain code that accesses a model and generates a text file, for example to generate program code. For more information, see [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md).

- **Other Visual Studio extensions.** You can write separate VSIX extensions that read and modify models. For more information, see [How to: Open a Model from File in Program Code](../modeling/how-to-open-a-model-from-file-in-program-code.md)

## In-Memory Store

Instances of the classes that you define in *DslDefinition.dsl* are kept in a data structure called the *In-Memory Store* (IMS) or *Store*. The classes you define in a DSL always take a Store as an argument to the constructor. For example, if your DSL defines a class called `Example`:

```csharp
Example element = new Example (theStore);
```

Keeping objects in the Store, instead of just as ordinary objects, provides several benefits.

- **Transactions**. You can group a series of related changes into a transaction:

  ```csharp
  using (Transaction t = store.TransactionManager.BeginTransaction("updates"))
  {
    // make several changes to Store elements here
    t.Commit();
  }
  ```

  If an exception occurs during the changes, so that the final `Commit()` isn't performed, the Store is reset to its previous state. This approach helps you to make sure that errors don't leave the model in an inconsistent state. For more information, see [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md).

- **Binary relationships**. If you define a relationship between two classes, instances at both ends have a property that navigates to the other end. The two ends are always synchronized. For example, if you define a parenthood relationship with roles named *Parents* and *Children*, you could write:

  `John.Children.Add(Mary)`

  Both of the following expressions are now true:

  `John.Children.Contains(Mary)`

  `Mary.Parents.Contains(John)`

  You could also achieve the same effect by writing:

  `Mary.Parents.Add(John)`

  For more information, see [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md).

- **Rules and Events**. You can define rules that fire whenever specified changes are made. Rules are used, for example, to keep shapes on the diagram up to date with the model elements they present. For more information, see [Responding to and Propagating Changes](../modeling/responding-to-and-propagating-changes.md).

- **Serialization**. The Store provides a standard way to serialize the objects it contains to a file. You can customize the rules for serializing and deserializing. For more information, see [Customizing File Storage and XML Serialization](../modeling/customizing-file-storage-and-xml-serialization.md).

## Related content

- [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md)

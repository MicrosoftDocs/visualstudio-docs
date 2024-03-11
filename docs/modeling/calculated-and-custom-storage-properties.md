---
title: Calculated and custom DSL storage properties
description: Learn how all domain properties in a domain-specific language (DSL) can be displayed to the user on the diagram and in your language explorer.
ms.date: 06/22/2022
ms.topic: how-to
helpviewer_keywords:
- Domain-Specific Language, programming domain properties
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---

# Calculated and custom storage properties

All domain properties in a domain-specific language (DSL) can be displayed to the user on the diagram and in your language explorer, and can be accessed by program code. However, properties differ in the way that their values are stored.

## Kinds of domain properties

In the DSL Definition, you can set the *kind* of a domain property, as listed in the following table:

|Domain property kind|Description|
|-|-|
|**Standard** (Default)|A domain property that is saved in the *store* and serialized to file.|
|**Calculated**|A read-only domain property that isn't saved in the store, but is calculated from other values. For example, `Person.Age` could be calculated from `Person.BirthDate`. You have to provide the code that performs the calculation. Typically, you calculate the value from other domain properties. However, you can also use external resources.|
|**Custom Storage**|A domain property that isn't saved directly in the store, but can be both get and set. You have to provide the methods that get and set the value. For example, `Person.FullAddress` could be stored in `Person.StreetAddress`, `Person.City`, and `Person.PostalCode`. You can also access external resources, for example to get and set values from a database. Your code shouldn't set values in the store when `Store.InUndoRedoOrRollback` is true. See [Transactions and Custom Setters](#setters).|

## Providing code for a storage property

If you set the kind of a domain property to *calculated* or *custom storage*, you have to provide access methods. When you build your solution, an error report tells you what is required.

### To define a calculated or custom storage property

1. In *DslDefinition.dsl*, select the domain property either in the diagram or in **DSL Explorer**.

1. In the **Properties** window, set the **Kind** field to **Calculated** or **Custom Storage**.

   Make sure that you have also set its **Type** to what you want.

1. Select **Transform All Templates** in the toolbar of **Solution Explorer**.

1. On the **Build** menu, select **Build Solution**.

   You receive the following error message: "\<YourClass> doesn't contain a definition for Get\<YourProperty>."

1. Double-click the error message.

   *Dsl\GeneratedCode\DomainClasses.cs* or *DomainRelationships.cs* opens. Above the highlighted method call, a comment prompts you to provide an implementation for Get\<YourProperty>().

    > [!NOTE]
    > This file is generated from *DslDefinition.dsl*. If you edit this file, your changes are lost the next time that you select **Transform All Templates**. Instead, add the required method in a separate file.

1. Create or open a class file in a separate folder, for example *CustomCode\\\<YourDomainClass>*.cs.

   Make sure that the namespace is the same as in the generated code.

1. In the class file, write a partial implementation of the domain class. In the class, write a definition for the missing `Get` method that resembles the following example:

    ```csharp
    namespace Company.FamilyTree
    {  
      public partial class Person
      {
        int GetAgeValue()
        {
          return System.DateTime.Today.Year - this.BirthYear;
        }
      }
    }
    ```

1. If you set **Kind** to **Custom Storage**, you also have to provide a `Set` method. For example:

    ```csharp
    void SetAgeValue(int value)
    {
      if (!Store.InUndoRedoOrRollback) this.BirthYear = System.DateTime.Today.Year - value;
    }
    ```

    Your code shouldn't set values in the store when `Store.InUndoRedoOrRollback` is true. See [Transactions and Custom Setters](#setters).

1. Build and run the solution.

1. Test the property. Make sure that you try **Undo** and **Redo**.

## <a name="setters"></a> Transactions and Custom Setters

In the `set` method of Custom Storage property, you don't have to open a transaction. The method is usually called inside an active transaction.

However, the `set` method might also be called if the user invokes **Undo** or **Redo**, or if a transaction is being rolled back. When <xref:Microsoft.VisualStudio.Modeling.Store.InUndoRedoOrRollback%2A> is true, your `set` method should behave as follows:

- It shouldn't make changes in the store, such as assigning values to other domain properties. The undo manager sets their values.

- However, it should update any external resources, such as database or file contents, or objects outside the store. This approach makes sure that they're kept in synchronism with the values in the store.

  For example:

  ```csharp
  void SetAgeValue(int value)
  {
    // If we are in Undo, no changes to Store objects:
    if (!this.Store.InUndoRedoOrRollback)
    {
      this.BirthYear = System.DateTime.Today.Year - value;
    }
    // But always update external objects:
    System.IO.File.WriteAllText(AgeFile, value);
  }
  ```

For more information about transactions, see [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md).

## Related content

- [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md)
- [Properties of Domain Properties](../modeling/properties-of-domain-properties.md)
- [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)

---
title: "Calculated and Custom Storage Properties | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language, programming domain properties"
ms.assetid: 42b785f9-2b0f-4f13-a6b4-246e5e0d477a
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Calculated and Custom Storage Properties
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

All domain properties in a domain-specific language (DSL) can be displayed to the user on the diagram and in your language explorer, and can be accessed by program code. However, properties differ in the way that their values are stored.

## Kinds of Domain Properties
 In the DSL Definition, you can set the **Kind** of a domain property, as listed in the following table:

|Domain Property Kind|Description|
|--------------------------|-----------------|
|**Standard** (Default)|A domain property that is saved in the *store* and serialized to file.|
|**Calculated**|A read-only domain property that is not saved in the store, but is calculated from other values.<br /><br /> For example, `Person.Age` could be calculated from `Person.BirthDate`.<br /><br /> You have to provide the code that performs the calculation. Typically, you calculate the value from other domain properties. However, you can also use external resources.|
|**Custom Storage**|A domain property that is not saved directly in the store, but can be both get and set.<br /><br /> You have to provide the methods that get and set the value.<br /><br /> For example, `Person.FullAddress` could be stored in `Person.StreetAddress`, `Person.City`, and `Person.PostalCode`.<br /><br /> You can also access external resources, for example to get and set values from a database.<br /><br /> Your code should not set values in the store when `Store.InUndoRedoOrRollback` is true. See [Transactions and Custom Setters](#setters).|

## Providing the code for a calculated or custom storage property
 If you set the Kind of a domain property to Calculated or Custom Storage, you have to provide access methods. When you build your solution, an error report will tell you what is required.

#### To define a Calculated or Custom Storage Property

1. In DslDefinition.dsl, select the domain property either in the diagram or in **DSL Explorer**.

2. In the **Properties** window, set the **Kind** field to **Calculated** or **Custom Storage**.

     Make sure that you have also set its **Type** to what you want.

3. Click **Transform All Templates** in the toolbar of **Solution Explorer**.

4. On the **Build** menu, click **Build Solution**.

     You receive the following error message: "*YourClass* does not contain a definition for Get*YourProperty*."

5. Double-click the error message.

     Dsl\GeneratedCode\DomainClasses.cs or DomainRelationships.cs opens. Above the highlighted method call, a comment prompts you to provide an implementation for Get*YourProperty*().

    > [!NOTE]
    > This file is generated from DslDefinition.dsl. If you edit this file, your changes will be lost the next time that you click **Transform All Templates**. Instead, add the required method in a separate file.

6. Create or open a class file in a separate folder, for example CustomCode\\*YourDomainClass*.cs.

     Make sure that the namespace is the same as in the generated code.

7. In the class file, write a partial implementation of the domain class. In the class, write a definition for the missing `Get` method that resembles the following example:

    ```
    namespace Company.FamilyTree
    {  public partial class Person
       {  int GetAgeValue()
          { return System.DateTime.Today.Year - this.BirthYear; }
    }  }
    ```

8. If you set **Kind** to **Custom Storage**, you will also have to provide a `Set` method. For example:

    ```
    void SetAgeValue(int value)
    { if (!Store.InUndoRedoOrRollback)
        this.BirthYear =
            System.DateTime.Today.Year - value; }
    ```

     Your code should not set values in the store when `Store.InUndoRedoOrRollback` is true. See [Transactions and Custom Setters](#setters).

9. Build and run the solution.

10. Test the property. Make sure that you try **Undo** and **Redo**.

## <a name="setters"></a> Transactions and Custom Setters
 In the Set method of Custom Storage property, you do not have to open a transaction, because the method is usually called inside an active transaction.

 However, the Set method might also be called if the user invokes Undo or Redo, or if a transaction is being rolled back. When <xref:Microsoft.VisualStudio.Modeling.Store.InUndoRedoOrRollback%2A> is true, your Set method should behave as follows:

- It should not make changes in the store, such as assigning values to other domain properties. The undo manager will set their values.

- However, it should update any external resources, such as database or file contents, or objects outside the store. This will make sure that they are kept in synchronism with the values in the store.

  For example:

```
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

## See Also
 [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md)
 [Properties of Domain Properties](../modeling/properties-of-domain-properties.md)
 [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)

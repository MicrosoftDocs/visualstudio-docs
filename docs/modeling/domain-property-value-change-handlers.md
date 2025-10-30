---
title: Domain Property Value Change Handlers
description: Learn about domain property value change handlers that can be used in a Visual Studio domain-specific language.
ms.date: 03/22/2018
ms.topic: article
helpviewer_keywords:
- Domain-Specific Language, overriding event handlers
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Domain property value change handlers

In a Visual Studio domain-specific language, when the value of a domain property changes, the `OnValueChanging()` and `OnValueChanged()` methods are invoked in the domain property handler. To respond to the change, you can override these methods.

## Override the Property Handler methods

Each domain property of your domain-specific language is handled by a class that is nested inside its parent domain class. Its name follows the format *PropertyName*PropertyHandler. You can inspect this property handler class in the file **Dsl\Generated Code\DomainClasses.cs**. In the class, `OnValueChanging()` is called immediately before the value changes, and `OnValueChanged()` is called immediately after the value changes.

For example, suppose you have a domain class named `Comment` that has a string domain property named `Text` and an integer property named `TextLengthCount`. To cause `TextLengthCount` always to contain the length of the `Text` string, you could write the following code in a separate file in the Dsl project:

```csharp
// Domain Class "Comment":
public partial class Comment
{
  // Domain Property "Text":
  partial class TextPropertyHandler
  {
    protected override void OnValueChanging(CommentBase element, string oldValue, string newValue)
    {
      base.OnValueChanging(element, oldValue, newValue);

      // To update values outside the Store, write code here.

      // Let the transaction manager handle undo:
      Store store = element.Store;
      if (store.InUndoRedoOrRollback || store.InSerializationTransaction) return;

      // Update values in the Store:
      this.TextLengthCount = newValue.Length;
    }
  }
}
```

Notice the following points about property handlers:

- The property handler methods are called both when the user makes changes to a domain property, and when program code assigns a different value to the property.

- The methods are called only when the value actually changes. The handler is not invoked if program code assigns a value that is equal to the current value.

- Calculated and custom storage domain properties do not have OnValueChanged and OnValueChanging methods.

- You cannot use a change handler to modify the new value. If you want to do that, for example to restrict the value to a particular range, define a `ChangeRule`.

- You cannot add a change handler to a property that represents a role of a relationship. Instead, define an `AddRule` and a `DeleteRule` on the relationship class. These rules are triggered when the links are created or changed. For more information, see [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).

### Changes in and out of the store

Property handler methods are called inside the transaction that initiated the change. Therefore, you can make more changes in the store without opening a new transaction. Your changes might result in additional handler calls.

When a transaction is being undone, redone, or rolled back, you should not make changes in the store,  that is, changes to model elements, relationships, shapes, connectors  diagrams, or their properties.

Furthermore, you would usually not update values when the model is being loaded from the file.

Changes to the model should therefore be guarded by a test like this:

```csharp
if (!store.InUndoRedoOrRollback && !store. InSerializationTransaction)
{
   this.TextLength = ...; // in-store changes
}
```

By contrast, if your property handler propagates changes outside the store,  for example, to a file, database, or non-store variables, then you should always make those changes so that the external values are updated when the user invokes undo or redo.

### Cancel a change

If you want to prevent a change, you can roll back the current transaction. For example, you might want to ensure that a property remains within a specific range.

```csharp
if (newValue > 10)
{
   store.TransactionManager.CurrentTransaction.Rollback();
   System.Windows.Forms.MessageBox.Show("Value must be less than 10");
}
```

### Alternative technique: Calculated Properties

The previous example shows how OnValueChanged() can be used to propagate values from one domain property to another. Each property has its own stored value.

Instead, you could consider defining the derived property as a Calculated property. In that case, the property has no storage of its own, and is defining function is evaluated whenever its value is required. For more information, see [Calculated and Custom Storage Properties](../modeling/calculated-and-custom-storage-properties.md).

Instead of the previous example, you could set the **Kind** field of `TextLengthCount` to be **Calculated** in the DSL Definition. You would provide your own **Get** method for this domain property. The **Get** method would return the current length of the `Text` string.

However, a potential drawback of calculated properties is that the expression is evaluated every time the value is used, which might present a performance problem. Also, there is no OnValueChanging() and OnValueChanged() on a calculated property.

### Alternative technique: Change Rules

If you define a ChangeRule, it is executed at the end of a transaction in which a property's value changes.  For more information, see [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).

If several changes are made in one transaction, the ChangeRule executes when they are all complete. By contrast, the OnValue... methods are executed when some of the changes have not been performed. Depending on what you want to achieve, this might make a ChangeRule more appropriate.

You can also use a ChangeRule to adjust the property's new value to keep it within a specific range.

> [!WARNING]
> If a rule makes changes to the store content, other rules and property handlers might be triggered. If a rule changes the property that triggered it, it will be called again. You must make sure that your rule definitions do not result in endless triggering.

```csharp
using Microsoft.VisualStudio.Modeling;
...
// Change rule on the domain class Comment:
[RuleOn(typeof(Comment), FireTime = TimeToFire.TopLevelCommit)]
class MyCommentTrimRule : ChangeRule
{
  public override void
    ElementPropertyChanged(ElementPropertyChangedEventArgs e)
  {
    base.ElementPropertyChanged(e);
    Comment comment = e.ModelElement as Comment;

    if (comment.Text.StartsWith(" ") || comment.Text.EndsWith(" "))
      comment.Text = comment.Text.Trim();
    // If changed, rule will trigger again.
  }
}

// Register the rule:
public partial class MyDomainModel
{
 protected override Type[] GetCustomDomainModelTypes()
 { return new Type[] { typeof(MyCommentTrimRule) };
 }
}
```

## Example

### Description

The following example overrides the property handler of a domain property and notifies the user when a property for the `ExampleElement` domain class has changed.

### Code

```csharp
using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;

namespace msft.FieldChangeSample
{
  public partial class ExampleElement
  {
    internal sealed partial class NamePropertyHandler
    {
      protected override void OnValueChanged(ExampleElement element,
         string oldValue, string newValue)
      {
        if (!this.Store.InUndoRedoOrRollback)
        {
           // make in-store changes here...
        }
        // This part is called even in undo:
        System.Windows.Forms.MessageBox.Show("Value Has Changed");
        base.OnValueChanged(element, oldValue, newValue);
      }
    }
  }
}
```

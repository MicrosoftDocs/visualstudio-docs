---
title: Overriding and Extending the Generated Classes
description: Learn how your DSL Definition is a platform on which you can build a powerful set of tools that are based on a domain-specific language.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- Domain-Specific Language, providing overridable classes
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Override and extend the generated classes

Your DSL Definition is a platform on which you can build a powerful set of tools that are based on a domain-specific language. Many extensions and adaptations can be made by overriding and extending the classes that are generated from the DSL Definition. These classes include not just the domain classes that you have explicitly defined in the DSL Definition diagram, but also other classes that define the toolbox, explorer, serialization, and so on.

## Extensibility Mechanisms

Several mechanisms are provided to allow you to extend the generated code.

### Override methods in a partial class

Partial class definitions allow a class to be defined in more than one place. This allows you to separate the generated code from the code that you write yourself. In your manually-written code, you can override classes inherited by the generated code.

For example, if in your DSL Definition you define a domain class named `Book`, you could write custom code that adds override methods:

```csharp
public partial class Book
{
   protected override void OnDeleting()
   {
      MessageBox.Show("Deleting book " + this.Title);
      base.OnDeleting();
   }
}
```

> [!NOTE]
> To override methods in a generated class, always write your code in a file that is separated from the generated files. Typically, the file is contained in a folder that is named CustomCode. If you make changes to the generated code, they will be lost when you regenerate the code from the DSL Definition.

To discover what methods you can override, type **override** in the class, followed by a space. The IntelliSense tooltip will tell you what methods can be overridden.

### Double-Derived Classes

Most of the methods in generated classes are inherited from a fixed set of classes in the Modeling namespaces. However, some methods are defined in the generated code. Ordinarily, this means that you cannot override them; you cannot override in one partial class the methods that are defined in another partial definition of the same class.

Nevertheless, you can override these methods by setting the **Generates Double Derived** flag for the domain class. This causes two classes to be generated, one being an abstract base class of the other. All the method and property definitions are in the base class, and only the constructor is in the derived class.

For example, in the sample Library.dsl, the `CirculationBook` domain class has the `Generates``Double Derived` property set to `true`. The generated code for that domain class contains two classes:

- `CirculationBookBase`, which is an abstract and which contains all the methods and properties.

- `CirculationBook`, which is derived from `CirculationBookBase`. It is empty, except for its constructors.

To override any method, you create a partial definition of the derived class such as `CirculationBook`. You can override both the generated methods and the methods inherited from the modeling framework.

You can use this method with all types of element, including model elements, relationships, shapes, diagrams, and connectors. You can also override methods of other generated classes. Some generated classes such as the ToolboxHelper are always double-derived.

### Custom Constructors

You cannot override a constructor. Even in double-derived classes, the constructor must be in the derived class.

If you want to provide your own constructor, you can do this by setting `Has Custom Constructor` for the domain class in the DSL Definition. When you click **Transform All Templates**, the generated code will not include a constructor for that class. It will include a call to the missing constructor. This causes an error report when you build the solution. Double-click the error report to see a comment in the generated code that explains what you should provide.

Write a partial class definition in a file that is separate from the generated files, and provide the constructor.

### Flagged Extension Points

A flagged extension point is a place in the DSL Definition where you can set a property or a check box to indicate that you will provide a custom method. Custom constructors are one example. Other examples include setting the `Kind` of a domain property to Calculated or Custom Storage or setting the **Is Custom** flag in a connection builder.

In each case, when you set the flag and regenerate the code, a build error will result. Double-click the error to see a comment that explains what you have to provide.

### Rules

The transaction manager allows you to define rules that run before the end of a transaction in which a designated event has occurred, such as a change in a property. Rules are typically used to maintain synchronism between different elements in the store. For example, rules are used to make sure that the diagram displays the current state of the model.

Rules are defined on a per-class basis, so that you do not have to have code that registers the rule for each object. For more information, see [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).

### Store Events

The modeling store provides an event mechanism that you can use to listen for specific types of change in the store, including addition and deletion of elements, changes to property values, and so on. The event handlers are called after the close of the transaction in which the changes were made. Typically, these events are used to update resources outside the store.

### .NET Events

You can subscribe to some events on shapes. For example, you can listen for mouse-clicks on a shape. You have to write code that subscribes to the event for each object. This code can be written in an override of InitializeInstanceResources().

Some events are generated on ShapeFields, which are used to draw decorators on a shape. For an example, see [How to: Intercept a Click on a Shape or Decorator](../modeling/how-to-intercept-a-click-on-a-shape-or-decorator.md).

These events usually do not occur inside a transaction. You should create a transaction if you want to make changes in the store.

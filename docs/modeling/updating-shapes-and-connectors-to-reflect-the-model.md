---
title: Updating Shapes and Connectors to Reflect the Model
description: Learn that in a domain-specific language in Visual Studio, you can make the appearance of a shape reflect the state of the underlying model.
ms.date: 11/04/2016
ms.topic: how-to
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Update Shapes and Connectors to Reflect the Model

In a domain-specific language in Visual Studio, you can make the appearance of a shape reflect the state of the underlying model.

The code examples in this topic should be added to a `.cs` file in your `Dsl` project. You need these directives in each file:

```csharp
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
```

## Set Shape Map properties to control the visibility of a decorator

You can control the visibility of a decorator without writing program code, by configuring the mapping between the shape and the domain class in the DSL Definition. For more information, see
 [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md).

## Expose the color and style of a shape as properties

In the DSL Definition, right-click the shape class, point to **Add Exposed**, and then click one of the items such as **Fill Color**.

The shape now has a domain property that you can set in program code or as a user. For example, to set it in the program code of a command or rule, you could write:

`shape.FillColor = System.Drawing.Color.Red;`

If you want to make the property variable only under program control, and not by the user, select the new domain property such as **Fill Color** in the DSL Definition diagram. Then, in the Properties window, set **Is Browsable** to `false` or set **Is UI Readonly** to `true`.

## Define Change Rules to make color, style, or location depend on model element properties
 You can define rules that update the appearance the shape dependent on other parts of the model. For example, you could define a Change Rule on a model element that updates the color of its shape dependent on the properties of the model element. For more information about Change Rules, see [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).

 You should use rules only to update properties that are maintained within the Store, because rules are not invoked when the Undo command is performed. This does not include some graphical features such as the size and visibility of a shape. To update those features of a shape, see [Updating Non-Store Graphical features](#OnAssociatedProperty).

 The following example assumes that you have exposed `FillColor` as a domain property as described in the previous section.

```csharp
[RuleOn(typeof(ExampleElement))]
  class ExampleElementPropertyRule : ChangeRule
  {
    public override void ElementPropertyChanged(ElementPropertyChangedEventArgs e)
    {
      base.ElementPropertyChanged(e);
      ExampleElement element = e.ModelElement as ExampleElement;
      // The rule is called for every property that is updated.
      // Therefore, verify which property changed:
      if (e.DomainProperty.Id == ExampleElement.NameDomainPropertyId)
      {
        // There is usually only one shape:
        foreach (PresentationElement pel in PresentationViewsSubject.GetPresentation(element))
        {
          ExampleShape shape = pel as ExampleShape;
          // Replace this with a useful condition:
          shape.FillColor = element.Name.EndsWith("3")
                     ? System.Drawing.Color.Red : System.Drawing.Color.Green;
        }
      }
    }
  }
  // The rule must be registered:
  public partial class OnAssociatedPropertyExptDomainModel
  {
    protected override Type[] GetCustomDomainModelTypes()
    {
      List<Type> types = new List<Type>(base.GetCustomDomainModelTypes());
      types.Add(typeof(ExampleElementPropertyRule));
      // If you add more rules, list them here.
      return types.ToArray();
    }
  }
```

## Use OnChildConfigured to initialize a shape's properties

To set the properties of a shape when it is first created, the override `OnChildConfigured()` in a partial definition of your diagram class. The diagram class is specified in your DSL Definition, and the generated code is in **Dsl\Generated Code\Diagram.cs**. For example:

```csharp
partial class MyLanguageDiagram
{
  protected override void OnChildConfigured(ShapeElement child, bool childWasPlaced, bool createdDuringViewFixup)
  {
    base.OnChildConfigured(child, childWasPlaced, createdDuringViewFixup);
    ExampleShape shape = child as ExampleShape;
    if (shape != null)
    {
      if (!createdDuringViewFixup) return; // Ignore load from file.
      ExampleElement element = shape.ModelElement as ExampleElement;
      // Replace with a useful condition:
      shape.FillColor = element.Name.EndsWith("3")
          ? System.Drawing.Color.Red : System.Drawing.Color.Green;
    }
    // else deal with other types of shapes and connectors.
  }
}
```

This method can be used both for domain properties and non-store features, such as the size of the shape.

## <a name="OnAssociatedProperty"></a> Use AssociateValueWith() to update other features of a shape

For some features of a shape, such as whether it has a shadow, or the arrow style of a connector, there is no built-in method of exposing the feature as a domain property.  Changes to such features are not under the control of the transaction system. Therefore, it is not appropriate to update them using rules, because rules are not invoked when the user performs the Undo command.

Instead, you can update such features by using <xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.OnAssociatedPropertyChanged%2A>. In the following example, the arrow style of a connector is controlled by a value of a domain property in the relationship that the connector displays:

```csharp
public partial class ArrowConnector // My connector class.
{
    /// <summary>
    /// Called whenever a registered property changes in the associated model element.
    /// </summary>
    /// <param name="e"></param>
    protected override void OnAssociatedPropertyChanged(VisualStudio.Modeling.Diagrams.PropertyChangedEventArgs e)
    {
      base.OnAssociatedPropertyChanged(e);
      // Can be called for any property change. Therefore,
      // Verify that this is the property we're interested in:
      if ("IsDirected".Equals(e.PropertyName))
      {
        if (e.NewValue.Equals(true))
        { // Update the shape's built-in Decorator feature:
          this.DecoratorTo = LinkDecorator.DecoratorEmptyArrow;
        }
        else
        {
          this.DecoratorTo = null; // No arrowhead.
        }
      }
    }

    // OnAssociatedPropertyChanged is called only for properties
    // that have been registered using AssociateValueWith().
    // InitializeResources is a convenient place to call this.
    // This method is invoked only once per class, even though
    // it is an instance method.
    protected override void InitializeResources(StyleSet classStyleSet)
    {
      base.InitializeResources(classStyleSet);
      AssociateValueWith(this.Store, Wire.IsDirectedDomainPropertyId);
      // Add other properties here.
    }
}
```

`AssociateValueWith()` should be called one time for each domain property that you want to register. After it has been called, any changes to the specified property will call `OnAssociatedPropertyChanged()` in any shapes that present the property's model element.

It is not necessary to call `AssociateValueWith()` for each instance. Although InitializeResources is an instance method, it is invoked only one time for each shape class.

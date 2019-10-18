---
title: Customizing the Properties Window
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Domain-Specific Language, Properties window"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Customize the Properties window

You can customize the appearance and behavior of the properties window in your domain-specific language (DSL) in Visual Studio. In your DSL Definition, you define domain properties on each domain class. By default, when you select an instance of the class, either on a diagram or in Model Explorer, every domain property is listed in the properties window. This lets you see and edit the values of domain properties, even if you have not mapped them to shape fields on the diagram.

## Names, descriptions, and categories

**Name and Display Name**. In your definition of a domain property, the Display Name of the property is the name that appears at run time in the properties window. By contrast, the Name is used when you write program code to update the property. The Name must be a correct CLR alphanumeric name, but the Display Name can contain spaces.

When you set the Name of a property in the DSL Definition, its Display Name is automatically set to a copy of the Name. If you write a Pascal cased name such as "FuelGauge", the Display Name will automatically contain a space: "Fuel Gauge". However, you can set the Display Name explicitly to another value.

**Description**. The Description of a domain property appears in two places:

- In the bottom of the properties window when the user selects the property. You can use it to explain to the user what the property represents.

- In the generated program code. If you use the documentation facilities to extract API documentation, it will appear as the description of this property in the API.

**Category**. A category is a heading in the Properties window.

## Expose style features

Some of the dynamic features of graphical elements can be represented or *exposed* as domain properties. A feature that has been exposed in this manner can be updated by the user and can more easily be updated by program code.

Right-click a shape class in DSL Definition, point to **Add Exposed**, and then choose a feature.

On shapes you can expose the **FillColor**, **OutlineColor**, **TextColor**, **OutlineDashStyle**, **OutlineThickness** and **FillGradientMode** properties. On connectors you can expose the **Color**`,`**TextColor**, **DashStyle**, and **Thickness** properties. On diagrams you can expose the **FillColor** and **TextColor** properties.

## Forwarding: Display properties of related elements

When the user of your DSL selects an element in a model, that element's properties are displayed in the properties window. However, you can also display the properties of specified related elements. This is useful if you have defined a group of elements that works together. For example, you might define a main element and an optional plug-in element. If the main element is mapped to a shape and the other is not, it is useful to see all their properties as if they were on one element.

This effect is named *property forwarding*, and it happens automatically in several cases. In other cases, you can achieve property forwarding by defining a domain type descriptor.

### Default property forwarding cases

When the user selects a shape or connector, or an element in the Explorer, the following properties are displayed in the Properties window:

- The domain properties that are defined on the domain class of the model element, including those that are defined in base classes. An exception is domain properties for which you have set **Is Browsable** to `False`.

- The names of elements that are linked through relationships that have a multiplicity of 0..1. This provides a convenient method of seeing optionally linked elements, even if you have not defined a connector mapping for the relationship.

- Domain properties of the embedding relationship that targets the element. Because embedding relationships are usually not displayed explicitly, this lets the user see their properties.

- Domain properties that are defined on the selected shape or connector.

### Add property forwarding

To forward a property, you define a domain type descriptor. If you have a domain relationship between two domain classes, you can use a domain type descriptor to set a domain property in the first class to the value of a domain property in the second domain class. For example, if you have a relationship between a **Book** domain class and an **Author** domain class, you can use a domain type descriptor to make the **Name** property of a Book's **Author** appear in the Properties window when the user selects the Book.

> [!NOTE]
> Property forwarding affects only the Properties window when the user is editing a model. It does not define a domain property on the receiving class. If you want to access the forwarded domain property in other parts of the DSL Definition or in program code, you must access the forwarding element.

The following procedure assumes that you have created a DSL. The first few steps summarize the prerequisites.

#### Forward a property from another element

1. Create a [!INCLUDE[dsl](../modeling/includes/dsl_md.md)] solution that contains at least two classes, which in this example are called **Book** and **Author**. There should be a relationship of either kind between **Book** and **Author**.

    The multiplicity of the source role (the role at the **Book** side) should be 0..1 or 1..1, so that each **Book** has one **Author**.

2. In **DSL Explorer**, right-click the **Book** domain class, and then click **Add New DomainTypeDescriptor**.

    A node named **Paths of Custom Property Descriptors** appears under the **Custom Type Descriptor** node.

3. Right-click the **Custom Type Descriptor** node, and then click **Add New PropertyPath**.

    A new property path appears under the **Paths Of Custom Property Descriptors** node.

4. Select the new property path, and in the **Properties** window, set **Path to Property** to the path of the appropriate model element.

    You can edit the path in a tree view by clicking the down arrow to the right of this property. For more information about domain paths, see [Domain Path Syntax](../modeling/domain-path-syntax.md). When you have edited it, the path should resemble **BookReferencesAuthor.Author/!Author**.

5. Set **Property** to the **Name** domain property of **Author**.

6. Set **Display Name** to **Author Name**.

7. Transform All Templates, build and run the DSL.

8. In a model diagram, create a book, an author, and link them using the reference relationship. Select the book element, and in the Properties window you should see Author Name in addition to the properties of the book. Change the name of the linked author, or link the book to a different author, and observe that the Author Name of the book changes.

## Custom property editors

The property window provides an appropriate default editing experience for the type of each domain property. For example, for an enumerated type, the user sees a drop-down list, and for a numeric property, the user can enter digits. This is only true for the built-in types. If you specify an external type, the user will be able to see the property's values, but not edit it.

However, you can specify the following editors and types:

1. Another editor that is used with a standard type. For example, you could specify a file path editor for a string property.

2. An external type for the domain property, and an editor for it.

3. A .NET editor such as the file path editor, or you can create your own custom property editor.

   A conversion between an external type and an type such as String, which has a default editor.

   In a DSL, an *external type* is any type that is not one of the simple types (such as Boolean or Int32) or String.

### Define a domain property that has an external type

1. In **Solution Explorer**, add a reference to the assembly (DLL) that contains the external type, in the **Dsl** project.

    The assembly can be a .NET assembly, or an assembly supplied by you.

2. Add the type to the **Domain Types** list, unless you have already done so.

   1. Open DslDefinition.dsl, and in **DSL Explorer**, right-click the root node, and then click **Add New External Type**.

        A new entry appears under the **Domain Types** node.

       > [!WARNING]
       > The menu item is on the DSL root node, not the **Domain Types** node.

   2. Set the name and the namespace of the new type in the Properties window.

3. Add a domain property to a domain class in the usual manner.

    In the Properties window, select the external type from the drop-down list in the **Type** field.

   At this stage, users can view the values of the property, but they cannot edit it. The displayed values are obtained from the `ToString()` function. You could write program code that sets the value of the property, for example in a command or rule.

### Set a property editor

Add a CLR attribute to the domain property, in the following form:

```csharp
[System.ComponentModel.Editor (
   typeof(AnEditor),
   typeof(System.Drawing.Design.UITypeEditor))]
```

You can set the attribute on a property by using the **Custom Attribute** entry in the Properties window.

The type of `AnEditor` must be derived from the type specified in the second parameter. The second parameter should be either <xref:System.Drawing.Design.UITypeEditor> or <xref:System.ComponentModel.ComponentEditor>. For more information, see <xref:System.ComponentModel.EditorAttribute>.

You can specify your own editor or a .NET editor, such as <xref:System.Windows.Forms.Design.FileNameEditor> or <xref:System.Drawing.Design.ImageEditor>. For example, use the following procedure to have a property in which the user can enter a file name.

#### Define a file name domain property

1. Add a domain property to a domain class in your DSL Definition.

2. Select the new property. In the **Custom Attribute** field in the Properties window, enter the following attribute. To enter this attribute, click the ellipsis **[...]** and then enter the attribute name and the parameters separately:

    ```csharp
    [System.ComponentModel.Editor (
       typeof(System.Windows.Forms.Design.FileNameEditor)
       , typeof(System.Drawing.Design.UITypeEditor))]

    ```

3. Leave the Type of the domain property at its default setting of **String**.

4. To test the editor, verify that users can open the file name editor to edit your domain property.

    1. Press CTRL+F5 or F5. In the debugging solution, open a test file. Create an element of the domain class and select it.

    2. In the Properties window, select the domain property. The value field shows an ellipsis **[...]**.

    3. Click the ellipsis. A file dialog box appears. Select a file and close the dialog box. The file path is now the value of the domain property.

### Define your own property editor

You can define your own editor. You would do this to  allow the user either to edit a type that you have defined, or to edit a standard type in a special way. For example, you could allow the user to input a string that represents a formula.

You define an editor by writing a class that is derived from <xref:System.Drawing.Design.UITypeEditor>. Your class must override:

- <xref:System.Drawing.Design.UITypeEditor.EditValue%2A>, to interact with the user and update the property value.

- <xref:System.Drawing.Design.UITypeEditor.GetEditStyle%2A>, to specify whether your editor will open a dialog or provide a drop-down menu.

You can also provide a graphical representation of the property's value that will be displayed in the property grid. To do this, override `GetPaintValueSupported`, and `PaintValue`.  For more information, see <xref:System.Drawing.Design.UITypeEditor>.

> [!NOTE]
> Add the code in a separate code file in the **Dsl** project.

For example:

```csharp
internal class TextFileNameEditor : System.Windows.Forms.Design.FileNameEditor
{
  protected override void InitializeDialog(System.Windows.Forms.OpenFileDialog openFileDialog)
  {
    base.InitializeDialog(openFileDialog);
    openFileDialog.Filter = "Text files(*.txt)|*.txt|All files (*.*)|*.*";
    openFileDialog.Title = "Select a text file";
  }
}
```

To use this editor, set the **Custom Attribute** of a domain property to:

```csharp
[System.ComponentModel.Editor (
   typeof(MyNamespace.TextFileNameEditor)
   , typeof(System.Drawing.Design.UITypeEditor))]
```

For more information, see <xref:System.Drawing.Design.UITypeEditor>.

## Provide a drop-down list of values

You can provide a list of values for a user to choose from.

> [!NOTE]
> This technique provides a list of values that can change at run time. If you want to provide a list that does not change, consider instead using an enumerated type as the type of your domain property.

To define a list of standard values, you add to your domain property a CLR attribute that has the following form:

```csharp
[System.ComponentModel.TypeConverter
(typeof(MyTypeConverter))]
```

Define a class that derives from <xref:System.ComponentModel.TypeConverter>. Add the code in a separate file in the **Dsl** project. For example:

```csharp
/// <summary>
/// Type converter that provides a list of values
/// to be displayed in the property grid.
/// </summary>
/// <remarks>This type converter returns a list
/// of the names of all "ExampleElements" in the
/// current store.</remarks>
public class MyTypeConverter : System.ComponentModel.TypeConverter
{
  /// <summary>
  /// Return true to indicate that we return a list of values to choose from
  /// </summary>
  /// <param name="context"></param>
  public override bool GetStandardValuesSupported
    (System.ComponentModel.ITypeDescriptorContext context)
  {
    return true;
  }

  /// <summary>
  /// Returns true to indicate that the user has
  /// to select a value from the list
  /// </summary>
  /// <param name="context"></param>
  /// <returns>If we returned false, the user would
  /// be able to either select a value from
  /// the list or type in a value that is not in the list.</returns>
  public override bool GetStandardValuesExclusive
      (System.ComponentModel.ITypeDescriptorContext context)
  {
    return true;
  }

  /// <summary>
  /// Return a list of the values to display in the grid
  /// </summary>
  /// <param name="context"></param>
  /// <returns>A list of values the user can choose from</returns>
  public override StandardValuesCollection GetStandardValues
      (System.ComponentModel.ITypeDescriptorContext context)
  {
    // Try to get a store from the current context
    // "context.Instance"  returns the element(s) that
    // are currently selected i.e. whose values are being
    // shown in the property grid.
    // Note that the user could have selected multiple objects,
    // in which case context.Instance will be an array.
    Store store = GetStore(context.Instance);

    List<string> values = new List<string>();

    if (store != null)
    {
      values.AddRange(store.ElementDirectory
        .FindElements<ExampleElement>()
        .Select<ExampleElement, string>(e =>
      {
        return e.Name;
      }));
    }
    return new StandardValuesCollection(values);
  }

  /// <summary>
  /// Attempts to get to a store from the currently selected object(s)
  /// in the property grid.
  /// </summary>
  private Store GetStore(object gridSelection)
  {
    // We assume that "instance" will either be a single model element, or
    // an array of model elements (if multiple items are selected).

    ModelElement currentElement = null;

    object[] objects = gridSelection as object[];
    if (objects != null && objects.Length > 0)
    {
      currentElement = objects[0] as ModelElement;
    }
    else
    {
        currentElement = gridSelection as ModelElement;
    }

    return (currentElement == null) ? null : currentElement.Store;
  }

}
```

## See also

- [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md)
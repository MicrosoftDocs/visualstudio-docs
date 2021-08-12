---
title: Customizing Text and Image Fields
description: Learn about customizing text and image files. Also learn that when you define a text decorator in a shape, it's represented by a TextField.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
  - "multiple"
---
# Customizing Text and Image Fields
When you define a text decorator in a shape, it is represented by a TextField. For examples of the initialization of TextFields and other ShapeFields, inspect Dsl\GeneratedCode\Shapes.cs in your DSL solution.

 A TextField is an object that manages an area within a shape, such as the space assigned to a label. One TextField instance is shared between many shapes of the same class. The TextField instance does not store the text of the label separately for each instance: instead, the `GetDisplayText(ShapeElement)` method takes the shape as a parameter, and can look up the text dependent on the current state of the shape and its model element.

## How the appearance of a text field is determined
 The `DoPaint()` method is called to displays the field on the screen. You can either override the default `DoPaint(),` or you can override some of the methods that it calls. The following simplified version of the default methods can help you understand how to override the default behavior:

```csharp
// Simplified version:
public override void DoPaint(DiagramPaintEventArgs e, ShapeElement parentShape)
{
  string text = GetDisplayText(shape);
  StringFormat format = GetStringFormat(parentShape);
  Brush brush = GetTextBrush(e.View, shape);
  using (Font font = GetFont(shape))
  {
    e.Graphics.DrawString(text, font, brush, format);
  }
}
// StringFormat determines whether the string is centered etc.
// To customize statically for all instances of this shape field,
// assign to DefaultStringFormat.
// To customize dynamically or per shape, override this:
public virtual StringFormat GetStringFormat(ShapeElement shape)
{ return DefaultStringFormat; }

// Override to customize the displayed string:
public virtual string GetDisplayText(ShapeElement shape)
{ return this.GetValue(shape).ToString(); }

// Brush determines the text color.
// To change the brush for every field, change the shape's styleset.
// To customize to a brush in the style set, override GetTextBrushId.
// To change the brush to non-standard color, override this.
// Should take account of whether selected.
public virtual Brush GetTextBrush(DiagramClientView view, ShapeElement shape)
{ return shape.StyleSet.GetBrush(this.GetTextBrushId(view, shape)); }

// Brush ID selects a brush from a StyleSet.
// Either return a member of DiagramBrushes
// or add your own brush to the shape or application's styleset.
// Override this to change dynamically or per instance.
// To change statically, just assign to default values.
public virtual StyleSetResourceId GetTextBrushId(DiagramClientView view, ShapeElement shape)
{ return IsSelected(view, shape) ? (view.Focused ? DefaultSelectedTextBrushId
: DefaultInactiveSelectedTextBrushId ) : DefaultTextBrushId ;
}

// Font determines the shape and size of the text.
// To change the font for every field, change the shape's styleset.
// To customize to a font in the style set, override GetFontId.
// To change the font to a non-standard font, override this.
public virtual Font GetFont(ShapeElement shape)
{ return shape.StyleSet.GetFont(GetFontId(shape)); }

// Selects a font from a styleset.
// Either return a member of DiagramFonts or
// add your own font to the shape or application's styleset.
// To change statically for all instances of this field,
// assign to DefaultFontId.
// To change per shape or dynamically, override this.
public virtual StyleSetResourceId GetFontId(ShapeElement parentShape)
{ return DefaultFontId; }
```

 There are several other pairs of `Get` methods and `Default` properties, such as `DefaultMultipleLine/GetMultipleLine()`. You can assign a value to the Default property to change the value for all instances of the shape field. To make the value vary from one shape instance to another, or dependent on the state of the shape or its model element, override the `Get` method.

## Static customizations
 If you want to change every instance of this shape field, first find out whether you can set the property in the DSL Definition. For example, you can set font size and style in the Properties window.

 If not, then override the `InitializeShapeFields` method of your shape class, and assign a value to the appropriate `Default...` property of the text field.

> [!WARNING]
> To override `InitializeShapeFields()`, you must set the **Generates Double Derived** property of the shape class to `true` in the DSL Definition.

 In this example, a shape has a text field that will be used for user comments. We want to use the standard comment font. Because it is a standard font from the style set, we can set the default font id:

```csharp

 partial class ExampleShape
{   protected override void InitializeShapeFields(IList<ShapeField> shapeFields)
    {
      // Fields set up according to DSL Definition:
      base.InitializeShapeFields(shapeFields);
      // Find and update comment field:
      TextField commentField = ShapeElement.FindShapeField(shapeFields, "CommentDecorator") as TextField;
      // Use the standard font for comments:
      commentField.DefaultFontId = DiagramFonts.CommentText;
```

## Dynamic customizations
 To make the appearance vary dependent on the state of a shape or its model element, derive your own subclass of `TextField` and override one or more `Get...` methods. You must also override your shape's InitializeShapeFields method, and replace the instance of the TextField with an instance of your own class.

 The following example makes the font of a text field dependent on the state of a Boolean domain property of the shape's model element.

 To run this example code, create a new DSL solution using the Minimal Language template. Add a Boolean domain property `AlternateState` to the ExampleElement domain class. Add an icon decorator to the ExampleShape class, and set its image to a bitmap file. Click **Transform All Templates**. Add a new code file in the DSL project, and insert the following code.

 To test the code, press F5 and, in the debugging solution, open a sample diagram. The default state of the icon should appear. Select the shape and in the Properties window, change the value of the **AlternateState** property. The font of the element name should change.

```csharp
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
...

  partial class ExampleShape
  {
    /// <summary>
    /// Compose a list of the fields in this shape.
    /// Called once for each shape class.
    /// </summary>
    protected override void InitializeShapeFields(IList<ShapeField> shapeFields)
    {
      // Fields set up according to DSL Definition:
      base.InitializeShapeFields(shapeFields);
      // Replace the text field for NameDecorator:
      TextField oldField = ShapeElement.FindShapeField(shapeFields, "NameDecorator") as TextField;
      shapeFields.Remove(oldField);
      // Replace with my text field based on DSL Definition values:
      MyTextField newField = new MyTextField(oldField);
      shapeFields.Add(newField);
    }
  }
  /// <summary>
  /// Dynamic font depends on state of model element.
  /// </summary>
  public class MyTextField : TextField
  {
    public MyTextField(TextField prototype)
      : base(prototype.Name)
    {
      DefaultText = prototype.DefaultText;
      DefaultFocusable = prototype.DefaultFocusable;
      DefaultAutoSize = prototype.DefaultAutoSize;
      AnchoringBehavior.MinimumHeightInLines = prototype.AnchoringBehavior.MinimumHeightInLines;
      AnchoringBehavior.MinimumWidthInCharacters = prototype.AnchoringBehavior.MinimumWidthInCharacters;
      DefaultAccessibleState = prototype.DefaultAccessibleState;
    }

    public override System.Drawing.Font GetFont(ShapeElement parentShape)
    {
      // Access the Boolean domain property of the model element:
      if ((parentShape.ModelElement as ExampleElement).AlternateState)
        return new System.Drawing.Font("Callisto", 14.0f,
               System.Drawing.FontStyle.Italic |
               System.Drawing.FontStyle.Bold);
      else
        return base.GetFont(parentShape);
    }

  }
```

## Style sets
 The preceding example shows how you can change the text field to any font that is available. However, a preferable method is to change it to one of a set of styles that is associated with the shape or with the application. To do this, you override <xref:Microsoft.VisualStudio.Modeling.Diagrams.TextField.GetFontId%2A> or GetTextBrushId().

 Alternatively, consider changing the style set of your shape by overriding <xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.InitializeResources%2A>. This has the effect of changing the fonts and brushes for all of the shape fields.

## Customizing Image Fields
 When you define an image decorator in a shape, and when you define an image shape, the area in which the shape is displayed is managed by an ImageField. For examples of the initialization of ImageFields and other ShapeFields, inspect Dsl\GeneratedCode\Shapes.cs in your DSL solution.

 An ImageField is an object that manages an area within a shape, such as the space assigned to a decorator. One ImageField instance is shared between many shapes of the same shape class. The ImageField instance does not store a separate image for each shape: instead, the `GetDisplayImage(ShapeElement)` method takes the shape as a parameter, and can look up the image dependent on the current state of the shape and its model element.

 If you want special behavior such as a variable image, you can create your own class derived from ImageField.

#### To create a subclass of ImageField

1. Set the **Generates Double Derived** property of the parent shape class in your DSL Definition.

2. Override the `InitializeShapeFields` method of your shape class.

    - Create a new code file in the DSL project, and write a partial class definition for the shape class. Override the method definition there.

3. Inspect the code of `InitializeShapeFields` in DSL\GeneratedCode\Shapes.cs.

     In your override method, call the base method and then create an instance of your own image field class. Use this to replace the regular image field in the `shapeFields` list.

## Dynamic icons
 This example makes an icon change dependent on the state of the shape's model element.

> [!WARNING]
> This example demonstrates how to make a dynamic image decorator. But if you only want to switch between one or two images depending on the state of a model variable, it is simpler to create several image decorators, locate them in the same position on the shape, and then set the Visibility filter to depend on specific values of the model variable. To set this filter, select the shape map in the DSL Definition, open the DSL Details window, and click the Decorators tab.

 To run this example code, create a new DSL solution using the Minimal Language template. Add a Boolean domain property `AlternateState` to the ExampleElement domain class. Add an icon decorator to the ExampleShape class, and set its image to a bitmap file. Click **Transform All Templates**. Add a new code file in the DSL project, and insert the following code.

 To test the code, press F5 and, in the debugging solution, open a sample diagram. The default state of the icon should appear. Select the shape and in the Properties window, change the value of the **AlternateState** property. The icon should then appear rotated through 90 degrees, on that shape.

```csharp
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
...
partial class ExampleShape
{
    /// <summary>
    /// Compose a list of the fields in this shape.
    /// Called once for each shape class.
    /// </summary>
    /// <param name="shapeFields"></param>
    protected override void InitializeShapeFields(IList<ShapeField> shapeFields)
    {
      // Fields set up according to DSL Definition:
      base.InitializeShapeFields(shapeFields);

      // Replace the image field:
      ShapeField oldField = ShapeElement.FindShapeField(shapeFields, "IconDecorator");
      shapeFields.Remove(oldField);
      // Must keep the same name:
      MyImageField newField = new MyImageField(oldField.Name);
      shapeFields.Add(newField);
      newField.DefaultImage = (oldField as ImageField).DefaultImage.Clone() as System.Drawing.Image;
    }
  }

  public class MyImageField : ImageField
  {
    public MyImageField(string tag) : base(tag) { }

    /// <summary>
    /// Get the image for this field in the given shape.
    /// </summary>
    public override System.Drawing.Image GetDisplayImage(ShapeElement parentShape)
    {
      ExampleElement element = parentShape.ModelElement as ExampleElement;
      if (element.AlternateState == true)
        return AlternateImage;
      else
        return base.GetDisplayImage(parentShape);
    }

    private System.Drawing.Image alternateImage;
    public System.Drawing.Image AlternateImage
    {
      get
      {
        if (alternateImage == null)
        {
          // Alternate image is a copy of the default, rotated by 90 degrees:
          alternateImage = this.DefaultImage.Clone() as System.Drawing.Image;
          alternateImage.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
        }
        return alternateImage;
      }
    }
  }
}
```

## See also

- [Defining Shapes and Connectors](../modeling/defining-shapes-and-connectors.md)
- [Setting a Background Image on a Diagram](../modeling/setting-a-background-image-on-a-diagram.md)
- [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md)
- [Writing Code to Customise a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)
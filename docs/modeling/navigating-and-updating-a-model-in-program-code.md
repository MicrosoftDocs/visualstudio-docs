---
title: Navigating and Updating a Model in Program Code
description: Learn how you can write code to create and delete model elements, set their properties, and create and delete links between elements.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Domain-Specific Language, programming domain models
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Navigate and Update a Model in Program Code

You can write code to create and delete model elements, set their properties, and create and delete links between elements. All changes must be made within a transaction. If the elements are viewed on a diagram, the diagram will be "fixed up" automatically at the end of the transaction.

## <a name="example"></a> An Example DSL Definition
 This is the main part of DslDefinition.dsl for the examples in this topic:

 ![DSL Definition diagram &#45; family tree model](../modeling/media/familyt_person.png)

 This model is an instance of this DSL:

 ![Tudor Family Tree Model](../modeling/media/tudor_familytreemodel.png)

### References and Namespaces
 To run the code in this topic, you should reference:

 `Microsoft.VisualStudio.Modeling.Sdk.11.0.dll`

 Your code will use this namespace:

 `using Microsoft.VisualStudio.Modeling;`

 In addition, if you are writing the code in a different project from the one in which your DSL is defined, you should import the assembly that is built by the Dsl project.

## <a name="navigation"></a> Navigating the Model

### Properties
 Domain properties that you define in the DSL definition become properties that you can access in program code:

 `Person henry = ...;`

 `if (henry.BirthDate < 1500) ...`

 `if (henry.Name.EndsWith("VIII")) ...`

 If you want to set a property, you must do so inside a [transaction](#transaction):

 `henry.Name = "Henry VIII";`

 If in the DSL definition, a property's **Kind** is **Calculated**, you cannot set it. For more information, see [Calculated and Custom Storage Properties](../modeling/calculated-and-custom-storage-properties.md).

### Relationships
 Domain relationships that you define in the DSL definition become pairs of properties, one on the class at each end of the relationship. The names of the properties appear in the DslDefinition diagram as labels on the roles at each side of the relationship. Depending on the multiplicity of the role, the type of the property is either the class at the other end of the relationship, or a collection of that class.

 `foreach (Person child in henry.Children) { ... }`

 `FamilyTreeModel ftree = henry.FamilyTreeModel;`

 The properties at opposite ends of a relationship are always reciprocal. When a link is created or deleted, the role properties on both elements are updated. The following expression (which uses the extensions of `System.Linq`) is always true for the ParentsHaveChildren relationship in the example:

 `(Person p) => p.Children.All(child => child.Parents.Contains(p))`

 `&& p.Parents.All(parent => parent.Children.Contains(p));`

 **ElementLinks**. A relationship is also represented by a model element called a *link*, which is an instance of the domain relationship type. A link always has one source element and one target element. The source element and the target element can be the same.

 You can access a link and its properties:

 `ParentsHaveChildren link = ParentsHaveChildren.GetLink(henry, edward);`

 `// This is now true:`

 `link == null || link.Parent == henry && link.Child == edward`

 By default, no more than one instance of a relationship is allowed to link any pair of model elements. But if in the DSL definition, the `Allow Duplicates` flag is true for the relationship, then there might be more than one link, and you must use `GetLinks`:

 `foreach (ParentsHaveChildren link in ParentsHaveChildren.GetLinks(henry, edward)) { ... }`

 There are also other methods for accessing links. For example:

 `foreach (ParentsHaveChildren link in     ParentsHaveChildren.GetLinksToChildren(henry)) { ... }`

 **Hidden roles.** If in the DSL definition, **Is Property Generated** is **false** for a particular role, then no property is generated that corresponds to that role. However, you can still access the links and traverse the links using the methods of the relationship:

 `foreach (Person p in ParentsHaveChildren.GetChildren(henry)) { ... }`

 The most frequently used example is the <xref:Microsoft.VisualStudio.Modeling.Diagrams.PresentationViewsSubject> relationship, which links a model element to the shape that displays it on a diagram:

 `PresentationViewsSubject.GetPresentation(henry)[0] as PersonShape`

### The Element Directory
 You can access all the elements in the store using the element directory:

 `store.ElementDirectory.AllElements`

 There are also methods for finding elements, such as the following:

 `store.ElementDirectory.FindElements(Person.DomainClassId);`

 `store.ElementDirectory.GetElement(elementId);`

## <a name="metadata"></a> Accessing Class Information
 You can get information about the classes, relationships, and other aspects of the DSL definition. For example:

 `DomainClassInfo personClass = henry.GetDomainClass();`

 `DomainPropertyInfo birthProperty =`

 `personClass.FindDomainProperty("BirthDate")`

 `DomainRelationshipInfo relationship =`

 `link.GetDomainRelationship();`

 `DomainRoleInfo sourceRole = relationship.DomainRole[0];`

 The ancestor classes of model elements are as follows:

- ModelElement - all elements and relationships are ModelElements

- ElementLink - all relationships are ElementLinks

## <a name="transaction"></a> Perform Changes inside a Transaction
 Whenever your program code changes anything in the Store, it must do so inside a transaction. This applies to all model elements, relationships, shapes, diagrams, and their properties. For more information, see <xref:Microsoft.VisualStudio.Modeling.Transaction>.

 The most convenient method of managing a transaction is with a `using` statement enclosed in a `try...catch` statement:

```
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

 You can make any number of changes inside one transaction. You can open new transactions inside an active transaction.

 To make your changes permanent, you should `Commit` the transaction before it is disposed. If an exception occurs that is not caught inside the transaction, the Store will be reset to its state before the changes.

## <a name="elements"></a> Creating Model Elements
 This example adds an element to an existing model:

```csharp
FamilyTreeModel familyTree = ...; // The root of the model.
using (Transaction t =
    familyTree.Store.TransactionManager
    .BeginTransaction("update model"))
{
  // Create a new model element
  // in the same partition as the model root:
  Person edward = new Person(familyTree.Partition);
  // Set its embedding relationship:
  edward.FamilyTreeModel = familyTree;
          // same as: familyTree.People.Add(edward);
  // Set its properties:
  edward.Name = "Edward VII";
  t.Commit(); // Don't forget this!
}
```

 This example illustrates these essential points about creating an element:

- Create the new element in a specific partition of the Store. For model elements and relationships, but not shapes, this is usually the default partition.

- Make it the target of an embedding relationship. In the DslDefinition of this example, each Person must be the target of embedding relationship FamilyTreeHasPeople. To achieve this, we can either set the FamilyTreeModel role property of the Person object, or add the Person to the People role property of the FamilyTreeModel object.

- Set the properties of a new element, particularly the property for which `IsName` is true in the DslDefinition. This flag marks the property that serves to identify the element uniquely within its owner. In this case, the Name property has that flag.

- The DSL definition of this DSL must have been loaded into the Store. If you are writing an extension such as a menu command, this will typically be already true. In other cases, you can explicitly load the model into the Store, or use [ModelBus](/previous-versions/ee904639(v=vs.140)) to load it. For more information, see [How to: Open a Model from File in Program Code](../modeling/how-to-open-a-model-from-file-in-program-code.md).

  When you create an element in this way, a shape is automatically created (if the DSL has a diagram). It appears in an automatically assigned location, with default shape, color, and other features. If you want to control where and how the associated shape appears, see [Creating an Element and its Shape](#merge).

## <a name="links"></a> Creating Relationship Links
 There are two relationships defined in the example DSL definition. Each relationship defines a *role property* on the class at each end of the relationship.

 There are three ways in which you can create an instance of a relationship. Each of these three methods has the same effect:

- Set the property of the source role player. For example:

  - `familyTree.People.Add(edward);`

  - `edward.Parents.Add(henry);`

- Set the property of the target role player. For example:

  - `edward.familyTreeModel = familyTree;`

       The multiplicity of this role is `1..1`, so we assign the value.

  - `henry.Children.Add(edward);`

       The multiplicity of this role is `0..*`, so we add to the collection.

- Construct an instance of the relationship explicitly. For example:

  - `FamilyTreeHasPeople edwardLink = new FamilyTreeHasPeople(familyTreeModel, edward);`

  - `ParentsHaveChildren edwardHenryLink = new ParentsHaveChildren(henry, edward);`

  The last method is useful if you want to set properties on the relationship itself.

  When you create an element in this way, a connector on the diagram is automatically created, but it has a default shape, color, and other features. To control how the associated connector is created, see [Creating an Element and its Shape](#merge).

## <a name="deleteelements"></a> Deleting Elements

Delete an element by calling `Delete()`:

`henry.Delete();`

This operation will also delete:

- Relationship links to and from the element. For example, `edward.Parents` will no longer contain `henry`.

- Elements at roles for which the `PropagatesDelete` flag is true. For example, the shape that displays the element will be deleted.

By default, every embedding relationship has `PropagatesDelete` true at the target role. Deleting `henry` does not delete the `familyTree`, but `familyTree.Delete()` would delete all the `Persons`.

By default, `PropagatesDelete` is not true for the roles of reference relationships.

You can cause the deletion rules to omit specific propagations when you delete an object. This is useful if you are substituting one element for another. You supply the GUID of one or more roles for which deletion should not be propagated. The GUID can be obtained from the relationship class:

`henry.Delete(ParentsHaveChildren.SourceDomainRoleId);`

(This particular example would have no effect, because `PropagatesDelete` is `false` for the roles of the `ParentsHaveChildren` relationship.)

In some cases, deletion is prevented by the existence of a lock, either on the element or on an element that would be deleted by propagation. You can use `element.CanDelete()` to check whether the element can be deleted.

## <a name="deletelinks"></a> Deleting Relationship Links
 You can delete a relationship link by removing an element from a role property:

 `henry.Children.Remove(edward); // or:`

 `edward.Parents.Remove(henry);  // or:`

 You can also delete the link explicitly:

 `edwardHenryLink.Delete();`

 These three methods all have the same effect. You only need to use one of them.

 If the role has 0..1 or 1..1 multiplicity, you can set it to `null`, or to another value:

 `edward.FamilyTreeModel = null;` // or:

 `edward.FamilyTreeModel = anotherFamilyTree;`

## <a name="reorder"></a> Re-ordering the Links of a Relationship
 The links of a particular relationship that are sourced or targeted at a particular model element have a specific sequence. They appear in the order in which they were added. For example, this statement will always yield the children in the same order:

 `foreach (Person child in henry.Children) ...`

 You can change the order of the links:

 `ParentsHaveChildren link = GetLink(henry,edward);`

 `ParentsHaveChildren nextLink = GetLink(henry, elizabeth);`

 `DomainRoleInfo role =`

 `link.GetDomainRelationship().DomainRoles[0];`

 `link.MoveBefore(role, nextLink);`

## <a name="locks"></a> Locks
 Your changes might be prevented by a lock. Locks can be set on individual elements, on partitions, and on the store. If any of these levels has a lock that prevents the kind of change that you want to make, an exception might be thrown when you attempt it. You can discover whether locks are set by using element.GetLocks(), which is an extension method that is defined in the namespace <xref:Microsoft.VisualStudio.Modeling.Immutability>.

 For more information, see [Defining a Locking Policy to Create Read-Only Segments](../modeling/defining-a-locking-policy-to-create-read-only-segments.md).

## <a name="copy"></a> Copy and Paste
 You can copy elements or groups of elements to an <xref:System.Windows.Forms.IDataObject>:

```csharp
Person person = personShape.ModelElement as Person;
Person adopter = adopterShape.ModelElement as Person;
IDataObject data = new DataObject();
personShape.Diagram.ElementOperations
      .Copy(data, person.Children.ToList<ModelElement>());
```

 The elements are stored as a serialized Element Group.

 You can merge elements from an IDataObject into a model:

```csharp
using (Transaction t = targetDiagram.Store.
        TransactionManager.BeginTransaction("paste"))
{
  adopterShape.Diagram.ElementOperations.Merge(adopter, data);
}
```

 `Merge ()` can accept either a `PresentationElement` or a `ModelElement`. If you give it a `PresentationElement`, you can also specify a position on the target diagram as a third parameter.

## <a name="diagrams"></a> Navigating and updating diagrams
 In a DSL, the domain model element, which represents a concept such as Person or Song, is separate from the shape element, which represents what you see on the diagram. The domain model element stores the important properties and relationships of the concepts. The shape element stores the size, position and color of the object's view on the diagram, and the layout of its component parts.

### Presentation Elements
 ![Class diagram of base shape and element types](../modeling/media/dslshapesandelements.png)

 In your DSL Definition, each element that you specify creates a class that is derived from one of the following standard classes.

|Kind of element|Base class|
|-|-|
|Domain class|<xref:Microsoft.VisualStudio.Modeling.ModelElement>|
|Domain relationship|<xref:Microsoft.VisualStudio.Modeling.ElementLink>|
|Shape|<xref:Microsoft.VisualStudio.Modeling.Diagrams.NodeShape>|
|Connector|<xref:Microsoft.VisualStudio.Modeling.Diagrams.BinaryLinkShape>|
|Diagram|<xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram>|

 An element on a diagram usually represents a model element. Typically (but not always), a <xref:Microsoft.VisualStudio.Modeling.Diagrams.NodeShape> represents a domain class instance, and a <xref:Microsoft.VisualStudio.Modeling.Diagrams.BinaryLinkShape> represents a domain relationship instance. The <xref:Microsoft.VisualStudio.Modeling.Diagrams.PresentationViewsSubject> relationship links a node or link shape to the model element that it represents.

 Every node or link shape belongs to one diagram. A binary link shape connects two node shapes.

 Shapes can have child shapes in two sets. A shape in the `NestedChildShapes` set is confined to the bounding box of its parent. A shape in the `RelativeChildShapes` list can appear outside or partly outside the bounds of the parent - for example a label or a port. A diagram has no `RelativeChildShapes` and no `Parent`.

### <a name="views"></a> Navigating between shapes and elements
 Domain model elements and shape elements are related by the <xref:Microsoft.VisualStudio.Modeling.Diagrams.PresentationViewsSubject> relationship.

```csharp
// using Microsoft.VisualStudio.Modeling;
// using Microsoft.VisualStudio.Modeling.Diagrams;
// using System.Linq;
Person henry = ...;
PersonShape henryShape =
  PresentationViewsSubject.GetPresentation(henry)
    .FirstOrDefault() as PersonShape;
```

 The same relationship links relationships to connectors on the diagram:

```
Descendants link = Descendants.GetLink(henry, edward);
DescendantConnector dc =
   PresentationViewsSubject.GetPresentation(link)
     .FirstOrDefault() as DescendantConnector;
// dc.FromShape == henryShape && dc.ToShape == edwardShape
```

 This relationship also links the root of the model to the diagram:

```
FamilyTreeDiagram diagram =
   PresentationViewsSubject.GetPresentation(familyTree)
      .FirstOrDefault() as FamilyTreeDiagram;
```

 To get the model element represented by a shape, use:

 `henryShape.ModelElement as Person`

 `diagram.ModelElement as FamilyTreeModel`

### Navigating around the Diagram
 In general it is not advisable to navigate between shapes and connectors on the diagram. It is better to navigate the relationships in the model, moving between the shapes and connectors only when it is necessary to work on the appearance of the diagram. These methods link connectors to the shapes at each end:

 `personShape.FromRoleLinkShapes, personShape.ToRoleLinkShapes`

 `connector.FromShape, connector.ToShape`

 Many shapes are composites; they are made up of a parent shape and one or more layers of children. Shapes that are positioned relative to another shape are said to be its *children*. When the parent shape moves, the children move with it.

 *Relative children* can appear outside the bounding box of the parent shape. *Nested* children appear strictly inside the bounds of the parent.

 To obtain the top set of shapes on a diagram, use:

 `Diagram.NestedChildShapes`

 The ancestor classes of shapes and connectors are:

 <xref:Microsoft.VisualStudio.Modeling.ModelElement>

 -- <xref:Microsoft.VisualStudio.Modeling.Diagrams.PresentationElement>

 -- <xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement>

 ----- <xref:Microsoft.VisualStudio.Modeling.Diagrams.NodeShape>

 ------- <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram>

 ------- *YourShape*

 ----- <xref:Microsoft.VisualStudio.Modeling.Diagrams.LinkShape>

 ------- <xref:Microsoft.VisualStudio.Modeling.Diagrams.BinaryLinkShape>

 --------- *YourConnector*

### <a name="shapeProperties"></a> Properties of Shapes and Connectors
 In most cases, it is not necessary to make explicit changes to shapes. When you have changed the model elements, the "fix up" rules update the shapes and connectors. For more information, see [Responding to and Propagating Changes](../modeling/responding-to-and-propagating-changes.md).

 However, it is useful to make some explicit changes to shapes in properties that are independent of the model elements. For example, you could change these properties:

- <xref:Microsoft.VisualStudio.Modeling.Diagrams.NodeShape.Size%2A> - determines the height and width of the shape.

- <xref:Microsoft.VisualStudio.Modeling.Diagrams.NodeShape.Location%2A> - position relative to the parent shape or diagram

- <xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.StyleSet%2A> - the set of pens and brushes used for drawing the shape or connector

- <xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.Hide%2A> - makes the shape invisible

- <xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement.Show%2A> - makes the shape visible after a `Hide()`

### <a name="merge"></a> Creating an Element and its Shape

When you create an element and link it into the tree of embedding relationships, a shape is automatically created and associated with it. This is done by the "fixup" rules that execute at the end of the transaction. However, the shape will appear in an automatically assigned location, and its shape, color and other features will have default values. To control how the shape is created, you can use the merge function. You must first add the elements you want to add into an ElementGroup, and then merge the group into the diagram.

This method:

- Sets the name, if you have assigned a property as the element name.

- Observes any Element Merge Directives that you specified in the DSL Definition.

This example creates a shape at the mouse position, when the user double-clicks the diagram. In the DSL Definition for this sample, the `FillColor` property of `ExampleShape` has been exposed.

```csharp
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
partial class MyDiagram
{
  public override void OnDoubleClick(DiagramPointEventArgs e)
  {
    base.OnDoubleClick(e);

    using (Transaction t = this.Store.TransactionManager
        .BeginTransaction("double click"))
    {
      ExampleElement element = new ExampleElement(this.Store);
      ElementGroup group = new ElementGroup(element);

      { // To use a shape of a default size and color, omit this block.
        ExampleShape shape = new ExampleShape(this.Partition);
        shape.ModelElement = element;
        shape.AbsoluteBounds = new RectangleD(0, 0, 1.5, 1.0);
        shape.FillColor = System.Drawing.Color.Azure;
        group.Add(shape);
      }

      this.ElementOperations.MergeElementGroupPrototype(
        this,
        group.CreatePrototype(),
        PointD.ToPointF(e.MousePosition));
      t.Commit();
    }
  }
}
```

 If you provide more than one shape, set their relative positions using the `AbsoluteBounds`.

 You can also set the color and other exposed properties of connectors using this method.

### Use Transactions
 Shapes, connectors and diagrams are subtypes of <xref:Microsoft.VisualStudio.Modeling.ModelElement> and live in the Store. You must therefore make changes to them only inside a transaction. For more information, see [How to: Use Transactions to Update the Model](../modeling/how-to-use-transactions-to-update-the-model.md).

## <a name="docdata"></a> Document View and Document Data
 ![Class diagram of standard diagram types](../modeling/media/dsldiagramsanddocs.png)

## Store Partitions
 When a model is loaded, the accompanying diagram is loaded at the same time. Typically, the model is loaded into Store.DefaultPartition, and the diagram content is loaded into another Partition. Usually, the content of each partition is loaded and saved to a separate file.

## Related content

- <xref:Microsoft.VisualStudio.Modeling.ModelElement>
- [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md)
- [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md)
- [How to: Use Transactions to Update the Model](../modeling/how-to-use-transactions-to-update-the-model.md)
- [Integrating Models by using Visual Studio Modelbus](../modeling/integrating-models-by-using-visual-studio-modelbus.md)
- [Responding to and Propagating Changes](../modeling/responding-to-and-propagating-changes.md)

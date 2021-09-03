---
title: The DslDefinition.dsl File
description: Learn about the structure of the DslDefinition.dsl file in the Dsl project of a DSL Tools solution, which defines a domain-specific language.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Domain-Specific Language, definition file
author: mgoertz-msft
ms.author: mgoertz
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
- multiple
---
# The DslDefinition.dsl File

This topic describes the structure of the DslDefinition.dsl file in the Dsl project of a [!INCLUDE[dsl](../modeling/includes/dsl_md.md)] solution, which defines a *domain-specific language*. The DslDefinition.dsl file describes the classes and relationships of a domain-specific language, together with the diagram, shapes, connectors, serialization format, and **Toolbox** of the domain-specific language and its editing tools. In a domain-specific language solution, the code that defines those tools is generated according to the information in the DslDefinition.dsl file.

Generally, you use the *Domain-Specific Language Designer* to edit the DslDefinition.dsl file. However, its raw form is XML, and you can open a DslDefinition.dsl file in an XML editor. You might find it useful to understand what information the file contains and how it is organized for debugging and extension purposes.

Examples in this topic are taken from the Component Diagram solution template. To see an example, create a domain-specific language solution that is based on the Component Models solution template. After you create the solution, the DslDefinition.dsl file appears in the Domain-Specific Language Designer. Close the file, right-click it in **Solution Explorer**, point to **Open With**, click **XML Editor**, and then click **OK**.

## Sections of the DslDefinition.dsl File

The root element is \<Dsl>, and its attributes identify the name of the domain-specific language, the namespace, and major and minor version numbers for versioning. The `DslDefinitionModel` schema defines the content and structure for a valid DslDefinition.dsl file.

The child elements of the \<Dsl> root element are as follows:

### Classes

This section defines each domain class that generates a class in the generated code.

### Relationships

This section defines each relationship in the model. The source and the target represent the two sides of a relationship.

### Types

This section defines each type and its namespace. Domain properties have two types. `DomainEnumerations` are defined in the model and generate types into DomainModel.cs. `ExternalTypes` refer to types that are defined elsewhere (such as `String` or `Int32`) and do not generate anything.

### Shapes

This section defines the shapes that describe how the model appears in a designer. These geometric shapes are mapped to the classes in the model in the Diagram section.

### Connectors

This section defines the appearance of the connectors that appear in a designer. These geometric style descriptions are mapped to specific relationships in the model in the Diagram section.

### XmlSerializationBehavior

This section defines a serialization scheme and provides additional information about how each class is saved to a file.

### ExplorerBehavior

This section defines how the **DSL Explorer** window appears when the user is editing a model.

### ConnectionBuilders

This section defines a connection builder for each connector tool (the tool for making links between any two classes that can be connected). This section determines whether you can connect a source and a target class.

### Diagram

This section defines a diagram, and you use it to specify properties such as background color and the root class. (The root class is the domain class that is represented by the diagram as a whole.) The Diagram section also contains ShapeMap and ConnectorMap elements, which specify the shape or connector that represents each domain class or relationship.

### Designer

This section defines a designer (editor), which brings together a **Toolbox**, validation settings, a diagram, and a serialization scheme. The Designer section also defines the root class of the model, which is usually also the root class of the diagram.

### Explorer

This section identifies the **DSL Explorer** behavior (defined in the XmlSerializationBehavior section).

## Monikers in the DslDefinition.dsl file

Throughout the DslDefinition.dsl file, you can use monikers to make cross-references to specific items. For example, each Relationship definition contains a Source subsection and a Target subsection. Each subsection contains the moniker of the class of object that can be linked with that relationship:

```xml
<DomainRelationship ...        Name="LibraryHasMembers" Namespace="ExampleNamespace" >    <Source>      <DomainRole ...>
       <RolePlayer>
         <DomainClassMoniker Name="Library" />
       </RolePlayer>
     </DomainRole>
   </Source>
```

Usually, the namespace of the referenced item (in this example, the `Library` domain class) is the same as the referencing item (in this case, the LibraryHasMembers domain relationship). In those cases, the moniker must give only the name of the class. Otherwise, you should use the full form /Namespace/Name:

```xml
<DomainClassMoniker Name="/ExampleNameSpace/Library" />
```

The moniker system requires that siblings in the XML tree have distinct names. For this reason, validation errors occur if you try to save a domain-specific language definition that has, for example, two classes of the same name. You should always correct such duplicate-name errors before you save the DslDefinition.dsl file so that you can reload it correctly later.

Each type has its own type of moniker: DomainClassMoniker, DomainRelationshipMoniker, and so on.

## Types

The Types section specifies all the types that the DslDefinition.dsl file contains as types of properties. These types fall into two kinds: external types, such as System.String, and enumerated types.

### External Types

The Component Diagram example lists a set of standard primitive types, although only some of them are used.

Each External Type definition consists of just a name and a namespace, such as String and System:

```xml
<ExternalType Name="String" Namespace="System" />
```

The full names of the types are used, instead of the equivalent compiler keywords such as "string".

External types are not restricted to standard library types.

### Enumerations

A typical Enumeration specification resembles this example:

```xml
<DomainEnumeration IsFlags="true" Name="PageSort"          Namespace="Fabrikam.Wizard">
  <Literals>
    <EnumerationLiteral Name="Start" Value="1"/>
    <EnumerationLiteral Name="Decision" Value="2"/>
  </Literals>
</DomainEnumeration>
```

The `IsFlags` attribute controls whether the generated code is prefixed by the `[Flags]` Common Language Runtime (CLR) attribute, which determines whether values of the enumeration can be combined bitwise. If this attribute is set to true, you should specify power-of-two values for the literal values.

## Classes

Most of the elements in any definition of a domain-specific language are either directly or indirectly instances of `DomainClass`. Subclasses of `DomainClass` include `DomainRelationship`, `Shape`, `Connector`, and `Diagram`. The `Classes` section of the DslDefinition.dsl file lists the domain classes.

Each class has a set of properties and might have a base class. In the Component Diagram example, `NamedElement` is an abstract class that has a `Name` property, whose type is string:

```xml
<DomainClass Id="ee3161ca-2818-42c8-b522-88f50fc72de8"  Name="NamedElement" Namespace="Fabrikam.CmptDsl5"      DisplayName="Named Element"  InheritanceModifier="Abstract">
  <Properties>
    <DomainProperty Id="ef553cf0-33b5-4e34-a30b-cfcfd86f2261"   Name="Name" DisplayName="Name"  DefaultValue="" Category="" IsElementName="true">
      <Type>
        <ExternalTypeMoniker Name="/System/String" />
      </Type>
    </DomainProperty>
  </Properties>
</DomainClass>
```

`NamedElement` is the base of several of the other classes such as `Component`, which has its own properties in addition to the `Name` property, which it inherited from `NamedElement`. The BaseClass child node contains a moniker reference. Because the referenced class is in the same namespace, only its name is required in the moniker:

```xml
<DomainClass Name="Component" Namespace="Fabrikam.CmptDsl5"              DisplayName="Component">
  <BaseClass>
    <DomainClassMoniker Name="NamedElement" />
  </BaseClass>
  <Properties>
    <DomainProperty Name="Kind" DisplayName="Kind" >
      <Type>
        <ExternalTypeMoniker Name="/System/String" />
      </Type>
    </DomainProperty>
  </Properties>
```

Every domain class (including relationships, shapes, connectors, and diagrams) can have these attributes and child nodes:

- **Id.** This attribute is a GUID. If you do not provide a value in the file, the Domain-Specific Language Designer will create a value. (In illustrations in this document, this attribute is usually omitted to save space.)

- **Name and Namespace.** These attributes specify the name and namespace of the class in the generated code. Together they must be unique within the domain-specific language.

- **InheritanceModifier.** This attribute is "abstract", "sealed", or none.

- **DisplayName.** This attribute is the name that appears in the **Properties** window. The DisplayName attribute can contain spaces and other punctuation.

- **GeneratesDoubleDerived.** If this attribute is set to true, two classes are generated, and one is a subclass of the other. All the generated methods are in the base, and the constructors are in the subclass. By setting this attribute, you can override any generated method in custom code.

- **HasCustomConstructor**. If this attribute is set to true, the constructor is omitted from the generated code so that you can write your own version.

- **Attributes**. This attribute contains the CLR Attributes of the generated class.

- **BaseClass**. If you specify a base class, it must be of the same type. For example, a domain class must have another domain class as its base, and a compartment shape must have a compartment shape. If you do not specify a base class, the class in the generated code derives from a standard framework class. For example, a domain class derives from `ModelElement`.

- **Properties**. This attribute contains the properties that are maintained under transaction control and persisted when the model is saved.

- **ElementMergeDirectives**. Each element merge directive controls how a different instance of another class is added to an instance of the parent class. You can find more detail about element merge directives later in this topic.

- A C# class is generated for each domain class that is listed in the `Classes` section. The C# classes are generated in Dsl\GeneratedCode\DomainClasses.cs.

### Properties

Each domain property has a name and a type. The name must be unique within the domain class and its transitive bases.

The type must refer to one of those listed in the `Types` section. Generally, the moniker must include the namespace.

```xml
<DomainProperty Name="Name" DisplayName="Name"  DefaultValue="" Category="" IsElementName="true">
  <Type>
    <ExternalTypeMoniker Name="/System/String" />
  </Type>
</DomainProperty>
```

Each domain property can also have these attributes:

- **IsBrowsable**. This attribute determines whether the property appears in the **Properties** window when the user clicks an object of the parent class.

- **IsUIReadOnly**. This attribute determines whether the user can change the property in the **Properties** window or through a decorator in which the property is presented.

- **Kind**. You can set this attribute to Normal, Calculated, or CustomStorage. If you set this attribute to Calculated, you must provide custom code that determines the value, and the property will be read-only. If you set this attribute to CustomStorage, you must provide code that both gets and sets values.

- **IsElementName**. If this attribute is set to true, its value is automatically set to a unique value when an instance of the parent class is created. This attribute can be set to true for only one property in each class, which must have a string type. In the Component Diagram example, the `Name` property in `NamedElement` has `IsElementName` set to true. Whenever a user creates a `Component` element (which inherits from `NamedElement`), the name is automatically initialized to something like "Component6."

- `DefaultValue`. If you have specified this attribute, the value that you specified is assigned to this attribute for new instances of this class. If `IsElementName` is set, the DefaultValue attribute specifies the initial part of the new string.

- **Category** is the header under which the property will appear in the **Properties** window.

## Relationships

The `Relationships` section lists all the relationships in the domain-specific language. Every `Domain Relationship` is binary and directed, linking members of a source class to members of a target class. The source and target classes are typically domain classes, but relationships to other relationships are also permitted.

For example, the Connection relationship links members of the OutPort class to members of the InPort class. Each link instance of the relationship connects an instance of an OutPort to an instance of an InPort. Because the relationship is many-many, each OutPort can have many Connection links with sources on it, and each InPort instance can have many Connection links that target it.

### Source and target roles

Each relationship contains source and target roles that have the following attributes:

- The `RolePlayer` attribute references the domain class of the linked instances: OutPort for the source, InPort for the target.

- The `Multiplicity` attribute has four possible values (ZeroMany, ZeroOne, One, and OneMany). This attribute refers to the number of links of this relationship that can be associated with one role player.

- The `PropertyName` attribute specifies the name that is used in the role playing class to access the objects at the other end. This name is used in template or custom code to traverse the relationship. For example, the `PropertyName` attribute of the source role is set to `Targets`. Therefore, the following code will work:

    ```
    OutPort op = ...; foreach (InPort ip in op.Targets) ...
    ```

     By convention, property names are plural if the multiplicity is ZeroMany or OneMany.

     The multiplicity of a role refers to how many of the opposite role can be associated with each instance of this role. For example, in the relationship ComponentHasPorts, the target role has the `RolePlayer` attribute set to Port, the `PropertyName` attribute set to Component, and the `Multiplicity` attribute set to ZeroOne. Therefore, the appropriate code to use this role is:

    ```
    ComponentPort p = ...; Component c = p.Component; if (c != null) ...
    ```

- The role's `Name` is the name that is used within the Relationship class to refer to that end of a link. By convention, a role name is always singular, because each link has only one instance at each end. The following code would work:

    ```
    Connection connectionLink = ...; OutPort op = connectionLink.Source;
    ```

- By default, the `IsPropertyGenerator` attribute is set to true. If it is set to false, no property is created on the Role Player class. (In that case, `op.Targets`, for example, would not work). However, it is still possible to use custom code to traverse the relationship or obtain access to the links themselves if the custom code uses the relationship explicitly:

    ```
    OutPort op = ...; foreach (InPort ip in Connection.GetTargets(op)) ...
    foreach (Connection link in Connection.GetLinksToTargets(op)) ...
    ```

### Relationship attributes

In addition to the attributes and child nodes that are available to all classes, each relationship has these attributes:

- **IsEmbedding**. This Boolean attribute specifies whether the relationship is part of the embedding tree. Every model must form a tree with its embedding relationships. Every domain class must therefore be the target of at least one embedding relationship, unless it is the root of a model.

- **AllowsDuplicates**. This Boolean attribute, which is false by default, applies only to relationships that have a "many" multiplicity at both source and target. It determines whether language users may connect a single pair of source and target elements by more than one link of the same relationship.

## Designer and Toolbox Tabs

The main part of the **Designer** section of the DslDefinition.dsl file is the **ToolboxTab** elements. One designer can have several of these elements, each of which represents a headed section in the generated designer's **Toolbox**. Each **ToolboxTab** element can contain one or more **ElementTool** elements, **ConnectionTool** elements, or both.

Element tools can create instances of a specific domain class. When the user drags an element tool onto the diagram, the result is determined by element merge directives as described in the section about element merge directives later in this topic.

Each connection tool can invoke a specific connection builder. One connection builder can create more than one type of relationship, depending on where the user clicks the mouse, as described in the section about connection builders.

Neither type of tool directly constructs shapes or connectors. Each instantiates a domain class or a domain relationship; the Shape and Connector mappings then determine how that domain class or domain relationship appears.

## Paths

Domain paths appear in several locations in the DslDefinition.dsl file. These paths specify a series of links from one element in a model (that is, an instance of the domain-specific language) to another. Path syntax is simple but verbose.

Paths appear in the DslDefinition.dsl file in `<DomainPath>...</DomainPath>` tags. Although paths can navigate through multiple links, most examples in practice traverse only one link.

A path consists of a sequence of segments. Each segment is a hop either from an object to a link or from a link to an object. Therefore, the hops typically alternate in a long path. The first hop is from an object to a link, the second hop is to the object at the other end of the link, the third hop is to the next link, and so on. The occasional exception to this sequence is where a relationship is itself the source or target of another relationship.

Each segment starts with a relationship name. In an object-to-link hop, the relationship precedes a dot and the property name: "`Relationship . Property`". In a link-to-object hop, the relationship precedes an exclamation mark and the role name: "`Relationship ! Role`".

The Component Diagram example contains a path in the ParentElementPath of the ShapeMap for InPort. This path starts as follows:

```
    ComponentHasPorts.Component
```

In this example, InPort is a subclass of ComponentPort and has a relationship ComponentHasPorts. The property is called Component.

When writing C# against this model, you can jump across a link in one step by using the property that the relationship generates on each of the classes that it relates:

```
     InPort port; ...  Component c = port.Component;
```

However, you must do both hops explicitly in Path Syntax. Because of this requirement, you can access the intermediate link more easily. The following code completes the hop from the link to the Component:

```
    ComponentHasPorts.Component / ! Component
```

(You can omit the relationship name where it is the same as in the previous segment.)

## Element Merge Directives

When the language user drags an item from the **Toolbox** onto the diagram, an instance of the tool's class is constructed. Also, links are made between that instance and the existing model elements. Some items, such as components or comments, are created when the language user drags them from the **Toolbox** onto a blank part of the diagram. Other items are created when the language user drags them onto other host elements. For example, an OutPort or InPort is created when the language user drags it onto a component.

A potential host class, such as Component, will accept a new element only if the host class has an element merge directive for the class of the new element. For example, the DomainClass node with Name="Component" contains:

```xml
<DomainClass Name="Component" ...> ...
    <ElementMergeDirective>
      <Index>
        <DomainClassMoniker Name="ComponentPort" />
      </Index>
      <LinkCreationPaths>
        <DomainPath>ComponentHasPorts.Ports</DomainPath>
      </LinkCreationPaths>
    </ElementMergeDirective> ...
```

The class moniker that is under the Index node references the class of element that can be accepted. In this case, ComponentPort is the abstract base class of InPort and OutPort. Therefore, either of those elements can be accepted.

ComponentModel, the root class of the language, has element merge directives for components and comments. The language user can drag items for those classes directly onto the diagram because the blank parts of the diagram represent the root class. However, ComponentModel has no element merge directive for ComponentPort. Therefore, the language user cannot drag InPorts or OutPorts directly onto the diagram.

The element merge directive determines what link or links are created so that the new element can integrate or merge into the existing model. For a ComponentPort, an instance of ComponentHasPorts is created. The DomainPath identifies both the relationship and the property of the parent class, Ports, to which the new element will be added.

You can create more than one link on an element merge directive by including more than one link creation path. One of the paths must be embedded.

You can use more than one segment in a link creation path. In this case, the last segment defines what link must be created. The earlier segments navigate from the parent class to the object from which the new link should be created.

For example, you can add this element merge directive to the Component class:

```xml
<DomainClass Name="Component" ...> ...
  <ElementMergeDirective>
    <Index>
       <DomainClassMoniker Name="Comment"/>
    </Index>
    <LinkCreationPaths>
       <DomainPath>          ComponentModelHasComponents . ComponentModel / !ComponentModel         / ComponentModelHasComments.Comments       </DomainPath>
       <DomainPath>CommentsReferenceComponents.Comments</DomainPath>
    </LinkCreationPaths>
  </ElementMergeDirective>
```

Language users can then drag a comment onto a component and have the new comment automatically created with a link to the component.

The first link creation path navigates from the `Component` to the `ComponentModel` and then creates an instance of the embedding relationship `ComponentModelHasComments`. The second link creation path creates a link of the reference relationship CommentsReferenceComponents from the host Component to the new Comment. All link creation paths must start with the host class and must end at a link that steps towards the newly instantiated class.

## XmlClassData

Each domain class (including relationships and other subtypes) can have extra information provided in an `XmlClassData` node, which appears under the `XmlSerializationBehavior` section of the DslDefinition.dsl file. This information specifically concerns how instances of the class are stored in serialized form when a model is saved to a file.

Much of the generated code that `XmlSerializationBehavior` influences is in `Dsl\GeneratedCode\Serializer.cs`.

Each `XmlClassData` node includes these child nodes and attributes:

- A moniker node, which references the class to which the data applies.

- **XmlPropertyData** for each property that is defined on the class.

- **XmlRelationshipData** for each relationship that is sourced at the class. (Relationships also have their own XmlClassData nodes.)

- **TypeName** string attribute, which determines the name of the serialization helper class in the generated code.

- **ElementName** string, which determines the XML tag of serialized instances of this class. By convention, ElementName is usually the same as the class name except the first letter is lowercase. For example, a sample model file starts with the following:

    ```xml
    <componentModel ...
    ```

- **MonikerElementName** in the user's serialized model files. This attribute introduces a moniker that references this class.

- **MonikerAttributeName**, which identifies the name of the XML attribute within a moniker. In this fragment of a user's serialized file, the author of the domain-specific language defined **MonikerElementName** as "inPortMoniker" and **MonikerAttributeName** as "path":

    ```xml
    <inPortMoniker path="//Component2/InPort1" />
    ```

### ConnectionBuilders

A connection builder is defined for each connection tool. Each connection builder consists of one or more LinkConnectDirective elements, each of which contains one or more SourceDirective elements and one or more TargetDirective elements. After clicking a connection tool, the user can start a connection from any shape mapped to a model element that appears in the list of SourceDirective elements. The connection can then be completed on a shape that is mapped to an element that appears in the list of TargetDirective elements. The class of relationship instantiated depends on the LinkConnectDirective element designated by where the connection was started.

### XmlPropertyData

A **DomainPropertyMoniker** attribute identifies the property to which the data refers. This attribute must be a property of the enclosing ClassData's class.

The **XmlName** attribute gives the corresponding attribute name as it should appear in the XML. By convention, this string is the same as the property name except the first letter is lowercase.

By default, the **Representation** attribute is set to Attribute. If **Representation** is set to Element, a child node is created in the XML. If **Representation** is set to Ignore, the property is not serialized.

The **IsMonikerKey** and **IsMonikerQualifier** attributes give a property a role in identifying instances of the parent class. You can set **IsMonikerKey** to true for one property that is defined in or inherited by a class. This attribute identifies an individual instance of the parent class. The property that you set to `IsMonikerKey` is usually a name or other key identifier. For example, the `Name` string property is the moniker key for NamedElement and its derived classes. When the user saves a model to file, this attribute must contain unique values for each instance, among its siblings in the tree of embedding relationships.

In the serialized model file, the full moniker of an element is a path from the model root down the tree of embedding relationships, quoting the moniker key at each point. For example, InPorts are embedded within Components, which are in turn embedded in the model root. A valid moniker is therefore:

```xml
<inPortMoniker name="//Component2/InPort1" />
```

You can set the **IsMonikerQualifier** attribute for a string property and provide an additional way to construct the full name of an element. For example, in the DslDefinition.dsl file, **Namespace** is a moniker qualifier.

### XmlRelationshipData

Within a serialized model file, links (of both embedding and reference relationships) are represented by child nodes of the source end of the relationship. For embedding relationships, the child node contains a subtree. For reference relationships, the child node contains a moniker that references another part of the tree.

The **XmlRelationshipData** attribute in an **XmlClassData** attribute defines exactly how the child nodes are nested within the source element. Every relationship that is a source on the Domain Class has one **XmlRelationshipData** attribute.

The **DomainRelationshipMoniker** attribute identifies one of the relationships sourced on the class.

The **RoleElementName** attribute gives the XML tag name that encloses the child node in the serialized data.

For example, the DslDefinition.dsl file contains:

```xml
<XmlClassData ElementName="component" ...>
  <DomainClassMoniker Name="Component" />
  <ElementData>
    <XmlRelationshipData RoleElementName="ports">
      <DomainRelationshipMoniker Name="ComponentHasPorts" />
    </XmlRelationshipData>
```

Therefore, the serialized file contains:

```xml
<component name="Component1"> <!-- parent -->
   <ports> <!-- role -->
     <outPort name="OutPort1"> <!-- child element -->
       ...
     </outPort>
   </ports> ...
```

If the **UseFullForm** attribute is set to true, an extra layer of nesting is introduced. This layer represents the relationship itself. The attribute must be set to true if the relationship has properties.

```xml
<XmlClassData ElementName="outPort">
   <DomainClassMoniker Name="OutPort" />
   <ElementData>
     <XmlRelationshipData UseFullForm="true" RoleElementName="targets">
       <DomainRelationshipMoniker Name="Connection" />
     </XmlRelationshipData>
   </ElementData>
 </XmlClassData>
```

The serialized file contains:

```xml
<outPort name="OutPort1">  <!-- Parent -->
   <targets>  <!-- role -->
     <connection sourceRoleName="X">  <!-- relationship link -->
         <inPortMoniker name="//Component2/InPort1" /> <!-- child -->
     </connection>
    </targets>
  </outPort>
```

(The Connection Relationship has its own XML class data, which provides its element and attribute names.)

If the **OmitElement** attribute is set to true, the relationship role name is omitted, which abbreviates the serialized file and is unambiguous if the two classes have no more than one relationship. For example:

```xml
<component name="Component3">
  <!-- only one relationship could get here: -->
  <outPort name="OutPort1">
     <targets> ...
```

### Serialization of a Domain-Specific Language Definition

The DslDefinition.dsl file is itself a serialized file and conforms to a domain-specific language definition. The following are some examples of XML serialization definitions:

- **Dsl** is the RootClass node and the class of the diagram. DomainClass, DomainRelationship, and other elements are embedded under `Dsl`.

- **Classes** is the **RoleElementName** of the relationship between Domain-Specific Language and DomainClass.

```xml
<Dsl Name="CmptDsl5" ...>
  <Classes>
    <DomainClass Name="NamedElement" InheritanceModifier="Abstract" ...
```

- The **XmlSerializationBehavior** attribute is embedded under the `Dsl` attribute, but the **OmitElement** attribute has been set on the embedding relationship. Therefore, no `RoleElementName` attribute intervenes. By contrast, a **ClassData** attribute is the `RoleElementName` attribute of the embedding relationship between an **XmlSerializationBehavior** attribute and an **XmlClassData** attribute.

```xml
<Dsl Name="CmptDsl5" ...> ...
  <XmlSerializationBehavior Name="ComponentsSerializationBehavior" >
    <ClassData>
      <XmlClassData ...>...</XmlClassData>
      <XmlClassData ...>...</XmlClassData>
```

- ConnectorHasDecorators is the embedding relationship between `Connector` and `Decorator`. `UseFullForm` has been set so that the name of the relationship appears with its list of properties for each link from the Connector object. However, `OmitElement` has also been set so that no `RoleElementName` encloses the multiple links that are embedded inside `Connector`:

```xml
<Connector Name="AssociationLink" ...>
  <ConnectorHasDecorators Position="TargetTop" ...>
    <TextDecorator Name="TargetRoleName"   />
  </ConnectorHasDecorators>
  <ConnectorHasDecorators Position="SourceTop" ...>
    <TextDecorator Name="SourceRoleName"   />
  </ConnectorHasDecorators>
</Connector>
```

## Shapes and Connectors

Shape and Connector definitions inherit attributes and child nodes from domain classes, in addition to the following:

- `Color` and `Line``Style` attributes.

- **ExposesFillColorAsProperty** and several similar attributes. These Boolean attributes make the corresponding property variable by the user. Generally, when a language user clicks a shape on the diagram, the properties that appear in the **Properties** window are those of the domain class instance to which the shape is mapped. If `ExposesFillColorAsProperty` is set to true, a property of the shape itself also appears.

- **ShapeHasDecorators**. An instance of this attribute occurs for each text, icon, or expand/collapse decorator. (In the DslDefinition.dsl file, `ShapeHasDecorators` is a relationship with `UseFullForm` set to true.)

## Shape Maps

Shape maps determine how instances of a given domain class appear on the screen, represented by a shape. Both shape and connector maps appear under the `Diagram` section of the DslDefinition.dsl file.

As in the following example, the `ShapeMap` elements have, at a minimum, the moniker of a domain class, the moniker of a shape, and a `ParentElementPath` element:

```xml
<ShapeMap>
  <DomainClassMoniker Name="InPort" />
  <ParentElementPath>
    <DomainPath>ComponentHasPorts.Component/!Component</DomainPath>
  </ParentElementPath>
  <PortMoniker Name="InPortShape" />
</ShapeMap>
```

The primary function of the `ParentElementPath` element is so that the same class of objects can appear as a different shape in different contexts. For example, if an `InPort` could also be embedded in a comment, the `InPort` could appear as a different shape for that purpose.

Secondly, the path determines how the shape relates to its parent. No embedding structure is defined between the shapes in a DslDefinition.dsl file. You must infer the structure from the shape maps. The parent of a shape is the shape that is mapped to the domain element that the parent element path identifies. In this case, the path identifies the component to which the `InPort` belongs. In another shape map, the Component class is mapped to ComponentShape. Therefore, the new `InPort` shape is made a child shape of its component's `ComponentShape`.

If you attached the InPort shape to the diagram instead, the parent element path would have to take another step, to the component model, which is mapped to the diagram:

```
ComponentHasPorts . Component / ! Component /    ComponentModelHasComponents . ComponentModel / ! ComponentModel
```

The root of the model does not have a shape map. Instead, the root is referenced directly from the diagram, which has a `Class` element:

```xml
<Diagram Name="ComponentDiagram" >
    <Class>
      <DomainClassMoniker Name="ComponentModel" />
    </Class>...
```

### Decorator Maps

A decorator map associates a property in the mapped class to a decorator on the shape. If the property is an enumerated or Boolean type, its value can determine whether the decorator is visible. If the decorator is a text decorator, the value of the property can appear, and the user can edit it.

### Compartment Shape Maps

Compartment shape maps are subtypes of shape maps.

## Connector Maps

The minimal connector map references a connector and a relationship:

```xml
<ConnectorMap>
  <ConnectorMoniker Name="CommentLink" />
  <DomainRelationshipMoniker Name="CommentsReferenceComponents" />
</ConnectorMap>
```

Connector maps can also contain decorator maps.

## See also

- [Domain-Specific Language Tools Glossary](/previous-versions/bb126564(v=vs.100))
- [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)
- [Understanding Models, Classes and Relationships](../modeling/understanding-models-classes-and-relationships.md)
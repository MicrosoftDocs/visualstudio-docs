---
title: Customizing File Storage and XML Serialization
description: Learn about the XML file created or updated when you save an instance, or model, of a domain-specific language (DSL) in Visual Studio.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- vs.dsltools.dsldesigner.xmlbehavior
helpviewer_keywords:
- Domain-Specific Language, serialization
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Customize File Storage and XML Serialization

When the user saves an instance, or *model*, of a domain-specific language (DSL) in Visual Studio, an XML file is created or updated. The file can be reloaded to recreate the model in the Store.

You can customize the serialization scheme by adjusting the settings under **Xml Serialization Behavior** in DSL Explorer. There's a node under **Xml Serialization Behavior** for every domain class, property, and relationship. The relationships are located under their source classes. There are also nodes corresponding to the shape, connector, and diagram classes.

You can also write program code for more advanced customization.

> [!NOTE]
> If you want to save the model in a particular format, but you do not need to reload it from that form, consider using text templates to generate output from the model, instead of a custom serialization scheme. For more information, see [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md).

## Model and Diagram Files

Each model is saved in two files:

- The model file has a name such as `Model1.mydsl`. It stores the model elements and relationships and their properties. The file extension such as `.mydsl` is determined by the **FileExtension** property of the **Editor** node in the DSL Definition.

- The diagram file has a name such as `Model1.mydsl.diagram`. It stores the shapes, connectors, and their positions, colors, line thicknesses, and other details of the appearance of the diagram. If the user deletes a `.diagram` file, the essential information in the model isn't lost. Only the layout of the diagram is lost. When the model file is opened, a default set of shapes and connectors is created.

### To change the file extension of a DSL

1. Open the DSL Definition. In DSL Explorer, click the Editor node.

2. In the Properties window, edit the **FileExtension** property. Don't include the initial `.` of the file name extension.

3. In Solution Explorer, change the name of the two item template files in **DslPackage\ProjectItemTemplates**. These files have names that follow this format:

     `myDsl.diagram`

     `myDsl.myDsl`

## The Default Serialization Scheme

To create an example for this topic, the following DSL Definition was used.

![DSL Definition diagram &#45; family tree model](../modeling/media/familyt_person.png)

This DSL was used to create a model that has the following appearance on the screen.

![Family tree diagram, toolbox, and explorer](../modeling/media/familyt_instance.png)

This model was saved and then reopened in the XML text editor:

```xml
<?xml version="1.0" encoding="utf-8"?>
<familyTreeModel xmlns:dm0="http://schemas.microsoft.com/VisualStudio/2008/DslTools/Core" dslVersion="1.0.0.0" Id="f817b728-e920-458e-bb99-98edc469d78f" xmlns="http://schemas.microsoft.com/dsltools/FamilyTree">
  <people>
    <person name="Henry VIII" birthYear="1491" deathYear="1547" age="519">
      <children>
        <personMoniker name="/f817b728-e920-458e-bb99-98edc469d78f/Elizabeth I" />
        <personMoniker name="/f817b728-e920-458e-bb99-98edc469d78f/Mary" />
      </children>
    </person>
    <person name="Elizabeth I" birthYear="1533" deathYear="1603" age="477" />
    <person name="Mary" birthYear="1515" deathYear="1558" age="495" />
  </people>
</familyTreeModel>
```

Notice the following points about the serialized model:

- Each XML node has a name that is the same as a domain class name, except that the initial letter is lowercase. For example, `familyTreeModel` and `person`.

- Domain properties such as Name and BirthYear are serialized as attributes in the XML nodes. Again, the initial character of the property name is converted to lowercase.

- Each relationship is serialized as an XML node nested inside the source end of the relationship. The node has the same name as the source role property, but with a lower case initial character.

     For example, in the DSL Definition, a role that is named **People** is sourced at the **FamilyTree** class.  In the XML, the **People** role is represented with a node named `people` nested inside the `familyTreeModel` node.

- The target end of each embedding relationship is serialized as a node nested under the relationship. For example, the `people` node contains several `person` nodes.

- The target end of each reference relationship is serialized as a *moniker*, which encodes a reference to the target element.

     For example, under a `person` node, there can be a `children` relationship. This node contains monikers such as:

    ```xml
    <personMoniker name="/f817b728-e920-458e-bb99-98edc469d78f/Elizabeth I" />
    ```

## Understand Monikers

Monikers are used to represent cross-references between different parts of the model and diagram files. They're also used in the `.diagram` file to refer to nodes in the model file. There are two forms of moniker:

- *Id monikers* quote the GUID of the target element. For example:

    ```xml
    <personShapeMoniker Id="f79734c0-3da1-4d72-9514-848fa9e75157" />
    ```

- *Qualified key monikers* identify the target element by the value of a designated domain property called the moniker key. The moniker of the target element is prefixed with the moniker of its parent element in the tree of embedding relationships.

     The following examples are taken from a DSL in which there's a domain class named Album, which has an embedding relationship to a domain class named Song:

    ```xml
    <albumMoniker title="/My Favorites/Jazz after Teatime" />
    <songMoniker title="/My Favorites/Jazz after Teatime/Hot tea" />
    ```

     Qualified key monikers are used if the target class has a domain property for which the option **Is Moniker Key** is set to `true` in **Xml Serialization Behavior**. In the example, this option is set for domain properties named "Title" in the domain classes "Album" and "Song".

Qualified key monikers are easier to read than ID monikers. If you intend the XML of your model files to be human-readable, consider using qualified key monikers. However, it's possible for the user to set more than one element to have the same moniker key. Duplicate keys could cause the file not to reload correctly. Therefore, if you define a domain class that is referenced using qualified key monikers, you should consider ways of preventing the user from saving a file that has duplicate monikers.

### To set a domain class to be referenced by ID monikers

1. Make sure that **Is Moniker Key** is `false` for every domain property in the class and its base classes.

    1. In DSL Explorer, expand **Xml Serialization Behavior\Class Data\\\<the domain class>\Element Data**.

    2. Verify that **Is Moniker Key** is `false` for every domain property.

    3. If the domain class has a base class, repeat the procedure in that class.

2. Set **Serialize Id** = `true` for the domain class.

     This property can be found under **Xml Serialization Behavior**.

### To set a domain class to be referenced by qualified key monikers

- Set **Is Moniker Key** for a domain property of an existing domain class. The type of the property must be `string`.

    1. In DSL Explorer, expand **Xml Serialization Behavior\Class Data\\\<the domain class>\Element Data**, and then select the domain property.

    2. In the Properties window, set **Is Moniker Key** to `true`.

- \- or -

     Create a new domain class using the **Named Domain Class** tool.

     This tool creates a new class that has a domain property called Name. The **Is Element Name** and **Is Moniker Key** properties of this domain property are initialized to `true`.

- \- or -

     Create an Inheritance relationship from the domain class to another class that has a moniker key property.

### Avoid Duplicate Monikers

If you use qualified key monikers, it's possible that two elements in a user's model could have the same value in the key property. For example, if your DSL has a class Person that has a property Name, the user could set the Names of two elements to be the same. Although the model could be saved to file, it wouldn't reload correctly.

There are several methods that help avoid this situation:

- Set **Is Element Name** = `true` for the key domain property. Select the domain property on the DSL Definition diagram and then set the value in the Properties window.

     When the user creates a new instance of the class, this value causes the domain property to be automatically assigned a different value. The default behavior adds a number to the end of the class name. This doesn't prevent the user from changing the name to a duplicate, but it helps in the case when the user doesn't set the value before saving the model.

- Enable validation for the DSL. In DSL Explorer, select Editor\Validation, and set the **Uses...** properties to `true`.

     There's an automatically generated validation method that checks for ambiguities. The method is in the `Load` validation category. This makes sure that the user will be warned that it might not be possible to reopen the file.

     For more information, see [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md).

### Moniker Paths and Qualifiers

A qualified key moniker ends with the moniker key, and is prefixed with the moniker of its parent in the embedding tree. For example, if the moniker of an Album is:

```xml
<albumMoniker title="/My Favorites/Jazz after Teatime" />
```

Then one of the Songs in that Album could be:

```xml
<songMoniker title="/My Favorites/Jazz after Teatime/Hot tea" />
```

However, if Albums are referenced by ID instead, then the monikers would be as follows:

```xml
<albumMoniker Id="77472c3a-9bf9-4085-976a-d97a4745237c" />
<songMoniker title="/77472c3a-9bf9-4085-976a-d97a4745237c/Hot tea" />
```

Notice that because a GUID is unique, it's never prefixed by the moniker of its parent.

If you know that a particular domain property will always have a unique value within a model, you can set **Is Moniker Qualifier** to `true` for that property. This causes it to be used as a qualifier, without using the moniker of the parent. For example, if you set both **Is Moniker Qualifier** and **Is Moniker Key** for the Title domain property of the Album class, the model's name or identifier isn't used in monikers for Album and its embedded children:

```xml
<albumMoniker name="Jazz after Teatime" />
<songMoniker title="/Jazz after Teatime/Hot tea" />
```

## Customize the structure of the XML

To make the following customizations, expand the **Xml Serialization Behavior** node in DSL Explorer. Under a domain class, expand the Element Data node to see the list of properties and relationships that are sourced at this class. Select a relationship and adjust its options in the Properties window.

- Set **Omit Element** to true to omit the source role node, leaving just the list of target elements. You shouldn't set this option if there's more than one relationship between the source and target classes.

    ```xml
    <familyTreeModel ...>
      <!-- The following node is omitted by using Omit Element: -->
      <!-- <people> -->
        <person name="Henry VIII" .../>
        <person name="Elizabeth I" .../>
      <!-- </people> -->
    </familyTreeModel>
    ```

- Set **Use Full Form** to embed the target nodes in nodes representing the relationship instances. This option is set automatically when you add domain properties to a domain relationship.

    ```xml
    <familyTreeModel ...>
      <people>
        <!-- The following node is inserted by using Use Full Form: -->
        <familyTreeModelHasPeople myRelationshipProperty="x1">
          <person name="Henry VIII" .../>
        </familyTreeModelHasPeople>
        <familyTreeModelHasPeople myRelationshipProperty="x2">
          <person name="Elizabeth I" .../>
        </familyTreeModelHasPeople>
      </people>
    </familyTreeModel>
    ```

- Set **Representation** = **Element** to have a domain property saved as an element instead of as an attribute value.

    ```xml
    <person name="Elizabeth I" birthYear="1533">
      <deathYear>1603</deathYear>
    </person>
    ```

- To change the order in which attributes and relationships are serialized, right-click an item under Element Data, and use the **Move Up** or **Move Down** menu commands.

## Major customization using program code

You can replace parts or all of the serialization algorithms.

We recommend that you study the code in **Dsl\Generated Code\Serializer.cs** and **SerializationHelper.cs**.

### To customize the serialization of a particular class

1. Set **Is Custom** in the node for that class under **Xml Serialization Behavior**.

2. Transform All Templates, build the solution, and investigate the resulting compilation errors. Comments near each error explain what code you have to provide.

### To provide your own serialization for the whole model

1. Override methods in Dsl\GeneratedCode\SerializationHelper.cs

> [!NOTE]
> Starting with Visual Studio 2022 17.13, the default serialization implementation no longer supports the serialization or deserialization of custom data types using BinaryFormatter due to [security risks with BinaryFormatter](/dotnet/standard/serialization/binaryformatter-security-guide).
>
> If you use a custom data type for any domain properties, you need to either override the serialization methods in the `SerializationHelper` class, or implement a `TypeConverter` capable of converting each custom data type to and from a string.
>
> While we do not recommend using `BinaryFormatter` for security reasons, if you must maintain backward compatibility with older models that used `BinaryFormatter` serialization, you can implement a `TypeConverter` that deserializes the binary data. The following code snippet serves as a template for implementing this compatibility:

```csharp
class MyCustomDataTypeConverter : TypeConverter
{
    public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
    {
        return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
    }

    public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
    {
        return destinationType == typeof(string) || base.CanConvertTo(context, destinationType);
    }

    public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
    {
        if (value is string text)
        {
            // First, try to parse the string as if it were returned by MyCustomDataType.ToString().
            if (MyCustomDataType.TryParse(text, out var custom))
                return custom;

            // Fall back to trying to deserialize the old BinaryFormatter serialization format.
            var decoded = Convert.FromBase64String(text);
            using (var memory = new MemoryStream(decoded, false))
            {
                var binaryFormatter = new BinaryFormatter();
                return binaryFormatter.Deserialize(memory) as MyCustomDataType;
            }
        }

        return base.ConvertFrom(context, culture, value);
    }

    public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
    {
        if (destinationType == typeof(string) && value is MyCustomDataType custom)
            return custom.ToString();

        return base.ConvertTo(context, culture, value, destinationType);
    }
}

// ...

[TypeConverter(MyCustomDataTypeConverter)]
class MyCustomDataType
{
    // ...
}
```

## Options in Xml Serialization Behavior

In DSL Explorer, the Xml Serialization Behavior node contains a child node for each domain class, relationship, shape, connector, and diagram class. Under each of those nodes is a list of properties and relationships sourced at that element. Relationships are represented both in their own right and under their source classes.

The following table summarizes the options that you can set in this section of the DSL Definition. In each case, select an element in DSL Explorer, and set the options in the Properties window.

### Xml Class data

These elements are found in DSL Explorer under **Xml Serialization Behavior\Class Data**.

|Property|Description|
|-|-|
|Has Custom Element Schema|If True, indicates that the domain class has a custom element schema|
|Is Custom|Set the value to **True** if you want to write your own serialization and deserialization code for this domain class.<br /><br /> Build the solution and investigate the errors to discover detailed instructions.|
|Domain Class|Domain class to which this class data node applies. Read-only.|
|Element Name|Xml node name for elements of this class. The default value is a lower-case version of the domain class name.|
|Moniker Attribute Name|Name of the attribute used in moniker elements to contain the reference. If blank, the name of the key property or id is used.<br /><br /> In this example, it's "name":  `<personMoniker name="/Mike Nash"/>`|
|Moniker Element Name|Name of the xml element used for monikers that refer to elements of this class.<br /><br /> The default value is a lowercase version of the class name suffixed with "Moniker". For example, `personMoniker`.|
|Moniker Type Name|Name of the xsd type generated for monikers to elements of this class. The XSD is in **Dsl\Generated Code\\\*Schema.xsd**|
|Serialize Id|If True, the element GUID is included in the file. The value *must* be set to **True** if there's no property that is marked **Is Moniker Key** and the DSL defines reference relationships to this class.|
|Type Name|Name of the xml type generated in the xsd from the designated domain class.|
|Notes|Informal notes associated with this element|

### Xml Property Data

Xml Property nodes are found under the class nodes.

|Property|Description|
|-|-|
|Domain Property|Property to which the xml serialization configuration data applies. Read-only.|
|Is Moniker Key|If the value is set to **True**, the property is used as the key for creating monikers that reference instances of this domain class.|
|Is Moniker Qualifier|If the value is set to **True**, the property is used for creating the qualifier in monikers. If false, and if SerializeId isn't true for this domain class, monikers are qualified by the moniker of the parent element in the embedding tree.|
|Representation|If the value is set to **Attribute**, then the property is serialized as an xml attribute; if the value is set to **Element**, then it's serialized as an element; if the value is set to **Ignore**, then it isn't serialized.|
|Xml Name|Name used for the xml attribute or element representing the property. By default, the value is a lower-case version of the domain property name.|
|Notes|Informal notes associated with this element|

### Xml Role data

Role data nodes are found under the source class nodes.

|Property|Description|
|-|-|
|Has Custom Moniker|Set this to true if you want to supply your own code for generating and resolving monikers that traverse this relationship.<br /><br /> For detailed instructions, build the solution, and then double-click the error messages.|
|Domain Relationship|Specifies the relationship to which these options apply. Read-only.|
|Omit Element|If true, the XML node that corresponds to the source role is omitted from the schema.<br /><br /> If there's more than one relationship between the source and target classes, this role node distinguishes between links that belong to the two relationships. We therefore recommend that you don't set this option in this case.|
|Role Element Name|Specifies the name of the XML element that is derived from the source role. The default value is the role property name.|
|Use Full Form|If true, each target element or moniker is enclosed in an XML node representing the relationship. This should be set to true if the relationship has its own domain properties.|

## Related content

- [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md)
- [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md)

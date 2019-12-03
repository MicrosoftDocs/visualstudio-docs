---
title: "Walkthrough: Generating Code by using Text Templates"
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "walkthroughs [text templates], generating application code"
  - "walkthroughs [text templates]"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Walkthrough: Generate Code by using Text Templates

Code generation allows you to produce program code that is strongly typed, and yet can be easily changed when the source model changes. Contrast this with the alternative technique of writing a completely generic program that accepts a configuration file, which is more flexible, but results in code that is neither so easy to read and change, nor has such good performance. This walkthrough demonstrates this benefit.

## Typed code for reading XML

The System.Xml namespace provides comprehensive tools for loading an XML document and then navigating it freely in memory. Unfortunately, all the nodes have the same type, XmlNode. It is therefore very easy to make programming mistakes such as expecting the wrong type of child node, or the wrong attributes.

In this example project, a template reads a sample XML file, and generates classes that correspond to each type of node. In the hand-written code, you can use these classes to navigate the XML file. You can also run your application on any other files that use the same node types. The purpose of the sample XML file is to provide examples of all the node types that you want your application to deal with.

> [!NOTE]
> The application [xsd.exe](/dotnet/standard/serialization/xml-schema-definition-tool-xsd-exe), which is included with Visual Studio, can generate strongly-typed classes from XML files. The template shown here is provided as an example.

Here is the sample file:

```xml
<?xml version="1.0" encoding="utf-8" ?>
<catalog>
  <artist id ="Mike%20Nash" name="Mike Nash Quartet">
    <song id ="MikeNashJazzBeforeTeatime">Jazz Before Teatime</song>
    <song id ="MikeNashJazzAfterBreakfast">Jazz After Breakfast</song>
  </artist>
  <artist id ="Euan%20Garden" name="Euan Garden">
    <song id ="GardenScottishCountry">Scottish Country Garden</song>
  </artist>
</catalog>
```

In the project that this walkthrough constructs, you can write code such as the following, and IntelliSense prompts you with the correct attribute and child names as you type:

```csharp
Catalog catalog = new Catalog(xmlDocument);
foreach (Artist artist in catalog.Artist)
{
  Console.WriteLine(artist.name);
  foreach (Song song in artist.Song)
  {
    Console.WriteLine("   " + song.Text);
  }
}
```

Contrast this with the untyped code that you might write without the template:

```csharp
XmlNode catalog = xmlDocument.SelectSingleNode("catalog");
foreach (XmlNode artist in catalog.SelectNodes("artist"))
{
    Console.WriteLine(artist.Attributes["name"].Value);
    foreach (XmlNode song in artist.SelectNodes("song"))
    {
         Console.WriteLine("   " + song.InnerText);
     }
}
```

In the strongly typed version, a change to the XML schema results in changes to the classes. The compiler highlights the parts of the application code that must be changed. In the untyped version that uses generic XML code, there is no such support.

In this project, a single template file is used to generate the classes that make the typed version possible.

## Set up the Project

### Create or open a C# project

You can apply this technique to any code project. This walkthrough uses a C# project, and for the purposes of testing we use a console application.

1. On the **File** menu click **New** and then click **Project**.

2. Click the **Visual C#** node, and then in the **Templates** pane, click **Console Application.**

### Add a prototype XML file to the project

The purpose of this file is to provide samples of the XML node types that you want your application to be able to read. It could be a file that will be used for testing your application. The template will produce a C# class for each node type in this file.

The file should be part of the project so that the template can read it, but it will not be built into the compiled application.

1. In **Solution Explorer**, right-click the project, click **Add** and then Click **New Item**.

2. In the **Add New Item** dialog box, select **XML File** from the **Templates** pane.

3. Add your sample content to the file.

4. For this walkthrough, name the file `exampleXml.xml`. Set the content of the file to be the XML shown in the previous section.

### Add a test code file

Add a C# file to your project and write in it a sample of the code that you want to be able to write. For example:

```csharp
using System;
namespace MyProject
{
  class CodeGeneratorTest
  {
    public void TestMethod()
    {
      Catalog catalog = new Catalog(@"..\..\exampleXml.xml");
      foreach (Artist artist in catalog.Artist)
      {
        Console.WriteLine(artist.name);
        foreach (Song song in artist.Song)
        {
          Console.WriteLine("   " + song.Text);
} } } } }
```

At this stage, this code will fail to compile. As you write the template, you will generate classes that allow it to succeed.

A more comprehensive test could check the output of this test function against the known content of the example XML file. But in this walkthrough, we will be satisfied when the test method compiles.

### Add a text template file

Add a text template file, and set the output extension to *.cs*.

1. In **Solution Explorer**, right-click the project, click **Add**, and then click **New Item**.

2. In the **Add New Item** dialog box select **Text Template** from the **Templates** pane.

    > [!NOTE]
    > Make sure that you add a Text Template, and not a Preprocessed Text Template.

3. In the file, in the template directive, change the `hostspecific` attribute to `true`.

     This change will enable the template code to gain access to the Visual Studio services.

4. In the output directive, change the extension attribute to ".cs", so that the template generates a C# file. In a Visual Basic project, you would change it to ".vb".

5. Save the file. At this stage, the text template file should contain these lines:

    ```
    <#@ template debug="false" hostspecific="true" language="C#" #>
    <#@ output extension=".cs" #>
    ```

Notice that a .cs file appears in Solution Explorer as a subsidiary of the template file. You can see it by clicking [+] next to the name of the template file. This file is generated from the template file whenever you save or move the focus away from the template file. The generated file will be compiled as part of your project.

For convenience while you develop the template file, arrange the windows of the template file and the generated file so that you can see them next to each other. This lets you see immediately the output of your template. You will also notice that when your template generates invalid C# code, errors will appear in the error message window.

Any edits you perform directly in the generated file will be lost whenever you save the template file. You should therefore either avoid editing the generated file, or edit it only for short experiments. It is sometimes useful to try a short fragment of code in the generated file, where IntelliSense is in operation, and then copy it to the template file.

## Develop the Text Template

Following the best advice on agile development, we will develop the template in small steps, clearing some of the errors at each increment, until the test code compiles and runs correctly.

### Prototype the code to be generated

The test code requires a class for each node in the file. Therefore, some of the compilation errors will go away if you append these lines to the template, and then save it:

```csharp
class Catalog {}
class Artist {}
class Song {}
```

This helps you see what is required, but the declarations should be generated from the node types in the sample XML file. Delete these experimental lines from the template.

### Generate application code from the model XML file

To read the XML file and generate class declarations, replace the template content with the following template code:

```
<#@ template debug="false" hostspecific="true" language="C#" #>
<#@ output extension=".cs" #>
<#@ assembly name="System.Xml"#>
<#@ import namespace="System.Xml" #>
<#
 XmlDocument doc = new XmlDocument();
 // Replace this file path with yours:
 doc.Load(@"C:\MySolution\MyProject\exampleXml.xml");
 foreach (XmlNode node in doc.SelectNodes("//*"))
 {
#>
  public partial class <#= node.Name #> {}
<#
 }
#>
```

Replace the file path with the correct path for your project.

Notice the code block delimiters `<#...#>`. These delimiters bracket a fragment of the program code that generates the text. The expression block delimiters `<#=...#>` bracket an expression that can be evaluated to a string.

When you are writing a template that generates source code for your application, you are dealing with two separate program texts. The program inside the code block delimiters runs every time that you save the template or move the focus to another window. The text that it generates, which appears outside the delimiters, is copied to the generated file and becomes part of your application code.

The `<#@assembly#>` directive behaves like a reference, making the assembly available to the template code. The list of assemblies seen by the template is separate from the list of References in the application project.

The `<#@import#>` directive acts like a `using` statement, allowing you to use the short names of classes in the imported namespace.

Unfortunately, although this template generates code, it produces a class declaration for every node in the example XML file, so that if there are several instances of the `<song>` node, several declarations of the class song will appear.

### Read the model file, then generate the code

Many text templates follow a pattern in which the first part of the template reads the source file, and the second part generates the template. We need to read all of the example file to summarize the node types that it contains, and then generate the class declarations. Another `<#@import#>` is needed so that we can use `Dictionary<>:`

```
<#@ template debug="false" hostspecific="true" language="C#" #>
<#@ output extension=".cs" #>
<#@ assembly name="System.Xml"#>
<#@ import namespace="System.Xml" #>
<#@ import namespace="System.Collections.Generic" #>
<#
 // Read the model file
 XmlDocument doc = new XmlDocument();
 doc.Load(@"C:\MySolution\MyProject\exampleXml.xml");
 Dictionary <string, string> nodeTypes =
        new Dictionary<string, string>();
 foreach (XmlNode node in doc.SelectNodes("//*"))
 {
   nodeTypes[node.Name] = "";
 }
 // Generate the code
 foreach (string nodeName in nodeTypes.Keys)
 {
#>
  public partial class <#= nodeName #> {}
<#
 }
#>
```

### Add an auxiliary method

A class feature control block is a block in which you can define auxiliary methods. The block is delimited by `<#+...#>` and it must appear as the last block in the file.

If you prefer class names to begin with an uppercase letter, you can replace the last part of the template with the following template code:

```
// Generate the code
 foreach (string nodeName in nodeTypes.Keys)
 {
#>
  public partial class <#= UpperInitial(nodeName) #> {}
<#
 }
#>
<#+
 private string UpperInitial(string name)
 { return name[0].ToString().ToUpperInvariant() + name.Substring(1); }
#>
```

At this stage, the generated *.cs* file contains the following declarations:

```csharp
public partial class Catalog {}
public partial class Artist {}
public partial class Song {}
```

More details such as properties for the child nodes, attributes, and inner text can be added using the same approach.

### Access the Visual Studio API

Setting the `hostspecific` attribute of the `<#@template#>` directive allows the template to obtain access to the Visual Studio API. The template can use this to obtain the location of the project files, to avoid using an absolute file path in the template code.

```
<#@ template debug="false" hostspecific="true" language="C#" #>
...
<#@ assembly name="EnvDTE" #>
...
EnvDTE.DTE dte = (EnvDTE.DTE) ((IServiceProvider) this.Host)
                       .GetService(typeof(EnvDTE.DTE));
// Open the prototype document.
XmlDocument doc = new XmlDocument();
doc.Load(System.IO.Path.Combine(dte.ActiveDocument.Path, "exampleXml.xml"));
```

## Complete the Text Template

The following template content generates code that allows the test code to compile and run.

```
<#@ template debug="false" hostspecific="true" language="C#" #>
<#@ output extension=".cs" #>
<#@ assembly name="System.Xml" #>
<#@ assembly name="EnvDTE" #>
<#@ import namespace="System.Xml" #>
<#@ import namespace="System.Collections.Generic" #>
using System;using System.Collections.Generic;using System.Linq;using System.Xml;namespace MyProject{
<#
 // Map node name --> child name --> child node type
 Dictionary<string, Dictionary<string, XmlNodeType>> nodeTypes = new Dictionary<string, Dictionary<string, XmlNodeType>>();

 // The Visual Studio host, to get the local file path.
 EnvDTE.DTE dte = (EnvDTE.DTE) ((IServiceProvider) this.Host)
                       .GetService(typeof(EnvDTE.DTE));
 // Open the prototype document.
 XmlDocument doc = new XmlDocument();
 doc.Load(System.IO.Path.Combine(dte.ActiveDocument.Path, "exampleXml.xml"));
 // Inspect all the nodes in the document.
 // The example might contain many nodes of the same type,
 // so make a dictionary of node types and their children.
 foreach (XmlNode node in doc.SelectNodes("//*"))
 {
   Dictionary<string, XmlNodeType> subs = null;
   if (!nodeTypes.TryGetValue(node.Name, out subs))
   {
     subs = new Dictionary<string, XmlNodeType>();
     nodeTypes.Add(node.Name, subs);
   }
   foreach (XmlNode child in node.ChildNodes)
   {
     subs[child.Name] = child.NodeType;
   }
   foreach (XmlNode child in node.Attributes)
   {
     subs[child.Name] = child.NodeType;
   }
 }
 // Generate a class for each node type.
 foreach (string className in nodeTypes.Keys)
 {
    // Capitalize the first character of the name.
#>
    partial class <#= UpperInitial(className) #>
    {      private XmlNode thisNode;      public <#= UpperInitial(className) #>(XmlNode node)       { thisNode = node; }

<#
    // Generate a property for each child.
    foreach (string childName in nodeTypes[className].Keys)
    {
      // Allow for different types of child.
      switch (nodeTypes[className][childName])
      {
         // Child nodes:
         case XmlNodeType.Element:
#>
      public IEnumerable<<#=UpperInitial(childName)#>><#=UpperInitial(childName) #>      {         get         {            foreach (XmlNode node in                thisNode.SelectNodes("<#=childName#>"))              yield return new <#=UpperInitial(childName)#>(node);       } }
<#
         break;
         // Child attributes:
         case XmlNodeType.Attribute:
#>
      public string <#=childName #>      { get { return thisNode.Attributes["<#=childName#>"].Value; } }
<#
         break;
         // Plain text:
         case XmlNodeType.Text:
#>
      public string Text  { get { return thisNode.InnerText; } }
<#
         break;
       } // switch
     } // foreach class child
  // End of the generated class:
#>
   }
<#
 } // foreach class

   // Add a constructor for the root class
   // that accepts an XML filename.
   string rootClassName = doc.SelectSingleNode("*").Name;
#>
   partial class <#= UpperInitial(rootClassName) #>   {      public <#= UpperInitial(rootClassName) #>(string fileName){        XmlDocument doc = new XmlDocument();        doc.Load(fileName);        thisNode = doc.SelectSingleNode("<#=rootClassName#>");}   }}
<#+
   private string UpperInitial(string name)
   {
      return name[0].ToString().ToUpperInvariant() + name.Substring(1);
   }
#>
```

### Run the test program

In the main of the console application, the following lines will execute the test method. Press F5 to run the program in debug mode:

```csharp
using System;
namespace MyProject
{
  class Program
  {
    static void Main(string[] args)
    {
      new CodeGeneratorTest().TestMethod();
      // Allow user to see the output:
      Console.ReadLine();
    }
  }
}
```

### Write and update the application

The application can now be written in strongly-typed style, using the generated classes instead of using generic XML code.

When the XML schema changes, new classes can easily be generated. The compiler will tell the developer where the application code must be updated.

To regenerate the classes when the example XML file is changed, click **Transform All Templates** in the **Solution Explorer** toolbar.

## Conclusion

This walkthrough demonstrates several techniques and benefits of code generation:

- *Code generation* is the creation of part of the source code of your application from a *model*. The model contains information in a form suited to the application domain, and may change over the lifetime of the application.

- Strong typing is one benefit of code generation. While the model represents information in a form more suitable to the user, the generated code allows other parts of the application to deal with the information using a set of types.

- IntelliSense and the compiler help you create code that adheres to the schema of the model, both when you write new code and when the schema is updated.

- The addition of a single uncomplicated template file to a project can provide these benefits.

- A text template can be developed and tested rapidly and incrementally.

In this walkthrough, the program code is actually generated from an instance of the model, a representative example of the XML files that the application will process. In a more formal approach, the XML schema would be the input to the template, in the form of an .xsd file or a domain-specific language definition. That approach would make it easier for the template to determine characteristics such as the multiplicity of a relationship.

## Troubleshoot the Text Template

If you have seen template transformation or compilation errors in the **Error List**, or if the output file was not generated correctly, you can troubleshoot the text template with the techniques described in [Generating Files with the TextTransform Utility](../modeling/generating-files-with-the-texttransform-utility.md).

## See also

- [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md)
- [Writing a T4 Text Template](../modeling/writing-a-t4-text-template.md)
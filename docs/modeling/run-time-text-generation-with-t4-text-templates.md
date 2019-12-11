---
title: Run-Time Text Generation with T4 Text Templates
ms.date: 11/04/2016
ms.topic: conceptual
dev_langs:
 - CSharp
 - VB
helpviewer_keywords:
  - "Preprocessed Text Template project item"
  - "TextTemplatingFilePreprocessor custom tool"
  - "text templates, TransformText() method"
  - "text templates, generating files at run time"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Run-Time Text Generation with T4 Text Templates

You can generate text strings in your application at run time by using Visual Studio runtime text templates. The computer where the application executes does not have to have Visual Studio. Runtime templates are sometimes called "preprocessed text templates" because at compile time, the template generates code that is executed at run time.

Each template is a mixture of the text as it will appear in the generated string, and fragments of program code. The program fragments supply values for the variable parts of the string, and also control conditional and repeated parts.

For example, the following template could be used in an application that creates an HTML report.

```html
<#@ template language="C#" #>
<html><body>
<h1>Sales for Previous Month</h2>
<table>
    <# for (int i = 1; i <= 10; i++)
       { #>
         <tr><td>Test name <#= i #> </td>
             <td>Test value <#= i * i #> </td> </tr>
    <# } #>
 </table>
This report is Company Confidential.
</body></html>
```

Notice that the template is an HTML page in which the variable parts have been replaced with program code. You could begin the design of such a page by writing a static prototype of the HTML page. You could then replace the table and other variable parts with program code that generates the content that varies from one occasion to the next.

Using a template in your application makes it is easier to see the final form of the output than you could in, for example, a long series of write statements. Making changes to the form of the output is easier and more reliable.

## Creating a Run-Time Text Template in any Application

### To create a run-time text template

1. In Solution Explorer, on the shortcut menu of your project, choose **Add** > **New Item**.

2. In the **Add New Item** dialog box, select **Runtime Text Template**. (In Visual Basic look under **Common Items** > **General**.)

3. Type a name for your template file.

    > [!NOTE]
    > The template file name will be used as a class name in the generated code. Therefore, it should not have spaces or punctuation.

4. Choose **Add**.

    A new file is created that has extension **.tt**. Its **Custom Tool** property is set to **TextTemplatingFilePreprocessor**. It contains the following lines:

    ```
    <#@ template language="C#" #>
    <#@ assembly name="System.Core" #>
    <#@ import namespace="System.Linq" #>
    <#@ import namespace="System.Text" #>
    <#@ import namespace="System.Collections.Generic" #>
    ```

## Converting an Existing File to a Run-Time Template

A good way to create a template is to convert an existing example of the output. For example, if your application will generate HTML files, you can start by creating a plain HTML file. Make sure that it works correctly and that its appearance is correct. Then include it into your Visual Studio project and convert it to a template.

### To convert an existing text file to a run-time template

1. Include the file into your Visual Studio project. In Solution Explorer, on the shortcut menu of the project, choose **Add** > **Existing Item**.

2. Set the file's **Custom Tools** property to **TextTemplatingFilePreprocessor**. In Solution Explorer, on the shortcut menu of the file, choose **Properties**.

    > [!NOTE]
    > If the property is already set, make sure that it is **TextTemplatingFilePreprocessor** and not **TextTemplatingFileGenerator**. This can happen if you include a file that already has the extension **.tt**.

3. Change the file name extension to **.tt**. Although this step is optional, it helps you avoid opening the file in an incorrect editor.

4. Remove any spaces or punctuation from the main part of the file name. For example "My Web Page.tt" would be incorrect, but "MyWebPage.tt" is correct. The file name will be used as a class name in the generated code.

5. Insert the following line at the beginning of the file. If you are working in a Visual Basic project, replace "C#" with "VB".

    `<#@ template language="C#" #>`

## The Content of the Run-Time Template

### Template directive

Keep the first line of the template as it was when you created the file:

`<#@ template language="C#" #>`

The language parameter will depend on the language of your project.

### Plain content

Edit the **.tt** file to contain the text that you want your application to generate. For example:

```html
<html><body>
<h1>Sales for January</h2>
<!-- table to be inserted here -->
This report is Company Confidential.
</body></html>
```

### Embedded program code

You can insert program code between `<#` and `#>`. For example:

```csharp
<table>
    <# for (int i = 1; i <= 10; i++)
       { #>
         <tr><td>Test name <#= i #> </td>
             <td>Test value <#= i * i #> </td> </tr>
    <# } #>
 </table>
```

```vb
<table>
<#
    For i As Integer = 1 To 10
#>
    <tr><td>Test name <#= i #> </td>
      <td>Test value <#= i*i #> </td></tr>
<#
    Next
#>
</table>
```

Notice that statements are inserted between `<# ... #>` and expressions are inserted between `<#= ... #>`. For more information, see [Writing a T4 Text Template](../modeling/writing-a-t4-text-template.md).

## Using the Template

### The code built from the template

When you save the **.tt** file, a subsidiary **.cs** or **.vb** file is generated. To see this file in **Solution Explorer**, expand the **.tt** file node. In a Visual Basic project, first choose **Show All Files** in the **Solution Explorer** toolbar.

Notice that the subsidiary file contains a partial class that contains a method called `TransformText()`. You can call this method from your application.

### Generating text at run time

In your application code, you can generate the content of your template using a call like this:

```csharp
MyWebPage page = new MyWebPage();
String pageContent = page.TransformText();
System.IO.File.WriteAllText("outputPage.html", pageContent);
```

```vb
Dim page = New My.Templates.MyWebPage
Dim pageContent = page.TransformText()
System.IO.File.WriteAllText("outputPage.html", pageContent)
```

To place the generated class in a particular namespace, set the **Custom Tool Namespace** property of the text template file.

### Debugging Runtime Text Templates

Debug and test runtime text templates in the same way as ordinary code.

You can set a breakpoint in a text template. If you start the application in debugging mode from Visual Studio, you can step through the code and evaluate watch expressions in the usual way.

### Passing parameters in the constructor

Usually a template must import some data from other parts of the application. To make this easy, the code built by the template is a partial class. You can create another part of the same class in another file in your project. That file can include a constructor with parameters, properties and functions that can be accessed both by the code that is embedded in the template, and by the rest of the application.

For example, you could create a separate file **MyWebPageCode.cs**:

```csharp
partial class MyWebPage
{
    private MyData m_data;
    public MyWebPage(MyData data) { this.m_data = data; }}
```

In your template file **MyWebPage.tt**, you could write:

```html
<h2>Sales figures</h2>
<table>
<# foreach (MyDataItem item in m_data.Items)
   // m_data is declared in MyWebPageCode.cs
   { #>
      <tr><td> <#= item.Name #> </td>
          <td> <#= item.Value #> </td></tr>
<# } // end of foreach
#>
</table>
```

To use this template in the application:

```csharp
MyData data = ...;
MyWebPage page = new MyWebPage(data);
String pageContent = page.TransformText();
System.IO.File.WriteAllText("outputPage.html", pageContent);
```

#### Constructor parameters in Visual Basic

In Visual Basic, the separate file **MyWebPageCode.vb** contains:

```vb
Namespace My.Templates
  Partial Public Class MyWebPage
    Private m_data As MyData
    Public Sub New(ByVal data As MyData)
      m_data = data
    End Sub
  End Class
End Namespace
```

The template file could contain:

```html
<#@ template language="VB" #>
<html><body>
<h1>Sales for January</h2>
<table>
<#
    For Each item In m_data.Items
#>
    <tr><td>Test name <#= item.Name #> </td>
      <td>Test value <#= item.Value #> </td></tr>
<#
    Next
#>
</table>
This report is Company Confidential.
</body></html>
```

The template can invoked by passing the parameter in the constructor:

```vb
Dim data = New My.Templates.MyData
    ' Add data values here ....
Dim page = New My.Templates.MyWebPage(data)
Dim pageContent = page.TransformText()
System.IO.File.WriteAllText("outputPage.html", pageContent)
```

#### Passing data in template properties

An alternative way of passing data to the template is to add public properties to the template class in a partial class definition. Your application can set the properties before invoking `TransformText()`.

You can also add fields to your template class in a partial definition. This enables you to pass data between successive executions of the template.

### Use partial classes for code

Many developers prefer to avoid writing large bodies of code in templates. Instead, you can define methods in a partial class that has the same name as the template file. Call those methods from the template. In this way, the template shows more clearly what the target output string will look like. Discussions about the appearance of the result can be separated from the logic of creating the data that it displays.

### Assemblies and references

If you want your template code to reference a .NET or other assembly such as **System.Xml.dll**, add it to your project's **References** in the usual manner.

If you want to import a namespace in the same way as a `using` statement, you can do this with the `import` directive:

```
<#@ import namespace="System.Xml" #>
```

These directives must be placed at the beginning of the file, immediately after the `<#@template` directive.

### Shared content

If you have text that is shared between several templates, you can place it in a separate file and include it in each file in which it should appear:

```
<#@include file="CommonHeader.txt" #>
```

The included content can contain any mixture of program code and plain text, and it can contain other include directives and other directives.

The include directive can be used anywhere within the text of a template file or an included file.

### Inheritance between Run-Time Text Templates

You can share content between run-time templates by writing a base class template, which can be abstract. Use the `inherits` parameter of the `<@#template#>` directive to reference another runtime template class.

#### Inheritance pattern: Fragments in Base Methods

In the pattern used in the example that follows, notice the following points:

- The base class `SharedFragments` defines methods within class feature blocks `<#+ ... #>`.

- The base class contains no free text. Instead, all of its text blocks occur inside the class feature methods.

- The derived class invokes the methods defined in `SharedFragments`.

- The application calls the `TextTransform()` method of the derived class, but does not transform the base class `SharedFragments`.

- Both the base and derived classes are runtime text templates; that is, the **Custom Tool** property is set to **TextTemplatingFilePreprocessor**.

**SharedFragments.tt:**

```
<#@ template language="C#" #>
<#+
protected void SharedText(int n)
{
#>
   Shared Text <#= n #>
<#+
}
// Insert more methods here if required.
#>
```

**MyTextTemplate1.tt:**

```
<#@ template language="C#" inherits="SharedFragments" #>
begin 1
   <# SharedText(2); #>
end 1
```

**MyProgram.cs:**

```csharp
...
MyTextTemplate1 t1  = new MyTextTemplate1();
string result = t1.TransformText();
Console.WriteLine(result);
```

**The resulting output:**

```
begin 1
    Shared Text 2
end 1
```

#### Inheritance Pattern: Text in Base Body

In this alternative approach to using template inheritance, the bulk of the text is defined in the base template. The derived templates provide data and text fragments that fit into the base content.

**AbstractBaseTemplate1.tt:**

```
<#@ template language="C#" #>

Here is the description for this derived template:
  <#= this.Description #>

Here is the fragment specific to this derived template:
<#
  this.PushIndent("  ");
  SpecificFragment(42);
  this.PopIndent();
#>
End of common template.
<#+
  // State set by derived class before calling TextTransform:
  protected string Description = "";
  // 'abstract' method to be defined in derived classes:
  protected virtual void SpecificFragment(int n) { }
#>
```

**DerivedTemplate1.tt:**

```
<#@ template language="C#" inherits="AbstractBaseTemplate1" #>
<#
  // Set the base template properties:
  base.Description = "Description for this derived class";

  // Run the base template:
  base.TransformText();

#>
End material for DerivedTemplate1.

<#+
// Provide a fragment specific to this derived template:

protected override void SpecificFragment(int n)
{
#>
   Specific to DerivedTemplate1 : <#= n #>
<#+
}
#>
```

**Application code:**

```csharp
...
DerivedTemplate1 t1 = new DerivedTemplate1();
string result = t1.TransformText();
Console.WriteLine(result);
```

**Resulting output:**

```
Here is the description for this derived template:
  Description for this derived class

Here is the fragment specific to this derived template:
     Specific to DerivedTemplate1 : 42
End of common template.
End material for DerivedTemplate1.
```

## Related Topics

Design-time templates: If you want to use a template to generate code that becomes part of your application, see [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md).

Run-time templates can be used in any application where the templates and their content are determined at compile time. But if you want to write a Visual Studio extension that generates text from templates that change at run time, see [Invoking Text Transformation in a VS Extension](../modeling/invoking-text-transformation-in-a-vs-extension.md).

## See also

- [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md)
- [Writing a T4 Text Template](../modeling/writing-a-t4-text-template.md)
- [T4 Toolbox](http://olegsych.com/T4Toolbox/)

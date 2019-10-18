---
title: T4 Include Directive
ms.date: 11/04/2016
ms.topic: reference
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# T4 Include Directive

In a text template in Visual Studio, you can include text from another file by using an `<#@include#>` directive. You can place `include` directives anywhere in a text template before the first class feature block `<#+ ... #>`. The included files can also contain `include` directives, and other directives. This allows you to share template code and boilerplate text between templates.

## Using Include Directives

```
<#@ include file="filePath" [once="true"] #>
```

- `filePath` can be absolute, or relative to the current template file.

   In addition, specific Visual Studio extensions can specify their own directories to search for include files. For example, when you have installed the Visualization and Modeling SDK (DSL Tools), the following folder is added to the include list: `Program Files\Microsoft Visual Studio 10.0\Common7\IDE\Extensions\Microsoft\DSL SDK\DSL Designer\11.0\TextTemplates`.

   These additional include folders might depend on the file extension of the including file. For example, the DSL Tools include folder is only accessible to including files that have the file extension `.tt`

- `filePath` can include environment variables delimited with "%". For example:

  ```
  <#@ include file="%HOMEPATH%\MyIncludeFile.t4" #>
  ```

- The name of an included file does not have to use the extension `".tt"`.

   You might want to use another extension such as `".t4"` for included files. This is because, when you add a `.tt` file to a project, Visual Studio automatically sets its **Custom Tool** property to `TextTemplatingFileGenerator`. You do not usually want included files to be transformed individually.

   On the other hand, you should be aware that in some cases, the file extension affects which additional folders will be searched for include files. This might be important when you have an included file that includes other files.

- The included content is processed almost as if it were part of the including text template. However, you can include a file that contains a class feature block `<#+...#>` even if the `include` directive is followed by ordinary text and standard control blocks.

- Use `once="true"` to ensure that a template is included only once, even if it's invoked from more than one other include file.

   This feature makes it easy to build up a library of reusable T4 snippets that you can include at will without worrying that some other snippet has already included them.  For example, suppose you have a library of very fine-grained snippets that deal with template processing and C# generation.  In turn, these are used by some more task-specific utilities such as generating exceptions, which you can then use from any more application-specific template. If you draw the dependency graph, you see that some snippets would be included several times. But the `once` parameter prevents the subsequent inclusions.

  **MyTextTemplate.tt:**

```
<#@ output extension=".txt" #>
Output message 1 (from top template).
<#@ include file="TextFile1.t4"#>
Output message 5 (from top template).
<#
   GenerateMessage(6); // defined in TextFile1.t4
   AnotherGenerateMessage(7); // defined in TextFile2.t4
#>
```

 **TextFile1.t4:**

```
   Output Message 2 (from included file).
<#@ include file="TextFile2.t4" #>
   Output Message 4 (from included file).
<#+ // Start of class feature control block.
void GenerateMessage(int n)
{
#>
   Output Message <#= n #> (from GenerateMessage method).
<#+
}
#>
```

 **TextFile2.t4:**

```
        Output Message 3 (from included file 2).
<#+ // Start of class feature control block.
void AnotherGenerateMessage(int n)
{
#>
       Output Message <#= n #> (from AnotherGenerateMessage method).
<#+
}
#>
```

 **The resulting generated file, MyTextTemplate.txt:**

```
Output message 1 (from top template).
   Output Message 2 (from included file).
        Output Message 3 (from included file 2).

   Output Message 4 (from included file).

Output message 5 (from top template).
   Output Message 6 (from GenerateMessage method).
       Output Message 7 (from AnotherGenerateMessage method).
```

## <a name="msbuild"></a> Using project properties in MSBuild and Visual Studio
 Although you can use Visual Studio macros like $(SolutionDir) in an include directive, they don't work in MSBuild. If you want to transform templates in your build machine, you have to use project properties instead.

 Edit your .csproj or .vbproj file to define a project property. This example defines a property named `myIncludeFolder`:

```xml
<!-- Define a project property, myIncludeFolder: -->
<PropertyGroup>
    <myIncludeFolder>$(MSBuildProjectDirectory)\..\libs</myIncludeFolder>
</PropertyGroup>

<!-- Tell the MSBuild T4 task to make the property available: -->
<ItemGroup>
    <T4ParameterValues Include="myIncludeFolder">
      <Value>$(myIncludeFolder)</Value>
    </T4ParameterValues>
  </ItemGroup>
```

 Now you can use your project property in text templates, which transform correctly in both Visual Studio and MSBuild:

```
<#@ include file="$(myIncludeFolder)\defs.tt" #>
```

---
title: "MSBuild Inline Tasks | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
helpviewer_keywords: 
  - "MSBuild, tasks"
ms.assetid: e72e6506-4a11-4edf-ae8d-cfb5a3b9d8a0
caps.latest.revision: 23
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Inline Tasks
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

MSBuild tasks are typically created by compiling a class that implements the <xref:Microsoft.Build.Framework.ITask> interface. For more information, see [Tasks](../msbuild/msbuild-tasks.md).  
  
 Starting in .NET Framework version 4, you can create tasks inline in the project file. You do not have to create a separate assembly to host the task. This makes it easier to keep track of source code and easier to deploy the task. The source code is integrated into the script.  
  
## The Structure of an Inline Task  
 An inline task is contained by a [UsingTask](../msbuild/usingtask-element-msbuild.md) element. The inline task and the `UsingTask` element that contains it are typically included in a .targets file and imported into other project files as required. Here is a basic inline task. Notice that it does nothing.  
  
```  
<Project ToolsVersion="12.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <!-- This simple inline task does nothing. -->  
  <UsingTask  
    TaskName="DoNothing"  
    TaskFactory="CodeTaskFactory"  
    AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v12.0.dll" >  
    <ParameterGroup />  
    <Task>  
      <Reference Include="" />  
      <Using Namespace="" />  
      <Code Type="Fragment" Language="cs">  
      </Code>  
    </Task>  
  </UsingTask>  
</Project>  
```  
  
 The `UsingTask` element in the example has three attributes that describe the task and the inline task factory that compiles it.  
  
- The `TaskName` attribute names the task, in this case, `DoNothing`.  
  
- The `TaskFactory` attribute names the class that implements the inline task factory.  
  
- The `AssemblyFile` attribute gives the location of the inline task factory. Alternatively, you can use the `AssemblyName` attribute to specify the fully qualified name of the inline task factory class, which is typically located in the global assembly cache (GAC).  
  
  The remaining elements of the `DoNothing` task are empty and are provided to illustrate the order and structure of an inline task. A more robust example is presented later in this topic.  
  
- The `ParameterGroup` element is optional. When specified, it declares the parameters for the task. For more information about input and output parameters, see "Input and Output Parameters" later in this topic.  
  
- The `Task` element describes and contains the task source code.  
  
- The `Reference` element specifies references to the .NET assemblies that you are using in your code. This is equivalent to adding a reference to a project in Visual Studio. The `Include` attribute specifies the path of the referenced assembly.  
  
- The `Using` element lists the namespaces that you want to access. This resembles the `Using` statement in Visual C#. The `Namespace` attribute specifies the namespace to include.  
  
  `Reference` and `Using` elements are language-agnostic. Inline tasks can be written in any one of the supported .NET CodeDom languages, for example, Visual Basic or Visual C#.  
  
> [!NOTE]
> Elements contained by the `Task` element are specific to the task factory, in this case, the code task factory.  
  
### Code Element  
 The last child element to appear within the `Task` element is the `Code` element. The `Code` element contains or locates the code that you want to be compiled into a task. What you put in the `Code` element depends on how you want to write the task.  
  
 The `Language` attribute specifies the language in which your code is written. Acceptable values are `cs` for C#, `vb` for Visual Basic.  
  
 The `Type` attribute specifies the type of code that is found in the `Code` element.  
  
- If the value of `Type` is `Class`, then the `Code` element contains code for a class that derives from the <xref:Microsoft.Build.Framework.ITask> interface.  
  
- If the value of `Type` is `Method`, then the code defines an override of the `Execute` method of the <xref:Microsoft.Build.Framework.ITask> interface.  
  
- If the value of `Type` is `Fragment`, then the code defines the contents of the `Execute` method, but not the signature or the `return` statement.  
  
  The code itself typically appears between a `<![CDATA[` marker and a `]]>` marker. Because the code is in a CDATA section, you do not have to worry about escaping reserved characters, for example, "\<" or ">".  
  
  Alternatively, you can use the `Source` attribute of the `Code` element to specify the location of a file that contains the code for your task. The code in the source file must be of the type that is specified by the `Type` attribute. If the `Source` attribute is present, the default value of `Type` is `Class`. If `Source` is not present, the default value is `Fragment`.  
  
> [!NOTE]
> When defining the task class in the source file, the class name must agree with the `TaskName` attribute of the corresponding [UsingTask](../msbuild/usingtask-element-msbuild.md) element.  
  
## Hello World  
 Here is a more robust inline task. The HelloWorld task displays "Hello, world!" on the default error logging device, which is typically the system console or the Visual Studio **Output** window. The `Reference` element in the example is included just for illustration.  
  
```  
<Project ToolsVersion="12.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <!-- This simple inline task displays "Hello, world!" -->  
  <UsingTask  
    TaskName="HelloWorld"  
    TaskFactory="CodeTaskFactory"  
    AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v4.0.dll" >  
    <ParameterGroup />  
    <Task>  
      <Reference Include="System.Xml"/>  
      <Using Namespace="System"/>  
      <Using Namespace="System.IO"/>  
      <Code Type="Fragment" Language="cs">  
<![CDATA[  
// Display "Hello, world!"  
Log.LogError("Hello, world!");  
]]>  
      </Code>  
    </Task>  
  </UsingTask>  
</Project>  
```  
  
 You could save the HelloWorld task in a file that is named HelloWorld.targets, and then invoke it from a project as follows.  
  
```  
<Project ToolsVersion="4.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">  
  <Import Project="HelloWorld.targets" />  
  <Target Name="Hello">  
    <HelloWorld />  
  </Target>  
</Project>  
```  
  
## Input and Output Parameters  
 Inline task parameters are child elements of a `ParameterGroup` element. Every parameter takes the name of the element that defines it. The following code defines the parameter `Text`.  
  
```  
<ParameterGroup>  
    <Text />  
</ParameterGroup>  
```  
  
 Parameters may have one or more of these attributes:  
  
- `Required` is an optional attribute that is `false` by default. If `true`, then the parameter is required and must be given a value before calling the task.  
  
- `ParameterType` is an optional attribute that is `System.String` by default. It may be set to any fully qualified type that is either an item or a value that can be converted to and from a string by using System.Convert.ChangeType. (In other words, any type that can be passed to and from an external task.)  
  
- `Output` is an optional attribute that is `false` by default. If `true`, then the parameter must be given a value before returning from the Execute method.  
  
  For example,  
  
```  
<ParameterGroup>  
    <Expression Required="true" />  
      <Files ParameterType="Microsoft.Build.Framework.ITaskItem[]" Required="true" />  
    <Tally ParameterType="System.Int32" Output="true" />  
</ParameterGroup>  
```  
  
 defines these three parameters:  
  
- `Expression` is a required input parameter of type System.String.  
  
- `Files` is a required item list input parameter.  
  
- `Tally` is an output parameter of type System.Int32.  
  
  If the `Code` element has the `Type` attribute of `Fragment` or `Method`, then properties are automatically created for every parameter. Otherwise, properties must be explicitly declared in the task source code, and must exactly match their parameter definitions.  
  
## Example  
 The following inline task replaces every occurrence of a token in the given file with the given value.  
  
```  
<Project xmlns='http://schemas.microsoft.com/developer/msbuild/2003' ToolsVersion="12.0">  
  
  <UsingTask TaskName="TokenReplace" TaskFactory="CodeTaskFactory" AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v12.0.dll">  
    <ParameterGroup>  
      <Path ParameterType="System.String" Required="true" />  
      <Token ParameterType="System.String" Required="true" />  
      <Replacement ParameterType="System.String" Required="true" />  
    </ParameterGroup>  
    <Task>  
      <Code Type="Fragment" Language="cs"><![CDATA[  
string content = File.ReadAllText(Path);  
content = content.Replace(Token, Replacement);  
File.WriteAllText(Path, content);  
  
]]></Code>  
    </Task>  
  </UsingTask>  
  
  <Target Name='Demo' >  
    <TokenReplace Path="C:\Project\Target.config" Token="$MyToken$" Replacement="MyValue"/>  
  </Target>  
</Project>  
```  
  
## See Also  
 [Tasks](../msbuild/msbuild-tasks.md)   
 [Walkthrough: Creating an Inline Task](../msbuild/walkthrough-creating-an-inline-task.md)

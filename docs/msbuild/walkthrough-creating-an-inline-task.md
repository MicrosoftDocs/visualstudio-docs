---
title: "Walkthrough: Creating an Inline Task | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "MSBuild, tutorial"
  - "MSBuild, tasks"
ms.assetid: 438194cb-668c-41a9-a7e2-c118d14c1ea7
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# Walkthrough: Create an inline task
MSBuild tasks are typically created by compiling a class that implements the <xref:Microsoft.Build.Framework.ITask> interface. Starting with the .NET Framework version 4, you can create tasks inline in the project file. You do not have to create a separate assembly to host the task. For more information, see [Inline tasks](../msbuild/msbuild-inline-tasks.md).

 This walkthrough shows how to create and run these inline tasks:

- A task that has no input or output parameters.

- A task that has one input parameter and no output parameters.

- A task that has two input parameters, and one output parameter that returns an MSBuild property.

- A task that has two input parameters, and one output parameter that returns an MSBuild item.

To create and run the tasks, use Visual Studio and the **Visual Studio Command Prompt Window**, as follows:

1. Create an MSBuild project file by using Visual Studio.

2. Modify the project file in Visual Studio to create the inline task.

3. Use the **Command Prompt Window** to build the project and examine the results.

## Create and modify an MSBuild project
 The Visual Studio project system is based on MSBuild. Therefore, you can create a build project file by using Visual Studio. In this section, you create a Visual C# project file. (You can create a Visual Basic project file instead. In the context of this tutorial, the difference between the two project files is minor.)

#### To create and modify a project file

1. In Visual Studio, on the **File** menu, click **New** and then click **Project**.

2. In the **New Project** dialog box, select the **Visual C#** project type, and then select the **Windows Forms Application** template. In the **Name** box, type `InlineTasks`. Type a **Location** for the solution, for example, *D:\\*. Ensure that **Create directory for solution** is selected, **Add to Source Control** is cleared, and **Solution Name** is **InlineTasks**.

3. Click **OK** to create the project file.

3. In **Solution Explorer**, right-click the **InlineTasks** project node, and then click **Unload Project**.

4. Right-click the project node again, and then click **Edit InlineTasks.csproj**.

     The project file appears in the code editor.

## Add a basic Hello task
 Now, add to the project file a basic task that displays the message "Hello, world!" Also add a default TestBuild target to invoke the task.

#### To add a basic Hello task

1. In the root `Project` node, change the `DefaultTargets` attribute to `TestBuild`.The resulting `Project` node should resemble this example:

   ```xml
   <Project ToolsVersion="4.0" DefaultTargets="TestBuild" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
   ```

2. Add the following inline task and target to the project file just before the `</Project>` tag.

   ```xml
   <UsingTask TaskName="Hello" TaskFactory="CodeTaskFactory" AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v4.0.dll" >
     <ParameterGroup />
     <Task>
       <Code Type="Fragment" Language="cs">
         Log.LogMessage("Hello, world!", MessageImportance.High);
       </Code>
     </Task>
   </UsingTask>
   <Target Name="TestBuild">
     <Hello />
   </Target>
   ```

3. Save the project file.

   This code creates an inline task that is named Hello and has no parameters, references, or `Using` directives. The Hello task contains just one line of code, which displays a hello message on the default logging device, typically the console window.

### Run the Hello task
 Run MSBuild by using the **Command Prompt Window** to construct the Hello task and to process the TestBuild target that invokes it.

##### To run the Hello task

1. Click **Start**, click **All Programs**, and then locate the **Visual Studio Tools** folder and click **Visual Studio Command Prompt**.

2. In the **Command Prompt Window**, locate the folder that contains the project file, in this case, *D:\InlineTasks\InlineTasks\\*.

3. Type **msbuild** without command switches, and then press **Enter**. By default, this builds the *InlineTasks.csproj* file and processes the default target TestBuild, which invokes the Hello task.

4. Examine the output in the **Command Prompt Window**. You should see this line:

    `Hello, world!`

   > [!NOTE]
   > If you do not see the hello message, try saving the project file again and then run the Hello task.

   By alternating between the code editor and the **Command Prompt Window**, you can change the project file and quickly see the results.

## Define the Echo task
 Create an inline task that accepts a string parameter and displays the string on the default logging device.

#### To define the Echo task

1. In the code editor, replace the Hello task and TestBuild target by using the following code.

   ```xml
   <UsingTask TaskName="Echo" TaskFactory="CodeTaskFactory" AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v4.0.dll" >
     <ParameterGroup>
       <Text Required="true" />
     </ParameterGroup>
     <Task>
       <Code Type="Fragment" Language="cs">
         Log.LogMessage(Text, MessageImportance.High);
       </Code>
     </Task>
   </UsingTask>
   <Target Name="TestBuild">
     <Echo Text="Greetings!" />
   </Target>
   ```

2. In the **Command Prompt Window**, type **msbuild** without command switches, and then press **Enter**. By default, this processes the default target TestBuild, which invokes the Echo task.

3. Examine the output in the **Command Prompt Window**. You should see this line:

    `Greetings!`

   This code defines an inline task that is named Echo and has just one required input parameter Text. By default, parameters are of type System.String. The value of the Text parameter is set when the TestBuild target invokes the Echo task.

## Define the Adder task
 Create an inline task that adds two integer parameters and emits their sum as an MSBuild property.

#### To define the Adder task

1. In the code editor, replace the Echo task and TestBuild target by using the following code.

   ```xml
   <UsingTask TaskName="Adder" TaskFactory="CodeTaskFactory" AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v4.0.dll" >
     <ParameterGroup>
       <A ParameterType="System.Int32" Required="true" />
       <B ParameterType="System.Int32" Required="true" />
       <C ParameterType="System.Int32" Output="true" />
     </ParameterGroup>
     <Task>
       <Code Type="Fragment" Language="cs">
         C = A + B;
       </Code>
     </Task>
   </UsingTask>
   <Target Name="TestBuild">
     <Adder A="4" B="5">
       <Output PropertyName="Sum" TaskParameter="C" />
     </Adder>
     <Message Text="The sum is $(Sum)" Importance="High" />
   </Target>
   ```

2. In the **Command Prompt Window**, type **msbuild** without command switches, and then press **Enter**. By default, this processes the default target TestBuild, which invokes the Echo task.

3. Examine the output in the **Command Prompt Window**. You should see this line:

    `The sum is 9`

   This code defines an inline task that is named Adder and has two required integer input parameters, A and B, and one integer output parameter, C. The Adder task adds the two input parameters and returns the sum in the output parameter. The sum is emitted as the MSBuild property `Sum`. The values of the input parameters are set when the TestBuild target invokes the Adder task.

## Define the RegX task
 Create an inline task that accepts an item group and a regular expression, and returns a list of all items that have file content that matches the expression.

#### To define the RegX task

1. In the code editor, replace the Adder task and TestBuild target by using the following code.

   ```xml
   <UsingTask TaskName="RegX" TaskFactory="CodeTaskFactory" AssemblyFile="$(MSBuildToolsPath)\Microsoft.Build.Tasks.v4.0.dll" >
     <ParameterGroup>
       <Expression Required="true" />
       <Files ParameterType="Microsoft.Build.Framework.ITaskItem[]" Required="true" />
       <Result ParameterType="Microsoft.Build.Framework.ITaskItem[]" Output="true" />
     </ParameterGroup>
     <Task>
       <Using Namespace="System.Text.RegularExpressions"/>
       <Code Type="Fragment" Language="cs">
   <![CDATA[
         if (Files.Length > 0)
         {
           Result = new TaskItem[Files.Length];
           for (int i = 0; i < Files.Length; i++)
           {
             ITaskItem item = Files[i];
             string path = item.GetMetadata("FullPath");
             using(StreamReader rdr = File.OpenText(path))
             {
               if (Regex.Match(rdr.ReadToEnd(), Expression).Success)
               {
                 Result[i] = new TaskItem(item.ItemSpec);
               }
             }
           }
         }
   ]]>
       </Code>
     </Task>
   </UsingTask>
   <Target Name="TestBuild">
     <RegX Expression="public|protected" Files="@(Compile)">
       <Output ItemName="MatchedFiles" TaskParameter="Result" />
     </RegX>
     <Message Text="Input files: @(Compile)" Importance="High" />
     <Message Text="Matched files: @(MatchedFiles)" Importance="High" />
   </Target>
   ```

2. In the **Command Prompt Window**, type **msbuild** without command switches, and then press **Enter**. By default, this processes the default target TestBuild, which invokes the RegX task.

3. Examine the output in the **Command Prompt Window**. You should see these lines:

   ```
   Input files: Form1.cs;Form1.Designer.cs;Program.cs;Properties\AssemblyInfo.cs;Properties\Resources.Designer.cs;Properties\Settings.Designer.cs
   ```

   ```
   Matched files: Form1.cs;Form1.Designer.cs;Properties\Settings.Designer.cs
   ```

   This code defines an inline task that is named RegX and has these three parameters:

- `Expression` is a required string input parameter that has a value that is the regular expression to be matched. In this example, the expression matches the words "public" or "protected".

- `Files` is a required item list input parameter that has a value that is a list of files to be searched for the match. In this example, `Files` is set to the `Compile` item, which lists the project source files.

- `Result` is an output parameter that has a value that is the list of files that have contents that match the regular expression.

  The value of the input parameters are set when the TestBuild target invokes the RegX task. The RegX task reads every file and returns the list of files that match the regular expression. This list is returned as the `Result` output parameter, which is emitted as the MSBuild item `MatchedFiles`.

### Handle reserved characters
 The MSBuild parser processes inline tasks as XML. Characters that have reserved meaning in XML, for example, "\<" and ">", are detected and handled as if they were XML, and not .NET source code. To include the reserved characters in code expressions such as `Files.Length > 0`, write the `Code` element so that its contents are contained in a CDATA expression, as follows:

 ```xml
<Code Type="Fragment" Language="cs">
  <![CDATA[

  // Your code goes here.

  ]]>
</Code>
```

## See also
- [Inline tasks](../msbuild/msbuild-inline-tasks.md)
- [Tasks](../msbuild/msbuild-tasks.md)
- [Targets](../msbuild/msbuild-targets.md)

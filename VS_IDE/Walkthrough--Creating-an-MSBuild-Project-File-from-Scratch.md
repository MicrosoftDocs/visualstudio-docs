---
title: "Walkthrough: Creating an MSBuild Project File from Scratch"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e3acff7c-cb4e-4ae1-8be2-a871bcff847b
caps.latest.revision: 17
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Walkthrough: Creating an MSBuild Project File from Scratch
<?xml version="1.0" encoding="utf-8"?>
<developerWalkthroughDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Programming languages that target the .NET Framework use MSBuild project files to describe and control the application build process. When you use Visual Studio to create an MSBuild project file, the appropriate XML is added to the file automatically. However, you may find it helpful to understand how the XML is organized and how you can change it to control a build. </para>
    <para>For information about creating a project file for a C++ project, see <link xlink:href="7a1be7ff-0312-4669-adf2-5f5bf507d560">Walkthrough: Using MSBuild to Create a Visual C++ Project</link>.</para>
    <para>This walkthrough shows how to create a basic project file incrementally, by using only a text editor. The walkthrough follows these steps:</para>
    <list class="bullet">
      <listItem>
        <para>Create a minimal application source file.</para>
      </listItem>
      <listItem>
        <para>Create a minimal MSBuild project file.</para>
      </listItem>
      <listItem>
        <para>Extend the PATH environment variable to include MSBuild.</para>
      </listItem>
      <listItem>
        <para>Build the application by using the project file.</para>
      </listItem>
      <listItem>
        <para>Add properties to control the build.</para>
      </listItem>
      <listItem>
        <para>Control the build by changing property values.</para>
      </listItem>
      <listItem>
        <para>Add targets to the build.</para>
      </listItem>
      <listItem>
        <para>Control the build by specifying targets.</para>
      </listItem>
      <listItem>
        <para>Build incrementally.</para>
      </listItem>
    </list>
    <para>This walkthrough shows how to build the project at the command prompt and examine the results. For more information about MSBuild and how to run MSBuild at the command prompt, see <link xlink:href="b8a8b866-bb07-4abf-b9ec-0b40d281c310">MSBuild Tutorial 1</link>. </para>
    <para>To complete the walkthrough, you must have the .NET Framework (version 2.0, 3.5, 4.0, or 4.5) installed because it includes MSBuild and the Visual C# compiler, which are required for the walkthrough.</para>
  </introduction>
  <section>
    <title>Creating a Minimal Application</title>
    <content>
      <para>This section shows how to create a minimal Visual C# application source file by using a text editor. </para>
      <procedure>
        <title>To create the minimal application</title>
        <steps class="ordered">
          <step>
            <content>
              <para>At the command prompt, browse to the folder where you want to create the application, for example, \My Documents\ or \Desktop\.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Type <system>md HelloWorld</system> to create a subfolder named \HelloWorld\.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Type <system>cd HelloWorld</system> to change to the new folder.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Start Notepad or another text editor, and then type the following code.</para>
              <code>using System;

class HelloWorld
{
    static void Main()
    {
#if DebugConfig
        Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");
#endif

        Console.WriteLine("Hello, world!");
    }
}</code>
            </content>
          </step>
          <step>
            <content>
              <para>Save this source code file and name it Helloworld.cs.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Build the application by typing <system>csc helloworld.cs</system> at the command prompt.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Test the application by typing <system>helloworld</system> at the command prompt.</para>
              <para>The <system>Hello, world!</system> message should be displayed.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Delete the application by typing <system>del helloworld.exe</system> at the command prompt.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Creating a Minimal MSBuild Project File</title>
    <content>
      <para>Now that you have a minimal application source file, you can create a minimal project file to build the application. This project file contains the following elements:</para>
      <list class="bullet">
        <listItem>
          <para>The required root <languageKeyword>Project</languageKeyword> node.</para>
        </listItem>
        <listItem>
          <para>An <languageKeyword>ItemGroup</languageKeyword> node to contain item elements.</para>
        </listItem>
        <listItem>
          <para>An item element that refers to the application source file.</para>
        </listItem>
        <listItem>
          <para>A <languageKeyword>Target</languageKeyword> node to contain tasks that are required to build the application.</para>
        </listItem>
        <listItem>
          <para>A <languageKeyword>Task</languageKeyword> element to start the Visual C# compiler to build the application.</para>
        </listItem>
      </list>
      <procedure>
        <title>To create a minimal MSBuild project file</title>
        <steps class="ordered">
          <step>
            <content>
              <para>In the text editor, replace the existing text by using these two lines:</para>
              <code>&lt;Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;
&lt;/Project&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Insert this <languageKeyword>ItemGroup</languageKeyword> node as a child element of the <languageKeyword>Project</languageKeyword> node:</para>
              <code>  &lt;ItemGroup&gt;
    &lt;Compile Include="helloworld.cs" /&gt;
  &lt;/ItemGroup&gt;</code>
              <para>Notice that this <languageKeyword>ItemGroup</languageKeyword> already contains an item element.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Add a <languageKeyword>Target</languageKeyword> node as a child element of the <languageKeyword>Project</languageKeyword> node. Name the node <userInput>Build</userInput>.</para>
              <code>  &lt;Target Name="Build"&gt;
  &lt;/Target&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Insert this task element as a child element of the <languageKeyword>Target</languageKeyword> node:</para>
              <code>    &lt;Csc Sources="@(Compile)"/&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Save this project file and name it Helloworld.csproj.</para>
            </content>
          </step>
        </steps>
      </procedure>
      <para>Your minimal project file should resemble the following code:</para>
      <code>&lt;Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;
  &lt;ItemGroup&gt;
    &lt;Compile Include="helloworld.cs" /&gt;
  &lt;/ItemGroup&gt;
  &lt;Target Name="Build"&gt;
    &lt;Csc Sources="@(Compile)"/&gt;  
  &lt;/Target&gt;
&lt;/Project&gt;</code>
      <para>Tasks in the Build target are executed sequentially. In this case, the Visual C# compiler <languageKeyword>Csc</languageKeyword> task is the only task. It expects a list of source files to compile, and this is given by the value of the <languageKeyword>Compile</languageKeyword> item. The <languageKeyword>Compile</languageKeyword> item references just one source file, Helloworld.cs.</para>
      <alert class="note">
        <para>In the item element, you can use the asterisk wildcard character (*) to reference all files that have the .cs file name extension, as follows:</para>
        <para>
          <codeInline>&lt;Compile Include="*.cs" /&gt;</codeInline>
        </para>
        <para>However, we do not recommend the use of wildcard characters because it makes debugging and selective targeting more difficult if source files are added or deleted.</para>
      </alert>
    </content>
  </section>
  <section>
    <title>Extending the Path to Include MSBuild</title>
    <content>
      <para>Before you can access MSBuild, you must extend the PATH environment variable to include the .NET Framework folder. </para>
      <procedure>
        <title>To add MSBuild to your path</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Starting in Visual Studio 2013, you can find MSBuild.exe in the MSBuild folder (<unmanagedCodeEntityReference>%ProgramFiles%\MSBuild</unmanagedCodeEntityReference> on a 32-bit operating system, or <unmanagedCodeEntityReference>%ProgramFiles(x86)%\MSBuild</unmanagedCodeEntityReference> on a 64-bit operating system). </para>
              <para>At the command prompt, type <system>set PATH=%PATH%;%ProgramFiles%\MSBuild</system> or <system>set PATH=%PATH%;%ProgramFiles(x86)%\MSBuild</system>. </para>
              <para>Alternatively, if you have Visual Studio installed, you can use the <ui>Visual Studio Command Prompt</ui>, which has a path that includes the MSBuild folder.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Using the Project File to Build the Application</title>
    <content>
      <para>Now, to build the application, use the project file that you just created.</para>
      <procedure>
        <title>To build the application</title>
        <steps class="ordered">
          <step>
            <content>
              <para>At the command prompt, type <system>msbuild helloworld.csproj /t:Build</system>.</para>
              <para>This builds the Build target of the Helloworld project file by invoking the Visual C# compiler to create the Helloworld application.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Test the application by typing <system>helloworld</system>.</para>
              <para>The <system>Hello, world!</system> message should be displayed.</para>
            </content>
          </step>
        </steps>
      </procedure>
      <alert class="note">
        <para>You can see more details about the build by increasing the verbosity level. To set the verbosity level to "detailed", type either of these commands at the command prompt:</para>
        <para>
          <system>msbuild helloworld.csproj /t:Build /verbosity:detailed</system>
        </para>
      </alert>
    </content>
  </section>
  <section>
    <title>Adding Build Properties</title>
    <content>
      <para>You can add build properties to the project file to further control the build. Now add these properties:</para>
      <list class="bullet">
        <listItem>
          <para>An <languageKeyword>AssemblyName</languageKeyword> property to specify the name of the application.</para>
        </listItem>
        <listItem>
          <para>An <languageKeyword>OutputPath</languageKeyword> property to specify a folder to contain the application.</para>
        </listItem>
      </list>
      <procedure>
        <title>To add build properties</title>
        <steps class="ordered">
          <step>
            <content>
              <para>Delete the existing application by typing <system>del helloworld.exe</system> at the command prompt.</para>
            </content>
          </step>
          <step>
            <content>
              <para>In the project file, insert this <languageKeyword>PropertyGroup</languageKeyword> element just after the opening <languageKeyword>Project</languageKeyword> element:</para>
              <code>  &lt;PropertyGroup&gt;
    &lt;AssemblyName&gt;MSBuildSample&lt;/AssemblyName&gt;
    &lt;OutputPath&gt;Bin\&lt;/OutputPath&gt;
  &lt;/PropertyGroup&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Add this task to the Build target, just before the <languageKeyword>Csc</languageKeyword> task:</para>
              <code>    &lt;MakeDir Directories="$(OutputPath)"      Condition="!Exists('$(OutputPath)')" /&gt;</code>
              <para>The <languageKeyword>MakeDir</languageKeyword> task creates a folder that is named by the <languageKeyword>OutputPath</languageKeyword> property, provided that no folder by that name currently exists.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Add this <languageKeyword>OutputAssembly</languageKeyword> attribute to the <languageKeyword>Csc</languageKeyword> task:</para>
              <code>&lt;Csc Sources="@(Compile)" OutputAssembly="$(OutputPath)$(AssemblyName).exe" /&gt;</code>
              <para>This instructs the Visual C# compiler to produce an assembly that is named by the <languageKeyword>AssemblyName</languageKeyword> property and to put it in the folder that is named by the <languageKeyword>OutputPath</languageKeyword> property.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Save your changes.</para>
            </content>
          </step>
        </steps>
      </procedure>
      <para>Your project file should now resemble the following code:</para>
      <code>&lt;Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;
  &lt;PropertyGroup&gt;
    &lt;AssemblyName&gt;MSBuildSample&lt;/AssemblyName&gt;
    &lt;OutputPath&gt;Bin\&lt;/OutputPath&gt;
  &lt;/PropertyGroup&gt;
  &lt;ItemGroup&gt;
    &lt;Compile Include="helloworld.cs" /&gt;
  &lt;/ItemGroup&gt;
  &lt;Target Name="Build"&gt;
    &lt;MakeDir Directories="$(OutputPath)" Condition="!Exists('$(OutputPath)')" /&gt;
    &lt;Csc Sources="@(Compile)" OutputAssembly="$(OutputPath)$(AssemblyName).exe" /&gt;
  &lt;/Target&gt;
&lt;/Project&gt;</code>
      <alert class="note">
        <para>We recommend that you add the backslash (\) path delimiter at the end of the folder name when you specify it in the <languageKeyword>OutputPath</languageKeyword> element, instead of adding it in the <languageKeyword>OutputAssembly</languageKeyword> attribute of the <languageKeyword>Csc</languageKeyword> task. Therefore, </para>
        <para>
          <codeInline>&lt;OutputPath&gt;Bin\&lt;/OutputPath&gt;</codeInline>
        </para>
        <para>
          <codeInline>OutputAssembly=="$(OutputPath)$(AssemblyName).exe" /&gt;</codeInline>
        </para>
        <para>is better than</para>
        <para>
          <codeInline>&lt;OutputPath&gt;Bin&lt;/OutputPath&gt;</codeInline>
        </para>
        <para>
          <codeInline>OutputAssembly=="$(OutputPath)\$(AssemblyName).exe" /&gt;</codeInline>
        </para>
      </alert>
    </content>
  </section>
  <section>
    <title>Testing the Build Properties</title>
    <content>
      <para>Now you can build the application by using the project file in which you used build properties to specify the output folder and application name.</para>
      <procedure>
        <title>To test the build properties</title>
        <steps class="ordered">
          <step>
            <content>
              <para>At the command prompt, type <system>msbuild helloworld.csproj /t:Build</system>.</para>
              <para>This creates the \Bin\ folder and then invokes the Visual C# compiler to create the MSBuildSample application and puts it in the \Bin\ folder.</para>
            </content>
          </step>
          <step>
            <content>
              <para>To verify that the \Bin\ folder has been created, and that it contains the MSBuildSample application, type <system>dir Bin</system>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Test the application by typing <system>Bin\MSBuildSample</system>.</para>
              <para>The <system>Hello, world!</system> message should be displayed.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Adding Build Targets</title>
    <content>
      <para>Next, add two more targets to the project file, as follows:</para>
      <list class="bullet">
        <listItem>
          <para>A Clean target that deletes old files.</para>
        </listItem>
        <listItem>
          <para>A Rebuild target that uses the <languageKeyword>DependsOnTargets</languageKeyword> attribute to force the Clean task to run before the Build task. </para>
        </listItem>
      </list>
      <para>Now that you have multiple targets, you can set the Build target as the default target.</para>
      <procedure>
        <title>To add build targets</title>
        <steps class="ordered">
          <step>
            <content>
              <para>In the project file, add these two targets just after the Build target:</para>
              <code>  &lt;Target Name="Clean" &gt;
    &lt;Delete Files="$(OutputPath)$(AssemblyName).exe" /&gt;
  &lt;/Target&gt;
  &lt;Target Name="Rebuild" DependsOnTargets="Clean;Build" /&gt;</code>
              <para>The Clean target invokes the Delete task to delete the application. The Rebuild target does not run until both the Clean target and the Build target have run. Although the Rebuild target has no tasks, it causes the Clean target to run before the Build target.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Add this <languageKeyword>DefaultTargets</languageKeyword> attribute to the opening <languageKeyword>Project</languageKeyword> element:</para>
              <code>&lt;Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;</code>
              <para>This sets the Build target as the default target.</para>
            </content>
          </step>
        </steps>
      </procedure>
      <para>Your project file should now resemble the following code:</para>
      <code>&lt;Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;
  &lt;PropertyGroup&gt;
    &lt;AssemblyName&gt;MSBuildSample&lt;/AssemblyName&gt;
    &lt;OutputPath&gt;Bin\&lt;/OutputPath&gt;
  &lt;/PropertyGroup&gt;
  &lt;ItemGroup&gt;
    &lt;Compile Include="helloworld.cs" /&gt;
  &lt;/ItemGroup&gt;
  &lt;Target Name="Build"&gt;
    &lt;MakeDir Directories="$(OutputPath)" Condition="!Exists('$(OutputPath)')" /&gt;
    &lt;Csc Sources="@(Compile)" OutputAssembly="$(OutputPath)$(AssemblyName).exe" /&gt;
  &lt;/Target&gt;
  &lt;Target Name="Clean" &gt;
    &lt;Delete Files="$(OutputPath)$(AssemblyName).exe" /&gt;
  &lt;/Target&gt;
  &lt;Target Name="Rebuild" DependsOnTargets="Clean;Build" /&gt;
&lt;/Project&gt;</code>
    </content>
  </section>
  <section>
    <title>Testing the Build Targets</title>
    <content>
      <para>You can exercise the new build targets to test these features of the project file:</para>
      <list class="bullet">
        <listItem>
          <para>Building the default build.</para>
        </listItem>
        <listItem>
          <para>Setting the application name at the command prompt.</para>
        </listItem>
        <listItem>
          <para>Deleting the application before another application is built.</para>
        </listItem>
        <listItem>
          <para>Deleting the application without building another application.</para>
        </listItem>
      </list>
      <procedure>
        <title>To test the build targets</title>
        <steps class="ordered">
          <step>
            <content>
              <para>At the command prompt, type <system>msbuild helloworld.csproj /p:AssemblyName=Greetings</system>.</para>
              <para>Because you did not use the <system>/t</system> switch to explicitly set the target, MSBuild runs the default Build target. The <system>/p</system> switch overrides the <languageKeyword>AssemblyName</languageKeyword> property and gives it the new value, <userInput>Greetings</userInput>. This causes a new application, Greetings.exe, to be created in the \Bin\ folder.</para>
            </content>
          </step>
          <step>
            <content>
              <para>To verify that the \Bin\ folder contains both the MSBuildSample application and the new Greetings application, type <system>dir Bin</system>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Test the Greetings application by typing <system>Bin\Greetings</system>.</para>
              <para>The <system>Hello, world!</system> message should be displayed.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Delete the MSBuildSample application by typing <system>msbuild helloworld.csproj /t:clean</system>.</para>
              <para>This runs the Clean task to remove the application that has the default <languageKeyword>AssemblyName</languageKeyword> property value, <userInput>MSBuildSample</userInput>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Delete the Greetings application by typing <system>msbuild helloworld.csproj /t:clean /p:AssemblyName=Greetings</system>.</para>
              <para>This runs the Clean task to remove the application that has the given <system>AssemblyName</system> property value, <userInput>Greetings</userInput>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>To verify that the \Bin\ folder is now empty, type <system>dir Bin</system>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Type <system>msbuild</system>.</para>
              <para>Although a project file is not specified, MSBuild builds the helloworld.csproj file because there is only one project file in the current folder. This causes the MSBuildSample application to be created in the \Bin\ folder.</para>
              <para>To verify that the \Bin\ folder contains the MSBuildSample application, type <system>dir Bin</system>.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Building Incrementally</title>
    <content>
      <para>You can tell MSBuild to build a target only if the source files or target files that the target depends on have changed. MSBuild uses the time stamp of a file to determine whether it has changed.</para>
      <procedure>
        <title>To build incrementally</title>
        <steps class="ordered">
          <step>
            <content>
              <para>In the project file, add these attributes to the opening Build target:</para>
              <code>Inputs="@(Compile)" Outputs="$(OutputPath)$(AssemblyName).exe"</code>
              <para>This specifies that the Build target depends on the input files that are specified in the <languageKeyword>Compile</languageKeyword> item group, and that the output target is the application file. </para>
              <para>The resulting Build target should resemble the following code:</para>
              <code>&lt;Target Name="Build" Inputs="@(Compile)" Outputs="$(OutputPath)$(AssemblyName).exe"&gt;
  &lt;MakeDir Directories="$(OutputPath)" Condition="!Exists('$(OutputPath)')" /&gt;
  &lt;Csc Sources="@(Compile)" OutputAssembly="$(OutputPath)$(AssemblyName).exe" /&gt;
&lt;/Target&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Test the Build target by typing <system>msbuild /v:d</system> at the command prompt. </para>
              <para>Remember that helloworld.csproj is the default project file, and that Build is the default target. </para>
              <para>The <system>/v:d</system> switch specifies a verbose description for the build process.</para>
              <para>These lines should be displayed:</para>
              <para>
                <system>Skipping target "Build" because all output files are up-to-date with respect to the input files.</system>
              </para>
              <para>
                <system>Input files: HelloWorld.cs</system>
              </para>
              <para>
                <system>Output files: Bin\MSBuildSample.exe</system>
              </para>
              <para>MSBuild skips the Build target because none of the source files have changed since the application was last built.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Example</title>
    <content />
    <sections>
      <section>
        <title>Description</title>
        <content>
          <para>The following example shows a project file that compiles a <token>csprcs</token> application and logs a message that contains the output file name.</para>
        </content>
      </section>
      <section>
        <title>Code</title>
        <content>
          <code language="c#">&lt;Project DefaultTargets = "Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" &gt;

    &lt;!-- Set the application name as a property --&gt;
    &lt;PropertyGroup&gt;
        &lt;appname&gt;HelloWorldCS&lt;/appname&gt;
    &lt;/PropertyGroup&gt;

    &lt;!-- Specify the inputs by type and file name --&gt;
    &lt;ItemGroup&gt;
        &lt;CSFile Include = "consolehwcs1.cs"/&gt;
    &lt;/ItemGroup&gt;

    &lt;Target Name = "Compile"&gt;
        &lt;!-- Run the Visual C# compilation using input files of type CSFile --&gt;
        &lt;CSC
            Sources = "@(CSFile)"
            OutputAssembly = "$(appname).exe"&gt;
            &lt;!-- Set the OutputAssembly attribute of the CSC task
            to the name of the executable file that is created --&gt;
            &lt;Output
                TaskParameter = "OutputAssembly"
                ItemName = "EXEFile" /&gt;
        &lt;/CSC&gt;
        &lt;!-- Log the file name of the output file --&gt;
        &lt;Message Text="The output file is @(EXEFile)"/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
        </content>
      </section>
      <section>
        <title>Comments</title>
        <content />
      </section>
    </sections>
  </section>
  <section>
    <title>Example</title>
    <content />
    <sections>
      <section>
        <title>Description</title>
        <content>
          <para>The following example shows a project file that compiles a <token>vbprvb</token> application and logs a message that contains the output file name.</para>
        </content>
      </section>
      <section>
        <title>Code</title>
        <content>
          <code language="vb#">&lt;Project DefaultTargets = "Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" &gt;

    &lt;!-- Set the application name as a property --&gt;
    &lt;PropertyGroup&gt;
        &lt;appname&gt;HelloWorldVB&lt;/appname&gt;
    &lt;/PropertyGroup&gt;

    &lt;!-- Specify the inputs by type and file name --&gt;
    &lt;ItemGroup&gt;
        &lt;VBFile Include = "consolehwvb1.vb"/&gt;
    &lt;/ItemGroup&gt;

    &lt;Target Name = "Compile"&gt;    
        &lt;!-- Run the Visual Basic compilation using input files of type VBFile --&gt;
        &lt;VBC
            Sources = "@(VBFile)"
            OutputAssembly= "$(appname).exe"&gt;
            &lt;!-- Set the OutputAssembly attribute of the VBC task
            to the name of the executable file that is created --&gt;
            &lt;Output
                TaskParameter = "OutputAssembly"
                ItemName = "EXEFile" /&gt;
        &lt;/VBC&gt;
        &lt;!-- Log the file name of the output file --&gt;
        &lt;Message Text="The output file is @(EXEFile)"/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
        </content>
      </section>
    </sections>
  </section>
  <section>
    <title>What's Next?</title>
    <content>
      <para>Visual Studio can automatically do much of the work that is shown in this walkthrough. To learn how to use Visual Studio to create, edit, build, and test MSBuild project files, see <link xlink:href="b8a8b866-bb07-4abf-b9ec-0b40d281c310">Tutorial: How to Use MSBuild</link>.</para>
    </content>
  </section>
  <relatedTopics>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild Overview</link>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
</relatedTopics>
</developerWalkthroughDocument>
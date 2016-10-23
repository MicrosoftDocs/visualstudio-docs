---
title: "Walkthrough: Using MSBuild"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b8a8b866-bb07-4abf-b9ec-0b40d281c310
caps.latest.revision: 29
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
# Walkthrough: Using MSBuild
<?xml version="1.0" encoding="utf-8"?>
<developerWalkthroughDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>MSBuild is the build platform for Microsoft and Visual Studio. This walkthrough introduces you to the building blocks of MSBuild and shows you how to write, manipulate, and debug MSBuild projects. You will learn about:</para>
    <list class="bullet">
      <listItem>
        <para>Creating and manipulating a project file.</para>
      </listItem>
      <listItem>
        <para>How to use build properties</para>
      </listItem>
      <listItem>
        <para>How to use build items.</para>
      </listItem>
    </list>
    <para>You can run MSBuild from Visual Studio, or from the Command Window. In this walkthrough, you create an MSBuild project file using Visual Studio. You edit the project file in Visual Studio, and use a Command Window to build the project and examine the results.</para>
  </introduction>
  <section>
    <title>Creating an MSBuild Project</title>
    <content>
      <para>The Visual Studio project system is based on MSBuild. This makes it easy to create a new project file using Visual Studio. In this section, you create a Visual C# project file. You can choose to create a Visual Basic project file instead. In the context of this walkthrough, the difference between the two project files is minor.</para>
      <procedure>
        <title>To create a project file</title>
        <steps class="ordered">
          <step>
            <content>
              <para>Open Visual Studio.</para>
            </content>
          </step>
          <step>
            <content>
              <para>On the <ui>File</ui> menu, point to <ui>New</ui>, and then click <ui>Project</ui>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>In the <ui>New Project</ui> dialog box, select the Visual C# project type, and then select the <ui>Windows Forms Application</ui> template. In the <ui>Name</ui> box, type <userInput>BuildApp</userInput>. Enter a <ui>Location</ui> for the solution, for example, <userInput>D:\</userInput>. Accept the defaults for <ui>Create directory for solution</ui> (selected), <ui>Add to Source Control</ui> (not selected), and <ui>Solution Name</ui> (<userInput>BuildApp</userInput>). </para>
              <para>Click <ui>OK</ui> to create the project file.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Examining the Project File</title>
    <content>
      <para>In the previous section, you used Visual Studio to create a Visual C# project file. The project file is represented in <ui>Solution Explorer</ui> by the project node named BuildApp. You can use the Visual Studio code editor to examine the project file.</para>
      <procedure>
        <title>To examine the project file</title>
        <steps class="ordered">
          <step>
            <content>
              <para>In <ui>Solution Explorer</ui>, click the project node BuildApp.</para>
            </content>
          </step>
          <step>
            <content>
              <para>In the <ui>Properties</ui> browser, notice that the <ui>Project File</ui> property is BuildApp.csproj. All project files are named with the suffix "proj". If you had created a Visual Basic project, the project file name would be BuildApp.vbproj.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Right-click the project node, then click <ui>Unload Project</ui>.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Right-click the project node again, then click <ui>Edit BuildApp.csproj</ui>.</para>
              <para>The project file appears in the code editor.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Targets and Tasks</title>
    <content>
      <para>Project files are XML-formatted files with the root node <legacyLink xlink:href="d1cda56a-dbef-4109-9201-39e962e3f653">Project</legacyLink>. </para>
      <code>&lt;?xml version="1.0" encoding="utf-8"?&gt;
&lt;Project ToolsVersion="12.0" DefaultTargets="Build"  xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;</code>
      <para>You must specify the xmlns namespace in the Project element.</para>
      <para>The work of building an application is done with <legacyLink xlink:href="350f6fc2-86b3-45f2-a31e-ece0e6bd4dca">Target</legacyLink> and <legacyLink xlink:href="d82e2485-e5f0-4936-a357-745bacccc299">Task</legacyLink> elements. </para>
      <list class="bullet">
        <listItem>
          <para>A task is the smallest unit of work, in other words, the "atom" of a build. Tasks are independent executable components which may have inputs and outputs. There are no tasks currently referenced or defined in the project file. You add tasks to the project file in the sections below. For more information, see the <link xlink:href="5d3cc4a7-e5db-4f73-b707-8b6882fddcf8">Tasks</link> topic.</para>
        </listItem>
        <listItem>
          <para>A target is a named sequence of tasks. There are two targets at the end of the project file that are currently enclosed in HTML comments: BeforeBuild and AfterBuild.</para>
          <code>&lt;Target Name="BeforeBuild"&gt;
&lt;/Target&gt;
&lt;Target Name="AfterBuild"&gt;
&lt;/Target&gt;</code>
          <para>For more information, see the <link xlink:href="8060b4d2-e4a9-48cf-a437-852649ceb417">Targets</link> topic.</para>
        </listItem>
      </list>
      <para>The Project node has an optional DefaultTargets attribute that selects the default target to build, in this case Build. </para>
      <code>&lt;Project ToolsVersion="12.0" DefaultTargets="Build" ...</code>
      <para>The Build target is not defined in the project file. Instead, it is imported from the file Microsoft.CSharp.targets by using the <legacyLink xlink:href="3bfecaf1-69fd-4008-b651-c9dafd4389d9">Import</legacyLink> element. </para>
      <code>&lt;Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" /&gt;</code>
      <para>Imported files are effectively inserted into the project file wherever they are referenced.</para>
      <para>MSBuild keeps track of the targets of a build, and guarantees that each target is built no more than once.</para>
    </content>
  </section>
  <section>
    <title>Adding a Target and a Task</title>
    <content>
      <para>Add a target to the project file. Add a task to the target that prints out a message.</para>
      <procedure>
        <title>To add a target and a task</title>
        <steps class="ordered">
          <step>
            <content>
              <para>Add these lines to the project file, just after the Import statement:</para>
              <code>&lt;Target Name="HelloWorld"&gt;
&lt;/Target&gt;</code>
              <para>This creates a target named HelloWorld. Notice that you have Intellisense support while editing the project file.</para>
            </content>
          </step>
          <step>
            <content>
              <para>Add lines to the HelloWorld target, so that the resulting section looks like this:</para>
              <code>&lt;Target Name="HelloWorld"&gt;
<codeFeaturedElement>  &lt;Message Text="Hello"&gt;&lt;/Message&gt;</codeFeaturedElement>
<codeFeaturedElement>  &lt;Message Text="World"&gt;&lt;/Message&gt;</codeFeaturedElement>
&lt;/Target&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Save the project file.</para>
            </content>
          </step>
        </steps>
      </procedure>
      <para>The Message task is one of the many tasks that ships with MSBuild. For a complete list of available tasks and usage information, see <link xlink:href="b3144b27-a426-4259-b8ae-5f7991b202b6">MSBuild Task Reference</link>.</para>
      <para>The Message task takes the string value of the Text attribute as input and displays it on the output device. The HelloWorld target executes the Message task twice: first to display "Hello", and then to display "World".</para>
    </content>
  </section>
  <section>
    <title>Building the Target</title>
    <content>
      <para>Run MSBuild from the <ui>Visual Studio Command Prompt</ui> to build the HelloWorld target defined above. Use the /target or /t command line switch to select the target.</para>
      <alert class="note">
        <para>We will refer to the <ui>Visual Studio Command Prompt</ui> as the <ui>Command Window</ui> in the sections below.</para>
      </alert>
      <procedure>
        <title>To build the target</title>
        <steps class="ordered">
          <step>
            <content>
              <para>Click <ui>Start</ui>, then click <ui>All Programs</ui>. Locate and click the <ui>Visual Studio Command Prompt</ui> in the <ui>Visual Studio Tools</ui> folder.</para>
            </content>
          </step>
          <step>
            <content>
              <para>From the command window, navigate to the folder containing the project file, in this case, D:\BuildApp\BuildApp. </para>
            </content>
          </step>
          <step>
            <content>
              <para>Run msbuild with the command switch /t:HelloWorld. This selects and builds the HelloWorld target:</para>
              <code>msbuild buildapp.csproj /t:HelloWorld</code>
            </content>
          </step>
          <step>
            <content>
              <para>Examine the output in the <ui>Command window</ui>. You should see the two lines "Hello" and "World":</para>
              <code>Hello
World</code>
            </content>
          </step>
        </steps>
        <conclusion>
          <content>
            <alert class="note">
              <para>If instead you see <codeInline>The target "HelloWorld" does not exist in the project </codeInline>then you probably forgot to save the project file in the code editor. Save the file and try again.</para>
            </alert>
          </content>
        </conclusion>
      </procedure>
      <para>By alternating between the code editor and the command window, you can change the project file and quickly see the results.</para>
      <alert class="note">
        <para>If you run msbuild without the /t command switch, msbuild builds the target given by the DefaultTarget attribute of the Project element, in this case "Build". This builds the Windows Forms application BuildApp.exe.</para>
      </alert>
    </content>
  </section>
  <section>
    <title>Build Properties</title>
    <content>
      <para>Build properties are name-value pairs that guide the build. Several build properties are already defined at the top of the project file:</para>
      <code>&lt;PropertyGroup&gt;
...
  &lt;ProductVersion&gt;10.0.11107&lt;/ProductVersion&gt;
  &lt;SchemaVersion&gt;2.0&lt;/SchemaVersion&gt;
  &lt;ProjectGuid&gt;{30E3C9D5-FD86-4691-A331-80EA5BA7E571}&lt;/ProjectGuid&gt;
  &lt;OutputType&gt;WinExe&lt;/OutputType&gt;
...
&lt;/PropertyGroup&gt;</code>
      <para>All properties are child elements of PropertyGroup elements. The name of the property is the name of the child element, and the value of the property is the text element of the child element. For example,</para>
      <code>&lt;TargetFrameworkVersion&gt;v12.0&lt;/TargetFrameworkVersion&gt;</code>
      <para>defines the property named TargetFrameworkVersion, giving it the string value "v12.0". </para>
      <para>Build properties may be redefined at any time. If </para>
      <code>&lt;TargetFrameworkVersion&gt;v3.5&lt;/TargetFrameworkVersion&gt;</code>
      <para>appears later in the project file, or in a file imported later in the project file, then TargetFrameworkVersion takes the new value "v3.5".</para>
    </content>
  </section>
  <section>
    <title>Examining a Property Value</title>
    <content>
      <para>To get the value of a property, use the following syntax, where PropertyName is the name of the property:</para>
      <code>$(PropertyName)</code>
      <para>Use this syntax to examine some of the properties in the project file.</para>
      <procedure>
        <title>To examine a property value</title>
        <steps class="ordered">
          <step>
            <content>
              <para>From the code editor, replace the HelloWorld target with this code:</para>
              <code>&lt;Target Name="HelloWorld"&gt;
  &lt;Message Text="Configuration is $(Configuration)" /&gt;
  &lt;Message Text="MSBuildToolsPath is $(MSBuildToolsPath)" /&gt;
&lt;/Target&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Save the project file.</para>
            </content>
          </step>
          <step>
            <content>
              <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
              <code>msbuild buildapp.csproj /t:HelloWorld</code>
            </content>
          </step>
          <step>
            <content>
              <para>Examine the output. You should see these two lines (your .NET Framework version may differ):</para>
              <code>Configuration is Debug
MSBuildToolsPath is C:\Program Files\MSBuild\12.0\bin</code>
            </content>
          </step>
        </steps>
        <conclusion>
          <content>
            <alert class="note">
              <para>If you don't see these lines then you probably forgot to save the project file in the code editor. Save the file and try again.</para>
              <para />
            </alert>
          </content>
        </conclusion>
      </procedure>
    </content>
    <sections>
      <section>
        <title>Conditional Properties</title>
        <content>
          <para>Many properties like Configuration are defined conditionally, that is, the Condition attribute appears in the property element. Conditional properties are defined or redefined only if the condition evaluates to "true". Note that undefined properties are given the default value of an empty string. For example,</para>
          <code>&lt;Configuration   Condition=" '$(Configuration)' == '' "&gt;Debug&lt;/Configuration&gt;</code>
          <para>means "If the Configuration property has not been defined yet, define it and give it the value 'Debug'". </para>
          <para>Almost all MSBuild elements can have a Condition attribute. For more discussion about using the Condition attribute, see <link xlink:href="9d7aa308-b667-48ed-b4c9-a61e49eb0a85">MSBuild Conditions</link>.</para>
        </content>
      </section>
      <section>
        <title>Reserved Properties</title>
        <content>
          <para>MSBuild reserves some property names to store information about the project file and the MSBuild binaries. MSBuildToolsPath is an example of a reserved property. Reserved properties are referenced with the $ notation like any other property. For more information, see <link xlink:href="c8fcc594-5d37-4e2e-b070-4d9c012043b5">How To: Reference the Name or Location of the Project File</link> and <link xlink:href="99333e61-83c9-4804-84e3-eda297c2478d">MSBuild Reserved Properties</link>.</para>
        </content>
      </section>
      <section>
        <title>Environment Variables</title>
        <content>
          <para>You can reference environment variables in project files the same way as build properties. For example, to use the PATH environment variable in your project file, use $(Path). If the project contains a property definition that has the same name as an environment variable, the property in the project overrides the value of the environment variable. For more information, see <link xlink:href="7f9e4469-8865-4b59-aab3-3ff26bd36e77">How To: Use Environment Variables in a Build</link>.</para>
        </content>
      </section>
    </sections>
  </section>
  <section>
    <title>Setting Properties from the Command Line</title>
    <content>
      <para>Properties may be defined on the command line using the /property or /p command line switch. Property values received from the command line override property values set in the project file and environment variables.</para>
      <procedure>
        <title>To set a property value from the command line</title>
        <steps class="ordered">
          <step>
            <content>
              <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
              <code>msbuild buildapp.csproj /t:HelloWorld /p:Configuration=Release</code>
              <para />
            </content>
          </step>
          <step>
            <content>
              <para>Examine the output. You should see this line:</para>
              <code>Configuration is Release.</code>
            </content>
          </step>
        </steps>
      </procedure>
      <para>MSBuild creates the Configuration property and gives it the value "Release". </para>
    </content>
  </section>
  <section>
    <title>Special Characters</title>
    <content>
      <para>Certain characters have special meaning in MSBuild project files. Examples of these characters include semicolons (;) and asterisks (*). In order to use these special characters as literals in a project file, they must be specified by using the syntax %xx, where xx represents the ASCII hexadecimal value of the character.</para>
      <para>Change the Message task to show the value of the Configuration property with special characters to make it more readable.</para>
      <procedure>
        <title>To use special characters in the Message task</title>
        <steps class="ordered">
          <step>
            <content>
              <para>From the code editor, replace both Message tasks with this line:</para>
              <code>&lt;Message Text="%24(Configuration) is %22$(Configuration)%22" /&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Save the project file.</para>
            </content>
          </step>
          <step>
            <content>
              <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
              <code>msbuild buildapp.csproj /t:HelloWorld</code>
            </content>
          </step>
          <step>
            <content>
              <para>Examine the output. You should see this line:</para>
              <code>$(Configuration) is "Debug"</code>
            </content>
          </step>
        </steps>
      </procedure>
      <para>For more information, see <link xlink:href="545e6a59-1093-4514-935e-78679a46fb3c">MSBuild Special Characters</link>.</para>
    </content>
  </section>
  <section>
    <title>Build Items</title>
    <content>
      <para>An item is a piece of information, typically a file name, that is used as an input to the build system. For example, a collection of items representing source files might be passed to a task named Compile to compile them into an assembly.</para>
      <para>All items are child elements of ItemGroup elements. The item name is the name of the child element, and the item value is the value of the Include attribute of the child element. The values of items with the same name are collected into item types of that name.  For example,</para>
      <code>&lt;ItemGroup&gt;
    &lt;Compile Include="Program.cs" /&gt;
    &lt;Compile Include="Properties\AssemblyInfo.cs" /&gt;
&lt;/ItemGroup&gt;</code>
      <para>defines an item group containing two items. The item type Compile has two values: "Program.cs" and "Properties\AssemblyInfo.cs". </para>
      <para>The following code creates the same item type by declaring both files in one Include attribute, separated by a semicolon.</para>
      <code>&lt;ItemGroup&gt;
    &lt;Compile Include="Program.cs;Properties\AssemblyInfo.cs" /&gt;
&lt;/ItemGroup&gt;</code>
      <para>For more information, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
      <alert class="note">
        <para>File paths are relative to the folder containing the MSBuild project file.</para>
      </alert>
    </content>
  </section>
  <section>
    <title>Examining Item Type Values</title>
    <content>
      <para>To get the values of an item type, use the following syntax, where ItemType is the name of the item type:</para>
      <code>@(ItemType)</code>
      <para>Use this syntax to examine the Compile item type in the project file.</para>
      <procedure>
        <title>To examine item type values</title>
        <steps class="ordered">
          <step>
            <content>
              <para>From the code editor, replace the HelloWorld target task with this code:</para>
              <code>&lt;Target Name="HelloWorld"&gt;
  &lt;Message Text="Compile item type contains @(Compile)" /&gt;
&lt;/Target&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Save the project file.</para>
            </content>
          </step>
          <step>
            <content>
              <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
              <code>msbuild buildapp.csproj /t:HelloWorld</code>
            </content>
          </step>
          <step>
            <content>
              <para>Examine the output. You should see this long line:</para>
              <code>Compile item type contains Form1.cs;Form1.Designer.cs;Program.cs;Properties\AssemblyInfo.cs;Properties\Resources.Designer.cs;Properties\Settings.Designer.cs</code>
            </content>
          </step>
        </steps>
      </procedure>
      <para>The values of an item type are separated with semicolons by default. </para>
      <para>To change the separator of an item type, use the following syntax, where ItemType is the item type and Separator is a string of one or more separating characters:</para>
      <code>@(ItemType, Separator)</code>
      <para>Change the Message task to use carriage returns and line feeds (%0A%0D) to display Compile items one per line.</para>
      <procedure>
        <title>To display item type values one per line</title>
        <steps class="ordered">
          <step>
            <content>
              <para>From the code editor, replace the Message task with this line:</para>
              <code>&lt;Message Text="Compile item type contains @(Compile, '%0A%0D')" /&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Save the project file.</para>
            </content>
          </step>
          <step>
            <content>
              <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
              <para>
                <codeInline>msbuild buildapp.csproj /t:HelloWorld</codeInline>
              </para>
            </content>
          </step>
          <step>
            <content>
              <para>Examine the output. You should see these lines:</para>
              <code>Compile item type contains Form1.cs
Form1.Designer.cs
Program.cs
Properties\AssemblyInfo.cs
Properties\Resources.Designer.cs
Properties\Settings.Designer.cs</code>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
    <sections>
      <section>
        <title>Include, Exclude, and Wildcards</title>
        <content>
          <para>You can use the wildcards "*", "**", and "?" with the Include attribute to add items to an item type. For example, </para>
          <code>&lt;Photos Include="images\*.jpeg" /&gt;</code>
          <para>adds all files with the file extension ".jpeg" in the images folder to the Photos item type, while</para>
          <code>&lt;Photos Include="images\**.jpeg" /&gt;</code>
          <para>adds all files with the file extension ".jpeg" in the images folder, and all its subfolders, to the Photos item type. For more examples, see <link xlink:href="f5ff182f-7b3a-46fb-9335-37df54cfb8eb">How to: Use Wildcards to Build All Files in a Directory</link>.</para>
          <para>Notice that as items are declared they are added to the item type. For example,</para>
          <code>&lt;Photos Include="images\*.jpeg" /&gt;
&lt;Photos Include="images\*.gif" /&gt;</code>
          <para>creates an item type named Photo containing all files in the image folder with a file extension of either ".jpeg" or ".gif". This is equivalent to the following line:</para>
          <code>&lt;Photos Include="images\*.jpeg;images\*.gif" /&gt;</code>
          <para>You can exclude an item from an item type with the Exclude attribute. For example,</para>
          <code>&lt;Compile Include="*.cs" Exclude="*Designer*"&gt;</code>
          <para>adds all files with the file extension".cs" to the Compile item type, except for files whose names contain the string "Designer". For more examples, see <link xlink:href="1be36e45-01da-451c-972d-f9fc0e7d663c">How to: Build All Files in a Directory Except One</link>.</para>
          <para>The Exclude attribute only affects the items added by the Include attribute in the item element that contains them both. For example,</para>
          <code>&lt;Compile Include="*.cs" /&gt;
&lt;Compile Include="*.res" Exclude="Form1.cs"&gt;</code>
          <para>would not exclude the file Form1.cs, which was added in the preceding item element.</para>
          <procedure>
            <title>To include and exclude items</title>
            <steps class="ordered">
              <step>
                <content>
                  <para>From the code editor, replace the Message task with this line:</para>
                  <code>&lt;Message Text="Compile item type contains @(XFiles)" /&gt;</code>
                </content>
              </step>
              <step>
                <content>
                  <para>Add this item group just after the Import element:</para>
                  <code>&lt;ItemGroup&gt;
   &lt;XFiles Include="*.cs;properties/*.resx" Exclude="*Designer*" /&gt;
&lt;/ItemGroup&gt;</code>
                </content>
              </step>
              <step>
                <content>
                  <para>Save the project file.</para>
                </content>
              </step>
              <step>
                <content>
                  <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
                  <code>msbuild buildapp.csproj /t:HelloWorld</code>
                </content>
              </step>
              <step>
                <content>
                  <para>Examine the output. You should see this line:</para>
                  <code>Compile item type contains Form1.cs;Program.cs;Properties/Resources.resx</code>
                </content>
              </step>
            </steps>
          </procedure>
        </content>
      </section>
    </sections>
  </section>
  <section>
    <title>Item Metadata</title>
    <content>
      <para>Items may contain metadata in addition to the information gathered from the Include and Exclude attributes. This metadata can be used by tasks that require more information about items than just the item value.</para>
      <para>Item metadata is declared in the project file by creating an element with the name of the metadata as a child element of the item. An item can have zero or more metadata values. For example, the following CSFile item has Culture metadata with a value of "Fr":</para>
      <code>&lt;ItemGroup&gt;
    &lt;CSFile Include="main.cs"&gt;
        &lt;Culture&gt;Fr&lt;/Culture&gt;
    &lt;/CSFile&gt;
&lt;/ItemGroup&gt;</code>
      <para>To get the metadata value of an item type, use the following syntax, where ItemType is the name of the item type and MetaDataName is the name of the metadata:</para>
      <code>%(ItemType.MetaDataName)</code>
      <procedure>
        <title>To examine item metadata</title>
        <steps class="ordered">
          <step>
            <content>
              <para>From the code editor, replace the Message task with this line:</para>
              <code>&lt;Message Text="Compile.DependentUpon: %(Compile.DependentUpon)" /&gt;</code>
            </content>
          </step>
          <step>
            <content>
              <para>Save the project file.</para>
            </content>
          </step>
          <step>
            <content>
              <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
              <code>msbuild buildapp.csproj /t:HelloWorld</code>
            </content>
          </step>
          <step>
            <content>
              <para>Examine the output. You should see these lines:</para>
              <code>Compile.DependentUpon:
Compile.DependentUpon: Form1.cs
Compile.DependentUpon: Resources.resx
Compile.DependentUpon: Settings.settings</code>
            </content>
          </step>
        </steps>
      </procedure>
      <para>Notice how the phrase "Compile.DependentUpon" appears several times. The use of metadata with this syntax within a target causes "batching". Batching means that the tasks within the target are executed once for each unique metadata value. This is the MSBuild script equivalent of the common "for loop" programming construct. For more information, see <link xlink:href="d35c085b-27b8-49d7-b6f8-8f2f3a0eec38">MSBuild Batching</link>.</para>
    </content>
    <sections>
      <section>
        <title>Well-Known Metadata</title>
        <content>
          <para>Whenever an item is added to an item list, that item is assigned some well-known metadata. For example, %(Filename) returns the file name of any item. For a complete list of well-known metadata, see <link xlink:href="b5e791b5-c68f-4978-ad8a-9247d03bb6c0">MSBuild Well-known Item Metadata</link>.</para>
          <procedure>
            <title>To examine well-known metadata</title>
            <steps class="ordered">
              <step>
                <content>
                  <para>From the code editor, replace the Message task with this line:</para>
                  <code>&lt;Message Text="Compile Filename: %(Compile.Filename)" /&gt;</code>
                </content>
              </step>
              <step>
                <content>
                  <para>Save the project file.</para>
                </content>
              </step>
              <step>
                <content>
                  <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
                  <code>msbuild buildapp.csproj /t:HelloWorld</code>
                </content>
              </step>
              <step>
                <content>
                  <para>Examine the output. You should see these lines:</para>
                  <code>Compile Filename: Form1
Compile Filename: Form1.Designer
Compile Filename: Program
Compile Filename: AssemblyInfo
Compile Filename: Resources.Designer
Compile Filename: Settings.Designer</code>
                </content>
              </step>
            </steps>
          </procedure>
          <para>By comparing the two examples above, you can see that while not every item in the Compile item type has DependentUpon metadata, all items have the well-known Filename metadata.</para>
        </content>
      </section>
      <section>
        <title>Metadata Transformations</title>
        <content>
          <para>Item lists can be transformed into new item lists. To transform an item list, use the following syntax, where ItemType is the name of the item type and MetadataName is the name of the metadata:</para>
          <code>@(ItemType -&gt; '%(MetadataName)')</code>
          <para>For example, an item list of source files can be transformed into a collection of object files using an expression like <codeInline>@(SourceFiles -&gt; '%(Filename).obj')</codeInline>. For more information, see <link xlink:href="d0bcfc3c-14fa-455e-805c-63ccffa4a3bf">MSBuild Transforms</link>.</para>
          <procedure>
            <title>To transform items using metadata</title>
            <steps class="ordered">
              <step>
                <content>
                  <para>From the code editor, replace the Message task with this line:</para>
                  <code>&lt;Message Text="Backup files: @(Compile-&gt;'%(filename).bak')" /&gt;</code>
                </content>
              </step>
              <step>
                <content>
                  <para>Save the project file.</para>
                </content>
              </step>
              <step>
                <content>
                  <para>From the <ui>Command Window</ui>, enter and execute this line:</para>
                  <code>msbuild buildapp.csproj /t:HelloWorld</code>
                </content>
              </step>
              <step>
                <content>
                  <para>Examine the output. You should see this line:</para>
                  <code>Backup files: Form1.bak;Form1.Designer.bak;Program.bak;AssemblyInfo.bak;Resources.Designer.bak;Settings.Designer.bak</code>
                </content>
              </step>
            </steps>
          </procedure>
          <para>Notice that metadata expressed in this syntax does not cause batching.</para>
        </content>
      </section>
    </sections>
  </section>
  <section>
    <title>What's Next?</title>
    <content>
      <para>To learn how to create a simple project file one step at a time, try out the <link xlink:href="e3acff7c-cb4e-4ae1-8be2-a871bcff847b">Tutorial: Creating a Project File from Scratch</link>.</para>
    </content>
  </section>
  <relatedTopics>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild Overview</link>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
</relatedTopics>
</developerWalkthroughDocument>
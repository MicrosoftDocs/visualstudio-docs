---
title: "MSBuild"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e39f13f7-1e1d-4435-95ca-0c222bca071c
caps.latest.revision: 56
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
# MSBuild
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>The <token>vstecmsbuildengine</token> is a platform for building applications. This engine, which is also known as MSBuild, provides an XML schema for a project file that controls how the build platform processes and builds software. Visual Studio uses MSBuild, but it doesn't depend on Visual Studio. By invoking msbuild.exe on your project or solution file, you can orchestrate and build products in environments where Visual Studio isn't installed.</para>
    <para>Visual Studio uses MSBuild to load and build managed projects. The project files in Visual Studio (.csproj,.vbproj, vcxproj, and others) contain MSBuild XML code that executes when you build a project by using the IDE. Visual Studio projects import all the necessary settings and build processes to do typical development work, but you can extend or modify them from within Visual Studio or by using an XML editor.</para>
    <para>For information about MSBuild for C++, see <link xlink:href="7a1be7ff-0312-4669-adf2-5f5bf507d560">MSBuild (Visual C++)</link>.</para>
    <para>The following examples illustrate when you might run builds by using an MSBuild command line instead of the Visual Studio IDE.</para>
    <list class="bullet">
      <listItem>
        <para>Visual Studio isn't installed.</para>
      </listItem>
      <listItem>
        <para>You want to use the 64-bit version of MSBuild. This version of MSBuild is usually unnecessary, but it allows MSBuild to access more memory.</para>
      </listItem>
      <listItem>
        <para>You want to run a build in multiple processes. However, you can use the IDE to achieve the same result on projects in C++ and C#.</para>
      </listItem>
      <listItem>
        <para>You want to modify the build system. For example, you might want to enable the following actions:</para>
        <list class="bullet">
          <listItem>
            <para>Preprocess files before they reach the compiler.</para>
          </listItem>
          <listItem>
            <para>Copy the build outputs to a different place.</para>
          </listItem>
          <listItem>
            <para>Create compressed files from build outputs.</para>
          </listItem>
          <listItem>
            <para>Do a post-processing step. For example, you might want to stamp an assembly with a different version.</para>
          </listItem>
        </list>
      </listItem>
    </list>
    <para>You can write code in the Visual Studio IDE but run builds by using MSBuild. As another alternative, you can build code in the IDE on a development computer but use an MSBuild command line to build code that's integrated from multiple developers.</para>
    <alert class="note">
      <para>You can use Team Foundation Build to automatically compile, test, and deploy your application. Your build system can automatically run builds when developers check in code (for example, as part of a Continuous Integration strategy) or according to a schedule (for example, a nightly Build Verification Test build). Team Foundation Build compiles your code by using MSBuild. For more information, see <legacyLink xlink:href="a971b0f9-7c28-479d-a37b-8fd7e27ef692">Build the application</legacyLink>.</para>
    </alert>
    <para>This topic provides an overview of MSBuild. For an introductory tutorial, see <link xlink:href="b8a8b866-bb07-4abf-b9ec-0b40d281c310">Tutorial: How to Use MSBuild</link>.</para>
    <para>
      <embeddedLabel>In this topic</embeddedLabel>
    </para>
    <list class="bullet">
      <listItem>
        <para>
          <link xlink:href="#BKMK_CommandPrompt">Using MSBuild at a Command Prompt</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_ProjectFile">Project File</link>
        </para>
        <list class="bullet">
          <listItem>
            <para>
              <link xlink:href="#BKMK_Properties">Properties</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_Items">Items</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_Tasks">Tasks</link>
            </para>
          </listItem>
          <listItem>
            <para>
              <link xlink:href="#BKMK_Targets">Targets</link>
            </para>
          </listItem>
        </list>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_BuildLogs">Build Logs</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_VisualStudio">Using MSBuild in Visual Studio</link>
        </para>
      </listItem>
      <listItem>
        <para>
          <link xlink:href="#BKMK_Multitargeting">Multitargeting</link>
        </para>
      </listItem>
    </list>
  </introduction>
  <section address="BKMK_CommandPrompt">
    <title>Using MSBuild at a Command Prompt</title>
    <content>
      <para>To run <token>vstecmsbuild</token> at a command prompt, pass a project file to MSBuild.exe, together with the appropriate command-line options. Command-line options let you set properties, execute specific targets, and set other options that control the build process. For example, you would use the following command-line syntax to build the file <codeInline>MyProj.proj</codeInline> with the <codeInline>Configuration</codeInline> property set to <codeInline>Debug</codeInline>.</para>
      <code>MSBuild.exe MyProj.proj /property:Configuration=Debug</code>
      <para>For more information about <token>vstecmsbuild</token> command-line options, see <link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>. </para>
      <alert class="security note">
        <para>Before you download a project, determine the trustworthiness of the code. </para>
      </alert>
    </content>
  </section>
  <section address="BKMK_ProjectFile">
    <title>Project File</title>
    <content>
      <para>
        <token>vstecmsbuild</token> uses an XML-based project file format that's straightforward and extensible. The <token>vstecmsbuild</token> project file format lets developers describe the items that are to be built, and also how they are to be built for different operating systems and configurations. In addition, the project file format lets developers author reusable build rules that can be factored into separate files so that builds can be performed consistently across different projects in the product. </para>
      <para>The following sections describe some of the basic elements of the <token>vstecmsbuild</token> project file format. For a tutorial about how to create a basic project file, see <link xlink:href="e3acff7c-cb4e-4ae1-8be2-a871bcff847b">Tutorial: Creating a Project File from Scratch</link>.</para>
    </content>
    <sections>
      <section address="BKMK_Properties">
        <title>Properties</title>
        <content>
          <para>Properties represent key/value pairs that can be used to configure builds. Properties are declared by creating an element that has the name of the property as a child of a <legacyLink xlink:href="ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4">PropertyGroup</legacyLink> element. For example, the following code creates a property named <codeInline>BuildDir</codeInline> that has a value of <codeInline>Build</codeInline>.</para>
          <code>&lt;PropertyGroup&gt;
    &lt;BuildDir&gt;Build&lt;/BuildDir&gt;
&lt;/PropertyGroup&gt;</code>
          <para>You can define a property conditionally by placing a <languageKeyword>Condition</languageKeyword> attribute in the element. The contents of conditional elements are ignored unless the condition evaluates to <languageKeyword>true</languageKeyword>. In the following example, the <codeInline>Configuration</codeInline> element is defined if it hasn't yet been defined.</para>
          <code>&lt;Configuration  Condition=" '$(Configuration)' == '' "&gt;Debug&lt;/Configuration&gt;</code>
          <para>Properties can be referenced throughout the project file by using the syntax $(<placeholder>PropertyName</placeholder>). For example, you can reference the properties in the previous examples by using <codeInline>$(BuildDir)</codeInline> and <codeInline>$(Configuration)</codeInline>.</para>
          <para>For more information about properties, see <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>.</para>
        </content>
      </section>
      <section address="BKMK_Items">
        <title>Items</title>
        <content>
          <para>Items are inputs into the build system and typically represent files. Items are grouped into item types, based on user-defined item names. These item types can be used as parameters for tasks, which use the individual items to perform the steps of the build process.</para>
          <para>Items are declared in the project file by creating an element that has the name of the item type as a child of an <legacyLink xlink:href="aac894e3-a9f1-4bbc-a796-6ef07001f35b">ItemGroup</legacyLink> element. For example, the following code creates an item type named <codeInline>Compile</codeInline>, which includes two files.</para>
          <code>&lt;ItemGroup&gt;
    &lt;Compile Include = "file1.cs"/&gt;
    &lt;Compile Include = "file2.cs"/&gt;
&lt;/ItemGroup&gt;</code>
          <para>Item types can be referenced throughout the project file by using the syntax @(<placeholder>ItemType</placeholder>). For example, the item type in the example would be referenced by using <codeInline>@(Compile)</codeInline>.</para>
          <para>In MSBuild, element and attribute names are case-sensitive. However, property, item, and metadata names are not. The following example creates the item type <codeInline>Compile</codeInline>, <codeInline>comPile</codeInline>, or any other case variation, and gives the item type the value "one.cs;two.cs".</para>
          <code>&lt;ItemGroup&gt;
  &lt;Compile Include="one.cs" /&gt;
  &lt;comPile Include="two.cs" /&gt;
&lt;/ItemGroup&gt;</code>
          <para>Items can be declared by using wildcard characters and may contain additional metadata for more advanced build scenarios. For more information about items, see <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>.</para>
        </content>
      </section>
      <section address="BKMK_Tasks">
        <title>Tasks</title>
        <content>
          <para>Tasks are units of executable code that <token>vstecmsbuild</token> projects use to perform build operations. For example, a task might compile input files or run an external tool. Tasks can be reused, and they can be shared by different developers in different projects.</para>
          <para>The execution logic of a task is written in managed code and mapped to <token>vstecmsbuild</token> by using the <legacyLink xlink:href="20247902-9446-4a1f-8253-5c7a17e4fe43">UsingTask</legacyLink> element. You can write your own task by authoring a managed type that implements the <codeEntityReference autoUpgrade="true">T:Microsoft.Build.Framework.ITask</codeEntityReference> interface. For more information about how to write tasks, see <link xlink:href="3ebc5f87-8f00-46fc-82a1-228f35a6823b">How To: Write a Task</link>.</para>
          <para>
            <token>vstecmsbuild</token> includes common tasks that you can modify to suit your requirements.  Examples are <legacyLink xlink:href="a46ba9da-3e4e-4890-b4ea-09a099b6bc40">Copy</legacyLink>, which copies files, <legacyLink xlink:href="bc951577-1bfb-4100-b1f1-bc8278c45bf7">MakeDir</legacyLink>, which creates directories, and <legacyLink xlink:href="d8c19b36-f5ca-484b-afa6-8ff3b90e103a">Csc</legacyLink>, which compiles Visual C# source code files. For a list of available tasks together with usage information, see <link xlink:href="b3144b27-a426-4259-b8ae-5f7991b202b6">MSBuild Task Reference</link>.</para>
          <para>A task is executed in an <token>vstecmsbuild</token> project file by creating an element that has the name of the task as a child of a <legacyLink xlink:href="350f6fc2-86b3-45f2-a31e-ece0e6bd4dca">Target</legacyLink> element. Tasks typically accept parameters, which are passed as attributes of the element. Both <token>vstecmsbuild</token> properties and items can be used as parameters. For example, the following code calls the <legacyLink xlink:href="bc951577-1bfb-4100-b1f1-bc8278c45bf7">MakeDir</legacyLink> task and passes it the value of the <codeInline>BuildDir</codeInline> property that was declared in the earlier example.</para>
          <code>&lt;Target Name="MakeBuildDirectory"&gt;
    &lt;MakeDir  Directories="$(BuildDir)" /&gt;
&lt;/Target&gt;</code>
          <para>For more information about tasks, see <link xlink:href="5d3cc4a7-e5db-4f73-b707-8b6882fddcf8">MSBuild Tasks</link>.</para>
        </content>
      </section>
      <section address="BKMK_Targets">
        <title>Targets</title>
        <content>
          <para>Targets group tasks together in a particular order and expose sections of the project file as entry points into the build process. Targets are often grouped into logical sections to increase readability and to allow for expansion. Breaking the build steps into targets lets you call one piece of the build process from other targets without copying that section of code into every target. For example, if several entry points into the build process require references to be built, you can create a target that builds references and then run that target from every entry point where it's required.</para>
          <para>Targets are declared in the project file by using the <legacyLink xlink:href="350f6fc2-86b3-45f2-a31e-ece0e6bd4dca">Target</legacyLink> element. For example, the following code creates a target named <codeInline>Compile</codeInline>, which then calls the <legacyLink xlink:href="d8c19b36-f5ca-484b-afa6-8ff3b90e103a">Csc</legacyLink> task that has the item list that was declared in the earlier example.</para>
          <code>&lt;Target Name="Compile"&gt;
    &lt;Csc Sources="@(Compile)" /&gt;
&lt;/Target&gt;</code>
          <para>In more advanced scenarios, targets can be used to describe relationships among one another and perform dependency analysis so that whole sections of the build process can be skipped if that target is up-to-date. For more information about targets, see <link xlink:href="8060b4d2-e4a9-48cf-a437-852649ceb417">MSBuild Targets</link>.</para>
        </content>
      </section>
    </sections>
  </section>
  <section address="BKMK_BuildLogs">
    <title>Build Logs</title>
    <content>
      <para>You can log build errors, warnings, and messages to the console or another output device. For more information, see <link xlink:href="6ba9a754-9cc0-4fed-9fc8-4dcd3926a031">Obtaining Build Logs with MSBuild</link> and <link xlink:href="9aea2e76-8f60-4234-913d-598e7bbad808">Logging in MSBuild</link>.</para>
    </content>
  </section>
  <section address="BKMK_VisualStudio">
    <title>Using MSBuild in Visual Studio</title>
    <content>
      <para>
        <token>vsprvs</token> uses the <token>vstecmsbuild</token> project file format to store build information about managed projects. Project settings that are added or changed by using the <token>vsprvs</token> interface are reflected in the .*proj file that's generated for every project. <token>vsprvs</token> uses a hosted instance of <token>vstecmsbuild</token> to build managed projects. This means that a managed project can be built in <token>vsprvs</token> or at a command prompt (even if <token>vsprvs</token> isn't installed), and the results will be identical. </para>
      <para>For a tutorial about how to use MSBuild in Visual Studio, see <link xlink:href="b8a8b866-bb07-4abf-b9ec-0b40d281c310">Tutorial: How to Use MSBuild</link>.</para>
    </content>
  </section>
  <section address="BKMK_Multitargeting">
    <title>Multitargeting</title>
    <content>
      <para>By using Visual Studio, you can compile an application to run on any one of several versions of the .NET Framework. For example, you can compile an application to run on the .NET Framework 2.0 on a 32-bit platform, and you can compile the same application to run on the .NET Framework 4.5 on a 64-bit platform. The ability to compile to more than one framework is named multitargeting.</para>
      <para>These are some of the benefits of multitargeting:</para>
      <list class="bullet">
        <listItem>
          <para>You can develop applications that target earlier versions of the .NET Framework, for example, versions 2.0, 3.0, and 3.5. </para>
        </listItem>
        <listItem>
          <para>You can target frameworks other than the .NET Framework, for example, Silverlight.</para>
        </listItem>
        <listItem>
          <para>You can target a <newTerm>framework profile</newTerm>, which is a predefined subset of a target framework.</para>
        </listItem>
        <listItem>
          <para>If a service pack for the current version of the .NET Framework is released, you could target it.</para>
        </listItem>
        <listItem>
          <para>Multitargeting guarantees that an application uses only the functionality that's available in the target framework and platform.</para>
        </listItem>
      </list>
      <para>For more information, see <link xlink:href="eecbcd65-9fbc-4307-a321-46d3c3b79b12">MSBuild Multitargeting Overview</link>.</para>
    </content>
  </section>
  <section>
    <title>Related Topics</title>
    <content>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Title</para>
            </TD>
            <TD>
              <para>Description</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <link xlink:href="e3acff7c-cb4e-4ae1-8be2-a871bcff847b">Walkthrough: Creating a Project File from Scratch</link>
              </para>
            </TD>
            <TD>
              <para>Shows how to create a basic project file incrementally, by using only a text editor.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="b8a8b866-bb07-4abf-b9ec-0b40d281c310">Tutorial: How to Use MSBuild</link>
              </para>
            </TD>
            <TD>
              <para>Introduces the building blocks of MSBuild and shows how to write, manipulate, and debug MSBuild projects without closing the Visual Studio IDE.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="083b8ba3-e4ad-45af-bb5d-3bc81d406131">MSBuild Concepts</link>
              </para>
            </TD>
            <TD>
              <para>Presents the four building blocks of MSBuild: properties, items, targets, and tasks.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>
              </para>
            </TD>
            <TD>
              <para>Describes the general concepts behind the <token>vstecmsbuild</token> file format and how the pieces fit together.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>
              </para>
            </TD>
            <TD>
              <para>Introduces properties and property collections. Properties are key/value pairs that can be used to configure builds. </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="8060b4d2-e4a9-48cf-a437-852649ceb417">MSBuild Targets</link>
              </para>
            </TD>
            <TD>
              <para>Explains how to group tasks together in a particular order and enable sections of the build process to be called on the command line. </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="5d3cc4a7-e5db-4f73-b707-8b6882fddcf8">MSBuild Tasks</link>
              </para>
            </TD>
            <TD>
              <para>Shows how to create a unit of executable code that can be used by <token>vstecmsbuild</token> to perform atomic build operations.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="9d7aa308-b667-48ed-b4c9-a61e49eb0a85">MSBuild Conditions</link>
              </para>
            </TD>
            <TD>
              <para>Discusses how to use the <codeInline>Condition</codeInline> attribute in an MSBuild element.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="f34a558a-ebd9-49bd-8510-32a2b581a4af">MSBuild Advanced Concepts</link>
              </para>
            </TD>
            <TD>
              <para>Presents batching, performing transforms, multitargeting, and other advanced techniques.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="9aea2e76-8f60-4234-913d-598e7bbad808">Logging in MSBuild</link>
              </para>
            </TD>
            <TD>
              <para>Describes how to log build events, messages, and errors.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="29dd85ee-1530-43c1-b085-bb2330ac5a48">Additional Resources</link>
              </para>
            </TD>
            <TD>
              <para>Lists community and support resources for more information about MSBuild.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
  </section>
  <section>
    <title>Reference</title>
    <content>
      <definitionTable>
        <definedTerm>
          <link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
        </definedTerm>
        <definition>
          <para>Links to topics that contain reference information.</para>
        </definition>
        <definedTerm>
          <link xlink:href="f767d8e4-24d8-4803-80eb-e857202dbe2c">Glossary</link>
        </definedTerm>
        <definition>
          <para>Defines common MSBuild terms.</para>
        </definition>
      </definitionTable>
    </content>
  </section>
  <relatedTopics />
</developerConceptualDocument>
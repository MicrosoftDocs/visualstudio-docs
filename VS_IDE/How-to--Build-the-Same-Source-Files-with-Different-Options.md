---
title: "How to: Build the Same Source Files with Different Options"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: d14f1212-ddd9-434f-b138-f840011b0fb2
caps.latest.revision: 16
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
# How to: Build the Same Source Files with Different Options
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>When you build projects, you frequently compile the same components with different build options. For example, you can create a debug build with symbol information or a release build with no symbol information but with optimizations enabled. Or you can build a project to run on a specific platform, such as x86 or <token>vcprx64</token>. In all these cases, most of the build options stay the same; only a few options are changed to control the build configuration. With <token>vstecmsbuild</token>, you use properties and conditions to create the different build configurations.</para>
  </introduction>
  <section>
    <title>Using Properties to Modify Projects</title>
    <content>
      <para>The <unmanagedCodeEntityReference>Property</unmanagedCodeEntityReference> element defines a variable that is referenced several times in a project file, such as the location of a temporary directory, or to set the values for properties that are used in several configurations, such as a Debug build and a Release build. For more information about properties, see <link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>.</para>
      <para>You can use properties to change the configuration of your build without having to change the project file. The <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Property</unmanagedCodeEntityReference> element and the <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> element allows you to change the value of properties. For more information about <token>vstecmsbuild</token> conditions, see <link xlink:href="9d7aa308-b667-48ed-b4c9-a61e49eb0a85">MSBuild Conditions</link>.</para>
      <procedure>
        <title>To set a group of properties based on another property</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use a <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference> attribute in a <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> element similar to the following:</para>
              <code>&lt;PropertyGroup Condition="'$(Flavor)'=='DEBUG'"&gt;
    &lt;DebugType&gt;full&lt;/DebugType&gt;
    &lt;Optimize&gt;no&lt;/Optimize&gt;
&lt;/PropertyGroup&gt;</code>
            </content>
          </step>
        </steps>
      </procedure>
      <procedure>
        <title>To define a property based on another property</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use a <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference> attribute in a <unmanagedCodeEntityReference>Property</unmanagedCodeEntityReference> element similar to the following:</para>
              <code>&lt;DebugType Condition="'$(Flavor)'=='DEBUG'"&gt;full&lt;/DebugType&gt;</code>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Specifying Properties on the Command Line</title>
    <content>
      <para>Once your project file is written to accept multiple configurations, you need to have the ability to change those configurations whenever you build your project. <token>vstecmsbuild</token> provides this ability by allowing properties to be specified on the command line using the <system>/property</system> or <system>/p</system> switch.</para>
      <procedure>
        <title>To set a project property at the command line</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use the <system>/property</system> switch with the property and property value. For example:</para>
              <code>msbuild file.proj /property:Flavor=Debug</code>
              <para>- or -</para>
              <code>Msbuild file.proj /p:Flavor=Debug</code>
            </content>
          </step>
        </steps>
      </procedure>
      <procedure>
        <title>To specify more than one project property at the command line</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use the <system>/property</system> or <system>/p</system> switch multiple times with the property and property values, or use one <system>/property</system> or <system>/p</system> switch and separate multiple properties with semicolons (;). For example:</para>
              <code>msbuild file.proj /p:Flavor=Debug;Platform=x86</code>
              <para>- or-</para>
              <code>msbuild file.proj /p:Flavor=Debug /p:Platform=x86</code>
            </content>
          </step>
        </steps>
      </procedure>
      <para>Environment variables are also treated as properties and are automatically incorporated by <token>vstecmsbuild</token>. For more information about using environment variables, see <link xlink:href="7f9e4469-8865-4b59-aab3-3ff26bd36e77">How To: Use Environment Variables in a Build</link>.</para>
      <para>The property value that is specified on the command line takes precedence over any value that is set for the same property in the project file, and that value in the project file takes precedence over the value in an environment variable.</para>
      <para>You can change this behavior by using the <unmanagedCodeEntityReference>TreatAsLocalProperty</unmanagedCodeEntityReference> attribute in a project tag. For property names that are listed with that attribute, the property value that's specified on the command line doesn't take precedence over the value in the project file. You can find an example later in this topic.</para>
    </content>
  </section>
  <codeExample>
    <description>
      <content>
        <para>The following code example, the "Hello World" project, contains two new property groups that can be used to create a Debug build and a Release build.</para>
        <para>To build the debug version of this project, type:</para>
        <code>msbuild consolehwcs1.proj /p:flavor=debug</code>
        <para>To build the retail version of this project, type:</para>
        <code>msbuild consolehwcs1.proj /p:flavor=retail</code>
      </content>
    </description>
    <code>&lt;Project DefaultTargets = "Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;

    &lt;!-- Sets the default flavor of an environment variable called 
    Flavor is not set or specified on the command line --&gt;
    &lt;PropertyGroup&gt;
        &lt;Flavor Condition="'$(Flavor)'==''"&gt;DEBUG&lt;/Flavor&gt;
    &lt;/PropertyGroup&gt;

    &lt;!-- Define the DEBUG settings --&gt;
    &lt;PropertyGroup Condition="'$(Flavor)'=='DEBUG'"&gt;
        &lt;DebugType&gt;full&lt;/DebugType&gt;
        &lt;Optimize&gt;no&lt;/Optimize&gt;
    &lt;/PropertyGroup&gt;

    &lt;!-- Define the RETAIL settings --&gt;
    &lt;PropertyGroup Condition="'$(Flavor)'=='RETAIL'"&gt;
        &lt;DebugType&gt;pdbonly&lt;/DebugType&gt;
        &lt;Optimize&gt;yes&lt;/Optimize&gt;
    &lt;/PropertyGroup&gt;

    &lt;!-- Set the application name as a property --&gt;
    &lt;PropertyGroup&gt;
        &lt;appname&gt;HelloWorldCS&lt;/appname&gt;
    &lt;/PropertyGroup&gt;

    &lt;!-- Specify the inputs by type and file name --&gt;
    &lt;ItemGroup&gt;
        &lt;CSFile Include = "consolehwcs1.cs"/&gt;
    &lt;/ItemGroup&gt;

    &lt;Target Name = "Compile"&gt;
        &lt;!-- Run the Visual C# compilation using input files
        of type CSFile --&gt;
        &lt;CSC  Sources = "@(CSFile)"
            DebugType="$(DebugType)"
            Optimize="$(Optimize)"
            OutputAssembly="$(appname).exe" &gt;

            &lt;!-- Set the OutputAssembly attribute of the CSC
            task to the name of the executable file that is 
            created --&gt;
            &lt;Output TaskParameter="OutputAssembly"
                ItemName = "EXEFile" /&gt;
        &lt;/CSC&gt;
        &lt;!-- Log the file name of the output file --&gt;
        &lt;Message Text="The output file is @(EXEFile)"/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
  </codeExample>
  <codeExample>
    <description>
      <content>
        <para>The following example illustrates how to use the <unmanagedCodeEntityReference>TreatAsLocalProperty</unmanagedCodeEntityReference> attribute. The <codeInline>Color</codeInline> property has a value of <codeInline>Blue</codeInline> in the project file and <codeInline>Green</codeInline> in the command line. With <codeInline>TreatAsLocalProperty="Color"</codeInline> in the project tag, the command-line property (<codeInline>Green</codeInline>) doesn't override the property that's defined in the project file (<codeInline>Blue</codeInline>).</para>
        <para>To build the project, enter the following <?Comment AT: &quot;text&quot;? &quot;commandlines&quot;? 2012-07-26T17:44:00Z  Id='0?>command:</para>
        <code>msbuild colortest.proj /t:go /property:Color=Green</code>
      </content>
    </description>
    <code>&lt;Project xmlns="http://schemas.microsoft.com/developer/msbuild/2003"
ToolsVersion="4.0" TreatAsLocalProperty="Color"&gt;

    &lt;PropertyGroup&gt;
        &lt;Color&gt;Blue&lt;/Color&gt;
    &lt;/PropertyGroup&gt;

    &lt;Target Name="go"&gt;
        &lt;Message Text="Color: $(Color)" /&gt;
    &lt;/Target&gt;
&lt;/Project&gt;

&lt;!--
  Output with TreatAsLocalProperty="Color" in project tag:
     Color: Blue

  Output without TreatAsLocalProperty="Color" in project tag:
     Color: Green
--&gt;</code>
  </codeExample>
  <relatedTopics>
    <link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="083b8ba3-e4ad-45af-bb5d-3bc81d406131">MSBuild Concepts</link>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
<link xlink:href="d1cda56a-dbef-4109-9201-39e962e3f653">Project Element (MSBuild)</link></relatedTopics>
</developerHowToDocument>
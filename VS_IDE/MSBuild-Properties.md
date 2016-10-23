---
title: "MSBuild Properties"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 962912ac-8931-49bf-a88c-0200b6e37362
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
# MSBuild Properties
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Properties are name-value pairs that can be used to configure builds. Properties are useful for passing values to tasks, evaluating conditions, and storing values that will be referenced throughout the project file.</para>
  </introduction>
  <section>
    <title>Defining and Referencing Properties in a Project File</title>
    <content>
      <para>Properties are declared by creating an element that has the name of the property as a child of a <legacyLink xlink:href="ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4">PropertyGroup</legacyLink> element. For example, the following XML creates a property named <codeInline>BuildDir</codeInline> that has a value of <codeInline>Build</codeInline>.</para>
      <code>&lt;PropertyGroup&gt;
    &lt;BuildDir&gt;Build&lt;/BuildDir&gt;
&lt;/PropertyGroup&gt;</code>
      <para>Throughout the project file, properties are referenced by using the syntax $(<parameterReference>PropertyName</parameterReference>). For example, the property in the previous example is referenced by using $(BuildDir).</para>
      <para>Property values can be changed by redefining the property. The <codeInline>BuildDir</codeInline> property can be given a new value by using this XML:</para>
      <code>&lt;PropertyGroup&gt;
    &lt;BuildDir&gt;Alternate&lt;/BuildDir&gt;
&lt;/PropertyGroup&gt;</code>
      <para>Properties are evaluated in the order in which they appear in the project file. The new value for <codeInline>BuildDir</codeInline> must be declared after the old value is assigned.</para>
    </content>
  </section>
  <section>
    <title>Reserved Properties</title>
    <content>
      <para>MSBuild reserves some property names to store information about the project file and the MSBuild binaries. These properties are referenced by using the $ notation, just like any other property. For example, $(MSBuildProjectFile) returns the complete file name of the project file, including the file name extension.</para>
      <para>For more information, see <link xlink:href="c8fcc594-5d37-4e2e-b070-4d9c012043b5">How To: Reference the Name or Location of the Project File</link> and <link xlink:href="99333e61-83c9-4804-84e3-eda297c2478d">MSBuild Reserved Properties</link>.</para>
    </content>
  </section>
  <section>
    <title>Environment Properties</title>
    <content>
      <para>You can reference environment variables in project files just as you reference reserved properties. For example, to use the <codeInline>PATH</codeInline> environment variable in your project file, use $(Path). If the project contains a property definition that has the same name as an environment property, the property in the project overrides the value of the environment variable. </para>
      <para>Each MSBuild project has an isolated environment block: it only sees reads and writes to its own block.  MSBuild only reads environment variables when it initializes the property collection, before the project file is evaluated or built. After that, environment properties are static, that is, each spawned tool starts with the same names and values.</para>
      <para>To get the current value of environment variables from within a spawned tool, use the <link xlink:href="2253956e-3ae0-4bdc-9d3a-4881dfae4ddb">property function</link> System.Environment.GetEnvironmentVariable. The preferred method, however, is to use the task parameter <codeEntityReference>P:Microsoft.Build.Utilities.ToolTask.EnvironmentVariables</codeEntityReference>. Environment properties set in this string array can be passed to the spawned tool without affecting the system environment variables.</para>
      <alert class="tip">
        <para>Not all environment variables are read in to become initial properties. Any environment variable whose name is not a valid MSBuild property names, such as "386", is ignored.</para>
      </alert>
      <para>For more information, see <link xlink:href="7f9e4469-8865-4b59-aab3-3ff26bd36e77">How To: Use Environment Variables in a Build</link>.</para>
    </content>
  </section>
  <section>
    <title>Registry Properties</title>
    <content>
      <para>You can read system registry values by using the following syntax, where <languageKeyword>Hive</languageKeyword> is the registry hive (for example, HKEY_LOCAL_MACHINE ), <languageKeyword>Key</languageKeyword> is the key name, <languageKeyword>SubKey</languageKeyword> is the subkey name, and <languageKeyword>Value</languageKeyword> is the value of the subkey.</para>
      <code>$(registry:Hive\MyKey\MySubKey@Value)</code>
      <para>To get the default subkey value, omit the <languageKeyword>Value</languageKeyword>.</para>
      <code>$(registry:Hive\MyKey\MySubKey)</code>
      <para>This registry value can be used to initialize a build property. For example, to create a build property that represents the Visual Studio web browser home page, use this code:</para>
      <code>&lt;PropertyGroup&gt;
  &lt;VisualStudioWebBrowserHomePage&gt;
    $(registry:HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\12.0\WebBrowser@HomePage)
  &lt;/VisualStudioWebBrowserHomePage&gt;
&lt;PropertyGroup&gt;</code>
    </content>
  </section>
  <section>
    <title>Global Properties</title>
    <content>
      <para>MSBuild lets you set properties on the command line by using the <system>/property</system> (or <system>/p</system>) switch. These global property values override property values that are set in the project file. This includes environment properties, but does not include reserved properties, which cannot be changed.</para>
      <para>The following example sets the global <unmanagedCodeEntityReference>Configuration</unmanagedCodeEntityReference> property to <codeInline>DEBUG</codeInline>.</para>
      <code>msbuild.exe MyProj.proj /p:Configuration=DEBUG</code>
      <para>Global properties can also be set or modified for child projects in a multi-project build by using the <unmanagedCodeEntityReference>Properties</unmanagedCodeEntityReference> attribute of the MSBuild task. For more information, see <link xlink:href="76577f6c-7669-44ad-a840-363e37a04d34">MSBuild task</link>.</para>
      <para>If you specify a property by using the <unmanagedCodeEntityReference>TreatAsLocalProperty</unmanagedCodeEntityReference> attribute in a project tag, that global property value doesn't override the property value that's set in the project file. For more information, see <link xlink:href="d1cda56a-dbef-4109-9201-39e962e3f653">Project Element (MSBuild)</link> and <link xlink:href="d14f1212-ddd9-434f-b138-f840011b0fb2">How to: Build the Same Source Files with Different Options</link>.</para>
    </content>
  </section>
  <section>
    <title>Property Functions</title>
    <content>
      <para>Starting in .NET Framework version 4, you can use property functions to evaluate your MSBuild scripts. You can read the system time, compare strings, match regular expressions, and perform many other actions within your build script without using MSBuild tasks.</para>
      <para>You can use string (instance) methods to operate on any property value, and you can call the static methods of many system classes. For example, you can set a build property to today's date as follows.</para>
      <code>&lt;Today&gt;$([System.DateTime]::Now.ToString("yyyy.MM.dd"))&lt;/Today&gt;</code>
      <para>For more information, and a list of property functions, see <link xlink:href="2253956e-3ae0-4bdc-9d3a-4881dfae4ddb">Property Functions</link>.</para>
    </content>
  </section>
  <section>
    <title>Creating Properties During Execution</title>
    <content>
      <para>Properties positioned outside <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> elements are assigned values during the evaluation phase of a build. During the subsequent execution phase, properties can be created or modified as follows:</para>
      <list class="bullet">
        <listItem>
          <para>A property can be emitted by any task. To emit a property, the <legacyLink xlink:href="d82e2485-e5f0-4936-a357-745bacccc299">Task</legacyLink> element must have a child <legacyLink xlink:href="34bc7cd1-efd3-4b57-b691-4584eeb6a0e9">Output</legacyLink> element that has a <unmanagedCodeEntityReference>PropertyName</unmanagedCodeEntityReference> attribute. </para>
        </listItem>
        <listItem>
          <para>A property can be emitted by the <legacyLink xlink:href="fbc31a88-62d4-43d2-b739-68ef3fac38f5">CreateProperty</legacyLink> task. This usage is deprecated. </para>
        </listItem>
        <listItem>
          <para>Starting in the .NET Framework 3.5, <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> elements may contain <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> elements that may contain property declarations. </para>
        </listItem>
      </list>
    </content>
  </section>
  <section>
    <title>Storing XML in Properties</title>
    <content>
      <para>Properties can contain arbitrary XML, which can help in passing values to tasks or displaying logging information. The following example shows the <unmanagedCodeEntityReference>ConfigTemplate</unmanagedCodeEntityReference> property, which has a value that contains XML and other property references. <token>vstecmsbuild</token> replaces the property references by using their respective property values. Property values are assigned in the order in which they appear. Therefore, in this example, <codeInline>$(MySupportedVersion)</codeInline>, <codeInline>$(MyRequiredVersion)</codeInline>, and <codeInline>$(MySafeMode)</codeInline> should have already been defined.</para>
      <code>
&lt;PropertyGroup&gt;
    &lt;ConfigTemplate&gt;
        &lt;Configuration&gt;
            &lt;Startup&gt;
                &lt;SupportedRuntime
                    ImageVersion="$(MySupportedVersion)"
                    Version="$(MySupportedVersion)"/&gt;
                &lt;RequiredRuntime
                    ImageVersion="$(MyRequiredVersion)
                    Version="$(MyRequiredVersion)"
                    SafeMode="$(MySafeMode)"/&gt;
            &lt;/Startup&gt;
        &lt;/Configuration&gt;
    &lt;/ConfigTemplate&gt;
&lt;/PropertyGroup&gt;</code>
    </content>
  </section>
  <relatedTopics>
    <link xlink:href="083b8ba3-e4ad-45af-bb5d-3bc81d406131">MSBuild Concepts</link>

<link xlink:href="7f9e4469-8865-4b59-aab3-3ff26bd36e77">How To: Use Environment Variables in a Build</link>
<link xlink:href="c8fcc594-5d37-4e2e-b070-4d9c012043b5">How To: Reference the Name or Location of the Project File</link>
<link xlink:href="d14f1212-ddd9-434f-b138-f840011b0fb2">How to: Build the Same Source Files with Different Options</link>
<link xlink:href="99333e61-83c9-4804-84e3-eda297c2478d">MSBuild Reserved Properties</link>
<link xlink:href="69ab08ab-3e76-41dd-a01b-49aa1d2e0cac">Property Element (MSBuild)</link></relatedTopics>
</developerConceptualDocument>
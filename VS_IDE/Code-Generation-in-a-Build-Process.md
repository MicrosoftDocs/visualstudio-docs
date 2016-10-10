---
title: "Code Generation in a Build Process"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 4da43429-2a11-4d7e-b2e0-9e4af7033b5a
caps.latest.revision: 26
manager: kamrani
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
# Code Generation in a Build Process
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <legacyLink xlink:href="74a0a748-5b11-4999-8bea-49572967827d">Text transformation</legacyLink> can be invoked as part of the <legacyLink xlink:href="a971b0f9-7c28-479d-a37b-8fd7e27ef692">build process</legacyLink> of a <token>vsprvs</token> solution. There are build tasks that are specialized for text transformation. The T4 build tasks run design-time text templates, and they also compile run-time (preprocessed) text templates.</para>
    <para>There are some differences in what the build tasks can do, depending on which build engine you use. When you build the solution in Visual Studio, a text template can access the Visual Studio API (EnvDTE) if the <legacyLink xlink:href="2b0a8e04-6fee-4c6c-b086-e49fc728a3ed">hostspecific="true"</legacyLink> attribute is set. But that isn’t true when you build the solution from the command line or when you initiate a server build through Visual Studio. In those cases, the build is performed by MSBuild and a different T4 host is used. </para>
    <para>This means that you can’t access things like project file names in the same way when you build a text template in MSBuild. However, you can <legacyLink xlink:href="#parameters">pass environment information into text templates and directive processors by using build parameters</legacyLink>. </para>
  </introduction>
  <section address="buildserver">
    <title>Configure your machines</title>
    <content>
      <para>To enable build tasks on your development computer, install <externalLink><linkText>Modeling SDK for Visual Studio</linkText><linkUri>http://www.microsoft.com/download/details.aspx?id=40754</linkUri></externalLink>.</para>
      <para>If <legacyLink xlink:href="788443c3-0547-452e-959c-4805573813a9">your build server</legacyLink> runs on a computer on which <token>vsprvs</token> is not installed, copy the following files to the build computer from your development machine. Substitute the most recent version numbers for ‘*’.</para>
      <list class="bullet">
        <listItem>
          <para>$(ProgramFiles)\MSBuild\Microsoft\VisualStudio\v*.0\TextTemplating</para>
          <list class="bullet">
            <listItem>
              <para>Microsoft.VisualStudio.TextTemplating.Sdk.Host.*.0.dll</para>
            </listItem>
            <listItem>
              <para>Microsoft.TextTemplating.Build.Tasks.dll</para>
            </listItem>
            <listItem>
              <para>Microsoft.TextTemplating.targets</para>
            </listItem>
          </list>
        </listItem>
        <listItem>
          <para>$(ProgramFiles)\Microsoft Visual Studio *.0\VSSDK\VisualStudioIntegration\Common\Assemblies\v4.0</para>
          <list class="bullet">
            <listItem>
              <para>Microsoft.VisualStudio.TextTemplating.*.0.dll</para>
            </listItem>
            <listItem>
              <para>Microsoft.VisualStudio.TextTemplating.Interfaces.*.0.dll (several files)</para>
            </listItem>
            <listItem>
              <para>Microsoft.VisualStudio.TextTemplating.VSHost.*.0.dll</para>
            </listItem>
          </list>
        </listItem>
        <listItem>
          <para>$(ProgramFiles)\Microsoft Visual Studio *.0\Common7\IDE\PublicAssemblies\</para>
          <list class="bullet">
            <listItem>
              <para>Microsoft.VisualStudio.TextTemplating.Modeling.*.0.dll</para>
            </listItem>
          </list>
        </listItem>
      </list>
    </content>
  </section>
  <section>
    <title>To edit the project file</title>
    <content>
      <para>You’ll have to edit your project file to configure some of the features in MSBuild. </para>
      <para>In solution explorer, choose <ui>Unload</ui> from the context menu of your project. That allows you to edit the .csproj or .vbproj file in the XML editor.</para>
      <para>When you’ve finished editing, choose <ui>Reload</ui>.</para>
    </content>
  </section>
  <section>
    <title>Import the Text Transformation Targets</title>
    <content>
      <para>In the .vbproj or .csproj file, find a line like this:</para>
      <para>
        <codeInline>&lt;Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" /&gt;</codeInline>
      </para>
      <para>- or -</para>
      <para>
        <codeInline>&lt;Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" /&gt;</codeInline>
      </para>
      <para>After that line, insert the Text Templating import:</para>
      <code language="xml">&lt;!-- Optionally make the import portable across VS versions --&gt;
  &lt;PropertyGroup&gt;
    &lt;!-- Get the Visual Studio version – defaults to 10: --&gt;
    &lt;VisualStudioVersion Condition="'$(VisualStudioVersion)' == ''"&gt;10.0&lt;/VisualStudioVersion&gt;
    &lt;!-- Keep the next element all on one line: --&gt;
    &lt;VSToolsPath Condition="'$(VSToolsPath)' == ''"&gt;$(MSBuildExtensionsPath32)\Microsoft\VisualStudio\v$(VisualStudioVersion)&lt;/VSToolsPath&gt;
  &lt;/PropertyGroup&gt;


&lt;!-- This is the important line: --&gt;
  &lt;Import Project="$(VSToolsPath)\TextTemplating\Microsoft.TextTemplating.targets" /&gt;</code>
    </content>
  </section>
  <section>
    <title>Transforming templates in a build</title>
    <content>
      <para>There are some properties that you can insert into your project file to control the transformation task:</para>
      <list class="bullet">
        <listItem>
          <para>Run the Transform task at the start of every build:</para>
          <code language="xml">&lt;PropertyGroup&gt;
    &lt;TransformOnBuild&gt;true&lt;/TransformOnBuild&gt;
&lt;/PropertyGroup&gt;</code>
        </listItem>
        <listItem>
          <para>Overwrite files that are read-only, for example because they are not checked out:</para>
          <code language="xml">&lt;PropertyGroup&gt;
    &lt;OverwriteReadOnlyOutputFiles&gt;true&lt;/OverwriteReadOnlyOutputFiles&gt;
&lt;/PropertyGroup&gt;</code>
        </listItem>
        <listItem>
          <para>Transform every template every time:</para>
          <code language="xml">&lt;PropertyGroup&gt;
    &lt;TransformOutOfDateOnly&gt;false&lt;/TransformOutOfDateOnly&gt;
&lt;/PropertyGroup&gt;</code>
          <para>By default, the T4 MSBuild task regenerates an output file if it is older than its template file, or any files that are included, or any files that have previously been read by the template or by a directive processor that it uses. Notice that this is a much more powerful dependency test than is used by the Transform All Templates command in Visual Studio, which only compares the dates of the template and output file.</para>
        </listItem>
      </list>
      <para>To perform just the text transformations in your project, invoke the TransformAll task:</para>
      <para>
        <codeInline>msbuild myProject.csproj /t:TransformAll </codeInline>
      </para>
      <para>To transform a specific text template:</para>
      <para>
        <codeInline>msbuild myProject.csproj /t:Transform /p:TransformFile="Template1.tt"</codeInline>
      </para>
      <para>You can use wildcards in TransformFile:</para>
      <para>
        <codeInline>msbuild dsl.csproj /t:Transform /p:TransformFile="GeneratedCode\**\*.tt"</codeInline>
      </para>
    </content>
  </section>
  <section>
    <title>Source Control</title>
    <content>
      <para>There is no specific built-in integration with a source control system. However, you can add your own extensions, for example to check out and check in a generated file.By default, the text transform task avoids overwriting a file that is marked as read- only, and when such a file is encountered, an error is logged in the Visual Studio error list, and the task fails.</para>
      <para>To specify that read-only files should be overwritten, insert this property:</para>
      <para>
        <codeInline>&lt;OverwriteReadOnlyOuputFiles&gt;true&lt;/OverwriteReadOnlyOuputFiles&gt;</codeInline>
      </para>
      <para>Unless you customize the postprocessing step, a warning will be logged in the error list when a file is overwritten.</para>
    </content>
  </section>
  <section>
    <title>Customizing the build process</title>
    <content>
      <para>Text transformation happens before other tasks in the build process. You can define tasks that are invoked before and after transformation, by setting the properties <codeInline>$(BeforeTransform)</codeInline> and <codeInline>$(AfterTransform)</codeInline>:</para>
      <code>&lt;PropertyGroup&gt;
    &lt;BeforeTransform&gt;CustomPreTransform&lt;/BeforeTransform&gt;
    &lt;AfterTransform&gt;CustomPostTransform&lt;/AfterTransform&gt;
  &lt;/PropertyGroup&gt;
  &lt;Target Name="CustomPreTransform"&gt;
    &lt;Message Text="In CustomPreTransform..." Importance="High" /&gt;
  &lt;/Target&gt;
  &lt;Target Name="CustomPostTransform"&gt;
    &lt;Message Text="In CustomPostTransform..." Importance="High" /&gt;
  &lt;/Target&gt;</code>
      <para>In <codeInline>AfterTransform</codeInline>, you can reference lists of files:</para>
      <list class="bullet">
        <listItem>
          <para>GeneratedFiles - a list of files written by the process. For those files that overwrote existing read-only files, %(GeneratedFiles.ReadOnlyFileOverwritten) will be true. These files can be checked out of source control.</para>
        </listItem>
        <listItem>
          <para>NonGeneratedFiles - a list of read-only files that were not overwritten.</para>
        </listItem>
      </list>
      <para>For example, you define a task to check out GeneratedFiles.</para>
    </content>
  </section>
  <section>
    <title>OutputFilePath and OutputFileName</title>
    <content>
      <para>These properties are used only by MSBuild. They do not affect code generation in Visual Studio. They redirect the generated output file to a different folder or file. The target folder must already exist.</para>
      <code language="xml">&lt;ItemGroup&gt;
  &lt;None Include="MyTemplate.tt"&gt;
    &lt;Generator&gt;TextTemplatingFileGenerator&lt;/Generator&gt;
    &lt;OutputFilePath&gt;MyFolder&lt;/OutputFilePath&gt;
    &lt;LastGenOutput&gt;MyTemplate.cs&lt;/LastGenOutput&gt;
  &lt;/None&gt;
&lt;/ItemGroup&gt;</code>
      <para>A useful folder to redirect to is <codeInline>$(IntermediateOutputPath).</codeInline></para>
      <para>If you specify and output filename, it will take precedence over the extension specified in the output directive in the templates.</para>
      <code language="xml">&lt;ItemGroup&gt;
  &lt;None Include="MyTemplate.tt"&gt;
    &lt;Generator&gt;TextTemplatingFileGenerator&lt;/Generator&gt;
    &lt;OutputFileName&gt;MyOutputFileName.cs&lt;/OutputFileName&gt;
    &lt;LastGenOutput&gt;MyTemplate.cs&lt;/LastGenOutput&gt;
  &lt;/None&gt;
&lt;/ItemGroup&gt;</code>
      <para>Specifying an OutputFileName or OutputFilePath isn’t recommended if you are also transforming templates inside VS using Transform All, or running the single file generator. You will end up with different file paths depending on how you triggered the transformation. This can be very confusing.</para>
    </content>
  </section>
  <section>
    <title>Adding reference and include paths</title>
    <content>
      <para>The host has a default set of paths where it searches for assemblies referenced in templates. To add to this set:</para>
      <code>&lt;ItemGroup&gt;
    &lt;T4ReferencePath Include="$(VsIdePath)PublicAssemblies\" /&gt;
    &lt;!-- Add more T4ReferencePath items here --&gt;
&lt;/ItemGroup&gt;</code>
      <para>To set the folders that will be searched for include files, provide a semicolon-separated list. Usually you add to the existing folder list.</para>
      <code>&lt;PropertyGroup&gt;
    &lt;IncludeFolders&gt;
$(IncludeFolders);$(MSBuildProjectDirectory)\Include;AnotherFolder;And\Another&lt;/IncludeFolders&gt;
&lt;/PropertyGroup&gt;
</code>
    </content>
  </section>
  <section address="parameters">
    <title>Pass build context data into the templates</title>
    <content>
      <para>You can set parameter values in the project file. For example, you can pass "build"" properties and <legacyLink xlink:href="7f9e4469-8865-4b59-aab3-3ff26bd36e77">environment variables</legacyLink>:</para>
      <code language="xml">&lt;ItemGroup&gt;
  &lt;T4ParameterValues Include="ProjectFolder"&gt;
    &lt;Value&gt;$(ProjectDir)&lt;/Value&gt;
    &lt;Visible&gt;false&lt;/Visible&gt;
  &lt;/T4ParameterValues&gt;
&lt;/ItemGroup&gt;</code>
      <para>In a text template, set <codeInline>hostspecific</codeInline> in the template directive. Use the <legacyLink xlink:href="1d590387-1d9d-40a5-a72c-65fae7a8bdf3">parameter</legacyLink> directive to get values:</para>
      <code>&lt;#@template language="c#" hostspecific="true"#&gt;
&lt;#@ parameter type="System.String" name="ProjectFolder" #&gt;
The project folder is: &lt;#= ProjectFolder #&gt;
</code>
      <para>In a directive processor, you can call <codeEntityReference autoUpgrade="true" qualifyHint="false">M:Microsoft.VisualStudio.TextTemplating.ITextTemplatingEngineHost.ResolveParameterValue(System.String,System.String,System.String)</codeEntityReference>:</para>
      <code language="c#">string value = Host.ResolveParameterValue("-", "-", "parameterName");</code>
      <code language="vb#">Dim value = Host.ResolveParameterValue("-", "-", "parameterName")</code>
      <alert class="note">
        <para>
          <codeInline>ResolveParameterValue</codeInline> gets data from <codeInline>T4ParameterValues</codeInline> only when you use MSBuild. When you transform the template using Visual Studio, the parameters will have default values.</para>
      </alert>
    </content>
  </section>
  <section address="msbuild">
    <title>Using project properties in assembly and include directives</title>
    <content>
      <para>Visual Studio macros like $(SolutionDir) don’t work in MSBuild. You can use project properties instead. </para>
      <para>Edit your .csproj or .vbproj file to define a project property. This example defines a property named <codeInline>myLibFolder</codeInline>:</para>
      <code language="xml">&lt;!-- Define a project property, myLibFolder: --&gt;
&lt;PropertyGroup&gt;
    &lt;<placeholder>myLibFolder</placeholder>&gt;$(MSBuildProjectDirectory)\..\libs&lt;/<placeholder>myLibFolder</placeholder>&gt;
&lt;/PropertyGroup&gt;

&lt;!-- Tell the MSBuild T4 task to make the property available: --&gt;
&lt;ItemGroup&gt;
    &lt;T4ParameterValues Include="<placeholder>myLibFolder</placeholder>"&gt;
      &lt;Value&gt;$(<placeholder>myLibFolder</placeholder>)&lt;/Value&gt;
    &lt;/T4ParameterValues&gt;
  &lt;/ItemGroup&gt;

</code>
      <para>Now you can use your project property in assembly and include directives:</para>
      <code>&lt;#@ assembly name="$(<placeholder>myLibFolder</placeholder>)\MyLib.dll" #&gt;
&lt;#@ include file="$(<placeholder>myLibFolder</placeholder>)\MyIncludeFile.t4" #&gt;</code>
      <para>These directives get values from T4parameterValues both in MSBuild and in Visual Studio hosts.</para>
    </content>
  </section>
  <section>
    <title>Q &amp; A</title>
    <content>
      <para>
        <embeddedLabel>Why would I want to transform templates in the build server? I already transformed templates in Visual Studio before I checked in my code.</embeddedLabel>
      </para>
      <para>If you update an included file, or another file read by the template, Visual Studio doesn’t transform the file automatically. Transforming templates as part of the build makes sure that everything’s up to date.</para>
      <para>
        <embeddedLabel>What other options are there for transforming text templates?</embeddedLabel>
      </para>
      <list class="bullet">
        <listItem>
          <para>The <legacyLink xlink:href="06a48235-fe02-403e-a1cf-2ae70b4db62f">TextTransform utility</legacyLink> can be used in command scripts. In most cases, it’s easier to use MSBuild.</para>
        </listItem>
        <listItem>
          <para>
            <link xlink:href="64674976-841f-43cb-8e61-0645c8a89eec">Invoking T4 in a VS Extension</link>
          </para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="2774b83d-1adb-4c66-a607-746e019b80c0">Design-time text templates</legacyLink> are transformed by Visual Studio.</para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="79b4b3c6-a9a7-4446-b6fd-e2388fc6b05f">Run time text templates</legacyLink> are transformed at run time in your application.</para>
        </listItem>
      </list>
    </content>
  </section>
  <section>
    <title>Read more</title>
    <content>
      <para>There is good guidance in the T4 MSbuild template, $(VSToolsPath)\TextTemplating\Microsoft.TextTemplating.targets</para>
      <para>
        <link xlink:href="94328da7-953b-4e92-9587-648543d1f732">Writing a text template</link>
      </para>
      <para>
        <externalLink>
          <linkText>Visual Studio Visualization and Modeling SDK</linkText>
          <linkUri>http://go.microsoft.com/fwlink/?LinkID=185579</linkUri>
        </externalLink>
      </para>
      <para>
        <externalLink>
          <linkText>Oleg Sych: Understanding T4:MSBuild Integration</linkText>
          <linkUri>http://www.olegsych.com/2010/04/understanding-t4-msbuild-integration/</linkUri>
        </externalLink>
      </para>
    </content>
  </section>
  <relatedTopics />
</developerConceptualDocument>
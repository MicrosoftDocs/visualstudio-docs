---
title: "How to: Use Environment Variables in a Build"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 7f9e4469-8865-4b59-aab3-3ff26bd36e77
caps.latest.revision: 12
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
# How to: Use Environment Variables in a Build
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>When you build projects, it is often necessary to set build options using information that is not in the project file or the files that comprise your project. This information is typically stored in environment variables.</para>
  </introduction>
  <section>
    <title>Referencing Environment Variables</title>
    <content>
      <para>All environment variables are available to the <token>vstecmsbuildengine</token> (<token>vstecmsbuild</token>) project file as properties.</para>
      <alert class="note">
        <para>If the project file contains an explicit definition of a property that has the same name as an environment variable, the property in the project file overrides the value of the environment variable.</para>
      </alert>
      <procedure>
        <title>To use an environment variable in an MSBuild project</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Reference the environment variable the same way you would a variable declared in your project file. For example, the following code references the BIN_PATH environment variable:</para>
              <para>
                <codeInline>&lt;FinalOutput&gt;$(BIN_PATH)\MyAssembly.dll&lt;/FinalOutput&gt;</codeInline>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
      <para>You can use a <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference> attribute to provide a default value for a property if the environment variable was not set.</para>
      <procedure>
        <title>To provide a default value for a property</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use a <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference> attribute on a property to set the value only if the property has no value. For example, the following code sets the <unmanagedCodeEntityReference>ToolsPath</unmanagedCodeEntityReference> property to c:\tools only if the <unmanagedCodeEntityReference>ToolsPath</unmanagedCodeEntityReference> environment variable is not set:</para>
              <para>
                <codeInline>&lt;ToolsPath Condition="'$(TOOLSPATH)' == ''"&gt;c:\tools&lt;/ToolsPath&gt;</codeInline>
              </para>
              <alert class="note">
                <para>Property names are not case-sensitive so both <codeInline>$(ToolsPath)</codeInline> and <codeInline>$(TOOLSPATH)</codeInline> reference the same property or environment variable.</para>
              </alert>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <codeExample>
    <description>
      <content>
        <para>The following project file uses environment variables to specify the location of directories.</para>
      </content>
    </description>
    <code>&lt;Project DefaultTargets="FakeBuild"&gt;
    &lt;PropertyGroup&gt;
        &lt;FinalOutput&gt;$(BIN_PATH)\myassembly.dll&lt;/FinalOutput&gt;
        &lt;ToolsPath Condition=" '$(ToolsPath)' == '' "&gt;
            C:\Tools
        &lt;/ToolsPath&gt;
    &lt;/PropertyGroup&gt;
    &lt;Target Name="FakeBuild"&gt;
        &lt;Message Text="Building $(FinalOutput) using the tools at $(ToolsPath)..."/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>
<link xlink:href="d14f1212-ddd9-434f-b138-f840011b0fb2">How To: Build the Same Source Files with Different Options</link>
</relatedTopics>
</developerHowToDocument>
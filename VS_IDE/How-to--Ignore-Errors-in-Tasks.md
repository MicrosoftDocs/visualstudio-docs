---
title: "How to: Ignore Errors in Tasks"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e2f1ca4f-787b-44bd-bc64-81a036025e96
caps.latest.revision: 15
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
# How to: Ignore Errors in Tasks
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Sometimes you want a build to be tolerant of faults in certain tasks. If those non-critical tasks fail, you want the build to continue because it can still produce the required output. For example, if a project uses a <unmanagedCodeEntityReference>SendMail</unmanagedCodeEntityReference> task to send an e-mail message after each component is built, you might consider it acceptable for the build to proceed to completion even when the mail servers are unavailable and the status messages cannot be sent. Or, for example, if intermediate files are usually deleted during the build, you might consider it acceptable for the build to proceed to completion even when those files cannot be deleted.</para>
  </introduction>
  <section>
    <title>Using the ContinueOnError Attribute</title>
    <content>
      <para>The <unmanagedCodeEntityReference>ContinueOnError</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Task</unmanagedCodeEntityReference> element controls whether a build stops or continues when a task failure occurs. This attribute also controls whether errors are treated as errors or warnings when the build continues.</para>
      <para>The <languageKeyword>ContinueOnError</languageKeyword> attribute can contain one of the following values:</para>
      <list class="bullet">
        <listItem>
          <para>
            <embeddedLabel>WarnAndContinue</embeddedLabel> or <embeddedLabel>true</embeddedLabel>. When a task fails, subsequent tasks in the <legacyLink xlink:href="350f6fc2-86b3-45f2-a31e-ece0e6bd4dca">Target</legacyLink> element and the build continue to execute, and all errors from the task are treated as warnings.</para>
        </listItem>
        <listItem>
          <para>
            <embeddedLabel>ErrorAndContinue</embeddedLabel>. When a task fails, subsequent tasks in the <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> element and the build continue to execute, and all errors from the task are treated as errors.</para>
        </listItem>
        <listItem>
          <para>
            <embeddedLabel>ErrorAndStop</embeddedLabel> or <embeddedLabel>false</embeddedLabel> (default). When a task fails, the remaining tasks in the <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> element and the build aren't executed, and the entire <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> element and the build is considered to have failed.</para>
        </listItem>
      </list>
      <para>Versions of the .NET Framework before 4.5 supported only the <languageKeyword>true</languageKeyword> and <languageKeyword>false</languageKeyword> values.</para>
      <para>The default value of <unmanagedCodeEntityReference>ContinueOnError</unmanagedCodeEntityReference> is <languageKeyword>ErrorAndStop</languageKeyword>. If you set the attribute to <languageKeyword>ErrorAndStop</languageKeyword>, you make the behavior explicit to anyone who reads the project file.</para>
      <procedure>
        <title>To ignore an error in a task</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use the <unmanagedCodeEntityReference>ContinueOnError</unmanagedCodeEntityReference> attribute of the task. For example:</para>
              <para>
                <codeInline>&lt;Delete Files="@(Files)" ContinueOnError="WarnAndContinue"/&gt;</codeInline>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <codeExample>
    <description>
      <content>
        <para>The following code example illustrates that the <codeInline>Build</codeInline> target still runs and the build is considered a success, even if the <unmanagedCodeEntityReference>Delete</unmanagedCodeEntityReference> task fails.</para>
      </content>
    </description>
    <code>&lt;Project DefaultTargets="FakeBuild"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;
    &lt;ItemGroup&gt;
        &lt;Files Include="*.obj"/&gt;
    &lt;/ItemGroup&gt;
    &lt;Target Name="Clean"&gt;
        &lt;Delete Files="@(Files)" ContinueOnError="WarnAndContinue"/&gt;
    &lt;/Target&gt;

    &lt;Target Name="FakeBuild" DependsOnTargets="Clean"&gt;
        &lt;Message Text="Building after cleaning..."/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>
    <link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="b3144b27-a426-4259-b8ae-5f7991b202b6">MSBuild Task Reference</link>
<link xlink:href="5d3cc4a7-e5db-4f73-b707-8b6882fddcf8">MSBuild Tasks</link></relatedTopics>
</developerHowToDocument>
---
title: "How to: Specify Which Target to Build First"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a580ba5b-2919-42d2-ae38-1af991e0205a
caps.latest.revision: 14
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
# How to: Specify Which Target to Build First
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>A project file can contain one or more <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> elements that define how the project is built. The <token>vstecmsbuildengine</token> (<token>vstecmsbuild</token>) engine builds the first project it finds, and any dependencies, unless the project file contains a <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute, an <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference> attribute, or a target is specified at the command line using the <system>/target</system> switch. </para>
  </introduction>
  <section>
    <title>Using the InitialTargets Attribute</title>
    <content>
      <para>The <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Project</unmanagedCodeEntityReference> element specifies a target that will run first, even if targets are specified on the command line or in the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute.</para>
      <procedure>
        <title>To specify one initial target</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Specify the default target in the <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Project</unmanagedCodeEntityReference> element. For example:</para>
              <para>
                <codeInline>&lt;Project InitialTargets="Clean"&gt;</codeInline>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
      <para>You can specify more than one initial target in the <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference> attribute by listing the targets in order, and using a semicolon to separate each target. The targets in the list will be run sequentially.</para>
      <procedure>
        <title>To specify more than one initial target</title>
        <steps class="bullet">
          <step>
            <content>
              <para>List the initial targets, separated by semicolons, in the <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Project</unmanagedCodeEntityReference> element. For example, to run the <unmanagedCodeEntityReference>Clean</unmanagedCodeEntityReference> target and then the <unmanagedCodeEntityReference>Compile</unmanagedCodeEntityReference> target, type:</para>
              <para>
                <codeInline>&lt;Project InitialTargets="Clean;Compile"&gt;</codeInline>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Using the DefaultTargets Attribute</title>
    <content>
      <para>The <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Project</unmanagedCodeEntityReference> element specifies which target or targets are built if a target is not specified explicitly on the command line. If targets are specified in both the <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference> and <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attributes and no target is specified on the command line, <token>vstecmsbuild</token> runs the targets specified in the <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference> attribute followed by the targets specified in the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute.</para>
      <procedure>
        <title>To specify one default target</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Specify the default target in the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Project</unmanagedCodeEntityReference> element. For example:</para>
              <para>
                <codeInline>&lt;Project DefaultTargets="Compile"&gt;</codeInline>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
      <para>You can specify more than one default target in the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute by listing the targets in order, and using a semicolon to separate each target. The targets in the list will be run sequentially.</para>
      <procedure>
        <title>To specify more than one default target</title>
        <steps class="bullet">
          <step>
            <content>
              <para>List the default targets, separated by semicolons, in the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Project</unmanagedCodeEntityReference> element. For example, to run the <unmanagedCodeEntityReference>Clean</unmanagedCodeEntityReference> target and then the <unmanagedCodeEntityReference>Compile</unmanagedCodeEntityReference> target, type:</para>
              <para>
                <codeInline>&lt;Project DefaultTargets="Clean;Compile"&gt;</codeInline>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Using the /target Switch</title>
    <content>
      <para>If a default target is not defined in the project file, or if you do not want to use that default target, you can use the command line switch <system>/target</system> to specify a different target. The target or targets specified with the <system>/target</system> switch are run instead of the targets specified by the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute. Targets specified in the <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference> attribute always run first.</para>
      <procedure>
        <title>To use a target other than the default target first</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Specify the target as the first target using the <system>/target</system> command line switch. For example:</para>
              <para>
                <codeInline>msbuild file.proj /target:Clean</codeInline>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
      <procedure>
        <title>To use several targets other than the default targets first</title>
        <steps class="bullet">
          <step>
            <content>
              <para>List the targets, separated by semicolons or commas, using the <system>/target</system> command line switch. For example:</para>
              <para>
                <codeInline>msbuild &lt;file name&gt;.proj /t:Clean;Compile</codeInline>
              </para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <relatedTopics>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="8060b4d2-e4a9-48cf-a437-852649ceb417">MSBuild Targets</link>
<link xlink:href="999ba473-b0c4-45c7-930a-63ea7a510509">How To: Clean a Build</link>
</relatedTopics>
</developerHowToDocument>
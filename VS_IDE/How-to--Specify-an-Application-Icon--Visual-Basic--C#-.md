---
title: "How to: Specify an Application Icon (Visual Basic, C#)"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ad8e14ed-adc2-45b6-a0be-818b16d5616f
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
# How to: Specify an Application Icon (Visual Basic, C#)
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://dduestorage.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>The <languageKeyword>Icon</languageKeyword> property for a project specifies the icon file (.ico) that will be displayed for the compiled application in File Explorer and in the Windows taskbar. </para>
    <para>The <languageKeyword>Icon</languageKeyword> property can be accessed in the <ui>Application</ui> pane of the <ui>Project Designer</ui>; it contains a list of icons that have been added to a project either as resources or as content files.</para>
    <alert class="note">
      <para>After you set the icon property for an application, you might also set the <unmanagedCodeEntityReference>Icon</unmanagedCodeEntityReference> property of each <ui>Window</ui> or <ui>Form</ui> in the application. For information about window icons for Windows Presentation Foundation (WPF) standalone applications, see <codeEntityReference autoUpgrade="true" qualifyHint="false">P:System.Windows.Window.Icon</codeEntityReference> property.</para>
    </alert>
  </introduction>
  <procedure>
    <title>To specify an application icon</title>
    <steps class="ordered">
      <step>
        <content>
          <para>In <ui>Solution Explorer</ui>, choose a project node (not the <ui>Solution</ui> node).</para>
        </content>
      </step>
      <step>
        <content>
          <para>On the menu bar, choose <ui>Project</ui>, <ui>Properties</ui>.</para>
        </content>
      </step>
      <step>
        <content>
          <para>When the <ui>Project Designer</ui> appears, choose the <ui>Application</ui> tab.</para>
        </content>
      </step>
      <step>
        <content>
          <para>
            <embeddedLabel>(Visual Basic)</embeddedLabel> In the <ui>Icon</ui> list, choose an icon (.ico) file.</para>
          <para>
            <embeddedLabel>C#</embeddedLabel> Near the <ui>Icon</ui> list, choose the <ui>&lt;Browse...&gt;</ui> button, and then browse to the location of the icon file that you want.</para>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>
    <link xlink:href="8cec9fea-cd92-47ff-88dd-7c928f0b4a74">Application Page, Project Designer (Visual Basic)</link>
<link xlink:href="f13701a8-4e2e-4474-9d60-bb43decbe0c1">Application Page, Project Designer (C#)</link>

<legacyLink xlink:href="7b77bc06-3952-4799-b029-def3f8f7f88d">How to: Add or Remove Resources</legacyLink></relatedTopics>
</developerHowToDocument>
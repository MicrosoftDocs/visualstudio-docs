---
title: "MSBuild Tasks"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 5d3cc4a7-e5db-4f73-b707-8b6882fddcf8
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
# MSBuild Tasks
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>A build platform needs the ability to execute any number of actions during the build process. <token>vstecmsbuild</token> uses <placeholder>tasks</placeholder> to perform these actions. A task is a unit of executable code used by <token>vstecmsbuild</token> to perform atomic build operations.</para>
  </introduction>
  <section>
    <title>Task Logic</title>
    <content>
      <para>The <token>vstecmsbuild</token> XML project file format cannot fully execute build operations on its own, so task logic must be implemented outside of the project file.</para>
      <para>The execution logic of a task is implemented as a .NET class that implements the <codeEntityReference autoUpgrade="true">T:Microsoft.Build.Framework.ITask</codeEntityReference> interface, which is defined in the <codeEntityReference autoUpgrade="true">N:Microsoft.Build.Framework</codeEntityReference> namespace.</para>
      <para>The task class also defines the input and output parameters available to the task in the project file. All public settable non-static non-abstract properties exposed by the task class can be accessed in the project file by placing a corresponding attribute with the same name on the <legacyLink xlink:href="d82e2485-e5f0-4936-a357-745bacccc299">Task</legacyLink> element.</para>
      <para>You can write your own task by authoring a managed class that implements the <codeEntityReference autoUpgrade="true">T:Microsoft.Build.Framework.ITask</codeEntityReference> interface. For more information, see <link xlink:href="3ebc5f87-8f00-46fc-82a1-228f35a6823b">How To: Write a Task</link>.</para>
    </content>
  </section>
  <section>
    <title>Executing a Task from a Project File</title>
    <content>
      <para>Before executing a task in your project file, you must first map the type in the assembly that implements the task to the task name with the <legacyLink xlink:href="20247902-9446-4a1f-8253-5c7a17e4fe43">UsingTask</legacyLink> element. This lets <token>vstecmsbuild</token> know where to look for the execution logic of your task when it finds it in your project file.</para>
      <para>To execute a task in an <token>vstecmsbuild</token> project file, create an element with the name of the task as a child of a <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> element. If a task accepts parameters, these are passed as attributes of the element.</para>
      <para>
        <token>vstecmsbuild</token> item lists and properties can be used as parameters. For example, the following code calls the <unmanagedCodeEntityReference>MakeDir</unmanagedCodeEntityReference> task and sets the value of the <unmanagedCodeEntityReference>Directories</unmanagedCodeEntityReference> property of the <unmanagedCodeEntityReference>MakeDir</unmanagedCodeEntityReference> object equal to the value of the <codeInline>BuildDir</codeInline> property declared in the previous example.</para>
      <code>&lt;Target Name="MakeBuildDirectory"&gt;
    &lt;MakeDir
        Directories="$(BuildDir)" /&gt;
&lt;/Target&gt;</code>
      <para>Tasks can also return information to the project file, which can be stored in items or properties for later use. For example, the following code calls the <unmanagedCodeEntityReference>Copy</unmanagedCodeEntityReference> task and stores the information from the <codeInline>CopiedFiles</codeInline> output property in the <codeInline>SuccessfullyCopiedFiles</codeInline> item list.</para>
      <code>&lt;Target Name="CopyFiles"&gt;
    &lt;Copy
        SourceFiles="@(MySourceFiles)"
        DestinationFolder="@(MyDestFolder)"&gt;
        &lt;Output
            TaskParameter="CopiedFiles"
            ItemName="SuccessfullyCopiedFiles"/&gt;
     &lt;/Copy&gt;
&lt;/Target&gt;</code>
    </content>
  </section>
  <section>
    <title>Included Tasks</title>
    <content>
      <para>
        <token>vstecmsbuild</token> ships with many tasks such as <legacyLink xlink:href="a46ba9da-3e4e-4890-b4ea-09a099b6bc40">Copy</legacyLink>, which copies files, <legacyLink xlink:href="bc951577-1bfb-4100-b1f1-bc8278c45bf7">MakeDir</legacyLink>, which creates directories, and <legacyLink xlink:href="d8c19b36-f5ca-484b-afa6-8ff3b90e103a">Csc</legacyLink>, which compiles <token>csprcs</token> source code files. For a complete list of available tasks and usage information, see <link xlink:href="b3144b27-a426-4259-b8ae-5f7991b202b6">MSBuild Task Reference</link>.</para>
    </content>
  </section>
  <section>
    <title>Overridden Tasks</title>
    <content>
      <para>
        <token>Vstecmsbuild</token> looks for tasks in several locations. The first location is in files with the extension .OverrideTasks stored in the .NET Framework directories. Tasks in these files override any other tasks with the same names, including tasks in the project file. The second location is in files with the extension .Tasks in the .NET Framework directories. If the task is not found in either of these locations, the task in the project file is used.</para>
    </content>
  </section>
  <relatedTopics>
<link xlink:href="083b8ba3-e4ad-45af-bb5d-3bc81d406131">MSBuild Concepts</link>

<link xlink:href="3ebc5f87-8f00-46fc-82a1-228f35a6823b">How To: Write a Task</link>
<link xlink:href="e72e6506-4a11-4edf-ae8d-cfb5a3b9d8a0">Inline Tasks</link>
</relatedTopics>
</developerConceptualDocument>
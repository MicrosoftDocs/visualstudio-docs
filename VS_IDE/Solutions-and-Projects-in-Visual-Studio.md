---
title: "Solutions and Projects in Visual Studio"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: aeaf56cb-c2dd-47f6-b012-23b84b7a7254
caps.latest.revision: 33
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Solutions and Projects in Visual Studio
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://dduestorage.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>When you create an app, application, website, Web App, script, plug-in, etc in Visual Studio, you start with a <newTerm>project</newTerm>. In a logical sense, a project contains of all the source code files, icons, images, data files and anything else that will be compiled into an executable program or web site, or else is needed in order to perform the compilation.  A project also contains all the compiler settings and other configuration files that might be needed by various services or components that your program will communicate with.</para>
    <para>In a literal sense, a project is an XML file (*.vbproj, *.csproj, *.vcxproj) that defines a virtual folder hierarchy along with paths to all the items it "contains" and all the build settings. In Visual Studio, the project file is used by Solution Explorer to display the project contents and settings. When you compile your project, the MSBuild engine consumes the project file to create the executable. You can also customize projects to product other kinds of output.</para>
    <para>A project is contained, in a logical sense and in the file system, within a <newTerm>solution</newTerm>, which may contain one or more projects, along with build information, Visual Studio window settings, and any miscellaneous files that aren't associated with any project. In a literal sense, the solution is a text file with its own unique format; it is generally not intended to be edited by hand. </para>
    <para>A solution has an associated *.suo file that stores settings, preferences and configuration information for each user that has worked on the project.</para>
    <para>The following diagram shows the relationship between projects and solutions, and the items they logically contain.</para>
    <mediaLink>
      <image xlink:href="1474a0a2-70f5-4555-9b5c-7ed98f0b36a5" />
    </mediaLink>
    <para>You can also create custom project and item templates. For more information, see <link xlink:href="a6ce501a-699b-4e3e-ade8-c81895645c20">Creating Custom Project and ItemTemplates in Visual Studio</link>.</para>
  </introduction>
  <section>
    <title>Creating new projects</title>
    <content>
      <para>The easiest way to create a new project is to start with a pre-defined project template, which consists of a basic set of pre-generated code files, config files, assets, and settings that get you started creating a particular type of application or website in a particular programming language. These templates are what you see in the <ui>New Project Dialog</ui> when you choose <ui>File | New | Project</ui> or <ui>File | New | Web Site</ui> from the main menu, and then navigate. For more information, see <link xlink:href="836f8ca0-3fc9-4f4b-9090-45f2e4d2e9c8">Creating Solutions and Projects</link> and  <legacyLink xlink:href="7c36d86a-6b79-4480-8228-0f925f1204b2">NIB Creating Projects from Templates</legacyLink>.</para>
    </content>
  </section>
  <section>
    <title>Managing projects in Solution Explorer</title>
    <content>
      <para />
      <para>After you create a new project, you use <ui>Solution Explorer</ui> to view and manage projects and solutions and their associated items. The following illustration shows Server Explorer with a C# solution that contains two projects.</para>
      <mediaLink>
        <image xlink:href="4db7aa68-df28-4c99-836b-d1e53c190958" />
      </mediaLink>
    </content>
  </section>
  <section>
    <title>In This Section</title>
    <content>
      <list class="bullet">
        <listItem>
          <para>
            <link xlink:href="836f8ca0-3fc9-4f4b-9090-45f2e4d2e9c8">Creating Solutions and Projects</link>
          </para>
        </listItem>
        <listItem>
          <para>
            <link xlink:href="4b6db52f-4352-4313-8f4f-50a451fd12f7">Adding and Removing Project Items</link>
          </para>
        </listItem>
        <listItem>
          <para>
            <link xlink:href="d727efc0-1096-4ede-84b6-31a65da22ac0">Managing Project and Solution Properties</link>
          </para>
        </listItem>
        <listItem>
          <para>
            <link xlink:href="05d1c51b-44f3-4973-8a11-6c919b08ad62">Managing Project References</link>
          </para>
        </listItem>
        <listItem>
          <para> Application Properties</para>
        </listItem>
        <listItem>
          <para>
            <link xlink:href="6c1ef36b-25f7-4ad0-b29a-51801b7a5420">Managing Assembly and Manifest Signing</link>
          </para>
        </listItem>
        <listItem>
          <para>
            <link xlink:href="ad8e14ed-adc2-45b6-a0be-818b16d5616f">How to: Specify an Application Icon (Visual Basic, C#)</link>
          </para>
        </listItem>
        <listItem>
          <para>
            <link xlink:href="91e77ad4-4da3-419d-85fb-9036f0e5c330">Targeting a Specific .NET Framework Version or Profile</link>
          </para>
        </listItem>
        <listItem>
          <para>
            <link xlink:href="a6ce501a-699b-4e3e-ade8-c81895645c20">Creating Custom Project and ItemTemplates in Visual Studio</link>
          </para>
        </listItem>
      </list>
      <para />
    </content>
  </section>
  <relatedTopics>
<link xlink:href="772b6cf4-cee5-42d0-bc18-b4eb07e22ff0">Visual Studio IDE</link></relatedTopics>
</developerConceptualDocument>
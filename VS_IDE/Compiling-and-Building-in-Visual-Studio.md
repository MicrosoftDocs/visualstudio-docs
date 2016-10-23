---
title: "Compiling and Building in Visual Studio"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: c7958821-285f-4e28-9e7a-b5d8b40336a1
caps.latest.revision: 25
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
# Compiling and Building in Visual Studio
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>You can use Visual Studio to build applications and to create assemblies and executable programs at frequent intervals during a development cycle. By building your code often, you can identify compile-time errors, such as incorrect syntax, misspelled keywords, and type mismatches, earlier. You can also detect and correct run-time errors, such as logic errors and semantic errors, by frequently building and running debug versions of the code.</para>
    <para>When you have fully developed and sufficiently debugged a project or solution, you can compile its components in a Release build. By default, a Release build is optimized and designed to be smaller and run faster than a debug version. For more information, see <link xlink:href="4842955d-8959-4e4e-98b8-2358360179b3">Walkthrough: Building an Application</link>.</para>
  </introduction>
  <section>
    <title>Choosing a Build Method</title>
    <content>
      <para />
      <para>You can build an application by using the default build options in the IDE, at a command prompt, or by using Team Foundation Build. Each of these options use MSBuild as the underlying technology, and each approach has specific benefits, as the following table shows.</para>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Build Method</para>
            </TD>
            <TD>
              <para>Benefits</para>
            </TD>
            <TD>
              <para>For more information</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>Using the IDE</para>
            </TD>
            <TD>
              <list class="bullet">
                <listItem>
                  <para>You can more easily create and run builds immediately.</para>
                </listItem>
                <listItem>
                  <para>You can run multi-processor builds for C++ and C# projects.</para>
                </listItem>
                <listItem>
                  <para>You can customize some aspects of the build system.</para>
                </listItem>
              </list>
            </TD>
            <TD>
              <para>
                <link xlink:href="710891fd-379e-42c2-a84b-44a7af694ca0">How to: Prepare and Manage Builds</link>
              </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Running an MSBuild command line</para>
            </TD>
            <TD>
              <list class="bullet">
                <listItem>
                  <para>You can build projects without installing Visual Studio.</para>
                </listItem>
                <listItem>
                  <para>You can run multi-processor builds for all project types.</para>
                </listItem>
                <listItem>
                  <para>You can customize most areas of the build system.</para>
                </listItem>
              </list>
              <para />
            </TD>
            <TD>
              <para>
                <link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
              </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Using Team Foundation Build</para>
            </TD>
            <TD>
              <list class="bullet">
                <listItem>
                  <para>You can automate your build process. For example, you can build one or more projects nightly or every time that code is checked in. You can also build projects on shared build servers rather than on your development computer. </para>
                </listItem>
                <listItem>
                  <para>You can quickly specify the code that you want to build, the tests that you want to run, and other common options.</para>
                </listItem>
                <listItem>
                  <para>You can modify the build workflow, and as needed, create build activities to perform deeply customized tasks.</para>
                </listItem>
              </list>
            </TD>
            <TD>
              <para>
                <legacyLink xlink:href="a971b0f9-7c28-479d-a37b-8fd7e27ef692">Build the application</legacyLink>
              </para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
  </section>
  <section>
    <title>Building from the IDE</title>
    <content>
      <para>When you create a project, default build configurations are defined for it, and a solution build configuration is assigned to it to provide context for builds. Solution configurations define how the projects in solution are built and deployed. Project configurations are a set of project properties that are unique for a platform and build type (for example, Release Win32). You can edit these default configurations, and you can create your own configurations. For more information, see <legacyLink xlink:href="898dd854-c98d-430c-ba1b-a913ce3c73d7">Introduction to the Project Designer</legacyLink> and <legacyLink xlink:href="e7184bc5-2f2b-4b4f-aa9a-3ecfcbc48b67">NIB How to: Modify Project Properties and Configuration Settings</legacyLink>.</para>
      <para>From within the IDE, you can perform the following additional tasks:</para>
      <list class="bullet">
        <listItem>
          <para>
            <legacyLink xlink:href="a8333c89-afb2-4b1d-b2e2-9146da852402">Change the build output directory</legacyLink>.</para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="e2a0a8ff-dae7-40a8-b774-b88aa5235183">Identify projects that are dependent on the output from another project in order to build correctly</legacyLink>.</para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="75d38b76-26d6-4f43-bbe7-cbacd7cc81e7">Change the amount of information included in the build log or Output window for builds</legacyLink>.</para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="31827b17-f933-413d-b28a-b19f903b64ca">Hide specific compiler warnings for Visual C#, Visual C++, or Visual Basic</legacyLink>.</para>
        </listItem>
        <listItem>
          <para>
            <legacyLink xlink:href="69e935a5-e208-4bcd-865c-3e5f9b047ca8">Specify custom pre-compile and post-compile actions for a build</legacyLink>.</para>
        </listItem>
        <listItem>
          <para>Improve build performance by using parallel builds. For more information, see <link xlink:href="c8c9aadc-33ad-4aa1-b07d-b879e9eabda0">Building Multiple Projects in Parallel</link> or the blog post <externalLink><linkText>Tuning C++ build parallelism</linkText><linkUri>http://blogs.msdn.com/b/msbuild/archive/2010/03/08/tuning-c-build-parallelism-in-vs2010.aspx</linkUri></externalLink>.</para>
        </listItem>
      </list>
    </content>
  </section>
  <relatedTopics>
    <link xlink:href="4842955d-8959-4e4e-98b8-2358360179b3">Walkthrough: Building an Application</link>
<link xlink:href="934c727d-3a22-429c-bd13-3552cecf2e24">Understanding Build Configurations</link>
<link xlink:href="c1e5da1b-cda1-4545-b46c-0440fba27485">Understanding Build Platforms</link>
<link xlink:href="a9cbb88c-8fff-4c67-848b-98fbfd823193">Building (Compiling) Web Site Projects</link>
<link xlink:href="e2a0a8ff-dae7-40a8-b774-b88aa5235183">How to: Create and Remove Project Dependencies</link></relatedTopics>
</developerConceptualDocument>
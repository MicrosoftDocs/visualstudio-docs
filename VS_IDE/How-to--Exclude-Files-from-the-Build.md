---
title: "How to: Exclude Files from the Build"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1be36e45-01da-451c-972d-f9fc0e7d663c
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
# How to: Exclude Files from the Build
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>In a project file you can use wildcards to include all the files in one directory or a nested set of directories as inputs for a build. However, there might be one file in the directory or one directory in a nested set of directories that you do not want to include as input for a build. You can explicitly exclude that file or directory from the list of inputs. There may also be a file in a project that you only want to include under certain conditions. You can explicitly declare the conditions under which a file is included in a build.</para>
  </introduction>
  <section>
    <title>Excluding a File or Directory from the Inputs for a Build</title>
    <content>
      <para>Item lists are the input files for a build. The items that you want to include are declared either separately or as a group using the <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference> attribute. For example: </para>
      <code>&lt;CSFile Include="Form1.cs"/&gt;
&lt;CSFile Include ="File1.cs;File2.cs"/&gt;
&lt;CSFile Include="*.cs"/&gt;
&lt;JPGFile Include="Images\**\*.jpg"/&gt;</code>
      <para>If you have used wildcards to include all the files in one directory or a nested set of directories as inputs for a build, there might be one or more files in the directory or one directory in the a nested set of directories that you do not want to include. To exclude an item from the item list, use the <unmanagedCodeEntityReference>Exclude</unmanagedCodeEntityReference> attribute.</para>
      <procedure>
        <title>To include all .cs or .vb files except Form2</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use one of the following <codeInline>Include</codeInline> and <codeInline>Exclude</codeInline> attributes:</para>
              <code>&lt;CSFile Include="*.cs" Exclude="Form2.cs"/&gt;</code>
              <para>- or -</para>
              <code>&lt;VBFile Include="*.vb" Exclude="Form2.vb"/&gt;</code>
            </content>
          </step>
        </steps>
      </procedure>
      <procedure>
        <title>To include all .cs or .vb files except Form2 and Form3</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use one of the following <codeInline>Include</codeInline> and <codeInline>Exclude</codeInline> attributes:</para>
              <code>&lt;CSFile Include="*.cs" Exclude="Form2.cs;Form3.cs"/&gt;</code>
              <para>- or -</para>
              <code>&lt;VBFile Include="*.vb" Exclude="Form2.vb;Form3.vb"/&gt;</code>
            </content>
          </step>
        </steps>
      </procedure>
      <procedure>
        <title>To include all .jpg files in subdirectories of the Images directory except those in the Version2 directory</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use the following <codeInline>Include</codeInline> and <codeInline>Exclude</codeInline> attributes:</para>
              <code>&lt;JPGFile
    Include="Images\**\*.jpg"
    Exclude = "Images\**\Version2\*.jpg"/&gt;</code>
              <alert class="note">
                <para>You must specify the path for both attributes. If you use an absolute path to specify file locations in the <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference> attribute, you must also use an absolute path in the <unmanagedCodeEntityReference>Exclude</unmanagedCodeEntityReference> attribute; if you use a relative path in the <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference> attribute, you must also use a relative path in the <unmanagedCodeEntityReference>Exclude</unmanagedCodeEntityReference> attribute.</para>
              </alert>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <section>
    <title>Using Conditions to Exclude a File or Directory from the Inputs for a Build</title>
    <content>
      <para>If there are items that you want to include, for example, in a Debug build but not a Release build, you can use the <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference> attribute to specify the conditions under which to include the item.</para>
      <procedure>
        <title>To include the file Formula.vb only in Release builds</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use a <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference> attribute similar to the following:</para>
              <code>&lt;Compile
    Include="Formula.vb"
    Condition=" '$(Configuration)' == 'Release' " /&gt;</code>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <codeExample>
    <description>
      <content>
        <para>The following code example builds a project with all of the .cs files in the directory except Form2.cs.</para>
      </content>
    </description>
    <code>&lt;Project DefaultTargets="Compile"
    xmlns="http://schemas.microsoft.com/developer/msbuild/2003" &gt;

    &lt;PropertyGroup&gt;
        &lt;builtdir&gt;built&lt;/builtdir&gt;
    &lt;/PropertyGroup&gt;

    &lt;ItemGroup&gt;
        &lt;CSFile Include="*.cs Exclude="Form2.cs"/&gt;

        &lt;Reference Include="System.dll"/&gt;
        &lt;Reference Include="System.Data.dll"/&gt;
        &lt;Reference Include="System.Drawing.dll"/&gt;
        &lt;Reference Include="System.Windows.Forms.dll"/&gt;
        &lt;Reference Include="System.XML.dll"/&gt;
    &lt;/ItemGroup&gt;

    &lt;Target Name="PreBuild"&gt;
        &lt;Exec Command="if not exist $(builtdir) md $(builtdir)"/&gt;
    &lt;/Target&gt;

    &lt;Target Name="Compile" DependsOnTargets="PreBuild"&gt;
        &lt;Csc Sources="@(CSFile)"
            References="@(Reference)"
            OutputAssembly="$(builtdir)\$(MSBuildProjectName).exe"
            TargetType="exe" /&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>
<link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>

<link xlink:href="f5ff182f-7b3a-46fb-9335-37df54cfb8eb">How To: Build All Files in a Directory</link>
</relatedTopics>
</developerHowToDocument>
---
title: "MSBuild Reserved and Well-Known Properties"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
H1: MSBuild Reserved and Well-Known Properties
ms.assetid: 99333e61-83c9-4804-84e3-eda297c2478d
caps.latest.revision: 27
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
# MSBuild Reserved and Well-Known Properties
<?xml version="1.0" encoding="utf-8"?>
<developerReferenceWithoutSyntaxDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://dduestorage.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <token>vstecmsbuild</token> provides a set of predefined properties that store information about the project file and the <token>vstecmsbuild</token> binaries. These properties are evaluated in the same manner as other <token>vstecmsbuild</token> properties. For example, to use the <unmanagedCodeEntityReference>MSBuildProjectFile</unmanagedCodeEntityReference> property, you type <codeInline>$(MSBuildProjectFile)</codeInline>.</para>
    <para>MSBuild uses the values in the following table to predefine reserved and well-known properties. Reserved properties cannot be overridden, but well-known properties can be overridden by using identically named environment properties, global properties, or properties that are declared in the project file.</para>
  </introduction>
  <section>
    <title>Reserved and Well-Known Properties</title>
    <content>
      <para>The following table describes the <token>vstecmsbuild</token> predefined properties.</para>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Property</para>
            </TD>
            <TD>
              <para>Description</para>
            </TD>
            <TD>
              <para>Reserved or Well-Known</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildBinPath</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The absolute path of the folder where the <token>vstecmsbuild</token> binaries that are currently being used are located (for example, C:\Windows\Microsoft.Net\Framework\<placeholder>versionNumber</placeholder>). This property is useful if you have to refer to files in the <token>vstecmsbuild</token> directory.</para>
              <para>Do not include the final backslash on this property.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildExtensionsPath</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Introduced in the .NET Framework 4: there is no difference between the default values of <unmanagedCodeEntityReference>MSBuildExtensionsPath</unmanagedCodeEntityReference> and <unmanagedCodeEntityReference>MSBuildExtensionsPath32</unmanagedCodeEntityReference>. You can set the environment variable <unmanagedCodeEntityReference>MSBUILDLEGACYEXTENSIONSPATH</unmanagedCodeEntityReference> to a non-null value to enable the behavior of the default value of <unmanagedCodeEntityReference>MSBuildExtensionsPath</unmanagedCodeEntityReference> in earlier versions.</para>
              <para>In the .NET Framework 3.5 and earlier, the default value of <unmanagedCodeEntityReference>MSBuildExtensionsPath</unmanagedCodeEntityReference> points to the path of the MSBuild subfolder under the \Program Files\ or \Program Files (x86) folder, depending on the bitness of the current process. For example, for a 32-bit process on a 64-bit machine, this property points to the \Program Files (x86) folder. For a 64-bit process on a 64-bit machine, this property points to the \Program Files folder.</para>
              <para>Do not include the final backslash on this property.</para>
              <para>This location is a useful place to put custom target files. For example, your target files could be installed at \Program Files\MSBuild\MyFiles\Northwind.targets and then imported in project files by using this XML code:</para>
              <para>
                <codeInline>&lt;Import Project="$(MSBuildExtensionsPath)\MyFiles\Northwind.targets"/&gt;</codeInline>
              </para>
            </TD>
            <TD>
              <para>Well-Known</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildExtensionsPath32</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The path of the <token>vstecmsbuild</token> subfolder under the \Program Files or \Program Files (x86) folder. This path always points to the 32-bit \Program Files folder on a 32-bit machine and \Program Files (x86) on a 64-bit machine. See also <unmanagedCodeEntityReference>MSBuildExtensionsPath</unmanagedCodeEntityReference> and <unmanagedCodeEntityReference>MSBuildExtensionsPath64</unmanagedCodeEntityReference>.</para>
              <para>Do not include the final backslash on this property.</para>
            </TD>
            <TD>
              <para>Well-Known</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildExtensionsPath64</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The path of the <token>vstecmsbuild</token> subfolder under the \Program Files folder. For a 64-bit machine, this path always points to the \Program Files folder. For a 32-bit machine, this path is blank. See also <unmanagedCodeEntityReference>MSBuildExtensionsPath</unmanagedCodeEntityReference> and <unmanagedCodeEntityReference>MSBuildExtensionsPath32</unmanagedCodeEntityReference>.</para>
              <para>Do not include the final backslash on this property.</para>
            </TD>
            <TD>
              <para>Well-Known</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildLastTaskResult</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>
                <languageKeyword>true</languageKeyword> if the previous task completed without any errors (even if there were warnings), or <languageKeyword>false</languageKeyword> if the previous task had errors. Typically, when an error occurs in a task, the error is the last thing that happens in that project. Therefore, the value of this property is never <languageKeyword>false</languageKeyword>, except in these scenarios:</para>
         
           
                  <para> - When the <languageKeyword>ContinueOnError</languageKeyword> attribute of the <link xlink:href="d82e2485-e5f0-4936-a357-745bacccc299">Task Element (MSBuild)</link> is set to <languageKeyword>WarnAndContinue</languageKeyword> (or <languageKeyword>true</languageKeyword>) or <languageKeyword>ErrorAndContinue</languageKeyword>.</para>
           
                  <para> - When the <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> has an <link xlink:href="765767d3-ecb7-4cd9-ba1e-d9468964dddc">OnError Element (MSBuild)</link> as a child element.</para>
        
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildNodeCount</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The maximum number of concurrent processes that are used when building. This is the value that you specified for <system>/maxcpucount</system> on the command line. If you specified <system>/maxcpucount</system> without specifying a value, then <unmanagedCodeEntityReference>MSBuildNodeCount</unmanagedCodeEntityReference> specifies the number of processors in the computer. For more information, see <link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command-Line Reference</link> and <link xlink:href="c8c9aadc-33ad-4aa1-b07d-b879e9eabda0">Building Multiple Projects in Parallel with MSBuild</link>.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildProgramFiles32</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The location of the 32-bit program folder; for example, <codeInline>C:\Program Files (x86)</codeInline>.</para>
              <para>Do not include the final backslash on this property.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildProjectDefaultTargets</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The complete list of targets that are specified in the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute of the <unmanagedCodeEntityReference>Project</unmanagedCodeEntityReference> element. For example, the following <unmanagedCodeEntityReference>Project</unmanagedCodeEntityReference> element would have an <unmanagedCodeEntityReference>MSBuildDefaultTargets</unmanagedCodeEntityReference> property value of <codeInline>A;B;C</codeInline>:  </para>
              <para>
                <codeInline>&lt;Project DefaultTargets="A;B;C" &gt;</codeInline>
              </para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildProjectDirectory</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The absolute path of the directory where the project file is located, for example <codeInline>C:\MyCompany\MyProduct</codeInline>.</para>
              <para>Do not include the final backslash on this property.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildProjectDirectoryNoRoot</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The value of the <unmanagedCodeEntityReference>MSBuildProjectDirectory</unmanagedCodeEntityReference> property, excluding the root drive.</para>
              <para>Do not include the final backslash on this property.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildProjectExtension</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The file name extension of the project file, including the period; for example, .proj.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildProjectFile</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The complete file name of the project file, including the file name extension; for example, MyApp.proj.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildProjectFullPath</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The absolute path and complete file name of the project file, including the file name extension; for example, C:\MyCompany\MyProduct\MyApp.proj.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildProjectName</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The file name of the project file without the file name extension; for example, MyApp.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildStartupDirectory</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The absolute path of the folder where <token>vstecmsbuild</token> is called. By using this property, you can build everything below a specific point in a project tree without creating dirs.proj files in every directory. Instead, you have just one project—for example, c:\traversal.proj, as shown here:</para>
              <para><codeInline>&lt;Project ...&gt;
    &lt;ItemGroup&gt;
        &lt;ProjectFiles  
           Include="$
           (MSBuildStartupDirectory)
           **\*.csproj"/&gt;
    &lt;/ItemGroup&gt;
    &lt;Target Name="build"&gt;
        &lt;MSBuild    
        Projects="@(ProjectFiles)"/&gt;
    &lt;/Target&gt;
&lt;/Project&gt;</codeInline></para>
              <para>To build at any point in the tree, type:</para>
              <para><codeInline>msbuild c:\traversal.proj</codeInline></para>
              <para>Do not include the final backslash on this property.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildThisFile</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The file name and file extension portion of <unmanagedCodeEntityReference>MSBuildThisFileFullPath</unmanagedCodeEntityReference>.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildThisFileDirectory</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The directory portion of <unmanagedCodeEntityReference>MSBuildThisFileFullPath</unmanagedCodeEntityReference>.</para>
              <para>Include the final backslash in the path.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildThisFileDirectoryNoRoot</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The directory portion of <unmanagedCodeEntityReference>MSBuildThisFileFullPath</unmanagedCodeEntityReference>, excluding the root drive.</para>
              <para>Include the final backslash in the path.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildThisFileExtension</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The file name extension portion of <unmanagedCodeEntityReference>MSBuildThisFileFullPath</unmanagedCodeEntityReference>.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildThisFileFullPath</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The absolute path of the project or targets file that contains the target that is running.</para>
              <para>Tip: You can specify a relative path in a targets file that's relative to the targets file and not relative to the original project file.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildThisFileName</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The file name portion of <unmanagedCodeEntityReference>MSBuildThisFileFullPath</unmanagedCodeEntityReference>, without the file name extension.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildToolsPath</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The installation path of the <token>vstecmsbuild</token> version that's associated with the value of <unmanagedCodeEntityReference>MSBuildToolsVersion</unmanagedCodeEntityReference>.</para>
              <para>Do not include the final backslash in the path.</para>
              <para>This property cannot be overridden.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>MSBuildToolsVersion</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>The version of the <token>vstecmsbuild</token> Toolset that is used to build the project.</para>
              <para>Note: An <token>vstecmsbuild</token> Toolset consists of tasks, targets, and tools that are used to build an application. The tools include compilers such as csc.exe and vbc.exe. For more information, see <link xlink:href="40040ee7-4620-4043-a6d8-ccba921421d1">MSBuild Toolset (ToolsVersion)</link>, and <link xlink:href="15a048c8-5ad3-448e-b6e9-e3c5d7147ed2">Standard and Custom Toolset Configurations</link>.</para>
            </TD>
            <TD>
              <para>Reserved</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
  </section>
  <relatedTopics>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>

</relatedTopics>
</developerReferenceWithoutSyntaxDocument>

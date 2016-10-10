---
title: "Application Page, Project Designer (C#)"
ms.custom: na
ms.date: 10/08/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f13701a8-4e2e-4474-9d60-bb43decbe0c1
caps.latest.revision: 53
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
# Application Page, Project Designer (C#)
<?xml version="1.0" encoding="utf-8"?>
<developerUIReferenceDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Use the <ui>Application</ui> page of the <ui>Project Designer</ui> to specify the project's application settings and properties.</para>
    <para>To access the <ui>Application</ui> page, choose a project node (not the <ui>Solution</ui> node) in <ui>Solution Explorer</ui>. Then choose <ui>Project</ui>, <ui>Properties</ui> on the menu bar. When the Project Designer appears, click the <ui>Application</ui> tab.</para>
    <para>
      <token>note_settings_general</token>
    </para>
  </introduction>
  <section>
    <title>General Application Settings</title>
    <content>
      <para>The following options enable you to configure general settings for the application.</para>
      <definitionTable>
        <definedTerm>
          <ui>Assembly name</ui>
        </definedTerm>
        <definition>
          <para>Specifies the name of the output file that will hold the assembly manifest. Changing this property will also change the <ui>Output Name</ui> property. You can also make this change from the command line by using <link xlink:href="70d91d01-7bd2-4aea-ba8b-4e9807e9caa5">/out (Set Output File Name) (C# Compiler Options)</link>. To access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.AssemblyName</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Default namespace</ui>
        </definedTerm>
        <definition>
          <para>Specifies the base namespace for files added to the project. </para>
          <para>See <link xlink:href="0a788423-9110-42e0-97d9-bda41ca4870f">namespace (C# Reference)</link> for more information about creating namespaces in your code.</para>
          <para>To access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.RootNamespace</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Target Framework</ui>
        </definedTerm>
        <definition>
          <para>Specifies the version of the .NET Framework that the application targets. This option can have different values depending on which versions of the .NET Framework are installed on your computer.</para>
          <para>By default, the value is the same as the target framework that you selected in the <ui>New Project</ui> dialog box.</para>
          <alert class="note">
            <para>The prerequisite packages listed in the <link xlink:href="53ac863c-77a0-409b-91e5-7a4bd8b8474e">Prerequisites Dialog Box</link> are set automatically the first time that you open the dialog box. If you subsequently change the project's target framework, you will have to select the prerequisites manually to match the new target framework.</para>
          </alert>
          <para>For more information, see <link xlink:href="dea62d25-3d1b-492e-a6cc-b5154489800a">How To: Target a Specific .NET Framework</link> and <link xlink:href="b1702c33-0672-4ebc-b779-2b324d6ea880">.NET Framework Multi-Targeting Overview</link>.</para>
        </definition>
        <definedTerm>
          <ui>Application type</ui>
        </definedTerm>
        <definition>
          <para>Specifies the type of application to build. For <token>win8_appname_long</token> apps, you can specify <ui>Windows Store App</ui>, <ui>Class Library</ui>, or <ui>WinMD File</ui>. For most other application types, you can specify <ui>Windows Application</ui>, <ui>Console Application</ui>, <ui>Class Library</ui>, <ui>Windows Service</ui>, or <ui>Web Control Library</ui>.</para>
          <para>
            <?Comment ALB: Writer reminder: Validate that this is still true for RTM. 2011-12-16T13:20:00Z  Id='0?>For<?CommentEnd Id='0'
    ?> a web application project, you must specify <ui>Class Library</ui>.</para>
          <para>If you specify the <ui>WinMD File</ui> option, types can be projected into any <?Comment AT: Writer reminder: link to something 2012-06-18T16:22:00Z  Id='1?>Windows Runtime<?CommentEnd Id='1'
    ?> programming language. By packaging the project's output as a WinMD file, you can code an application in multiple languages and have code interoperate as if you wrote it all in the same language. You can specify this option for solutions that target the Windows Runtime libraries, including <token>win8_appname_long</token> apps. For more information, see <externalLink><linkText><?Comment ALB: Writer reminder: Link instead to Glenn Hackney's GUID topic when available. 2011-10-25T15:35:00Z  Id='2?>Crea<?CommentEnd Id='2'
    ?>ting Windows Runtime Components in C# and Visual Basic</linkText><linkUri>http://go.microsoft.com/fwlink/?LinkId=231895</linkUri></externalLink>.</para>
          <alert class="note">
            <para>The Windows Runtime can project types so that they appear as native objects in whichever language uses them. For example, JavaScript applications that interact with Windows Runtime use it as a set of JavaScript objects, and C# applications use the library as a collection of .NET objects. By packaging the project’s output as a WinMD file, you can take advantage of the same technology that Windows Runtime uses.</para>
          </alert>
          <para>For more information about the <ui>Application type</ui> property, see <link xlink:href="a18bbd8e-bbf7-49e7-992c-717d0eb1f76f">/target (C# Compiler Options)</link>. For information about how to access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.OutputType</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Assembly Information</ui>
        </definedTerm>
        <definition>
          <para>Clicking this button displays the <link xlink:href="8f1f6449-e03d-4a5b-9076-d3b1f84ada48">Assembly Information Dialog Box</link>.</para>
        </definition>
        <definedTerm>
          <ui>Startup object</ui>
        </definedTerm>
        <definition>
          <para>Defines the entry point to be called when the application loads. Generally this is set either to the main form in your application or to the <codeInline>Main</codeInline> procedure that should run when the application starts. Because class libraries do not have an entry point, their only option for this property is <ui>(Not Set)</ui>.</para>
          <para>By default, in a WPF Browser Application project, this option is <ui>(Not set)</ui>. The other option is <placeholder>Projectname</placeholder>.App. In this kind of project, you have to set the startup URI to load a UI resource when the application starts. To do this, open the Application.xaml file in your project and set the <languageKeyword>StartupUri</languageKeyword> property to a .xaml file in your project, such as Window1.xaml. For a list of acceptable root elements, see <codeEntityReference autoUpgrade="true">P:System.Windows.Application.StartupUri</codeEntityReference>. You also have to define a <codeInline>public static void Main()</codeInline> method in a class in the project. This class will appear in the <ui>Startup object</ui> list as <placeholder>ProjectName.ClassName</placeholder>. You can then select the class as the startup object.</para>
          <para>See <link xlink:href="975cf4d5-36ac-4530-826c-4aad0c7f2049">/main (Specify Location of Main Method) (C# Compiler Options)</link> for more information. To access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.StartupObject</codeEntityReference>.</para>
        </definition>
      </definitionTable>
    </content>
  </section>
  <section>
    <title>Resources</title>
    <content>
      <para>The following options enable you to configure general settings for the application.</para>
      <definitionTable>
        <definedTerm>
          <ui>Icon and manifest</ui>
        </definedTerm>
        <definition>
          <para>By default, this radio button is selected and the <ui>Icon</ui> and <ui>Manifest</ui> options are enabled. This enables you to select your own icon, or to select different manifest generation options. Leave this radio button selected unless you are providing a resource file for the project.</para>
        </definition>
        <definedTerm>
          <ui>Icon</ui>
        </definedTerm>
        <definition>
          <para>Sets the .ico file that you want to use as your program icon. Click the ellipsis button to browse for an existing graphic, or type the name of the file that you want. See <link xlink:href="756d9b6d-ab07-41b7-ba58-5bd88f711138">/win32icon (Import an .ico File)  (C# Compiler Options)</link> for more information. To access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.ApplicationIcon</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Manifest</ui>
        </definedTerm>
        <definition>
          <para>Selects a manifest generation option when the application runs on Windows Vista under User Account Control (UAC). This option can have the following values:</para>
          <list class="bullet">
            <listItem>
              <para>
                <ui>Embed manifest with default settings</ui>. Supports the typical manner in which Visual Studio operates on Windows Vista, which is to embed security information in the application's executable file, specifying that <languageKeyword>requestedExecutionLevel</languageKeyword> be <languageKeyword>AsInvoker</languageKeyword>. This is the default option.</para>
            </listItem>
            <listItem>
              <para>
                <ui>Create application without a manifest</ui>. This method is known as <newTerm>virtualization</newTerm>. Use this option for compatibility with earlier applications.</para>
            </listItem>
            <listItem>
              <para>
                <ui>Properties\app.manifest</ui>. This option is required for applications deployed by ClickOnce or Registration-Free COM. If you publish an application by using ClickOnce deployment, <ui>Manifest</ui> is automatically set to this option.</para>
            </listItem>
          </list>
        </definition>
        <definedTerm>
          <ui>Resource File</ui>
        </definedTerm>
        <definition>
          <para>Select this radio button when you are providing a resource file for the project. Selecting this option disables the <ui>Icon</ui> and <ui>Manifest</ui> options.</para>
          <para>Enter a path name or use the Browse button (<ui>...</ui>) to add a Win32 resource file to the project. </para>
        </definition>
      </definitionTable>
    </content>
  </section>
  <relatedTopics>
    <link xlink:href="0ad4926f-636e-41f8-a5b1-faf9d9b0a254">Managing Application Properties</link>
<link xlink:href="2d4d8fd0-e881-4829-976f-0d1a9221dec0">Writing Code in Office Solutions</link></relatedTopics>
</developerUIReferenceDocument>
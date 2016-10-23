---
title: "Application Page, Project Designer (Visual Basic)"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8cec9fea-cd92-47ff-88dd-7c928f0b4a74
caps.latest.revision: 61
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
# Application Page, Project Designer (Visual Basic)
<?xml version="1.0" encoding="utf-8"?>
<developerUIReferenceDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Use the <ui>Application</ui> page of the Project Designer to specify a project's application settings and properties.</para>
    <para>To access the <ui>Application</ui> page, choose a project node (not the <ui>Solution</ui> node) in <ui>Solution Explorer</ui>. Then choose <ui>Project</ui>, <ui>Properties</ui> on the menu bar. When the Project Designer appears, click the <ui>Application</ui> tab.</para>
    <para>
      <token>note_settings_general</token>
    </para>
  </introduction>
  <section>
    <title>General Application Settings</title>
    <content>
      <para>The following options enable you to configure general settings for an application.</para>
      <definitionTable>
        <definedTerm>
          <ui>Assembly name</ui>
        </definedTerm>
        <definition>
          <para>Specifies the name of the output file that will contain the assembly manifest. If you change this property, the <ui>Output Name</ui> property will also change. You can also make this change at a command prompt by using <link xlink:href="9f148c15-0909-4cb8-a2db-777f8a8b45ae">/out</link>. For information about how to access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.AssemblyName</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Root namespace</ui>
        </definedTerm>
        <definition>
          <para>Specifies the base namespace for all files in the project. For example, if you set the <ui>Root Namespace</ui> to <codeInline>Project1</codeInline> and you have a <codeInline>Class1</codeInline> outside of any namespace in your code, its namespace would be <codeInline>Project1.Class1</codeInline>. If you have a <codeInline>Class2</codeInline> in a namespace <codeInline>Order</codeInline> in code, its namespace would be <codeInline>Project1.Order.Class2</codeInline>.</para>
          <para>If you clear the <ui>Root Namespace</ui>, you can specify the namespace structure of your project in code.</para>
          <alert class="note">
            <para>If you use the Global keyword in a <link xlink:href="a31fbd95-9ace-4c3d-bbb1-51222a2272b2">Namespace Statement</link>, you can define a namespace out of the root namespace of your project. If you clear the <ui>Root Namespace</ui>, <languageKeyword>Global</languageKeyword> becomes the top-level namespace, which removes the need for the <languageKeyword>Global</languageKeyword> keyword in a <languageKeyword>Namespace</languageKeyword> statement. For more information, see "Global Keyword in Namespace Statements" in <link xlink:href="cffac744-ab8c-4f1f-ba50-732c22ab4b88">Namespaces in Visual Basic</link>.</para>
          </alert>
          <para>For information about how to create namespaces in your code, see <link xlink:href="a31fbd95-9ace-4c3d-bbb1-51222a2272b2">Namespace Statement</link>.</para>
          <para>For more information about the root namespace property, see <link xlink:href="e9245edf-6bef-420d-a7c7-324117752783">/rootnamespace</link>.</para>
          <para>For information about how to access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.RootNamespace</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Target framework (all configurations)</ui>
        </definedTerm>
        <definition>
          <para>Specifies the version of the .NET Framework that the application targets. This option can have different values depending on which versions of the .NET Framework are installed on your computer.</para>
          <para>The default value matches the target framework that you specified in the <ui>New Project</ui> dialog box.</para>
          <alert class="note">
            <para>The prerequisite packages that are listed in the <link xlink:href="53ac863c-77a0-409b-91e5-7a4bd8b8474e">Prerequisites Dialog Box</link> are set automatically when you open the dialog box for the first time. If you subsequently change the project's target framework, you must specify the prerequisites manually to match the new target framework.</para>
          </alert>
          <para>For more information, see <link xlink:href="dea62d25-3d1b-492e-a6cc-b5154489800a">How To: Target a Specific .NET Framework</link> and <link xlink:href="b1702c33-0672-4ebc-b779-2b324d6ea880">.NET Framework Multi-Targeting Overview</link>.</para>
        </definition>
        <definedTerm>
          <ui>Application type</ui>
        </definedTerm>
        <definition>
          <para>Specifies the type of application to build. For <token>win8_appname_long</token> apps, you can specify <ui>Windows Store App</ui>, <ui>Class Library</ui>, or <ui>WinMD File</ui>. For most other application types, you can specify <ui>Windows Application</ui>, <ui>Console Application</ui>, <ui>Class Library</ui>, <ui>Windows Service</ui>, or <ui>Web Control Library</ui>.</para>
          <para>For a web application project, you must specify <ui>Class Library</ui>.</para>
          <para>If you specify the <ui>WinMD File</ui> option, types can be projected into any Windows Runtime programming language. By packaging the project's output as a WinMD file, you can code an application in multiple languages and have code interoperate as if you wrote it all in the same language. You can use the <ui>WinMD File</ui> option for solutions that target the Windows Runtime libraries, including <token>win8_appname_long</token> apps. For more information, see <externalLink><linkText>Creating Windows Runtime Components in C# and Visual Basic</linkText><linkUri>http://go.microsoft.com/fwlink/?LinkId=231895</linkUri></externalLink>.</para>
          <alert class="note">
            <para>The Windows Runtime can project types so that they appear as native objects in whichever language uses them. For example, JavaScript applications that interact with Windows Runtime use it as a set of JavaScript objects, and C# applications use the library as a collection of .NET objects. By packaging the project’s output as a WinMD file, you can take advantage of the same technology that Windows Runtime uses.</para>
          </alert>
          <para>For more information about the <ui>Application type</ui> property, see <link xlink:href="e0954147-548b-461f-9c4b-a8f88845616c">/target (Visual Basic)</link>. For information about how to access that property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.OutputType</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Icon</ui>
        </definedTerm>
        <definition>
          <para>Sets the .ico file that you want to use as your program icon. Select <ui>&lt;Browse...&gt;</ui> to browse for an existing graphic. See <link xlink:href="aecaab01-9353-46c5-941c-6edabd4eff92">/win32icon</link> (or <link xlink:href="756d9b6d-ab07-41b7-ba58-5bd88f711138">/win32icon (Import an .ico File) (C# Compiler Options)</link>) for more information. To access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.ApplicationIcon</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Startup form / Startup object / Startup URI</ui>
        </definedTerm>
        <definition>
          <para>Specifies the application's startup form or entry point.</para>
          <para>If <ui>Enable application framework</ui> is selected (the default), this list is titled <ui>Startup form</ui> and shows only forms because the application framework supports only startup forms, not objects.</para>
          <para>If the project is a WPF Browser Application, this list is titled <ui>Startup URI</ui>, and the default is <ui>Page1.xaml</ui>. The <ui>Startup URI</ui> list enables you to specify the user interface resource (a XAML element) that the application displays when the application starts. For more information, see <codeEntityReference autoUpgrade="true">P:System.Windows.Application.StartupUri</codeEntityReference>.</para>
          <para>If <ui>Enable application framework</ui> is cleared, this list becomes <ui>Startup object</ui> and shows both forms and classes or modules with a <languageKeyword>Sub Main</languageKeyword>.</para>
          <para>
            <ui>Startup object</ui> defines the entry point to be called when the application loads. Generally this is set to either the main form in your application or to the <languageKeyword>Sub Main</languageKeyword> procedure that should run when the application starts. Because class libraries do not have an entry point, their only option for this property is <ui>(None)</ui>. For more information, see <link xlink:href="83fc339d-6652-415d-b205-b5133319b5b0">/main</link>. To access this property programmatically, see <codeEntityReference autoUpgrade="true">P:VSLangProj.ProjectProperties.StartupObject</codeEntityReference>.</para>
        </definition>
        <definedTerm>
          <ui>Assembly Information</ui>
        </definedTerm>
        <definition>
          <para>Click this button to display the <link xlink:href="8f1f6449-e03d-4a5b-9076-d3b1f84ada48">Assembly Information Dialog Box</link>.</para>
        </definition>
        <definedTerm>
          <ui>Enable application framework</ui>
        </definedTerm>
        <definition>
          <para>Specifies whether a project will use the application framework. The setting of this option affects the options available in <ui>Startup form</ui>/<ui>Startup object</ui>.</para>
          <para>If this check box is selected, your application uses the standard <languageKeyword>Sub Main</languageKeyword>. Selecting this check box enables the features in the <ui>Windows application framework properties</ui> section, and also requires you to select a startup form.</para>
          <para>If this check box is cleared, your application uses the custom <languageKeyword>Sub Main</languageKeyword> that you specified in <ui>Startup form</ui>. In this case you can specify either a startup object (a custom <languageKeyword>Sub Main</languageKeyword> in a method or a class) or a form. Also, the options in the <ui>Windows application framework properties</ui> section become unavailable.</para>
        </definition>
        <definedTerm>
          <ui>View Windows Settings</ui>
        </definedTerm>
        <definition>
          <para>Click this button to generate and open the app.manifest file. Visual Studio uses this file to generate manifest data for the application. Then set the UAC requested execution level by modifying the <languageKeyword>&lt;requestedExecutionLevel&gt;</languageKeyword> tag in app.manifest as follows:</para>
          <para>
            <codeInline>&lt;requestedExecutionLevel level="asInvoker" /&gt;</codeInline>
          </para>
          <para>ClickOnce works with a level of <codeInline>asInvoker</codeInline> or in virtualized mode (no manifest generation). To specify virtualized mode, remove the entire tag from app.manifest.</para>
          <para>For more information about manifest generation, see <link xlink:href="b21a0ebc-0ff6-4f49-8993-7d1ad3f8cac2">ClickOnce Deployment on Windows Vista</link>.</para>
        </definition>
      </definitionTable>
    </content>
  </section>
  <section>
    <title>Windows Application Framework Properties</title>
    <content>
      <para>The following settings are available in the <ui>Windows application framework properties</ui> section. These options are available only if the <ui>Enable application framework</ui> check box is selected. The section following this one describes <ui>Windows application framework properties</ui> settings for Windows Presentation Foundation (WPF) Applications.</para>
      <definitionTable>
        <definedTerm>
          <ui>Enable XP visual styles</ui>
        </definedTerm>
        <definition>
          <para>Enables or disables the Windows XP visual styles, also known as <newTerm>Windows XP Themes</newTerm>. Windows XP visual styles enable, for example, controls with rounded corners and dynamic colors. The default is enabled. For more information about Windows XP visual styles, see <legacyLink xlink:href="BC7FAB94-FCE9-4BF1-A8AD-A5837C91C3C0">Windows XP Features and Windows Forms Controls</legacyLink> and <link xlink:href="0a038ade-31cf-4e56-9cfe-7a1e6b83b57f">How to: Enable Windows XP Visual Styles</link>.</para>
        </definition>
        <definedTerm>
          <ui>Make single instance application</ui>
        </definedTerm>
        <definition>
          <para>Select this check box to prevent users from running multiple instances of the application. The default setting for this check box is cleared. This setting allows multiple instances of the application to be run. </para>
        </definition>
        <definedTerm>
          <ui>Save My.Settings on Shutdown</ui>
        </definedTerm>
        <definition>
          <para>Select this check box to specify that the application's <languageKeyword>My.Settings</languageKeyword> settings are saved when users shut down their computers. The default setting is enabled. If this option is disabled, you can save application settings manually by calling <languageKeyword>My.Settings.Save</languageKeyword>.</para>
        </definition>
        <definedTerm>
          <ui>Authentication mode</ui>
        </definedTerm>
        <definition>
          <para>Select <ui>Windows</ui> (the default) to specify the use of Windows authentication to identify the currently logged-on user. You can retrieve this information at run time by using the <languageKeyword>My.User</languageKeyword> object. Select <ui>Application-defined</ui> if you will provide your own code to authenticate users instead of using the default Windows authentication methods. </para>
        </definition>
        <definedTerm>
          <ui>Shutdown mode</ui>
        </definedTerm>
        <definition>
          <para>Select <ui>When startup form closes</ui> (the default) to specify that the application exit when the form set as the startup form closes, even if other forms are open. Select <ui>When last form closes</ui> to specify that the application exit when the last form is closed or when <languageKeyword>My.Application.Exit</languageKeyword> or the <languageKeyword>End</languageKeyword> statement is called explicitly. </para>
          <para>Select <ui>On explicit shutdown</ui> to specify that the application exit when you explicitly call <languageKeyword>Shutdown</languageKeyword>.</para>
          <para>Select <ui>On last window close</ui> to specify that the application exit when the last window closes or when you explicitly call <languageKeyword>Shutdown</languageKeyword>. This is the default setting.</para>
          <para>Select <ui>On main window close</ui> to specify that the application exit when the main window closes or when you explicitly call <languageKeyword>Shutdown</languageKeyword>.</para>
        </definition>
        <definedTerm>
          <ui>Splash screen</ui>
        </definedTerm>
        <definition>
          <para>Select the form that you want to use as a splash screen. You must have previously created a splash screen by using a form or a template. The default is <ui>(None)</ui>.</para>
        </definition>
        <definedTerm>
          <ui>View Application Events</ui>
        </definedTerm>
        <definition>
          <para>Click this button to display an events code file in which you can write events for the application framework events <languageKeyword>Startup</languageKeyword>, <languageKeyword>Shutdown</languageKeyword>, <languageKeyword>UnhandledException</languageKeyword>, <languageKeyword>StartupNextInstance</languageKeyword> and <languageKeyword>NetworkAvailabilityChanged</languageKeyword>. You can also override certain application framework methods. For example, you can change the display behavior of the splash screen by overriding <languageKeyword>OnInitialize</languageKeyword>.</para>
        </definition>
      </definitionTable>
    </content>
    <sections>
      <section>
        <title>Windows Application Framework Properties for Windows Presentation Foundation (WPF) Applications</title>
        <content>
          <para>The following settings are available in the <ui>Windows application framework properties</ui> section when the project is a Windows Presentation Foundation application. These options are available only if the <ui>Enable application framework</ui> check box is selected. The options listed in this table are available only for WPF applications or WPF browser applications. They are not available for WPF User Control or Custom Control libraries.</para>
          <definitionTable>
            <definedTerm>
              <ui>Shutdown mode</ui>
            </definedTerm>
            <definition>
              <para>This property is applicable only to Windows Presentation Foundation applications.</para>
              <para>Select <ui>On explicit shutdown</ui> to specify that the application exit when you explicitly call <codeEntityReference autoUpgrade="true">M:System.Windows.Application.Shutdown</codeEntityReference>.</para>
              <para>Select <ui>On last window close</ui> to specify that the application exit when the last window closes or when you explicitly call <codeEntityReference autoUpgrade="true">M:System.Windows.Application.Shutdown</codeEntityReference>. This is the default setting.</para>
              <para>Select <ui>On main window close</ui> to specify that the application exit when the main window closes or when you explicitly call <codeEntityReference autoUpgrade="true">M:System.Windows.Application.Shutdown</codeEntityReference>.</para>
              <para>For more information about using this setting, see <codeEntityReference autoUpgrade="true">M:System.Windows.Application.Shutdown</codeEntityReference></para>
            </definition>
            <definedTerm>
              <ui>Edit XAML</ui>
            </definedTerm>
            <definition>
              <para>Click this button to open and modify the application definition file (Application.xaml) in the XAML editor. When you click this button, Application.xaml opens at the application definition node. You might have to edit this file to perform certain tasks, such as defining resources. If the application definition file does not exist, the Project Designer creates one.</para>
            </definition>
            <definedTerm>
              <ui>View Application Events</ui>
            </definedTerm>
            <definition>
              <para>Click this button to display the <languageKeyword>Application</languageKeyword> partial class file (Application.xaml.vb) in a code editor. If the file does not exist, the Project Designer creates one with the appropriate class name and namespace.</para>
              <para>The <codeEntityReference autoUpgrade="true">T:System.Windows.Application</codeEntityReference> object raises events when certain application state changes occur (for example, on application startup or shutdown). For a full list of the events that this class exposes, see <codeEntityReference autoUpgrade="true">T:System.Windows.Application</codeEntityReference>. These events are handled in the user code section of the <languageKeyword>Application</languageKeyword> partial class. </para>
            </definition>
          </definitionTable>
        </content>
      </section>
    </sections>
  </section>
  <relatedTopics>
    
<link xlink:href="2d4d8fd0-e881-4829-976f-0d1a9221dec0">Writing Code in Office Solutions</link></relatedTopics>
</developerUIReferenceDocument>
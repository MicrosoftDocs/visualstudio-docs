---
title: "Application Page, Project Designer (C#) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "cs.ProjectPropertiesApplicationWPF"
  - "cs.ProjectPropertiesApplication"
helpviewer_keywords:
  - "Project Designer, Application page"
  - "Application page in Project Designer"
ms.assetid: f13701a8-4e2e-4474-9d60-bb43decbe0c1
caps.latest.revision: 61
author: jillre
ms.author: jillfra
manager: jillfra
---
# Application Page, Project Designer (C#)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use the **Application** page of the **Project Designer** to specify the project's application settings and properties.

 To access the **Application** page, choose a project node (not the **Solution** node) in **Solution Explorer**. Then choose **Project**, **Properties** on the menu bar. When the Project Designer appears, click the **Application** tab.

 [!INCLUDE[note_settings_general](../../includes/note-settings-general-md.md)]

## General Application Settings
 The following options enable you to configure general settings for the application.

 **Assembly name**
 Specifies the name of the output file that will hold the assembly manifest. Changing this property will also change the **Output Name** property. You can also make this change from the command line by using [/out (C# Compiler Options)](https://msdn.microsoft.com/library/70d91d01-7bd2-4aea-ba8b-4e9807e9caa5). To access this property programmatically, see <xref:VSLangProj.ProjectProperties.AssemblyName%2A>.

 **Default namespace**
 Specifies the base namespace for files added to the project.

 See [namespace](https://msdn.microsoft.com/library/0a788423-9110-42e0-97d9-bda41ca4870f) for more information about creating namespaces in your code.

 To access this property programmatically, see <xref:VSLangProj.ProjectProperties.RootNamespace%2A>.

 **Target Framework**
 Specifies the version of the .NET Framework that the application targets. This option can have different values depending on which versions of the .NET Framework are installed on your computer.

 By default, the value is the same as the target framework that you selected in the **New Project** dialog box.

> [!NOTE]
> The prerequisite packages listed in the [Prerequisites Dialog Box](../../ide/reference/prerequisites-dialog-box.md) are set automatically the first time that you open the dialog box. If you subsequently change the project's target framework, you will have to select the prerequisites manually to match the new target framework.

 For more information, see [How to: Target a Version of the .NET Framework](../../ide/how-to-target-a-version-of-the-dotnet-framework.md) and [Visual Studio Multi-Targeting Overview](../../ide/visual-studio-multi-targeting-overview.md).

 **Application type**
 Specifies the type of application to build. For [!INCLUDE[win8_appname_long](../../includes/win8-appname-long-md.md)] apps, you can specify **Windows Store App**, **Class Library**, or **WinMD File**. For most other application types, you can specify **Windows Application**, **Console Application**, **Class Library**, **Windows Service**, or **Web Control Library**.

 For a web application project, you must specify **Class Library**.

 If you specify the **WinMD File** option, types can be projected into any Windows Runtime programming language. By packaging the project's output as a WinMD file, you can code an application in multiple languages and have code interoperate as if you wrote it all in the same language. You can specify this option for solutions that target the Windows Runtime libraries, including [!INCLUDE[win8_appname_long](../../includes/win8-appname-long-md.md)] apps. For more information, see [Creating Windows Runtime Components in C# and Visual Basic](https://go.microsoft.com/fwlink/?LinkId=231895).

> [!NOTE]
> The Windows Runtime can project types so that they appear as native objects in whichever language uses them. For example, JavaScript applications that interact with Windows Runtime use it as a set of JavaScript objects, and C# applications use the library as a collection of .NET objects. By packaging the project’s output as a WinMD file, you can take advantage of the same technology that Windows Runtime uses.

 For more information about the **Application type** property, see [/target (C# Compiler Options)](https://msdn.microsoft.com/library/a18bbd8e-bbf7-49e7-992c-717d0eb1f76f). For information about how to access this property programmatically, see <xref:VSLangProj.ProjectProperties.OutputType%2A>.

 **Assembly Information**
 Clicking this button displays the [Assembly Information Dialog Box](../../ide/reference/assembly-information-dialog-box.md).

 **Startup object**
 Defines the entry point to be called when the application loads. Generally this is set either to the main form in your application or to the `Main` procedure that should run when the application starts. Because class libraries do not have an entry point, their only option for this property is **(Not Set)**.

 By default, in a WPF Browser Application project, this option is **(Not set)**. The other option is *Projectname*.App. In this kind of project, you have to set the startup URI to load a UI resource when the application starts. To do this, open the Application.xaml file in your project and set the `StartupUri` property to a .xaml file in your project, such as Window1.xaml. For a list of acceptable root elements, see <xref:System.Windows.Application.StartupUri%2A>. You also have to define a `public static void Main()` method in a class in the project. This class will appear in the **Startup object** list as *ProjectName.ClassName*. You can then select the class as the startup object.

 See [/main (C# Compiler Options)](https://msdn.microsoft.com/library/975cf4d5-36ac-4530-826c-4aad0c7f2049) for more information. To access this property programmatically, see <xref:VSLangProj.ProjectProperties.StartupObject%2A>.

## Resources
 The following options enable you to configure general settings for the application.

 **Icon and manifest**
 By default, this radio button is selected and the **Icon** and **Manifest** options are enabled. This enables you to select your own icon, or to select different manifest generation options. Leave this radio button selected unless you are providing a resource file for the project.

 **Icon**
 Sets the .ico file that you want to use as your program icon. Click the ellipsis button to browse for an existing graphic, or type the name of the file that you want. See [/win32icon (C# Compiler Options)](https://msdn.microsoft.com/library/756d9b6d-ab07-41b7-ba58-5bd88f711138) for more information. To access this property programmatically, see <xref:VSLangProj.ProjectProperties.ApplicationIcon%2A>.

 **Manifest**
 Selects a manifest generation option when the application runs on Windows Vista under User Account Control (UAC). This option can have the following values:

- **Embed manifest with default settings**. Supports the typical manner in which Visual Studio operates on Windows Vista, which is to embed security information in the application's executable file, specifying that `requestedExecutionLevel` be `AsInvoker`. This is the default option.

- **Create application without a manifest**. This method is known as *virtualization*. Use this option for compatibility with earlier applications.

- **Properties\app.manifest**. This option is required for applications deployed by ClickOnce or Registration-Free COM. If you publish an application by using ClickOnce deployment, **Manifest** is automatically set to this option.

  **Resource File**
  Select this radio button when you are providing a resource file for the project. Selecting this option disables the **Icon** and **Manifest** options.

  Enter a path name or use the Browse button (**...**) to add a Win32 resource file to the project.

## See Also
[Managing Application Properties](../../ide/application-properties.md)
 [Writing Code in Office Solutions](https://msdn.microsoft.com/library/2d4d8fd0-e881-4829-976f-0d1a9221dec0)

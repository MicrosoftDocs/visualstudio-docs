---
title: Application page of VB project properties
description: Learn how to use the Application page of the Visual Basic Project Designer to specify the project's application settings and properties.
ms.date: 10/30/2018
ms.topic: reference
f1_keywords:
- vb.ProjectPropertiesApplicationWPF
- vb.ProjectPropertiesApplication
helpviewer_keywords:
- Project Designer, Application page
- Application page in Project Designer
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
monikerRange: 'vs-2019'
---
# Application Page, Project Designer (Visual Basic)

Use the **Application** page of the Project Designer to specify a project's application settings and properties.

To access the **Application** page, choose a project node (not the **Solution** node) in **Solution Explorer**. Then choose **Project** > **Properties** on the menu bar. When the **Project Designer** appears, select the **Application** tab.

[!INCLUDE[note_settings_general](../../data-tools/includes/note_settings_general_md.md)]

## General application settings

The following options enable you to configure general settings for an application.

### Assembly name

Specifies the name of the output file that will contain the assembly manifest. If you change this property, the **Output Name** property also changes.

You can also specify the name of the output file from a command prompt by using the [/out (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/out) compiler switch.

For information about how to access this property programmatically, see <xref:VSLangProj.ProjectProperties.AssemblyName%2A>.

### Root namespace

Specifies the base namespace for all files in the project. For example, if you set the **Root Namespace** to `Project1` and you have a `Class1` outside of any namespace in your code, its namespace would be `Project1.Class1`. If you have a `Class2` in a namespace `Order` in code, its namespace would be `Project1.Order.Class2`.

If you clear the **Root Namespace**, you can specify the namespace structure of your project in code.

> [!NOTE]
> If you use the `Global` keyword in a [Namespace Statement](/dotnet/visual-basic/language-reference/statements/namespace-statement), you can define a namespace out of the root namespace of your project. If you clear the **Root Namespace**, `Global` becomes the top-level namespace, which removes the need for the `Global` keyword in a `Namespace` statement. For more information, see "Global Keyword in Namespace Statements" in [Namespaces in Visual Basic](/dotnet/visual-basic/programming-guide/program-structure/namespaces).

For information about how to create namespaces in your code, see [Namespace Statement](/dotnet/visual-basic/language-reference/statements/namespace-statement).

For more information about the root namespace property, see [/rootnamespace](/dotnet/visual-basic/reference/command-line-compiler/rootnamespace).

For information about how to access this property programmatically, see <xref:VSLangProj.ProjectProperties.RootNamespace%2A>.

### Target framework (all configurations)

Specifies the version of .NET that the application targets. This option can have different values depending on which versions of .NET are installed on your computer.

For .NET Framework projects, the default value matches the target framework that you specified when you created the project.

> [!NOTE]
> The prerequisite packages that are listed in the [Prerequisites Dialog Box](../../ide/reference/prerequisites-dialog-box.md) are set automatically when you open the dialog box for the first time. If you subsequently change the project's target framework, you must specify the prerequisites manually to match the new target framework.

For more information, see [Framework targeting overview](../../ide/visual-studio-multi-targeting-overview.md).

### Application type

Specifies the type of application to build. The values are different depending on the project type. For example, for a **Windows Forms App** project, you can specify **Windows Forms Application**, **Class Library**, **Console Application**, **Windows Service**, or **Web Control Library**.

For a web application project, you must specify **Class Library**.

For more information about the **Application type** property, see [/target (Visual Basic)](/dotnet/visual-basic/reference/command-line-compiler/target). For information about how to access that property programmatically, see <xref:VSLangProj.ProjectProperties.OutputType%2A>.

### Auto-generate binding redirects

Binding redirects are added to your project if your app or its components reference more than one version of the same assembly. If you want to manually define binding redirects in the project file, deselect **Auto-generate binding redirects**.

For more information about redirection, see [Redirecting assembly versions](/dotnet/framework/configure-apps/redirect-assembly-versions).

### Startup form / Startup object / Startup URI

Specifies the application's startup form or entry point.

If **Enable application framework** is selected (the default), this list is titled **Startup form** and shows only forms because the application framework supports only startup forms, not objects.

If the project is a WPF Browser Application, this list is titled **Startup URI**, and the default is **Page1.xaml**. The **Startup URI** list enables you to specify the user interface resource (a XAML element) that the application displays when the application starts. For more information, see <xref:System.Windows.Application.StartupUri%2A>.

If **Enable application framework** is cleared, this list becomes **Startup object** and shows both forms and classes or modules with a `Sub Main`.

**Startup object** defines the entry point to be called when the application loads. Generally this is set to either the main form in your application or to the `Sub Main` procedure that should run when the application starts. Because class libraries do not have an entry point, their only option for this property is **(None)**. For more information, see [/main](/dotnet/visual-basic/reference/command-line-compiler/main). To access this property programmatically, see <xref:VSLangProj.ProjectProperties.StartupObject%2A>.

### Icon

Sets the .ico file that you want to use as your program icon. Select **\<Browse...>** to browse for an existing graphic. See [/win32icon](/dotnet/visual-basic/reference/command-line-compiler/win32icon) (or [/win32icon (C# Compiler Options)](/dotnet/csharp/language-reference/compiler-options/win32icon-compiler-option)) for more information. To access this property programmatically, see <xref:VSLangProj.ProjectProperties.ApplicationIcon%2A>.

### Assembly Information

Click this button to display the [Assembly Information Dialog Box](../../ide/reference/assembly-information-dialog-box.md).

### Enable application framework

Specifies whether a project will use the application framework. The setting of this option affects the options available in **Startup form**/**Startup object**.

If this check box is selected, your application uses the standard `Sub Main`. Selecting this check box enables the features in the **Windows application framework properties** section, and also requires you to select a startup form.

If this check box is cleared, your application uses the custom `Sub Main` that you specified in **Startup form**. In this case you can specify either a startup object (a custom `Sub Main` in a method or a class) or a form. Also, the options in the **Windows application framework properties** section become unavailable.

### View Windows Settings

Click this button to generate and open the *app.manifest* file. Visual Studio uses this file to generate manifest data for the application. Then set the UAC requested execution level by modifying the `<requestedExecutionLevel>` tag in *app.manifest* as follows:

`<requestedExecutionLevel level="asInvoker" />`

ClickOnce works with a level of `asInvoker` or in virtualized mode (no manifest generation). To specify virtualized mode, remove the entire tag from app.manifest.

## Windows application framework properties

The following settings are available in the **Windows application framework properties** section. These options are available only if the **Enable application framework** check box is selected.

> [!TIP]
> The section following this one describes **Windows application framework properties** settings specific to Windows Presentation Foundation (WPF) apps.

### Enable Windows visual styles

Enables or disables the Windows visual styles, also known as *Windows Themes*. Windows visual styles enable, for example, controls with rounded corners and dynamic colors. The default is enabled.

### Make single instance application

Select this check box to prevent users from running multiple instances of the application. The default setting for this check box is *cleared*, which allows multiple instances of the application to be run. For more information, see the <xref:Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase.StartupNextInstance> event.

### Save My.Settings on Shutdown

Select this check box to specify that the application's `My.Settings` settings are saved when users shut down their computers. The default setting is enabled. If this option is disabled, you can save application settings manually by calling `My.Settings.Save`.

### Authentication mode

Select **Windows** (the default) to specify the use of Windows authentication to identify the currently logged-on user. You can retrieve this information at run time by using the `My.User` object. Select **Application-defined** if you will provide your own code to authenticate users instead of using the default Windows authentication methods.

### Shutdown mode

Select **When startup form closes** (the default) to specify that the application exit when the form set as the startup form closes, even if other forms are open. Select **When last form closes** to specify that the application exit when the last form is closed or when `My.Application.Exit` or the `End` statement is called explicitly.

Select **On explicit shutdown** to specify that the application exit when you explicitly call `Shutdown`.

Select **On last window close** to specify that the application exit when the last window closes or when you explicitly call `Shutdown`. This is the default setting.

Select **On main window close** to specify that the application exit when the main window closes or when you explicitly call `Shutdown`.

### Splash screen

Select the form that you want to use as a splash screen. You must have previously created a splash screen by using a form or a template. The default is **(None)**.

### View Application Events

Click this button to display an events code file in which you can write events for the application framework events `Startup`, `Shutdown`, `UnhandledException`, `StartupNextInstance` and `NetworkAvailabilityChanged`. You can also override certain application framework methods. For example, you can change the display behavior of the splash screen by overriding `OnInitialize`.

## Windows application framework properties for Windows Presentation Foundation (WPF) apps

The following settings are available in the **Windows application framework properties** section when the project is a Windows Presentation Foundation (WPF) app. These options are available only if the **Enable application framework** check box is selected. The options listed in this table are available only for WPF or WPF browser applications. They are not available for WPF User Control or Custom Control libraries.

### Shutdown mode

This property is applicable only to Windows Presentation Foundation (WPF) applications.

Select **On explicit shutdown** to specify that the application exit when you explicitly call <xref:System.Windows.Application.Shutdown%2A>.

Select **On last window close** to specify that the application exit when the last window closes or when you explicitly call <xref:System.Windows.Application.Shutdown%2A>. This is the default setting.

Select **On main window close** to specify that the application exit when the main window closes or when you explicitly call <xref:System.Windows.Application.Shutdown%2A>.

For more information about using this setting, see <xref:System.Windows.Application.Shutdown%2A>

### Edit XAML

This button opens the application definition file (Application.xaml) in the XAML editor. When you click this button, *Application.xaml* opens at the application definition node. You might have to edit this file to perform certain tasks, such as defining resources. If the application definition file does not exist, the Project Designer creates one.

### View Application Events

This button opens the `Application` class file (*Application.xaml.vb*) in a code editor. If the file does not exist, the Project Designer creates one with the appropriate class name and namespace.

The <xref:System.Windows.Application> object raises events when certain application state changes occur (for example, on application startup or shutdown). For a full list of the events that this class exposes, see <xref:System.Windows.Application>. These events are handled in the user code section of the `Application` partial class.

---
title: "Customizing Windows Installer Packages | Microsoft Docs"
ms.date: "11/01/2012"
ms.topic: "conceptual"
helpviewer_keywords:
  - "packaging"
  - "packaging, overview"
ms.workload:
  - "multiple"
---
customizing-windows-installer-packages

# Customizing Windows Installer Packages

The deployment tools in Visual Studio let you control the user interface (UI) that a user sees during installation. You can customize the installation UI to present information to or gather information from the user.

You can also customize the installer package by using merge modules and custom actions. Merge modules can deliver shared components, and custom actions run code at the end of an installation to perform actions that cannot be handled during installation.

## Installation User Interface

The **User Interface Editor** is used to specify and customize the dialog boxes that appear. Each user interface dialog box represents a separate page in the **Setup Wizard** that is displayed during installation.

A number of predefined dialog boxes are available in the **User Interface Editor** to handle common scenarios such as introducing the purpose of the wizard (the **Welcome** dialog box), enabling the user to specify an installation directory (the **Installation Folder** dialog box), or showing the progress of an installation (the **Progress** dialog box). In addition, several custom dialog boxes enable you to present choices or gather information by using check boxes, option buttons, and text boxes.


> [!NOTE]
> <P>Visual Studio Setup and Deployment projects do not support custom dialog boxes or other user interface elements that you build yourself.</P>


Each user interface dialog box has properties that can be used to control its appearance. Custom dialog boxes include properties that can be evaluated during installation, using conditions to change the installation.

## Merge Modules

A merge module contains a component, such as a .dll, along with any related files, resources, registry entries, and setup logic. You cannot install merge modules directly. Instead, a module is merged into an installer to provide the application with the functionality of the component.

### Merge Module Recommendations

Merge modules can be difficult to service and update. Developers who include the merge module in their Setup project cannot deliver fixes to the merge module without interacting with its owner. Additionally, the owner of the merge cannot send updates directly to end-user computers.

As an alternative, consider providing your technology as a Windows Installer that can be chained into the setup. For more information, see [Application Deployment Prerequisites](application-deployment-prerequisites.md).

### Retargetable Merge Modules

By default, files in merge modules are installed into the folder locations specified by the module's owner. In some cases, you may want to allow the consumer of the merge module to decide where the files are installed. For example, if an assembly in a merge module is used by multiple applications, the consumer of the merge module can choose to install it in the global assembly cache; otherwise, the consumer can choose to install the assembly in the application directory.

To allow the consumer of a merge module to retarget a file to a different location, place the file in the **Module Retargetable** folder in the **File System Editor**. When the resulting merge module is added to another deployment project, the author of that project can choose a location by setting the **Module Retargetable Folder** property exposed by the merge module. The **Module Retargetable Folder** property is a dynamic property. It appears under the **(MergeModuleProperties)** node beneath the **KeyOutput** node in the **Properties** window when a merge module is selected in **Solution Explorer**.


> [!NOTE]
> <P>If you change the name of the <STRONG>Module Retargetable</STRONG> folder in the <STRONG>File System Editor</STRONG>, the name of the property is changed, as well. The property does not show up in the <STRONG>Properties</STRONG> window until the merge module is built.</P>


## Custom Actions

Custom actions run code, such as a .dll, .exe, or assembly, at the end of an installation to perform actions that cannot be handled during installation. For example, if you want to create a local database on the target computer during installation, create an executable file that creates and configures the database and then add that executable file as a custom action in your deployment project.

You can use the **Custom Actions Editor** in Visual Studio to add custom actions and to set their properties in a deployment project. A deployment project can contain multiple custom actions.

Custom actions are run after the installation is complete, so they do not have access to properties that are used to control the installation. If you need to pass information from the installer to a custom action, you can do so by setting the **CustomActionData** property.


> [!WARNING]
> <P>If a custom action fails, the entire installation is rolled back.</P>


In addition, you can place conditions on any custom action by using the **Condition** property. This allows you to run different custom actions based on conditions that exist on a target computer during installation. For example, you might want to run different custom actions depending on the operating system version on the target computer.

### Custom Action Recommendations

You can use custom actions to create a flexible installer package, but the broad variety of end-user computers and configurations may cause problems. You should develop custom actions that implement the [Install](https://msdn.microsoft.com/en-us/library/6a9x53dx), [Uninstall](https://msdn.microsoft.com/en-us/library/4th99k30), [Rollback](https://msdn.microsoft.com/en-us/library/xaa5h264), and [Commit](https://msdn.microsoft.com/en-us/library/5e7k0366) methods. In addition, ensure that the custom action can support the following scenarios: repair, mitigation, product upgrade, product downgrade, OS upgrade, OS downgrade, servicing/patching, and reference counting.

For more information about custom action guidelines, see Rule 25 in [Tao of the Windows Installer, Part 2](http://go.microsoft.com/fwlink/?linkid=168865).

## Conditional Deployment

One of the most valuable features in Visual Studio deployment is the ability to set conditions for installation, which allows you to customize how your application is installed. By using conditional deployment, you can install different files based on operating system version, or customize registry settings based on the value of an existing key, or even halt installation if a dependent application is not already installed on the target computer.

The deployment tools in Visual Studio support conditional deployment in two ways: through launch conditions and through the **Condition** property.

### Launch Conditions

Launch conditions are used to evaluate a condition on a target computer and to halt installation if the condition is not met. You can set launch conditions to check for the operating system version, existence of files, registry values, Window Installer components, the common language runtime, and Internet Information Services. Launch conditions are specified in the **Launch Conditions Editor**.

### Condition Property

The **Condition** property of a file, folder, registry entry, custom action, or launch condition is used to evaluate properties exposed by Windows Installer or set by other elements in the installer. Custom properties can be specified for launch conditions in the Launch Conditions Editor, for custom folders in the **File System Editor**, or for custom dialog boxes in the **User Interface Editor**. When specifying a custom property, the name must contain uppercase characters and the name must not conflict with any existing properties or Windows Installer property names.

Conditions can evaluate the **Property** property exposed by other elements in the installer (for example, the **Property** property for a file search), or it can evaluate properties exposed by Windows Installer (for example, operating system version).

## Boolean Operators for Conditions

Multiple properties can be evaluated using Boolean operators. For more information, see [Windows Installer Conditional Statement Syntax](https://msdn.microsoft.com/en-us/library/aa368012).

## See Also

#### Concepts

[Setup and Deployment Projects](setup-and-deployment-projects.md)

[Visual Studio Installer Deployment](visual-studio-installer-deployment.md)


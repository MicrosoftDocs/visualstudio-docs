---
title: "Localizing Windows Installer Packages | Microsoft Docs"
ms.date: "11/01/2012"
ms.topic: "conceptual"
helpviewer_keywords:
  - "packaging"
  - "packaging, overview"
ms.workload:
  - "multiple"
---

# Localizing Windows Installer Packages

The deployment tools in Visual Studio include several features that allow you to distribute multiple versions of your application for different locales. You will need to create a separate installer for each localized version of your application; it is not possible to create a single installer for multiple locales.


> [!TIP]
> <P>If the core files for your application are the same for all locales, consider putting the core files in a merge module and adding the merge module plus any locale-specific files to the installer for each locale. Registry settings, custom actions, and file types can be set in the merge module project so that you do not need to recreate them for each project.</P>


In order to create a localized installer, you set the **Localization** property of the deployment project to one of the supported languages (listed in the drop-down list in the **Properties** window). The **Localization** property setting determines the language for the default text displayed in the installation user interface dialogs during installation. You cannot see the translated text in the IDE; you can only see the translated text by building and running the installer.

Text that is provided by properties is not translated. For example, the **ProductName** property determines the name that is displayed in the title bar of the installation dialogs. You will need to enter the localized **ProductName** in the **Properties** window for each localized deployment project. Other deployment project properties that may need to be localized include the **Author**, **Description**, **Keywords**, **Manufacturer**, **ManufacturerUrl**, **Subject**, **SupportPhone**, **SupportUrl**, and **Title** properties. If the **AddRemoveProgramsIcon** property specifies an icon that contains text, you may want to specify a localized icon as well.


> [!NOTE]
> <P>Text for deployment properties must be entered using characters from the code page for the target locale or a build error will occur. The code pages supported for deployment are: 1252 (Neutral, English, French, German, Italian, and Spanish), 936 (Chinese (Simplified)), 950 (Chinese (Traditional)), 932 (Japanese), and 949 (Korean).</P>


Additional properties that may need to be localized include the **Name** and **Description** properties for shortcuts in the **File System Editor**, the **Name** and **Description** properties for file types and actions in the **File Types Editor**, and the **Message** property for conditions in the **Launch Conditions Editor**.


> [!NOTE]
> <P>For localized installers, the default text for the <STRONG>CopyrightWarning</STRONG> and <STRONG>WelcomeText</STRONG> properties will be displayed during installation in the language specified in the project's <STRONG>Localization</STRONG> property, not in the language displayed in the <STRONG>Properties</STRONG> window. If the <STRONG>CopyrightWarning</STRONG> or <STRONG>WelcomeText</STRONG> property has been changed, the text displayed in the <STRONG>Properties</STRONG> window will be displayed during installation; you must enter the text in the localized language.</P>

---
title: 'Walkthrough: Creating a Legacy Language Service | Microsoft Docs'
description: Learn how to use the managed package framework language classes to implement a language service in Visual C#.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- language services [managed package framework], creating
ms.assetid: 6a5dd2c2-261b-4efd-a3f4-8fb90b73dc82
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Walkthrough: Creating a Legacy Language Service
Using the managed package framework (MPF) language classes to implement a language service in [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] is straightforward. You need a VSPackage to host the language service, the language service itself, and a parser for your language.

## Prerequisites
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../../extensibility/visual-studio-sdk.md).

## Locations for the Visual Studio Package Project Template
 The Visual Studio Package Project Template can be found in three different template locations in the **New Project** dialog box:

1. Under Visual Basic Extensibility. The default language of the project is Visual Basic.

2. Under C# Extensibility. The default language of the project is C#.

3. Under Other Project Types Extensibility. The default language of the project is C++.

### Create a VSPackage

1. Create a new VSPackage with the Visual Studio Package project template.

    If you are adding a language service to an existing VSPackage, skip the following steps and go directly to the "Create the Language Service Class" procedure.

2. Enter MyLanguagePackage for the name of the project and click **OK**.

    You can use whatever name you want. These procedures detailed here assume MyLanguagePackage as the name.

3. Select [!INCLUDE[csprcs](../../data-tools/includes/csprcs_md.md)] as the language and the option to generate a new key file. Click **Next**.

4. Enter the appropriate company and package information. Click **Next**.

5. Select **Menu Command**. Click **Next**.

    If you do not intend to support code snippets, you can just click Finish and ignore the next step.

6. Enter **Insert Snippet** as the **Command Name** and `cmdidInsertSnippet` for the **Command ID**. Click **Finish**.

    The **Command Name** and **Command ID** can be whatever you want, these are just examples.

### Create the Language Service Class

1. In **Solution Explorer**, right-click on the MyLanguagePackage project, choose **Add**, **Reference**, and then choose the **Add New Reference** button.

2. In the **Add Reference** dialog box, select **Microsoft.VisualStudio.Package.LanguageService** in the **.NET** tab and click **OK**.

     This needs to be done only once for the language package project.

3. In **Solution Explorer**, right-click on the VSPackage project and select **Add**, **Class**.

4. Make sure **Class** is selected in the templates list.

5. Enter **MyLanguageService.cs** for the name of the class file and click **Add**.

     You can use whatever name you want. These procedures detailed here assume `MyLanguageService` as the name.

6. In the MyLanguageService.cs file, add the following `using` directives.

     :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/cs/mylanguageservice.cs" id="Snippet1":::
     :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/vb/mylanguageservice.vb" id="Snippet1":::

7. Modify the `MyLanguageService` class to derive from the <xref:Microsoft.VisualStudio.Package.LanguageService> class:

     :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/cs/mylanguageservice.cs" id="Snippet2":::
     :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/vb/mylanguageservice.vb" id="Snippet2":::

8. Position the cursor on "LanguageService" and from the **Edit**, **IntelliSense** menu, select **Implement Abstract Class**. This adds the minimum necessary methods to implement a language service class.

9. Implement the abstract methods as described in [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service2.md).

### Register the Language Service

1. Open the MyLanguagePackagePackage.cs file and add the following `using` directives:

     :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/vb/mylanguagepackagepackage.vb" id="Snippet3":::
     :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/cs/mylanguagepackagepackage.cs" id="Snippet3":::

2. Register your language service class as described in [Registering a Legacy Language Service](../../extensibility/internals/registering-a-legacy-language-service1.md). This includes the ProvideXX attributes and "Proffering the Language Service" sections. Use MyLanguageService where this topic uses TestLanguageService.

### The Parser and Scanner

1. Implement a parser and scanner for your language as described in [Legacy Language Service Parser and Scanner](../../extensibility/internals/legacy-language-service-parser-and-scanner.md).

     How you implement your parser and scanner is entirely up to you and is beyond the scope of this topic.

## Language Service Features
 To implement each feature in the language service, you typically derive a class from the appropriate MPF language service class, implement any abstract methods as necessary, and override the appropriate methods. What classes you create and/or derive from is dependent on the features you intend to support. These features are discussed in detail in [Legacy Language Service Features](../../extensibility/internals/legacy-language-service-features1.md). The following procedure is the general approach to deriving a class from the MPF classes.

#### Deriving From an MPF Class

1. In **Solution Explorer**, right-click on the VSPackage project and select **Add**, **Class**.

2. Make sure **Class** is selected in the templates list.

     Enter a suitable name for the class file and click **Add**.

3. In the new class file, add the following `using` directives.

     :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/cs/mysource.cs" id="Snippet4":::
     :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/vb/mysource.vb" id="Snippet4":::

4. Modify the class to derive from the desired MPF class.

5. Add a class constructor that takes at least the same parameters as the base class's constructor and pass the constructor parameters on to the base class constructor.

     For example, the constructor for a class derived from the <xref:Microsoft.VisualStudio.Package.Source> class might look like the following:

     :::code language="csharp" source="../../snippets/csharp/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/cs/mysource.cs" id="Snippet5":::
     :::code language="vb" source="../../snippets/visualbasic/VS_Snippets_VSSDK/creatingalanguageservice(managedpackageframework)/vb/mysource.vb" id="Snippet5":::

6. From the **Edit**, **IntelliSense** menu, select **Implement Abstract Class** if the base class has any abstract methods that must be implemented.

7. Otherwise, position the caret inside the class and enter the method to be overridden.

     For example, type `public override` to see a list of all methods that can be overridden in that class.

## See also
- [Implementing a Legacy Language Service](../../extensibility/internals/implementing-a-legacy-language-service1.md)

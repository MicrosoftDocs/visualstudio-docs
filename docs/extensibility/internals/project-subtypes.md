---
title: Project Subtypes
description: Learn how project subtypes let you customize behavior of the project systems of Visual Studio. VSPackages implement project subtypes using COM aggregation.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- projects [Visual Studio SDK], subtypes
- project subtypes [Visual Studio SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Project Subtypes

Project subtypes let you customize or flavor the behavior of the project systems of Visual Studio. Customizations include saving additional data in the project file, adding or filtering items in the **Add New Item** dialog box, controlling how assemblies are debugged and deployed, and extending the project **Property Pages** dialog box. VSPackages implement project subtypes using COM aggregation.

> [!NOTE]
> The Visual C++ project system does not support project subtypes. Visual Studio itself uses project subtypes to implement SQL Server and Smart Device projects.

## In This Section

- [Project Subtypes Design](../../extensibility/internals/project-subtypes-design.md)

  Describes the concept of project subtypes.

- [Initialization Sequence of Project Subtypes](../../extensibility/internals/initialization-sequence-of-project-subtypes.md)

  Describes the programmatic project subtype initialization sequence by Visual Studio environment.

- [Properties and Methods Extended by Project Subtypes](../../extensibility/internals/properties-and-methods-extended-by-project-subtypes.md)

  Provides detailed descriptions of the features and methods most frequently extended by using project subtypes.

- [Persisting Data in the MSBuild Project File](../../extensibility/internals/persisting-data-in-the-msbuild-project-file.md)

  Describes how to persist data in a project file and how to use <xref:Microsoft.VisualStudio.Shell.Interop.IPersistXMLFragment> to maintain the data in the project file across the project subtype aggregation levels.

- [Project Property User Interface](../../extensibility/internals/project-property-user-interface.md)

  Describes how project subtypes can modify the project **Property Pages** dialog box.

- [Extending the Object Model of the Base Project](../../extensibility/internals/extending-the-object-model-of-the-base-project.md)

  Provides information about how project subtypes can use Automation Extenders to extend the automation object model.

- [Contributing to the Add New Item Dialog Box](../../extensibility/internals/contributing-to-the-add-new-item-dialog-box.md)

  Describes how to add items to the **Add New Item** dialog box.

- [Saving Data in Project Files](../../extensibility/saving-data-in-project-files.md)

  Explains how a project subtype can save and retrieve subtype-specific data in the project file by using the Managed Package Framework (MPF).

- [Handling Specialized Deployment](../../extensibility/internals/handling-specialized-deployment.md)

  Explains how project subtypes can supply specialized deployment behavior by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsDeployableProjectCfg> interface.

- [Adding and Removing Property Pages](../../extensibility/adding-and-removing-property-pages.md)

  Describes adding and removing property pages in Project Designer.

## Related Sections

- [Project Types](../../extensibility/internals/project-types.md)

  Provides links to topics detailing Visual Studio projects.

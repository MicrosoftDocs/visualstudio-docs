---
title: "Sandboxed Solution Considerations"
description: Explore sandboxed solutions, which are a feature in Microsoft SharePoint that enables site collection users to upload their own custom code solutions.
ms.date: "02/02/2017"
ms.topic: article
f1_keywords:
  - "VS.SharePointTools.Project.SandboxedSolutions"
  - "VS.SharePointTools.Security.SandboxedSolutions"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, sandboxed solutions"
  - "sandboxed solutions [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, farm solutions"
  - "farm solutions [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Sandboxed solution considerations

  *Sandboxed solutions* are a feature in Microsoft SharePoint 2010 that enables site collection users to upload their own custom code solutions. A common sandboxed solution is users uploading their own Web Parts.

 A sandboxed SharePoint application runs in a secure, monitored process that has access to a limited part of the Web farm. Microsoft SharePoint 2010 uses a combination of features, solution galleries, solution monitoring, and a validation framework to enable sandboxed solutions.

## Specify project trust level
 Visual Studio supports sandboxed solutions through a Boolean project property called *Sandboxed Solution*. This property can be set at any time in the project, or it can be specified when you create the project in the **SharePoint Customization Wizard**.

> [!NOTE]
> Changing the *Sandboxed Solution* property of a project after it is created may cause validation errors.

 The solution is considered a farm-scoped solution if the *Sandboxed Solution* property is set to **false** or you choose the **Deploy as a farm solution** option. However, the solution is treated differently from a farm solution if the *Sandboxed Solution* property is set to **true** or you choose the **Deploy as a sandboxed solution** option in the wizard.

## SharePoint site hierarchy
 To understand how sandboxed solutions work, it helps to know that SharePoint sites are hierarchical in scope. The top element is known as the Web farm, and other elements are subordinate to it:

 Web Farm

 Web Application A

 Site Collection A1

 Site A1a

 Web Application B

 Site Collection B1

 Site B1a

 Site B1b

 Site Collection B2

 Site B2a

 As you can see, Web farms can contain one or more Web applications, which in turn can contain one or more site collections, which can have subsites, and so on. Changes made to one site collection affect only that site collection and no other. However, changes made at the Web farm level affect all site collections on the farm.

 Windows SharePoint Services (WSS) 3.0 allows you to deploy solutions only to the farm level, but  Microsoft SharePoint Foundation allows you to deploy to either the farm level (farm solution) or the site collection level (sandboxed solution).

## Why sandboxed solutions?
 In WSS 3.0, solutions could be deployed only to the farm level. This meant that potentially harmful or destabilizing solutions could be deployed that affected the whole Web farm and all of the other site collections and applications that run under it. However, by using sandboxed solutions, you can deploy your solutions to a subarea of the farm, a specific site collection. To provide additional protection, the solution's assembly is not loaded into the main  IIS  process (*w3wp.exe*). Instead, it is loaded into a separate process (*SPUCWorkerProcess.exe*). This process is monitored and implements quotas and throttling to protect the farm from sandboxed solutions that perform harmful activities, such as running tight loops that consume CPU cycles.

## Site collection solution gallery
 Windows SharePoint Services 2010 has a feature that's known as the "site collection solution gallery." You can access this feature from the SharePoint 2010 Central Administration page or by opening the **Site Actions** menu, choosing **Site Settings**, and then choosing the **Solutions** link under  **Galleries** in the SharePoint site. Solution galleries are repositories of solutions that enable site collection administrators to manage solutions in their site collections.

 The solution gallery is a document library stored in the root Web of the SharePoint site. The solution gallery replaces site templates and supports solution packages. When a SharePoint solution package (*.wsp*) file is uploaded, it is processed as a sandboxed solution.

## Sandboxed solution limitations
 When a sandboxed solution is deployed, the array of SharePoint functionality available to it is limited to help reduce any security vulnerabilities it may have. Some of these limitations include the following:

- Sandboxed solutions have a restricted subset of deployable solution elements available to them. Potentially vulnerable SharePoint project templates, such as site definitions and workflows, are not available.

- SharePoint runs sandboxed solution code in a process (*SPUCWorkerProcess.exe*) separate from the main  IIS  application pool (*w3wp.exe*) process.

- Mapped folders cannot be added to the project.

- Types in the  Microsoft SharePoint Server assembly Microsoft.Office.Server cannot be used in sandboxed solutions. Also, only types in the  Microsoft SharePoint Foundation assembly Microsoft.SharePoint can be used in sandboxed solutions.

  It is important to note that specifying a SharePoint solution as a sandboxed solution has no affect on SharePoint server; it only determines how the SharePoint project is deployed to SharePoint from Visual Studio and what assemblies it binds to. It does not affect the generated *.wsp* file, and the *.wsp* file has no data that directly correlates to the *Sandboxed Solution* property.

## Capabilities and elements in sandboxed solutions
 Sandboxed solutions support the following capabilities and elements:

- Content Types/Fields

- Custom actions

- Declarative workflows

- Event receivers

- Feature callouts

- List Definitions

- List Instances

- Module/files

- Navigation

- *Onet.xml*

- SPItemEventReceiver

- SPListEventReceiver

- SPWebEventReceiver

- Support for all Web Parts that derive from `System.Web.UI.WebControls.WebParts.WebPart`

- Web Parts

- WebTemplate feature elements (instead of *Webtemp.xml*)

- Visual Web Parts

  Sandboxed solutions do not support the following capabilities and elements:

- Application Pages

- Custom Action Group

- Farm-scoped features

- `HideCustomAction` element

- Web Application-scoped features

- Workflows with code

## Related content
- [Differences between sandboxed and farm solutions](../sharepoint/differences-between-sandboxed-and-farm-solutions.md)
- [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md)

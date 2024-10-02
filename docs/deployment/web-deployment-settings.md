---
title: Manage web deployment settings
description: Learn how to configure deployment settings for web applications in Visual Studio, when you publish a web application to Azure, IIS, or another target.
ms.date: 09/27/2024
ms.topic: how-to
helpviewer_keywords:
  - "deployment settings, web app"
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: deployment
monikerRange: '>= vs-2019'
#customer intent: As a web developer, I want to understand and control the deployment settings for my web app.
---
# Manage web deployment settings

You can control how your web application gets deployed using the settings.

## Prerequisite

Visual Studio with the Web Development workload installed.

## Manage settings

The **Show all settings** link appears after you run the **Publish** wizard to create a publish profile. The settings vary according to the type of deployment.

To view or change the settings, select the **Show all settings** link, or click on any of the pencil icons. The **Settings** page appears.

1. Click on the **Settings** link. The Settings screen opens.
1. The **Prev** button takes you to the previous screen with settings you can edit for some deployment types.
1. Expand the **File Publish Options** to view settings that relate to files that might already be on the site.
1. Expand the Database settings to view the database connection information, which can be different from what your app uses when running locally during development and testing.

The following table describes the settings. Click on the links for more information.

| Name | Profile types | Property | Description |
| - | - | - |
| Configuration | Folder, IIS | `LastUsedBuildConfiguration` | The project build configuration to deploy, for example, `Release`. |
| TargetFramework | Folder, IIS | `TargetFramework` | The version of .NET that the app is targeted to run on. This is already set by the project, but you can change it for deployment. |
| [Deployment mode](/dotnet/core/deploying/) | Folder, IIS | none or `SelfContained` | You can choose framework-dependent if you can depend on the runtime being available, or self-contained if you want to package the runtime with the application's publish artifacts. |
| [Target Runtime](/dotnet/core/rid-catalog) | Folder, IIS | | The .NET Runtime ID (RID) for this deployment. |
| Server | IIS | `MSDeployServiceURL` | The web server name, URI, or IP address. For example, `localhost`. |
| Site name | IIS | Site | The site name in IIS, for example, `Default Web Site`. |
| Username | IIS | `UserName` | The username you will use to access the site in IIS. |
| Password | IIS | `UserPWD` | The first time you publish, you create a password that you will use to publish the site. The password can't be changed in Visual Studio, but it can be changed in IIS or in Azure. If you don't know the password, you can get it by downloading the `.publishsettings` file. See [Import publish settings from IIS](tutorial-import-publish-settings-iis.md) and [Import publish settings from Azure](tutorial-import-publish-settings-azure.md). |
| Save password checkbox | IIS | `_SavePWD` | If checked, saves the password as plain text in the `.pubxml` file. |
| Destination URL | IIS | `SiteURLToLaunchAfterPublish` | The URL that launches the app, for example, `http://localhost/projectname`. If the IIS configuration for the web site exposes the site on a specific port in its bindings settings, include that as in `http://localhost:nnnn/projectname`. This is optional and only provides a convenient link on the Publish page, and is used to launch the site after a successful publish. |
| [Enable ReadyToRun compilation](/dotnet/core/deploying/ready-to-run) | Folder | `PublishReadyToRun` | ReadyToRun is a form of Ahead-of-time (AOT) compilation. It can reduce latency by avoiding Just-in-time (JIT) compilation at runtime. |
| [Trim unused code](/dotnet/core/deploying/trimming/trim-self-contained) | Folder | `PublishTrimmed` | Minimizes the size of a self-contained deployment. |
| [Produce single file](/dotnet/core/deploying/single-file/overview) | Folder | `PublishSingleFile` | An option that allows the published application to be distributed in a single file. |
| Remove additional files at destination | IIS  | `SkipExtraFilesOnServer` | To preserve added files, uncheck the box. |
| Delete all existing files prior to publish. | FTP | `DeleteExistingFiles` | Uncheck this to preserve unrelated files at the destination, or check this to start with a clean deployment to the folder. |
|Package location| IIS WebDeploy Package|`DesktopBuildPackageLocation` | A local filesystem path to place the output package. |

## Next steps

The settings are persisted in the `.pubxml` file. The `.pubxml` file is an MSBuild input file. You can edit the file to further customize the deployment. See [MSBuild](../msbuild/msbuild.md).

## Related content

[Visual Studio .pubxml files](/aspnet/core/host-and-deploy/visual-studio-publish-profiles)

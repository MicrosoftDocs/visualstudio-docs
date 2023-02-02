---
title: "Troubleshooting: How do I release a new version of my existing extension?"
description: "A guide on updating existing extensions via the publishing workflow."
author: heiligerdankgesang 
ms.author: dominicn
manager: dominicn
ms.date: 12/14/2020
ms.technology: vs-ide-general
ms.assetid: 5DA76197-7859-421f-AC45-401F22F5D794
ms.topic: how-to
---
# Troubleshooting: How do I release a new version of my existing extension?

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

> [!IMPORTANT]
> Currently, creating new extensions is not officially supported in Visual Studio 2019 for Mac.

The Visual Studio for Mac extension repository server will be moving on January 15, 2021. This move will not impact users that have already downloaded your extension, but will change the way you publish new releases of your extension after this date.

As an author of an existing extension, you'll need to follow a different workflow to release further updates. This process consists of:
- Setting up a public GitHub repository for each extension
- Sharing the repository URL to the Visual Studio for Mac team via the [extension publishing mailing list](mailto:vsmextpub@microsoft.com)
- Updating your extension by using the releases feature in GitHub


## Initial setup 

In order to continue publishing updates to your extensions, you'll need to create a public GitHub repository. If you publish multiple extensions, you'll need to have a separate repository for each one unless you always version and publish them together, in which case you can use a single repository.

> [!NOTE]
> While the GitHub repository for your extension needs to be public, you don't need to host any of your code there. Following this process does not require you to have any of your code in GitHub.


## Share the location of your repository

Once you've set up the repository, send an email to the [extension publishing mailing list](mailto:vsmextpub@microsoft.com) with the URL.


## Release a new version

You'll use the "Create a new release" link on the main page of the repository to begin the process of updating your extension. Once you've selected that link, follow these steps:

1. Add information to the **tag version** of the release in the following format

    > v\<releaseVersion>\-vsm\<targetVersion>

    Where:
     - **&lt;releaseVersion&gt;** is your extension version number
     - **&lt;targetVersion&gt;** is the minimum version of Visual Studio for Mac your extension is targeting

2. (Optional) The **title** and **description** fields can be filled with any information you'd like; this workflow doesn't use the information in those fields.

3. Ensure the **pre-release** checkbox is unchecked. If it's checked, the release will not be picked up by this publishing process.

4. Attach the **.mpack** file(s) that implement your extension in the **binaries** section. It's possible to attach multiple **.mpack** files in a release.

Visual Studio for Mac will display the latest version of your extension that is compatible with the Visual Studio for Mac installation that was used to access the extension repository.

As long as you registered your GitHub repository with the Visual Studio for Mac team, your extension release will be picked up by Visual Studio for Mac within 24 hours.

## Additional information

- Releases that don't conform to the requirements detailed above won't be published. 
- After January 15, 2021, extension updates will only show up in Visual Studio for Mac 8.0 or newer.
- Existing extensions will remain available to Visual Studio for Mac users without any action on your part. You only need to follow the instructions in this guide if you publish a new version after January 15, 2021.

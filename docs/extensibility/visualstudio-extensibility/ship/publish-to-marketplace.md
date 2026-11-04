---
title: Publish a Visual Studio extension to the Marketplace
description: Learn how to publish a Visual Studio extension to the Visual Studio Marketplace, where developers worldwide can discover and install your extension.
ms.date: 10/15/2026
ms.topic: how-to
ms.author: tinali
author: tinaschrepfer
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---

# Publish a Visual Studio extension to the Marketplace

This walkthrough shows you how to publish a Visual Studio extension to [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/vs). When you add your extension to the Marketplace, developers can use the Extension Manager in Visual Studio to discover, install, and update it.

## Prerequisites

- A Visual Studio extension project with a built `.vsix` file.
- A Microsoft account for signing in to the Marketplace.

## Package your extension

1. Update the extension manifest (`.vsixmanifest` or extension configuration) with the correct product name, author, version, and description.
2. Build your extension in **Release** mode. The `.vsix` file is generated in your output folder (for example, `bin\Release`).
3. Optionally, double-click the `.vsix` file to verify that the installation works correctly.

## Test the extension

Before distributing, test your extension to verify it installs and functions correctly:

1. In Visual Studio, press **F5** to start debugging and open an experimental instance.
2. In the experimental instance, verify your extension's features function as expected.
3. Check the **Extensions** > **Manage Extensions** dialog to confirm the extension appears and is enabled.

## Publish the extension

1. In a web browser, go to [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/vs).
2. In the upper-right corner, select **Sign in** and sign in with your Microsoft account.
3. Select **Publish extensions**. If you don't have a publisher account, you're prompted to create one.
4. Choose the publisher you want to use to upload your extension. Select **New extension** and then select **Visual Studio**.
5. In **Upload extension**, drag and drop your `.vsix` file or browse to select it. Select **Continue**.
6. In **Provide extension details**, review and update the following fields:

   | Field | Description |
   |-------|-------------|
   | **Internal Name** | Used in the URL of your extension's detail page |
   | **Display Name** | The name shown in the Marketplace and Extension Manager |
   | **Version** | Auto-populated from your extension manifest |
   | **VSIX ID** | Unique identifier for your extension (required for auto-updates) |
   | **Logo** | Auto-populated from your extension manifest if provided |
   | **Short description** | Brief description of your extension |
   | **Overview** | Include screenshots and detailed information about your extension |
   | **Supported Visual Studio versions** | Which versions of Visual Studio your extension supports |
   | **Categories** | Select up to three categories that best fit your extension |
   | **Tags** | Keywords that help users find your extension |
   | **Pricing Category** | Free or paid |
   | **Source code repository** | Optional link to your source code |

7. Select **Save & Upload**.
8. To publish your extension, right-click on your extension in the publisher management page and select **Make Public**.

## Update a published extension

1. In a web browser, go to [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/vs) and sign in.
2. Select **Publish extensions** and choose your publisher.
3. Next to the extension you want to update, hover over the three dots menu and choose **Manage**.
4. Select **Add version**.
5. Drop the next `.vsix` file into the upload area or browse to select it, then select **Upload package**.
6. Review the extracted package details, including its extension version and installation targets. VSIX-supplied values are read-only. If they are incorrect, cancel the upload, fix the project or manifest, and rebuild.
7. Review any warnings and resolve errors, then select **Publish package**.
8. Expand the version in the package list and check its minimum supported Visual Studio version, architecture, edition, and validation status.
9. Repeat for each remaining package.

The packages can share an extension version when they target different minimum API versions, architectures, or editions. To update an existing target, increment its extension version and use **Add version** again. You don't overwrite the previously published package.

For a worked example and selection rules, see [Publish multiple VSIX payloads](publish-multiple-payloads.md).

## Manage extension information

The management page groups packages by extension version. Expand a version to inspect its packages and download a specific package. Use the architecture, edition, and version filters to find the targets you need.

### Changing extension metadata

To change extension metadata such as the overview markdown, preview state, icon, and more, navigate the "Manage" tab under the reports page, or follow these steps:

1. Select **Publish extensions** and choose your publisher.
2. Next to the extension you want to update, hover over the three dots menu and choose **Manage**.

On this page there is a panel where extension metadata is displayed. Some fields are read-only, which means they're either set once at the time of extension creation, or are provided by uploaded payloads. To make edits, update the field(s) you want to change and then click the "Save" button at the bottom of the panel.

### Deleting versions

To remove an eligible version:

1. Select **Publish extensions** and choose your publisher.
2. Next to the extension you want to update, hover over the three dots menu and choose **Manage**.
3. Scroll down to the table listing the versions and their targets.
4. Expand the version you want to delete and review every package in the group.
5. Verify that customers who need those packages have a compatible replacement.
6. Select **Delete** on the version group.
7. Confirm the version number in the dialog, then select **Remove version**.

> [!WARNING]
> This action removes all payloads at the selected extension version, not just one package in the expanded list. The confirmation is non-reversible. The portal doesn't offer deletion of the latest or only remaining version.

To replace a faulty package, publish a higher extension version. For the distinction between removing a version and removing the whole listing, see [Remove published packages](publish-multiple-payloads.md#remove-published-packages).

## Manage publisher accounts

Visual Studio Marketplace supports multiple users on a publisher account with different access levels:

| Role | Permissions |
|------|-------------|
| **Creator** | Can publish extensions, but can't view or manage extensions published by other users |
| **Reader** | Can view extensions, but can't publish or manage them |
| **Contributor** | Can publish and manage extensions, but can't edit publisher settings or manage access |
| **Owner** | Full access to publish, manage extensions, edit publisher settings, and manage access |

To add a user:

1. Ask the new member to sign into the Marketplace and copy their User ID (visible by hovering over their email address).
2. Navigate to your publisher account, select **Members**, and select **Add**.
3. Enter the User ID and select the appropriate role.

## Install the extension from the Marketplace

1. In Visual Studio, go to **Extensions** > **Manage Extensions**.
2. Select **Online** and search for your extension.
3. Select **Download** to schedule the installation.

## Remove an extension from the Marketplace

1. Go to [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/vs) and sign in.
2. Select **Publish extensions** and choose your publisher.
3. Select the extension menu and choose **Remove**.
4. Confirm the removal by entering the extension name.

> [!WARNING]
> The remove/unpublish action is non-reversible.

## Related content

- [Publish multiple VSIX payloads in one Marketplace entry](publish-multiple-payloads.md)
- [Publish via command line](publish-via-command-line.md)
- [Sign VSIX packages](sign-vsix-packages.md)

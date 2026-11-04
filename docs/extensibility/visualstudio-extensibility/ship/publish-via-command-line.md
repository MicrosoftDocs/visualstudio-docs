---
title: Publish a Visual Studio extension via command line
description: Learn how to publish a Visual Studio extension to the Marketplace using the VsixPublisher.exe command-line tool.
ms.date: 10/27/2026
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
monikerRange: ">=vs-2022"
---
# Publish a Visual Studio extension via command line

You can publish a Visual Studio extension to the [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/vs) using the `VsixPublisher.exe` command-line tool. This is useful for CI/CD pipelines and automated publishing workflows.

`VsixPublisher.exe` is located at:

```text
${VSInstallDir}\VSSDK\VisualStudioIntegration\Tools\Bin\VsixPublisher.exe
```

## Commands

### publish

Publishes an extension to the Marketplace. The payload can be a `.vsix`, `.msi`, or `.exe` file, or a link to use as the "more info URL". If the extension already exists, the command publishes to its listing; otherwise, it creates a new listing.

| Option | Description |
|--------|-------------|
| `payload` (required) | Path to the package to publish, or a link to use as the "more info URL". |
| `publishManifest` (required) | Path to the publish manifest JSON file. |
| `ignoreWarnings` | Comma-separated list of warnings to ignore (for example, `VSIXValidatorWarning01,VSIXValidatorWarning02`). |
| `personalAccessToken` | Personal Access Token (PAT) for authentication. If neither this option nor `oidc` is specified, the `login` command gets the PAT from the saved publisher credentials. Don't specify this option together with `oidc`. |
| `oidc` | Uses trusted publishing from GitHub Actions instead of a PAT. This flag doesn't take a value. Requires a Marketplace trusted publishing policy and `id-token: write` permission in the GitHub Actions job. See [Publish from GitHub Actions with trusted publishing](#publish-from-github-actions-with-trusted-publishing). |

```console
VsixPublisher.exe publish -payload "{path to vsix}" -publishManifest "{path to vs-publish.json}" -ignoreWarnings "VSIXValidatorWarning01,VSIXValidatorWarning02" -personalAccessToken "{Your PAT}"
```

To publish from a GitHub Actions workflow configured for trusted publishing, use `-oidc` instead of `-personalAccessToken`:

```console
VsixPublisher.exe publish -payload "{path to vsix}" -publishManifest "{path to vs-publish.json}" -oidc
```

### `deletePublisher`

Deletes a publisher on the Marketplace.

| Option | Description |
|--------|-------------|
| `publisherName` (required) | The publisher identifier. |
| `personalAccessToken` (required) | Personal Access Token (PAT) used to authenticate the publisher. |

```console
VsixPublisher.exe deletePublisher -publisherName "{Publisher Name}" -personalAccessToken "{Personal Access Token}"
```

### `deleteExtension`

Deletes an extension from the Marketplace.

> [!WARNING]
> This command deletes the whole Marketplace entry, not one payload or extension version. To remove an eligible version, use [the publisher portal](publish-to-marketplace.md#deleting-versions).

| Option | Description |
|--------|-------------|
| `extensionName` (required) | The name of the extension to delete. |
| `publisherName` (required) | The publisher identifier. |
| `personalAccessToken` | PAT for authentication. If not specified, the PAT is obtained from the logged-in publisher credentials. |

```console
VsixPublisher.exe deleteExtension -extensionName "{Extension Name}" -publisherName "{Publisher Name}"
```

### `login`

Logs a publisher into the machine.

| Option | Description |
|--------|-------------|
| `personalAccessToken` (required) | Personal Access Token (PAT) used to authenticate the publisher. |
| `publisherName` (required) | The publisher identifier. |
| `overwrite` | Overwrites any existing publisher credentials. |

```console
VsixPublisher.exe login -personalAccessToken "{Personal Access Token}" -publisherName "{Publisher Name}"
```

### `logout`

Logs a publisher out of the machine.

| Option | Description |
|--------|-------------|
| `publisherName` (required) | The publisher identifier. |
| `ignoreMissingPublisher` | Doesn't report an error if the publisher isn't logged in. |

```console
VsixPublisher.exe logout -publisherName "{Publisher Name}"
```

### `createPublisher`

> [!CAUTION]
> The `createPublisher` command is no longer available. Create a publisher on the [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/manage/publishers).

## Publish from GitHub Actions with trusted publishing

Trusted publishing lets a GitHub Actions workflow publish your Visual Studio extension without storing a Personal Access Token (PAT). Use the `-oidc` flag with the `publish` command to authenticate by using the workflow's OpenID Connect (OIDC) identity.

`VsixPublisher.exe` requests an OIDC token from GitHub Actions with the audience `marketplace.visualstudio.com`, then exchanges it for a short-lived Marketplace session token. The tool uses that session token to publish the extension.

### Trusted publishing prerequisites

Before publishing by using `-oidc`:

- Use a version of `VsixPublisher.exe` that supports the `oidc` option.
- Create a publisher in the [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/manage/publishers) and configure a trusted publishing policy that authorizes your GitHub repository and workflow.
- Set the `publisher` property in your [publish manifest](#publish-manifest-file) to the Marketplace publisher identifier associated with that policy.
- Grant the publishing job `id-token: write` permission so it can request an OIDC token from GitHub Actions.
- Make the extension payload, publish manifest, overview file, and any other referenced assets available on the Windows runner.

### Configure the workflow

Add the following permissions to the GitHub Actions job that publishes your extension:

```yaml
permissions:
  contents: read
  id-token: write
```

The `id-token: write` permission allows the job to request an OIDC token. It doesn't, by itself, authorize publishing to the Marketplace; the repository and workflow must also match the publisher's trusted publishing policy.

After your workflow builds the extension or downloads its build artifacts, add a publishing step like the following. Replace the executable, payload, and manifest paths with the paths used by your workflow. The executable is normally installed under `<VSInstallDir>\VSSDK\VisualStudioIntegration\Tools\Bin\VsixPublisher.exe`.

```yaml
- name: Publish extension to Visual Studio Marketplace
  shell: pwsh
  run: |
    & "C:\path\to\VsixPublisher.exe" publish `
      -payload ".\artifacts\TestPublish.vsix" `
      -publishManifest ".\publishManifest.json" `
      -oidc
    if ($LASTEXITCODE -ne 0) {
      exit $LASTEXITCODE
    }
```

You don't need to run `VsixPublisher.exe login` or provide a PAT when using `-oidc`. The tool obtains the token from the GitHub Actions job automatically.

> [!IMPORTANT]
> Don't combine `-oidc` with `-personalAccessToken`. If OIDC token acquisition or the Marketplace token exchange fails, publishing fails; the tool doesn't fall back to saved PAT credentials.

### Troubleshoot trusted publishing

| Problem | What to check |
| --- | --- |
| The tool reports that `-oidc` is an invalid argument. | Confirm that the installed version of `VsixPublisher.exe` supports trusted publishing and that the flag has a single hyphen. |
| The tool reports missing GitHub Actions OIDC environment variables. | Run the command in a GitHub Actions job with `id-token: write` permission. The implementation requires `ACTIONS_ID_TOKEN_REQUEST_URL` and `ACTIONS_ID_TOKEN_REQUEST_TOKEN`, which GitHub Actions supplies. Running the same command in a local terminal doesn't provide these variables. |
| The tool can't exchange the OIDC token for a Marketplace session token. | Check that the Marketplace trusted publishing policy authorizes the repository and workflow, and that the publish manifest specifies the correct publisher identifier. |
| The tool reports conflicting authentication arguments. | Remove `-personalAccessToken` when using `-oidc`. |

## Publish manifest file

The `publishManifest` file provides extension metadata for the Marketplace. For a VSIX, the `identity` property only needs `internalName`; Marketplace gets the other identity properties from the VSIX manifest. For an MSI, EXE, or link extension, specify the required identity properties in the publish manifest.

**VSIX extension example:**

```json
{
    "$schema": "http://json.schemastore.org/vsix-publish",
    "categories": [ "build", "coding" ],
    "identity": {
        "internalName": "MyVsixExtension"
    },
    "overview": "overview.md",
    "priceCategory": "free",
    "publisher": "MyPublisherName",
    "private": false,
    "qna": true,
    "repo": "https://github.com/MyPublisherName/MyVsixExtension"
}
```

**MSI/EXE or link extension example:**

```json
{
    "$schema": "http://json.schemastore.org/vsix-publish",
    "categories": [ "build", "coding" ],
    "identity": {
        "description": "My extension.",
        "displayName": "My Extension",
        "icon": "\\path\\to\\icon.ico",
        "installTargets": [
            {
                "sku": "Microsoft.VisualStudio.Community",
                "version": "[10.0, 16.0)"
            }
        ],
        "internalName": "MyExtension",
        "language": "en-US",
        "tags": [ "tag1", "tag2" ],
        "version": "3.7.0",
        "vsixId": "MyExtension"
    },
    "overview": "overview.md",
    "priceCategory": "free",
    "publisher": "MyPublisherName",
    "private": false,
    "qna": true,
    "repo": "https://github.com/MyPublisherName/MyVsixExtension"
}
```

For non-VSIX extensions, `description`, `displayName`, `icon`, `installTargets`, `language`, and `version` are required in `identity`. `tags` and `vsixId` are optional. The `icon` path can be relative to the publish manifest file. The `language` value can use a locale name (such as `en-US`) or a language identifier (such as `1033`).

## Asset files

You can use asset files to embed images and other files in the Marketplace overview. For example, if `overview.md` contains:

```markdown
TestExtension
...
This is test extension.
![Test logo](images/testlogo.png "Test logo")
```

Map the image's path on disk to the path used in the Markdown by adding an `assetFiles` entry to the publish manifest:

```json
{
    "assetFiles": [
        {
            "pathOnDisk": "\\path\\to\\images\\testlogo.png",
            "targetPath": "images/testlogo.png"
        }
    ],
    "categories": [ "build", "coding" ],
    "identity": {
        "internalName": "MyVsixExtension"
    },
    "overview": "overview.md",
    "priceCategory": "free",
    "publisher": "MyPublisherName"
}
```

## Publishing walkthrough

### Prerequisites

Install the Visual Studio SDK. For more information, see [Install the Visual Studio SDK ↗](../../installing-the-visual-studio-sdk.md).

### Create a Visual Studio extension

This walkthrough uses a default VSPackage extension, but the publishing steps apply to other extension types too.

1. Create a C# VSPackage named `TestPublish` that has a menu command. For more information, see [Create your first extension: Hello World ↗](../../extensibility-hello-world.md).

### Package your extension

1. Update the extension `.vsixmanifest` with the correct product name, author, and version.

   [![Screenshot showing the `.vsixmanifest`.](../../media/visualstudio/update-extension-vsixmanifest.png)](../../media/visualstudio/update-extension-vsixmanifest.png#lightbox)

2. Build your extension in **Release** mode. The VSIX is generated in the `bin\Release` folder.

3. Optionally, double-click the VSIX to verify that it installs.

### Test the extension

Before you distribute the extension, build and test it to make sure it installs correctly in the experimental instance of Visual Studio.

1. In Visual Studio, start debugging to open an experimental instance.

2. In the experimental instance, go to **Tools** > **Extensions and Updates**. Confirm that `TestPublish` appears in the center pane and is enabled.

3. On the **Tools** menu, confirm that you see the test command.

### Publish the extension

1. Make sure that you built the latest version of your extension in **Release** mode.

2. Create a `vs-publish.json` publish manifest and an `overview.md` file.

3. Open Developer PowerShell and navigate to the `VsixPublisher.exe` directory:

   ```text
   ${VSInstallDir}\VSSDK\VisualStudioIntegration\Tools\Bin
   ```

4. Choose the authentication method for your environment:

   - To authenticate with a Personal Access Token (PAT), use:

     ```console
     VsixPublisher.exe publish -payload "{path to vsix file}" -publishManifest "{path to vs-publish.json}" -personalAccessToken "{PAT}"
     ```

   - Omit `-personalAccessToken` if you previously saved credentials for the publisher by using the [`login`](#login) command.

   - To authenticate from a GitHub Actions workflow configured for [trusted publishing](#publish-from-github-actions-with-trusted-publishing), use:

     ```console
     VsixPublisher.exe publish -payload "{path to vsix file}" -publishManifest "{path to vs-publish.json}" -oidc
     ```

5. On successful publishing, you'll see:

   ```text
   Uploaded 'MyVsixExtension' to the Marketplace.
   ```

6. Verify your extension on the [Visual Studio Marketplace ↗](https://marketplace.visualstudio.com/).

### Install the extension from the Marketplace

Now that the extension is published, install it in Visual Studio and test it there.

1. In Visual Studio, go to **Extensions** > **Manage Extensions**.
2. Select **Online** and search for `TestPublish`.
3. Select **Download** to schedule the installation.
4. Close all instances of Visual Studio to complete the installation.

## Publish multiple VSIX payloads

Publish each VSIX to the same Marketplace entry by using the same publish manifest for every upload. Keep the Marketplace identity and VSIX ID consistent across packages.

Run `publish` once for each package, using the authentication method described in [Publish the extension](#publish-the-extension). Each upload is independent; if one fails, earlier successful uploads aren't rolled back.

For package requirements, selection rules, and a worked example, see [Publish multiple VSIX payloads in one Marketplace entry](publish-multiple-payloads.md).

## Remove the extension

You can remove the extension from the Visual Studio Marketplace and from your computer.

### Remove the extension from the Marketplace

To remove the Marketplace listing, use the following command:

```console
VsixPublisher.exe deleteExtension -publisherName "TestVSIXPublisher" -extensionName "MyVsixExtension"
```

On successful deletion, you'll see:

```text
Removed 'MyVsixExtension' from the Marketplace.
```

> [!WARNING]
> Removing the Marketplace entry deletes the whole listing. To remove an eligible version or payload, see [Delete versions](publish-to-marketplace.md#deleting-versions).

### Remove the extension from your computer

1. In Visual Studio, go to **Extensions** > **Manage Extensions**.
2. Find `MyVsixExtension` and select **Uninstall** to schedule its removal.
3. Close all instances of Visual Studio to complete the uninstallation.

## See also

- [Install the Visual Studio SDK ↗](../../installing-the-visual-studio-sdk.md)
- [Create your first extension: Hello World ↗](../../extensibility-hello-world.md)

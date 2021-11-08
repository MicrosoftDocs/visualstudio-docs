---
title: CodeIndex command
description: "Learn how to use the CodeIndex command to manage code indexing on Azure DevOps Server (formerly known as Team Foundation Server)."
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- command-line tools [Team Foundation Server]
- TFSConfig
- CodeIndex command [Team Foundation Server]
ms.assetid: b79568d4-6a64-4ca9-a1ee-3e57f92a9c5c
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# CodeIndex command

Use the **CodeIndex** command to manage code indexing on Team Foundation Server. For example, you might want to reset the index to fix CodeLens information, or turn off indexing to investigate server performance issues.

## Required permissions

To use the **CodeIndex** command, you must be a member of the **Team Foundation Administrators** security group. See [Permissions and groups defined for Azure DevOps Services and TFS](/azure/devops/organizations/security/permissions?view=vsts&preserve-view=true).

> [!NOTE]
> Even if you log on with administrative credentials, you must open an elevated Command Prompt window to run this command. You must also run this command from the application tier for Team Foundation.

## Syntax

```cmd
TFSConfig CodeIndex /indexingStatus | /setIndexing:[ on | off | keepupOnly ] | /ignoreList:[ add | remove | removeAll | view ] ServerPath | /listLargeFiles [/fileCount:FileCount] [/minSize:MinSize] | /reindexAll | /destroyCodeIndex [/noPrompt] | /temporaryDataSizeLimit:[ view | <SizeInGBs> | disable ] | /indexHistoryPeriod:[ view | all | <NumberOfMonths> ] [/collectionName:CollectionName | /collectionId:CollectionId]
```

### Parameters

|**Argument**|**Description**|
|------------------| - |
|`CollectionName`|Specifies the name of the project collection. If the name has spaces, enclose the name with quotation marks, for example, "Fabrikam Website".|
|`CollectionId`|Specifies the identification number of the project collection.|
|`ServerPath`|Specifies the path to a code file.|

|**Option**|**Description**|
|----------------| - |
|**/indexingStatus**|Show the status and configuration of the code indexing service.|
|**/setIndexing:**[ on &#124; off &#124; keepupOnly ]|-   **on**: Start indexing all changesets.<br />-   **off**: Stop indexing all changesets.<br />-   **keepupOnly**: Stop indexing previously created changesets and start indexing new changesets only.|
|**/ignoreList:**[ add &#124; remove &#124; removeAll &#124; view ] `ServerPath`<br /><br /> You can use the wildcard character (*) at the start, end, or both ends of the server path.|Specifies a list of code files and their paths that you don't want indexed.<br /><br /> -   **add**: Add the file that you don't want indexed to the ignored file list.<br />-   **remove**: Remove the file that you want indexed from the ignored file list.<br />-   **removeAll**: Clear the ignored file list and start indexing all files.<br />-   **view**: See all the files that aren't being indexed.|
|**/listLargeFiles [/fileCount:** `FileCount` **/minSize:** `MinSize`]|Shows the specified number of files that exceeds the specified size in KB. You can then use the **/ignoreList** option to exclude these files from indexing.|
|**/reindexAll**|Clear previously indexed data and restart indexing.|
|**/destroyCodeIndex [/noPrompt]**|Delete the code index and remove all indexed data. Does not require confirmation if you use the **/noPrompt** option.|
|**/temporaryDataSizeLimit**:[ view &#124; <`SizeInGBs`> &#124; disable ]|Control how much temporary data that CodeLens creates when processing changesets. The default limit is 2 GB.<br /><br /> -   **view**: Show the current size limit.<br />-   `SizeInGBs`: Change the size limit.<br />-   **disable**: Remove the size limit.<br /><br /> This limit is checked before CodeLens processes a new changeset. If temporary data exceeds this limit, CodeLens will pause processing past changesets, not new ones. CodeLens will restart processing after the data is cleaned up and falls below this limit. Cleanup runs automatically once a day. This means temporary data might exceed this limit until cleanup starts running.|
|**/indexHistoryPeriod**:[ view &#124; all &#124; <`NumberOfMonths`> ]|Control how long to index your change history. This affects how much history CodeLens shows you. The default limit is 12 months. This means CodeLens shows your change history from the last 12 months only.<br /><br /> -   **view**: Show the current number of months.<br />-   **all**: Index all change history.<br />-   `NumberOfMonths`: Change the number of months used to index change history.|
|**/collectionName:** `CollectionName`|Specifies the name of the project collection on which to run the **CodeIndex** command. Required if you don't use **/CollectionId**.|
|**/collectionId:** `CollectionId`|Specifies the identification number of the project collection on which to run the **CodeIndex** command. Required if you don't use **/CollectionName**.|

## Examples

> [!NOTE]
> The example companies, organizations, products, domain names, email addresses, logos, people, places, and events depicted herein are fictitious.  No association with any real company, organization, product, domain name, email address, logo, person, places, or events is intended or should be inferred.

To see the code indexing status and configuration:

```cmd
TFSConfig CodeIndex /indexingStatus /collectionName:"Fabrikam Website"
```

To start indexing all changesets:

```cmd
TFSConfig CodeIndex /setIndexing:on /collectionName:"Fabrikam Website"
```

To stop indexing previously created changesets and start indexing new changesets only:

```cmd
TFSConfig CodeIndex /setIndexing:keepupOnly /collectionName:"Fabrikam Website"
```

To find up to 50 files that are larger than 10 KB:

```cmd
TFSConfig CodeIndex /listLargeFiles /fileCount:50 /minSize:10 /collectionName:"Fabrikam Website"
```

To exclude a specific file from indexing and add it to the ignored file list:

```cmd
TFSConfig CodeIndex /ignoreList:add "$/Fabrikam Website/Catalog.cs" /collectionName:"Fabrikam Website"
```

To see all the files that aren't indexed:

```cmd
TFSConfig CodeIndex /ignoreList:view
```

To clear previously indexed data and restart indexing:

```cmd
TFSConfig CodeIndex /reindexAll /collectionName:"Fabrikam Website"
```

To save all changeset history:

```cmd
TFSConfig CodeIndex /indexHistoryPeriod:all /collectionName:"Fabrikam Website"
```

To remove the size limit on CodeLens temporary data and continue indexing regardless of temporary data size:

```cmd
TFSConfig CodeIndex /temporaryDataSizeLimit:disable /collectionName:"Fabrikam Website"
```

To delete the code index with confirmation:

```cmd
TFSConfig CodeIndex /destroyCodeIndex /collectionName:"Fabrikam Website"
```

## See also

- [Find code changes and other history with CodeLens](../ide/find-code-changes-and-other-history-with-codelens.md)
- [Managing server configuration with TFSConfig](/azure/devops/server/command-line/tfsconfig-cmd)

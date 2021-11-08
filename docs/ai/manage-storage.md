---
title: Browse storage to upload data
description: Learn how you can browse all storage on the remote machine or Azure file share to enable uploading data or downloading models and logs.
ms.custom: SEO-VS-2020
author: jillre
ms.author: jillfra
manager: jmartens
ms.technology: vs-ai-tools
monikerRange: vs-2017
ms.date: 11/13/2017
ms.topic: how-to
ms.workload:
  - "multiple"
---
# Browse storage to upload data or download models and logs

You can browse all storage on the remote machine or Azure file share to enable uploading data or downloading models and logs. Or, if you want to access logs and job outputs for a specific job, you can do that as well in the job browser.

## To access all data on the remote machine or file share

1. Open the **Server Explorer**.
2. Expand the remote machine or Batch AI compute context.
3. Right-click **Storage**; then, click **Browse**.

    ![Screenshot of Server Explorer with the Remote Machines folder expanded. Storage is highlighted in the folder tree, and Browse is selected on the context menu.](media/manage-storage/browse-storage.png)

## To access job-specific data on the remote machine or file share

1. Open the [Job History](job-details.md)
2. Select the job.
3. Click **Working Folder** or click **StdOut / Stderr** for quick access to these important log files.

    ![Screenshot of the Job Browser window in Server Explorer. The train_mnist job is selected, and the Working Folder link is selected under Job Details.](media/manage-storage/job-workingfolder.png)

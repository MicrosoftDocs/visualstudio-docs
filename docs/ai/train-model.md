---
title: Sumbit a job to train model locally or in cloud
description: train model locally or in cloud
keywords: ai, visual studio, train model, cloud, local
author: lisawong19
ms.author: liwong
manager: routlaw
ms.date: 11/13/2017
ms.topic: how-to article
ms.technology: visual studio
ms.devlang: multiple
ms.service: multiple
---

# Submitting a job to train your model locally or in the cloud
Now that the new project is open in Visual Studio, you can submit a model training job to your different compute targets (local or VM with docker).

Visual Studio Tools for AI provides multiple ways to submit a model training job. 
1. Context Menu (right click) - **Machine Learning: Submit Job**.
2. From the command palette: "Machine Learning: Submit Job".
3. Alternatively, you can run the command directly using Azure CLI, Machine Learning Commands, using the embedded terminal.

![submit job](media\train-model\submitjobs.png)

Open iris_sklearn.py, right click and select **Machine Learning: Submit Job**.
1. Select your platform: "Azure Machine Learning".
2. Select your run-configuration: "Docker-Python."

> [!NOTE]
> If it is the first time your submit a job, you receive a message "No Machine Learning configuration found, creating...". A JSON file is opened, save it (**Ctrl+S**).

Once the job is submitted, the embedded-terminal displays the progress of the runs. 

## View recent job performance and details
Once the jobs are submitted, you can list the jobs from the run history.
1. Open the command palette (View > **Command Palette** or **Ctrl+Shift+P**).
2. Enter "**AI List**."
3. You get a recommendation for "AI: List Jobs", select and press enter.
4. Select the platform "Azure Machine Learning."

The Job List View opens and displays all the runs and some related information.

![add data source](media\train-model\runhistory-list.png)

To view the results of a job, click on the **job ID** link to see detailed information. 
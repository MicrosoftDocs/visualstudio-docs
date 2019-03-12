---
title: "Tutorial: Open a project from a repo"
description: "Learn how to open a project in a GitHub or Azure DevOps repository by using Visual Studio."
ms.custom: "get-started"
ms.date: 03/13/2019
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
ms.topic: tutorial
author: TerryGLee
ms.author: tglee
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "dotnet"
  - "dotnetcore"
---
# Tutorial: Open a project from a repo

In this tutorial, you'll use Visual Studio to open a solution from a repo in either GitHub or Azure DevOps.

Here's how.

## Open a project from GitHub

1. Open Visual Studio 2017.

1. From the top menu bar, choose **File** > **Open** > **Open from Source Control**.

   The **Team Explorer - Connect** pane opens.

1. In the **Local Git Repositories** section, choose **Clone**. 

1. In the box that says ***Enter the URL of a Git repo to clone***, type or paste the URL for your repo.

1. After you clone your repo, Team Explorer closes and Solution Explorer opens. A message appears that says ***Click on Solutions and Folders above to view a list of Solutions***. In that message, the text "Solutions and Folders" is linked. Click to select **Solutions and Folders**.

   If you choose the folder for your repo, nothing happens because the folder structure is already displayed.

   If you have a solution file available and you want to open it, choose it here. Visual Studio opens the solution.

  To view the code, choose **Program.cs**

1. If a solution file is or a solution file. (In the following example, you could choose either )

1. Then, in the **Solutions** section of the **Home|vs-tutorials-sample** window, 

### Review your work

Here's an example of what it looks like when you open a project from GitHub in Visual Studio 2017:

   ![Animation of opening a project in GitHub within the Visual Studio IDE](./media/open-project-from-github.gif)

## Open a project from Azure DevOps

1. Open Visual Studio 2017.

1. From the top menu bar, choose **File** > **Open** > **Open from Source Control**.

   The **Team Explorer - Connect** pane opens.

1. 



## Next steps

If you're ready to code with Visual Studio, dive into any of the following language-specific tutorial sets:

- [Visual Studio tutorials | **C#**](./csharp/index.yml)
- [Visual Studio tutorials | **Visual Basic**](./visual-basic/index.yml)
- [Visual Studio tutorials | **C++**](/cpp/get-started/)
- [Visual Studio tutorials | **Python**](/visualstudio/python/)
- [Visual Studio tutorials | **JavaScript**, **TypeScript**, **Node.js**](/visualstudio/javascript/)

## See also

- [Visual Studio: Connect to projects by using Team Explorer](./ide/connect-team-project)
- [Azure DevOps Services: Connect to a project in Azure DevOps](/azure/devops/organizations/projects/connect-to-projects/)
- [Azure DevOps Services: Connect Azure Boards to GitHub](/azure/devops/boards/github/connect-to-github/)

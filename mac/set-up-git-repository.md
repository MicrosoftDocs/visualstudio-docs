---
title: Setting up a Git Repository
description: Connecting to a Git repository using Visual Studio for Mac.
author: heiligerdankgesang 
ms.author: dominicn
manager: dominicn
ms.date: 06/30/2022
ms.assetid: E992FA1D-B2AD-4A28-ADC6-47E4FC471060
ms.topic: how-to
---
# Set up a Git repository

 [!INCLUDE [Visual Studio for Mac](~/includes/applies-to-version/vs-mac-only.md)]

Git is a distributed version control system that allows teams to work on the same documents simultaneously. This means there is a single server that contains all the files, but whenever a repository is checked out from this central source, the entire repository is cloned locally to your machine.

There are many remote hosts that allow you to work with Git for version control, however the most common host is GitHub. The following example uses a GitHub host, but you can use any Git host for version control in Visual Studio for Mac.

If you wish to use GitHub, make sure that you have an account created and configured before following the steps in this article.

## Creating a remote repo on GitHub

The following example uses a GitHub host, but you can use any Git host for version control in Visual Studio for Mac.

To set up a Git repository, execute the following steps:

1. Create a new Git repo at github.com:

    ![Create new git repo](media/version-control-git1-sml.png)

2. Set Repo Name, description, and privacy. Do **not** initialize Repo. Set .gitignore and license to None:

    ![Set details of git repo](media/version-control-git2.png)

3. The next page gives you an option to display and copy either the HTTPS or SSH address to the repo you have created:

    ![view and copy address](media/version-control-git3.png)

   You'll need the HTTPS address to point Visual Studio for Mac to this repo.


## Clone an existing repository
Visual Studio for Mac makes it easy to clone a repository right from the IDE. You can work remotely with the Git provider of your choice, such as GitHub or Azure DevOps.

::: moniker range=">=vsmac-2022"

To clone a repository from GitHub:
1. On the home page of the GitHub repo, click the **Code** button and choose the **Open with Visual Studio** option.
:::image type="content" source="media/set-up-git-repository/version-control-git-14-2022.png" alt-text="Clone menu on GitHub, with cursor over the Open in Visual Studio link.":::
1. When prompted in the browser to open Visual Studio, click the **Open** button.
1. Visual Studio for Mac will launch with the Clone Git Repository dialog open with the URL of the GitHub repo.
1. Choose a target folder path, then click **Clone**.

To clone a repo hosted on a different remote service:

1. Copy the URL of the repo you want to clone.
1. In the Visual Studio for Mac menu bar, select the **Git > Clone Repository...** menu.
1. Paste the URL for the repo into the **URL** field of the **Clone Git Repository** dialog, choose a target folder path, then click **Clone**.

:::image type="content" source="media/set-up-git-repository/version-control-git-clone.png" alt-text="Clone dialog shown in Visual Studio for Mac, with a URL field set to the URL of the Git repo. A Target Folder path includes a file path. Cancel and Clone buttons are shown, with the Clone button set as the default button.":::

After clicking the **Clone** button, Visual Studio for Mac will clone the repository and open the first solution file (.sln) file found.

::: moniker-end


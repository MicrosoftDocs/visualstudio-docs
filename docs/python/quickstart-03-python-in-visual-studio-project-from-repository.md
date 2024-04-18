---
title: "Quickstart: Clone a repository of Python code"
description: Follow guided steps to create a Python project in Visual Studio by cloning the Python koans repository with Git or Team Explorer.
ms.date: 04/18/2024
ms.topic: quickstart
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to clone and work with code from existing Python repositories by using Git commands to create Python projects in Visual Studio.
---

# Quickstart: Clone a repository of Python code in Visual Studio

In this quickstart, you follow guided steps to clone a GitHub repository of Python code and create a project. Visual Studio makes it easy to work with Python projects by using Git commands to access content under source control. You can also clone Python code repositories from the command line and then work with the projects in Visual Studio.

## Prerequisites

::: moniker range=">=vs-2022"

- Visual Studio 2022 installed with support for Python workloads. Visual Studio 2022 provides seamless integration with GitHub with support for Git commands. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

::: moniker-end
::: moniker range="<=vs-2019"

- Visual Studio installed with support for Python workloads, along with the **GitHub extension for Visual Studio**. This extension enables you to work with GitHub repositories and Git commands. The GitHub extension is available in the Visual Studio Installer on the **Individual components** tab in the **Code tools** section:

   :::image type="content" source="media/installation-github-extension.png" alt-text="Screenshot that shows how to select the GitHub extension in the Visual Studio Installer." border="false" lightbox="media/installation-github-extension.png":::

::: moniker-end

Visual Studio for Mac isn't supported. For more information, see [What's happening to Visual Studio for Mac?](/visualstudio/mac/what-happened-to-vs-for-mac) Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

## Clone existing repository files

::: moniker range=">=vs-2022"

Use the following steps to clone an existing repository by using the Visual Studio **Git** source control commands:

1. In Visual Studio, select **Git** > **Clone**:

   :::image type="content" source="media/vs-2022/quickstart-python-git-clone-repo.png" alt-text="Screenshot that shows how to select the Git Clone repository option in Visual Studio 2022." border="false" lightbox="media/vs-2022/quickstart-python-git-clone-repo.png":::

1. In the **Clone a repository** dialog, specify the GitHub repository to clone:

   :::image type="content" source="media/vs-2022/quickstart-python-clone-repo-dialog.png" alt-text="Screenshot that shows how to specify the GitHub repository to clone in Visual Studio 2022." border="false" lightbox="media/vs-2022/quickstart-python-clone-repo-dialog.png":::

   1. For the **Repository location**, enter the URL of the repository to clone. For this exercise, enter `https://github.com/gregmalcolm/python_koans`.

   1. For the **Path**, enter the folder on your system where you want Visual Studio to store the cloned files.

      The folder you specify should be the exact folder that you want Visual Studio to use. Unlike the `git clone` command, when you create a clone in **Team Explorer**, Visual Studio doesn't automatically create a new subfolder with the name of the repository.

   1. When you're ready, select **Clone**.
   
   After cloning completes, Visual Studio opens the **Git Changes** pane for the repository. You can also see the folder with the cloned repository files in **Solution Explorer**.

1. Select **Git** > **Local Repositories** and confirm the cloned repository is now in the list:

   :::image type="content" source="media/vs-2022/quickstart-python-local-repos.png" alt-text="Screenshot that shows how to see the list of local GitHub repositories available in Visual Studio 2022." border="false" lightbox="media/vs-2022/quickstart-python-local-repos.png":::

::: moniker-end
::: moniker range="<=vs-2019"

Use the following steps to clone an existing repository by using Visual Studio **Team Explorer**:

1. In Visual Studio, select **View** > **Team Explorer** to open the **Team Explorer** window. On the **Connect** page, you can access GitHub or Azure DevOps repositories or clone a repository. 

   :::image type="content" source="media/quickstart-python-team-explorer.png" alt-text="Screenshot of the Team Explorer Connect page showing hosted service providers, including Azure DevOps and GitHub, and Local Git Repositories." border="false" lightbox="media/quickstart-python-team-explorer.png":::

   If **Team Explorer** doesn't open on the **Connect** page, select the plug icon on the Visual Studio toolbar to open the page.

1. In the **Team Explorer - Connect** page, expand the **Local Git Repositories** section, and select the **Clone** option.

   1. For the **Repository location**, enter the URL of the repository to clone. For this exercise, enter `https://github.com/gregmalcolm/python_koans`.

   1. For the **Path**, enter the folder on your system where you want Visual Studio to store the cloned files.

      The folder you specify should be the exact folder that you want Visual Studio to use. Unlike the `git clone` command, when you create a clone in **Team Explorer**, Visual Studio doesn't automatically create a new subfolder with the name of the repository.
   
   1. Select the **Recursively Clone Submodules** option.

   1. At the bottom of the page, select **Clone**.

After cloning completes, the repository name appears in the **Local Git Repositories** list.

::: moniker-end

> [!IMPORTANT]
> In this quickstart, you create a direct clone of the _python\_koans_ repository on GitHub. Such a repository is protected by its author from direct changes, so attempting to commit changes to the repository fails. In practice, developers instead fork such a repository to their own GitHub account, make changes there, and then create pull requests to submit those changes to the original repository. When you have your own fork, use its URL instead of the original repository URL used earlier.

## Create project from cloned files

After you clone the repository, you can create a new project from the cloned files.

::: moniker range=">=vs-2022"

[!INCLUDE[project-from-existing](includes/project-from-existing.md)]

::: moniker-end
::: moniker range="<=vs-2019"

1. In the **Local Git Repositories** list, double-click the repository name. The repository dashboard opens in the **Team Explorer - Home** page with **GitHub**, **Project**, and **Solutions** options.

1. Expand the **Solutions** section and select **New** to create a new project.

   :::image type="content" source="media/quickstart-python-team-explorer-new-project.png" alt-text="Screenshot of the Team Explorer Home page showing how to create a new project from a cloned repository." border="false" lightbox="media/quickstart-python-team-explorer-new-project.png":::

1. In the **Create a new project** dialog, set the **Language** filter to **Python** (or search for _python_), select the **From Existing Python Code** template, and select **Next**.

1. In the **Configure your new project** dialog, enter a project **Name**, set the **Location** to the same folder as the repository, and select **OK**. The **Create New Project from Existing Python Code** wizard opens.

1. In the wizard, select **Finish**.

::: moniker-end

## Configure project properties 

To run the project, you need to identify the working directory for the project, and let Visual Studio know which file to use as the **Startup File**.

Follow these steps to configure your project properties:

1. In **Solution Explorer**, expand the project node, right-click the _contemplate\_koans.py_ file, and select **Set as Startup File**. This action lets Visual Studio know which file to use to run the project.

1. On the main Visual Studio toolbar, select **Project** > **Properties** to open the properties for the project.

1. On the **General** tab, observe the value of the **Working Directory** for the project.

   By default, Visual Studio sets the **Working Directory** to the project root (`.`). Notice that the **Startup File** has no specific folder location.

   :::image type="content" source="media/quickstart-python-working-directory.png" alt-text="Screenshot that shows the current working directory for the Python project set to the project root." border="false" lightbox="media/quickstart-python-working-directory.png":::
   
   The cloned program code looks for a file named _koans.txt_ in the working directory. The code expects the directory to be the folder location where you instructed Visual Studio to store the cloned repository files. If you leave the **Working Directory** set to the project root (`.`), the program generates runtime errors.

1. Set the value of the **Working Directory** to the folder location of the cloned repository, such as `C:\Users\contoso\source\repos\Python-Koans`.

   > [!TIP]
   > A quick way to confirm the folder location for the cloned files is to check the properties for the cloned file in **Solution Explorer**. Right-click the _koans.txt_ file and select **Properties** to open the details pane under **Solution Explorer**. In the details pane, notice that the folder location for the file is listed in the **Full path** property. You can paste this value into the **Working Directory** field in the project **Properties** page.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/quickstart-python-full-path-property.png" alt-text="Screenshot that shows how to set the Working Directory for the project with the Full Path property value for a cloned file." border="false" lightbox="media/vs-2022/quickstart-python-full-path-property.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   :::image type="content" source="media/quickstart-python-projects-set-working-directory.png" alt-text="Screenshot that shows how to set the working directory for a Python project." border="false" lightbox="media/quickstart-python-projects-set-working-directory.png":::

   ::: moniker-end

1. Save your changes and close the project **Properties** pane.

## Run Python program

Now you're ready to try running the application for the new project:

1. Select **Debug** > **Start without Debugging** (or use the keyboard shortcut **Ctrl**+**F5**) to run the program.

   If you see a **FileNotFoundError** runtime error for the _koans.txt_ file, confirm the **Working Directory** is set correctly, as described in the [previous section](#configure-project-properties).

1. When the program runs successfully, it displays an assertion error on line 17 of the project file _/koans/about\_asserts.py_:

   :::image type="content" source="media/quickstart-python-initial-program-output.png" alt-text="Screenshot that shows the initial output from the Python koans program that produces an assertion error in the about_asserts file." lightbox="media/quickstart-python-initial-program-output.png":::

   The assertion error is intentional. The program is designed to teach Python by having you correct all the intentional errors. You can find more information about the program at [Ruby Koans](https://rubykoans.com/), which inspired Python Koans.

1. Exit the program.

1. In **Solution Explorer**, double-click the _/koans/about\_asserts.py_ file to open the file in the editor:

   :::image type="content" source="media/quickstart-python-open-about-asserts.png" alt-text="Screenshot that shows how to open the about_asserts file in Visual Studio." border="false" lightbox="media/quickstart-python-open-about-asserts.png":::

   ::: moniker range=">=vs-2022"

   By default, line numbers don't appear in the editor. To see the line numbers, select **Tools** > **Options**, expand the **Text Editor** > **Python** > **General** section, and select the **Line numbers** option:

   :::image type="content" source="media/vs-2022/quickstart-python-enable-line-numbers.png" alt-text="Screenshot that shows how to enable line numbering in the editor with the Text Editor Python General Line numbers option." border="false" lightbox="media/vs-2022/quickstart-python-enable-line-numbers.png":::

   ::: moniker-end
   ::: moniker range="<=vs-2019"

   By default, line numbers don't appear in the editor. To see the line numbers, select **Tools** > **Options**, and select **Show all settings** at the bottom of the dialog. Expand the **Text Editor** > **Python** > **General** section and select the **Line numbers** option:

   :::image type="content" source="media/options-general-line-numbers.png" alt-text="Screenshot that shows how to turn on line numbers for Python code files." border="false" lightbox="media/options-general-line-numbers.png":::

   ::: moniker-end

1. Correct the error in the _/koans/about\_asserts.py_ file by changing the `False` argument on line 17 to `True`. Here's what the updated code should look like:

   ```python
   self.assertTrue(True) # This value should be True
   ```

1. Run the program again.

   If Visual Studio warns about errors, respond with **Yes** to continue running the code. This time, the program passes through the first check and stops on the next koan. You can continue to correct further errors and run the program to see the adjustments.

## Related content

- [Clone a Git repository in Visual Studio](../version-control/git-clone-repository.md)
- [Create a Git repository from Visual Studio](../version-control/git-create-repository.md)
- [Tutorial: Work with Python in Visual Studio](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)

---
title: Manage Python package dependencies
description: Use the pip freeze > requirements.txt command and manage your Python package dependencies for application development in Visual Studio.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to explore options for managing my Python package dependencies so that I can ensure my Python application works as expected.

---
# Manage required Python packages with requirements.txt

If you share your Python project with others, or use a build system to produce your Python application, you need to specify any required external packages. When you plan to copy your project to other locations where you need to restore an environment, you also need to define the required dependent packages.

The recommended approach for specifying external dependent Python packages is to use a [requirements file](https://pip.readthedocs.org/en/latest/user_guide.html#requirements-files) (readthedocs.org). This file contains a list of pip commands that install any required versions of dependent packages for your project. The most common command is `pip freeze > requirements.txt`. This command records your environment's current package list into the `requirements.txt` file.

A requirements file contains precise versions of all installed packages. You can use requirements files to freeze the requirements of an environment. By using precise package versions, you can easily reproduce your environment on another computer. The requirements files include packages even if they're installed with a version range, as a dependency of another package, or with an installer other than pip.

## Prerequisites 

- Visual Studio installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

- A requirements file. You can use an existing requirements file or [generate a file](#generate-the-requirementstxt-file) as described in this article.

Technically, any filename can be used to track requirements. However, Visual Studio provides specific support for the requirements file named "requirements.txt." You can use the `-r <full path to file>` argument when you install a package to specify your preferred name for the file.

## Install dependencies listed in requirements.txt

If you load a project that has a `requirements.txt` file, you can install all the package dependencies listed in the file.

1. In **Solution Explorer**, expand the project, and then expand the **Python Environments** node.

1. Locate the environment node that you want to install the packages for. Right-click the node, and select **Install from requirements.txt**.

   :::moniker range="<=vs-2019"

   :::image type="content" source="media/environments/environments-requirements-txt-install-2019.png" alt-text="Screenshot that shows how to install Python packages from a requirements text file in Visual Studio 2019." border="false" lightbox="media/environments/environments-requirements-txt-install-2019.png":::

   :::moniker-end
   :::moniker range=">=vs-2022"

   :::image type="content" source="media/environments/environments-requirements-txt-install-2022.png" alt-text="Screenshot that shows how to install Python packages from a requirements text file in Visual Studio 2022." border="false" lightbox="media/environments/environments-requirements-txt-install-2022.png":::

   :::moniker-end

1. You can monitor the package installation process in the **Output** window:

   :::image type="content" source="media/environments/environments-requirements-txt-install-output.png" alt-text="Screenshot that shows the output from the installation of the Python packages from a requirements text file." border="false" lightbox="media/environments/environments-requirements-txt-install-output.png":::

   The output lists any required packages that are installed, along with any updates required for affected pip commands and the availability of newer pip versions.

## Install dependencies in a virtual environment

You can also install the Python package dependencies in an existing virtual environment.

1. In **Solution Explorer**, expand your project, and then expand the **Python Environments** node.

1. Locate the virtual environment node that you want to install the packages for. Right-click the node, and select **Install from requirements.txt**.

If you need to create a virtual environment, see [Use virtual environments](selecting-a-python-environment-for-a-project.md#use-virtual-environments).

## Generate the requirements.txt file

If all the necessary Python packages for your project are already installed in an environment, you can generate the `requirements.txt` file in Visual Studio.

1. In **Solution Explorer**, expand your project, and then expand the **Python Environments** node.

1. Locate the environment node for which you want to generate the requirements file. Right-click the node, and select **Generate requirements.txt**.

   :::moniker range="<=vs-2019"

   :::image type="content" source="media/environments/environments-requirements-txt-generate-2019.png" alt-text="Screenshot that shows how to generate a requirements text file for Python package dependencies in Visual Studio 2019." border="false" lightbox="media/environments/environments-requirements-txt-generate-2019.png":::

   :::moniker-end
   :::moniker range=">=vs-2022"

   :::image type="content" source="media/environments/environments-requirements-txt-generate-2022.png" alt-text="Screenshot that shows how to generate a requirements text file for Python package dependencies in Visual Studio 2022." border="false" lightbox="media/environments/environments-requirements-txt-generate-2022.png":::

   :::moniker-end

## Refresh or add entries to an existing requirements.txt file

If the `requirements.txt` file already exists, Visual Studio displays a prompt with several options:

:::image type="content" source="media/environments/environments-requirements-txt-replace.png" alt-text="Screenshot of the prompt displayed when the requirements text file already exists, with options to update or add entries, or replace the file." border="false" lightbox="media/environments/environments-requirements-txt-replace.png":::

- **Replace entire file**: Overwrite all items, comments, and options defined in the `requirements.text` file.
- **Refresh existing entries**: Update the version specifiers in the `requirements.text` file to match the currently installed version.
- **Update and add entries**: Refresh existing requirements in the `requirements.text` file, and append all new package requirements to the end of the file.

Visual Studio runs `pip` to detect the current package requirements for the environment, and then updates your `requirements.txt` file based on your selection.

## Manually install package dependencies

If pip doesn't install a package dependency defined in your `requirements.txt` file, the entire installation fails.

You have two options to address this issue:

- Manually edit the `requirements.txt` file to exclude the failed package, and then rerun the installation process.

- Use [pip command options](https://pip.readthedocs.org/en/latest/reference/pip_install.html#requirements-file-format) to refer to an installable version of the package.

### Update the requirements file with pip wheel

If you use the [`pip wheel`](https://pip.readthedocs.org/en/latest/reference/pip_wheel.html) command to compile a dependency, you can add the `--find-links <path>` option to your `requirements.txt` file.

1. Call the `pip wheel` command to compile the list of required dependencies:

   ```console
   pip wheel azure
   ```

   The output shows the wheels built for the collected packages:

   ```output
   Downloading/unpacking azure
       Running setup.py (path:C:\Project\env\build\azure\setup.py) egg_info for package azure

   Building wheels for collected packages: azure
       Running setup.py bdist_wheel for azure
       Destination directory: c:\project\wheelhouse
   Successfully built azure
   Cleaning up...
   ```

1. Append the `find-links` and `no-index` options, along with the package version requirement to your `requirements.txt` file:

   ```console
   type requirements.txt
   --find-links wheelhouse
   --no-index
   azure==0.8.0
   ```

1. Run the pip install process with your updated requirements file:

   ```console
   pip install -r requirements.txt -v
   ```

   The output tracks progress for the installation process:

   ```output
   Downloading/unpacking azure==0.8.0 (from -r requirements.txt (line 3))
       Local files found: C:/Project/wheelhouse/azure-0.8.0-py3-none-any.whl
   Installing collected packages: azure
   Successfully installed azure
   Cleaning up...
       Removing temporary dir C:\Project\env\build...
   ```

## Related content

- [Manage Python environments in Visual Studio](managing-python-environments-in-visual-studio.md)
- [Select an interpreter for a project](selecting-a-python-environment-for-a-project.md)
- [Search paths](search-paths.md)
- [Python Environments window reference](python-environments-window-tab-reference.md)

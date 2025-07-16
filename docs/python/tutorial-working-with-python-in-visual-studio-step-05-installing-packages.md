---
title: Python in Visual Studio tutorial Step 5, install packages
titleSuffix: ""
description: Step 5 of a core walkthrough of Python capabilities in Visual Studio that shows Visual Studio features to manage and install packages in a Python environment.
ms.date: 04/18/2024
ms.topic: tutorial
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to manage and install packages for Python in Visual Studio so I can manage my Python environments.
---

# Tutorial: Install packages in your Python environment in Visual Studio

This article presents Step 5 in the tutorial series _Work with Python in Visual Studio_.

All code in a Python project runs within the context of a specific environment. Examples of environments include a global environment, a virtual environment, a conda environment, and so on. The environment is used for any tasks that require language services that are specific to the Python version and a set of installed packages. Each environment requires certain installed packages based on the project code.

The Python developer community produces thousands of useful packages that you can incorporate into your own projects. In Step 5 of this tutorial series, you use the **Python Environments** window in Visual Studio to manage packages in your Python environments.

In Step 5 of the tutorial, you learn how to:

> [!div class="checklist"]
> - View Python environments and packages in Visual Studio
> - Install and manage packages for Python environments
> - Test Python code with installed packages

## Prerequisites

- A Python application project that has a Python file (_.py_) with code created in [Step 2: Write and run Python code](tutorial-working-with-python-in-visual-studio-step-02-writing-code.md).

## View Python environments in Visual Studio

Visual Studio provides two places to view information about Python environments:

- The **Python Environments** _node_ in **Solution Explorer** lists environments currently in use by your project. If you have more than one environment for a project, Visual Studio shows the active environment in bold. You can expand a specific environment to see the set of installed packages. When an environment is active, you can import its installed packages and use them in your code.

   :::moniker range=">=vs-2022"

   :::image type="content" source="media/python-environments-node-2022.png" alt-text="Screenshot that shows the Python Environments node in Solution Explorer in Visual Studio 2022." border="false" lightbox="media/python-environments-node-2022.png":::

   :::moniker-end
   :::moniker range="<=vs-2019"

   :::image type="content" source="media/python-environments-node-2019.png" alt-text="Screenshot that shows the Python Environments node in Solution Explorer in Visual Studio 2019." border="false" lightbox="media/python-environments-node-2019.png":::

   :::moniker-end

- The **Python Environments** _window_ displays all available environments and their installed packages. You can view environments installed by using the Visual Studio Installer and environments installed separately. The available environments include global, virtual, and conda environments. Visual Studio shows the default Python environment for new projects in bold.

   :::moniker range=">=vs-2022"

   :::image type="content" source="media/environments/environments-default-view-2022.png" alt-text="Screenshot that shows the Python Environments window in Visual Studio 2022." border="false" lightbox="media/environments/environments-default-view-2022.png":::

   :::moniker-end
   :::moniker range="<=vs-2019"

   :::image type="content" source="media/environments/environments-default-view-2019.png" alt-text="Screenshot that shows the Python Environments window in Visual Studio 2019." border="false" lightbox="media/environments/environments-default-view-2019.png":::

   :::moniker-end

Use one of the following methods to open the **Python Environments** window:

- To access the window from the main toolbar in Visual Studio, select **View** > **Other Windows** > **Python Environments**.

- If you have a Python project open in **Solution Explorer**, right-click the **Python Environments** node under the project, and select **View All Python Environments**:

   :::moniker range=">=vs-2022"

   :::image type="content" source="media/environments/environments-view-all-2022.png" alt-text="Screenshot that shows how to open the Python Environments window with right-click in Visual Studio." border="false" lightbox="media/environments/environments-view-all-2022.png":::

   :::moniker-end
   :::moniker range="<=vs-2019"

   :::image type="content" source="media/environments/environments-view-all-2019.png" alt-text="Screenshot that shows how to open the Python Environments window with right-click in Visual Studio 2019." border="false" lightbox="media/environments/environments-view-all-2019.png":::

   :::moniker-end

   You can also use the **Ctrl+K, Ctrl+`** keyboard shortcut to open the **Python Environments** window from **Solution Explorer**. 

## Prepare the Python file

To prepare for the exercise, follow these steps to update your Python project file to include the necessary code:

1. Open your Python project file (_.py_) in the editor. (Tutorial Step 2 explains how to create this file, where the default file name is _PythonApplication1.py_.)

1. Replace the code in the file with the following code. This version of the code creates a cosine wave similar to the output from tutorial Step 4, but it plots the output graphically.

   ```python
   from math import radians
   import numpy as np                # installed with matplotlib
   import matplotlib.pyplot as plt

   def main():
      x = np.arange(0, radians(1800), radians(12))
      plt.plot(x, np.cos(x), 'b')
      plt.show()

   main()
   ```

1. In the editor, hover over the `matplotlib` import statement. Visual Studio uses special formatting to indicate the statement is unresolved. 

   :::moniker range=">=vs-2022"

   :::image type="content" source="media/packages-unresolved-import-2022.png" alt-text="Screenshot that shows how Visual Studio 2022 uses special formatting to indicate that the matplotlib import statement is unresolved." border="false" lightbox="media/packages-unresolved-import-2022.png":::

   :::moniker-end
   :::moniker range="<=vs-2019"

   :::image type="content" source="media/packages-unresolved-import-2019.png" alt-text="Screenshot that shows how Visual Studio 2019 uses special formatting to indicate that the matplotlib import statement is unresolved." border="false" lightbox="media/packages-unresolved-import-2019.png":::

   :::moniker-end

   The `matplotlib` import statement is unresolved because the necessary packages aren't installed to the default global environment. You learn how to install the required packages in the next section.

## Install packages for the Python environment

To resolve the `matplotlib` import statement, you need to install the necessary packages to the default global environment:

1. In the **Python Environments** window, select the default environment for new Python projects, then select **Packages (PyPI)** in the dropdown menu. (PyPI is the acronym for the Python Package Index.)

   :::moniker range=">=vs-2022"

   :::image type="content" source="media/packages-installed-2022.png" alt-text="Screenshot that shows how to select the Packages PyPI option for the selected environment to see the installed packages." border="false" lightbox="media/packages-installed-2022.png":::

   :::moniker-end

   Visual Studio shows the list of packages currently installed in the default environment.

1. In the **Search** field, enter `matplotlib`. In the results list, select the **Run command: pip install matplotlib** option.

   :::moniker range=">=vs-2022"

   :::image type="content" source="media/packages-install-matplotlib-2022.png" alt-text="Screenshot that shows how to install the matplotlib library for the selected environment in the Python Environments window in Visual Studio 2022." border="false" lightbox="media/packages-install-matplotlib-2022.png":::

   :::moniker-end
   :::moniker range="<=vs-2019"

   :::image type="content" source="media/packages-install-matplotlib-2019.png" alt-text="Screenshot that shows how to install the matplotlib library for the selected environment in the Python Environments window in Visual Studio 2019." border="false" lightbox="media/packages-install-matplotlib-2019.png":::

   :::moniker-end

   The command installs the `matplotlib` library, and also any packages it depends on. In this case, the dependent packages include the `numpy` library.

   You can open the **View** > **Output** window to monitor the progress of the installation.

1. After the packages install, the **Python Environments** window refreshes to show the packages for the selected environment:

   :::moniker range=">=vs-2022"

   :::image type="content" source="media/packages-matplotlib-numpy-2022.png" alt-text="Screenshot that shows the newly installed matplotlib and numpy packages for the selected environment in the Python Environments window in Visual Studio." border="false" lightbox="media/packages-matplotlib-numpy-2022.png":::

   :::moniker-end
   :::moniker range="<=vs-2019"

   :::image type="content" source="media/packages-matplotlib-2019.png" alt-text="Screenshot that shows the newly installed matplotlib and numpy packages for the selected environment in the Python Environments window in Visual Studio 2019." border="false" lightbox="media/packages-matplotlib-2019.png":::

   :::moniker-end

   The **X** to the right of the package uninstalls it.

## Run the program

Now that the [matplotlib](https://matplotlib.org/) library is installed, you're ready to test your program.

1. Run your program with debugging (**F5**) or without the **Debugger** (**Ctrl**+**F5**).

1. Check the program output. You should see a plot graph of the cosine data:

   :::image type="content" source="media/matplotlib-graph.png" alt-text="Screenshot that shows the program output, which uses code in the Python matplotlib library package." border="false" lightbox="media/matplotlib-graph.png":::

## Next step

> [!div class="nextstepaction"]
> [Step 6: Work with Git](tutorial-working-with-python-in-visual-studio-step-06-working-with-git.md)

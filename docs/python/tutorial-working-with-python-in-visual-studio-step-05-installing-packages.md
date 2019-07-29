---
title: Python in Visual Studio tutorial step 5, install packages
titleSuffix: ""
description: Step 5 of a core walkthrough of Python capabilities in Visual Studio, demonstrating Visual Studio's features for managing packages in a Python environment.
ms.date: 01/28/2019
ms.topic: tutorial
author: JoshuaPartlow
ms.author: joshuapa
manager: jillfra
ms.custom: seodec18
ms.workload:
  - python
  - data-science
---

# Step 5: Install packages in your Python environment

**Previous step: [Run code in the debugger](tutorial-working-with-python-in-visual-studio-step-04-debugging.md)**

The Python developer community has produced thousands of useful packages that you can incorporate into your own projects. Visual Studio provides a UI to manage packages in your Python environments.

1. Select the **View** > **Other Windows** > **Python Environments** menu command. The **Python Environments** window opens as a peer to **Solution Explorer** and shows the different environments available to you. The list includes both environments that you installed using the Visual Studio installer and those you installed separately. The environment in bold is the default environment that's used for new projects.

   ![Python Environments window](media/environments/environments-default-view-blue.png)

2. The environment's **Overview** tab provides quick access to an **Interactive** window for that environment along with the environment's installation folder and interpreters. For example, select **Open interactive window** and an **Interactive** window for that specific environment appears in Visual Studio.

3. Select the **Packages** tab and you see a list of packages that are currently installed in the environment.

   ![Packages installed in an environment](media/environments/environments-installed-packages-blue.png)

4. Install `matplotlib` by entering its name into the search field, then select the **pip install**

   ![Installing matplotlib in the environment](media/environments/environments-add-matplotlib1.png)

5. Consent to elevation if prompted to do so.

6. After the package is installed, it appears in the **Python Environments** window. The **X** to the right of the package uninstalls it.

   ![Completion of installing matplotlib in the environment](media/environments/environments-add-matplotlib2.png)

   A small progress bar may appear underneath the environment to indicate that Visual Studio is building its IntelliSense database for the newly-installed package. The **IntelliSense** tab also shows more detailed information. Note that until that database is complete, IntelliSense features like auto-completion and syntax checking won't be active in the editor for that package.

   Note that Visual Studio 2017 version 15.6 and later uses a different and faster method for working with IntelliSense, and displays a message to that effect on the **IntelliSense** tab.

7. Create a new project with **File** > **New** > **Project**, selecting the **Python Application** template. In the code file that appears, paste the following code, which creates a cosine wave like the previous tutorial steps, only this time plotted graphically:

    ```python
    from math import radians
    import numpy as np     # installed with matplotlib
    import matplotlib.pyplot as plt

    def main():
        x = np.arange(0, radians(1800), radians(12))
        plt.plot(x, np.cos(x), 'b')
        plt.show()

    main()
    ```

8. Run the program with (**F5**) or without the debugger (**Ctrl**+**F5**) to see the output:

   ![Output of matplotlib example](media/environments/environments-add-matplotlib3.png)

## Next step

> [!div class="nextstepaction"]
> [Work with Git](tutorial-working-with-python-in-visual-studio-step-06-working-with-git.md)

## Go deeper

- [Python environments](managing-python-environments-in-visual-studio.md)

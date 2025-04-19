---
title: Use IPython REPL in the Interactive Window
description: Use the Visual Studio Interactive Window in IPython mode for a user-friendly interactive development environment with Interactive Parallel Computing features.
ms.date: 04/18/2024
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to use IPython REPL in the Interactive Window to develop Python applications in Visual Studio.
---

# Use IPython in the Interactive Window in Visual Studio

The Visual Studio **Interactive Window** in IPython mode is an advanced yet user-friendly interactive development environment that has Interactive Parallel Computing features. This article explains how to use IPython in the Visual Studio **Interactive Window** and access standard [Interactive Window](python-interactive-repl-in-visual-studio.md) features.

## Prerequisites 

- Visual Studio on Windows installed with support for Python workloads. For more information, see [Install Python support in Visual Studio](installing-python-support-in-visual-studio.md).

   Visual Studio for Mac isn't supported. For more information, see [What's happening to Visual Studio for Mac?](/visualstudio/mac/what-happened-to-vs-for-mac) Visual Studio Code on Windows, Mac, and Linux [works well with Python through available extensions](https://code.visualstudio.com/docs/languages/python).

- The Python installation must include the IPython, numpy, and matplotlib libraries. You can install these libraries by using the Package installer in Visual Studio, as described in [Tutorial: Install packages in your Python environment in Visual Studio](tutorial-working-with-python-in-visual-studio-step-05-installing-packages.md).

> [!NOTE]
> IronPython doesn't support IPython, despite the fact that you can select this option on the **Interactive Options** form. For more information, see the [Feature request (Support IPython when interp is IronPython)](https://github.com/Microsoft/PTVS/issues/84).

## Work with the Interactive Window

The following steps show you how to use IPython commands in the Interactive Window. This walkthrough assumes you're using Anaconda.

1. In Visual Studio, select **View** > **Other Windows** > **Python Environments** to open the **Python Environments** window.

1. In the **Python Environments** window, select an Anaconda environment.

1. Switch to the **Packages** view for the environment to see the installed packages. In the dropdown menu, select **Packages (Conda)**. The menu option might be named **pip** or **Packages**.

1. Confirm that the `ipython` and `matplotlib` libraries are installed for the environment.

   If both libraries aren't installed, follow the instructions in [Tutorial: Install packages in your Python environment in Visual Studio](tutorial-working-with-python-in-visual-studio-step-05-installing-packages.md). For more information, see [Python Environments window - Packages tabs reference](./python-environments-window-tab-reference.md#packages-tab).

1. Switch to the **Overview** view for the environment and select the **Use IPython interactive mode** option.

1. Select **Open interactive window** to show the **Interactive Window** in IPython mode. You might need to reset the window if the window was already open.
   
1. When the **Interactive Window** opens, you should see the first prompt `In [1]`. If you see the standard prompt `>>>`, enter return at the prompt to ensure the window is using IPython mode. The prompt should change to something like `In [2]`.

   :::image type="content" source="media/ipython-repl-03.png" alt-text="Screenshot that shows the Interactive Window in IPython mode in Visual Studio." border="false" lightbox="media/ipython-repl-03.png":::

1. Enter the following code:

   ```python
   import matplotlib.pyplot as plt
   import numpy as np

   x = np.linspace(0, 5, 10)
   y = x ** 2
   plt.plot(x, y, 'r', x, x ** 3, 'g', x, x ** 4, 'b')
   ```

1. After you enter the last line of code and select **Enter**, you should see an inline graph:

   :::image type="content" source="media/ipython-repl-04.png" alt-text="Screenshot that shows an inline graph in the Interactive Window in IPython mode in Visual Studio." border="false" lightbox="media/ipython-repl-04.png":::

   You can resize the graph by dragging on the lower right-hand corner.

1. Rather than entering code directly in the **Interactive Window**, you can write code in the Visual Studio editor and send it to the **Interactive Window**:

   1. Paste the following code into a new file in the editor.
   
   1. Use the keyboard shortcut **Ctrl**+**A** to select the code in the editor.
   
   1. Right-click the selected code and choose **Send to Interactive**. You can also use the keyboard shortcut **Ctrl**+**Enter**.
   
   Visual Studio sends the code as a single block to the **Interactive Window** to avoid an intermediate or partial graph.
   
   (If you don't have a Python project open with a specific active environment, Visual Studio opens an **Interactive Window** for the default environment listed in the **Python Environments** window.)

    ```python
    from mpl_toolkits.mplot3d import Axes3D
    import matplotlib.pyplot as plt
    import numpy as np
    fig = plt.figure()
    ax = fig.add_subplot(111, projection='3d')
    for c, z in zip(['r', 'g', 'b', 'y'], [30, 20, 10, 0]):
        xs = np.arange(20)
        ys = np.random.rand(20)
        # You can provide either a single color or an array. To demonstrate this,
        # the first bar of each set is colored cyan.
        cs = [c] * len(xs)
        cs[0] = 'c'
        ax.bar(xs, ys, zs=z, zdir='y', color=cs, alpha=0.8)

    ax.set_xlabel('X')
    ax.set_ylabel('Y')
    ax.set_zlabel('Z')
    plt.show()
    ```

   :::image type="content" source="media/ipython-repl-05.png" alt-text="Screenshot that shows how to send code from the Visual Studio editor to the Interactive Window." border="false" lightbox="media/ipython-repl-05.png":::

1. To view the graphs outside of the **Interactive Window**, run the code with the **Debug** > **Start without Debugging** command on the main Visual Studio toolbar.

IPython has many other useful features, such as escaping to the system shell, variable substitution, capturing output, and so on. For more information, see the [IPython documentation](https://ipython.org/documentation.html).

## Related content

- [Work with the Python Interactive Window in Visual Studio](./python-interactive-repl-in-visual-studio.md)
- [Tutorial: Use the Interactive REPL window in Visual Studio](./tutorial-working-with-python-in-visual-studio-step-03-interactive-repl.md)

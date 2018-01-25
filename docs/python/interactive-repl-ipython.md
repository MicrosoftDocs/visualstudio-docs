---
title: IPython REPL in Visual Studio | Microsoft Docs
ms.custom: ""
ms.date: 07/13/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-python"
ms.devlang: python
ms.tgt_pltfrm: ""
ms.topic: "article"
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "python"
  - "data-science"
---

# Using IPython in the Interactive Window

The Visual Studio interactive window in IPython mode is an advanced yet user-friendly interactive development environment that has Interactive Parallel Computing features. This topic walks through using IPython in the Visual Studio interactive window, in which all of the regular [interactive window](interactive-repl.md) features are also available.

For this walkthrough you should have the [Anaconda](https://www.continuum.io) environment installed, which includes IPython and the necessary libraries.

> [!Note]
> IronPython does not support IPython, despite the fact that you can select it on the Interactive Options form. FOr more information see the [feature request](https://github.com/Microsoft/PTVS/issues/84).

1. Open Visual Studio, switch to the Python Environments window (**View > Other Windows > Python Environments**), and select the Python environment that appeared when you started IPython.

1. Look at the **Packages** (or **pip**) tab and ensure that `IPython` and `matplotlib` are listed. If not, install them here.

1. Select the **Overview** tab and select **Use IPython interactive mode.** (In Visual Studio 2015, select **Configure interactive options** to open the **Options** dialog, then set **Interactive Mode** to IPython, and select **OK**).

1. Select **Open interactive window** to bring up the interactive window in IPython mode. You may need to reset the window if you have just changed the interactive mode; you might also need to press Enter if only a >>> prompt appears.

    ![The interactive window in IPython mode](media/ipython-repl-03.png)

1. Enter the following code:

  ```python
  x = linspace(0, 5, 10)
  y = x ** 2
  plot(x, y, 'r', x, x ** 3, 'g', x, x ** 4, 'b')
  ```

1. After entering the last line, you should see an inline graph (which you can resize by dragging on the lower right-hand corner) if desired.

    ![Inline graph in the interactive window](media/ipython-repl-04.png)

1. Instead of typing in the REPL, you can instead write code in the editor, select it, right-click, and select the **Send to interactive** command (or press Ctrl-Enter). Try pasting the code below into a new file in the editor, selecting it with Ctrl-A, then sending to the interactive window. (Note that Visual Studio sends the code as one unit to avoid giving you intermediate or partial graphs. Also note that if you don't have a Python project open with a different environment selected, Visual Studio opens an interactive window for whatever environment is selected as your default in the **Python Environments** window.)

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
        # the first bar of each set will be colored cyan.
        cs = [c] * len(xs) 
        cs[0] = 'c' 
        ax.bar(xs, ys, zs=z, zdir='y', color=cs, alpha=0.8)

    ax.set_xlabel('X') 
    ax.set_ylabel('Y') 
    ax.set_zlabel('Z') 
    plt.show()
    ```

    ![Sending code from the editor to the interactive window](media/ipython-repl-05.png)

1. To see the graphs outside of the interactive window, run the code instead using the **Debug > Start without Debugging** command.

IPython has many other useful features such as escaping to the system shell, variable substitution, capturing output, etc. Refer to the [IPython documentation](http://ipython.org/documentation.html) for more.

## Related topics

- To use Jupyter easily and without installation, try the free [Azure Notebooks hosted service](https://notebooks.azure.com/) that lets you keep and share your notebooks with others.

- You can also run Jupyter (formerly known as IPython) on your own Windows or Linux virtual machine on Azure. For details, see [Creating an Azure VM. installing Jupyter, and running Jupyter Notebook on Azure](/azure/virtual-machines/virtual-machines-linux-jupyter-notebook).

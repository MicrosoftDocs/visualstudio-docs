---
title: Python in Visual Studio tutorial step 0, installation
titleSuffix: ""
description: Step 0 (installation prerequisites) of a core walkthrough of working with Python in Visual Studio.
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

# Install Python support in Visual Studio

> [!Note]
> Python support is presently available only on Visual Studio for Windows; on Mac and Linux, Python support is available through [Visual Studio Code](https://code.visualstudio.com/docs/python/python-tutorial).

1. Download and run the latest Visual Studio installer for Windows (Python support is present in release 15.2 and later). If you have Visual Studio installed already, run the Visual Studio installer and go to step 2.

    > [!div class="nextstepaction"]
    > [Install Visual Studio Community](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Community&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_gettingstarted)

    >[!Tip]
    > The Community edition is for individual developers, classroom learning, academic research, and open source development. For other uses, install [Visual Studio Professional](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Professional&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_gettingstarted) or [Visual Studio Enterprise](https://visualstudio.microsoft.com/thank-you-downloading-visual-studio/?sku=Enterprise&rel=15&rid=34347&utm_source=docs&utm_medium=clickbutton&utm_campaign=python_gettingstarted).

1. The installer presents you with a list of workloads, which are groups of related options for specific development areas. For Python, select the **Python development** workload and select **Install**:

    ![Python development workload in the Visual Studio installer](media/installation-python-workload.png)

1. To quickly test Python support, launch Visual Studio, press **Alt**+**I** to open the **Python Interactive** window, and enter `2+2`. If you don't see the output of **4**, recheck your steps.

    ![Testing Python through the interactive window](media/installation-interactive-test.png)

## Next step

> [!div class="nextstepaction"]
> [Step 1: Create a Python project](tutorial-working-with-python-in-visual-studio-step-01-create-project.md)

## See also

- [Manually identify an existing Python interpreter](managing-python-environments-in-visual-studio.md#manually-identify-an-existing-environment)
- [Install Python support in Visual Studio 2015 and earlier](installing-python-support-in-visual-studio.md)
- [Install locations](installing-python-support-in-visual-studio.md#install-locations)

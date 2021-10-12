## Prerequisites

::: moniker range=">=vs-2019"

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) installed with the appropriate workloads for your language of choice:
  * ASP.NET: **ASP.NET and web development**
  * Python: **Python development**
  * Node.js: **Node.js development**
::: moniker-end
::: moniker range="vs-2017"
* [Visual Studio 2017](https://visualstudio.microsoft.com/vs/older-downloads/?utm_medium=microsoft&utm_source=docs.microsoft.com&utm_campaign=vs+2017+download) installed with the appropriate workloads for your language of choice:
  * ASP.NET: **ASP.NET and web development**
  * Python: **Python development**
  * Node.js: **Node.js development**
::: moniker-end

* An ASP.NET, ASP.NET Core, Python, or Node.js project. If you don't already have a project, select an option below:
  * ASP.NET Core: Follow [Quickstart: Use Visual Studio to create your first ASP.NET Core web app](../../ide/quickstart-aspnet-core.md), or use the following steps:
    ::: moniker range=">=vs-2019"
    In Visual Studio 2019, choose **Create a new project** in the start window. If the start window is not open, choose **File** > **Start Window**. Type **web app** in the search box, choose **C#** as the language, then choose **ASP.NET Core Web Application (Model-View-Controller)**, and then choose **Next**. On the next screen, name the project **MyASPApp**, and then choose **Next**.

    Choose either the recommended target framework or .NET 6, and then choose **Create**.
    ::: moniker-end
    ::: moniker range="vs-2017"
    In Visual Studio 2017, choose **File** > **New Project**, select **Visual C#** > **.NET Core**, then select **ASP.NET Core Web Application**. When prompted, select the **Web Application (Model-View-Controller)** template, make sure that **No Authentication** is selected, and then select **OK**.
    ::: moniker-end
  * Python: Follow [Quickstart: Create your first Python web app using Visual Studio](../../ide/quickstart-python.md), or use **File** > **New Project**, select **Python**, then select **Flask Web Project**.
  * Node.js: Follow [Quickstart: Use Visual Studio to create your first Node.js app](../../ide/quickstart-nodejs.md), or use **File** > **New Project**, select **JavaScript**, then select **Blank Node.js Web Application**.

* Make sure you build the project using the **Build > Build Solution** menu command before following the deployment steps.
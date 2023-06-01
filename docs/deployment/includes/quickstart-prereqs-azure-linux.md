## Prerequisites

::: moniker range=">=vs-2019"

* [Visual Studio 2019](https://visualstudio.microsoft.com/downloads) installed with the appropriate workloads for your language of choice:
  * ASP.NET: **ASP.NET and web development**
::: moniker-end


* An Azure subscription. If you do not already have subscription, [sign up for free](https://azure.microsoft.com/free/dotnet/), which includes $200 in credit for 30 days and 12 months of popular free services.

* ASP.NET Core: Follow [Quickstart: Use Visual Studio to create your first ASP.NET Core web app](../../ide/quickstart-aspnet-core.md), or use the following steps:
  ::: moniker range=">=vs-2019"
  In Visual Studio 2019, choose **Create a new project** in the start window. If the start window is not open, choose **File** > **Start Window**. Type **web app** in the search box, choose **C#** as the language, then choose **ASP.NET Core Web Application (Model-View-Controller)**, and then choose **Next**. On the next screen, name the project **MyASPApp**, and then choose **Next**.

  Choose either the recommended target framework or .NET 6, and then choose **Create**.
  ::: moniker-end


* Make sure you build the project using the **Build > Build Solution** menu command before following the deployment steps.
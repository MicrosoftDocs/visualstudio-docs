---
title: Sign in 
description: Sign in to Visual Studio to Extend the Visual Studio trial period, Unlock Visual Studio, and more
ms.custom: "contperf-fy21q1"
ms.date: 12/10/2021
ms.topic: how-to
ms.assetid: b9531c25-e4cf-43ae-b331-a9f31a8cd171
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Sign in to Visual Studio on Windows 

In this article, you'll learn:
+ [The benefits to account sign in](#benefits)
+ How to [sign in](#sign-in) with an account
+ How to [update your profile](#update-your-profile)

::: moniker range="vs-2017"

> [!WARNING]
> To work with resources configured for conditional access or multi-factor authentication, you need Visual Studio 2019 Update 16.6 or later. Earlier versions may trigger a degraded authentication experience, prompting reauthentication several times within the same Visual Studio session. 

::: moniker-end

<a name="benefits"></a>
## Benefits: why sign in? 

While you don't have to sign in, there are many advantages to doing so.   

|Benefit|Description|
|---|---|
|[Extend your Visual Studio trial period](../ide/how-to-unlock-visual-studio.md)|Use Visual Studio Professional or Visual Studio Enterprise **for an additional 90 days**, instead of being limited to the trial period of 30 days.|
|[Unlock Visual Studio](../ide/how-to-unlock-visual-studio.md)|Unlock Visual Studio if you use an account that's associated with a [Visual Studio subscription](/visualstudio/subscriptions/using-the-subscriber-portal) or an Azure DevOps organization.|
|[Synchronize](../ide/synchronized-settings-in-visual-studio.md) your settings|Settings that you customize, such as key bindings, window layout, and color theme, apply immediately when you sign in to Visual Studio on any device.|
|Auto-connect to Azure services|Connect to services, such as Azure and Azure DevOps Services, in the IDE without prompting again for credentials for the same account.|
|Continue using our Community edition|If the installation prompts you for a license, sign in to the IDE to continue using Visual Studio Community for **free**. |
|[Get 'Visual Studio Dev Essentials'](https://visualstudio.microsoft.com/dev-essentials/)|This program includes free software, training, support, and more.|

<a name="sign-in"></a>
## Sign in to account

::: moniker range="<=vs-2019"

1. Launch Visual Studio. When you open Visual Studio for the first time, you're asked to sign in and provide some basic registration information.

   ![Sign-in prompt](../ide/media/vs2019_signinpopup.png)
   
   > [!NOTE]
   > If you choose not to sign in when you first open Visual Studio, it's easy to do so later. Look for the **Sign in** link in the upper-right corner of the Visual Studio environment.

::: moniker-end

::: moniker range="vs-2022"

1. Launch Visual Studio.  When you open Visual Studio for the first time, you're asked to sign in and provide some basic registration information.

   ![Sign-in prompt](../ide/media/vs-2022/visual-studio-sign-in-pop-up.png)

::: moniker-end

2. Choose a Microsoft account or a work or school account.  If you don't have one, [create a Microsoft account for free](https://support.microsoft.com/help/4026324/microsoft-account-how-to-create) by selecting the link near the **Sign in** button. 

3. Choose your preferred color theme and other UI settings.  Visual Studio [remembers these settings and synchronizes](../ide/synchronized-settings-in-visual-studio.md) them across all Visual Studio environments you have signed in to. You can change the settings later if you open the **Tools** > **Options** menu in Visual Studio.

   You can see that you're successfully signed in the upper-right corner of the Visual Studio environment.   Unless you sign out, you're automatically signed in to Visual Studio whenever you start it, and any changes to synchronized settings are automatically applied.

::: moniker range="<=vs-2019"

   ![Currently logged in user in VS2019](../ide/media/vs2019_username.png)

::: moniker-end

::: moniker range="vs-2022"

   ![Currently logged in user in VS2019](../ide/media/vs-2022/visual-studio-sign-in.png)

::: moniker-end


## Sign out of account

1. Click on the icon with your profile name in the upper-right corner of the Visual Studio environment
2. Choose the **Account settings** command.
3. Choose the **Sign out** link. 

## Update your profile

1. Go to **File** > **Account Settings** and choose the **Manage Visual Studio profile** link.
1. In the browser window, choose **Edit profile** and change the settings that you want.
1. When you're done, choose **Save changes**.

## See also

- Troubleshooting: [Subscription support](https://visualstudio.microsoft.com/subscriptions/support/)
- [Compare Visual Studio 2022 Editions](https://visualstudio.microsoft.com/vs/compare/)

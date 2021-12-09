---
title: Sign in 
description: Sign in to Visual Studio to Extend the Visual Studio trial period, Unlock Visual Studio, and more
ms.custom: "contperf-fy21q1"
ms.date: 09/11/2020
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

While you don't have to sign in, there are many advantages to doing so. In this article, you'll learn [how to sign in](#how-to-sign-in), how to [update your profile](#update-your-profile), and the benefits to your Visual Studio experience. 

> [!NOTE]
> This topic applies to Visual Studio on Windows. For Visual Studio for Mac, see [Sign in to Visual Studio for Mac](/visualstudio/mac/signing-in).

::: moniker range="vs-2017"

> [!WARNING]
> To work with resources configured for conditional access, upgrade to Visual Studio 2019 Update 16.6 or later. For more information, see [How to use Visual Studio with accounts that require multi-factor authentication](work-with-multi-factor-authentication.md).
> Using Visual Studio 2017 to access resources configured for conditional access may trigger a degraded authentication experience, prompting reauthentication several times within the same Visual Studio session. 
> 
::: moniker-end

## Benefits to signing in

Here's a full list of what you can expect and what you can do after you sign in:

|Benefit|Description|
|---|---|
|Extend the Visual Studio trial period|Use Visual Studio Professional or Visual Studio Enterprise **for an additional 90 days**, instead of being limited to the trial period of 30 days. <br/>See [Extend a trial version or update a license](../ide/how-to-unlock-visual-studio.md).|
|Unlock Visual Studio (Visual Studio subscription or an Azure DevOps organization)|Unlock Visual Studio if you use an account that's associated with a Visual Studio subscription or an Azure DevOps organization.<br/>See [Extend a trial version or update a license](../ide/how-to-unlock-visual-studio.md).|
|Synchronize your Visual Studio settings|Settings that you customize, such as key bindings, window layout, and color theme, apply immediately when you sign in to Visual Studio on any device. <br/>See [Synchronize settings in Visual Studio](../ide/synchronized-settings-in-visual-studio.md).|
|Automatically connect to services|Connect to services, such as Azure and Azure DevOps Services, in the IDE without prompting again for credentials for the same account.|
|Continue using Visual Studio Community edition|If your Community edition installation prompts you for a license, sign in to the IDE to continue using Visual Studio Community for **free**. |
|Get 'Visual Studio Dev Essentials'|This program includes free software offerings, training, support, and more. <br/>See [Visual Studio Dev Essentials](https://visualstudio.microsoft.com/dev-essentials/).|


## How to sign in 

When you open Visual Studio for the first time, you're asked to sign in and provide some basic registration information.

![Sign-in prompt](../ide/media/vs2019_signinpopup.png)

1. Choose a Microsoft account or a work or school account that best represents you. If you don't have any of these accounts, you can create a Microsoft account for free by clicking the link under the sign in button. If you're having trouble, see [How do I sign up for a Microsoft account?](https://support.microsoft.com/help/4026324/microsoft-account-how-to-create)

2. Choose the UI settings and color theme that you want to use in Visual Studio. Visual Studio remembers these settings and synchronizes them across all Visual Studio environments you have signed in to. For a list of the settings that are synchronized, see [Synchronized settings](../ide/synchronized-settings-in-visual-studio.md). You can change the settings later if you open the **Tools** > **Options** menu in Visual Studio.
   After you provide the settings, Visual Studio starts, and you're signed in and ready to get started. 
   
1. To verify whether you're signed in, look for your name in the upper-right corner of the Visual Studio environment.

![Currently logged in user in VS2019](../ide/media/vs2019_username.png)

If you choose not to sign in when you first open Visual Studio, it's easy to do so later. Look for the **Sign in** link in the upper-right corner of the Visual Studio environment.

![Not signed in user](../ide/media/vs2019_usernotsignedin.png)

Unless you sign out, you're automatically signed in to Visual Studio whenever you start it, and any changes to synchronized settings are automatically applied. To sign out, click on the icon with your profile name in the upper-right corner of the Visual Studio environment, choose the **Account settings** command, and then choose the **Sign out** link. To sign in again, choose the **Sign in** command in the upper-right corner of the Visual Studio environment.

## Update your profile

1. Go to **File** > **Account Settings** and choose the **Manage Visual Studio profile** link.

1. In the browser window, choose **Edit profile** and change the settings that you want.

1. When you're done, choose **Save changes**.

## Troubleshooting

See the [Subscription support](https://visualstudio.microsoft.com/subscriptions/support/) page to get help.

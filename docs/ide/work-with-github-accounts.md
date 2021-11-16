---
title: Work with GitHub accounts in Visual Studio
ms.date: 11/16/2020
ms.custom:
ms.topic: how-to
description: "Learn how to use Visual Studio with GitHub accounts."
author: anandmeg
ms.author: meghaanand
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
monikerRange: ">=vs-2019"
---
# Work with GitHub accounts in Visual Studio

If you have a public GitHub or GitHub Enterprise account, you can add it to your Visual Studio keychain. After you add your account, you'll be able to take advantage of the platform integration by accessing and creating GitHub repositories, right from Visual Studio.

## Adding public GitHub accounts

You can add your public GitHub account if you're already signed in to Visual Studio with a Microsoft account, or a work or school account.

1. Select the icon with your initials in the upper-right corner of the Visual Studio environment. Then, select **Account settings...** to manage your accounts. You can also open the Account Settings dialog by going to **File** > **Account Settings**.

    :::image type="content" source="../ide/media/account-picker.png" alt-text="Account settings":::

2. Under the **All Accounts** submenu, select the plus sign to add an account, and select **GitHub**.

    :::image type="content" source="../ide/media/sign-in-add-github.png" alt-text="Select add GitHub account":::

3. You'll be redirected to the browser, where you can sign in with your GitHub credentials. After you sign in, you'll get a success window in the browser, and you can return to Visual Studio.

    :::image type="content" source="../ide/media/github-success-signin.png" alt-text="Success window in browser":::

4. You'll have both accounts present in your **All Accounts** submenu.

    :::image type="content" source="../ide/media/show-both-accounts.png" alt-text="Both accounts showing":::

If you're not already signed in to Visual Studio with a different account,select the **Sign in** link in the upper-right corner of the Visual Studio environment. You can also open the Account Settings dialog by going to **File** > **Account Settings**. Then, follow the instructions above to add your GitHub account.

![Not signed in user](../ide/media/vs2019_usernotsignedin.png)

## Adding GitHub enterprise accounts

By default, Visual Studio only has public GitHub accounts enabled.

1. To enable GitHub enterprise accounts, go to **Tools** > **Options** and search for the **Accounts** options.

    :::image type="content" source="../ide/media/accounts-options.png" alt-text="Accounts options menu":::

2. Then, check the box to **Include GitHub Enterprise Server accounts**. The next time you go to your **Account Settings** and try to add a GitHub account, you'll see options for both GitHub and GitHub Enterprise.

    :::image type="content" source="../ide/media/github-enterprise-endpoint-signin.png" alt-text="Sign in with GitHub Enterprise":::

3. After you enter your GitHub Enterprise server address, select **Sign in with your browser**. There, you can sign in using your GitHub Enterprise credentials.

## See also

- [Work with multiple user accounts](work-with-multiple-user-accounts.md)
- [Sign in to Visual Studio](signing-in-to-visual-studio.md)

---
title: Signing in to Visual Studio Subscriptions with your GitHub account | Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
ms.date: 07/11/2019
ms.topic: conceptual
description:  Learn how to sign in to your Visual Studio subscription(s) with your GitHub account. 
---

# Signing in to Visual Studio subscription(s) with your GitHub account 

The steps to sign in to your Visual Studio subscription depend on the kind of account you're using. For example, you may be using a Microsoft Account (MSA) or an email address supplied by your employer or school. As of January 2019, you can now also use your GitHub account to sign in to some subscriptions. 

This article will provide the steps for signing in with your GitHub account.

## Signing in with your GitHub account

GitHub identity support lets you use your existing GitHub account as a credential for a new or existing Microsoft account, linking your GitHub account with your Microsoft account. 

When you sign in with GitHub, Microsoft checks whether any email addresses associated with your GitHub account match an existing personal or enterprise Microsoft account. If the address matches your enterprise account, you'll be prompted to sign in to that account instead. If the address matches a personal account, we’ll add your GitHub account as a sign-in method to that personal account.

After your GitHub and Microsoft account credentials are linked, you can use that single sign-in anywhere a personal Microsoft account can be used, like on Azure sites, Office apps, and Xbox. These accounts can also be used for Azure Active Directory guest sign ins as a Microsoft account, assuming the email address matches the one on the invite.

> [!NOTE]
> Linking a GitHub identity to a Microsoft account doesn't give Microsoft any code access. When apps such as Azure DevOps and Visual Studio require access to your code repositories, you'll be prompted to grant specific consent for this access. 

### Frequently asked questions
The following FAQs address questions you may encounter regarding the use of your GitHub account credentials to sign in to Visual Studio subscriptions.

#### Q: I forgot my GitHub password.  How can I access my account now?
A:  You can recover your GitHub account by going to [Reset your password](https://github.com/password_reset). Or, you can recover your GitHub-linked Microsoft account by entering your GitHub account’s email address at [Recover your account](https://account.live.com/password/reset).

#### Q: I deleted my GitHub account.  How can I access my Microsoft account (MSA) now?
A: If you don’t have any other credentials on your MSA (like a password, Authenticator app, or security key), you can recover your Microsoft account by using the email address attached to it. To get started, go to [Recover your account](https://account.live.com/password/reset). You’ll have to add a password to your account so we'll know how to sign you in later. 

#### Q: There's no "Sign in with GitHub" option on the sign-in page.  How can I use my GitHub credentials to sign in?
A:  Type the GitHub account email address you chose when you created your GitHub-linked Microsoft account. We’ll look you up and send you to GitHub for sign-in. Or, if there’s a Sign-in options link on the sign in page, use the **Sign in with GitHub** button that's shown after you click that link. 

#### Q: I can't sign in to some of my apps and products with GitHub.  Why?
A:  Not all Microsoft products can access GitHub.com from their sign-in page—for example, Xbox consoles. Instead, when you type the email address from your linked GitHub account, we’ll send a code to that address so we can verify it’s really you. You’re still signing in to the same account, just by a different sign-in method. 

#### Q:  I've added a password to the Microsoft account I have linked to my GitHub account.  Will that cause a problem?
A:  Not at all. This doesn’t change your GitHub password; you’ll just have another way to sign in to your Microsoft account. Whenever you sign in using your email address, we’ll offer you the choice of signing in with your Microsoft account password or going to GitHub to sign in. We strongly recommend that, if you need to add a password, you make sure it’s different from the password for your GitHub account.

#### Q: I want to add the Authenticator app to the account I created using GitHub.  Can I do that?
A:  No problem — just download the app and sign in using your email address. When you sign in with your email address, you'll be prompted to choose either the [Authenticator app](https://go.microsoft.com/fwlink/?linkid=2090219) or GitHub as your credential.

#### Q: I've enabled two-factor authentication on both my GitHub and Microsoft accounts (MSA), but when I sign in to my MSA, I'm still asked to authenticate twice.  Why?
A: Because of security restrictions, Microsoft counts signing in with GitHub as a single-factor verification, even if you have two-step verification enabled there. Therefore, you’ll have to authenticate again for your Microsoft account. 

#### Q:  How can I tell if my Microsoft account and GitHub accounts are linked?
A:  Whenever you sign using your account alias (email address, phone number, Skype name), we’ll show you all the sign-in methods for your account. If you don’t see GitHub there, you haven’t set it up yet.

#### Q:  How can I unlink my Microsoft and GitHub accounts? 
A:  Go to the [Security tab](https://account.microsoft.com/security) of account.microsoft.com and click **More security options** to unlink your GitHub account. Unlinking your GitHub account removes it as a sign-in method and removes access to any GitHub repositories in Visual Studio. Other Microsoft products might have requested access your GitHub account separately, so removing the access here won’t remove access in all products. Go to the [application permissions](https://github.com/settings/applications) page of your GitHub profile to revoke consent from the apps listed there.

#### Q:  I try to use my GitHub account to sign in, but I'm prompted that I already have a Microsoft identity that I should use instead.  What's happening?
A:  If you have an Azure Active Directory email address on your GitHub account, this means you already have a Microsoft identity that can access Azure and run CI pipelines using your GitHub code. Using that account ensures that your Azure resources and build pipelines remain within your organizational boundaries. However, if you’re doing personal work, we recommend putting a personal email address on your GitHub account so that you'll always have access to it. Once you do this, try signing in again and choose **Use a different email address** when you're prompted to sign in to your work or school account. This will let you create a new Microsoft account using that personal email address.

## Next steps
Once you've successfully signed in to the subscriptions portal, we recommend visiting the Benefits page at https://my.visualstudio.com/benefits and exploring the great tools, services, and offers available to you.  
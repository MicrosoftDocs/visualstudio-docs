---
title: How to use connected Microsoft account and Azure Active Directory identities  | Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
ms.date: 09/27/2019
ms.topic: conceptual
robots: "noindex, nofollow"
description:  Learn how to work with connected Microsoft accounts and Azure Active Directory identities
---

# How to use connected identities in Visual Studio subscriptions
If you receive a Visual Studio subscription through your work or school, and you use your Microsoft account (MSA) to sign in, your subscriptions administrator may connect your MSA to your identity in your organization's Azure Active Directory (Azure AD).  This will change how you access some of the benefits included in your subscription. 

## Overview of connected IDs
Organizations are increasingly moving to Azure AD-based identities to provide improved security and support for automated management of subscriptions.  If your subscription uses an MSA such as an @outlook.com or other personal email address, your administrator may change your sign-in email to your Azure AD identity.  That will change how to sign in to the subscriber portal at https://my.visualstudio.com but may not change how you access all of your benefits.  

If your administrator connects your MSA and Azure AD identities, you'll receive an email letting you know to start accessing your Visual Studio subscription with your Azure AD identity instead of your MSA. 

## How to access benefits using Azure AD identities
After your admin has connected your MSA to your Azure AD identity, you'll need to sign in to the subscriber portal at https://my.visualstudio.com with your Azure AD identity to access benefits that rely on Azure AD.  These include:
- Visual Studio IDE
- Azure DevOps
- Azure DevTest individual credit

## How to access benefits using your MSA
For many of the benefits offered in Visual Studio subscriptions such as Pluralsight, LinkedIn, CloudPilot and others, you actually create user accounts on the partners' web sites.  For those accounts, you should continue to use the identity you used when you created the account.  For example, if you activated your Pluralsight benefit using your MSA, you should continue to use your MSA when taking Pluralsight training, regardless of the identity you use to sign into the subscriber portal.  

## Use an alternate identity to access your subscription
Adding an alternate account to your Visual Studio subscription allows you to access the subscription benefits, like Azure DevOps and Azure, with a different identity than that which the subscription is assigned to. In the past, this functionality was available only if your Visual Studio (VS) subscription was assigned to a Microsoft Account (MSA). We have extended this functionality for work or school accounts in Azure Active Directory (Azure AD).  For more information about using alternate accounts, check out our [Alternate identities](vs-alternate-identity.md) article. 

## Frequently asked questions
### Q: How can I contact my admin about this?
A:  Please see our [Contact your subscriptions administrator](contact-my-admin.md) article for information about contacting your admin.  

## Next steps
After your admin connects your Azure AD and MSA accounts, we recommend verifying that you can successfully sign in to the [subscription portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs) and access benefits like Azure DevOps, Visual Studio, and your Azure DevTest individual credit. 
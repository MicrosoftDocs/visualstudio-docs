---
title: How to use connected identities in Visual Studio subscriptions  | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: 50ce0445-ef1a-4e92-b9d0-aebb2155a111
ms.date: 10/14/2021
ms.topic: conceptual
robots: "noindex, nofollow"
description:  Learn how to work with connected Microsoft accounts and Azure Active Directory identities
---

# How to use connected identities in Visual Studio subscriptions
If you receive a Visual Studio subscription through your work or school, and you use your Microsoft account (MSA) to sign in, your subscriptions admin may connect your MSA to your identity in your organization's Azure Active Directory (Azure AD).  This will change how you access some of the benefits included in your subscription. 

## Overview of connected IDs
Organizations are increasingly moving to Azure AD-based identities to provide improved security and support for automated management of subscriptions.  If your subscription uses an MSA such as an @outlook.com or other personal email address, your admin may change your sign-in email to your Azure AD identity.  That will change how you sign in to the subscriber portal at https://my.visualstudio.com but may not change how you access all of your benefits.  

If your admin connects your MSA and Azure AD identities, you'll receive an email letting you know to start accessing your Visual Studio subscription with your Azure AD identity instead of your MSA. 

## How to access benefits using Azure AD identities
After your admin has connected your MSA to your Azure AD identity, you'll need to sign in to the subscriber portal at https://my.visualstudio.com with your Azure AD identity to access benefits that rely on Azure AD.  These include:
- Visual Studio IDE
- Azure DevOps
- Azure DevTest individual credit

## How to access benefits using your MSA
For many of the benefits offered in Visual Studio subscriptions such as Pluralsight, LinkedIn, CloudPilot and others, you actually create user accounts on the partners' web sites.  For those accounts, you should continue to use the identity you used when you created the account.  For example, if you activated your Pluralsight benefit using your MSA, you should continue to use your MSA when taking Pluralsight training, regardless of the identity you use to sign into the subscriber portal.  

## Use an alternate identity to access your subscription
Adding an alternate account to your Visual Studio subscription allows you to access the subscription benefits, like Azure DevOps and Azure, with a different identity than the one to which the subscription is assigned. In the past, this functionality was available only if your Visual Studio (VS) subscription was assigned to a Microsoft Account (MSA). We have extended this functionality for work or school accounts in Azure AD.  For more information about using alternate accounts, check out our [Alternate identities](vs-alternate-identity.md) article. 

## Frequently asked questions
### Q: How can I contact my admin about this?
A:  Look for the "Contact my admin" button at the top right in the subscriber portal. See our [Contact your subscriptions admin](contact-my-admin.md) article for more information about contacting your admin.  

### Q: I'm an admin.  How do I use this?
A:  Implementing connected identities is simple.  Check out [this article](personal-email-sign-ins.md) for more information. 

## Resources
- For assistance with sales, subscriptions, accounts and billing for Visual Studio Subscriptions, see Visual Studio [Subscriptions support](https://aka.ms/vssubscriberhelp).

## See also
- [Visual Studio documentation](/visualstudio/)
- [Azure DevOps documentation](/azure/devops/)
- [Azure documentation](/azure/)
- [Microsoft 365 documentation](/microsoft-365/)

## Next steps
After your admin connects your Azure AD and MSA accounts, we recommend verifying that you can successfully sign in to the [subscription portal](https://my.visualstudio.com?wt.mc_id=o~msft~docs) and access benefits like Azure DevOps, Visual Studio, and your Azure DevTest individual credit.
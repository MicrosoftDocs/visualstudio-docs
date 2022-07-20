---
title: Anonymization of Visual Studio subscriber data | Microsoft Docs
author: evanwindom
ms.author: amast
manager: shve
ms.assetid: ce5fc8a4-484c-4df6-97c3-cb60174fb66b
ms.date: 07/07/2022
ms.topic: conceptual
description:  Learn how subscriber data is anonymized when access to subscriptions is lost.
---

# Anonymization of Visual Studio subscriber information

When an event occurs that blocks a subscriber's use of a subscription, the user's personal information such as name and sign-in account is scrambled to render it unusable.  This "anonymization" is done to safeguard the subscriber's personal information.  These events can include:
+ Expiration of the subscription
+ Deletion of the subscribers sign-in account   

[!INCLUDE [GDPR-related guidance](includes/gdpr-intro-sentence.md)]

## When does anonymization occur?

Events that make a subscription unusable to a subscriber will trigger anonymization.  How quickly the anonymization occurs depends on the type of subscription and the triggering event. See the table below for more information.

| Subscription Type  | Event triggering anonymization | When anonymization occurs |
|--------------------|--------------------------------|---------------------------|
| Visual Studio Dev Essentials | Subscriber opts out of the program or doesn't accept the terms of use | 30 days |
| Visual Studio subscriptions purchased  through the Microsoft Store (retail) | Subscription expires or isn't activated  | 360 days |
| Visual Studio subscriptions acquired through  Volume License, Visual Studio Marketplace  (cloud subscriptions), or programs such as MPN | Subscription expires or isn't assigned to a user | 180 days |
| All subscriptions | An Azure Active Directory account or Microsoft  Account (MSA) used to sign into the subscription is closed | Immediately |
| All subscriptions | A subscriber is removed from the tenant that is associated with the Azure Active Directory account | Immediately |

## FAQ

### Q:  Does the anonymization of the subscriber's personal information cause them to lose access to the subscription?

A:  No.  Anonymization occurs after access to the subscription has already occurred.

### Q:  I'm an admin for my organization's subscriptions.  If one of my subscriber's information is anonymized, can I reassign that subscription to another user?

A:  Yes.  A subscription can be reassigned if these criteria are met:
+ The subscription hasn't expired.
+ A minimum of 90 days have passed since the subscription was last assigned to a subscriber.  For example, if a subscription was assigned to a subscriber on June 1, it can't be reassigned until at least August 30.

### Q: How can I prevent anonymization caused by deleting a sign-in email address?

A:  There are two ways to prevent the issue:
+ Deploy a single identity management system--either MSA or Azure Active Directory--but not both.  
+ Associate the Azure Active Directory and MSA identities via the tenant. 

## Support resources

For assistance with sales, subscriptions, accounts, and billing for Visual Studio Subscriptions, see Visual Studio [Subscriptions support](https://aka.ms/vssubscriberhelp).

## See also

+ [Visual Studio documentation](/visualstudio/)
+ [Azure DevOps documentation](/azure/devops/)
+ [Azure documentation](/azure/)
+ [Microsoft 365 documentation](/microsoft-365/)

## Next steps

Learn how to prevent anonymization by [associating MSA and Azure Active Directory identities](/azure/active-directory/b2b/add-users-administrator).
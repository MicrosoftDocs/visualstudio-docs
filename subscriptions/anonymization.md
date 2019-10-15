---
title: Anonymization of Visual Studio subscriber data | Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
ms.date: 07/19/2019
ms.topic: conceptual
description:  Learn how subscriber data is anonymized when access to subscriptions is lost.
---

# Anonymization of Visual Studio subscriber information
When an event occurs that blocks a subscriber's use of a subscription, such as the expiration of a subscription or the deletion of a subscriber's sign-in account, the user's personal information such as name and sign-in account are essentially scrambled to render them unusable.  This is done to safeguard the subscriber's personal information.

[!INCLUDE [GDPR-related guidance](includes/gdpr-intro-sentence.md)]

## When does anonymization occur?
Events that render a subscription unusable to a subscriber will trigger anonymization.  How quickly the anonymization occurs depends on the type of subscription and the triggering event. See the table below for more information.

| Subscription Type                                                                                                                       | Event triggering anonymization                                                                                                     | When anonymization occurs |
|-----------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------|---------------------------|
| Visual Studio Dev Essentials                                                                                                            | Subscriber opts out of the program or does not  accept the terms of use                                    | 30 days               |
| Visual Studio subscriptions purchased  through the Microsoft Store (retail)                                                                      | Subscription expires or is not activated                                                                   | 360 days                  |
| Visual Studio subscriptions acquired through  Volume License, Visual Studio Marketplace  (cloud subscriptions), or programs such as MPN | Subscription expires or is not assigned to a user                                                          | 180 days                  |
| All subscriptions                                                                                                                       | An Azure Active Directory account or Microsoft  Account (MSA) used to sign into the subscription is closed | Immediately               |
| All subscriptions                                                                                                                       | A subscriber is removed from the tenant that is associated with the Azure Active Directory account                                | Immediately               |

## FAQ
### Q:  Does the anonymization of the subscriber's personal information cause them to lose access to the subscription?
A:  No.  The anonymization is in response to an event that causes the loss of access to the subscription, but does not cause the lack of access.

### Q:  I'm an administrator for my organization's subscriptions.  If one of my subscriber's information is anonymized, can that subscription be reassigned to another user?
A:  Yes -- As long as the subscription has not expired, it can be reassigned to another subscriber.

### Q: How can I prevent anonymization caused by deleting a sign-in email address?
A:  There are two ways to prevent the issue:
- Deploy a single identity management system -- either MSA or AAD -- but not both.  
- Associate the AAD and MSA identities via the tenant. 

## Next steps
Learn how to prevent anonymization by [associating MSA and AAD identities](/azure/active-directory/b2b/add-users-administrator).

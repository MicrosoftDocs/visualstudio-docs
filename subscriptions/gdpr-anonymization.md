---
title: Anonymization of Visual Studio Subscriber Data for GDPR | Microsoft Docs
author: evanwindom
ms.author: lank
manager: lank
ms.date: 10/31/2018
ms.topic: conceptual
description:  Learn how GDPR impacts anonymization of Visual Studio subscriptions
ms.prod: vs-subscription
ms.technology: vs-subscriptions
searchscope: VS Subscription
---

# Anonymization of Visual Studio subscriber information to comply with GDPR requirements

The General Data Protection Regulation (GDPR) regulates the collection, storage, processing, and sharing of personal data. Personal data is defined very broadly under the GDPR as any data that relates to an identified or identifiable natural person that is a resident of the European Union (EU).  GDPR applies to the personal data of EU residents, regardless of the geography in which that data is held.  

Learn more about [Microsoft's commitment to GDPR](https://blogs.microsoft.com/on-the-issues/2018/05/21/microsofts-commitment-to-gdpr-privacy-and-putting-customers-in-control-of-their-own-data/).  

For more information about GDPR, visit the European Commission's [Data protection portal](https://ec.europa.eu/info/law/law-topic/data-protection_en).

To ensure compliance with GDPR, steps to render Visual Studio subscription sign-in data anonymous will be taken whenever certain events involving a subscription occur.

[!INCLUDE [GDPR-related guidance](docs/misc/includes/gdpr-intro-sentence.md)] 

## What happens when a subscriber's data is "anonymized"?

When an event occurs that blocks a subscriber's use of a subscription, such as the expiration of a subscription or the deletion of a subscriber's sign-in account, the user's personal information such as name and sign-in account are essentially scrambled to render them unusable.  This is done to safeguard the subscriber's personal information.

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
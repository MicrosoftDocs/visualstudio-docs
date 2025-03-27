---
title: Configure feedback group policies
description: Configure Group Policies that control submission of feedback and survey responses for enterprise deployments of Visual Studio.
ms.date: 3/27/2025
ms.topic: conceptual
f1_keywords:
- gpo
- policy
- feedback
helpviewer_keywords:
- '{{PLACEHOLDER}}'
- '{{PLACEHOLDER}}'
author: 
ms.author: jasonchlus
manager: dominicn

ms.subservice: installation
---
# Configure Feedback Group Policies

Visual Studio allows you to configure and deploy global machine-wide policies across your organization by using the [Microsoft Intune settings catalog](/mem/intune/configuration/settings-catalog) or by importing [Visual Studio Administrative Templates (ADMX)](administrative-templates.md) into legacy tools like Group Policy editor. To learn more, see [Configure policies for enterprise deployments of Visual Studio](configure-policies-for-enterprise-deployments.md).

One of the main categories included in the Visual Studio ADMX templates is feedback. Feedback Group Policies can be used to control the types of feedback sent through Visual Studio. IT administrators may find these policies useful to control whether Visual Studio users in their organization are permitted to submit feedback or survey responses to Microsoft. By default, users can submit both feedback and survey responses through Visual Studio.

## Supported policies

> [!IMPORTANT]
> These policies require Visual Studio 2022 version 17.13 or later

Feedback Group Poicies for Visual Studio include the following:

| **Name**                         | **Description**                                               |
|----------------------------------|---------------------------------------------------------------|
| `SurveysDisabled`                | **Controls whether the user receives survey links in Visual Studio:** If enabled, Visual Studio and the Visual Studio Installer will not display any product survey requests or links to surveys to the user. |
| `ProductFeedbackDisabled`        | **Controls whether the user can submit feedback through Visual Studio:** If enabled, Visual Studio and the Visual Studio Installer will not allow users to submit feedback to Microsoft. This includes, but is not limited to reporting feedback, submitting suggestions, and providing feedback on features via a thumbs up/thumbs down control. |

   > [!NOTE]
   > `DisableFeedbackDialog` is an older feedback policy that may be avaialble on your machine depending on the ADMX template version on box. This policy controls Send a Smile feedback. We do not recommend using this policy and instead recommend using the newer `SurveysDisabled` and `ProductFeedbackDisabled` policies.

## Related content

* [Visual Studio administrator guide](../install/visual-studio-administrator-guide.md)
* [Visual Studio Administrative Templates (ADMX)](administrative-templates.md)
* [Configure policies for enterprise deployments of Visual Studio](configure-policies-for-enterprise-deployments.md) 

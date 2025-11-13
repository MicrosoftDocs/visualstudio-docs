---
title: Certificate revocation check 
description: Learn how to enable certificate revocation check to keep Visual Studio secure.
ms.date: 11/13/2025
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
ms.topic: how-to
monikerRange: ">=visualstudio"
---
# Configure certificate revocation check

Starting with Visual Studio 2026, you can enable an optional certificate revocation check feature. When you enable it, Visual Studio blocks connections if it detects any issue in the [X509 certificate chain](/dotnet/api/system.security.cryptography.x509certificates.x509chainstatusflags).

If a connection is blocked because of a certificate error, a dialog appears with more information about why the certificate validation failed. 

:::image type="content" source="media/visualstudio/certificate-status-security-dialog.png" alt-text="Screenshot of the certificate status security dialog.":::

This feature is disabled by default. To enable it:

1. Go to **Tools** > **Options** > **Environment** > **Security** > **Certificates**.
1. Select the **Warn me about invalid or missing certificates** checkbox.

:::image type="content" source="media/visualstudio/certificate-revocation-setting.png" alt-text="Screenshot of the certificate revocation setting in the Options dialog.":::

For more information about certificate validation, see [X509 certificates](/dotnet/api/system.security.cryptography.x509certificates.x509certificate).

 

 
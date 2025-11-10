---
title: Certificate revocation check 
description: Learn how to enable certificate revocation check to keep Visual Studio secure.
ms.date: 11/11/2025
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
ms.date: 11/11/2025
ms.topic: how-to
---
# Configure certificate revocation check

Starting with Visual Studio 2026, an optional certificate revocation check feature is available. When enabled, Visual Studio blocks connections if any issue is detected in the X.509 certificate chain. 

If a connection is blocked due to a certificate error, a dialog will appear providing additional information about why the certificate validation failed.  

:::image type="content" source="media/visualstudio/certificate-status-security-dialog.png" alt-text="Screenshot of the certificate status security dialog.":::

This feature is disabled by default. To enable it:

1. Go to **Tools** > **Options** > **Environment** > **Security** > **Certificates**.
1. Select the **Warn me about invalid or missing certificates** checkbox.

:::image type="content" source="media/visualstudio/certificate-revocation-setting.png" alt-text="Screenshot of the certificate revocation setting in the Options dialog.":::

For more information about certificate validation, see [X.509 certificates](/dotnet/api/system.security.cryptography.x509certificates.x509certificate).
 

 

 
---
title: 'Secure a brokered service'
description: Learn how to secure a brokered service for consumption over Live Share.
monikerRange: '>= vs-2019'
ms.date: 01/11/2022
ms.topic: how-to
helpviewer_keywords:
- brokered services, providing
author: aarnott
ms.author: andarno
manager: ansonh
ms.subservice: extensibility-integration
---
# Secure a brokered service

Brokered services default to only being available to the local user and to the processes involved in the Visual Studio session that activated it.
Under these defaults, security considerations for brokered services are no different than other code running in these processes, which include:

- From a threat model perspective, extensions that run within the Visual Studio process are assumed to be fully trusted. Extensions that run out of process should treat Visual Studio service calls as crossing a trust boundary.
- Your code must validate arguments at entry points to confirm they fall in expected patterns/ranges.
- When reading data from disk, consider that the data may have been tampered with.
- When receiving data from a network or the Internet, be cautious when parsing or deserializing the data to avoid common vulnerabilities.

Several critical additional security considerations apply when your service is registered with the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients?displayProperty=nameWithType> flag set.
The remainder of this article focuses on those considerations.

## Authorization checks for sensitive operations

### Acquiring the authorization service

Your brokered service should have a constructor that takes an <xref:Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient> as a parameter.
The argument should be stored in a field and disposed of in your service's <xref:System.IDisposable.Dispose> method.

```csharp
class Calculator : ICalculator, IDisposable
{
    private readonly AuthorizationServiceClient authorizationService;

    internal Calculator(AuthorizationServiceClient authorizationService)
    {
        this.authorizationService = authorizationService;
    }

    public void Dispose()
    {
        this.authorizationService.Dispose();
    }
}
```

The service factory you proffer changes slightly to support this new parameter.
Instead of providing a <xref:Microsoft.VisualStudio.Shell.ServiceBroker.BrokeredServiceFactory> to the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.IBrokeredServiceContainer.Proffer%2A?displayProperty=nameWithType> method, provide an <xref:Microsoft.VisualStudio.Shell.ServiceBroker.AuthorizingBrokeredServiceFactory> delegate.
This delegate receives the <xref:Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient> that you will need to pass to your brokered service.

This change to your proffer code might look like this:

```diff
 container.Proffer(
     CalculatorService,
-    (moniker, options, serviceBroker, cancellationToken) => new ValueTask<object?>(new CalculatorService()));
+    (moniker, options, serviceBroker, authorizationService, cancellationToken) => new ValueTask<object?>(new CalculatorService(authorizationService)));
```

### Using the authorization service

Any operation that may disclose sensitive information or mutate the user's state should be checked with the authorization service using <xref:Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient.AuthorizeOrThrowAsync%2A?displayProperty=nameWithType>.

To assert that the caller is the owner of the code (the same identity as the operator of the Live Share host), this code may be used:

```csharp
private static readonly ProtectedOperation ClientIsOwner = WellKnownProtectedOperations.CreateClientIsOwner();

public ValueTask ResetOperationCounterAsync(CancellationToken cancellationToken)
{
    // Resetting the counter should only be allowed if the user is the owner.
    await this.authorizationService.AuthorizeOrThrowAsync(ClientIsOwner, cancellationToken);

    // Proceed with the operation.
    this.operationCounter = 0;
}
```

Various other authorization levels are defined in the <xref:Microsoft.VisualStudio.RpcContracts.WellKnownProtectedOperations> class.

All authorization checks are always approved when the service client is running in the same machine and user account.
They are also all approved to a Live Share guest that is operating under the same Microsoft account as the host.

When the requested operation is *not* authorized, <xref:Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient.AuthorizeOrThrowAsync%2A> will throw an <xref:System.UnauthorizedAccessException>.
The Live Share host may notify the owner of the failed attempt, giving the host a chance to grant the permission required to complete the operation if the <xref:Microsoft.ServiceHub.Framework.Services.ProtectedOperation> is recognized so that a subsequent attempt on the client may succeed.

The <xref:Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient> caches all authorization checks locally so that repeated authorization checks will be fast.
In the event that a user's permission set changes (for example, the Live Share host changes permissions for the guest), the local cache is automatically flushed.

## Consuming other brokered services

When a brokered service itself requires access to another brokered service, it should use the <xref:Microsoft.ServiceHub.Framework.IServiceBroker> that is provided to its service factory.
It should *not* use the global service broker, as that is unaware of the context of this particular brokered service instance and the authorization its client has to activate and invoke other behavior.

If our calculator service had need of other brokered services to implement its behavior, we would modify the constructor to accept an <xref:Microsoft.ServiceHub.Framework.IServiceBroker>:

```csharp
internal class Calculator : ICalculator
{
    private readonly IServiceBroker serviceBroker;
    private readonly AuthorizationServiceClient authorizationService;

    internal class Calculator(IServiceBroker serviceBroker, AuthorizationServiceClient authorizationService)
    {
        this.serviceBroker = serviceBroker;
        this.authorizationService = authorizationService;
    }
}
```

This additional parameter will impact your service factory proffering code:

```diff
 container.Proffer(
     CalculatorService,
     (moniker, options, serviceBroker, authorizationService, cancellationToken)
-        => new ValueTask<object?>(new CalculatorService(authorizationService)));
+        => new ValueTask<object?>(new CalculatorService(serviceBroker, authorizationService)));
```

### Limited brokered service availability

When the client of your brokered service is a Live Share guest (under a different account from the owner of the Host), your contextual service broker will only activate other brokered services that have also set the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients> flag as a security precaution.
Attempts to activate a non-qualifying brokered service will throw an <xref:System.UnauthorizedAccessException>.

If your brokered service requires another brokered service that lacks the <xref:Microsoft.VisualStudio.Shell.ServiceBroker.ProvideBrokeredServiceAttribute.AllowTransitiveGuestClients> flag, you may use the global service broker to obtain it, but must consider that that brokered services obtained from it have no idea that an untrusted guest is the ultimate client.
You should follow all the same precautions given in the next section about calling other VS services or other APIs.

Read more about [consuming brokered services](how-to-consume-brokered-service.md).

## Consuming other VS services or other APIs

Calling standard Visual Studio services, 3rd party libraries or standard .NET APIs is allowed in brokered services that are exposed to Live Share guests, but such calls should be carefully written and all inputs validated first.

File paths or URLs should be carefully checked to ensure they are valid and fall within the expected sub-paths that the guest has authorization to access.
For example if your brokered service allows reading from or writing to files based on a path, the path should be checked to fall under the open solution and that the guest actually has write permissions if applicable.
Validating file paths properly can be difficult considering `..` and other means to make it look like a path starts with the right prefix but then escape the allowed solution directory.

Make use of the <xref:Microsoft.ServiceHub.Framework.Services.AuthorizationServiceClient> described in the above section as appropriate to assert that the client has permission before calling any API that does not have its own permission checks built in.
**Only brokered services built into Visual Studio should be assumed to contain their own authorization checks**, and this relies on your acquiring these brokered services using the contextual service broker as described in the above section.

All other APIs, including non-brokered Visual Studio services or brokered services obtained with the global service broker, may execute as you direct them without regard to your Live Share guest's permission level, making your own authorization check critical to protecting the security of the Live Share host.

Avoid exposing functionality from your brokered service that another Visual Studio brokered service already exposes as it increases the attack surface.

## Sharing state across brokered service instances

When your brokered service requires sharing state across multiple instances of the service, this data becomes exposed potentially to multiple users with diverse permission sets.
It becomes critical for your brokered service to protect this data across these users.
Use [the STRIDE model](/azure/security/develop/threat-modeling-tool-threats#stride-model) to help identify, classify and ultimately to mitigate threats.

You may decide to treat your shared state as trusted, and therefore grant it permission to do whatever it needs to internally (for example, access VS services or use the global service broker).
In such case it becomes an individual brokered service instance's responsibility to guard calls made into its shared state to ensure all inputs are appropriate given its own user's permissions using the authorization service.

The [Microsoft Threat Modeling Tool](/azure/security/develop/threat-modeling-tool) can be a useful tool for securing your shared state and your users.

## Related content
- [Secure Development overview](/azure/security/develop/secure-dev-overview)
- [How to: Provide a Brokered Service](how-to-provide-brokered-service.md)
- [Best Practices for Designing a Brokered Service](best-practices-design-brokered-service.md)
- [Brokered Service Essentials](internals/brokered-service-essentials.md)
- [Use and Provide Brokered Services](use-and-provide-brokered-services.md)

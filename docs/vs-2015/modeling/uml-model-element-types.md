---
title: "UML model element types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML API, types"
ms.assetid: 25345a53-7246-4eb7-8ad9-0b695aa171a2
caps.latest.revision: 10
author: jillre
ms.author: jillfra
manager: jillfra
---
# UML model element types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can read and manipulate a UML model through a programming interface. This topic summarizes the hierarchy of element types. The hierarchy is the same as that defined in the UML specification.

 The details of each type are provided in [API Reference for UML Modeling Extensibility](../modeling/api-reference-for-uml-modeling-extensibility.md).

## Element types
 This is the set of types defined in the assembly `Microsoft.VisualStudio.Uml.Interfaces.dll`.

 The fully qualified name of each item is "`Microsoft.VisualStudio.Uml.`" followed by the name listed.

 For convenience, this list is set out as an inheritance hierarchy. Where a type has more than one supertype, additional supertypes are listed after a colon (:).

```

Classes.IElement
|  Activities.IActivityGroup
|  Classes.IComment
|  Classes.IMultiplicityElement
|  |  CompositeStructures.IConnectorEnd
|  Classes.INamedElement
|  |  Deployments.IDeployedArtifact
|  |  Deployments.IDeploymentTarget
|  |  |  Classes.IInstanceSpecification
             : Deployments.IDeployedArtifact,
               Deployments.IDeploymentTarget
|  |  |  |  Classes.IEnumerationLiteral
|  |  Interactions.IInteractionFragment
|  |  |  Interactions.ICombinedFragment
|  |  |  |  Interactions.IConsiderIgnoreFragment
|  |  |  Interactions.IExecutionSpecification
|  |  |  |  Interactions.IActionExecutionSpecification
|  |  |  |  Interactions.IBehaviorExecutionSpecification
|  |  |  Interactions.IInteraction  : CommonBehaviors.IBehavior
|  |  |  Interactions.IInteractionOperand : Classes.INamespace
|  |  |  Interactions.IInteractionUse
|  |  |  Interactions.IOccurrenceSpecification
|  |  |  |  Interactions.IExecutionOccurrenceSpecification
|  |  |  |  Interactions.IMessageOccurrenceSpecification
                   : Interactions.IMessageEnd
|  |  |  |  |  Interactions.ILostFoundTarget
|  |  |  |  Interactions.IOperandOccurrenceSpecification
|  |  |  Interactions.IStateInvariant
|  |  Interactions.ILifeline
|  |  Interactions.IMessage
|  |  Interactions.IMessageEnd
|  |  Classes.INamespace
|  |  |  Classes.IPackage
             : Classes.IPackageableElement,
              AuxiliaryConstructs.ITemplateableElement
|  |  |  |  AuxiliaryConstructs.IModel
|  |  |  Activities.IState
|  |  Classes.IPackageableElement
                   : AuxiliaryConstructs.IParameterableElement
|  |  |  Classes.IConstraint
|  |  |  |  Interactions.IInteractionConstraint
|  |  |  CommonBehaviors.IEvent
|  |  |  |  Interactions.IExecutionEvent
|  |  |  |  CommonBehaviors.IMessageEvent
|  |  |  |  |  CommonBehaviors.ICallEvent
|  |  |  |  |  Interactions.IReceiveOperationEvent
|  |  |  |  |  Interactions.IReceiveSignalEvent
|  |  |  |  |  Interactions.ISendOperationEvent
|  |  |  |  |  Interactions.ISendSignalEvent
|  |  |  Classes.IType
|  |  |  |  Classes.IClassifier : Classes.INamespace, Classes.IRedefinableElement, AuxiliaryConstructs.ITemplateableElement
|  |  |  |  |  Deployments.IArtifact
                   : Deployments.IDeployedArtifact
|  |  |  |  |  |  Deployments.IDeploymentSpecification
|  |  |  |  |  CommonBehaviors.IBehavioredClassifier
|  |  |  |  |  |  UseCases.IActor
|  |  |  |  |  |  Classes.IClass
                         : CompositeStructures.IEncapsulatedClassifier
|  |  |  |  |  |  |  CommonBehaviors.IBehavior
|  |  |  |  |  |  |  |  Activities.IActivity
|  |  |  |  |  |  |  Components.IComponent
|  |  |  |  |  |  |  |  UseCases.ISubsystem
|  |  |  |  |  |  |  Deployments.INode : IDeploymentTarget
|  |  |  |  |  |  |  |  Deployments.IDevice
|  |  |  |  |  |  |  |  Deployments.IExecutionEnvironment
|  |  |  |  |  |  UseCases.IUseCase
|  |  |  |  |  Classes.IDataType
|  |  |  |  |  |  Classes.IEnumeration
|  |  |  |  |  |  Classes.IPrimitiveType
|  |  |  |  |  Classes.IInterface
|  |  |  |  |  CompositeStructures.IStructuredClassifier
|  |  |  |  |  |  CompositeStructures.IEncapsulatedClassifier
|  |  |  Classes.IValueSpecification : Classes.ITypedElement
|  |  |  |  Classes.IExpression
|  |  |  |  Classes.IInstanceValue
|  |  |  |  Classes.ILiteralSpecification
|  |  |  |  |  Classes.ILiteralBoolean
|  |  |  |  |  Classes.ILiteralInteger
|  |  |  |  |  Classes.ILiteralNull
|  |  |  |  |  Classes.ILiteralString
|  |  |  |  |  Classes.ILiteralUnlimitedNatural
|  |  |  |  Classes.IOpaqueExpression
|  |  Classes.IRedefinableElement
|  |  |  Activities.IActivityNode
|  |  |  |  Activities.IControlNode
|  |  |  |  |  Activities.IDecisionNode
|  |  |  |  |  Activities.IFinalNode
|  |  |  |  |  |  Activities.IActivityFinalNode
|  |  |  |  |  Activities.IForkNode
|  |  |  |  |  Activities.IInitialNode
|  |  |  |  |  Activities.IJoinNode
|  |  |  |  |  Activities.IMergeNode
|  |  |  |  Activities.IExecutableNode
|  |  |  |  |  Actions.IAction
|  |  |  |  |  |  Actions.IAcceptEventAction
|  |  |  |  |  |  Actions.ICreateObjectAction
|  |  |  |  |  |  Actions.IInvocationAction
|  |  |  |  |  |  |  Actions.ICallAction
|  |  |  |  |  |  |  |  Actions.ICallBehaviorAction
|  |  |  |  |  |  |  |  Actions.ICallOperationAction
|  |  |  |  |  |  |  Actions.ISendSignalAction
|  |  |  |  |  |  Actions.IOpaqueAction
|  |  |  |  Activities.IObjectNode  : Classes.ITypedElement
|  |  |  |  |  Activities.IActivityParameterNode
|  |  |  |  |  Actions.IPin : Classes.IMultiplicityElement
|  |  |  |  |  |  Actions.IInputPin
|  |  |  |  |  |  Actions.IOutputPin
|  |  |  UseCases.IExtensionPoint
|  |  |  Classes.IFeature
|  |  |  |  Classes.IBehavioralFeature  : Classes.INamespace
|  |  |  |  |  Classes.IOperation
                   : AuxiliaryConstructs.ITemplateableElement,
                   AuxiliaryConstructs.IParameterableElement
|  |  |  |  Classes.IStructuralFeature
              : Classes.IMultiplicityElement,
                Classes.ITypedElement
|  |  |  |  |  Classes.IProperty
                   : AuxiliaryConstructs.ITemplateableElement,
                   CompositeStructures.IConnectableElement,
                   Deployments.IDeploymentTarget
|  |  |  |  |  |  CompositeStructures.IPort
|  |  Classes.ITypedElement
|  |  |  CompositeStructures.IConnectableElement
             : AuxiliaryConstructs.IParameterableElement
|  |  |  Classes.IParameter  : Classes.IMultiplicityElement, CompositeStructures.IConnectableElement
|  AuxiliaryConstructs.IParameterableElement
|  Classes.IProfileInstance

|  Classes.IRelationship
|  |  Activities.IActivityEdge : Classes.IRedefinableElement
|  |  |  Activities.IControlFlow
|  |  |  Activities.IObjectFlow
|  |  Classes.IAssociation : IClassifier
|  |  |  Deployments.ICommunicationPath
|  |  CompositeStructures.IConnector
|  |  Classes.IDirectedRelationship
|  |  |  Classes.IDependency : Classes.IPackageableElement
|  |  |  |  Classes.IAbstraction
|  |  |  |  |  Deployments.IManifestation
|  |  |  |  |  Classes.IRealization
|  |  |  |  |  |  Classes.IInterfaceRealization
|  |  |  |  Deployments.IDeployment
|  |  |  |  Classes.IUsage
|  |  |  UseCases.IExtend : Classes.INamedElement
|  |  |  Classes.IGeneralization
|  |  |  UseCases.IInclude : Classes.INamedElement
|  |  |  Classes.IPackageImport
|  |  |  AuxiliaryConstructs.ITemplateBinding
|  Classes.IStereotypeInstance
|  Classes.IStereotypePropertyInstance
|  AuxiliaryConstructs.ITemplateableElement
|  AuxiliaryConstructs.ITemplateParameter
|  |  AuxiliaryConstructs.IClassifierTemplateParameter
|  |  AuxiliaryConstructs.IOperationTemplateParameter
|  AuxiliaryConstructs.ITemplateParameterSubstitution
|  AuxiliaryConstructs.ITemplateSignature
|  |  AuxiliaryConstructs.IRedefinableTemplateSignature
             : Classes.IRedefinableElement
```

## See Also
 [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md)
 [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)
 [API Reference for UML Modeling Extensibility](../modeling/api-reference-for-uml-modeling-extensibility.md)

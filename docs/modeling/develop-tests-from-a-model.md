---
title: Develop tests from a model
description: Learn how you can use requirements and architectural models to help organize the tests of your system and its components.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- tests and requirements
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Develop tests from a model

You can use requirements and architectural models to help you organize the tests of your system and its components. This practice helps ensure that you test the requirements that are important to the users and other stakeholders, and it helps you update the tests quickly when the requirements change. If you use Microsoft Test Manager, you can also maintain links between the models and the tests.

 To see which versions of Visual Studio support these features, see [Version support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport).

## System and Subsystem Testing
 *System testing,* also known as *acceptance testing*, means testing whether the users' needs are being met. Such tests are concerned about the externally visible behavior of the system instead of the internal design.

 System tests are very valuable when extending or redesigning a system. They help you avoid introducing bugs when you change the code.

 When you plan any change or extension to a system, it is helpful to start with a set of system tests that run on the existing system. Then you can extend or adjust the tests to test the new requirements, make the changes to the code, and rerun the complete set of tests.

 When you develop a new system, you can begin to create tests as soon as development begins. By defining tests before you develop each feature, you can capture the requirements discussions in a very specific way.

 Subsystem testing applies the same principles to the major components of a system. Each component is tested separately from other components. Subsystem tests focus on the behavior visible at the component's user interfaces or API.

## Deriving System Tests from a Requirements Model
 You can create and maintain a relationship between system tests and a requirements model. To establish this relationship, you write tests that correspond to the main elements of the requirements model. Visual Studio helps you maintain that relationship by letting you create links between the tests and parts of the model. For more information about requirements models, see [Model user requirements](../modeling/model-user-requirements.md).

### Write Tests for Each Use Case
 If you use Microsoft Test Manager, you can create a group of tests for each use case that you defined in your requirements model. For example, if you have a use case Order a Meal, which includes Create Order and Add Item to Order, you can create tests for both the overall and the more detailed of these use cases.

 These guidelines might be helpful:

- Each use case should have several tests, for main paths and exceptional outcomes.

- When you describe a use case in the requirements model, it is more important to define its postcondition, that is, the goal that is achieved, than to describe in detail the procedures the user follows in order to achieve the goal. For example, the postcondition of Order a Meal might be that a Restaurant is preparing a meal for a Customer and that the Customer has paid. The postcondition is the criterion that your tests should verify.

- Base separate tests on the separate clauses of the postcondition. For example, create separate tests for notifying the restaurant of the order, and for taking payment from the customer. This separation has these advantages:

  - Changes in different aspects of the requirements frequently occur independently. By separating the tests into different aspects in this manner, you make it easier to update the tests when requirements change.

  - If the development plan implements one aspect of the use case before another, you can enable the tests separately as development progresses.

- When you design the tests, separate the choice of test data from the code or script that determines whether the postcondition has been achieved. For example, a test of a simple arithmetic function might be: Input 4; verify that the output is 2. Instead, design the script as: Choose an input; multiply the output by itself, and verify that the result is the original input. This style enables you to vary the test inputs without changing the main body of the test.

#### Linking tests to use cases
 If you are using Test Manager to design and run your tests, you can organize your tests under requirement, use case, or user story work items. You can link these work items to use cases in your model. This enables you to quickly trace requirements changes to the tests, and helps you track the progress of each use case.

###### To link tests to a use case

1. In Test Manager, create a requirement and base a test suite on it.

    The requirement that you create is a work item in Team Foundation Server. It might be a User Story, Requirement, or Use Case work item, depending on the process template that your project uses with Team Foundation. For more information, see [About Agile tools and Agile project management](/azure/devops/boards/backlogs/backlogs-overview?view=vsts&preserve-view=true).

2. Link the requirement work item to one or more use cases in your model.

    In a use case diagram, right-click a use case and then click **Link to Work Item**.

3. Add to the test suite, test cases that verify the use cases.

   Usually, each user story or requirement work item will link to several use cases in your model, and each use case will link to several user stories or requirements. This is because each user story or requirement covers a set of tasks that develop several use cases. For example, in an early iteration of your project, you might develop the basic user story in which a customer can choose items from a catalog and have them delivered. In a later iteration, the story might be that the user pays when completing the order, and the supplier receives the money after it sends the goods.  Each story adds a clause to the postcondition of the Order Goods use case.

   You can create separate links from requirements to the clauses of the postcondition by writing those clauses in separate comments on the use case diagram. You can link each comment to a requirement work item, and link the comment to the use case on the diagram.

### Base Tests on the Requirements Types
 The types, that is, the classes, interfaces and enumerations, of a requirements model describe the concepts and relationships in terms of how users think and communicate about their business. It excludes types concerned only with the internal design of the system.

 Design your tests in terms of these requirements types. This practice helps you ensure that when changes to the requirements are discussed, it is easy to relate the changes to the necessary changes in the tests. It makes it possible to discuss the tests and their intended results directly with end-users and other stakeholders. This means that the users' needs can be maintained outside the development process, and avoids the inadvertent design of the tests around possible flaws in the design.

 For manual tests, this practice involves adhering to the vocabulary of the requirements model in the test scripts. For automated tests, this practice involves using the requirements class diagrams as a basis for your test code, and creating accessor and updater functions to link the requirement model to the code.

 For example, a requirements model might include types Menu, Menu Item, Order, and associations between them. This model represents the information that is stored and dealt with by the meal ordering system, but does not represent the complexities of its implementation. In the working system, there might be several different realizations of each type, in databases, in user interfaces and on APIs. In a distributed system, there might be several variants of each instance stored in different parts of the system at the same time.

 To test a use case such as Add Item to Order, a test method could include code similar to this:

```
Order order = ... ; // set up an order
// Store prior state:
int countBefore = order.MenuItems.Count;
// Perform use case:
MenuItem chosenItem = ...; // choose an item
AddItemToOrder (chosenItem, order);
// Verify part of postcondition:
int countAfter = order.MenuItems.Count;
Assert (countAfter == countBefore = 1);
```

 Notice that this test method uses the classes of the requirements model. Associations and attributes are realized as .NET properties.

 To make this work, the properties of the classes must be defined as read-only functions or accessors, which access the system to retrieve information about its current state. Methods that simulate use cases such as AddItemToOrder must drive the system through its API or through a layer underneath its user interface. The constructors of test objects such as Order and MenuItem must also drive the system to create corresponding items inside the system.

 Many of the accessors and updaters will already be available through the application's normal API. But some additional functions might have to be written in order to enable the tests. These additional accessors and updaters are sometimes known as 'test instrumentation'. Because they depend on the internal design of the system, it is the responsibility of the system's developers to provide them, whereas the testers write the code of the tests in terms of the requirements model.

 When you write automated tests, you can use Generic Tests to wrap the accessors and updaters.

### Tests for Business Rules
 Some requirements are not directly related to any one use case. For example, the DinnerNow business allows customers to choose from many Menus, but requires that in every Order, all the chosen Items shall be from a single Menu. This business rule can be expressed as an invariant about the associations between Orders, Menus, and Items in the requirements class model.

 An invariant rule of this kind governs not only all the use cases that are currently defined, but also any other use cases that will be defined later. Therefore, it is useful to write it separately from any use case, and to test it separately from the use cases.

## Deriving Subsystem Tests from Models
 In the high-level design of a large system, you can identify components or subsystems. These represent parts that can be separately designed, or are located on different computers, or are reusable modules that can be recombined in many ways.

 You can apply to each major component the same principles as you use for the complete system. In a large project, each component can have its own requirements model. In smaller projects, an architectural model or high-level design can be created to show the major components and their interactions. For more information, see [Model your app's architecture](../modeling/model-your-app-s-architecture.md).

 In either case, you can establish a relationship between the model elements and the subsystem tests in the same manner as you would between the requirements model and the system tests.

### Isolate Components with Provided and Required Interfaces
 It is useful to identify all the dependencies that a component has on other parts of your system or external services, and to represent these as Required Interfaces. This exercise usually leads to some redesign that leaves the component much more decoupled and easily separable from the rest of your design.

 An advantage of this decoupling is that the component can be executed for testing by replacing with mock objects the services it usually uses. These are components that are set up for the purposes of testing. A mock component provides the interface that your component requires, responding to queries with simulated data. The mock components form part of a complete test harness that you can connect to all the interfaces of the component.

 A benefit of mock testing is that you can develop your component while the other components whose services it will use are still under development.

## Maintain the Relationships between Tests and Model
 In a typical project that performs an iteration every few weeks, a requirements review is held near the beginning of each iteration. The meeting discusses the features that are to be delivered in the next iteration. A requirements model can be used to help discuss the concepts, scenarios, and sequences of actions that will be developed. The business stakeholders set priorities, the developers make estimates, and the testers ensure the expected behavior of each feature is captured correctly.

 Writing tests is the most effective way to define a requirement, and is also an effective way to ensure that a person has a clear understanding of what is required. However, whereas writing tests takes too long to do during a specification workshop, creating models can be done much more rapidly.

 From a testing point of view, a requirements model can be seen as a shorthand for the tests. Therefore, it's important to maintain the relationship between tests and model throughout the project.

## <a name="Attaching"></a> Attaching Test Cases to Model Elements
 If your project uses Test Manager, you can link tests to the elements in your model. This lets you quickly find the tests affected by a change in the requirements, and helps you track the extent to which a requirement has been realized.

 You can link tests to all kinds of element. Here are some examples:

- Link a use case to the tests that exercise it.

- Write the clauses of a use case postcondition, or goal, onto comments that are linked to the use case, and then link tests to each comment.

- Write invariant rules in comments on class diagrams or activity diagrams, and link them to tests.

- Link tests to an activity diagram, or to individual activities.

- Link a test suite to the component or subsystem it tests.

#### To link tests to a model element or relationship

1. In Test Manager, create a requirement and base a test suite on it.

    The requirement that you create is a work item in Team Foundation Server. It might be a User Story, Requirement, or Use Case work item, depending on the process template that your project uses with Team Foundation. For more information, see [About Agile tools and Agile project management](/azure/devops/boards/backlogs/backlogs-overview?view=vsts&preserve-view=true).

2. Link the requirement work item to one or more elements in your model.

    In a modeling diagram, right-click an element, comment or relationship and then click **Link to Work Item**.

3. Add to the test suite, test cases that verify the requirement expressed in the model element.

## Related content

- [Create models for your app](../modeling/create-models-for-your-app.md)
- [Model user requirements](../modeling/model-user-requirements.md)
- [Model your app's architecture](../modeling/model-your-app-s-architecture.md)
- [Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)

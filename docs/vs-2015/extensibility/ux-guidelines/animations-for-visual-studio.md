---
title: "Animations"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: 446773a9-e6f7-4c0c-8dbc-9e303bf32eb1
caps.latest.revision: 3
ms.author: gregvanl
manager: jillfra
---
# Animations for Visual Studio
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

## Animation fundamentals

### Animation best practices in Visual Studio
 Follow these rules to ensure consistent and user-friendly animation styles across Visual Studio’s IDE.

- **Be selective.** Limit animations to those that serve specific purposes.

- **Timing and speed are important** to ensure that transitions feel quick and natural:

  - Complete animated transitions within one half-second (500 milliseconds).

  - Animations that would occur frequently need to be quick enough that they don't interrupt the user's workflow.

  - Animations should not be so fast or jarring that it is difficult to understand, but not so slow that it makes one impatient for the transition to finish.

  - Use variable timing to emphasize importance. For example, when navigating through a sequence of items on a class diagram, speed through transitions between items then slow down to focus on important items.

- **Use gradual non-linear easing** from one state to another, giving a sense of calm and natural movement

- When possible, **use a subtle animation on hover** to indicate interactive elements under the mouse.

- If you rely heavily on animations in your features then **provide a means to turn them off** locally (for all your features) as an option in the **Tools > Options** dialog.

- **Only one animation should occur at a time** and convey just one piece of information.

- **Subtlety is important.** In most cases animation doesn't have to demand user attention to serve its purpose. Subtle changes in timing, sequencing, and behavior may significantly impact perception, and can make the difference between an effective and ineffective animation.

- When using animation to draw attention to something, **make sure that it is worth interrupting the user**'s train of thought.

- **When showing progress or status** through animation:

  - Stop showing progress movement when the underlying process is not advancing.

  - Distinguish indeterminate processes from determinate processes.

  - Ensure that an animation has identifiable completion and failure states.

  - Minimize use of effect animations that show status and make sure that they have real value by providing additional information of actual use. Examples include transient status changes and emergencies

#### Do not:

- Use small movements (movement in a small footprint), preferring fades and changes over moving objects.

- Use animations that take place over a large area of screen real estate. Regardless of size, this style of animation is distracting to the user.

- Use animations that do not relate to the object the user is currently focused on or interacting with.

- Use animations that require user interaction to reset the state, such as forcing the user to respond to a flashing notification in order to make it stop flashing. Interacting with them in any way should be sufficient to dismiss them.

  For more information on applications for these best practices, see [Animation patterns](../../extensibility/ux-guidelines/animations-for-visual-studio.md#BKMK_AnimationPatterns).

### Animation metrics

- The system should visibly react to user gestures in less than 10 milliseconds.

- Animated transitions should not take longer than 500 milliseconds to complete.

- One way to compensate for transitions that require longer times is to separate it into two parts; for example, the first part of an animation could be the empty content container (up to 500 milliseconds) followed by the content fading into the container (up to 500 milliseconds).

- For load times that can be calculated, a determinant progress indicator (percent-done progress indicator) is preferred.

- For load times that cannot be calculated, a busy indicator such as a cursor or embedded spinning animation (loading or working indicator) is appropriate.

### Animation as communicator
 In Visual Studio’s UI, animation functions only as a communication tool.  It is used to communicate a variety of information, such as structural changes in the UI; for example, when a menu opens or closes. Animation can help visualize the time-dependent behavior of complex systems, such as installation progress visualization or be used to attract attention with alerts and notifications.

 UI animations typically function in four ways: visualize, attract attention, simulate, and indicate response times/progress.

#### Visualize
 Animation can emphasize the three-dimensional nature of objects and make it easier for users to visualize their spatial structure. To achieve this, the animation may need to spin the object in a full circle, slowly turn it back and forth, or bring the object closer and slightly increase its size to emphasize rollover or focus.

 Although three-dimensional objects may be moved with user control, the designer should determine in advance (programmatically or manually) how to best animate a movement that provides optimal understanding of the object. This programmed animation can then be activated by the user by placing the cursor over the object, whereas user-controlled movements require the user to understand how to manipulate the object. Limit the movement to a single axis or orientation at a time; either scale, rotate, or translate, but don't do more than one simultaneously.

 The Visualize category includes the aspects of data, relationships, state, structure, sequence, and time.

##### Data
 Illustrate complex and variable information:

- Moving through information visualizations like charts and graphs

- Stepping through a sequence, guided tour, and paging

- Calling out details, pointing, and highlighting specific information

- Overlaying details and additional information on top of a focused element

- Morphing from one structural or organizational representation to another

- Representing changes over time using time sliders, jog-and-shuttle wheels, and transport controls (play, stop, and pause).

##### Relationships

- Illustrate how items relate to one another or which items relate to a given item.

- Show hierarchies and parent-child or sibling relationships

- One element spawns another

- One element minimizes to another element

- One element tethered to another

##### State

- Content updates.

- User focus and selection

- Progress

- Errors

##### Structure

- Pivoting the structure on one node

- Reorienting

- Minimize and maximize, or expand and collapse

##### Sequence

- Slideshow sequence

- Flipping through pictures

##### Time

- Show change over time, time lapse, and screencast

- Move to trash, undo, and redo

- Restore historical state

#### Attract attention
 If the goal is to draw the user's attention to a single element out of several or to alert the user to updated information, then an animation may be appropriate. For example, your applications start page might employ a Getting Started button that slides into place after the page loads.

 As a rule, the last moving element on the screen attracts the user’s attention.  In a series of animated elements, the user’s attention will follow the last moving object.

##### Alert

- Alert the user, get attention, show progress

- Show that something is being done correctly or incorrectly or show progress or progress changes

- Prompt users during a task, such as finding more information online or learning about the current task

##### Notifications

- Alert the user about an error condition

- Interrupt the user to see if they would like to attend to something else

- Gently inform the user that a process has completed or changed, such as when a download is complete.

#### Simulate
 This category covers physicality and dimensionality.

- Illustrate where objects come from or where they go to

- Expand and collapse or open and close

- Panning, scrolling, and page turns

- Stacking and z-ordering

- Carousel and accordion

- Flipping and rotating UI

#### Response and progress indicators
 Progress indicators have a couple of notable advantages:

- Both determinate and indeterminate progress indicators reassure the user that the system has not crashed and is working on the problem.

- Determinate indicators give the user a sense of how far along the action is progressing, as well as a feeling of getting closer to the finish.

## <a name="BKMK_AnimationPatterns"></a> Animation patterns

### Overview
 Animations in Visual Studio are meant to serve a specific function and not hinder user productivity. General animation characteristics to adhere to include:

- Small and unobtrusive

- Natural and realistic

- Subtle and subdued

- Fast and efficient

- Relaxed, not hurried

  The following illustration shows the animation styles recommended for use in Visual Studio. No animation and subtle animations such as fade in/fade out are the most frequently used. There is limited application of movement animations such as expand and contract, X and Y position change, and rotation.

  ![Recommended animation styles for Visual Studio](../../extensibility/ux-guidelines/media/1202-a-vsanimstyles.png "1202-a_VSAnimStyles")

  **Recommended animation styles for Visual Studio**

#### Appear and disappear
 With this pattern, an element switches from visible to out-of-view and back without a transition animation:

 ![Appear&#47;Disappear animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-b-appearanddisappear.png "1202-b_AppearAndDisappear")

##### Correct usage
 Fresh UI elements that need to instantly appear or disappear so that the user is neither distracted nor obstructed. In addition, slow moving animations may be perceived as a performance drag, which won't occur with the appear-and-disappear style.

##### Incorrect usage
 Cases in which UI appears so abruptly the user has no idea what happened, and adding an animation would help with contextual understanding.

##### Animation properties
 The time delay is generally zero seconds.

##### Examples

- Auto-hide tool windows

- Keyboard-activated editor UI, such as IntelliSense and Parameter Help

- Expand-and-collapse code regions

#### Fade-in and fade-out
 With this pattern, a UI element transitions from not visible (0% opacity) to visible (100% opacity) or vice versa:

 ![Fade&#45;in&#47;Fade&#45;out animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-c-fadeinfadeout.png "1202-c_FadeInFadeOut")

##### Correct usage
 This is the most commonly recommended UI animation. It is a subtle effect that adds interest without interrupting flow. In some cases, the user may not even realize that there is an animation and simply perceives a smooth, flowing UI system.

##### Animation properties

- Starting opacity: 0% for fade-in, 100% for fade-out

- Ending opacity: 100% for fade-in, 0% for fade-out

- Duration: 200 milliseconds standalone, 100 milliseconds when used as part of a combination animation sequence

- Easing style: Sine InOut

##### Examples

- Auto-hide tool windows

- Menu open and close

- Background and foreground tab transitions

#### Color blend from A to B
 With this pattern, a UI element changes from color A to color B:

 ![Color blend animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-d-colorblend.png "1202-d_ColorBlend")

##### Correct usage
 As an animated transition when a UI element changes color from one context or state to another.

##### Animation properties

- Starting color: UI-specific

- Ending color: UI-specific

- Duration: 200 milliseconds standalone, 100 milliseconds when used as part of a combination animation sequence

- Easing style: Sine InOut

##### Examples

- Document window state transitions (active, last active, and inactive)

- Tool window state transitions (focused and unfocused)

#### Expand and contract
 With this pattern, a UI element expands in the X, Y, or both directions:

 ![Expand&#47;Contract animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-e-expandcontract.png "1202-e_ExpandContract")

##### Correct usage
 As an animated transition when a UI element changes size from one context to another.

##### Animation properties

- X scale: % or specific dimension (in pixels)

- Y scale: % or specific dimension (in pixels)

- Anchor position: Generally upper-left (for left-to-right languages) or upper-right (for right-to-left languages)

- Duration: 200 milliseconds standalone, 100 milliseconds when used as part of a combination animation sequence

##### Examples

- Architecture Explorer panel expand and collapse

- Start Page item expand and collapse

#### X-Y position change
 With this pattern, a UI element changes its X or Y position or both:

 ![X&#47;Y position change animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-f-xypositionchange.png "1202-f_XYPositionChange")

##### Correct usage
 As an animated transition when a UI element changes position from one context to another.

##### Animation properties

- Starting X and Y position: UI-specific

- Ending X and Y position: UI-specific

- Motion path: None

- Duration: 200 milliseconds standalone, 100 milliseconds when used as part of a combination animation sequence

- Easing style: Sine InOut

##### Example
 Tab reordering

#### Rotate
 With this pattern, the UI element rotates:

 ![Rotate animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-g-rotate.png "1202-g_Rotate")

##### Correct usage
 Only for the indeterminate spinning progress indicator.

##### Animation properties

- Degree of rotation: 360

- Rotation center: Middle of the object

- Duration: Continuous

##### Example
 Indeterminate progress indicator (spinning)

### Common shell UI actions and recommended animations

#### Tab open

- Style: Appear

- Duration: Zero seconds

  ![Tab open animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-h-tabopen.png "1202-h_TabOpen")

#### Tab close

- Style: X position change

- Duration: 200 milliseconds

  ![Tab close animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-i-tabclose.png "1202-i_TabClose")

#### Tab reorder

- Style: X position change

- Duration: 200 milliseconds

  ![Tab reorder animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-j-tabreorder.png "1202-j_TabReorder")

#### Close floating document

- Style: Appear

- Duration: 200 milliseconds

  ![Close floating document animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-k-closefloatingdocument.png "1202-k_CloseFloatingDocument")

#### Window state transition

- Style: To be consistent with other windows, let the current operating system define the document close animation.

- Duration: 200 milliseconds

  ![Window state transition animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-l-windowstatetransition.png "1202-l_WindowStateTransition")

#### Menu open

- Style: Fade-in

- Duration: 200 milliseconds

  ![Menu open animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-m-menuopen.png "1202-m_MenuOpen")

#### Menu close

- Style: Fade-out

- Duration: 200 milliseconds

  ![Menu close animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-n-menuclose.png "1202-n_MenuClose")

#### Auto-hide tool window reveal

- Style: Appear

- Duration: Zero seconds

  ![Auto&#45;hide tool window animation in Visual Studio](../../extensibility/ux-guidelines/media/1202-o-autohidetoolwindowreveal.png "1202-o_AutoHideToolWindowReveal")

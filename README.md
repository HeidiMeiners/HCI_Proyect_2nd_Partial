# HCI_Project_2nd_Partial

## 1. Summary

**Project Description:**

This prototype allows students and professors to borrow Meta Quest 3 headsets. There are six kits available in the application. Some kits may already be loaned to another person, while others may be charging and therefore unavailable for borrowing.

Users can select an available kit, choose how long they want to borrow it, and check whether the kit contains all the required equipment. Once the borrowing process is complete, the application displays the time at which the kit must be returned.

**Objective:**

The goal of this application is to simplify the process of borrowing and returning Meta Quest 3 headsets for students and professors.

## 2. Figma Design

**Figma Link:** [Figma Design](https://www.figma.com/design/JqTF1DllNz3Tk0ABxP0M2z/QUEST-CHECKOUT?node-id=0-1&m=dev)

The Figma design serves as a reference for the application's interface and user experience.

## 3. Contributions

| Team Member | Contributions |
|---|---|
| Heidi Meiners | Developed the working prototype and implemented the project repository on GitHub. |
| Regina López | [Describe the features, design, or implementation tasks completed.] |
| Natalia Trujillo | [Describe the features, design, or implementation tasks completed.] |

## 4. Unity Version and Requirements

- **Unity Version:** Unity 6 (6000.3.5f2)
- **Render Pipeline:** Built-in Render Pipeline

## 5. Setup and Installation

Follow these steps to open and run the project:

1. Clone the repository or download the project files from GitHub.
2. Open Unity Hub.
3. Select **Add Project from Disk**.
4. Navigate to the downloaded project folder and select it.
5. Open the project using Unity version **6000.3.5f2**.
6. Wait for Unity to import the assets and compile the scripts.
7. In the **Project** window, navigate to the `Assets/Scenes`.
8. Open the scene corresponding to the scenario you want to test.
9. Press the **Play** button to run the application.

## 6. Scenarios

### Scenario A: Available Kits

**Description:**

This scenario demonstrates the process of borrowing a Meta Quest 3 headset. Users can browse the six kits, select an available kit, choose the borrowing duration, and check whether the kit is complete before confirming the loan.

**Expected Result:**

The application completes the borrowing process and displays the selected kit's borrowing status and return time.

**How to Run:**

1. Open the scene corresponding to Scenario A.
2. Press **Play**.
3. Select an available kit.
4. Choose the desired borrowing duration.
5. Check the kit's contents and complete the borrowing process.
6. Verify that the application displays the return time.

**How to Reset:**

Click the **Reset** button in the upper-right corner of the application to restore the original scenario.

**How to Test:**

- Verify that available kits can be selected.
- Confirm that the borrowing duration can be selected.
- Check that the kit's contents can be reviewed.
- Verify that the application displays the correct borrowing status and return time.
- Reset the scenario and confirm that the initial kit states are restored.

### Scenario B: No Available Kits

**Description:**

This scenario demonstrates how the application handles situations in which no kits are available for borrowing. All kits are either already loaned to other users or currently charging.

If a user attempts to select a loaned or charging kit, the application displays a warning explaining that the kit cannot be borrowed.

**Expected Result:**

The application displays a warning when the user attempts to select an unavailable kit. The user cannot complete the borrowing process using a loaned or charging kit.

**How to Run:**

1. Open the scene corresponding to Scenario B.
2. Press **Play**.
3. Attempt to select a kit that is already loaned or charging.
4. Verify that the application displays the appropriate warning.

**How to Test:**

- Verify that loaned kits cannot be selected for borrowing.
- Verify that charging kits cannot be selected for borrowing.
- Confirm that the appropriate warning appears when an unavailable kit is selected.
- Ensure that the borrowing process cannot be completed with an unavailable kit.

## 7. Controls

| Input | Action |
|---|---|
| Mouse click | Select buttons, kits, and other interactive elements. |
| Reset button | Restore the scenario to its initial state. |

## 8. Limitations

The current prototype has the following limitations:

- Users cannot see when a loaned headset is expected to be returned.
- Users cannot see how much time remains before a charging kit becomes fully charged and available.

These limitations may affect the user's ability to determine when unavailable kits will become available for borrowing.
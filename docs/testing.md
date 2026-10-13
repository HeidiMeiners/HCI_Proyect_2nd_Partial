# Usability Testing Report (docs/testing.md)

## 1. External Usability Testers

Testing was conducted with three participants outside the development team without step-by-step guidance:

| Participant ID | Gender | Age | Scenario A Completion | Scenario B Completion | Key Observations / Feedback |
| :--- | :--- | :--- | :--- | :--- | :--- |
| *User 1 (P01)* | Female | 56 | Completed | Completed | Had slight hesitation with thin UI text readability on secondary screens. |
| *User 2 (P02)* | Male | 31 | Completed | Completed | Navigated the checkout flow smoothly. Suggested clearer visual distinction for system buttons. |
| *User 3 (P03)* | Male | 60 | Completed | Completed | Leaned closer to the screen to read thin default fonts. Mentioned red buttons for charging alerts felt misleading. |

---

## 2. Identified Usability Problems & Implemented Fixes

Based on real observations during external testing, two key usability issues were identified, corrected in Unity, and retested:

### Problem 1: Low Text Contrast and Small Button Readability (Accessibility Issue)
* *Observation:* User 3 (60 years old) struggled to read the UI titles and action buttons due to the thin font weight, forcing him to lean close to the display. Additionally, the *Reset* button was too small and hard to locate.
* *HCI Principle:* Visibility, Readability, and Universal Accessibility.
* *Fix Applied:* Changed the primary UI typography and button font weights to Bold. Increased the overall scale and font weight of the *Reset* button to ensure immediate visual prominence.
* *Result:* Readability improved significantly across all age groups, allowing faster navigation without visual strain.

#### Visual Evidence (Before vs. After):
*Main Instructions Font Weight Adjustment:*

![Font Weight Fix](https://github.com/user-attachments/assets/bca22ef3-b7b4-4010-99e0-a6bdd2e2e848)

*Reset Button Size & Font Weight Adjustment:*

![Reset Button Fix](https://github.com/user-attachments/assets/35fd1148-0c5a-4b14-bd3b-fce0f56f799e)

---

### Problem 2: Misleading Button Color Palette (Visual Consistency Issue)
* *Observation:* When selecting a headset currently in charging status, a modal pop-up displayed a bright *Red* "Ok" button. Testers associated red with a severe system error or destructive action rather than an informative status message.
* *HCI Principle:* Consistency and Standards / Match Between System and Real World.
* *Fix Applied:* Updated the confirmation button color from *Red* to *Yellow* for charging state alerts to establish visual continuity with warning/charging status color codes.
* *Result:* Improved color hierarchy and reduced user confusion when encountering unavailable charging kits.

#### Visual Evidence (Before vs. After):
*Charging Alert Color Palette Fix:*

![Color Hierarchy Fix](https://github.com/user-attachments/assets/1d7c3018-9077-458e-a38a-9002f248a8fa)

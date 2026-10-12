# AI Usage Log

## 1. AI Usage: Formatting for documentation
-   **Tool:** Gemini
-   **Date:** October 12, 2026
-   **Teammate:** Regina López Almodóvar
-   **Purpose:** Learn how to format text in .md files (bold, titles, bullet points) for the design.
-   **Prompt:** "formats for a docs.md, I want comments, title text, bold text and just text"
-   **Response used:** Title: Use a number or hash symbol (#), Bold text: Place double asterisks (**), Normal text: Simply write directly, Comments (hidden): Use HTML syntax opening with < !-- and closing with -- >.
-   **Modifications:** This was applied for the creation and design of the .md files.
-   **Verification:** The file was reviewed on GitHub to ensure it looked as expected.
-   **Related work:** `docs/design.md`

## 2. AI Usage: Git command control
-   **Tool:** Gemini
-   **Date:** October 12, 2026
-   **Teammate:** Regina López Almodóvar
-   **Purpose:** Correctly upload the documentation files to the correct branch in the team repository.
-   **Prompt:** "how do I make all my changes go to my GitHub branch from the terminal?"
-   **Response used:** Using the commands in the following order: `git add .`, `git commit -m "meaningful text"`, and `git push -u origin Regi`.
-   **Modifications:** The commit message was modified to a descriptive one ("add the design justification and the figma vs unity comparation").
-   **Verification:** On the GitHub website, the "Regi" branch was updated with the new `.md` files.
-   **Related work:** GitHub repository / General documentation.

## 3. AI Usage: README Structure
-   **Tool:** ChatGPT
-   **Date:** October 12, 2026
-   **Teammate:** Heidi Meiners
-   **Purpose:** Create an initial base structure to meet all the README requirements.
-   **Prompt:** "make me a template for my project's README on GitHub."
-   **Response used:** Below is a base template with summary, installation, and usage sections.
-   **Modifications:** The generic content was removed and the specific sections required by the rubric were added (Figma link, Unity version, and kiosk controls, etc.).
-   **Verification:** It was validated that the final README in the repository covered every point required for grading.
-   **Related work:** `README.md`

## 4. AI Usage: Unity Interface Logic (Canvas)
-   **Tool:** ChatGPT
-   **Date:** October 12, 2026
-   **Teammate:** Heidi Meiners
-   **Purpose:** Control the visibility of graphical elements and screens in the Unity interface.
-   **Prompt:** "how do I make things appear and disappear in a canvas"
-   **Response used:** There are two main ways to make user interface (UI) elements appear and disappear inside a Canvas in Unity through code (C#). 1. Activate and Deactivate the GameObject (The simplest method) 2. Use a Canvas Group (Recommended for performance and animations).
-   **Modifications:** The code was adapted to link it to the buttons that disappear from the kiosk.
-   **Verification:** Play mode was executed in Unity, clicking the buttons to verify that the elements appeared and disappeared at the right time.
-   **Related work:** Unity Implementation (C# Scripts and Canvas hierarchy).
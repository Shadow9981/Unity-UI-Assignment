# Unity-UI-Assignment  
Unity Developer Assessment Task for Playing Human Studios  

---

## Overview  
This project implements a structured UI system in Unity, including dynamic button handling and popup management. The interface is built with panels for a clear and organized layout, following a scalable design that adapts to different screen resolutions. Below, you will find a detailed explanation of the code and the UI setup.  

---

## Code Explanation  

### Script: `UI_Manager`  
This script manages the interactions and animations of the UI elements, focusing on showing and hiding a popup panel when buttons are clicked.  

### Key Components  

- **ShowPopup(Button clickedButton):**  
  - Displays the popup panel when a button is pressed.  
  - Updates the popup text to reflect the name of the pressed button.  
  - Animates the popup panel from off-screen to the center using DOTween.  
  - Marks the popup as active.  

- **ClosePopup():**  
  - Hides the popup panel by animating it off-screen.  
  - Logs the closure for debugging.  
  - Resets the popup state to inactive.  

- **Update():**  
  - Listens for two user actions:  
    - Pressing the back button (or Escape key) to close the popup.  
    - Clicking outside the popup to close it.  
  - Uses `RectTransformUtility.RectangleContainsScreenPoint` to detect clicks outside the popup area.  

### Scalability  
- The popup animations are smooth and parameterized (`fadeTime`), making the UI easy to adjust.  

---

## UI Setup  

### Canvas Setup  

- **Scaling Mode:**  
  - Scale with Screen Size with a reference resolution of 1920x1080 for responsiveness across different devices.  

### Panel Layout  

- **Root Canvas:**  
  - Contains all the UI elements organized in panels for a clean structure.  

- **Panels:**  
  - **Top Panel:**  
    - Displays player and match info.  

  - **Left Panel:**  
    - Contains 5 buttons:  
      - Playstore  
      - Store  
      - Settings  
      - Achievements  
      - Social  
    - **Layout:** Arranged using a Vertical Layout Group for even spacing and alignment.  

  - **Center Panel:**  
    - The main section of the UI, divided into:  
      - **Game Info Section:** Shows key information about the game.  
      - **Headline Section (Right):** Displays additional headlines or updates.  

  - **Bottom Panel:**  
    - Contains 3 buttons:  
      - Play  
      - Threats  
      - Ground Report  

  - **Popup Panel:**  
    - Displays the name of the button that was clicked.  
    - **Components:**  
      - **Background Image (bg):** Provides a backdrop for the popup.  
      - **Foreground Image (fg):** Highlights the content area.  
      - **Close Button:** Allows the user to dismiss the popup.  
      - **Text Element:** Dynamically updates to show which button was pressed.  
    - **Animation:**  
      - Appears in the center of the screen when a button is clicked and hides when the close button is pressed or the user interacts outside the panel.  

---

## Features  

- **Dynamic Popup Handling:**  
  - The popup displays the name of the button pressed dynamically.  
  - Closes on pressing the back button, clicking outside the popup, or pressing the close button.  

- **Responsive Design:**  
  - UI elements are laid out to adapt to different screen sizes and resolutions seamlessly.  

- **Animations with DOTween:**  
  - Smooth entry and exit animations for the popup panel enhance user experience.  

---

## How to Use  

### Setup:  
- Import the project into Unity.  
- Ensure DOTween is installed in your project.  

### Interaction:  
- Click any button to display the popup.  
- The popup shows the button's name and can be closed by:  
  - Clicking the close button.  
  - Clicking outside the popup.  
  - Pressing the back button (Escape key).  

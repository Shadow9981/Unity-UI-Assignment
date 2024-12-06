using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField] float fadeTime = 20f; // The duration of the popup animation (fade-in and fade-out).
    [SerializeField] RectTransform popUpPanel; // The RectTransform of the popup panel to control its position.
    [SerializeField] TextMeshProUGUI textElement; // The TextMeshPro text element to display button-related information.

    bool isPopupActive = false; // Tracks whether the popup is currently visible or not.

    /// <summary>
    /// Displays the popup panel with a message indicating the clicked button's name.
    /// </summary>
    public void ShowPopup()
    {
        // Update the text of the popup with the name of the clicked button.
        textElement.text = "Pressed " + gameObject.name;

        // Set the popup's initial position off-screen (below the visible area).
        popUpPanel.transform.localPosition = new Vector3(0f, -1500f, 0f);

        // Animate the popup into view using DOTween.
        popUpPanel.DOAnchorPos(new Vector3(0f, 0f, 0f), fadeTime, false);

        // Mark the popup as active.
        isPopupActive = true;
    }

    /// <summary>
    /// Hides the popup panel and resets its state.
    /// </summary>
    public void ClosePopup()
    {
        // If the popup is not active, exit early to avoid redundancy.
        if (!isPopupActive) return;

        // Log the closure of the popup (for debugging purposes).
        Debug.Log("Popup closed");

        // Animate the popup out of view (moving it above the visible area).
        popUpPanel.DOAnchorPos(new Vector3(0f, 1500f, 0f), fadeTime, false);

        // Mark the popup as inactive.
        isPopupActive = false;
    }

    /// <summary>
    /// Handles user interactions to close the popup (back button or click outside the popup).
    /// </summary>
    void Update()
    {
        // Close the popup when the Escape key (back button) is pressed and the popup is active.
        if (Input.GetKeyDown(KeyCode.Escape) && isPopupActive)
        {
            ClosePopup();
        }

        // Close the popup when the user clicks outside the popup panel.
        if (Input.GetMouseButtonDown(0) && isPopupActive)
        {
            // Check if the click position is outside the popup panel's bounds.
            if (!RectTransformUtility.RectangleContainsScreenPoint(popUpPanel, Input.mousePosition, Camera.main))
            {
                ClosePopup();
            }
        }
    }
}
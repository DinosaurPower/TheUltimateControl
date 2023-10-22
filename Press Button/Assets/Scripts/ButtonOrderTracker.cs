using UnityEngine;
using TMPro;
public class ButtonOrderTracker : MonoBehaviour
{
    // Define an array to store the expected order of button clicks
    public string[] expectedOrder = { "Button1", "Button2", "Button3" };
    private int currentIndex = 0;
    public TMP_Text OldText;
    public string NewText;
    public Tracker tracker;

    void Start(){
        tracker = GetComponent<Tracker>();
    }

    // Define a function to handle button clicks
    public void HandleButtonClick(string buttonName)
    {
        if (buttonName == expectedOrder[currentIndex])
        {
            currentIndex++;

            if (currentIndex == expectedOrder.Length)
            {
                Debug.Log("Button click order is correct!");
                // Perform additional actions when the correct order is achieved.
                // For example, reset the currentIndex.
                currentIndex = 0;
                OldText.text = NewText;
                tracker.ButtonsClicked = true;
            }
        }
        else
        {
            Debug.Log("Button click order is incorrect. Resetting...");
            currentIndex = 0; // Reset if the order is incorrect.

        }
    }
}
using UnityEngine;

public class ButtonOrderTracker : MonoBehaviour
{
    // Define an array to store the expected order of button clicks
    public string[] expectedOrder = { "Button1", "Button2", "Button3" };
    private int currentIndex = 0;

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
            }
        }
        else
        {
            Debug.Log("Button click order is incorrect. Resetting...");
            currentIndex = 0; // Reset if the order is incorrect.
        }
    }
}
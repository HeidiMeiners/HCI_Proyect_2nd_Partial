using TMPro;
using UnityEngine;

public class CanvasB : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainPanel;

    [Header("Warning")]
    public TMP_Text warningText;
    public GameObject warning;

    private string[] kits = { "charging", "loaned", "charging", "charging", "loaned", "loaned" };

    public void mainButton(int nkit)
    {
        string message = "";
        if (kits[nkit - 1] == "loaned")
        {
            message = "You can’t select a headset that is loaned, please choose and other one";
        }
        else if (kits[nkit - 1] == "incomplete")
        {
            message = "You can’t select a headset that is incomplete, please choose and other one";
        }
        else
        {
            message = "You can’t select a headset that is charging, please choose and other one";
        }
        warning.SetActive(true);
        warningText.text = message;
    }

    public void HideWarning()
    {
        warning.SetActive(false);
    }
}

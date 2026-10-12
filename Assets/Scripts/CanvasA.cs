
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ColorUtility = UnityEngine.ColorUtility;

public class CanvasA : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainPanel;
    public GameObject timePanel;
    public GameObject finalPanel;

    [Header("Warning")]
    public TMP_Text warningText;
    public GameObject warning;

    [Header("Confirmation")]
    public TMP_Text confirmationText;
    public GameObject confirmation;

    [Header("Finish")]
    public TMP_Text finalMessaje;
    public GameObject final;
    public Button finish;
    public Button ok;

    [Header("Kits")]
    public List<Button> buttons;

    private int kit;
    private int minutesSelected;
    private string[] kits = { "available", "available", "available", "charging", "loaned", "loaned" };

    public void mainButton(int nkit)
    {
        string message = "";
        if (kits[nkit - 1] == "available")
        {
            kit = nkit;
            showTime();
            return;
        }
        else if (kits[nkit - 1] == "loaned")
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

    public void showTime()
    {
        timePanel.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void selectedTime(int minutes)
    {
        minutesSelected = minutes;
        confirmation.SetActive(true);
        string text = "You have selected kit number " + kit.ToString() + " for " + minutes.ToString() + " minutes, is it correct?";
        confirmationText.text = text;
    }

    public void confirmationYes()
    {
        timePanel.SetActive(false);
        confirmation.SetActive(false);
        finalPanel.SetActive(true);
    }

    public void confirmationNo()
    {
        timePanel.SetActive(false);
        confirmation.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void complete()
    {
        confirmation.SetActive(false);
        final.SetActive(true);
        DateTime currentTime = DateTime.Now;
        DateTime newTime = currentTime.AddMinutes(minutesSelected);

        finalMessaje.text = "Thanks for borrowing the kit, please return it at " + newTime.ToString("HH:mm");
        kits[kit - 1] = "loaned";
        ok.gameObject.SetActive(false);
        finish.gameObject.SetActive(true);
    }

    public void incomplte()
    {
        confirmation.SetActive(false);
        final.SetActive(true);
        finalMessaje.text = "We apologize for the inconvenience, please select another kit.";
        kits[kit] = "incomplete";
        finish.gameObject.SetActive(false);
        ok.gameObject.SetActive(true);
    }

    public void backtoMain()
    {
        final.SetActive(false);
        string hexColor;
        for (int i = 0; i < 6; i++)
        {
            TMP_Text buttonText = buttons[i].GetComponentInChildren<TMP_Text>();
            buttonText.text = kits[i];

            if (kits[i] == "loaned" || kits[i] == "incomplete")
            {
                hexColor = "#C92A00";
            }
            else if (kits[i] == "charging")
            {
                hexColor = "#FFEB04";
            }
            else
            {
                hexColor = "#009114";
            }

            if (ColorUtility.TryParseHtmlString(hexColor, out Color newColor))
            {
                ColorBlock colors = buttons[i].colors;
                colors.normalColor = newColor;
                colors.highlightedColor = newColor;
                buttons[i].colors = colors;
            }
        }
        finalPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    public void reset()
    {
        kits = new string[] { "available", "available", "available", "charging", "loaned", "loaned" };
        backtoMain();
    }
}

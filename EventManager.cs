using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System.Linq;

public class EventManager : MonoBehaviour
{
    public Event startEvent;
    public TextMeshProUGUI eventText;
    public Button choice1Button;
    public Button choice2Button;

    private Option Choice1;
    private Option Choice2;


    void Start()
    {
        DisplayEventInfo(startEvent);
    }


    void Update()
    {

    }
    private void DisplayEventInfo(Event eventInfo)
    {
        eventText.text = eventInfo.eventText;
        choice1Button.GetComponentInChildren<Text>().text = eventInfo.playerOptions.ElementAt(0).optionText;
        Choice1 = eventInfo.playerOptions.ElementAt(0);
        choice2Button.GetComponentInChildren<Text>().text = eventInfo.playerOptions.ElementAt(1).optionText;
        Choice2 = eventInfo.playerOptions.ElementAt(1);
    }
    public void SelectButton(int Choice)
    {
        if (Choice == 1)
        {
            DisplayEventInfo(Choice1.nextEvent);
        }
        else if (Choice == 2)
        {
            DisplayEventInfo(Choice2.nextEvent);
        }
    }
}

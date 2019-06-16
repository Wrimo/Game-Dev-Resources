using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event", menuName = "Events")]
public class Event : ScriptableObject
{
    public string eventName;
    public string eventText;
    public List<Option> playerOptions = new List<Option>(); 
   
}

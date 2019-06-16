using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Option", menuName = "Options")]
public class Option : ScriptableObject
{
    public string optionName;
    public string optionText;
    public Event nextEvent; 
}

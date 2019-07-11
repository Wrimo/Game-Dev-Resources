using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer
{
    public int CountTo;
    public int StartCount;
    public int Increment;
    public int CurrentCount;

    public Timer()
    {
        CountTo = 60;
        StartCount = 0;
        Increment = 1;
        CurrentCount = 0; 
    }
    public Timer(int countTo, int startCount, int increment, int currentCount)
    {
        CountTo = countTo;
        StartCount = startCount;
        Increment = increment;
        CurrentCount = currentCount;
    }

    public bool CheckTimer()
    {
        if(CurrentCount >= CountTo)
        {
            return true; 
        } 
        else
        {
            return false;
        }
    }
    
    public void TimerIncrement()
    {
        CurrentCount += Increment; 
    }

    public void ResetTimer()
    {
        CurrentCount = 0; 
    }
}

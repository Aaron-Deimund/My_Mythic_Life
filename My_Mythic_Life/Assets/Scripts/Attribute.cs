using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attribute : Player
{
    public int currXP;
    public int maxXP;
    private readonly Slider _progressionBar;
    public Attribute(Slider progressionBar)
    {
        _progressionBar = progressionBar;
    }

    public void IncreaseXP(float xp)
    {
        if ((currXP + xp) >= maxXP)
        {
            xp = currXP + xp - maxXP;
            IncreaseFitnessLevel();
        }
            
        _progressionBar.value += xp;
        currXP = (int)_progressionBar.value;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal 
{
    public float value;
    public GoalList GoalName;

    public Goal(GoalList goalname, float value)
    {
        GoalName = goalname;
        this.value = value;
    }

    public float GetDiscontentment(float value)
    {
        return value * value;
    }
}

public enum GoalList{

    Eat,
    Sleep,
    Bathroom
}

public class Action 
{
    public string name;

    public List<Goal> targetGoals;

    public Action(string name)
    {
        this.name = name;
        targetGoals = new List<Goal>();
    }


    public float GetGoalChange(Goal goal)
    {
        foreach(Goal target in targetGoals)
        {
            if(target.GoalName == goal.GoalName)
            {
                return target.value;
            }
        }

        return 0f;
    }
}
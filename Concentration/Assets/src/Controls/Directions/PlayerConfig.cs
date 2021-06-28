using System;
using System.Collections;
using UnityEngine;

public static class PlayerConfig
{
    public static readonly int MOVEMENT_OFFSET = 2;

    public static readonly ArrayList ValidMoves = new ArrayList
    {
        Directions.Right,
        Directions.Left
    };

    public static bool GetRightKeyPressed()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            return true;
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            return true;
        }

        return false;
    }

    public static bool GetLeftKeyPressed()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            return true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            return true;
        }

        return false;
    }
}

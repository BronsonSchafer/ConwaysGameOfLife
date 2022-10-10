using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    // gets the color
    public Color GetColor(int stage, float trans){
        return GetStage(stage, trans);
    }

    private Color Stages(int stage, float trans){
        Color color = new Color;

        switch(stage){
            case 0:
                return new Color(1.0f, 1.0f, 1.0f, trans);
            case 1:
                return new Color(1.0f, 1.0f, 1.0f, trans);
            case 2:
                return new Color(1.0f, 1.0f, 1.0f, trans);
            case 3:
                return new Color(1.0f, 1.0f, 1.0f, trans);
            case 4:
                return new Color(1.0f, 1.0f, 1.0f, trans);
            default:
                break;
        }
    }
}

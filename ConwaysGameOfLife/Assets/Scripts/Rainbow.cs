using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rainbow : MonoBehaviour
{
    // gets the color
    public Color GetColor(int stage, float trans){
        return GetStage(stage, trans);
    }

    private Color GetStage(int stage, float trans){
        Color color = new Color();

        switch(stage){
            case 0:
                return new Color(220/255f, 20/255f, 60/255f, trans);
            case 1:
                return new Color(225/255f, 48/255f, 105/255f, trans);
            case 2:
                return new Color(229/255f, 76/255f, 150/255f, trans);
            case 3:
                return new Color(234/255f, 103/255f, 195/255f, trans);
            case 4:
                return new Color(236/255f, 129/255f, 238/255f, trans);
            case 5:
                return new Color(175/255f, 96/255f, 242/255f, trans);
            case 6:
                return new Color(115/255f, 63/255f, 247/255f, trans);
            case 7:
                return new Color(55/255f, 30/255f, 251/255f, trans);
            case 8:
                return new Color(0/255f, 3/255f, 250/255f, trans);
            case 9:
                return new Color(0/255f, 35/255f, 185/255f, trans);
            case 10:
                return new Color(0/255f, 67/255f, 121/255f, trans);
            case 11:
                return new Color(0/255f, 100/255f, 57/255f, trans);
            case 12:
                return new Color(8/255f, 132/255f, 0/255f, trans);
            case 13:
                return new Color(72/255f, 164/255f, 0/255f, trans);
            case 14:
                return new Color(137/255f, 196/255f, 0/255f, trans);
            case 15:
                return new Color(201/255f, 228/255f, 0/255f, trans);
            case 16:
                return new Color(254/255f, 246/255f, 2/255f, trans);
            case 17:
                return new Color(245/255f, 186/255f, 18/255f, trans);
            case 18:
                return new Color(236/255f, 127/255f, 33/255f, trans);
            case 19:
                return new Color(227/255f, 67/255f, 48/255f, trans);
            default:
                return new Color(220/255f, 20/255f, 60/255f, trans);
                break;
        }
        return new Color(0.0f, 0.0f, 0.0f, trans);
    }
}

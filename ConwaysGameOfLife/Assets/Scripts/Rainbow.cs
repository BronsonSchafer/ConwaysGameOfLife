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
                return new Color(221/255f, 26/255f, 69/255f, trans);
            case 2:
                return new Color(222/255f, 31/255f, 78/255f, trans);
            case 3:
                return new Color(223/255f, 37/255f, 87/255f, trans);
            case 4:
                return new Color(224/255f, 42/255f, 96/255f, trans);
            case 5:
                return new Color(225/255f, 48/255f, 105/255f, trans);
            case 6:
                return new Color(225/255f, 53/255f, 114/255f, trans);
            case 7:
                return new Color(226/255f, 59/255f, 123/255f, trans);
            case 8:
                return new Color(227/255f, 64/255f, 132/255f, trans);
            case 9:
                return new Color(228/255f, 70/255f, 141/255f, trans);
            case 10:
                return new Color(229/255f, 76/255f, 150/255f, trans);
            case 11:
                return new Color(230/255f, 81/255f, 159/255f, trans);
            case 12:
                return new Color(231/255f, 87/255f, 168/255f, trans);
            case 13:
                return new Color(232/255f, 92/255f, 177/255f, trans);
            case 14:
                return new Color(233/255f, 98/255f, 186/255f, trans);
            case 15:
                return new Color(234/255f, 103/255f, 195/255f, trans);
            case 16:
                return new Color(235/255f, 109/255f, 204/255f, trans);
            case 17:
                return new Color(235/255f, 114/255f, 213/255f, trans);
            case 18:
                return new Color(236/255f, 120/255f, 222/255f, trans);
            case 19:
                return new Color(237/255f, 126/255f, 231/255f, trans);
            case 20:
                return new Color(236/255f, 129/255f, 238/255f, trans);
            case 21:
                return new Color(224/255f, 122/255f, 239/255f, trans);
            case 22:
                return new Color(212/255f, 116/255f, 240/255f, trans);
            case 23:
                return new Color(200/255f, 109/255f, 241/255f, trans);
            case 24:
                return new Color(188/255f, 102/255f, 242/255f, trans);
            case 25:
                return new Color(175/255f, 96/255f, 242/255f, trans);
            case 26:
                return new Color(163/255f, 89/255f, 243/255f, trans);
            case 27:
                return new Color(151/255f, 83/255f, 244/255f, trans);
            case 28:
                return new Color(139/255f, 76/255f, 245/255f, trans);
            case 29:
                return new Color(127/255f, 70/255f, 246/255f, trans);
            case 30:
                return new Color(115/255f, 63/255f, 247/255f, trans);
            case 31:
                return new Color(103/255f, 56/255f, 248/255f, trans);
            case 32:
                return new Color(91/255f, 50/255f, 248/255f, trans);
            case 33:
                return new Color(79/255f, 43/255f, 249/255f, trans);
            case 34:
                return new Color(67/255f, 37/255f, 250/255f, trans);
            case 35:
                return new Color(55/255f, 30/255f, 251/255f, trans);
            case 36:
                return new Color(43/255f, 24/255f, 252/255f, trans);
            case 37:
                return new Color(31/255f, 17/255f, 253/255f, trans);
            case 38:
                return new Color(19/255f, 11/255f, 254/255f, trans);
            case 39:
                return new Color(7/255f, 4/255f, 254/255f, trans);
            case 40:
                return new Color(0/255f, 3/255f, 250/255f, trans);
            case 41:
                return new Color(0/255f, 9/255f, 237/255f, trans);
            case 42:
                return new Color(0/255f, 16/255f, 224/255f, trans);
            case 43:
                return new Color(0/255f, 22/255f, 211/255f, trans);
            case 44:
                return new Color(0/255f, 28/255f, 198/255f, trans);
            case 45:
                return new Color(0/255f, 35/255f, 185/255f, trans);
            case 46:
                return new Color(0/255f, 41/255f, 173/255f, trans);
            case 47:
                return new Color(0/255f, 48/255f, 160/255f, trans);
            case 48:
                return new Color(0/255f, 54/255f, 147/255f, trans);
            case 49:
                return new Color(0/255f, 61/255f, 134/255f, trans);
            case 50:
                return new Color(0/255f, 67/255f, 121/255f, trans);
            case 51:
                return new Color(0/255f, 74/255f, 108/255f, trans);
            case 52:
                return new Color(0/255f, 80/255f, 95/255f, trans);
            case 53:
                return new Color(0/255f, 87/255f, 82/255f, trans);
            case 54:
                return new Color(0/255f, 93/255f, 70/255f, trans);
            case 55:
                return new Color(0/255f, 100/255f, 57/255f, trans);
            case 56:
                return new Color(0/255f, 106/255f, 44/255f, trans);
            case 57:
                return new Color(0/255f, 112/255f, 31/255f, trans);
            case 58:
                return new Color(0/255f, 119/255f, 18/255f, trans);
            case 59:
                return new Color(0/255f, 125/255f, 5/255f, trans);
            case 60:
                return new Color(8/255f, 132/255f, 0/255f, trans);
            case 61:
                return new Color(21/255f, 138/255f, 0/255f, trans);
            case 62:
                return new Color(33/255f, 145/255f, 0/255f, trans);
            case 63:
                return new Color(46/255f, 151/255f, 0/255f, trans);
            case 64:
                return new Color(59/255f, 158/255f, 0/255f, trans);
            case 65:
                return new Color(72/255f, 164/255f, 0/255f, trans);
            case 66:
                return new Color(85/255f, 170/255f, 0/255f, trans);
            case 67:
                return new Color(98/255f, 177/255f, 0/255f, trans);
            case 68:
                return new Color(111/255f, 183/255f, 0/255f, trans);
            case 69:
                return new Color(124/255f, 190/255f, 0/255f, trans);
            case 70:
                return new Color(137/255f, 196/255f, 0/255f, trans);
            case 71:
                return new Color(149/255f, 202/255f, 0/255f, trans);
            case 72:
                return new Color(162/255f, 209/255f, 0/255f, trans);
            case 73:
                return new Color(175/255f, 215/255f, 0/255f, trans);
            case 74:
                return new Color(188/255f, 222/255f, 0/255f, trans);
            case 75:
                return new Color(201/255f, 228/255f, 0/255f, trans);
            case 76:
                return new Color(214/255f, 234/255f, 0/255f, trans);
            case 77:
                return new Color(227/255f, 241/255f, 0/255f, trans);
            case 78:
                return new Color(240/255f, 247/255f, 0/255f, trans);
            case 79:
                return new Color(252/255f, 254/255f, 0/255f, trans);
            case 80:
                return new Color(254/255f, 246/255f, 2/255f, trans);
            case 81:
                return new Color(252/255f, 234/255f, 5/255f, trans);
            case 82:
                return new Color(250/255f, 222/255f, 8/255f, trans);
            case 83:
                return new Color(248/255f, 210/255f, 12/255f, trans);
            case 84:
                return new Color(247/255f, 198/255f, 15/255f, trans);
            case 85:
                return new Color(245/255f, 186/255f, 18/255f, trans);
            case 86:
                return new Color(243/255f, 174/255f, 21/255f, trans);
            case 87:
                return new Color(241/255f, 162/255f, 24/255f, trans);
            case 88:
                return new Color(239/255f, 151/255f, 27/255f, trans);
            case 89:
                return new Color(238/255f, 139/255f, 30/255f, trans);
            case 90:
                return new Color(236/255f, 127/255f, 33/255f, trans);
            case 91:
                return new Color(234/255f, 115/255f, 36/255f, trans);
            case 92:
                return new Color(232/255f, 103/255f, 39/255f, trans);
            case 93:
                return new Color(231/255f, 91/255f, 42/255f, trans);
            case 94:
                return new Color(229/255f, 79/255f, 45/255f, trans);
            case 95:
                return new Color(227/255f, 67/255f, 48/255f, trans);
            case 96:
                return new Color(225/255f, 56/255f, 51/255f, trans);
            case 97:
                return new Color(224/255f, 44/255f, 54/255f, trans);
            case 98:
                return new Color(222/255f, 32/255f, 57/255f, trans);
            case 99:
                return new Color(220/255f, 20/255f, 60/255f, trans);
            default:
                return new Color(220/255f, 20/255f, 60/255f, trans);
                break;
        }
        return new Color(0.0f, 0.0f, 0.0f, trans);
    }
}

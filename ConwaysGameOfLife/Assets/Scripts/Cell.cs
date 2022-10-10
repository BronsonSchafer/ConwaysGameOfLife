using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// controls basic logic for if a cell is alive or dead
public class Cell : MonoBehaviour
{
    public bool isAlive = false;
    public int aliveState = 0;
    public int numNeighbors = 0;
    private int maxState = 100;
    // start colors 
    private float rS = 1.0f;
    private float gS = 0.412f;
    private float bS = 0.706f;
    // end color 
    private float rE = 1.0f - 0.627f;
    private float gE = 0.412f - 0.125f;
    private float bE = 0.941f - 0.706f;

    public void SetAlive (bool alive){
        isAlive = alive;
        if(alive){
            GetComponent<SpriteRenderer>().enabled = true;
            // GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, (1.0f));
            GetComponent<SpriteRenderer>().color = new Color(rS, gS, bS, (1.0f));
            aliveState = this.maxState;
        }
        else
        {
            if(aliveState == 0){
                GetComponent<SpriteRenderer>().enabled = false;
            }
        }
    }

    public void LowerAliveState(){
        if (!isAlive)
        {
            if(aliveState >= 0){
                aliveState-=1;
                // max = 1.0, min == 0.0
                float percent = aliveState*0.01f;
                GetComponent<SpriteRenderer>().color = new Color(rS - (rE*(1-percent)), gS - (gE*(1-percent)), bS + (bE*(1-percent)), percent);
            }

        }
    }
}

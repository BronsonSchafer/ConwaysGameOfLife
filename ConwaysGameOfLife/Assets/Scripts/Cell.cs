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
    private float rS = 0.0f;
    private float gS = 0.0f;
    private float bS = 1.0f;
    // end color 
    private float rE = 0.0f;
    private float gE = 1.0f;
    private float bE = 0.0f;

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
                //double scale = (1.0f)/maxState
                GetComponent<SpriteRenderer>().color = new Color(rS - rE*(1 - aliveState*0.01f), gS + gE*(1 - aliveState*0.01f), bS - (1 - aliveState*0.01f), (aliveState)*(0.01f));
            }

        }
    }
}

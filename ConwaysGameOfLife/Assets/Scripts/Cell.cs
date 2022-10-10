using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// controls basic logic for if a cell is alive or dead
public class Cell : MonoBehaviour
{
    public bool isAlive = false;
    public int aliveState = 0;
    public int numNeighbors = 0;
    private int maxState = 20;
    // start colors 
    private float rS = 220/255f;
    private float gS = 20/255f;
    private float bS = 60/255f;
    // rainbow value
    Rainbow rainbow = new Rainbow();

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
                float trans = aliveState*0.05f;
                //trans = 1.0f;
                GetComponent<SpriteRenderer>().color = rainbow.GetColor(aliveState, trans);
            }
            else{
                GetComponent<SpriteRenderer>().enabled = false;
            }

        }
    }
}

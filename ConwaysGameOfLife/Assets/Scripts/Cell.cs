using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// controls basic logic for if a cell is alive or dead
public class Cell : MonoBehaviour
{
    public bool isAlive = false;
    public int aliveState = 0;
    public int numNeighbors = 0;
    public int maxState = 50;

    public void SetAlive (bool alive){
        isAlive = alive;
        if(alive){
            GetComponent<SpriteRenderer>().enabled = true;
            aliveState = maxState;
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
            aliveState-=1;
            if(aliveState >= 0){
                // max = 1.0, min == 0.0
                GetComponent<SpriteRenderer>().color = new Color(1.0f, 1.0f, 1.0f, aliveState*(0.02f));
            }

        }
    }
}

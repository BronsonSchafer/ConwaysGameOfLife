using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// controls basic logic for if a cell is alive or dead
public class Cell : MonoBehaviour
{
    public bool isAlive = false;
    public int numNeighbors = 0;

    public void SetAlive (bool alive){
        isAlive = alive;
        if(alive){
            GetComponent<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}

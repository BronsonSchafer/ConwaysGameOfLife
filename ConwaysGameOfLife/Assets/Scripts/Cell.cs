using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// controls basic logic for if a cell is alive or dead
public class Cell : MonoBehaviour
{
    public bool isAlive = false;
    public int numNieghbors = 0;

    public void SetAlive (bool alive){
        isAlive = alive;
        if(alive){
            GetComponet<SpriteRenderer>().enabled = true;
        }
        else
        {
            GetComponet<SpriteRenderer>().enabled = false;
        }
    }
}

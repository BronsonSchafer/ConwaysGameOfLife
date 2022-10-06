using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    // holds creen size
    private static int SCREEN_WIDTH = 64;   // 1024 pixels
    private static int SCREEN_HEIGHT = 48;  // 768 pixels

    // calls from cell class
    Cell[,] grid = new Cell[SCREEN_WIDTH, SCREEN_HEIGHT];

    // Start is called before the first frame update
    void Start()
    {
        // place cells
        PlaceCells();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // palces the cells for the start of the "game"
    void PlaceCells(){
        // creates a cell for the grid
        for(int y = 0; y < SCREEN_HEIGHT; y++){
            for(int x = 0; x < SCREEN_WIDTH; x++){
                Cell cell = Instantiate(Resources.Load("Prefabs/Cell", typeof(Cell)), new Vector2(x,y), Quaternion.identity) as Cell;
                grid[x, y] = cell;
                grid[x, y].SetAlive(RandomAliveCell());
            }
        }
    }

    // creates random alive cells 
    bool RandomAliveCell(){
        // generates random num 
        int rand = UnityEngine.Random.Range(0, 100);
        // percent chance of returning true 
        if(rand > 75){
            return true;
        }
        return false;
    }
}

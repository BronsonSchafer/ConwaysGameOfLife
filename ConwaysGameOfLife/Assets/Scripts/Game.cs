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

    // plces the cells for the start of the "game"
    void PlaceCells(){
        for(int y = 0; y < SCREEN_HEIGHT; y++){
            for(int x = 0; x < SCREEN_WIDTH; x++){
                Cell cell = Instantiate(Resources.Load("Prefabs/Cell", typeof(Cell)), new Vector2(x,y), Quaternion.identity) as Cell;
                grid[x, y] = cell;
            }
        }
    }
}

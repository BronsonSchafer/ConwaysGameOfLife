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
        // counts the number of alive neighbors 
        CountNeighbors();
        // iterate 
        PopulationControl();
    }

    // places the cells for the start of the "game"
    void PlaceCells(){
        // creates a cell for the grid
        for (int y = 0; y < SCREEN_HEIGHT; y++){
            for (int x = 0; x < SCREEN_WIDTH; x++){
                Cell cell = Instantiate(Resources.Load("Prefabs/Cell", typeof(Cell)), new Vector2(x,y), Quaternion.identity) as Cell;
                grid[x, y] = cell;
                // sets if the cell is alive or dead
                grid[x, y].SetAlive(RandomAliveCell());
            }
        }
    }

    // counts the number of alive neigbors 
    void CountNeighbors(){
        for(int y = 0; y < SCREEN_HEIGHT; y++){
            for(int x = 0; x < SCREEN_WIDTH; x++){
                int numNeighbors = 0;
                // North
                if(y+1 < SCREEN_HEIGHT){
                    if (grid[x, y+1].isAlive){
                        numNeighbors++;
                    }
                }
                // East
                if(x+1 < SCREEN_WIDTH){
                    if (grid[x+1, y].isAlive){
                        numNeighbors++;
                    }
                }
                // South
                if(y-1 >= 0){
                    if (grid[x, y-1].isAlive){
                        numNeighbors++;
                    }
                }
                // West
                if(x-1 >= 0){
                    if (grid[x-1, y].isAlive){
                        numNeighbors++;
                    }
                }
                // North East
                if(x+1 < SCREEN_WIDTH && y+1 < SCREEN_HEIGHT){
                    if (grid[x+1, y+1].isAlive){
                        numNeighbors++;
                    }
                }
                // North West
                if(x-1 >= 0 && y+1 < SCREEN_HEIGHT){
                    if (grid[x-1, y+1].isAlive){
                        numNeighbors++;
                    }
                }
                // South East
                if(x+1 < SCREEN_WIDTH && y-1 >= 0){
                    if (grid[x+1, y-1].isAlive){
                        numNeighbors++;
                    }
                }
                // South West
                if(x-1 >= 0 && y-1 >= 0){
                    if (grid[x-1, y-1].isAlive){
                        numNeighbors++;
                    }
                }

                // sets the amount of alive neighbors
                grid[x,y].numNeighbors = numNeighbors;
            }
        }
    }

    // controls if a cell will stay alive, be born, or die 
    void PopulationControl(){
        for(int y = 0; y < SCREEN_HEIGHT; y++){
            for(int x = 0; x < SCREEN_WIDTH; x++){
                // Rules 
                // Any live cell with 2 or 3 live neighbors survives
                // Any dead cells with 3 live neighbors becoem a live cell
                // All other live cells die in the next generation and all other dead cells stay dead 

                // check if the cell is alive
                if(grid[x,y].isAlive){
                    if(grid[x,y].numNeighbors != 2 && grid[x,y].numNeighbors != 3){
                        // kill cell
                        grid[x,y].SetAlive(false);
                    }
                }
                else{
                    if(grid[x,y].numNeighbors == 3){
                        // cell born
                        grid[x,y].SetAlive(true);
                    }
                }
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

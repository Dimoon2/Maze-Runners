using System;
using System.Drawing;
using Microsoft.VisualBasic;


    public class Maze
    {
        // metodo show maze
        int size = 8;
        
        //initialize the Maze
        public Boxes[,] GenerateMaze()
        {

            Boxes[,] maze = {
                { Boxes.trap, Boxes.path, Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path, Boxes.trap},
                { Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.path,Boxes.trap,Boxes.path,Boxes.path, Boxes.path },
                { Boxes.path, Boxes.path,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.obstacle,Boxes.path, Boxes.obstacle},
                { Boxes.path, Boxes.obstacle,Boxes.trap,Boxes.treasure,Boxes.treasure,Boxes.path,Boxes.path, Boxes.path },
                { Boxes.path, Boxes.path,Boxes.path,Boxes.treasure,Boxes.treasure,Boxes.obstacle,Boxes.trap, Boxes.path },
                { Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.trap,Boxes.obstacle,Boxes.path, Boxes.path },
                { Boxes.obstacle, Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.path, Boxes.obstacle },
                { Boxes.path, Boxes.path,Boxes.trap,Boxes.path,Boxes.path,Boxes.path,Boxes.path, Boxes.trap},
            };
            return maze;
        }

        int rows = 8;
        int columns = 8;
        int traps;
        public int Traps(Boxes[,] maze)
        {
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < columns; j++)
                {
                    if (maze[i, j] == Boxes.trap)
                    {
                        traps++;
                    }
                }
            }

            return traps;


        }
    }


using System;
using System.Drawing;
using Microsoft.VisualBasic;
public class Maze
{
    public static int size = 18;
    public Boxes[,] GenerateMaze()
    {

        Boxes[,] maze = {
        {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle,Boxes.path, Boxes.Astharoth, Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle},
        {Boxes.obstacle, Boxes.obstacle, Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle, Boxes.path, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle, Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle, Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path, Boxes.path,Boxes.path,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.path,Boxes.trap,Boxes.path,Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.trap,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle},
        {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle},
        {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle},
        {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},

          };
        return maze;

        // Boxes[,] maze =
        // {
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
        //     {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
        //     {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
        //     {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
        // };
        // return maze;
    }
    //metodo que recorre la matriz y que agrega a una lista los caminos libres
    public List<int[]> PathList(Boxes[,] maze)
    {
        List<int[]> paths = new List<int[]>();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (maze[i, j] == Boxes.path)
                {
                    paths.Add(new int[] { i, j });
                }
            }
        }
        return paths;

    }

    int traps;
    public int NumTraps(Boxes[,] maze)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
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


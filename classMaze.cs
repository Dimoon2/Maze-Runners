using System;
using System.Drawing;
using Microsoft.VisualBasic;
public class Maze
{
    public static int size = 23;
    public Boxes[,] GenerateMaze()
    {

        //     Boxes[,] maze = {
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path, Boxes.path, Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.obstacle, Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.path, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path, Boxes.path,Boxes.path,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.path,Boxes.trap,Boxes.Astharoth,Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.trap,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},

        //       };
        //     return maze;

        //HUNT AND KILL :)
        //INITIALIZATION:
        //1. laberinto generico dividido por habitaciones:
        Boxes[,] maze =
        {
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },

            //small:
            // {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            // {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            // {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            // {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            // {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            // {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            // {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
        };
        Mask[,] mask =
        {
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },

            //mask small:
            // {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            // {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            // {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall},
            // {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            // {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            // {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            // {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall},
        };
        int Count = 0;
        List<int[]> unvisited = new List<int[]>();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (maze[i, j] == Boxes.path)
                //esto es una habitacion
                {
                    Count++;
                    unvisited.Add(new int[] { i, j });

                }
            }
        }
        //2. creacion de lista de habitaciones no visitadas:

        //KILL MODE:
        //3. seleccion de habitacion random de la lista de visitadas:
        Random randomIndex = new Random();
        int index = randomIndex.Next(unvisited.Count);

        int[] selectedCell = unvisited[index];
        Console.WriteLine($"Estamos en:{selectedCell[0]} , {selectedCell[1]}");

        //4.Marcar la random como visitada:
        mask[selectedCell[0], selectedCell[1]] = Mask.visited;
        Count--;
        //5.array direccional para acceder a un vecino random adyacente:

        //crear lista de direcciones:
        List<int[]> Direction = new List<int[]>();
        Direction.Add(new int[] { -1, 0 });
        Direction.Add(new int[] { 1, 0 });
        Direction.Add(new int[] { 0, -1 });
        Direction.Add(new int[] { 0, 1 });

        //6.seleccionar un vecino random adyacente:
        while (Count > 0)
        {
            GameActions.PrintMaze(maze);
            Console.ReadKey(true);
            //escojo random direction pamoverme
            int indexOfDir = randomIndex.Next(Direction.Count);
            int[] Dir = Direction[indexOfDir];

            Console.WriteLine($"Estamos en:{selectedCell[0]} , {selectedCell[1]}");
            Console.WriteLine($"Escogimos direccion:{Dir[0]} , {Dir[1]} imdice {indexOfDir}");
            Console.WriteLine($"hay {Direction.Count} direcciones");
            Console.WriteLine($"no visitadas {unvisited.Count}");

            //este es el vecino
            int[] adjacentCell = [selectedCell[0] + Dir[0] + Dir[0], selectedCell[1] + Dir[1] + Dir[1]];
            Console.WriteLine($"Habitacion adyacente:{adjacentCell[0]} , {adjacentCell[1]}");

            //7.Verificar limites:
            if (adjacentCell[0] >= 1 && adjacentCell[0] < size - 1 && adjacentCell[1] >= 1 && adjacentCell[1] < size - 1)
            {

                Console.WriteLine($"hay {Direction.Count} direcciones");
                Console.WriteLine($"no visitadas {unvisited.Count}");
                Console.WriteLine();
                //8. Comprobar que el seleccionado pertenezca a la lista de no visitados.
                while (Direction.Count > 0)
                {

                    Console.WriteLine($"Estamos en:{selectedCell[0]} , {selectedCell[1]}");
                    //9.Romper la pared de por medio:
                    //ver si elvecino es no visitado
                    if (mask[adjacentCell[0], adjacentCell[1]] == Mask.unvisited)
                    {
                        //rompo pared entre donde estoy y mi vecino
                        maze[selectedCell[0] + Dir[0], selectedCell[1] + Dir[1]] = Boxes.path;
                        Console.WriteLine($"rompo en {selectedCell[0] + Dir[0]} , {selectedCell[1] + Dir[1]}");
                        Console.WriteLine();
                        //10.Marcar adjacentCell como visitada:
                        mask[adjacentCell[0], adjacentCell[1]] = Mask.visited;
                        Count--;

                        //11.Me muevo para la celda vecina:
                        selectedCell[0] = adjacentCell[0];
                        selectedCell[1] = adjacentCell[1];
                        Console.WriteLine($"me movi a {selectedCell[0]} , {selectedCell[1]}");
                        Console.WriteLine();
                        Console.WriteLine($"hay {Direction.Count} direcciones");
                        //vaciar lista de Direction
                        Direction = new List<int[]>();
                        //la llenamos:
                        Direction.Add(new int[] { -1, 0 });
                        Direction.Add(new int[] { 1, 0 });
                        Direction.Add(new int[] { 0, -1 });
                        Direction.Add(new int[] { 0, 1 });
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"hay {Direction.Count} direcciones");
                        Console.WriteLine();
                        Console.WriteLine($"borrare dir en idice {Direction.Count} ");
                        Direction.RemoveAt(indexOfDir);
                        break;
                    }


                }
            }
            else
            {
                Console.WriteLine($"borro dir en idice {Direction.Count} ");
                Direction.RemoveAt(indexOfDir);
            }


            bool found = false;
            //Hunt mode:
            while (Direction.Count == 0)
            {
                Console.WriteLine($"entro al hunt tamanio de lista de dirs{Direction.Count} unvisited remaining {unvisited.Count} estoy en {selectedCell[0]},{selectedCell[1]}");
                for (int i = 1; i < size - 1; i++)
                {
                    for (int j = 1; j < size - 1; j++)
                    {
                        //buscamos un unvisited y revisamos q tenga algun vecino como visitado para cavar la pared:
                        if (mask[i, j] == Mask.unvisited)
                        {
                            if (i - 2 >= 1 && i - 2 < size - 2 && j >= 1 && j < size - 2)
                            {
                                if (mask[i - 2, j] == Mask.visited)
                                {
                                    //rompo pared en el medio
                                    maze[i - 1, j] = Boxes.path;
                                    //la escojo y marco como visited
                                    mask[i, j] = Mask.visited;
                                    Count--;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;

                                    //llenar lista de direcciones:


                                    found = true;
                                    break;
                                }
                            }
                            if (i + 2 >= 1 && i + 2 < size - 2 && j >= 1 && j < size - 2)
                            {
                                if (mask[i + 2, j] == Mask.visited)
                                {
                                    GameActions.PrintMaze(maze);
                                    Console.ReadKey(true);
                                    maze[i + 1, j] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    Count--;

                                    //llenar lista de direcciones:


                                    found = true;
                                    break;
                                }
                            }
                            if (i >= 1 && i < size - 2 && j - 2 >= 1 && j - 2 < size - 2)
                            {
                                if (mask[i, j - 2] == Mask.visited)
                                {
                                    maze[i, j - 1] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    Count--;

                                    //llenar lista de direcciones:


                                    found = true;
                                    break;
                                }
                            }
                            if (i >= 1 && i < size - 2 && j + 2 >= 1 && j + 2 < size - 2)
                            {
                                if (mask[i, j + 2] == Mask.visited)
                                {
                                    maze[i, j + 1] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    Count--;

                                    //llenar lista de direcciones:


                                    found = true;
                                    break;
                                }
                            }



                        }

                    }
                    if (found == true)
                    {
                        break;
                    }
                }
                break;
            }
            Console.WriteLine($"lista de dirs{Direction.Count} unvisited remaining {Count}");
            if (Direction.Count == 0)
            {
                Direction.Add(new int[] { -1, 0 });
                Direction.Add(new int[] { 1, 0 });
                Direction.Add(new int[] { 0, -1 });
                Direction.Add(new int[] { 0, 1 });
            }
            if (Count == 0)
            {
                break;
            }

        }
        return maze;
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


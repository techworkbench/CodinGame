using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * TechWorkbench
 * Please leave your collaboration if you are interested to contribute.
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int initialTx = int.Parse(inputs[2]); // Thor's starting X position
        int initialTy = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine()); // The remaining amount of turns Thor can move. Do not remove this line.
            string movingDirection = "";

            // Write an action using Console.WriteLine()
            // To debug: Console.Error.WriteLine("Debug messages...");
            /*
            Note: This is a common solution in C#, but as this a very basic language instructions, this can be used almost the same way in other languages.
            X Range -> 0-39 (40)
            Y Range -> 0-17 (18)
               0
            0 -|--------------> 39 (X)
               |
               |
               |
               17 (Y)
            */

            // Check target Y is bigger than current Y
            // increment current Y as it would move south (down) and set direction to S/South
            if (initialTy < lightY)
            {
                initialTy++;
                movingDirection = "S";
            }
            // Check if current Y is bigger than target Y
            // decrement Y as it would move north (up) and ser direction to N/North
            else if (initialTy > lightY)
            {
                initialTy--;
                movingDirection = "N";
            }

            // Check if current X is smaller than target X
            // Increment current X as it is would move diagonally to E/East and append E/East to N/North or S/South
            // It only move diagonally if there is need to move S or N
            if (initialTx < lightX)
            {
                initialTx++;
                movingDirection += "E";
            }
            // Check if current X is bigger than target X
            // Decrement current X as it is would move diagonally to W/West and append W/West to N/North or S/South
            // It only move diagonally if there is need to move S or N
            else if (initialTx > lightX)
            {
                initialTx--;
                movingDirection += "W";
            }


            // A single line providing the move to be made: N NE E SE S SW W or NW
            Console.WriteLine(movingDirection);
        }
    }
}
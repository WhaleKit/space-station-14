﻿using System;

namespace SS14.Client
{
    public class Program
    {
        /************************************************************************/
        /* program starts here                                                  */
        /************************************************************************/

        [STAThread]
        private static void Main()
        {
            GameController GC = new GameController(); // No, sonarqube, this isn't unused. A side-effect of this is to "run the game"
        }
    }
}

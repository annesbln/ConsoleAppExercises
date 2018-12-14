using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppExercises
{
    class Vehicle
    {
        public string type;
        public int numTires;
        public int year;
        public bool runs;

        public Vehicle(string myType, int myNumTires, int myYear, bool myRuns)
        {
            type = myType;
            numTires = myNumTires;
            year = myYear;
            runs = myRuns;
        }

    }
}

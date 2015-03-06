using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResultCalculator
{
    class ResultCalculator
    {
        public double PhysicsMarks { set; get; }
        public double ChemistryMarks { set; get; }
        public double MathMarks { set; get; }

        public double GetAverageResult()
        {
            double average = (PhysicsMarks + ChemistryMarks + MathMarks)/3;
            return average;
        }

        public string GetGradeLetter()
        {
            double average = GetAverageResult();
            if (average >= 80)
            {
                return "A+";
            }
            else if (average >= 70)
            {
                return "B+";
            }
            else if (average >= 60)
            {
                return "C+";
            }
            else if (average >= 50)
            {
                return "D+";
            }
            else
            {
                return "F";
            }
        }
    }
}

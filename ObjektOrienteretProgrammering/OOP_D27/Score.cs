using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_D2
{
    internal class Score
    {
        private string name;
        private int points;

        public string Name { get => name; set => name = value; }
        public int Points { get => points; set => points = value; }

        public Score(string name, int points)
        {
            this.Name = name;
            this.Points = points;
        }

    }
}

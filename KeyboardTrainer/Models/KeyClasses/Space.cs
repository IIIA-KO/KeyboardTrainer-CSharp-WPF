using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KeyboardTrainer.Models.KeyClasses
{
    internal class Space : KeyButton
    {
        public Space(int row, int col, int colSpan, Color back) 
            : base("Space", "Space", row, col, colSpan, back) { }
    }
}

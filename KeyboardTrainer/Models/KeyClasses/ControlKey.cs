using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace KeyboardTrainer.Models.KeyClasses
{
    internal class ControlKey : KeyButton
    {
        public ControlKey(string value, int row, int col, int colSpan) 
            : base(value, value, row, col, colSpan, Colors.LightGray) { Content.FontSize = 20; }
    }
}

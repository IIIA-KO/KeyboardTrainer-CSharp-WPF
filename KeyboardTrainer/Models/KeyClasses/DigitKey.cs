using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace KeyboardTrainer.Models.KeyClasses
{
    internal class DigitKey : KeyButton
    {
        public DigitKey(string lower, string upper, int row, int column, Color backgroundColor) 
            : base(lower, upper, row, column, 2, backgroundColor) { }

        public override void UpdateValue(bool capsIsPressed, bool shiftIsPressed) =>
            Content.Text = shiftIsPressed ? UpperValue : LowerValue;
    }
}

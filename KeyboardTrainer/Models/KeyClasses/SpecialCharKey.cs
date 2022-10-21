using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace KeyboardTrainer.Models.KeyClasses
{
    internal class SpecialCharKey : KeyButton
    {
        public SpecialCharKey(string? lower, string? upper, int row, int col, int colSpan, Color back)
            : base(lower, upper, row, col, colSpan, back) { }

        public override void UpdateValue(bool capsIsPressed, bool shiftIsPressed) =>
            Content.Text = shiftIsPressed ? UpperValue : LowerValue;
    }
}

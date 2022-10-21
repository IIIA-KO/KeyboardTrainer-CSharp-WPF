using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Media;

namespace KeyboardTrainer.Models.KeyClasses
{
    internal class LetterKey : KeyButton
    {
        public LetterKey(string value, int row, int col, Color back) 
            : base(value.ToLower(), value.ToUpper(), row, col, 2, back) { }

        public override void UpdateValue(bool capsIsPressed, bool shiftIsPressed) =>
            Content.Text = capsIsPressed != shiftIsPressed ? UpperValue : LowerValue;
    }
}

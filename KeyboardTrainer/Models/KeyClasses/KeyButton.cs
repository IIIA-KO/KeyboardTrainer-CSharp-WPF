using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using Color = System.Windows.Media.Color;

namespace KeyboardTrainer.Models.KeyClasses
{
    internal class KeyButton
    {
        public string? LowerValue { get; private set; }
        public string? UpperValue { get; private set; }

        public UIElement KeyGrid { get; private set; }
        public TextBlock Content { get; private set; }

        public KeyButton(string? lower, string? upper, int row, int col, int colSpan, Color back)
        {
            LowerValue = lower;
            UpperValue = upper;

            var border = new Border
            {
                Margin = new Thickness(2.0),
                BorderBrush = new SolidColorBrush(Colors.Black),
                BorderThickness = new Thickness(1.5),
                Background = new SolidColorBrush(back),
                CornerRadius = new CornerRadius(15)
            };

            var text = new TextBlock
            {
                Text = lower,
                FontSize = 24.0,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontFamily = new System.Windows.Media.FontFamily("Cascadia Mono"),
                FontWeight = FontWeights.Bold
        };

            border.Child = text;
            Grid.SetRow(border, row);
            Grid.SetColumn(border, col);
            Grid.SetColumnSpan(border, colSpan);

            Content = text;
            KeyGrid = border;
        }
        public virtual void UpdateValue(bool capsIsPressed, bool shiftIsPressed) { }
    }
}

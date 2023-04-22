using System.Collections.Generic;
using System.Drawing;

namespace IO.Drawing
{
    public static class Palette
    {
        private static readonly Dictionary<Memory.CellType, Brush> cellBrushes = new Dictionary<Memory.CellType, Brush>()
        {
            { Memory.CellType.Empty, null },
            { Memory.CellType.Filled, Brushes.Green },
            { Memory.CellType.Reserved, Brushes.LightBlue }
        };

        public static Pen GridPen => Pens.LightGray;
        public static Pen SelectionPen => Pens.Red;
        public static IReadOnlyDictionary<Memory.CellType, Brush> CellBrushes => cellBrushes;

    }
}

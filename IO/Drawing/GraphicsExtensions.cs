namespace System.Drawing
{
    public static class GraphicsExtensions
    {
        public static void DrawRectangle(this Graphics gfx, Pen pen, Point pos, Size size)
        {
            gfx.DrawRectangle(pen, pos.X, pos.Y, size.Width, size.Height);
        }
    }
}

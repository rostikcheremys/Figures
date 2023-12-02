namespace Program
{
    public class Rhomb : Figure
    {
        private readonly double _horDiagLen;
        private readonly double _vertDiagLen;

        public Rhomb(double centerX, double centerY, double horDiagLen, double vertDiagLen) : base(centerX, centerY)
        {
            _horDiagLen = horDiagLen;
            _vertDiagLen = vertDiagLen;
        }

        private Point[] GetRhombPoints()
        {
            return new Point[] {
                new ((int)centerX, (int)(centerY - _vertDiagLen / 2)),
                new ((int)(centerX - _horDiagLen / 2), (int)centerY),
                new ((int)centerX, (int)(centerY + _vertDiagLen / 2)),
                new ((int)(centerX + _horDiagLen / 2), (int)centerY)
            };
        }
        
        protected override void DrawBlack()
        {
            Graphics graphics = MyForm.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, GetRhombPoints());
        }

        protected override void HideDrawingBackGround()
        {
            Graphics graphics = MyForm.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(MyForm.ActiveForm.BackColor), GetRhombPoints());
        }
    }
}
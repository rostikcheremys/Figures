namespace Program
{
    public class Square : Figure
    {
        private readonly double _sideLength;

        public Square(double centerX, double centerY, double sideLength) : base(centerX, centerY)
        {
            _sideLength = sideLength;
        }

        protected override void DrawBlack()
        {
            Graphics graphics = MyForm.ActiveForm.CreateGraphics();
            graphics.DrawRectangle(Pens.Black, (float)(centerX - _sideLength / 2), (float)(centerY - _sideLength / 2), (float)_sideLength, (float)_sideLength);
        }

        protected override void HideDrawingBackGround()
        {
            Graphics graphics = MyForm.ActiveForm.CreateGraphics();
            graphics.DrawRectangle(new Pen(MyForm.ActiveForm.BackColor), (float)(centerX - _sideLength / 2), (float)(centerY - _sideLength / 2), (float)_sideLength, (float)_sideLength);
        }
    }
}
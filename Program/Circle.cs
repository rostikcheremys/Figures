namespace Program
{
    public class Circle : Figure
    {
        private readonly double _radius;

        public Circle(double centerX, double centerY, double radius) : base(centerX, centerY)
        {
            _radius = radius;
        }

        protected override void DrawBlack()
        {
            Graphics graphics = MyForm.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, (float)(centerX - _radius), (float)(centerY - _radius), (float)(_radius * 2), (float)(_radius * 2));
        }

        protected override void HideDrawingBackGround()
        {
            Graphics graphics = MyForm.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(new Pen(MyForm.ActiveForm.BackColor), (float)(centerX - _radius), (float)(centerY - _radius), (float)(_radius * 2), (float)(_radius * 2));
        }
    }
}
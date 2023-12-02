namespace Program
{
    public abstract class Figure
    {
        protected double centerX;
        protected double centerY;

        protected Figure(double centerX, double centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }

        protected abstract void DrawBlack();

        protected abstract void HideDrawingBackGround();

        public void MoveRight()
        {
            for (int i = 0; i < 100; i++)
            {
                DrawBlack();
                Thread.Sleep(100);
                HideDrawingBackGround();
                centerX++;
            }
        }
    }
}
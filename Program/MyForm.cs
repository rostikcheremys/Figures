namespace Program
{
    public partial class MyForm : Form
    {
        private readonly Circle _circle;
        private readonly Square _square;
        private readonly Rhomb _rhomb;

        public MyForm()
        {
            InitializeComponent();
            
            _circle = new Circle(50, 150, 50);
            _square = new Square(50, 150, 100);
            _rhomb = new Rhomb(50, 150, 85, 110);
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            _circle.MoveRight();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            _square.MoveRight();
        }

        private void buttonRhomb_Click(object sender, EventArgs e)
        {
            _rhomb.MoveRight();
        }
    }
}
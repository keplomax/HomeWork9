namespace Tumakov_Lab_10
{
    public abstract class Figure
    {
        protected string color;
        protected bool visible;

        public Figure(string color, bool visible)
        {
            this.color = color;
            this.visible = visible;
        }

        public string Color
        {
            get
            {
                return color;
            }
        }

        public bool Visible
        {
            get
            {
                return visible;
            }
        }

        public abstract void Display();
    }
}

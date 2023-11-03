namespace Learn73
{
    public struct People
    {
        private  static People _origin;
        public int Age { get; set; }

        public ref  People NewAge => ref _origin;

        public People(int ager)
        {
            Age = ager;
        }
    }
}
namespace Google
{
    class Children
    {
        private string name;
        private string birthday;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public Children(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
    }
}
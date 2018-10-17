﻿namespace Google
{
    class Car
    {
        private string model;
        private int speed;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public Car(string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }
    }
}

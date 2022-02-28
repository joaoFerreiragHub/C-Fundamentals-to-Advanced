using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        //member variable

        private int length;
        private int height;
       // private int width;
        private int volume;


        public void setLength(int length)
        {
            if(length <0)
            {
                throw new Exception("Length has to be bigger than 0");
            }
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;
                }
                
            }
        }
        //prop
        public int Width { get; set; }

        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
            }
        }


        public Box(int length, int height,int width)
        {
            this.length = length;
            this.height = height;
            Width = width; //It is a property
        }


        //ChallengeProperties
        public int FrontSurface
        {
            get { return height * length; }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Lenght is {0}, height is {1}, width is {2} and volume is {3} ", length, height, Width, volume = length * height * Width);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;//canvas
using System.Windows.Media;//solidcolorbrush
using System.Windows.Shapes;//rectangle

namespace Kneipe
{
    class Logo
    {
        Canvas canvas;
        Rectangle rectangle1;
        Rectangle rectangle2;
        protected double posx;
        protected double posy;


        public Canvas Canvas
        {

            get { return this.canvas; }
            set { this.canvas = value; }
        }


        public double Posx
        {
            get { return this.posx; }
            set { this.posx = value; }
        }

        public double Posy
        {
            get { return this.posy; }
            set { this.posy = value; }
        }

        public Logo()
        {
            rectangle1 = new Rectangle();
            rectangle1.Fill = new SolidColorBrush(Colors.DarkGreen);
            rectangle1.Opacity = 0.5;//Deckkraft
            rectangle1.Width = 10;
            rectangle1.Height = 16;
            Canvas.SetLeft(rectangle1, 10);
            Canvas.SetTop(rectangle1, 12);//Höhe des oberen rectangle plus dessen top hier 5
            rectangle2 = new Rectangle();
            rectangle2.Fill = new SolidColorBrush(Colors.DarkGreen);
            rectangle2.Opacity = 0.5;//Deckkraft
            rectangle2.Width = 6;
            rectangle2.Height = 7;
            Canvas.SetLeft(rectangle2, 12);
            Canvas.SetTop(rectangle2, 5);
            canvas = new Canvas();
            canvas.Width = 100;
            canvas.Height = 30;
            canvas.Children.Add(rectangle1);
            canvas.Children.Add(rectangle2);
            Canvas.SetLeft(canvas, 750);
            Canvas.SetTop(canvas, 20);//Objekt, Position im übergeordneten Canvas
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntController
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
          //  System.Drawing.Drawing2D.GraphicsPath buttonPath =
          //new System.Drawing.Drawing2D.GraphicsPath();

          //  // Set a new rectangle to the same size as the button's 
          //  // ClientRectangle property.
          //  System.Drawing.Rectangle newRectangle = ClientRectangle;

          //  // Decrease the size of the rectangle.
          //  newRectangle.Inflate(-10, -10);

          //  // Draw the button's border.
          //  e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);

          //  // Increase the size of the rectangle to include the border.
          //  newRectangle.Inflate(1, 1);

          //  // Create a circle within the new rectangle.
          //  buttonPath.AddEllipse(newRectangle);

          //  // Set the button's Region property to the newly created 
          //  // circle region.
          // this.Region = new System.Drawing.Region(buttonPath);


            System.Drawing.Rectangle newRectangle = ClientRectangle;

            // Decrease the size of the rectangle.
            newRectangle.Inflate(-10, -10);
            var graphicsPath = new GraphicsPath();
            e.Graphics.DrawEllipse(System.Drawing.Pens.Black, newRectangle);
            newRectangle.Inflate(1, 1);
            graphicsPath.AddEllipse(newRectangle);
            this.Region = new Region(graphicsPath);
            base.OnPaint(e);

        }
    }
}

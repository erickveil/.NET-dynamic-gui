using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test7_dynamic_GUI
{
    public partial class Form2 : Form
    {
        int num_bez = Convert.ToInt32(test7_dynamic_GUI.Properties.Settings.Default.num_bez);
        
        private List<Button> bezel_list=new List<Button>();

        
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Set up the initial position and sizes of the elements
            int x = 13;
            int y = 13;
            int height = 23;
            int width = 48;
            int margin = 6;

            // Arranging the buttons into rows and columns, as close to square as possile
            int rows = Convert.ToInt32(Math.Sqrt(Convert.ToDouble(this.num_bez)));
            int cols = Convert.ToInt32(this.num_bez/rows);
            if (cols * rows < this.num_bez)
            {
                ++rows;
            }
            int count =0;

            for (int r = 0; r < rows; ++r)
            {
                for (int c = 0; c < cols; ++c)
                {
                    // End the row early if we've drawn all the buttons
                    if (count >= this.num_bez)
                    {
                        break;
                    }
                    ++count;

                    // Create a local button and set its attributes
                    Button bezel = new Button();

                    bezel.Location = new System.Drawing.Point(x, y);

                    // You can give the cloned items unique Names, or all the same
                    //bezel.Name = "bezel_" + Convert.ToString(count);
                    bezel.Name = "bezel_";

                    bezel.Size = new System.Drawing.Size(width, height);
                    bezel.TabIndex = 0;
                    bezel.UseVisualStyleBackColor = true;
                    bezel.Text = Convert.ToString(count);

                    // Add the button, not only to draw in the form, but to a 
                    // globally available list so that it can be referenced and manipulated
                    Controls.Add(bezel);
                    bezel_list.Add(bezel);

                    x = x + margin + width;
                }
                y = y + margin + height;
                x = 13;                
            }

            // Size the form to accomodate new buttons
            int form_h = (rows * height) + (rows * margin) + 24+height;
            int form_w = (cols * width) + (cols * margin) + 24;
            this.Width = form_w;
            this.Height = form_h;
        }
    }
}

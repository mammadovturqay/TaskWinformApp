using System.Security.Cryptography.X509Certificates;

namespace WinFormsApp5
{
    // 1 CI TASK  1 ci ders ev tapsirigi 
    public partial class Form1 : Form
    {
        private Point startLocation;
        private Label rectangleLabel;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startLocation = e.Location;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point endLocation = e.Location;

                int x = Math.Min(startLocation.X, endLocation.X);
                int y = Math.Min(startLocation.Y, endLocation.Y);
                int width = Math.Abs(startLocation.X - endLocation.X);
                int height = Math.Abs(startLocation.Y - endLocation.Y);
                x = Math.Max(x, 0);
                y = Math.Max(y, 0);
                width = Math.Min(width, this.ClientSize.Width - x);
                height = Math.Min(height, this.ClientSize.Height - y);
                if (width >= 10 && height >= 10)
                {
                    rectangleLabel = new Label();
                    rectangleLabel.Location = new Point(x, y);
                    rectangleLabel.Size = new Size(width, height);
                    rectangleLabel.BorderStyle = BorderStyle.FixedSingle;
                    rectangleLabel.Text = $"{width}x{height}";
                    this.Controls.Add(rectangleLabel);
                }
            }
        }

        

        //// Bu 2 ci taskdi  label qacir .. 
        //private void label1_MouseEnter(object sender, EventArgs e)
        //{
        //    int x = Random.Shared.Next(0,this.Size.Width - label1.Size.Width-20);
        //    int y = Random.Shared.Next(0,this.Size.Height - label1.Size.Height-20);
        //    label1.Location = new Point(x,y);
        //}


    }
}
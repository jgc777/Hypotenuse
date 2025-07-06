

namespace Hypotenuse
{
    public partial class Hypotenuse : Form
    {
        private float leg1Length = 0;
        private float leg2Length = 0;
        private float hypLenght = 0;

        public Hypotenuse()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e) // Do not focus on the first control when the form is shown
        {
            base.OnShown(e);
            ActiveControl = null;
        }

        private void Hypotenuse_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (!(leg1Length > 0 && leg2Length > 0 && hypLenght > 0 && (hypLenght * hypLenght == leg1Length * leg1Length + leg2Length * leg2Length))) return;

            // Scale the triangle to fit within the GroupBox
            float padding = 10;
            float scaleX = (triangleDrawing.Width - 2 * padding) / leg1Length;
            float scaleY = (triangleDrawing.Height - 2 * padding) / leg2Length;
            float scale = Math.Min(scaleX, scaleY); // usar el más pequeño para que quepa

            // Set the origin at the bottom left corner of the GroupBox
            float originX = padding;
            float originY = triangleDrawing.Height - padding;

            // Scaled points for the triangle
            PointF p1 = new PointF(originX, originY); // Right angle
            PointF p2 = new PointF(originX + leg1Length * scale, originY); // Horizontal
            PointF p3 = new PointF(originX, originY - leg2Length * scale); // Vertical

            PointF[] triangle = { p1, p2, p3 };

            Pen lapiz = new Pen(Color.Blue, 2);
            Brush pincel = new SolidBrush(Color.LightBlue);

            g.FillPolygon(pincel, triangle);
            g.DrawPolygon(lapiz, triangle);
        }

        private void Drawbtn_Click(object sender, EventArgs e)
        {
            if (float.TryParse(leg1.Text, out float l1) && float.TryParse(leg2.Text, out float l2) && float.TryParse(hypotenusebox.Text, out float hyp))
                if (l1 > 0 && l2 > 0 && hyp > 0 && (hyp * hyp == l1 * l1 + l2 * l2)) // Hypotenuse validation
                {
                    leg1Length = l1;
                    leg2Length = l2;
                    triangleDrawing.Invalidate(); // Repaint the triangle
                }
                else MessageBox.Show("Invalid leg values.");
            else MessageBox.Show("Error parsing values.");
        }


        private void leg1btn_Click(object sender, EventArgs e) // Calculate leg1 based on hypotenuse and leg2 and update the UI
        {
            if (float.TryParse(hypotenusebox.Text, out float hyp) && float.TryParse(leg2.Text, out float l2))
            {
                leg2Length = l2;
                leg1Length = (float)Math.Sqrt(hyp * hyp - l2 * l2);
                leg1.Text = leg1Length.ToString();
                triangleDrawing.Invalidate();
            }
            else
            {
                MessageBox.Show("Invalid hypotenuse or leg 2 value.");
            }
        }

        private void leg2btn_Click(object sender, EventArgs e) // Calculate leg2 based on hypotenuse and leg1 and update the UI
        {
            if (float.TryParse(hypotenusebox.Text, out float hyp) && float.TryParse(leg1.Text, out float l1))
            {
                leg1Length = l1;
                leg2Length = (float)Math.Sqrt(hyp * hyp - l1 * l1);
                leg2.Text = leg2Length.ToString();
                triangleDrawing.Invalidate(); // Fuerza el repintado
            }
            else
            {
                MessageBox.Show("Invalid hypotenuse or leg 2 value.");
            }
        }

        private void hypbtn_Click(object sender, EventArgs e) // Calculate hypotenuse based on leg1 and leg2 and update the UI
        {
            if (float.TryParse(leg2.Text, out float l2) && float.TryParse(leg1.Text, out float l1))
            {
                leg1Length = l1;
                leg2Length = l2;
                hypotenusebox.Text = ((float)Math.Sqrt(l1 * l1 + l2 * l2)).ToString();
                triangleDrawing.Invalidate(); // Fuerza el repintado
            }
            else
            {
                MessageBox.Show("Invalid hypotenuse or leg 2 value.");
            }
        }

        protected override void OnResize(EventArgs e) // Resize the triangleDrawing control when the form is resized
        {
            base.OnResize(e);
            triangleDrawing.Size = new Size(
                ClientSize.Width - triangleDrawing.Left - 10,
                ClientSize.Height - triangleDrawing.Top - 10
            );
        }
    }
}

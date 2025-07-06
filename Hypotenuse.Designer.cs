namespace Hypotenuse
{
    partial class Hypotenuse
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hypotenuse));
            label1 = new Label();
            leg1 = new TextBox();
            leg2 = new TextBox();
            hypotenusebox = new TextBox();
            leg1btn = new Button();
            leg2btn = new Button();
            hypbtn = new Button();
            drawbtn = new Button();
            triangleDrawing = new GroupBox();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // leg1
            // 
            leg1.Location = new Point(10, 62);
            leg1.Name = "leg1";
            leg1.PlaceholderText = "Leg 1";
            leg1.Size = new Size(100, 23);
            leg1.TabIndex = 1;
            // 
            // leg2
            // 
            leg2.Location = new Point(10, 91);
            leg2.Name = "leg2";
            leg2.PlaceholderText = "Leg 2";
            leg2.Size = new Size(100, 23);
            leg2.TabIndex = 2;
            // 
            // hypotenusebox
            // 
            hypotenusebox.Location = new Point(10, 120);
            hypotenusebox.Name = "hypotenusebox";
            hypotenusebox.PlaceholderText = "Hypotenuse";
            hypotenusebox.Size = new Size(100, 23);
            hypotenusebox.TabIndex = 3;
            // 
            // leg1btn
            // 
            leg1btn.Location = new Point(116, 62);
            leg1btn.Name = "leg1btn";
            leg1btn.Size = new Size(75, 23);
            leg1btn.TabIndex = 4;
            leg1btn.Text = "Calculate";
            leg1btn.UseVisualStyleBackColor = true;
            leg1btn.Click += leg1btn_Click;
            // 
            // leg2btn
            // 
            leg2btn.Location = new Point(116, 91);
            leg2btn.Name = "leg2btn";
            leg2btn.Size = new Size(75, 23);
            leg2btn.TabIndex = 5;
            leg2btn.Text = "Calculate";
            leg2btn.UseVisualStyleBackColor = true;
            leg2btn.Click += leg2btn_Click;
            // 
            // hypbtn
            // 
            hypbtn.Location = new Point(116, 120);
            hypbtn.Name = "hypbtn";
            hypbtn.Size = new Size(75, 23);
            hypbtn.TabIndex = 6;
            hypbtn.Text = "Calculate";
            hypbtn.UseVisualStyleBackColor = true;
            hypbtn.Click += hypbtn_Click;
            // 
            // drawbtn
            // 
            drawbtn.Location = new Point(197, 62);
            drawbtn.Name = "drawbtn";
            drawbtn.Size = new Size(75, 81);
            drawbtn.TabIndex = 7;
            drawbtn.Text = "Draw";
            drawbtn.UseVisualStyleBackColor = true;
            drawbtn.Click += Drawbtn_Click;
            // 
            // triangleDrawing
            // 
            triangleDrawing.AutoSize = true;
            triangleDrawing.Location = new Point(12, 149);
            triangleDrawing.Name = "triangleDrawing";
            triangleDrawing.Size = new Size(260, 150);
            triangleDrawing.TabIndex = 8;
            triangleDrawing.TabStop = false;
            triangleDrawing.Paint += Hypotenuse_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 8F);
            label2.Location = new Point(102, 46);
            label2.Name = "label2";
            label2.Size = new Size(123, 13);
            label2.TabIndex = 10;
            label2.Text = "Copyright © Jgc7 2025";
            // 
            // Hypotenuse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(284, 311);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(triangleDrawing);
            Controls.Add(drawbtn);
            Controls.Add(hypbtn);
            Controls.Add(leg2btn);
            Controls.Add(leg1btn);
            Controls.Add(hypotenusebox);
            Controls.Add(leg2);
            Controls.Add(leg1);
            Controls.Add(label1);
            MinimumSize = new Size(300, 350);
            Name = "Hypotenuse";
            ShowIcon = false;
            Text = "Hypotenuse";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox leg1;
        private TextBox leg2;
        private TextBox hypotenusebox;
        private Button leg1btn;
        private Button leg2btn;
        private Button hypbtn;
        private Button drawbtn;
        private GroupBox triangleDrawing;
        private PictureBox pictureBox1;
        private Label label2;
    }
}
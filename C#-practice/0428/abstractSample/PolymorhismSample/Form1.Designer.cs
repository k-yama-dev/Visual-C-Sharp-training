namespace PolymorhismSample
{
    partial class FormCookie
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxDog = new PictureBox();
            pictureBoxCat = new PictureBox();
            pictureBoxBird = new PictureBox();
            buttonSing = new Button();
            buttonReset = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxDog
            // 
            pictureBoxDog.Image = Properties.Resources.DogCookie;
            pictureBoxDog.Location = new Point(49, 38);
            pictureBoxDog.Margin = new Padding(3, 2, 3, 2);
            pictureBoxDog.Name = "pictureBoxDog";
            pictureBoxDog.Size = new Size(173, 100);
            pictureBoxDog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDog.TabIndex = 0;
            pictureBoxDog.TabStop = false;
            // 
            // pictureBoxCat
            // 
            pictureBoxCat.Image = Properties.Resources.CatCookie;
            pictureBoxCat.Location = new Point(238, 38);
            pictureBoxCat.Margin = new Padding(3, 2, 3, 2);
            pictureBoxCat.Name = "pictureBoxCat";
            pictureBoxCat.Size = new Size(173, 100);
            pictureBoxCat.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCat.TabIndex = 0;
            pictureBoxCat.TabStop = false;
            // 
            // pictureBoxBird
            // 
            pictureBoxBird.Image = Properties.Resources.BirdCookie;
            pictureBoxBird.Location = new Point(430, 38);
            pictureBoxBird.Margin = new Padding(3, 2, 3, 2);
            pictureBoxBird.Name = "pictureBoxBird";
            pictureBoxBird.Size = new Size(173, 100);
            pictureBoxBird.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBird.TabIndex = 0;
            pictureBoxBird.TabStop = false;
            // 
            // buttonSing
            // 
            buttonSing.Location = new Point(49, 161);
            buttonSing.Margin = new Padding(3, 2, 3, 2);
            buttonSing.Name = "buttonSing";
            buttonSing.Size = new Size(554, 22);
            buttonSing.TabIndex = 1;
            buttonSing.Text = "鳴く";
            buttonSing.UseVisualStyleBackColor = true;
            buttonSing.Click += buttonSing_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(49, 202);
            buttonReset.Margin = new Padding(3, 2, 3, 2);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(554, 22);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "元に戻す";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // FormCookie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 261);
            Controls.Add(buttonReset);
            Controls.Add(buttonSing);
            Controls.Add(pictureBoxBird);
            Controls.Add(pictureBoxCat);
            Controls.Add(pictureBoxDog);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCookie";
            Text = "動物クッキー";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCat).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBird).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxDog;
        private PictureBox pictureBoxCat;
        private PictureBox pictureBoxBird;
        private Button buttonSing;
        private Button buttonReset;
    }
}

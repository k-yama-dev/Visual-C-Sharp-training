namespace InheritanceSamples
{
    partial class Form1
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
            buttonAnimal = new Button();
            textBoxAnimalColor = new TextBox();
            textBoxAnimalSmell = new TextBox();
            textBoxAnimalFlavor = new TextBox();
            textBoxAnimalSing = new TextBox();
            textBoxCatColor = new TextBox();
            textBoxCatSmell = new TextBox();
            textBoxCatFlavor = new TextBox();
            textBoxCatEar = new TextBox();
            textBoxCatSing = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            buttonCat = new Button();
            SuspendLayout();
            // 
            // buttonAnimal
            // 
            buttonAnimal.BackColor = Color.Brown;
            buttonAnimal.ForeColor = Color.White;
            buttonAnimal.Location = new Point(82, 48);
            buttonAnimal.Name = "buttonAnimal";
            buttonAnimal.Size = new Size(100, 23);
            buttonAnimal.TabIndex = 0;
            buttonAnimal.Text = "動物クッキー";
            buttonAnimal.UseVisualStyleBackColor = false;
            buttonAnimal.Click += buttonAnimal_Click;
            // 
            // textBoxAnimalColor
            // 
            textBoxAnimalColor.Location = new Point(82, 89);
            textBoxAnimalColor.Name = "textBoxAnimalColor";
            textBoxAnimalColor.Size = new Size(100, 23);
            textBoxAnimalColor.TabIndex = 1;
            textBoxAnimalColor.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAnimalSmell
            // 
            textBoxAnimalSmell.Location = new Point(82, 141);
            textBoxAnimalSmell.Name = "textBoxAnimalSmell";
            textBoxAnimalSmell.Size = new Size(100, 23);
            textBoxAnimalSmell.TabIndex = 2;
            textBoxAnimalSmell.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAnimalFlavor
            // 
            textBoxAnimalFlavor.Location = new Point(82, 193);
            textBoxAnimalFlavor.Name = "textBoxAnimalFlavor";
            textBoxAnimalFlavor.Size = new Size(100, 23);
            textBoxAnimalFlavor.TabIndex = 3;
            textBoxAnimalFlavor.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAnimalSing
            // 
            textBoxAnimalSing.Location = new Point(82, 291);
            textBoxAnimalSing.Name = "textBoxAnimalSing";
            textBoxAnimalSing.Size = new Size(100, 23);
            textBoxAnimalSing.TabIndex = 4;
            textBoxAnimalSing.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCatColor
            // 
            textBoxCatColor.Location = new Point(206, 89);
            textBoxCatColor.Name = "textBoxCatColor";
            textBoxCatColor.Size = new Size(100, 23);
            textBoxCatColor.TabIndex = 5;
            textBoxCatColor.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCatSmell
            // 
            textBoxCatSmell.Location = new Point(206, 141);
            textBoxCatSmell.Name = "textBoxCatSmell";
            textBoxCatSmell.Size = new Size(100, 23);
            textBoxCatSmell.TabIndex = 6;
            textBoxCatSmell.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCatFlavor
            // 
            textBoxCatFlavor.Location = new Point(206, 193);
            textBoxCatFlavor.Name = "textBoxCatFlavor";
            textBoxCatFlavor.Size = new Size(100, 23);
            textBoxCatFlavor.TabIndex = 7;
            textBoxCatFlavor.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCatEar
            // 
            textBoxCatEar.Location = new Point(206, 244);
            textBoxCatEar.Name = "textBoxCatEar";
            textBoxCatEar.Size = new Size(100, 23);
            textBoxCatEar.TabIndex = 8;
            textBoxCatEar.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxCatSing
            // 
            textBoxCatSing.Location = new Point(206, 291);
            textBoxCatSing.Name = "textBoxCatSing";
            textBoxCatSing.Size = new Size(100, 23);
            textBoxCatSing.TabIndex = 9;
            textBoxCatSing.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 92);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 11;
            label1.Text = "色";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 144);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 12;
            label2.Text = "匂い";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 196);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 13;
            label3.Text = "味";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 247);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 14;
            label4.Text = "耳の形";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 294);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 15;
            label5.Text = "鳴き声";
            // 
            // buttonCat
            // 
            buttonCat.BackColor = Color.Chocolate;
            buttonCat.ForeColor = Color.White;
            buttonCat.Location = new Point(206, 48);
            buttonCat.Name = "buttonCat";
            buttonCat.Size = new Size(100, 23);
            buttonCat.TabIndex = 16;
            buttonCat.Text = "猫クッキー";
            buttonCat.UseVisualStyleBackColor = false;
            buttonCat.Click += buttonCat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCat);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCatSing);
            Controls.Add(textBoxCatEar);
            Controls.Add(textBoxCatFlavor);
            Controls.Add(textBoxCatSmell);
            Controls.Add(textBoxCatColor);
            Controls.Add(textBoxAnimalSing);
            Controls.Add(textBoxAnimalFlavor);
            Controls.Add(textBoxAnimalSmell);
            Controls.Add(textBoxAnimalColor);
            Controls.Add(buttonAnimal);
            Name = "Form1";
            Text = "継承のサンプル";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAnimal;
        private TextBox textBoxAnimalColor;
        private TextBox textBoxAnimalSmell;
        private TextBox textBoxAnimalFlavor;
        private TextBox textBoxAnimalSing;
        private TextBox textBoxCatColor;
        private TextBox textBoxCatSmell;
        private TextBox textBoxCatFlavor;
        private TextBox textBoxCatEar;
        private TextBox textBoxCatSing;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button buttonCat;
    }
}

namespace ColorpickerApp
{
    partial class Colorpicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Colorpicker));
            PaletteImageBox = new PictureBox();
            InputImageBox = new PictureBox();
            PaletteLabel = new Label();
            InputLabel = new Label();
            generate_btn = new Button();
            OutputPicture = new PictureBox();
            progressLabel = new Label();
            swap_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)PaletteImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OutputPicture).BeginInit();
            SuspendLayout();
            // 
            // PaletteImageBox
            // 
            PaletteImageBox.AccessibleDescription = "";
            PaletteImageBox.AccessibleName = "";
            PaletteImageBox.BackColor = SystemColors.Control;
            PaletteImageBox.BorderStyle = BorderStyle.FixedSingle;
            PaletteImageBox.Cursor = Cursors.Hand;
            PaletteImageBox.ImageLocation = "";
            PaletteImageBox.Location = new Point(56, 40);
            PaletteImageBox.Name = "PaletteImageBox";
            PaletteImageBox.Size = new Size(321, 182);
            PaletteImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            PaletteImageBox.TabIndex = 0;
            PaletteImageBox.TabStop = false;
            PaletteImageBox.Click += PaletteImageBox_Click;
            // 
            // InputImageBox
            // 
            InputImageBox.BackColor = SystemColors.Control;
            InputImageBox.BorderStyle = BorderStyle.FixedSingle;
            InputImageBox.Cursor = Cursors.Hand;
            InputImageBox.ImageLocation = "";
            InputImageBox.Location = new Point(423, 40);
            InputImageBox.Name = "InputImageBox";
            InputImageBox.Size = new Size(321, 182);
            InputImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            InputImageBox.TabIndex = 1;
            InputImageBox.TabStop = false;
            InputImageBox.Click += InputImageBox_Click;
            // 
            // PaletteLabel
            // 
            PaletteLabel.AutoSize = true;
            PaletteLabel.Location = new Point(56, 22);
            PaletteLabel.Name = "PaletteLabel";
            PaletteLabel.Size = new Size(43, 15);
            PaletteLabel.TabIndex = 3;
            PaletteLabel.Text = "Palette";
            PaletteLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // InputLabel
            // 
            InputLabel.AutoSize = true;
            InputLabel.Location = new Point(423, 22);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(35, 15);
            InputLabel.TabIndex = 4;
            InputLabel.Text = "Input";
            InputLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // generate_btn
            // 
            generate_btn.Cursor = Cursors.Hand;
            generate_btn.Location = new Point(56, 228);
            generate_btn.Name = "generate_btn";
            generate_btn.Size = new Size(688, 23);
            generate_btn.TabIndex = 5;
            generate_btn.Text = "Generate Colorpicked Image";
            generate_btn.UseVisualStyleBackColor = true;
            generate_btn.Click += generate_btn_Click;
            // 
            // OutputPicture
            // 
            OutputPicture.AccessibleDescription = "";
            OutputPicture.AccessibleName = "";
            OutputPicture.BackColor = SystemColors.Control;
            OutputPicture.BorderStyle = BorderStyle.FixedSingle;
            OutputPicture.ImageLocation = "";
            OutputPicture.Location = new Point(236, 257);
            OutputPicture.Name = "OutputPicture";
            OutputPicture.Size = new Size(321, 182);
            OutputPicture.SizeMode = PictureBoxSizeMode.Zoom;
            OutputPicture.TabIndex = 6;
            OutputPicture.TabStop = false;
            // 
            // progressLabel
            // 
            progressLabel.AutoSize = true;
            progressLabel.Location = new Point(6, 442);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(0, 15);
            progressLabel.TabIndex = 7;
            // 
            // swap_btn
            // 
            swap_btn.Cursor = Cursors.Hand;
            swap_btn.Location = new Point(387, 118);
            swap_btn.Name = "swap_btn";
            swap_btn.Size = new Size(27, 27);
            swap_btn.TabIndex = 8;
            swap_btn.Text = "↹";
            swap_btn.UseVisualStyleBackColor = true;
            swap_btn.Click += swap_btn_Click;
            // 
            // Colorpicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 462);
            Controls.Add(swap_btn);
            Controls.Add(progressLabel);
            Controls.Add(OutputPicture);
            Controls.Add(generate_btn);
            Controls.Add(InputLabel);
            Controls.Add(PaletteLabel);
            Controls.Add(InputImageBox);
            Controls.Add(PaletteImageBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(816, 501);
            MinimumSize = new Size(816, 501);
            Name = "Colorpicker";
            Text = "Colorpicker";
            ((System.ComponentModel.ISupportInitialize)PaletteImageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputImageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)OutputPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PaletteImageBox;
        private OpenFileDialog openFileDialog1;
        private PictureBox InputImageBox;
        private Label PaletteLabel;
        private Label InputLabel;
        private Button generate_btn;
        private PictureBox OutputPicture;
        private Label progressLabel;
        private Button swap_btn;
    }
}
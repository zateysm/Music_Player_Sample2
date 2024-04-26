namespace Music_Player_Sample2
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
            pictureBox1 = new PictureBox();
            btn_previous = new Button();
            progressBar1 = new ProgressBar();
            lbl_track_start = new Label();
            lbl_track_end = new Label();
            btn_play = new Button();
            btn_next = new Button();
            listBox1 = new ListBox();
            trackBar1 = new TrackBar();
            label1 = new Label();
            lbl_volume = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(247, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 310);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btn_previous
            // 
            btn_previous.BackgroundImage = Properties.Resources.previous_12;
            btn_previous.BackgroundImageLayout = ImageLayout.Zoom;
            btn_previous.FlatAppearance.BorderSize = 0;
            btn_previous.FlatStyle = FlatStyle.Flat;
            btn_previous.Location = new Point(304, 379);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(62, 60);
            btn_previous.TabIndex = 1;
            btn_previous.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ActiveBorder;
            progressBar1.Location = new Point(74, 338);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(683, 25);
            progressBar1.TabIndex = 2;
            // 
            // lbl_track_start
            // 
            lbl_track_start.AutoSize = true;
            lbl_track_start.Location = new Point(12, 338);
            lbl_track_start.Name = "lbl_track_start";
            lbl_track_start.Size = new Size(56, 25);
            lbl_track_start.TabIndex = 3;
            lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            lbl_track_end.AutoSize = true;
            lbl_track_end.Location = new Point(763, 338);
            lbl_track_end.Name = "lbl_track_end";
            lbl_track_end.Size = new Size(56, 25);
            lbl_track_end.TabIndex = 4;
            lbl_track_end.Text = "00:00";
            // 
            // btn_play
            // 
            btn_play.BackgroundImage = Properties.Resources._375;
            btn_play.BackgroundImageLayout = ImageLayout.Zoom;
            btn_play.FlatAppearance.BorderSize = 0;
            btn_play.FlatStyle = FlatStyle.Flat;
            btn_play.Location = new Point(372, 379);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(62, 60);
            btn_play.TabIndex = 5;
            btn_play.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            btn_next.BackgroundImage = Properties.Resources.next;
            btn_next.BackgroundImageLayout = ImageLayout.Zoom;
            btn_next.FlatAppearance.BorderSize = 0;
            btn_next.FlatStyle = FlatStyle.Flat;
            btn_next.Location = new Point(440, 379);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(62, 60);
            btn_next.TabIndex = 6;
            btn_next.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.ActiveBorder;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(12, 451);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(699, 129);
            listBox1.TabIndex = 7;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.Gray;
            trackBar1.Location = new Point(717, 451);
            trackBar1.Name = "trackBar1";
            trackBar1.Orientation = Orientation.Vertical;
            trackBar1.Size = new Size(69, 103);
            trackBar1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(717, 557);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 9;
            label1.Text = "Volume";
            label1.Click += label1_Click;
            // 
            // lbl_volume
            // 
            lbl_volume.AutoSize = true;
            lbl_volume.BackColor = Color.Transparent;
            lbl_volume.Location = new Point(792, 490);
            lbl_volume.Name = "lbl_volume";
            lbl_volume.Size = new Size(37, 25);
            lbl_volume.TabIndex = 10;
            lbl_volume.Text = "0%";
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources._512px_Folder_open_alt_font_awesome_svg;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(508, 379);
            button1.Name = "button1";
            button1.Size = new Size(62, 60);
            button1.TabIndex = 11;
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(831, 592);
            Controls.Add(button1);
            Controls.Add(lbl_volume);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(listBox1);
            Controls.Add(btn_next);
            Controls.Add(btn_play);
            Controls.Add(lbl_track_end);
            Controls.Add(lbl_track_start);
            Controls.Add(progressBar1);
            Controls.Add(btn_previous);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btn_previous;
        private ProgressBar progressBar1;
        private Label lbl_track_start;
        private Label lbl_track_end;
        private Button btn_play;
        private Button btn_next;
        private ListBox listBox1;
        private TrackBar trackBar1;
        private Label label1;
        private Label lbl_volume;
        private Button button1;
    }
}

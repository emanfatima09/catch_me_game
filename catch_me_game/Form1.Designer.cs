
namespace catch_me_game
{
    partial class catch_me
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
            this.components = new System.ComponentModel.Container();
            this.dog = new System.Windows.Forms.PictureBox();
            this.catch_timer = new System.Windows.Forms.Timer(this.components);
            this.catch_bone = new System.Windows.Forms.Label();
            this.eat_bone = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eat_bone)).BeginInit();
            this.SuspendLayout();
            // 
            // dog
            // 
            this.dog.BackColor = System.Drawing.SystemColors.Control;
            this.dog.Image = global::catch_me_game.Properties.Resources.dog_left;
            this.dog.Location = new System.Drawing.Point(299, 565);
            this.dog.Name = "dog";
            this.dog.Size = new System.Drawing.Size(80, 80);
            this.dog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dog.TabIndex = 4;
            this.dog.TabStop = false;
            this.dog.Paint += new System.Windows.Forms.PaintEventHandler(this.dog_Paint);
            // 
            // catch_timer
            // 
            this.catch_timer.Enabled = true;
            this.catch_timer.Interval = 20;
            this.catch_timer.Tick += new System.EventHandler(this.catch_Timer);
            // 
            // catch_bone
            // 
            this.catch_bone.AutoSize = true;
            this.catch_bone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catch_bone.Location = new System.Drawing.Point(136, 20);
            this.catch_bone.Name = "catch_bone";
            this.catch_bone.Size = new System.Drawing.Size(284, 46);
            this.catch_bone.TabIndex = 5;
            this.catch_bone.Text = "Bones Caught:";
            // 
            // eat_bone
            // 
            this.eat_bone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eat_bone.Image = global::catch_me_game.Properties.Resources.bone_straight;
            this.eat_bone.Location = new System.Drawing.Point(144, 104);
            this.eat_bone.Name = "eat_bone";
            this.eat_bone.Size = new System.Drawing.Size(67, 62);
            this.eat_bone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eat_bone.TabIndex = 8;
            this.eat_bone.TabStop = false;
            this.eat_bone.Tag = "eat_bone";
            this.eat_bone.Click += new System.EventHandler(this.eat_bone_Click);
            // 
            // catch_me
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(713, 657);
            this.Controls.Add(this.eat_bone);
            this.Controls.Add(this.catch_bone);
            this.Controls.Add(this.dog);
            this.Name = "catch_me";
            this.Text = "Catche ME!";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.dog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eat_bone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox dog;
        private System.Windows.Forms.Timer catch_timer;
        private System.Windows.Forms.Label catch_bone;
        private System.Windows.Forms.PictureBox eat_bone;
    }
}


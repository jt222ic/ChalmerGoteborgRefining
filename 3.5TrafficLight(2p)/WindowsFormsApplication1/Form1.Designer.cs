namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.RedLight = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.YellowLight = new System.Windows.Forms.Button();
            this.GreenLight = new System.Windows.Forms.Button();
            this.timerRed = new System.Windows.Forms.Timer(this.components);
            this.timerYellow = new System.Windows.Forms.Timer(this.components);
            this.timerGreen = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateTimePseudo = new System.Windows.Forms.Timer(this.components);
            this.YellowLightSouth = new System.Windows.Forms.Button();
            this.GreenLightSouth = new System.Windows.Forms.Button();
            this.RedLightSouth = new System.Windows.Forms.Button();
            this.YellowLightEast = new System.Windows.Forms.Button();
            this.GreenLightEast = new System.Windows.Forms.Button();
            this.RedLightEast = new System.Windows.Forms.Button();
            this.YellowLightNorth = new System.Windows.Forms.Button();
            this.GreenLightNorth = new System.Windows.Forms.Button();
            this.RedLightNorth = new System.Windows.Forms.Button();
            this.timerRed_South = new System.Windows.Forms.Timer(this.components);
            this.timerGreen_South = new System.Windows.Forms.Timer(this.components);
            this.timerYellow_South = new System.Windows.Forms.Timer(this.components);
            this.timerRed_East = new System.Windows.Forms.Timer(this.components);
            this.timerGreen_East = new System.Windows.Forms.Timer(this.components);
            this.timerYellow_East = new System.Windows.Forms.Timer(this.components);
            this.timerGreen_North = new System.Windows.Forms.Timer(this.components);
            this.timerYellow_North = new System.Windows.Forms.Timer(this.components);
            this.timerRed_North = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // RedLight
            // 
            this.RedLight.Location = new System.Drawing.Point(23, 39);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(38, 23);
            this.RedLight.TabIndex = 0;
            this.RedLight.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Play";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // YellowLight
            // 
            this.YellowLight.Location = new System.Drawing.Point(23, 77);
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.Size = new System.Drawing.Size(38, 23);
            this.YellowLight.TabIndex = 1;
            this.YellowLight.UseVisualStyleBackColor = true;
            // 
            // GreenLight
            // 
            this.GreenLight.Location = new System.Drawing.Point(23, 119);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(38, 23);
            this.GreenLight.TabIndex = 1;
            this.GreenLight.UseVisualStyleBackColor = true;
            // 
            // timerRed
            // 
            this.timerRed.Interval = 1000;
            this.timerRed.Tick += new System.EventHandler(this.timerRed_Tick);
            // 
            // timerYellow
            // 
            this.timerYellow.Interval = 1000;
            this.timerYellow.Tick += new System.EventHandler(this.timerYellow_Tick);
            // 
            // timerGreen
            // 
            this.timerGreen.Interval = 1000;
            this.timerGreen.Tick += new System.EventHandler(this.timerGreen_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // UpdateTimePseudo
            // 
            this.UpdateTimePseudo.Interval = 1000;
            this.UpdateTimePseudo.Tick += new System.EventHandler(this.Pseudo_UpdateTick);
            // 
            // YellowLightSouth
            // 
            this.YellowLightSouth.Location = new System.Drawing.Point(207, 228);
            this.YellowLightSouth.Name = "YellowLightSouth";
            this.YellowLightSouth.Size = new System.Drawing.Size(38, 23);
            this.YellowLightSouth.TabIndex = 5;
            this.YellowLightSouth.UseVisualStyleBackColor = true;
            // 
            // GreenLightSouth
            // 
            this.GreenLightSouth.Location = new System.Drawing.Point(207, 270);
            this.GreenLightSouth.Name = "GreenLightSouth";
            this.GreenLightSouth.Size = new System.Drawing.Size(38, 23);
            this.GreenLightSouth.TabIndex = 4;
            this.GreenLightSouth.UseVisualStyleBackColor = true;
            // 
            // RedLightSouth
            // 
            this.RedLightSouth.Location = new System.Drawing.Point(207, 190);
            this.RedLightSouth.Name = "RedLightSouth";
            this.RedLightSouth.Size = new System.Drawing.Size(38, 23);
            this.RedLightSouth.TabIndex = 3;
            this.RedLightSouth.UseVisualStyleBackColor = true;
            // 
            // YellowLightEast
            // 
            this.YellowLightEast.Location = new System.Drawing.Point(390, 157);
            this.YellowLightEast.Name = "YellowLightEast";
            this.YellowLightEast.Size = new System.Drawing.Size(38, 23);
            this.YellowLightEast.TabIndex = 8;
            this.YellowLightEast.UseVisualStyleBackColor = true;
            // 
            // GreenLightEast
            // 
            this.GreenLightEast.Location = new System.Drawing.Point(390, 199);
            this.GreenLightEast.Name = "GreenLightEast";
            this.GreenLightEast.Size = new System.Drawing.Size(38, 23);
            this.GreenLightEast.TabIndex = 7;
            this.GreenLightEast.UseVisualStyleBackColor = true;
            // 
            // RedLightEast
            // 
            this.RedLightEast.Location = new System.Drawing.Point(390, 119);
            this.RedLightEast.Name = "RedLightEast";
            this.RedLightEast.Size = new System.Drawing.Size(38, 23);
            this.RedLightEast.TabIndex = 6;
            this.RedLightEast.UseVisualStyleBackColor = true;
            // 
            // YellowLightNorth
            // 
            this.YellowLightNorth.Location = new System.Drawing.Point(257, 72);
            this.YellowLightNorth.Name = "YellowLightNorth";
            this.YellowLightNorth.Size = new System.Drawing.Size(38, 23);
            this.YellowLightNorth.TabIndex = 11;
            this.YellowLightNorth.UseVisualStyleBackColor = true;
            // 
            // GreenLightNorth
            // 
            this.GreenLightNorth.Location = new System.Drawing.Point(257, 114);
            this.GreenLightNorth.Name = "GreenLightNorth";
            this.GreenLightNorth.Size = new System.Drawing.Size(38, 23);
            this.GreenLightNorth.TabIndex = 10;
            this.GreenLightNorth.UseVisualStyleBackColor = true;
            // 
            // RedLightNorth
            // 
            this.RedLightNorth.Location = new System.Drawing.Point(257, 34);
            this.RedLightNorth.Name = "RedLightNorth";
            this.RedLightNorth.Size = new System.Drawing.Size(38, 23);
            this.RedLightNorth.TabIndex = 9;
            this.RedLightNorth.UseVisualStyleBackColor = true;
            // 
            // timerRed_South
            // 
            this.timerRed_South.Interval = 1000;
            this.timerRed_South.Tick += new System.EventHandler(this.timerRed_Tick_South);
            // 
            // timerGreen_South
            // 
            this.timerGreen_South.Interval = 1000;
            this.timerGreen_South.Tick += new System.EventHandler(this.timerGreen_Tick_South);
            // 
            // timerYellow_South
            // 
            this.timerYellow_South.Interval = 1000;
            this.timerYellow_South.Tick += new System.EventHandler(this.timerYellow_Tick_South);
            // 
            // timerRed_East
            // 
            this.timerRed_East.Interval = 1000;
            this.timerRed_East.Tick += new System.EventHandler(this.timerRed_Tick_East);
            // 
            // timerGreen_East
            // 
            this.timerGreen_East.Interval = 1000;
            this.timerGreen_East.Tick += new System.EventHandler(this.timerGreen_Tick_East);
            // 
            // timerYellow_East
            // 
            this.timerYellow_East.Interval = 1000;
            this.timerYellow_East.Tick += new System.EventHandler(this.timerYellow_Tick_East);
            // 
            // timerGreen_North
            // 
            this.timerGreen_North.Interval = 1000;
            this.timerGreen_North.Tick += new System.EventHandler(this.timerGreen_Tick_North);
            // 
            // timerYellow_North
            // 
            this.timerYellow_North.Interval = 1000;
            this.timerYellow_North.Tick += new System.EventHandler(this.timerYellow_Tick_North);
            // 
            // timerRed_North
            // 
            this.timerRed_North.Interval = 1000;
            this.timerRed_North.Tick += new System.EventHandler(this.timerRed_Tick_North);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 411);
            this.Controls.Add(this.YellowLightNorth);
            this.Controls.Add(this.GreenLightNorth);
            this.Controls.Add(this.RedLightNorth);
            this.Controls.Add(this.YellowLightEast);
            this.Controls.Add(this.GreenLightEast);
            this.Controls.Add(this.RedLightEast);
            this.Controls.Add(this.YellowLightSouth);
            this.Controls.Add(this.GreenLightSouth);
            this.Controls.Add(this.RedLightSouth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.RedLight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RedLight;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button YellowLight;
        private System.Windows.Forms.Button GreenLight;
        private System.Windows.Forms.Timer timerRed;
        private System.Windows.Forms.Timer timerYellow;
        private System.Windows.Forms.Timer timerGreen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer UpdateTimePseudo;
        private System.Windows.Forms.Button YellowLightSouth;
        private System.Windows.Forms.Button GreenLightSouth;
        private System.Windows.Forms.Button RedLightSouth;
        private System.Windows.Forms.Button YellowLightEast;
        private System.Windows.Forms.Button GreenLightEast;
        private System.Windows.Forms.Button RedLightEast;
        private System.Windows.Forms.Button YellowLightNorth;
        private System.Windows.Forms.Button GreenLightNorth;
        private System.Windows.Forms.Button RedLightNorth;
        private System.Windows.Forms.Timer timerRed_South;
        private System.Windows.Forms.Timer timerGreen_South;
        private System.Windows.Forms.Timer timerYellow_South;
        private System.Windows.Forms.Timer timerRed_East;
        private System.Windows.Forms.Timer timerGreen_East;
        private System.Windows.Forms.Timer timerYellow_East;
        private System.Windows.Forms.Timer timerGreen_North;
        private System.Windows.Forms.Timer timerYellow_North;
        private System.Windows.Forms.Timer timerRed_North;
    }
}


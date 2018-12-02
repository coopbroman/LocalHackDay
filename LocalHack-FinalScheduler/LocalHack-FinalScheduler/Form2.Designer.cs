namespace LocalHack_FinalScheduler
{
    partial class FRMinstruct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMinstruct));
            this.LBLinstructions = new System.Windows.Forms.Label();
            this.PBXtitlePic = new System.Windows.Forms.PictureBox();
            this.BTNstart = new System.Windows.Forms.Button();
            this.LBLtitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PBXtitlePic)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLinstructions
            // 
            this.LBLinstructions.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLinstructions.ForeColor = System.Drawing.Color.White;
            this.LBLinstructions.Location = new System.Drawing.Point(148, 313);
            this.LBLinstructions.Name = "LBLinstructions";
            this.LBLinstructions.Size = new System.Drawing.Size(495, 53);
            this.LBLinstructions.TabIndex = 0;
            this.LBLinstructions.Text = "To get started select either a course or the first time you meet with that class " +
    "during the week. Then add the course to see when the final exam is!";
            // 
            // PBXtitlePic
            // 
            this.PBXtitlePic.Image = global::LocalHack_FinalScheduler.Properties.Resources._1200px_Missouri_S_T_Miners_wordmark_svg;
            this.PBXtitlePic.Location = new System.Drawing.Point(182, 55);
            this.PBXtitlePic.Name = "PBXtitlePic";
            this.PBXtitlePic.Size = new System.Drawing.Size(406, 204);
            this.PBXtitlePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBXtitlePic.TabIndex = 1;
            this.PBXtitlePic.TabStop = false;
            // 
            // BTNstart
            // 
            this.BTNstart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNstart.Location = new System.Drawing.Point(302, 369);
            this.BTNstart.Name = "BTNstart";
            this.BTNstart.Size = new System.Drawing.Size(159, 42);
            this.BTNstart.TabIndex = 2;
            this.BTNstart.Text = "Start Planning!";
            this.BTNstart.UseVisualStyleBackColor = true;
            this.BTNstart.Click += new System.EventHandler(this.BTNstart_Click);
            // 
            // LBLtitle
            // 
            this.LBLtitle.AutoSize = true;
            this.LBLtitle.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLtitle.ForeColor = System.Drawing.Color.White;
            this.LBLtitle.Location = new System.Drawing.Point(206, 280);
            this.LBLtitle.Name = "LBLtitle";
            this.LBLtitle.Size = new System.Drawing.Size(356, 23);
            this.LBLtitle.TabIndex = 3;
            this.LBLtitle.Text = "Welcome to the Final Exam Scheduler! ";
            this.LBLtitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FRMinstruct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LBLtitle);
            this.Controls.Add(this.BTNstart);
            this.Controls.Add(this.PBXtitlePic);
            this.Controls.Add(this.LBLinstructions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FRMinstruct";
            this.Text = "Welcome to Final Schedule Planner";
            this.Load += new System.EventHandler(this.FRMinstruct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PBXtitlePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLinstructions;
        private System.Windows.Forms.PictureBox PBXtitlePic;
        private System.Windows.Forms.Button BTNstart;
        private System.Windows.Forms.Label LBLtitle;
    }
}
namespace weather_app
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Citylabel = new System.Windows.Forms.Label();
            this.Currenttemp = new System.Windows.Forms.Label();
            this.Todaylabel = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.todayunderline = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Citylabel
            // 
            this.Citylabel.AutoSize = true;
            this.Citylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Citylabel.Location = new System.Drawing.Point(77, 136);
            this.Citylabel.Name = "Citylabel";
            this.Citylabel.Size = new System.Drawing.Size(71, 37);
            this.Citylabel.TabIndex = 0;
            this.Citylabel.Text = "City";
            this.Citylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Currenttemp
            // 
            this.Currenttemp.AutoSize = true;
            this.Currenttemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Currenttemp.Location = new System.Drawing.Point(74, 222);
            this.Currenttemp.Name = "Currenttemp";
            this.Currenttemp.Size = new System.Drawing.Size(152, 55);
            this.Currenttemp.TabIndex = 1;
            this.Currenttemp.Text = "label2";
            // 
            // Todaylabel
            // 
            this.Todaylabel.AutoSize = true;
            this.Todaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todaylabel.Location = new System.Drawing.Point(0, 13);
            this.Todaylabel.Name = "Todaylabel";
            this.Todaylabel.Size = new System.Drawing.Size(90, 31);
            this.Todaylabel.TabIndex = 4;
            this.Todaylabel.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.AutoSize = true;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.Location = new System.Drawing.Point(199, 13);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 31);
            this.forecastLabel.TabIndex = 5;
            this.forecastLabel.Text = "Week";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Today";
            // 
            // todayunderline
            // 
            this.todayunderline.AutoSize = true;
            this.todayunderline.BackColor = System.Drawing.Color.Transparent;
            this.todayunderline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.todayunderline.Location = new System.Drawing.Point(3, 47);
            this.todayunderline.Name = "todayunderline";
            this.todayunderline.Size = new System.Drawing.Size(103, 13);
            this.todayunderline.TabIndex = 6;
            this.todayunderline.Text = "________________";
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.todayunderline);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.Todaylabel);
            this.Controls.Add(this.Currenttemp);
            this.Controls.Add(this.Citylabel);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(300, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Citylabel;
        private System.Windows.Forms.Label Currenttemp;
        private System.Windows.Forms.Label Todaylabel;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label todayunderline;
    }
}

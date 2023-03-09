namespace devicesCircuitGraph
{
    partial class device
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
            this.pin3 = new devicesCircuitGraph.pin();
            this.pin2 = new devicesCircuitGraph.pin();
            this.pin1 = new devicesCircuitGraph.pin();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pin3
            // 
            this.pin3.BackColor = System.Drawing.Color.Red;
            this.pin3.Location = new System.Drawing.Point(69, 35);
            this.pin3.Name = "pin3";
            this.pin3.Size = new System.Drawing.Size(25, 13);
            this.pin3.TabIndex = 2;
            // 
            // pin2
            // 
            this.pin2.BackColor = System.Drawing.Color.Red;
            this.pin2.Location = new System.Drawing.Point(0, 58);
            this.pin2.Name = "pin2";
            this.pin2.Size = new System.Drawing.Size(25, 13);
            this.pin2.TabIndex = 1;
            // 
            // pin1
            // 
            this.pin1.BackColor = System.Drawing.Color.Red;
            this.pin1.Location = new System.Drawing.Point(0, 14);
            this.pin1.Name = "pin1";
            this.pin1.Size = new System.Drawing.Size(25, 13);
            this.pin1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "AND";
            // 
            // device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pin3);
            this.Controls.Add(this.pin2);
            this.Controls.Add(this.pin1);
            this.Name = "device";
            this.Size = new System.Drawing.Size(91, 84);
            this.Load += new System.EventHandler(this.device_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private pin pin1;
        private pin pin2;
        private pin pin3;
        private System.Windows.Forms.Label label1;
    }
}

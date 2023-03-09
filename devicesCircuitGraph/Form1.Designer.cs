namespace devicesCircuitGraph
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
            this.device1 = new devicesCircuitGraph.device();
            this.device2 = new devicesCircuitGraph.device();
            this.device3 = new devicesCircuitGraph.device();
            this.SuspendLayout();
            // 
            // device1
            // 
            this.device1.BackColor = System.Drawing.Color.Silver;
            this.device1.Location = new System.Drawing.Point(213, 90);
            this.device1.Name = "device1";
            this.device1.Size = new System.Drawing.Size(91, 84);
            this.device1.TabIndex = 0;
            // 
            // device2
            // 
            this.device2.BackColor = System.Drawing.Color.Silver;
            this.device2.Location = new System.Drawing.Point(375, 157);
            this.device2.Name = "device2";
            this.device2.Size = new System.Drawing.Size(91, 84);
            this.device2.TabIndex = 0;
            // 
            // device3
            // 
            this.device3.BackColor = System.Drawing.Color.Silver;
            this.device3.Location = new System.Drawing.Point(513, 246);
            this.device3.Name = "device3";
            this.device3.Size = new System.Drawing.Size(91, 84);
            this.device3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 706);
            this.Controls.Add(this.device3);
            this.Controls.Add(this.device2);
            this.Controls.Add(this.device1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }


        #endregion

        private device device1;
        private device device2;
        private device device3;
    }
}


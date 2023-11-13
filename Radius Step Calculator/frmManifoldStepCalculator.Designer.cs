namespace Manifold_Step_Calculator
{
    partial class frmManifoldStepCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManifoldStepCalculator));
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtXOffset = new System.Windows.Forms.TextBox();
            this.lblXOffset = new System.Windows.Forms.Label();
            this.txtYOffset = new System.Windows.Forms.TextBox();
            this.lblYOffset = new System.Windows.Forms.Label();
            this.txtStartAngle = new System.Windows.Forms.TextBox();
            this.lblStartAngle = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkInc = new System.Windows.Forms.CheckBox();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.lblBold = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.lblFormat = new System.Windows.Forms.Label();
            this.txtNumHoles = new System.Windows.Forms.TextBox();
            this.lblNumHoles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(130, 86);
            this.txtRadius.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(100, 22);
            this.txtRadius.TabIndex = 2;
            this.txtRadius.Text = "0.0";
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(73, 88);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(50, 16);
            this.lblRadius.TabIndex = 1;
            this.lblRadius.Text = "Radius";
            // 
            // txtXOffset
            // 
            this.txtXOffset.Location = new System.Drawing.Point(130, 130);
            this.txtXOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtXOffset.Name = "txtXOffset";
            this.txtXOffset.Size = new System.Drawing.Size(100, 22);
            this.txtXOffset.TabIndex = 3;
            this.txtXOffset.Text = "0.0";
            // 
            // lblXOffset
            // 
            this.lblXOffset.AutoSize = true;
            this.lblXOffset.Location = new System.Drawing.Point(20, 132);
            this.lblXOffset.Name = "lblXOffset";
            this.lblXOffset.Size = new System.Drawing.Size(94, 16);
            this.lblXOffset.TabIndex = 5;
            this.lblXOffset.Text = "Center X Offset";
            // 
            // txtYOffset
            // 
            this.txtYOffset.Location = new System.Drawing.Point(130, 158);
            this.txtYOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYOffset.Name = "txtYOffset";
            this.txtYOffset.Size = new System.Drawing.Size(100, 22);
            this.txtYOffset.TabIndex = 4;
            this.txtYOffset.Text = "0.0";
            // 
            // lblYOffset
            // 
            this.lblYOffset.AutoSize = true;
            this.lblYOffset.Location = new System.Drawing.Point(20, 161);
            this.lblYOffset.Name = "lblYOffset";
            this.lblYOffset.Size = new System.Drawing.Size(95, 16);
            this.lblYOffset.TabIndex = 7;
            this.lblYOffset.Text = "Center Y Offset";
            // 
            // txtStartAngle
            // 
            this.txtStartAngle.Location = new System.Drawing.Point(130, 201);
            this.txtStartAngle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStartAngle.Name = "txtStartAngle";
            this.txtStartAngle.Size = new System.Drawing.Size(100, 22);
            this.txtStartAngle.TabIndex = 5;
            this.txtStartAngle.Text = "0.0";
            // 
            // lblStartAngle
            // 
            this.lblStartAngle.AutoSize = true;
            this.lblStartAngle.Location = new System.Drawing.Point(48, 204);
            this.lblStartAngle.Name = "lblStartAngle";
            this.lblStartAngle.Size = new System.Drawing.Size(72, 16);
            this.lblStartAngle.TabIndex = 9;
            this.lblStartAngle.Text = "Start Angle";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(515, 414);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 46);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkInc
            // 
            this.chkInc.AutoSize = true;
            this.chkInc.Location = new System.Drawing.Point(251, 402);
            this.chkInc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkInc.Name = "chkInc";
            this.chkInc.Size = new System.Drawing.Size(98, 20);
            this.chkInc.TabIndex = 6;
            this.chkInc.Text = "Incremental";
            this.chkInc.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(251, 30);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.txtOutput.Size = new System.Drawing.Size(453, 367);
            this.txtOutput.TabIndex = 22;
            this.txtOutput.TabStop = false;
            this.txtOutput.Text = "";
            // 
            // lblBold
            // 
            this.lblBold.AutoSize = true;
            this.lblBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBold.Location = new System.Drawing.Point(403, 9);
            this.lblBold.Name = "lblBold";
            this.lblBold.Size = new System.Drawing.Size(160, 16);
            this.lblBold.TabIndex = 23;
            this.lblBold.Text = "Move BOLD Axis First!";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(355, 437);
            this.txtFormat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFormat.MaxLength = 7;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(77, 22);
            this.txtFormat.TabIndex = 7;
            this.txtFormat.Text = "0.000";
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(247, 441);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(102, 16);
            this.lblFormat.TabIndex = 26;
            this.lblFormat.Text = "Decimal Format";
            // 
            // txtNumHoles
            // 
            this.txtNumHoles.Location = new System.Drawing.Point(130, 49);
            this.txtNumHoles.Name = "txtNumHoles";
            this.txtNumHoles.Size = new System.Drawing.Size(100, 22);
            this.txtNumHoles.TabIndex = 1;
            this.txtNumHoles.Text = "4";
            // 
            // lblNumHoles
            // 
            this.lblNumHoles.AutoSize = true;
            this.lblNumHoles.Location = new System.Drawing.Point(67, 52);
            this.lblNumHoles.Name = "lblNumHoles";
            this.lblNumHoles.Size = new System.Drawing.Size(53, 16);
            this.lblNumHoles.TabIndex = 28;
            this.lblNumHoles.Text = "# Holes";
            // 
            // frmManifoldStepCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 486);
            this.Controls.Add(this.lblNumHoles);
            this.Controls.Add(this.txtNumHoles);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.lblBold);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.chkInc);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblStartAngle);
            this.Controls.Add(this.txtStartAngle);
            this.Controls.Add(this.lblYOffset);
            this.Controls.Add(this.txtYOffset);
            this.Controls.Add(this.lblXOffset);
            this.Controls.Add(this.txtXOffset);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.txtRadius);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmManifoldStepCalculator";
            this.Text = "Manifold Step Calculator v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtXOffset;
        private System.Windows.Forms.Label lblXOffset;
        private System.Windows.Forms.TextBox txtYOffset;
        private System.Windows.Forms.Label lblYOffset;
        private System.Windows.Forms.TextBox txtStartAngle;
        private System.Windows.Forms.Label lblStartAngle;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkInc;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.Label lblBold;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TextBox txtNumHoles;
        private System.Windows.Forms.Label lblNumHoles;
    }
}


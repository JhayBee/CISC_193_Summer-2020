namespace Project_1
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
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(139, 156);
            this.lblLength.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(81, 26);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Length:";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(139, 256);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(73, 26);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width:";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(139, 357);
            this.lblArea.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(60, 26);
            this.lblArea.TabIndex = 2;
            this.lblArea.Text = "Area:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(139, 459);
            this.lblPerimeter.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(105, 26);
            this.lblPerimeter.TabIndex = 3;
            this.lblPerimeter.Text = "Perimeter:";
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(406, 156);
            this.txtLength.Margin = new System.Windows.Forms.Padding(6);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(196, 33);
            this.txtLength.TabIndex = 4;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(406, 256);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(6);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(196, 33);
            this.txtWidth.TabIndex = 5;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(406, 357);
            this.txtArea.Margin = new System.Windows.Forms.Padding(6);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(196, 33);
            this.txtArea.TabIndex = 6;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Location = new System.Drawing.Point(406, 459);
            this.txtPerimeter.Margin = new System.Windows.Forms.Padding(6);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.ReadOnly = true;
            this.txtPerimeter.Size = new System.Drawing.Size(196, 33);
            this.txtPerimeter.TabIndex = 7;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(144, 549);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(6);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(150, 46);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(452, 549);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(150, 46);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(747, 665);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtPerimeter);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.lblPerimeter);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Area and Perimeter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
    }
}


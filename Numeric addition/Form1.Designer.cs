namespace Numeric_addition
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
            this.BTN_Sum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBX_Input = new System.Windows.Forms.TextBox();
            this.TBX_Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_Sum
            // 
            this.BTN_Sum.Location = new System.Drawing.Point(12, 118);
            this.BTN_Sum.Name = "BTN_Sum";
            this.BTN_Sum.Size = new System.Drawing.Size(318, 38);
            this.BTN_Sum.TabIndex = 0;
            this.BTN_Sum.Text = "Find the sum of the digits";
            this.BTN_Sum.UseVisualStyleBackColor = true;
            this.BTN_Sum.Click += new System.EventHandler(this.BTN_Sum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sum of digits calculator";
            // 
            // TBX_Input
            // 
            this.TBX_Input.Location = new System.Drawing.Point(12, 83);
            this.TBX_Input.Name = "TBX_Input";
            this.TBX_Input.Size = new System.Drawing.Size(318, 20);
            this.TBX_Input.TabIndex = 2;
            this.TBX_Input.Text = "Number Input";
            // 
            // TBX_Output
            // 
            this.TBX_Output.Location = new System.Drawing.Point(12, 174);
            this.TBX_Output.Name = "TBX_Output";
            this.TBX_Output.Size = new System.Drawing.Size(318, 20);
            this.TBX_Output.TabIndex = 3;
            this.TBX_Output.Text = "Number Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 243);
            this.Controls.Add(this.TBX_Output);
            this.Controls.Add(this.TBX_Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Sum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_Sum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBX_Input;
        private System.Windows.Forms.TextBox TBX_Output;
    }
}


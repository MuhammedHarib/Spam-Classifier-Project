namespace SpamClassifierApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblConfidence = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(237, 69);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(301, 131);
            this.txtInput.TabIndex = 0;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(315, 243);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(103, 35);
            this.btnPredict.TabIndex = 1;
            this.btnPredict.Text = "Predict";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(335, 304);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 21);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result:";
            // 
            // lblConfidence
            // 
            this.lblConfidence.AutoSize = true;
            this.lblConfidence.Location = new System.Drawing.Point(332, 355);
            this.lblConfidence.Name = "lblConfidence";
            this.lblConfidence.Size = new System.Drawing.Size(64, 13);
            this.lblConfidence.TabIndex = 3;
            this.lblConfidence.Text = "Confidence:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 423);
            this.Controls.Add(this.lblConfidence);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.txtInput);
            this.Name = "Form1";
            this.Text = "Spam Classifier ML";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Declare the UI components
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblConfidence;
    }
}
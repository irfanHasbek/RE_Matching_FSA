namespace RE_Matching_FSA_Project
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
            this.btn_check = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_inputs = new System.Windows.Forms.RichTextBox();
            this.txt_re = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_results = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(365, 179);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(130, 94);
            this.btn_check.TabIndex = 0;
            this.btn_check.Text = "CHECK STRING";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INPUTS";
            // 
            // rtb_inputs
            // 
            this.rtb_inputs.Location = new System.Drawing.Point(47, 109);
            this.rtb_inputs.Name = "rtb_inputs";
            this.rtb_inputs.Size = new System.Drawing.Size(223, 274);
            this.rtb_inputs.TabIndex = 2;
            this.rtb_inputs.Text = "";
            // 
            // txt_re
            // 
            this.txt_re.Location = new System.Drawing.Point(317, 109);
            this.txt_re.Name = "txt_re";
            this.txt_re.Size = new System.Drawing.Size(223, 20);
            this.txt_re.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "REGULAR EXPRESSION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(593, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RESULTS";
            // 
            // rtb_results
            // 
            this.rtb_results.Location = new System.Drawing.Point(596, 109);
            this.rtb_results.Name = "rtb_results";
            this.rtb_results.Size = new System.Drawing.Size(223, 274);
            this.rtb_results.TabIndex = 6;
            this.rtb_results.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 468);
            this.Controls.Add(this.rtb_results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_re);
            this.Controls.Add(this.rtb_inputs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_check);
            this.Name = "Form1";
            this.Text = "REGULAR EXPRESSION FOR MATCHING FSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_inputs;
        private System.Windows.Forms.TextBox txt_re;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_results;
    }
}


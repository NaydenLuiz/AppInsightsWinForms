namespace WinFormsAppInsights
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
            this.btn_action1 = new System.Windows.Forms.Button();
            this.btn_action2 = new System.Windows.Forms.Button();
            this.btn_action3 = new System.Windows.Forms.Button();
            this.btn_action4 = new System.Windows.Forms.Button();
            this.btn_exception = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_action1
            // 
            this.btn_action1.Location = new System.Drawing.Point(62, 16);
            this.btn_action1.Name = "btn_action1";
            this.btn_action1.Size = new System.Drawing.Size(137, 23);
            this.btn_action1.TabIndex = 0;
            this.btn_action1.Text = "Action 1";
            this.btn_action1.UseVisualStyleBackColor = true;
            this.btn_action1.Click += new System.EventHandler(this.btn_action1_Click);
            // 
            // btn_action2
            // 
            this.btn_action2.Location = new System.Drawing.Point(62, 59);
            this.btn_action2.Name = "btn_action2";
            this.btn_action2.Size = new System.Drawing.Size(137, 23);
            this.btn_action2.TabIndex = 1;
            this.btn_action2.Text = "Action 2";
            this.btn_action2.UseVisualStyleBackColor = true;
            this.btn_action2.Click += new System.EventHandler(this.btn_action2_Click);
            // 
            // btn_action3
            // 
            this.btn_action3.Location = new System.Drawing.Point(62, 101);
            this.btn_action3.Name = "btn_action3";
            this.btn_action3.Size = new System.Drawing.Size(137, 23);
            this.btn_action3.TabIndex = 2;
            this.btn_action3.Text = "Action 3";
            this.btn_action3.UseVisualStyleBackColor = true;
            this.btn_action3.Click += new System.EventHandler(this.btn_action3_Click);
            // 
            // btn_action4
            // 
            this.btn_action4.Location = new System.Drawing.Point(62, 150);
            this.btn_action4.Name = "btn_action4";
            this.btn_action4.Size = new System.Drawing.Size(137, 23);
            this.btn_action4.TabIndex = 3;
            this.btn_action4.Text = "Action 4";
            this.btn_action4.UseVisualStyleBackColor = true;
            this.btn_action4.Click += new System.EventHandler(this.btn_action4_Click);
            // 
            // btn_exception
            // 
            this.btn_exception.Location = new System.Drawing.Point(62, 198);
            this.btn_exception.Name = "btn_exception";
            this.btn_exception.Size = new System.Drawing.Size(137, 23);
            this.btn_exception.TabIndex = 4;
            this.btn_exception.Text = "Exception";
            this.btn_exception.UseVisualStyleBackColor = true;
            this.btn_exception.Click += new System.EventHandler(this.btn_exception_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(245, 252);
            this.Controls.Add(this.btn_exception);
            this.Controls.Add(this.btn_action4);
            this.Controls.Add(this.btn_action3);
            this.Controls.Add(this.btn_action2);
            this.Controls.Add(this.btn_action1);
            this.Name = "Form1";
            this.Text = "App Insights Log";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_action1;
        private System.Windows.Forms.Button btn_action2;
        private System.Windows.Forms.Button btn_action3;
        private System.Windows.Forms.Button btn_action4;
        private System.Windows.Forms.Button btn_exception;
    }
}


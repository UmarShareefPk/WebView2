namespace ScappingWeb
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.scriptText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(-1, 114);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1119, 968);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            this.webView21.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.webView21_NavigationCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(430, 72);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load Web Site";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1383, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(416, 72);
            this.button2.TabIndex = 2;
            this.button2.Text = "Load HTML";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1273, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(789, 925);
            this.textBox1.TabIndex = 3;
            // 
            // scriptText
            // 
            this.scriptText.Location = new System.Drawing.Point(91, 1146);
            this.scriptText.Multiline = true;
            this.scriptText.Name = "scriptText";
            this.scriptText.Size = new System.Drawing.Size(570, 217);
            this.scriptText.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(730, 1203);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(203, 129);
            this.button3.TabIndex = 5;
            this.button3.Text = "Execute Script";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(1340, 1146);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(417, 154);
            this.runBtn.TabIndex = 6;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(1805, 1189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 38);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result will show here";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2215, 1450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.scriptText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webView21);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox scriptText;
        private Button button3;
        private Button runBtn;
        private Label label1;
    }
}

namespace BalancedCashRegister
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Currency_Title = new System.Windows.Forms.Label();
            this.Enter = new System.Windows.Forms.Button();
            this.Canada = new System.Windows.Forms.RadioButton();
            this.United_States = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Debug_Title = new System.Windows.Forms.Label();
            this.Debug_Output = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.4F));
            this.tableLayoutPanel1.Controls.Add(this.Currency_Title, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Enter, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Canada, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.United_States, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(250, 136);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Currency_Title
            // 
            this.Currency_Title.AutoSize = true;
            this.Currency_Title.Location = new System.Drawing.Point(22, 0);
            this.Currency_Title.Name = "Currency_Title";
            this.Currency_Title.Size = new System.Drawing.Size(171, 20);
            this.Currency_Title.TabIndex = 1;
            this.Currency_Title.Text = "Please Choose a Country";
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(22, 105);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(94, 28);
            this.Enter.TabIndex = 1;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // Canada
            // 
            this.Canada.AutoSize = true;
            this.Canada.Location = new System.Drawing.Point(22, 71);
            this.Canada.Name = "Canada";
            this.Canada.Size = new System.Drawing.Size(80, 24);
            this.Canada.TabIndex = 2;
            this.Canada.TabStop = true;
            this.Canada.Text = "Canada";
            this.Canada.UseVisualStyleBackColor = true;
            // 
            // United_States
            // 
            this.United_States.AutoSize = true;
            this.United_States.Location = new System.Drawing.Point(22, 37);
            this.United_States.Name = "United_States";
            this.United_States.Size = new System.Drawing.Size(118, 24);
            this.United_States.TabIndex = 1;
            this.United_States.TabStop = true;
            this.United_States.Text = "United States";
            this.United_States.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.Debug_Title, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Debug_Output, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(307, 74);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(196, 125);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // Debug_Title
            // 
            this.Debug_Title.AutoSize = true;
            this.Debug_Title.Location = new System.Drawing.Point(3, 0);
            this.Debug_Title.Name = "Debug_Title";
            this.Debug_Title.Size = new System.Drawing.Size(104, 20);
            this.Debug_Title.TabIndex = 0;
            this.Debug_Title.Text = "Debug Output";
            // 
            // Debug_Output
            // 
            this.Debug_Output.Location = new System.Drawing.Point(3, 38);
            this.Debug_Output.Multiline = true;
            this.Debug_Output.Name = "Debug_Output";
            this.Debug_Output.ReadOnly = true;
            this.Debug_Output.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Debug_Output.Size = new System.Drawing.Size(190, 84);
            this.Debug_Output.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton United_States;
        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.RadioButton Canada;
        private System.Windows.Forms.Label Currency_Title;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Debug_Title;
        private System.Windows.Forms.TextBox Debug_Output;
    }
}


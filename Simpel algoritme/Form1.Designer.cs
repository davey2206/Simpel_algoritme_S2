
namespace Simpel_algoritme
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
            this.ProductButton = new System.Windows.Forms.Button();
            this.ProductBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.minPriceButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.maxButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(151, 164);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(159, 23);
            this.ProductButton.TabIndex = 1;
            this.ProductButton.Text = "Add";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // ProductBox
            // 
            this.ProductBox.FormattingEnabled = true;
            this.ProductBox.Location = new System.Drawing.Point(151, 137);
            this.ProductBox.Name = "ProductBox";
            this.ProductBox.Size = new System.Drawing.Size(159, 21);
            this.ProductBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 42);
            this.label2.TabIndex = 5;
            this.label2.Text = "Products";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(483, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(543, 137);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(245, 290);
            this.listBox1.TabIndex = 7;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(462, 404);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // minPriceButton
            // 
            this.minPriceButton.Location = new System.Drawing.Point(462, 375);
            this.minPriceButton.Name = "minPriceButton";
            this.minPriceButton.Size = new System.Drawing.Size(75, 23);
            this.minPriceButton.TabIndex = 9;
            this.minPriceButton.Text = "Min price";
            this.minPriceButton.UseVisualStyleBackColor = true;
            this.minPriceButton.Click += new System.EventHandler(this.minPriceButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(462, 346);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(75, 23);
            this.averageButton.TabIndex = 10;
            this.averageButton.Text = "Average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // maxButton
            // 
            this.maxButton.Location = new System.Drawing.Point(462, 317);
            this.maxButton.Name = "maxButton";
            this.maxButton.Size = new System.Drawing.Size(75, 23);
            this.maxButton.TabIndex = 11;
            this.maxButton.Text = "Max";
            this.maxButton.UseVisualStyleBackColor = true;
            this.maxButton.Click += new System.EventHandler(this.maxButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(356, 375);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maxButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.minPriceButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ProductBox);
            this.Controls.Add(this.ProductButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.ComboBox ProductBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button minPriceButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button maxButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}


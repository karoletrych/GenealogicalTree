namespace Frontend
{
    partial class AddMarriage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.marriageId = new System.Windows.Forms.TextBox();
            this.husband = new System.Windows.Forms.TextBox();
            this.wife = new System.Windows.Forms.TextBox();
            this.marriageDate = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id malzenstwa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "id męża";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "id żony\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "data";
            // 
            // marriageId
            // 
            this.marriageId.Location = new System.Drawing.Point(105, 13);
            this.marriageId.Name = "marriageId";
            this.marriageId.Size = new System.Drawing.Size(100, 20);
            this.marriageId.TabIndex = 4;
            // 
            // husband
            // 
            this.husband.Location = new System.Drawing.Point(105, 36);
            this.husband.Name = "husband";
            this.husband.Size = new System.Drawing.Size(100, 20);
            this.husband.TabIndex = 5;
            // 
            // wife
            // 
            this.wife.Location = new System.Drawing.Point(105, 56);
            this.wife.Name = "wife";
            this.wife.Size = new System.Drawing.Size(100, 20);
            this.wife.TabIndex = 6;
            // 
            // marriageDate
            // 
            this.marriageDate.Location = new System.Drawing.Point(105, 74);
            this.marriageDate.Name = "marriageDate";
            this.marriageDate.Size = new System.Drawing.Size(100, 20);
            this.marriageDate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddMarriage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 137);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.marriageDate);
            this.Controls.Add(this.wife);
            this.Controls.Add(this.husband);
            this.Controls.Add(this.marriageId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddMarriage";
            this.Text = "DodajMalzenstwo";
            this.Load += new System.EventHandler(this.AddMarriage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox marriageId;
        private System.Windows.Forms.TextBox husband;
        private System.Windows.Forms.TextBox wife;
        private System.Windows.Forms.TextBox marriageDate;
        private System.Windows.Forms.Button button1;
    }
}
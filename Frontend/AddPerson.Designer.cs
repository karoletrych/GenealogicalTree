namespace Frontend
{
    partial class AddPerson
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
            this.bAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.forenames = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.mother = new System.Windows.Forms.TextBox();
            this.father = new System.Windows.Forms.TextBox();
            this.born = new System.Windows.Forms.TextBox();
            this.died = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(82, 175);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(75, 23);
            this.bAdd.TabIndex = 0;
            this.bAdd.Text = "Dodaj";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "id";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "imiona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "nazwisko";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "płeć";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "id matki";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "id ojca";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "urodzony";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "zmarły";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(82, 9);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 9;
            this.id.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // forenames
            // 
            this.forenames.Location = new System.Drawing.Point(82, 28);
            this.forenames.Name = "forenames";
            this.forenames.Size = new System.Drawing.Size(100, 20);
            this.forenames.TabIndex = 10;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(82, 45);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 20);
            this.surname.TabIndex = 11;
            // 
            // sex
            // 
            this.sex.Location = new System.Drawing.Point(82, 66);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(100, 20);
            this.sex.TabIndex = 12;
            // 
            // mother
            // 
            this.mother.Location = new System.Drawing.Point(82, 86);
            this.mother.Name = "mother";
            this.mother.Size = new System.Drawing.Size(100, 20);
            this.mother.TabIndex = 13;
            // 
            // father
            // 
            this.father.Location = new System.Drawing.Point(82, 107);
            this.father.Name = "father";
            this.father.Size = new System.Drawing.Size(100, 20);
            this.father.TabIndex = 14;
            // 
            // born
            // 
            this.born.Location = new System.Drawing.Point(82, 128);
            this.born.Name = "born";
            this.born.Size = new System.Drawing.Size(100, 20);
            this.born.TabIndex = 15;
            // 
            // died
            // 
            this.died.Location = new System.Drawing.Point(82, 149);
            this.died.Name = "died";
            this.died.Size = new System.Drawing.Size(100, 20);
            this.died.TabIndex = 16;
            // 
            // AddPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 207);
            this.Controls.Add(this.died);
            this.Controls.Add(this.born);
            this.Controls.Add(this.father);
            this.Controls.Add(this.mother);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.forenames);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAdd);
            this.Name = "AddPerson";
            this.Text = "DodajOsobe";
            this.Load += new System.EventHandler(this.AddPerson_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox forenames;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox mother;
        private System.Windows.Forms.TextBox father;
        private System.Windows.Forms.TextBox born;
        private System.Windows.Forms.TextBox died;
    }
}
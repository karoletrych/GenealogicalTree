namespace Frontend
{
    partial class Main
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
            this.lbPersons = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddPerson = new System.Windows.Forms.Button();
            this.bDeletePerson = new System.Windows.Forms.Button();
            this.bSavePerson = new System.Windows.Forms.Button();
            this.lDetails = new System.Windows.Forms.Label();
            this.lMarriages = new System.Windows.Forms.Label();
            this.bAddMarriage = new System.Windows.Forms.Button();
            this.bDeleteMarriage = new System.Windows.Forms.Button();
            this.dgMarriages = new System.Windows.Forms.DataGridView();
            this.tbDetails = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarriages)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPersons
            // 
            this.lbPersons.FormattingEnabled = true;
            this.lbPersons.Location = new System.Drawing.Point(23, 32);
            this.lbPersons.Name = "lbPersons";
            this.lbPersons.Size = new System.Drawing.Size(149, 407);
            this.lbPersons.TabIndex = 0;
            this.lbPersons.SelectedIndexChanged += new System.EventHandler(this.lbPersons_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Osoby:";
            // 
            // bAddPerson
            // 
            this.bAddPerson.Location = new System.Drawing.Point(23, 453);
            this.bAddPerson.Name = "bAddPerson";
            this.bAddPerson.Size = new System.Drawing.Size(46, 23);
            this.bAddPerson.TabIndex = 5;
            this.bAddPerson.Text = "Dodaj";
            this.bAddPerson.UseVisualStyleBackColor = true;
            this.bAddPerson.Click += new System.EventHandler(this.bAddPerson_Click);
            // 
            // bDeletePerson
            // 
            this.bDeletePerson.Location = new System.Drawing.Point(75, 453);
            this.bDeletePerson.Name = "bDeletePerson";
            this.bDeletePerson.Size = new System.Drawing.Size(47, 23);
            this.bDeletePerson.TabIndex = 6;
            this.bDeletePerson.Text = "Usun";
            this.bDeletePerson.UseVisualStyleBackColor = true;
            this.bDeletePerson.Click += new System.EventHandler(this.bDeletePerson_Click);
            // 
            // bSavePerson
            // 
            this.bSavePerson.Location = new System.Drawing.Point(128, 453);
            this.bSavePerson.Name = "bSavePerson";
            this.bSavePerson.Size = new System.Drawing.Size(56, 23);
            this.bSavePerson.TabIndex = 7;
            this.bSavePerson.Text = "Nadpisz";
            this.bSavePerson.UseVisualStyleBackColor = true;
            this.bSavePerson.Click += new System.EventHandler(this.bSavePerson_Click);
            // 
            // lDetails
            // 
            this.lDetails.AutoSize = true;
            this.lDetails.Location = new System.Drawing.Point(202, 15);
            this.lDetails.Name = "lDetails";
            this.lDetails.Size = new System.Drawing.Size(55, 13);
            this.lDetails.TabIndex = 8;
            this.lDetails.Text = "Szczegoly";
            // 
            // lMarriages
            // 
            this.lMarriages.AutoSize = true;
            this.lMarriages.Location = new System.Drawing.Point(199, 327);
            this.lMarriages.Name = "lMarriages";
            this.lMarriages.Size = new System.Drawing.Size(63, 13);
            this.lMarriages.TabIndex = 9;
            this.lMarriages.Text = "Malzenstwa";
            // 
            // bAddMarriage
            // 
            this.bAddMarriage.Location = new System.Drawing.Point(201, 453);
            this.bAddMarriage.Name = "bAddMarriage";
            this.bAddMarriage.Size = new System.Drawing.Size(75, 23);
            this.bAddMarriage.TabIndex = 10;
            this.bAddMarriage.Text = "Dodaj";
            this.bAddMarriage.UseVisualStyleBackColor = true;
            this.bAddMarriage.Click += new System.EventHandler(this.bAddMarriage_Click);
            // 
            // bDeleteMarriage
            // 
            this.bDeleteMarriage.Location = new System.Drawing.Point(282, 453);
            this.bDeleteMarriage.Name = "bDeleteMarriage";
            this.bDeleteMarriage.Size = new System.Drawing.Size(75, 23);
            this.bDeleteMarriage.TabIndex = 11;
            this.bDeleteMarriage.Text = "Usun";
            this.bDeleteMarriage.UseVisualStyleBackColor = true;
            this.bDeleteMarriage.Click += new System.EventHandler(this.bDeleteMarriage_Click);
            // 
            // dgMarriages
            // 
            this.dgMarriages.AllowUserToAddRows = false;
            this.dgMarriages.AllowUserToDeleteRows = false;
            this.dgMarriages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMarriages.Location = new System.Drawing.Point(201, 344);
            this.dgMarriages.Name = "dgMarriages";
            this.dgMarriages.Size = new System.Drawing.Size(427, 103);
            this.dgMarriages.TabIndex = 14;
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(205, 32);
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(423, 279);
            this.tbDetails.TabIndex = 15;
            this.tbDetails.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 516);
            this.Controls.Add(this.tbDetails);
            this.Controls.Add(this.dgMarriages);
            this.Controls.Add(this.bDeleteMarriage);
            this.Controls.Add(this.bAddMarriage);
            this.Controls.Add(this.lMarriages);
            this.Controls.Add(this.lDetails);
            this.Controls.Add(this.bSavePerson);
            this.Controls.Add(this.bDeletePerson);
            this.Controls.Add(this.bAddPerson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPersons);
            this.Name = "Main";
            this.Text = "DrzewoGenealogiczne";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMarriages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPersons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddPerson;
        private System.Windows.Forms.Button bDeletePerson;
        private System.Windows.Forms.Button bSavePerson;
        private System.Windows.Forms.Label lDetails;
        private System.Windows.Forms.Label lMarriages;
        private System.Windows.Forms.Button bAddMarriage;
        private System.Windows.Forms.Button bDeleteMarriage;
        private System.Windows.Forms.DataGridView dgMarriages;
        private System.Windows.Forms.RichTextBox tbDetails;
    }
}


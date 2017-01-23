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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bAddPerson = new System.Windows.Forms.Button();
            this.bDeletePerson = new System.Windows.Forms.Button();
            this.bSavePerson = new System.Windows.Forms.Button();
            this.lDetails = new System.Windows.Forms.Label();
            this.lMarriages = new System.Windows.Forms.Label();
            this.bAddMarriage = new System.Windows.Forms.Button();
            this.bDeleteMarriage = new System.Windows.Forms.Button();
            this.dgMarriages = new System.Windows.Forms.DataGridView();
            this.tbDetails = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAddFamily = new System.Windows.Forms.Button();
            this.tbFamilyName = new System.Windows.Forms.TextBox();
            this.Nazwa = new System.Windows.Forms.Label();
            this.bDeleteFamily = new System.Windows.Forms.Button();
            this.lvFamilies = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPersons = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescendants = new System.Windows.Forms.TextBox();
            this.Pokolenia = new System.Windows.Forms.Label();
            this.generations = new System.Windows.Forms.NumericUpDown();
            this.search = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMarriages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generations)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMarriages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgMarriages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMarriages.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgMarriages.Location = new System.Drawing.Point(201, 344);
            this.dgMarriages.Name = "dgMarriages";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMarriages.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgMarriages.Size = new System.Drawing.Size(729, 103);
            this.dgMarriages.TabIndex = 14;
            // 
            // tbDetails
            // 
            this.tbDetails.Location = new System.Drawing.Point(205, 32);
            this.tbDetails.Name = "tbDetails";
            this.tbDetails.Size = new System.Drawing.Size(367, 279);
            this.tbDetails.TabIndex = 15;
            this.tbDetails.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Rodziny";
            // 
            // bAddFamily
            // 
            this.bAddFamily.Location = new System.Drawing.Point(128, 156);
            this.bAddFamily.Name = "bAddFamily";
            this.bAddFamily.Size = new System.Drawing.Size(56, 23);
            this.bAddFamily.TabIndex = 18;
            this.bAddFamily.Text = "Dodaj";
            this.bAddFamily.UseVisualStyleBackColor = true;
            this.bAddFamily.Click += new System.EventHandler(this.bAddFamily_Click);
            // 
            // tbFamilyName
            // 
            this.tbFamilyName.Location = new System.Drawing.Point(59, 156);
            this.tbFamilyName.Name = "tbFamilyName";
            this.tbFamilyName.Size = new System.Drawing.Size(63, 20);
            this.tbFamilyName.TabIndex = 19;
            // 
            // Nazwa
            // 
            this.Nazwa.AutoSize = true;
            this.Nazwa.Location = new System.Drawing.Point(13, 156);
            this.Nazwa.Name = "Nazwa";
            this.Nazwa.Size = new System.Drawing.Size(40, 13);
            this.Nazwa.TabIndex = 20;
            this.Nazwa.Text = "Nazwa";
            // 
            // bDeleteFamily
            // 
            this.bDeleteFamily.Location = new System.Drawing.Point(128, 182);
            this.bDeleteFamily.Name = "bDeleteFamily";
            this.bDeleteFamily.Size = new System.Drawing.Size(56, 23);
            this.bDeleteFamily.TabIndex = 21;
            this.bDeleteFamily.Text = "Usuń";
            this.bDeleteFamily.UseVisualStyleBackColor = true;
            this.bDeleteFamily.Click += new System.EventHandler(this.bDeleteFamily_Click);
            // 
            // lvFamilies
            // 
            this.lvFamilies.Location = new System.Drawing.Point(23, 32);
            this.lvFamilies.Name = "lvFamilies";
            this.lvFamilies.Size = new System.Drawing.Size(149, 118);
            this.lvFamilies.TabIndex = 24;
            this.lvFamilies.UseCompatibleStateImageBehavior = false;
            this.lvFamilies.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Osoby:";
            // 
            // lbPersons
            // 
            this.lbPersons.FormattingEnabled = true;
            this.lbPersons.Location = new System.Drawing.Point(23, 277);
            this.lbPersons.Name = "lbPersons";
            this.lbPersons.Size = new System.Drawing.Size(161, 160);
            this.lbPersons.TabIndex = 23;
            this.lbPersons.SelectedIndexChanged += new System.EventHandler(this.lbPersons_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(579, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Potomkowie:";
            // 
            // tbDescendants
            // 
            this.tbDescendants.Location = new System.Drawing.Point(582, 32);
            this.tbDescendants.Multiline = true;
            this.tbDescendants.Name = "tbDescendants";
            this.tbDescendants.Size = new System.Drawing.Size(348, 279);
            this.tbDescendants.TabIndex = 26;
            // 
            // Pokolenia
            // 
            this.Pokolenia.AutoSize = true;
            this.Pokolenia.Location = new System.Drawing.Point(673, 13);
            this.Pokolenia.Name = "Pokolenia";
            this.Pokolenia.Size = new System.Drawing.Size(79, 13);
            this.Pokolenia.TabIndex = 27;
            this.Pokolenia.Text = "Liczba pokoleń";
            // 
            // generations
            // 
            this.generations.Location = new System.Drawing.Point(758, 8);
            this.generations.Name = "generations";
            this.generations.Size = new System.Drawing.Size(120, 20);
            this.generations.TabIndex = 28;
            this.generations.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.generations.ValueChanged += new System.EventHandler(this.generations_ValueChanged);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(84, 230);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 20);
            this.search.TabIndex = 29;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Wyszukaj:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 516);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.search);
            this.Controls.Add(this.generations);
            this.Controls.Add(this.Pokolenia);
            this.Controls.Add(this.tbDescendants);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lvFamilies);
            this.Controls.Add(this.lbPersons);
            this.Controls.Add(this.bDeleteFamily);
            this.Controls.Add(this.Nazwa);
            this.Controls.Add(this.tbFamilyName);
            this.Controls.Add(this.bAddFamily);
            this.Controls.Add(this.label2);
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
            this.Name = "Main";
            this.Text = "DrzewoGenealogiczne";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgMarriages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAddPerson;
        private System.Windows.Forms.Button bDeletePerson;
        private System.Windows.Forms.Button bSavePerson;
        private System.Windows.Forms.Label lDetails;
        private System.Windows.Forms.Label lMarriages;
        private System.Windows.Forms.Button bAddMarriage;
        private System.Windows.Forms.Button bDeleteMarriage;
        private System.Windows.Forms.DataGridView dgMarriages;
        private System.Windows.Forms.RichTextBox tbDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAddFamily;
        private System.Windows.Forms.TextBox tbFamilyName;
        private System.Windows.Forms.Label Nazwa;
        private System.Windows.Forms.Button bDeleteFamily;
        private System.Windows.Forms.ListView lvFamilies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbPersons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescendants;
        private System.Windows.Forms.Label Pokolenia;
        private System.Windows.Forms.NumericUpDown generations;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label4;
    }
}


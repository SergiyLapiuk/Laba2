
namespace Xml_Lab
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
            this.checkBoxPIP = new System.Windows.Forms.CheckBox();
            this.checkBoxFaculty = new System.Windows.Forms.CheckBox();
            this.checkBoxCathedra = new System.Windows.Forms.CheckBox();
            this.checkBoxTimeOfEntry = new System.Windows.Forms.CheckBox();
            this.checkBoxSex = new System.Windows.Forms.CheckBox();
            this.checkBoxID = new System.Windows.Forms.CheckBox();
            this.comboBoxMember = new System.Windows.Forms.ComboBox();
            this.comboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.comboBoxCathedra = new System.Windows.Forms.ComboBox();
            this.comboBoxTImeOfEntry = new System.Windows.Forms.ComboBox();
            this.comboBoxID = new System.Windows.Forms.ComboBox();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.linq = new System.Windows.Forms.RadioButton();
            this.dom = new System.Windows.Forms.RadioButton();
            this.sax = new System.Windows.Forms.RadioButton();
            this.search = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.transform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxPIP
            // 
            this.checkBoxPIP.AutoSize = true;
            this.checkBoxPIP.Location = new System.Drawing.Point(12, 62);
            this.checkBoxPIP.Name = "checkBoxPIP";
            this.checkBoxPIP.Size = new System.Drawing.Size(57, 24);
            this.checkBoxPIP.TabIndex = 0;
            this.checkBoxPIP.Text = "ПІП";
            this.checkBoxPIP.UseVisualStyleBackColor = true;
            this.checkBoxPIP.Click += new System.EventHandler(this.checkBoxPIP_Click);
            // 
            // checkBoxFaculty
            // 
            this.checkBoxFaculty.AutoSize = true;
            this.checkBoxFaculty.Location = new System.Drawing.Point(12, 106);
            this.checkBoxFaculty.Name = "checkBoxFaculty";
            this.checkBoxFaculty.Size = new System.Drawing.Size(100, 24);
            this.checkBoxFaculty.TabIndex = 1;
            this.checkBoxFaculty.Text = "Факультет";
            this.checkBoxFaculty.UseVisualStyleBackColor = true;
            this.checkBoxFaculty.Click += new System.EventHandler(this.checkBoxFaculty_Click);
            // 
            // checkBoxCathedra
            // 
            this.checkBoxCathedra.AutoSize = true;
            this.checkBoxCathedra.Location = new System.Drawing.Point(12, 152);
            this.checkBoxCathedra.Name = "checkBoxCathedra";
            this.checkBoxCathedra.Size = new System.Drawing.Size(91, 24);
            this.checkBoxCathedra.TabIndex = 2;
            this.checkBoxCathedra.Text = "Кафедра";
            this.checkBoxCathedra.UseVisualStyleBackColor = true;
            this.checkBoxCathedra.Click += new System.EventHandler(this.checkBoxCathedra_Click);
            // 
            // checkBoxTimeOfEntry
            // 
            this.checkBoxTimeOfEntry.AutoSize = true;
            this.checkBoxTimeOfEntry.Location = new System.Drawing.Point(12, 198);
            this.checkBoxTimeOfEntry.Name = "checkBoxTimeOfEntry";
            this.checkBoxTimeOfEntry.Size = new System.Drawing.Size(155, 24);
            this.checkBoxTimeOfEntry.TabIndex = 3;
            this.checkBoxTimeOfEntry.Text = "Дата народження";
            this.checkBoxTimeOfEntry.UseVisualStyleBackColor = true;
            this.checkBoxTimeOfEntry.Click += new System.EventHandler(this.checkBoxTimeOfEntry_Click);
            // 
            // checkBoxSex
            // 
            this.checkBoxSex.AutoSize = true;
            this.checkBoxSex.Location = new System.Drawing.Point(12, 247);
            this.checkBoxSex.Name = "checkBoxSex";
            this.checkBoxSex.Size = new System.Drawing.Size(68, 24);
            this.checkBoxSex.TabIndex = 4;
            this.checkBoxSex.Text = "Стать";
            this.checkBoxSex.UseVisualStyleBackColor = true;
            this.checkBoxSex.Click += new System.EventHandler(this.checkBoxSex_Click);
            // 
            // checkBoxID
            // 
            this.checkBoxID.AutoSize = true;
            this.checkBoxID.Location = new System.Drawing.Point(12, 297);
            this.checkBoxID.Name = "checkBoxID";
            this.checkBoxID.Size = new System.Drawing.Size(46, 24);
            this.checkBoxID.TabIndex = 5;
            this.checkBoxID.Text = "ID";
            this.checkBoxID.UseVisualStyleBackColor = true;
            this.checkBoxID.Click += new System.EventHandler(this.checkBoxID_Click);
            // 
            // comboBoxMember
            // 
            this.comboBoxMember.FormattingEnabled = true;
            this.comboBoxMember.Location = new System.Drawing.Point(222, 58);
            this.comboBoxMember.Name = "comboBoxMember";
            this.comboBoxMember.Size = new System.Drawing.Size(335, 28);
            this.comboBoxMember.TabIndex = 6;
            // 
            // comboBoxFaculty
            // 
            this.comboBoxFaculty.FormattingEnabled = true;
            this.comboBoxFaculty.Location = new System.Drawing.Point(222, 102);
            this.comboBoxFaculty.Name = "comboBoxFaculty";
            this.comboBoxFaculty.Size = new System.Drawing.Size(335, 28);
            this.comboBoxFaculty.TabIndex = 7;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Location = new System.Drawing.Point(222, 243);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(335, 28);
            this.comboBoxSex.TabIndex = 8;
            // 
            // comboBoxCathedra
            // 
            this.comboBoxCathedra.FormattingEnabled = true;
            this.comboBoxCathedra.Location = new System.Drawing.Point(222, 148);
            this.comboBoxCathedra.Name = "comboBoxCathedra";
            this.comboBoxCathedra.Size = new System.Drawing.Size(335, 28);
            this.comboBoxCathedra.TabIndex = 9;
            // 
            // comboBoxTImeOfEntry
            // 
            this.comboBoxTImeOfEntry.FormattingEnabled = true;
            this.comboBoxTImeOfEntry.Location = new System.Drawing.Point(222, 194);
            this.comboBoxTImeOfEntry.Name = "comboBoxTImeOfEntry";
            this.comboBoxTImeOfEntry.Size = new System.Drawing.Size(335, 28);
            this.comboBoxTImeOfEntry.TabIndex = 10;
            // 
            // comboBoxID
            // 
            this.comboBoxID.FormattingEnabled = true;
            this.comboBoxID.Location = new System.Drawing.Point(222, 295);
            this.comboBoxID.Name = "comboBoxID";
            this.comboBoxID.Size = new System.Drawing.Size(335, 28);
            this.comboBoxID.TabIndex = 11;
            // 
            // rtbResult
            // 
            this.rtbResult.BackColor = System.Drawing.Color.Aquamarine;
            this.rtbResult.Location = new System.Drawing.Point(615, 37);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(550, 390);
            this.rtbResult.TabIndex = 12;
            this.rtbResult.Text = "";
            // 
            // linq
            // 
            this.linq.AutoSize = true;
            this.linq.Location = new System.Drawing.Point(12, 403);
            this.linq.Name = "linq";
            this.linq.Size = new System.Drawing.Size(63, 24);
            this.linq.TabIndex = 13;
            this.linq.TabStop = true;
            this.linq.Text = "LINQ";
            this.linq.UseVisualStyleBackColor = true;
            // 
            // dom
            // 
            this.dom.AutoSize = true;
            this.dom.Location = new System.Drawing.Point(93, 403);
            this.dom.Name = "dom";
            this.dom.Size = new System.Drawing.Size(65, 24);
            this.dom.TabIndex = 14;
            this.dom.TabStop = true;
            this.dom.Text = "DOM";
            this.dom.UseVisualStyleBackColor = true;
            // 
            // sax
            // 
            this.sax.AutoSize = true;
            this.sax.Location = new System.Drawing.Point(179, 403);
            this.sax.Name = "sax";
            this.sax.Size = new System.Drawing.Size(57, 24);
            this.sax.TabIndex = 15;
            this.sax.TabStop = true;
            this.sax.Text = "SAX";
            this.sax.UseVisualStyleBackColor = true;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.Highlight;
            this.search.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.search.ForeColor = System.Drawing.Color.Aqua;
            this.search.Location = new System.Drawing.Point(12, 472);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(214, 88);
            this.search.TabIndex = 16;
            this.search.Text = "Пошук";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Highlight;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clear.ForeColor = System.Drawing.Color.Aqua;
            this.clear.Location = new System.Drawing.Point(248, 472);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(214, 88);
            this.clear.TabIndex = 17;
            this.clear.Text = "Очистити";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // transform
            // 
            this.transform.BackColor = System.Drawing.SystemColors.Highlight;
            this.transform.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.transform.ForeColor = System.Drawing.Color.Aqua;
            this.transform.Location = new System.Drawing.Point(929, 472);
            this.transform.Name = "transform";
            this.transform.Size = new System.Drawing.Size(236, 88);
            this.transform.TabIndex = 18;
            this.transform.Text = "Трансформувати в HTML ";
            this.transform.UseVisualStyleBackColor = false;
            this.transform.Click += new System.EventHandler(this.transform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 343);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Аналізатор:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "Фільтр:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1184, 589);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transform);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.search);
            this.Controls.Add(this.sax);
            this.Controls.Add(this.dom);
            this.Controls.Add(this.linq);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.comboBoxID);
            this.Controls.Add(this.comboBoxTImeOfEntry);
            this.Controls.Add(this.comboBoxCathedra);
            this.Controls.Add(this.comboBoxSex);
            this.Controls.Add(this.comboBoxFaculty);
            this.Controls.Add(this.comboBoxMember);
            this.Controls.Add(this.checkBoxID);
            this.Controls.Add(this.checkBoxSex);
            this.Controls.Add(this.checkBoxTimeOfEntry);
            this.Controls.Add(this.checkBoxCathedra);
            this.Controls.Add(this.checkBoxFaculty);
            this.Controls.Add(this.checkBoxPIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxPIP;
        private System.Windows.Forms.CheckBox checkBoxFaculty;
        private System.Windows.Forms.CheckBox checkBoxCathedra;
        private System.Windows.Forms.CheckBox checkBoxTimeOfEntry;
        private System.Windows.Forms.CheckBox checkBoxSex;
        private System.Windows.Forms.CheckBox checkBoxID;
        private System.Windows.Forms.ComboBox comboBoxMember;
        private System.Windows.Forms.ComboBox comboBoxFaculty;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.ComboBox comboBoxCathedra;
        private System.Windows.Forms.ComboBox comboBoxTImeOfEntry;
        private System.Windows.Forms.ComboBox comboBoxID;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.RadioButton linq;
        private System.Windows.Forms.RadioButton dom;
        private System.Windows.Forms.RadioButton sax;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button transform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}


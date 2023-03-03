namespace SLVP_Aflevering1
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
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbDelPos = new System.Windows.Forms.TextBox();
            this.btnDelPos = new System.Windows.Forms.Button();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lblDelPos = new System.Windows.Forms.Label();
            this.lblArray = new System.Windows.Forms.Label();
            this.rtbArray = new System.Windows.Forms.RichTextBox();
            this.btnArrayDel = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnRevSort = new System.Windows.Forms.Button();
            this.rtbList = new System.Windows.Forms.RichTextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.lblList = new System.Windows.Forms.Label();
            this.btnAutoSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(105, 34);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(100, 20);
            this.tbAdd.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(105, 61);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add name";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbDelPos
            // 
            this.tbDelPos.Location = new System.Drawing.Point(105, 130);
            this.tbDelPos.Name = "tbDelPos";
            this.tbDelPos.Size = new System.Drawing.Size(100, 20);
            this.tbDelPos.TabIndex = 1;
            // 
            // btnDelPos
            // 
            this.btnDelPos.Location = new System.Drawing.Point(105, 156);
            this.btnDelPos.Name = "btnDelPos";
            this.btnDelPos.Size = new System.Drawing.Size(85, 23);
            this.btnDelPos.TabIndex = 3;
            this.btnDelPos.Text = "Delete position";
            this.btnDelPos.UseVisualStyleBackColor = true;
            this.btnDelPos.Click += new System.EventHandler(this.btnDelPos_Click);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(66, 34);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(38, 13);
            this.lblAdd.TabIndex = 7;
            this.lblAdd.Text = "Name:";
            // 
            // lblDelPos
            // 
            this.lblDelPos.AutoSize = true;
            this.lblDelPos.Location = new System.Drawing.Point(55, 133);
            this.lblDelPos.Name = "lblDelPos";
            this.lblDelPos.Size = new System.Drawing.Size(47, 13);
            this.lblDelPos.TabIndex = 8;
            this.lblDelPos.Text = "Position:";
            // 
            // lblArray
            // 
            this.lblArray.AutoSize = true;
            this.lblArray.Location = new System.Drawing.Point(258, 33);
            this.lblArray.Name = "lblArray";
            this.lblArray.Size = new System.Drawing.Size(42, 13);
            this.lblArray.TabIndex = 9;
            this.lblArray.Text = "Navne:";
            // 
            // rtbArray
            // 
            this.rtbArray.Location = new System.Drawing.Point(261, 49);
            this.rtbArray.Name = "rtbArray";
            this.rtbArray.ReadOnly = true;
            this.rtbArray.Size = new System.Drawing.Size(227, 276);
            this.rtbArray.TabIndex = 11;
            this.rtbArray.Text = "The data in this box is stored in an array.";
            this.rtbArray.SelectionChanged += new System.EventHandler(this.rtbArray_SelectionChanged);
            // 
            // btnArrayDel
            // 
            this.btnArrayDel.Location = new System.Drawing.Point(494, 49);
            this.btnArrayDel.Name = "btnArrayDel";
            this.btnArrayDel.Size = new System.Drawing.Size(96, 23);
            this.btnArrayDel.TabIndex = 12;
            this.btnArrayDel.Text = "Delete selected";
            this.btnArrayDel.UseVisualStyleBackColor = true;
            this.btnArrayDel.Click += new System.EventHandler(this.btnArrayDel_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(494, 94);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(96, 23);
            this.btnSort.TabIndex = 13;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnRevSort
            // 
            this.btnRevSort.Location = new System.Drawing.Point(494, 123);
            this.btnRevSort.Name = "btnRevSort";
            this.btnRevSort.Size = new System.Drawing.Size(96, 23);
            this.btnRevSort.TabIndex = 14;
            this.btnRevSort.Text = "Sort reversed";
            this.btnRevSort.UseVisualStyleBackColor = true;
            this.btnRevSort.Click += new System.EventHandler(this.btnRevSort_Click);
            // 
            // rtbList
            // 
            this.rtbList.Location = new System.Drawing.Point(596, 49);
            this.rtbList.Name = "rtbList";
            this.rtbList.ReadOnly = true;
            this.rtbList.Size = new System.Drawing.Size(227, 276);
            this.rtbList.TabIndex = 15;
            this.rtbList.Text = "The data in this box is stored in a list.";
            this.rtbList.SelectionChanged += new System.EventHandler(this.rtbList_SelectionChanged);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(332, 424);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(42, 13);
            this.lblOutput.TabIndex = 16;
            this.lblOutput.Text = "Output:";
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput.Location = new System.Drawing.Point(380, 422);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(291, 17);
            this.tbOutput.TabIndex = 17;
            this.tbOutput.Text = "Shows if last operation was a success or an error.";
            this.tbOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(593, 33);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(42, 13);
            this.lblList.TabIndex = 18;
            this.lblList.Text = "Navne:";
            // 
            // btnAutoSort
            // 
            this.btnAutoSort.Location = new System.Drawing.Point(494, 152);
            this.btnAutoSort.Name = "btnAutoSort";
            this.btnAutoSort.Size = new System.Drawing.Size(96, 27);
            this.btnAutoSort.TabIndex = 19;
            this.btnAutoSort.Text = "Autosort: yes";
            this.btnAutoSort.UseVisualStyleBackColor = true;
            this.btnAutoSort.Click += new System.EventHandler(this.btnAutoSort_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 508);
            this.Controls.Add(this.btnAutoSort);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.rtbList);
            this.Controls.Add(this.btnRevSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnArrayDel);
            this.Controls.Add(this.rtbArray);
            this.Controls.Add(this.lblArray);
            this.Controls.Add(this.lblDelPos);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.btnDelPos);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbDelPos);
            this.Controls.Add(this.tbAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbDelPos;
        private System.Windows.Forms.Button btnDelPos;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblDelPos;
        private System.Windows.Forms.Label lblArray;
        private System.Windows.Forms.RichTextBox rtbArray;
        private System.Windows.Forms.Button btnArrayDel;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnRevSort;
        private System.Windows.Forms.RichTextBox rtbList;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Button btnAutoSort;
    }
}


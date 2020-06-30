namespace Crud_With_ListBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxSports = new System.Windows.Forms.ListBox();
            this.textBoxItems = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonInsertItem = new System.Windows.Forms.Button();
            this.buttonUpdateItem = new System.Windows.Forms.Button();
            this.buttonDeleteItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "CRUD WITH LISTBOX";
            // 
            // listBoxSports
            // 
            this.listBoxSports.FormattingEnabled = true;
            this.listBoxSports.Location = new System.Drawing.Point(24, 66);
            this.listBoxSports.Name = "listBoxSports";
            this.listBoxSports.Size = new System.Drawing.Size(127, 212);
            this.listBoxSports.TabIndex = 1;
            this.listBoxSports.SelectedIndexChanged += new System.EventHandler(this.listBoxSports_SelectedIndexChanged);
            // 
            // textBoxItems
            // 
            this.textBoxItems.Location = new System.Drawing.Point(172, 92);
            this.textBoxItems.Name = "textBoxItems";
            this.textBoxItems.Size = new System.Drawing.Size(163, 20);
            this.textBoxItems.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Items:";
            // 
            // buttonInsertItem
            // 
            this.buttonInsertItem.Location = new System.Drawing.Point(200, 135);
            this.buttonInsertItem.Name = "buttonInsertItem";
            this.buttonInsertItem.Size = new System.Drawing.Size(102, 32);
            this.buttonInsertItem.TabIndex = 4;
            this.buttonInsertItem.Text = "Insert Item";
            this.buttonInsertItem.UseVisualStyleBackColor = true;
            this.buttonInsertItem.Click += new System.EventHandler(this.buttonInsertItem_Click);
            // 
            // buttonUpdateItem
            // 
            this.buttonUpdateItem.Location = new System.Drawing.Point(200, 189);
            this.buttonUpdateItem.Name = "buttonUpdateItem";
            this.buttonUpdateItem.Size = new System.Drawing.Size(102, 32);
            this.buttonUpdateItem.TabIndex = 4;
            this.buttonUpdateItem.Text = "Update Item";
            this.buttonUpdateItem.UseVisualStyleBackColor = true;
            this.buttonUpdateItem.Click += new System.EventHandler(this.buttonUpdateItem_Click);
            // 
            // buttonDeleteItem
            // 
            this.buttonDeleteItem.Location = new System.Drawing.Point(200, 243);
            this.buttonDeleteItem.Name = "buttonDeleteItem";
            this.buttonDeleteItem.Size = new System.Drawing.Size(102, 32);
            this.buttonDeleteItem.TabIndex = 4;
            this.buttonDeleteItem.Text = "Delete Item";
            this.buttonDeleteItem.UseVisualStyleBackColor = true;
            this.buttonDeleteItem.Click += new System.EventHandler(this.buttonDeleteItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 315);
            this.Controls.Add(this.buttonDeleteItem);
            this.Controls.Add(this.buttonUpdateItem);
            this.Controls.Add(this.buttonInsertItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxItems);
            this.Controls.Add(this.listBoxSports);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSports;
        private System.Windows.Forms.TextBox textBoxItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInsertItem;
        private System.Windows.Forms.Button buttonUpdateItem;
        private System.Windows.Forms.Button buttonDeleteItem;
    }
}


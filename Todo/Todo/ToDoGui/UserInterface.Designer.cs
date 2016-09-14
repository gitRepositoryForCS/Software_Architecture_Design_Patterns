namespace ToDoGui
{
    partial class UserInterface
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
            this.uxEnterDescription = new System.Windows.Forms.TextBox();
            this.uxLableEnter = new System.Windows.Forms.Label();
            this.uxLableDescription = new System.Windows.Forms.Label();
            this.uxEntryList = new System.Windows.Forms.ListView();
            this.uxLableShowActive = new System.Windows.Forms.Label();
            this.uxChooseView = new System.Windows.Forms.ComboBox();
            this.uxClearCompleted = new System.Windows.Forms.Button();
            this.uxLoad = new System.Windows.Forms.Button();
            this.uxSave = new System.Windows.Forms.Button();
            this.uxOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // uxEnterDescription
            // 
            this.uxEnterDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxEnterDescription.Location = new System.Drawing.Point(7, 66);
            this.uxEnterDescription.Multiline = true;
            this.uxEnterDescription.Name = "uxEnterDescription";
            this.uxEnterDescription.Size = new System.Drawing.Size(857, 51);
            this.uxEnterDescription.TabIndex = 0;
            this.uxEnterDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            // 
            // uxLableEnter
            // 
            this.uxLableEnter.AutoSize = true;
            this.uxLableEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLableEnter.Location = new System.Drawing.Point(1, 10);
            this.uxLableEnter.Name = "uxLableEnter";
            this.uxLableEnter.Size = new System.Drawing.Size(339, 31);
            this.uxLableEnter.TabIndex = 1;
            this.uxLableEnter.Text = "Enter a to-do task below:";
            // 
            // uxLableDescription
            // 
            this.uxLableDescription.AutoSize = true;
            this.uxLableDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLableDescription.Location = new System.Drawing.Point(1, 120);
            this.uxLableDescription.Name = "uxLableDescription";
            this.uxLableDescription.Size = new System.Drawing.Size(162, 31);
            this.uxLableDescription.TabIndex = 2;
            this.uxLableDescription.Text = "Description";
            // 
            // uxEntryList
            // 
            this.uxEntryList.CheckBoxes = true;
            this.uxEntryList.GridLines = true;
            this.uxEntryList.LabelEdit = true;
            this.uxEntryList.LabelWrap = false;
            this.uxEntryList.Location = new System.Drawing.Point(12, 154);
            this.uxEntryList.Name = "uxEntryList";
            this.uxEntryList.Size = new System.Drawing.Size(852, 372);
            this.uxEntryList.TabIndex = 3;
            this.uxEntryList.UseCompatibleStateImageBehavior = false;
            this.uxEntryList.View = System.Windows.Forms.View.Details;
            this.uxEntryList.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.uxEntryList_AfterLabelEdit);
            this.uxEntryList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.uxEntryList_ItemCheck_1);
            this.uxEntryList.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.uxEntryList_ItemDrag);
            // 
            // uxLableShowActive
            // 
            this.uxLableShowActive.AutoSize = true;
            this.uxLableShowActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLableShowActive.Location = new System.Drawing.Point(12, 599);
            this.uxLableShowActive.Name = "uxLableShowActive";
            this.uxLableShowActive.Size = new System.Drawing.Size(162, 31);
            this.uxLableShowActive.TabIndex = 4;
            this.uxLableShowActive.Text = "Description";
            // 
            // uxChooseView
            // 
            this.uxChooseView.FormattingEnabled = true;
            this.uxChooseView.Items.AddRange(new object[] {
            "All entries",
            "Active entries",
            "Completed entries"});
            this.uxChooseView.Location = new System.Drawing.Point(7, 556);
            this.uxChooseView.Name = "uxChooseView";
            this.uxChooseView.Size = new System.Drawing.Size(295, 33);
            this.uxChooseView.TabIndex = 5;
            this.uxChooseView.SelectedIndexChanged += new System.EventHandler(this.uxChooseView_SelectedIndexChanged);
            // 
            // uxClearCompleted
            // 
            this.uxClearCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxClearCompleted.Location = new System.Drawing.Point(320, 548);
            this.uxClearCompleted.Name = "uxClearCompleted";
            this.uxClearCompleted.Size = new System.Drawing.Size(250, 47);
            this.uxClearCompleted.TabIndex = 6;
            this.uxClearCompleted.Text = "Clear Completed";
            this.uxClearCompleted.UseVisualStyleBackColor = true;
            this.uxClearCompleted.Click += new System.EventHandler(this.uxClearCompleted_Click);
            // 
            // uxLoad
            // 
            this.uxLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxLoad.Location = new System.Drawing.Point(576, 2);
            this.uxLoad.Name = "uxLoad";
            this.uxLoad.Size = new System.Drawing.Size(288, 47);
            this.uxLoad.TabIndex = 7;
            this.uxLoad.Text = "LoadExistingEntries";
            this.uxLoad.UseVisualStyleBackColor = true;
            this.uxLoad.Click += new System.EventHandler(this.uxLoad_Click);
            // 
            // uxSave
            // 
            this.uxSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSave.Location = new System.Drawing.Point(576, 548);
            this.uxSave.Name = "uxSave";
            this.uxSave.Size = new System.Drawing.Size(288, 47);
            this.uxSave.TabIndex = 8;
            this.uxSave.Text = "SaveCurrentEntries";
            this.uxSave.UseVisualStyleBackColor = true;
            this.uxSave.Click += new System.EventHandler(this.uxSave_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 641);
            this.Controls.Add(this.uxSave);
            this.Controls.Add(this.uxLoad);
            this.Controls.Add(this.uxClearCompleted);
            this.Controls.Add(this.uxChooseView);
            this.Controls.Add(this.uxLableShowActive);
            this.Controls.Add(this.uxEntryList);
            this.Controls.Add(this.uxLableDescription);
            this.Controls.Add(this.uxLableEnter);
            this.Controls.Add(this.uxEnterDescription);
            this.Name = "UserInterface";
            this.Text = "Todo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxEnterDescription;
        private System.Windows.Forms.Label uxLableEnter;
        private System.Windows.Forms.Label uxLableDescription;
        private System.Windows.Forms.ListView uxEntryList;
        private System.Windows.Forms.Label uxLableShowActive;
        private System.Windows.Forms.ComboBox uxChooseView;
        private System.Windows.Forms.Button uxClearCompleted;
        private System.Windows.Forms.Button uxLoad;
        private System.Windows.Forms.Button uxSave;
        private System.Windows.Forms.OpenFileDialog uxOpenFile;
        private System.Windows.Forms.SaveFileDialog uxSaveFile;
    }
}


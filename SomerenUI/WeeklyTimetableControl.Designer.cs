namespace SomerenUI
{
    partial class WeeklyTimetableControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelWeekDay = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.listBoxWActivities = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labelWeekDay
            // 
            this.labelWeekDay.AutoSize = true;
            this.labelWeekDay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWeekDay.Location = new System.Drawing.Point(58, 34);
            this.labelWeekDay.Name = "labelWeekDay";
            this.labelWeekDay.Size = new System.Drawing.Size(51, 15);
            this.labelWeekDay.TabIndex = 0;
            this.labelWeekDay.Text = "Monday";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDate.Location = new System.Drawing.Point(24, 4);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(85, 19);
            this.labelDate.TabIndex = 1;
            this.labelDate.Text = "22-03-2023";
            // 
            // listBoxWActivities
            // 
            this.listBoxWActivities.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.listBoxWActivities.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxWActivities.FormattingEnabled = true;
            this.listBoxWActivities.HorizontalScrollbar = true;
            this.listBoxWActivities.IntegralHeight = false;
            this.listBoxWActivities.ItemHeight = 17;
            this.listBoxWActivities.Location = new System.Drawing.Point(2, 61);
            this.listBoxWActivities.Name = "listBoxWActivities";
            this.listBoxWActivities.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxWActivities.Size = new System.Drawing.Size(181, 123);
            this.listBoxWActivities.TabIndex = 2;
            // 
            // WeeklyTimetableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.listBoxWActivities);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelWeekDay);
            this.Name = "WeeklyTimetableControl";
            this.Size = new System.Drawing.Size(186, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWeekDay;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ListBox listBoxWActivities;
    }
}

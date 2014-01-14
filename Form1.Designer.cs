namespace IT151PhoneAnsweringSystem
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
            this.components = new System.ComponentModel.Container();
            this.grpIncoming = new System.Windows.Forms.GroupBox();
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtRecentCall = new System.Windows.Forms.TextBox();
            this.lblRecentCall = new System.Windows.Forms.Label();
            this.grpAnswered = new System.Windows.Forms.GroupBox();
            this.btnAnswer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnsweredCall = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.grpIncoming.SuspendLayout();
            this.grpAnswered.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpIncoming
            // 
            this.grpIncoming.Controls.Add(this.btnActivate);
            this.grpIncoming.Controls.Add(this.txtRecentCall);
            this.grpIncoming.Controls.Add(this.lblRecentCall);
            this.grpIncoming.Location = new System.Drawing.Point(12, 12);
            this.grpIncoming.Name = "grpIncoming";
            this.grpIncoming.Size = new System.Drawing.Size(775, 84);
            this.grpIncoming.TabIndex = 0;
            this.grpIncoming.TabStop = false;
            this.grpIncoming.Text = "Incoming Calls";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(598, 39);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(148, 38);
            this.btnActivate.TabIndex = 4;
            this.btnActivate.Text = "A&ctivate System";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // txtRecentCall
            // 
            this.txtRecentCall.Location = new System.Drawing.Point(103, 13);
            this.txtRecentCall.Name = "txtRecentCall";
            this.txtRecentCall.Size = new System.Drawing.Size(643, 20);
            this.txtRecentCall.TabIndex = 1;
            // 
            // lblRecentCall
            // 
            this.lblRecentCall.AutoSize = true;
            this.lblRecentCall.Location = new System.Drawing.Point(6, 16);
            this.lblRecentCall.Name = "lblRecentCall";
            this.lblRecentCall.Size = new System.Drawing.Size(91, 13);
            this.lblRecentCall.TabIndex = 0;
            this.lblRecentCall.Text = "Most Recent Call:";
            // 
            // grpAnswered
            // 
            this.grpAnswered.Controls.Add(this.btnAnswer);
            this.grpAnswered.Controls.Add(this.label1);
            this.grpAnswered.Controls.Add(this.txtAnsweredCall);
            this.grpAnswered.Location = new System.Drawing.Point(12, 102);
            this.grpAnswered.Name = "grpAnswered";
            this.grpAnswered.Size = new System.Drawing.Size(775, 95);
            this.grpAnswered.TabIndex = 1;
            this.grpAnswered.TabStop = false;
            this.grpAnswered.Text = "Answered Calls";
            // 
            // btnAnswer
            // 
            this.btnAnswer.Location = new System.Drawing.Point(598, 45);
            this.btnAnswer.Name = "btnAnswer";
            this.btnAnswer.Size = new System.Drawing.Size(148, 40);
            this.btnAnswer.TabIndex = 4;
            this.btnAnswer.Text = "&Answer Next Call";
            this.btnAnswer.UseVisualStyleBackColor = true;
            this.btnAnswer.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current Call:";
            // 
            // txtAnsweredCall
            // 
            this.txtAnsweredCall.Location = new System.Drawing.Point(103, 19);
            this.txtAnsweredCall.Name = "txtAnsweredCall";
            this.txtAnsweredCall.Size = new System.Drawing.Size(643, 20);
            this.txtAnsweredCall.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 248);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(799, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            this.tslStatus.Name = "tslStatus";
            this.tslStatus.Size = new System.Drawing.Size(88, 17);
            this.tslStatus.Text = "Waiting Calls: 0";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(707, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 29);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit System";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 270);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grpAnswered);
            this.Controls.Add(this.grpIncoming);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpIncoming.ResumeLayout(false);
            this.grpIncoming.PerformLayout();
            this.grpAnswered.ResumeLayout(false);
            this.grpAnswered.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIncoming;
        private System.Windows.Forms.Label lblRecentCall;
        private System.Windows.Forms.GroupBox grpAnswered;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.TextBox txtRecentCall;
        private System.Windows.Forms.Button btnAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAnsweredCall;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Timer timer1;
    }
}


namespace Card
{
    partial class MainForm
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
            this.status_label = new System.Windows.Forms.Label();
            this.pass_txtbox = new System.Windows.Forms.TextBox();
            this.atr_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ReadCardTab = new System.Windows.Forms.TabPage();
            this.AddNewTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pass_txtboxwrite = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.ReadCardTab.SuspendLayout();
            this.AddNewTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_label
            // 
            this.status_label.AutoSize = true;
            this.status_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_label.Location = new System.Drawing.Point(63, 26);
            this.status_label.Name = "status_label";
            this.status_label.Size = new System.Drawing.Size(122, 31);
            this.status_label.TabIndex = 0;
            this.status_label.Text = "STATUS";
            this.status_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pass_txtbox
            // 
            this.pass_txtbox.Location = new System.Drawing.Point(6, 131);
            this.pass_txtbox.Name = "pass_txtbox";
            this.pass_txtbox.ReadOnly = true;
            this.pass_txtbox.Size = new System.Drawing.Size(226, 20);
            this.pass_txtbox.TabIndex = 1;
            // 
            // atr_txtbox
            // 
            this.atr_txtbox.Location = new System.Drawing.Point(6, 81);
            this.atr_txtbox.Name = "atr_txtbox";
            this.atr_txtbox.ReadOnly = true;
            this.atr_txtbox.Size = new System.Drawing.Size(226, 20);
            this.atr_txtbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ATR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ReadCardTab);
            this.tabControl1.Controls.Add(this.AddNewTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 213);
            this.tabControl1.TabIndex = 3;
            // 
            // ReadCardTab
            // 
            this.ReadCardTab.Controls.Add(this.linkLabel1);
            this.ReadCardTab.Controls.Add(this.label2);
            this.ReadCardTab.Controls.Add(this.label1);
            this.ReadCardTab.Controls.Add(this.atr_txtbox);
            this.ReadCardTab.Controls.Add(this.pass_txtbox);
            this.ReadCardTab.Controls.Add(this.status_label);
            this.ReadCardTab.Location = new System.Drawing.Point(4, 22);
            this.ReadCardTab.Name = "ReadCardTab";
            this.ReadCardTab.Padding = new System.Windows.Forms.Padding(3);
            this.ReadCardTab.Size = new System.Drawing.Size(252, 187);
            this.ReadCardTab.TabIndex = 0;
            this.ReadCardTab.Text = "Чтение";
            this.ReadCardTab.UseVisualStyleBackColor = true;
            // 
            // AddNewTab
            // 
            this.AddNewTab.Controls.Add(this.button1);
            this.AddNewTab.Controls.Add(this.pass_txtboxwrite);
            this.AddNewTab.Controls.Add(this.label3);
            this.AddNewTab.Location = new System.Drawing.Point(4, 22);
            this.AddNewTab.Name = "AddNewTab";
            this.AddNewTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddNewTab.Size = new System.Drawing.Size(252, 159);
            this.AddNewTab.TabIndex = 1;
            this.AddNewTab.Text = "Добавить";
            this.AddNewTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pass_txtboxwrite
            // 
            this.pass_txtboxwrite.Location = new System.Drawing.Point(6, 61);
            this.pass_txtboxwrite.Name = "pass_txtboxwrite";
            this.pass_txtboxwrite.Size = new System.Drawing.Size(240, 20);
            this.pass_txtboxwrite.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Пароль";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(8, 161);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 13);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Удалить";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 213);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Reader";
            this.tabControl1.ResumeLayout(false);
            this.ReadCardTab.ResumeLayout(false);
            this.ReadCardTab.PerformLayout();
            this.AddNewTab.ResumeLayout(false);
            this.AddNewTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label status_label;
        private System.Windows.Forms.TextBox pass_txtbox;
        private System.Windows.Forms.TextBox atr_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ReadCardTab;
        private System.Windows.Forms.TabPage AddNewTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox pass_txtboxwrite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
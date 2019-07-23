namespace Card
{
    partial class Identify
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
            this.atrTxtBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusLabel = new System.Windows.Forms.TextBox();
            this.readerLabel = new System.Windows.Forms.TextBox();
            this.MoreSignLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.ReadersComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.DelCardMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddCardMeniItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CardListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.дезигнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.темнаяТемаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oFFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atrTxtBox
            // 
            this.atrTxtBox.BackColor = System.Drawing.Color.White;
            this.atrTxtBox.Font = new System.Drawing.Font("Play", 16F);
            this.atrTxtBox.Location = new System.Drawing.Point(16, 154);
            this.atrTxtBox.Name = "atrTxtBox";
            this.atrTxtBox.ReadOnly = true;
            this.atrTxtBox.Size = new System.Drawing.Size(597, 32);
            this.atrTxtBox.TabIndex = 0;
            this.atrTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.atrTxtBox.TextChanged += new System.EventHandler(this.AtrTxtBox_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.Control;
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusLabel.Font = new System.Drawing.Font("Play", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.Location = new System.Drawing.Point(12, 89);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.ReadOnly = true;
            this.statusLabel.Size = new System.Drawing.Size(597, 50);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "STATUS";
            this.statusLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // readerLabel
            // 
            this.readerLabel.BackColor = System.Drawing.SystemColors.Control;
            this.readerLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.readerLabel.Font = new System.Drawing.Font("Play", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readerLabel.Location = new System.Drawing.Point(12, 64);
            this.readerLabel.Name = "readerLabel";
            this.readerLabel.ReadOnly = true;
            this.readerLabel.Size = new System.Drawing.Size(597, 19);
            this.readerLabel.TabIndex = 2;
            this.readerLabel.Text = "Reader";
            this.readerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MoreSignLbl
            // 
            this.MoreSignLbl.AutoSize = true;
            this.MoreSignLbl.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoreSignLbl.Location = new System.Drawing.Point(12, 203);
            this.MoreSignLbl.Name = "MoreSignLbl";
            this.MoreSignLbl.Size = new System.Drawing.Size(28, 19);
            this.MoreSignLbl.TabIndex = 3;
            this.MoreSignLbl.Text = "";
            this.MoreSignLbl.Click += new System.EventHandler(this.MoreSignLbl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Подробнее";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(16, 247);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(175, 28);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Отображать ATR";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(16, 281);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(330, 28);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Отбражать название считывателя";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // ReadersComboBox
            // 
            this.ReadersComboBox.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ReadersComboBox.FormattingEnabled = true;
            this.ReadersComboBox.Location = new System.Drawing.Point(16, 353);
            this.ReadersComboBox.Name = "ReadersComboBox";
            this.ReadersComboBox.Size = new System.Drawing.Size(334, 32);
            this.ReadersComboBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Выбрать считыватель";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Play", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CardMenu,
            this.дезигнToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(634, 25);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CardMenu
            // 
            this.CardMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DelCardMenuItem,
            this.AddCardMeniItem,
            this.CardListMenuItem});
            this.CardMenu.Font = new System.Drawing.Font("Play", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CardMenu.Name = "CardMenu";
            this.CardMenu.Size = new System.Drawing.Size(56, 21);
            this.CardMenu.Text = "Карта";
            this.CardMenu.Click += new System.EventHandler(this.CardMenu_Click);
            // 
            // DelCardMenuItem
            // 
            this.DelCardMenuItem.Name = "DelCardMenuItem";
            this.DelCardMenuItem.Size = new System.Drawing.Size(169, 22);
            this.DelCardMenuItem.Text = "Удалить карту";
            this.DelCardMenuItem.Click += new System.EventHandler(this.DelCardMenuItem_Click);
            // 
            // AddCardMeniItem
            // 
            this.AddCardMeniItem.Name = "AddCardMeniItem";
            this.AddCardMeniItem.Size = new System.Drawing.Size(169, 22);
            this.AddCardMeniItem.Text = "Добавить карту";
            this.AddCardMeniItem.Click += new System.EventHandler(this.AddCardMeniItem_Click);
            // 
            // CardListMenuItem
            // 
            this.CardListMenuItem.Name = "CardListMenuItem";
            this.CardListMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CardListMenuItem.Text = "Список карт";
            this.CardListMenuItem.Click += new System.EventHandler(this.CardListMenuItem_Click);
            // 
            // дезигнToolStripMenuItem
            // 
            this.дезигнToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.темнаяТемаToolStripMenuItem});
            this.дезигнToolStripMenuItem.Font = new System.Drawing.Font("Play", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дезигнToolStripMenuItem.Name = "дезигнToolStripMenuItem";
            this.дезигнToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.дезигнToolStripMenuItem.Text = "Дезигн";
            // 
            // темнаяТемаToolStripMenuItem
            // 
            this.темнаяТемаToolStripMenuItem.CheckOnClick = true;
            this.темнаяТемаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oNToolStripMenuItem,
            this.oFFToolStripMenuItem});
            this.темнаяТемаToolStripMenuItem.Name = "темнаяТемаToolStripMenuItem";
            this.темнаяТемаToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.темнаяТемаToolStripMenuItem.Text = "Темная тема";
            // 
            // oNToolStripMenuItem
            // 
            this.oNToolStripMenuItem.CheckOnClick = true;
            this.oNToolStripMenuItem.Name = "oNToolStripMenuItem";
            this.oNToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oNToolStripMenuItem.Text = "ON";
            // 
            // oFFToolStripMenuItem
            // 
            this.oFFToolStripMenuItem.CheckOnClick = true;
            this.oFFToolStripMenuItem.Name = "oFFToolStripMenuItem";
            this.oFFToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oFFToolStripMenuItem.Text = "OFF";
            // 
            // Identify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 396);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReadersComboBox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MoreSignLbl);
            this.Controls.Add(this.readerLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.atrTxtBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Identify";
            this.Text = "Identify";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Identify_FormClosing);
            this.Load += new System.EventHandler(this.Identify_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox atrTxtBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox statusLabel;
        private System.Windows.Forms.TextBox readerLabel;
        private System.Windows.Forms.Label MoreSignLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox ReadersComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CardMenu;
        private System.Windows.Forms.ToolStripMenuItem DelCardMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddCardMeniItem;
        private System.Windows.Forms.ToolStripMenuItem CardListMenuItem;
        private System.Windows.Forms.ToolStripMenuItem дезигнToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem темнаяТемаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oFFToolStripMenuItem;
    }
}
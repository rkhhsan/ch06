namespace ExCap6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.displayListBox = new System.Windows.Forms.ListBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.DeletaBt = new System.Windows.Forms.Button();
            this.Ex6_11 = new System.Windows.Forms.Button();
            this.LimpaButton = new System.Windows.Forms.Button();
            this.Ex6_13 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Ex6_15But = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // displayListBox
            // 
            this.displayListBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.displayListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayListBox.FormattingEnabled = true;
            this.displayListBox.HorizontalScrollbar = true;
            this.displayListBox.ItemHeight = 20;
            this.displayListBox.Location = new System.Drawing.Point(29, 25);
            this.displayListBox.Name = "displayListBox";
            this.displayListBox.Size = new System.Drawing.Size(423, 404);
            this.displayListBox.TabIndex = 0;
            this.displayListBox.SelectedIndexChanged += new System.EventHandler(this.displayListBox_SelectedIndexChanged);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(487, 27);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(169, 26);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.Blue;
            this.addButton.Location = new System.Drawing.Point(487, 73);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(169, 33);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Inclui na lista";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // DeletaBt
            // 
            this.DeletaBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletaBt.ForeColor = System.Drawing.Color.Red;
            this.DeletaBt.Location = new System.Drawing.Point(487, 126);
            this.DeletaBt.Name = "DeletaBt";
            this.DeletaBt.Size = new System.Drawing.Size(169, 33);
            this.DeletaBt.TabIndex = 4;
            this.DeletaBt.Text = "Deleta o selecionado";
            this.DeletaBt.UseVisualStyleBackColor = true;
            this.DeletaBt.Click += new System.EventHandler(this.DeletaBt_Click);
            // 
            // Ex6_11
            // 
            this.Ex6_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex6_11.Location = new System.Drawing.Point(487, 232);
            this.Ex6_11.Name = "Ex6_11";
            this.Ex6_11.Size = new System.Drawing.Size(75, 33);
            this.Ex6_11.TabIndex = 5;
            this.Ex6_11.Text = "Ex 6-11";
            this.toolTip1.SetToolTip(this.Ex6_11, "Ache o maior o segundo maior, e o menor dos números. Digite no textbox e aperte n" +
        "o Inclui na lista");
            this.Ex6_11.UseVisualStyleBackColor = true;
            this.Ex6_11.Click += new System.EventHandler(this.Ex6_11_Click);
            // 
            // LimpaButton
            // 
            this.LimpaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpaButton.Location = new System.Drawing.Point(487, 179);
            this.LimpaButton.Name = "LimpaButton";
            this.LimpaButton.Size = new System.Drawing.Size(169, 33);
            this.LimpaButton.TabIndex = 6;
            this.LimpaButton.Text = "Limpa";
            this.LimpaButton.UseVisualStyleBackColor = true;
            this.LimpaButton.Click += new System.EventHandler(this.LimpaButton_Click);
            // 
            // Ex6_13
            // 
            this.Ex6_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex6_13.Location = new System.Drawing.Point(581, 232);
            this.Ex6_13.Name = "Ex6_13";
            this.Ex6_13.Size = new System.Drawing.Size(75, 33);
            this.Ex6_13.TabIndex = 7;
            this.Ex6_13.Text = "Ex 6-13";
            this.toolTip1.SetToolTip(this.Ex6_13, "Calcula o fatorial: digite um inteiro positivo no textbox e após este botão");
            this.Ex6_13.UseVisualStyleBackColor = true;
            this.Ex6_13.Click += new System.EventHandler(this.Ex6_13_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 20000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Exercícios do Cap 6 - Estruturas de Controle II";
            // 
            // Ex6_15But
            // 
            this.Ex6_15But.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ex6_15But.Location = new System.Drawing.Point(487, 288);
            this.Ex6_15But.Name = "Ex6_15But";
            this.Ex6_15But.Size = new System.Drawing.Size(75, 33);
            this.Ex6_15But.TabIndex = 8;
            this.Ex6_15But.Text = "Ex6_15";
            this.toolTip1.SetToolTip(this.Ex6_15But, resources.GetString("Ex6_15But.ToolTip"));
            this.Ex6_15But.UseVisualStyleBackColor = true;
            this.Ex6_15But.Click += new System.EventHandler(this.Ex6_15But_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.ShowToolTips = true;
            this.tabControl1.Size = new System.Drawing.Size(746, 484);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(738, 458);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.Ex6_15But);
            this.panel1.Controls.Add(this.displayListBox);
            this.panel1.Controls.Add(this.inputTextBox);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.DeletaBt);
            this.panel1.Controls.Add(this.LimpaButton);
            this.panel1.Controls.Add(this.Ex6_13);
            this.panel1.Controls.Add(this.Ex6_11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 452);
            this.panel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(738, 458);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 484);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox displayListBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button DeletaBt;
        private System.Windows.Forms.Button Ex6_11;
        private System.Windows.Forms.Button LimpaButton;
        private System.Windows.Forms.Button Ex6_13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Ex6_15But;
    }
}


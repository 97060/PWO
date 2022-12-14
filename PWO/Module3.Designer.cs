namespace PWO
{
    partial class Module3
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
            this.kwotaBruttoTextBox = new System.Windows.Forms.TextBox();
            this.obliczButton = new System.Windows.Forms.Button();
            this.pit0CheckBox = new System.Windows.Forms.CheckBox();
            this.wynikGroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.podatekTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.skladkaZdrowotnaTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.skladkaRentowaTextBox = new System.Windows.Forms.TextBox();
            this.skladkaEmerytalnaTextBox = new System.Windows.Forms.TextBox();
            this.skladkaChorobowaTextBox = new System.Windows.Forms.TextBox();
            this.sumaSkladekTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kwotaNettoTextBox = new System.Windows.Forms.TextBox();
            this.wynikGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kwotaBruttoTextBox
            // 
            this.kwotaBruttoTextBox.Location = new System.Drawing.Point(348, 25);
            this.kwotaBruttoTextBox.Name = "kwotaBruttoTextBox";
            this.kwotaBruttoTextBox.PlaceholderText = "Kwota brutto";
            this.kwotaBruttoTextBox.Size = new System.Drawing.Size(100, 23);
            this.kwotaBruttoTextBox.TabIndex = 0;
            this.kwotaBruttoTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kwotaBruttoTextBox_KeyPress);
            // 
            // obliczButton
            // 
            this.obliczButton.Location = new System.Drawing.Point(454, 24);
            this.obliczButton.Name = "obliczButton";
            this.obliczButton.Size = new System.Drawing.Size(75, 23);
            this.obliczButton.TabIndex = 1;
            this.obliczButton.Text = "Oblicz";
            this.obliczButton.UseVisualStyleBackColor = true;
            this.obliczButton.Click += new System.EventHandler(this.obliczButton_Click);
            // 
            // pit0CheckBox
            // 
            this.pit0CheckBox.AutoSize = true;
            this.pit0CheckBox.Location = new System.Drawing.Point(348, 54);
            this.pit0CheckBox.Name = "pit0CheckBox";
            this.pit0CheckBox.Size = new System.Drawing.Size(177, 19);
            this.pit0CheckBox.TabIndex = 2;
            this.pit0CheckBox.Text = "Pit - 0 (poniżej 26 roku życia)";
            this.pit0CheckBox.UseVisualStyleBackColor = true;
            // 
            // wynikGroupBox
            // 
            this.wynikGroupBox.Controls.Add(this.label7);
            this.wynikGroupBox.Controls.Add(this.podatekTextBox);
            this.wynikGroupBox.Controls.Add(this.label6);
            this.wynikGroupBox.Controls.Add(this.skladkaZdrowotnaTextBox);
            this.wynikGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.wynikGroupBox.Controls.Add(this.label1);
            this.wynikGroupBox.Controls.Add(this.kwotaNettoTextBox);
            this.wynikGroupBox.Location = new System.Drawing.Point(309, 79);
            this.wynikGroupBox.Name = "wynikGroupBox";
            this.wynikGroupBox.Size = new System.Drawing.Size(259, 237);
            this.wynikGroupBox.TabIndex = 3;
            this.wynikGroupBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Podatek do zaplaty";
            // 
            // podatekTextBox
            // 
            this.podatekTextBox.Location = new System.Drawing.Point(131, 201);
            this.podatekTextBox.Name = "podatekTextBox";
            this.podatekTextBox.ReadOnly = true;
            this.podatekTextBox.Size = new System.Drawing.Size(114, 23);
            this.podatekTextBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Składka zdrowotna";
            // 
            // skladkaZdrowotnaTextBox
            // 
            this.skladkaZdrowotnaTextBox.Location = new System.Drawing.Point(131, 174);
            this.skladkaZdrowotnaTextBox.Name = "skladkaZdrowotnaTextBox";
            this.skladkaZdrowotnaTextBox.ReadOnly = true;
            this.skladkaZdrowotnaTextBox.Size = new System.Drawing.Size(115, 23);
            this.skladkaZdrowotnaTextBox.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.skladkaRentowaTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.skladkaEmerytalnaTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.skladkaChorobowaTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.sumaSkladekTextBox, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 51);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(244, 113);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 27);
            this.label5.TabIndex = 8;
            this.label5.Text = "Składka chorobowa";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "Składka rentowa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Suma";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // skladkaRentowaTextBox
            // 
            this.skladkaRentowaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skladkaRentowaTextBox.Location = new System.Drawing.Point(125, 32);
            this.skladkaRentowaTextBox.Name = "skladkaRentowaTextBox";
            this.skladkaRentowaTextBox.ReadOnly = true;
            this.skladkaRentowaTextBox.Size = new System.Drawing.Size(115, 23);
            this.skladkaRentowaTextBox.TabIndex = 6;
            // 
            // skladkaEmerytalnaTextBox
            // 
            this.skladkaEmerytalnaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skladkaEmerytalnaTextBox.Location = new System.Drawing.Point(125, 4);
            this.skladkaEmerytalnaTextBox.Name = "skladkaEmerytalnaTextBox";
            this.skladkaEmerytalnaTextBox.ReadOnly = true;
            this.skladkaEmerytalnaTextBox.Size = new System.Drawing.Size(115, 23);
            this.skladkaEmerytalnaTextBox.TabIndex = 3;
            // 
            // skladkaChorobowaTextBox
            // 
            this.skladkaChorobowaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skladkaChorobowaTextBox.Location = new System.Drawing.Point(125, 60);
            this.skladkaChorobowaTextBox.Name = "skladkaChorobowaTextBox";
            this.skladkaChorobowaTextBox.ReadOnly = true;
            this.skladkaChorobowaTextBox.Size = new System.Drawing.Size(115, 23);
            this.skladkaChorobowaTextBox.TabIndex = 4;
            // 
            // sumaSkladekTextBox
            // 
            this.sumaSkladekTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sumaSkladekTextBox.Location = new System.Drawing.Point(125, 88);
            this.sumaSkladekTextBox.Name = "sumaSkladekTextBox";
            this.sumaSkladekTextBox.ReadOnly = true;
            this.sumaSkladekTextBox.Size = new System.Drawing.Size(115, 23);
            this.sumaSkladekTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "Składka emerytalna";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kwota netto";
            // 
            // kwotaNettoTextBox
            // 
            this.kwotaNettoTextBox.Location = new System.Drawing.Point(131, 26);
            this.kwotaNettoTextBox.Name = "kwotaNettoTextBox";
            this.kwotaNettoTextBox.ReadOnly = true;
            this.kwotaNettoTextBox.Size = new System.Drawing.Size(115, 23);
            this.kwotaNettoTextBox.TabIndex = 0;
            // 
            // Module3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.wynikGroupBox);
            this.Controls.Add(this.pit0CheckBox);
            this.Controls.Add(this.obliczButton);
            this.Controls.Add(this.kwotaBruttoTextBox);
            this.Name = "Module3";
            this.Size = new System.Drawing.Size(912, 490);
            this.wynikGroupBox.ResumeLayout(false);
            this.wynikGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox kwotaBruttoTextBox;
        private Button obliczButton;
        private CheckBox pit0CheckBox;
        private GroupBox wynikGroupBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox skladkaRentowaTextBox;
        private TextBox skladkaEmerytalnaTextBox;
        private TextBox skladkaChorobowaTextBox;
        private TextBox sumaSkladekTextBox;
        private Label label2;
        private Label label1;
        private TextBox kwotaNettoTextBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private TextBox skladkaZdrowotnaTextBox;
        private Label label7;
        private TextBox podatekTextBox;
    }
}

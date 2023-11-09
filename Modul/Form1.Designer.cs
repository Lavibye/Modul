namespace Modul
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.birdNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.aviariesListBox = new System.Windows.Forms.ListBox();
            this.BirdType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AviaryArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaterArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperatureWater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TemperatureAir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReadButton = new System.Windows.Forms.Button();
            this.WriteDataButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BirdType,
            this.AviaryArea,
            this.WaterArea,
            this.TemperatureWater,
            this.TemperatureAir});
            this.dataGridView1.Location = new System.Drawing.Point(174, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 306);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Bird name:";
            // 
            // birdNameTextBox
            // 
            this.birdNameTextBox.Location = new System.Drawing.Point(36, 75);
            this.birdNameTextBox.Name = "birdNameTextBox";
            this.birdNameTextBox.Size = new System.Drawing.Size(111, 20);
            this.birdNameTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(36, 119);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Bird";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // aviariesListBox
            // 
            this.aviariesListBox.FormattingEnabled = true;
            this.aviariesListBox.Location = new System.Drawing.Point(174, 334);
            this.aviariesListBox.Name = "aviariesListBox";
            this.aviariesListBox.Size = new System.Drawing.Size(271, 134);
            this.aviariesListBox.TabIndex = 5;
            // 
            // BirdType
            // 
            this.BirdType.HeaderText = "Тип птаха";
            this.BirdType.Name = "BirdType";
            // 
            // AviaryArea
            // 
            this.AviaryArea.HeaderText = "Площа вольєра";
            this.AviaryArea.Name = "AviaryArea";
            // 
            // WaterArea
            // 
            this.WaterArea.HeaderText = "Площа водойми";
            this.WaterArea.Name = "WaterArea";
            // 
            // TemperatureWater
            // 
            this.TemperatureWater.HeaderText = "Температура води";
            this.TemperatureWater.Name = "TemperatureWater";
            // 
            // TemperatureAir
            // 
            this.TemperatureAir.HeaderText = "Температури на суші";
            this.TemperatureAir.Name = "TemperatureAir";
            // 
            // ReadButton
            // 
            this.ReadButton.Location = new System.Drawing.Point(36, 249);
            this.ReadButton.Name = "ReadButton";
            this.ReadButton.Size = new System.Drawing.Size(111, 23);
            this.ReadButton.TabIndex = 6;
            this.ReadButton.Text = "Read File";
            this.ReadButton.UseVisualStyleBackColor = true;
            // 
            // WriteDataButton
            // 
            this.WriteDataButton.Location = new System.Drawing.Point(36, 292);
            this.WriteDataButton.Name = "WriteDataButton";
            this.WriteDataButton.Size = new System.Drawing.Size(111, 23);
            this.WriteDataButton.TabIndex = 7;
            this.WriteDataButton.Text = "Write File";
            this.WriteDataButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(876, 520);
            this.Controls.Add(this.WriteDataButton);
            this.Controls.Add(this.ReadButton);
            this.Controls.Add(this.aviariesListBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.birdNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox birdNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ListBox aviariesListBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirdType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AviaryArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaterArea;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperatureWater;
        private System.Windows.Forms.DataGridViewTextBoxColumn TemperatureAir;
        private System.Windows.Forms.Button ReadButton;
        private System.Windows.Forms.Button WriteDataButton;
    }
}


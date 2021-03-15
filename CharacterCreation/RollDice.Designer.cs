
namespace CharacterCreation
{
    partial class RollDice
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
            this.label2 = new System.Windows.Forms.Label();
            this.Modifier = new System.Windows.Forms.TextBox();
            this.RollResult = new System.Windows.Forms.TextBox();
            this.Roll = new System.Windows.Forms.Button();
            this.D4 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.D6 = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.D8 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.D100 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.D20 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.D10 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.D4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D100)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.D10)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 41);
            this.label1.TabIndex = 6;
            this.label1.Text = "Dice Roller";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add Mod.";
            // 
            // Modifier
            // 
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.Location = new System.Drawing.Point(31, 291);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(282, 30);
            this.Modifier.TabIndex = 9;
            // 
            // RollResult
            // 
            this.RollResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RollResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RollResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RollResult.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.RollResult.Location = new System.Drawing.Point(12, 416);
            this.RollResult.MaximumSize = new System.Drawing.Size(322, 50);
            this.RollResult.MinimumSize = new System.Drawing.Size(322, 50);
            this.RollResult.Multiline = true;
            this.RollResult.Name = "RollResult";
            this.RollResult.ReadOnly = true;
            this.RollResult.Size = new System.Drawing.Size(322, 50);
            this.RollResult.TabIndex = 10;
            // 
            // Roll
            // 
            this.Roll.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Roll.Location = new System.Drawing.Point(91, 361);
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(163, 49);
            this.Roll.TabIndex = 11;
            this.Roll.Text = "Roll Dice";
            this.Roll.UseVisualStyleBackColor = true;
            this.Roll.Click += new System.EventHandler(this.Roll_Click);
            // 
            // D4
            // 
            this.D4.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D4.Location = new System.Drawing.Point(85, 98);
            this.D4.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.D4.Name = "D4";
            this.D4.Size = new System.Drawing.Size(35, 33);
            this.D4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 34);
            this.label3.TabIndex = 13;
            this.label3.Text = "D4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "D6";
            // 
            // D6
            // 
            this.D6.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D6.Location = new System.Drawing.Point(85, 148);
            this.D6.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.D6.Name = "D6";
            this.D6.Size = new System.Drawing.Size(35, 33);
            this.D6.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 34);
            this.label6.TabIndex = 17;
            this.label6.Text = "D8";
            // 
            // D8
            // 
            this.D8.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D8.Location = new System.Drawing.Point(85, 197);
            this.D8.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.D8.Name = "D8";
            this.D8.Size = new System.Drawing.Size(35, 33);
            this.D8.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(188, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 34);
            this.label5.TabIndex = 23;
            this.label5.Text = "D100";
            // 
            // D100
            // 
            this.D100.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D100.Location = new System.Drawing.Point(278, 196);
            this.D100.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.D100.Name = "D100";
            this.D100.Size = new System.Drawing.Size(35, 33);
            this.D100.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(188, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 34);
            this.label7.TabIndex = 21;
            this.label7.Text = "D20";
            // 
            // D20
            // 
            this.D20.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D20.Location = new System.Drawing.Point(278, 147);
            this.D20.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.D20.Name = "D20";
            this.D20.Size = new System.Drawing.Size(35, 33);
            this.D20.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 24.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(188, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 34);
            this.label8.TabIndex = 19;
            this.label8.Text = "D10";
            // 
            // D10
            // 
            this.D10.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D10.Location = new System.Drawing.Point(278, 97);
            this.D10.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.D10.Name = "D10";
            this.D10.Size = new System.Drawing.Size(35, 33);
            this.D10.TabIndex = 18;
            // 
            // RollDice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 482);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.D100);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.D20);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.D10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.D8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.D6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.D4);
            this.Controls.Add(this.Roll);
            this.Controls.Add(this.RollResult);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RollDice";
            this.Text = "RollDice";
            this.Load += new System.EventHandler(this.RollDice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.D4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D100)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.D10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Modifier;
        private System.Windows.Forms.TextBox RollResult;
        private System.Windows.Forms.Button Roll;
        private System.Windows.Forms.NumericUpDown D4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown D6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown D8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown D100;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown D20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown D10;
    }
}
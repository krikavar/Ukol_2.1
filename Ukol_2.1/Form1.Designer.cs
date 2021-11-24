
namespace Ukol_2._1
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMAX = new System.Windows.Forms.TextBox();
            this.listBoxVystup = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxMIN = new System.Windows.Forms.TextBox();
            this.buttonVypocet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(34, 235);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 32);
            this.button2.TabIndex = 32;
            this.button2.Text = "Výpočet NSD";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Linen;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(34, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "Výpočet první / 7";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "Maximum";
            // 
            // textBoxMAX
            // 
            this.textBoxMAX.BackColor = System.Drawing.Color.Silver;
            this.textBoxMAX.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMAX.Location = new System.Drawing.Point(134, 83);
            this.textBoxMAX.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMAX.Name = "textBoxMAX";
            this.textBoxMAX.Size = new System.Drawing.Size(132, 25);
            this.textBoxMAX.TabIndex = 29;
            this.textBoxMAX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listBoxVystup
            // 
            this.listBoxVystup.BackColor = System.Drawing.Color.White;
            this.listBoxVystup.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBoxVystup.ForeColor = System.Drawing.Color.Black;
            this.listBoxVystup.FormattingEnabled = true;
            this.listBoxVystup.ItemHeight = 26;
            this.listBoxVystup.Location = new System.Drawing.Point(300, 27);
            this.listBoxVystup.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxVystup.Name = "listBoxVystup";
            this.listBoxVystup.Size = new System.Drawing.Size(147, 238);
            this.listBoxVystup.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Minimum";
            // 
            // textBoxMIN
            // 
            this.textBoxMIN.BackColor = System.Drawing.Color.Silver;
            this.textBoxMIN.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxMIN.Location = new System.Drawing.Point(134, 28);
            this.textBoxMIN.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMIN.Name = "textBoxMIN";
            this.textBoxMIN.Size = new System.Drawing.Size(132, 25);
            this.textBoxMIN.TabIndex = 26;
            this.textBoxMIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonVypocet
            // 
            this.buttonVypocet.BackColor = System.Drawing.Color.Linen;
            this.buttonVypocet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonVypocet.Location = new System.Drawing.Point(34, 132);
            this.buttonVypocet.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVypocet.Name = "buttonVypocet";
            this.buttonVypocet.Size = new System.Drawing.Size(232, 32);
            this.buttonVypocet.TabIndex = 25;
            this.buttonVypocet.Text = "Výpočet prvočísel";
            this.buttonVypocet.UseVisualStyleBackColor = false;
            this.buttonVypocet.Click += new System.EventHandler(this.buttonVypocet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxMAX);
            this.Controls.Add(this.listBoxVystup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMIN);
            this.Controls.Add(this.buttonVypocet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ukol 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMAX;
        private System.Windows.Forms.ListBox listBoxVystup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxMIN;
        private System.Windows.Forms.Button buttonVypocet;
    }
}


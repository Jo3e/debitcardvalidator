namespace CreditCardValidator_conference_
{
    partial class CreditCardValidator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCardValidator));
            this.label1 = new System.Windows.Forms.Label();
            this.userValue = new System.Windows.Forms.TextBox();
            this.ValidateCreditCard = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.TextBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.MII = new System.Windows.Forms.TextBox();
            this.IssuerIdentifier = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cardIssuer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.SeaShell;
            this.label1.Location = new System.Drawing.Point(519, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Credit Card Number :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userValue
            // 
            this.userValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userValue.Location = new System.Drawing.Point(714, 146);
            this.userValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userValue.Name = "userValue";
            this.userValue.Size = new System.Drawing.Size(227, 24);
            this.userValue.TabIndex = 1;
            this.userValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userValue.TextChanged += new System.EventHandler(this.userValue_TextChanged);
            // 
            // ValidateCreditCard
            // 
            this.ValidateCreditCard.Enabled = false;
            this.ValidateCreditCard.ForeColor = System.Drawing.Color.Black;
            this.ValidateCreditCard.Location = new System.Drawing.Point(714, 335);
            this.ValidateCreditCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValidateCreditCard.Name = "ValidateCreditCard";
            this.ValidateCreditCard.Size = new System.Drawing.Size(114, 28);
            this.ValidateCreditCard.TabIndex = 2;
            this.ValidateCreditCard.Text = "Validate Card";
            this.ValidateCreditCard.UseVisualStyleBackColor = true;
            this.ValidateCreditCard.Click += new System.EventHandler(this.ValidateCreditCard_Click);
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Enabled = false;
            this.result.Location = new System.Drawing.Point(714, 189);
            this.result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(227, 24);
            this.result.TabIndex = 3;
            this.result.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.resultLabel.Location = new System.Drawing.Point(615, 196);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(63, 17);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result :";
            // 
            // MII
            // 
            this.MII.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MII.Enabled = false;
            this.MII.Location = new System.Drawing.Point(714, 238);
            this.MII.Name = "MII";
            this.MII.Size = new System.Drawing.Size(227, 24);
            this.MII.TabIndex = 5;
            this.MII.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IssuerIdentifier
            // 
            this.IssuerIdentifier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IssuerIdentifier.Enabled = false;
            this.IssuerIdentifier.Location = new System.Drawing.Point(714, 286);
            this.IssuerIdentifier.Name = "IssuerIdentifier";
            this.IssuerIdentifier.Size = new System.Drawing.Size(227, 24);
            this.IssuerIdentifier.TabIndex = 6;
            this.IssuerIdentifier.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.SeaShell;
            this.label2.Location = new System.Drawing.Point(628, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "M I I :";
            // 
            // cardIssuer
            // 
            this.cardIssuer.AutoSize = true;
            this.cardIssuer.BackColor = System.Drawing.Color.Transparent;
            this.cardIssuer.ForeColor = System.Drawing.Color.SeaShell;
            this.cardIssuer.Location = new System.Drawing.Point(577, 293);
            this.cardIssuer.Name = "cardIssuer";
            this.cardIssuer.Size = new System.Drawing.Size(101, 17);
            this.cardIssuer.TabIndex = 8;
            this.cardIssuer.Text = "Card Issuer :";
            // 
            // CreditCardValidator
            // 
            this.AccessibleName = "NOUN CCV";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1044, 452);
            this.Controls.Add(this.cardIssuer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IssuerIdentifier);
            this.Controls.Add(this.MII);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.result);
            this.Controls.Add(this.ValidateCreditCard);
            this.Controls.Add(this.userValue);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CreditCardValidator";
            this.Text = "NOUN Credit Card Validator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userValue;
        private System.Windows.Forms.Button ValidateCreditCard;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TextBox MII;
        private System.Windows.Forms.TextBox IssuerIdentifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label cardIssuer;
    }
}


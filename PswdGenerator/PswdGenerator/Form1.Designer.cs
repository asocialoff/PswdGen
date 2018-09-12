namespace PswdGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.genBtn = new MetroFramework.Controls.MetroButton();
            this.ForceLC = new MetroFramework.Controls.MetroCheckBox();
            this.ForceUC = new MetroFramework.Controls.MetroCheckBox();
            this.ForceS = new MetroFramework.Controls.MetroCheckBox();
            this.ForceN = new MetroFramework.Controls.MetroCheckBox();
            this.creditLabel = new MetroFramework.Controls.MetroLabel();
            this.LenghtLabel = new MetroFramework.Controls.MetroLabel();
            this.pswdBox = new MetroFramework.Controls.MetroTextBox();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(3, 88);
            this.trackBar.Maximum = 16;
            this.trackBar.Minimum = 8;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(144, 45);
            this.trackBar.TabIndex = 11;
            this.trackBar.Value = 8;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(189, 165);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(109, 28);
            this.genBtn.Style = MetroFramework.MetroColorStyle.Blue;
            this.genBtn.TabIndex = 13;
            this.genBtn.Text = "Generate";
            this.genBtn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.genBtn.UseSelectable = true;
            this.genBtn.UseStyleColors = true;
            // 
            // ForceLC
            // 
            this.ForceLC.AutoSize = true;
            this.ForceLC.Location = new System.Drawing.Point(13, 63);
            this.ForceLC.Name = "ForceLC";
            this.ForceLC.Size = new System.Drawing.Size(110, 15);
            this.ForceLC.TabIndex = 14;
            this.ForceLC.Text = "Force lower case";
            this.ForceLC.UseSelectable = true;
            // 
            // ForceUC
            // 
            this.ForceUC.AutoSize = true;
            this.ForceUC.Location = new System.Drawing.Point(129, 63);
            this.ForceUC.Name = "ForceUC";
            this.ForceUC.Size = new System.Drawing.Size(112, 15);
            this.ForceUC.TabIndex = 15;
            this.ForceUC.Text = "Force upper case";
            this.ForceUC.UseSelectable = true;
            // 
            // ForceS
            // 
            this.ForceS.AutoSize = true;
            this.ForceS.Location = new System.Drawing.Point(247, 63);
            this.ForceS.Name = "ForceS";
            this.ForceS.Size = new System.Drawing.Size(99, 15);
            this.ForceS.TabIndex = 16;
            this.ForceS.Text = "Force symbols";
            this.ForceS.UseSelectable = true;
            // 
            // ForceN
            // 
            this.ForceN.AutoSize = true;
            this.ForceN.Location = new System.Drawing.Point(360, 63);
            this.ForceN.Name = "ForceN";
            this.ForceN.Size = new System.Drawing.Size(102, 15);
            this.ForceN.TabIndex = 17;
            this.ForceN.Text = "Force numbers";
            this.ForceN.UseSelectable = true;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Location = new System.Drawing.Point(13, 183);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(66, 19);
            this.creditLabel.TabIndex = 18;
            this.creditLabel.Text = "by asocial";
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Location = new System.Drawing.Point(3, 114);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(59, 19);
            this.LenghtLabel.TabIndex = 19;
            this.LenghtLabel.Text = "Lenght : ";
            // 
            // pswdBox
            // 
            // 
            // 
            // 
            this.pswdBox.CustomButton.Image = null;
            this.pswdBox.CustomButton.Location = new System.Drawing.Point(122, 1);
            this.pswdBox.CustomButton.Name = "";
            this.pswdBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.pswdBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.pswdBox.CustomButton.TabIndex = 1;
            this.pswdBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.pswdBox.CustomButton.UseSelectable = true;
            this.pswdBox.CustomButton.Visible = false;
            this.pswdBox.Lines = new string[0];
            this.pswdBox.Location = new System.Drawing.Point(173, 136);
            this.pswdBox.MaxLength = 32767;
            this.pswdBox.Name = "pswdBox";
            this.pswdBox.PasswordChar = '\0';
            this.pswdBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.pswdBox.SelectedText = "";
            this.pswdBox.SelectionLength = 0;
            this.pswdBox.SelectionStart = 0;
            this.pswdBox.ShortcutsEnabled = true;
            this.pswdBox.Size = new System.Drawing.Size(144, 23);
            this.pswdBox.TabIndex = 20;
            this.pswdBox.UseSelectable = true;
            this.pswdBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.pswdBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(481, 216);
            this.Controls.Add(this.pswdBox);
            this.Controls.Add(this.LenghtLabel);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.ForceN);
            this.Controls.Add(this.ForceS);
            this.Controls.Add(this.ForceUC);
            this.Controls.Add(this.ForceLC);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.trackBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "PswdGenerator";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBar;
        private MetroFramework.Controls.MetroButton genBtn;
        private MetroFramework.Controls.MetroCheckBox ForceLC;
        private MetroFramework.Controls.MetroCheckBox ForceUC;
        private MetroFramework.Controls.MetroCheckBox ForceS;
        private MetroFramework.Controls.MetroCheckBox ForceN;
        private MetroFramework.Controls.MetroLabel creditLabel;
        private MetroFramework.Controls.MetroLabel LenghtLabel;
        private MetroFramework.Controls.MetroTextBox pswdBox;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}


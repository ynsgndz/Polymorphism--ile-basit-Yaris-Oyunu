
namespace polimorphismVeYarısOyunu
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
            this.lblHuman = new System.Windows.Forms.Label();
            this.lblOrg = new System.Windows.Forms.Label();
            this.lblElf = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmStart = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHuman
            // 
            this.lblHuman.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblHuman.Location = new System.Drawing.Point(110, 47);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(109, 52);
            this.lblHuman.TabIndex = 0;
            this.lblHuman.Text = "Human";
            this.lblHuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOrg
            // 
            this.lblOrg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOrg.Location = new System.Drawing.Point(110, 123);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(109, 52);
            this.lblOrg.TabIndex = 0;
            this.lblOrg.Text = "Org";
            this.lblOrg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblElf
            // 
            this.lblElf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblElf.Location = new System.Drawing.Point(110, 205);
            this.lblElf.Name = "lblElf";
            this.lblElf.Size = new System.Drawing.Size(109, 52);
            this.lblElf.TabIndex = 0;
            this.lblElf.Text = "Elf";
            this.lblElf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFinish
            // 
            this.lblFinish.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblFinish.Location = new System.Drawing.Point(738, 9);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(15, 307);
            this.lblFinish.TabIndex = 0;
            this.lblFinish.Text = "Finish";
            this.lblFinish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.Location = new System.Drawing.Point(12, 374);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(71, 64);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tmStart
            // 
            this.tmStart.Tick += new System.EventHandler(this.tmStart_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblElf);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblOrg);
            this.Controls.Add(this.lblHuman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Label lblOrg;
        private System.Windows.Forms.Label lblElf;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer tmStart;
    }
}


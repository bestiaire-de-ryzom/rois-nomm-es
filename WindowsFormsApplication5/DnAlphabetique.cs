using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class DnAlphabetique : Form
    {
        public DnAlphabetique()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DnAlphabetique));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DnACherkin = new System.Windows.Forms.Button();
            this.DnAFimpon = new System.Windows.Forms.Button();
            this.DnAGodgin = new System.Windows.Forms.Button();
            this.DnAKlops = new System.Windows.Forms.Button();
            this.DnANekothus = new System.Windows.Forms.Button();
            this.DnASkellop = new System.Windows.Forms.Button();
            this.DnATarron = new System.Windows.Forms.Button();
            this.DnATennyx = new System.Windows.Forms.Button();
            this.DnAMynion = new System.Windows.Forms.Button();
            this.DnANympton = new System.Windows.Forms.Button();
            this.DnAPakuh = new System.Windows.Forms.Button();
            this.DnAPoncha = new System.Windows.Forms.Button();
            this.DnAUtasha = new System.Windows.Forms.Button();
            this.DnAZorak = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nommés Désertique";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Niveau 210 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Niveau 260 :";
            // 
            // DnACherkin
            // 
            this.DnACherkin.Location = new System.Drawing.Point(50, 100);
            this.DnACherkin.Name = "DnACherkin";
            this.DnACherkin.Size = new System.Drawing.Size(80, 20);
            this.DnACherkin.TabIndex = 3;
            this.DnACherkin.Text = "Cherkin";
            this.DnACherkin.UseVisualStyleBackColor = true;
            // 
            // DnAFimpon
            // 
            this.DnAFimpon.Location = new System.Drawing.Point(50, 130);
            this.DnAFimpon.Name = "DnAFimpon";
            this.DnAFimpon.Size = new System.Drawing.Size(80, 20);
            this.DnAFimpon.TabIndex = 4;
            this.DnAFimpon.Text = "Fimpon";
            this.DnAFimpon.UseVisualStyleBackColor = true;
            // 
            // DnAGodgin
            // 
            this.DnAGodgin.Location = new System.Drawing.Point(50, 160);
            this.DnAGodgin.Name = "DnAGodgin";
            this.DnAGodgin.Size = new System.Drawing.Size(80, 20);
            this.DnAGodgin.TabIndex = 5;
            this.DnAGodgin.Text = "Godgin";
            this.DnAGodgin.UseVisualStyleBackColor = true;
            // 
            // DnAKlops
            // 
            this.DnAKlops.Location = new System.Drawing.Point(50, 190);
            this.DnAKlops.Name = "DnAKlops";
            this.DnAKlops.Size = new System.Drawing.Size(80, 20);
            this.DnAKlops.TabIndex = 6;
            this.DnAKlops.Text = "Klops";
            this.DnAKlops.UseVisualStyleBackColor = true;
            // 
            // DnANekothus
            // 
            this.DnANekothus.Location = new System.Drawing.Point(50, 220);
            this.DnANekothus.Name = "DnANekothus";
            this.DnANekothus.Size = new System.Drawing.Size(80, 20);
            this.DnANekothus.TabIndex = 7;
            this.DnANekothus.Text = "Nekothus";
            this.DnANekothus.UseVisualStyleBackColor = true;
            // 
            // DnASkellop
            // 
            this.DnASkellop.Location = new System.Drawing.Point(50, 250);
            this.DnASkellop.Name = "DnASkellop";
            this.DnASkellop.Size = new System.Drawing.Size(80, 20);
            this.DnASkellop.TabIndex = 8;
            this.DnASkellop.Text = "Skellop";
            this.DnASkellop.UseVisualStyleBackColor = true;
            // 
            // DnATarron
            // 
            this.DnATarron.Location = new System.Drawing.Point(50, 280);
            this.DnATarron.Name = "DnATarron";
            this.DnATarron.Size = new System.Drawing.Size(80, 20);
            this.DnATarron.TabIndex = 9;
            this.DnATarron.Text = "Tarron";
            this.DnATarron.UseVisualStyleBackColor = true;
            // 
            // DnATennyx
            // 
            this.DnATennyx.Location = new System.Drawing.Point(50, 310);
            this.DnATennyx.Name = "DnATennyx";
            this.DnATennyx.Size = new System.Drawing.Size(80, 20);
            this.DnATennyx.TabIndex = 10;
            this.DnATennyx.Text = "Tennyx";
            this.DnATennyx.UseVisualStyleBackColor = true;
            // 
            // DnAMynion
            // 
            this.DnAMynion.Location = new System.Drawing.Point(350, 100);
            this.DnAMynion.Name = "DnAMynion";
            this.DnAMynion.Size = new System.Drawing.Size(80, 20);
            this.DnAMynion.TabIndex = 11;
            this.DnAMynion.Text = "Mynion";
            this.DnAMynion.UseVisualStyleBackColor = true;
            // 
            // DnANympton
            // 
            this.DnANympton.Location = new System.Drawing.Point(350, 150);
            this.DnANympton.Name = "DnANympton";
            this.DnANympton.Size = new System.Drawing.Size(80, 20);
            this.DnANympton.TabIndex = 12;
            this.DnANympton.Text = "Nympton";
            this.DnANympton.UseVisualStyleBackColor = true;
            // 
            // DnAPakuh
            // 
            this.DnAPakuh.Location = new System.Drawing.Point(350, 200);
            this.DnAPakuh.Name = "DnAPakuh";
            this.DnAPakuh.Size = new System.Drawing.Size(80, 20);
            this.DnAPakuh.TabIndex = 13;
            this.DnAPakuh.Text = "Pakuh";
            this.DnAPakuh.UseVisualStyleBackColor = true;
            // 
            // DnAPoncha
            // 
            this.DnAPoncha.Location = new System.Drawing.Point(350, 250);
            this.DnAPoncha.Name = "DnAPoncha";
            this.DnAPoncha.Size = new System.Drawing.Size(80, 20);
            this.DnAPoncha.TabIndex = 14;
            this.DnAPoncha.Text = "Poncha";
            this.DnAPoncha.UseVisualStyleBackColor = true;
            // 
            // DnAUtasha
            // 
            this.DnAUtasha.Location = new System.Drawing.Point(350, 300);
            this.DnAUtasha.Name = "DnAUtasha";
            this.DnAUtasha.Size = new System.Drawing.Size(80, 20);
            this.DnAUtasha.TabIndex = 15;
            this.DnAUtasha.Text = "Utasha";
            this.DnAUtasha.UseVisualStyleBackColor = true;
            // 
            // DnAZorak
            // 
            this.DnAZorak.Location = new System.Drawing.Point(50, 340);
            this.DnAZorak.Name = "DnAZorak";
            this.DnAZorak.Size = new System.Drawing.Size(80, 20);
            this.DnAZorak.TabIndex = 16;
            this.DnAZorak.Text = "Zorak";
            this.DnAZorak.UseVisualStyleBackColor = true;
            // 
            // DnAlphabetique
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.DnAZorak);
            this.Controls.Add(this.DnAUtasha);
            this.Controls.Add(this.DnAPoncha);
            this.Controls.Add(this.DnAPakuh);
            this.Controls.Add(this.DnANympton);
            this.Controls.Add(this.DnAMynion);
            this.Controls.Add(this.DnATennyx);
            this.Controls.Add(this.DnATarron);
            this.Controls.Add(this.DnASkellop);
            this.Controls.Add(this.DnANekothus);
            this.Controls.Add(this.DnAKlops);
            this.Controls.Add(this.DnAGodgin);
            this.Controls.Add(this.DnAFimpon);
            this.Controls.Add(this.DnACherkin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DnAlphabetique";
            this.Text = "DnAlphabetique";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

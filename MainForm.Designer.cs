/*
 * Created by SharpDevelop.
 * User: alkom
 * Date: 06.05.2019
 * Time: 19:28
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Trainer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.fatBtn = new System.Windows.Forms.Button();
			this.fatBox = new System.Windows.Forms.TextBox();
			this.fatLbl = new System.Windows.Forms.Label();
			this.wantedBtn = new System.Windows.Forms.Button();
			this.wantedBox = new System.Windows.Forms.TextBox();
			this.wantedLbl = new System.Windows.Forms.Label();
			this.armorButton = new System.Windows.Forms.Button();
			this.armorBox = new System.Windows.Forms.TextBox();
			this.armorLbl = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.healthButton = new System.Windows.Forms.Button();
			this.healthBox = new System.Windows.Forms.TextBox();
			this.healthLbl = new System.Windows.Forms.Label();
			this.moneyButton = new System.Windows.Forms.Button();
			this.moneyBox = new System.Windows.Forms.TextBox();
			this.moneyLbl = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(743, 417);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.fatBtn);
			this.tabPage1.Controls.Add(this.fatBox);
			this.tabPage1.Controls.Add(this.fatLbl);
			this.tabPage1.Controls.Add(this.wantedBtn);
			this.tabPage1.Controls.Add(this.wantedBox);
			this.tabPage1.Controls.Add(this.wantedLbl);
			this.tabPage1.Controls.Add(this.armorButton);
			this.tabPage1.Controls.Add(this.armorBox);
			this.tabPage1.Controls.Add(this.armorLbl);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.healthButton);
			this.tabPage1.Controls.Add(this.healthBox);
			this.tabPage1.Controls.Add(this.healthLbl);
			this.tabPage1.Controls.Add(this.moneyButton);
			this.tabPage1.Controls.Add(this.moneyBox);
			this.tabPage1.Controls.Add(this.moneyLbl);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(735, 391);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Ped";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// fatBtn
			// 
			this.fatBtn.Location = new System.Drawing.Point(134, 193);
			this.fatBtn.Name = "fatBtn";
			this.fatBtn.Size = new System.Drawing.Size(103, 21);
			this.fatBtn.TabIndex = 15;
			this.fatBtn.Text = "Set fat level";
			this.fatBtn.UseVisualStyleBackColor = true;
			this.fatBtn.Click += new System.EventHandler(this.FatBtnClick);
			// 
			// fatBox
			// 
			this.fatBox.Location = new System.Drawing.Point(6, 193);
			this.fatBox.Name = "fatBox";
			this.fatBox.Size = new System.Drawing.Size(113, 20);
			this.fatBox.TabIndex = 14;
			// 
			// fatLbl
			// 
			this.fatLbl.Location = new System.Drawing.Point(6, 176);
			this.fatLbl.Name = "fatLbl";
			this.fatLbl.Size = new System.Drawing.Size(113, 14);
			this.fatLbl.TabIndex = 13;
			this.fatLbl.Text = "Fat level:";
			// 
			// wantedBtn
			// 
			this.wantedBtn.Enabled = false;
			this.wantedBtn.Location = new System.Drawing.Point(134, 152);
			this.wantedBtn.Name = "wantedBtn";
			this.wantedBtn.Size = new System.Drawing.Size(103, 21);
			this.wantedBtn.TabIndex = 12;
			this.wantedBtn.Text = "Set wanted level";
			this.wantedBtn.UseVisualStyleBackColor = true;
			// 
			// wantedBox
			// 
			this.wantedBox.Enabled = false;
			this.wantedBox.Location = new System.Drawing.Point(6, 153);
			this.wantedBox.Name = "wantedBox";
			this.wantedBox.Size = new System.Drawing.Size(113, 20);
			this.wantedBox.TabIndex = 11;
			// 
			// wantedLbl
			// 
			this.wantedLbl.Location = new System.Drawing.Point(6, 136);
			this.wantedLbl.Name = "wantedLbl";
			this.wantedLbl.Size = new System.Drawing.Size(113, 14);
			this.wantedLbl.TabIndex = 10;
			this.wantedLbl.Text = "Wanted Level:";
			// 
			// armorButton
			// 
			this.armorButton.Location = new System.Drawing.Point(134, 112);
			this.armorButton.Name = "armorButton";
			this.armorButton.Size = new System.Drawing.Size(103, 21);
			this.armorButton.TabIndex = 9;
			this.armorButton.Text = "Set armor";
			this.armorButton.UseVisualStyleBackColor = true;
			this.armorButton.Click += new System.EventHandler(this.ArmorButtonClick);
			// 
			// armorBox
			// 
			this.armorBox.Location = new System.Drawing.Point(6, 113);
			this.armorBox.Name = "armorBox";
			this.armorBox.Size = new System.Drawing.Size(113, 20);
			this.armorBox.TabIndex = 8;
			// 
			// armorLbl
			// 
			this.armorLbl.Location = new System.Drawing.Point(6, 96);
			this.armorLbl.Name = "armorLbl";
			this.armorLbl.Size = new System.Drawing.Size(113, 14);
			this.armorLbl.TabIndex = 7;
			this.armorLbl.Text = "Armor:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(49, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "General";
			// 
			// healthButton
			// 
			this.healthButton.Location = new System.Drawing.Point(134, 72);
			this.healthButton.Name = "healthButton";
			this.healthButton.Size = new System.Drawing.Size(103, 21);
			this.healthButton.TabIndex = 5;
			this.healthButton.Text = "Set health";
			this.healthButton.UseVisualStyleBackColor = true;
			this.healthButton.Click += new System.EventHandler(this.OnClickHealthChange);
			// 
			// healthBox
			// 
			this.healthBox.Location = new System.Drawing.Point(6, 73);
			this.healthBox.Name = "healthBox";
			this.healthBox.Size = new System.Drawing.Size(113, 20);
			this.healthBox.TabIndex = 4;
			// 
			// healthLbl
			// 
			this.healthLbl.Location = new System.Drawing.Point(6, 56);
			this.healthLbl.Name = "healthLbl";
			this.healthLbl.Size = new System.Drawing.Size(113, 14);
			this.healthLbl.TabIndex = 3;
			this.healthLbl.Text = "Health:";
			// 
			// moneyButton
			// 
			this.moneyButton.Location = new System.Drawing.Point(134, 32);
			this.moneyButton.Name = "moneyButton";
			this.moneyButton.Size = new System.Drawing.Size(103, 21);
			this.moneyButton.TabIndex = 2;
			this.moneyButton.Text = "Set money";
			this.moneyButton.UseVisualStyleBackColor = true;
			this.moneyButton.Click += new System.EventHandler(this.OnClickMoneyChange);
			// 
			// moneyBox
			// 
			this.moneyBox.Location = new System.Drawing.Point(6, 33);
			this.moneyBox.Name = "moneyBox";
			this.moneyBox.Size = new System.Drawing.Size(113, 20);
			this.moneyBox.TabIndex = 1;
			// 
			// moneyLbl
			// 
			this.moneyLbl.Location = new System.Drawing.Point(6, 16);
			this.moneyLbl.Name = "moneyLbl";
			this.moneyLbl.Size = new System.Drawing.Size(113, 14);
			this.moneyLbl.TabIndex = 0;
			this.moneyLbl.Text = "Money: ";
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(735, 391);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Vehicle";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 421);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "GTA SA Trainer";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label fatLbl;
		private System.Windows.Forms.TextBox fatBox;
		private System.Windows.Forms.Button fatBtn;
		private System.Windows.Forms.Label wantedLbl;
		private System.Windows.Forms.TextBox wantedBox;
		private System.Windows.Forms.Button wantedBtn;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label armorLbl;
		private System.Windows.Forms.TextBox armorBox;
		private System.Windows.Forms.Button armorButton;
		private System.Windows.Forms.Label healthLbl;
		private System.Windows.Forms.TextBox healthBox;
		private System.Windows.Forms.Button healthButton;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Label moneyLbl;
		private System.Windows.Forms.TextBox moneyBox;
		private System.Windows.Forms.Button moneyButton;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabControl tabControl1;
	}
}

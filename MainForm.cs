/*
 *	Author: FileEX
 * 	Class: MainClass
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Trainer
{	
	[Flags]
	public enum eMemAddress 
	{
		// static address
		Main = 0x0076F3B8,
		Money = 0x00B7CE50,
		WantedLevel = 0x00BAA420,
		Gravity = 0x00863984,
		GameSpeed = 0x00B7CB64,
		// offsets
		HealthOffset = 0x540,
		ArmorOffset = 0x548,
		//
		Stamina = 0x00B793D8,
		FatLevel = 0x00B793D4,
		Muscle = 0x00B793DC,
		Respect = 0x00B79480,
	}
	
	public partial class MainForm : Form
	{
		private Process pProc;
		private int pointer;
		
		// define const value
		private const int MAX_MONEY = 99999999;
		private const int MAX_HEALTH = 100;
		private const int MAX_ARMOR = 100;
		//private const int MAX_WANTEDLEVEL = 6;
		private const int MAX_FAT = 3000;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			if (Process.GetProcessesByName("gta_sa").Length == 0)
			{
				MessageBox.Show("GTA SA is not running", "Error");
				Application.Exit();
			}
			
			pProc = Process.GetProcessesByName("gta_sa")[0];
			pointer = (int)pProc.MainModule.BaseAddress + (int)eMemAddress.Main;
			
			// grab info from process
			int iCPedOffset = Convert.ToInt32(Mem.ReadMem(pProc, pointer, "int"));
			
			string strMoney = Mem.ReadMem(pProc, (int)eMemAddress.Money + 0x04, "long");
			moneyLbl.Text = "Money: " + strMoney + " $";
			
			string strHealth = Mem.ReadMem(pProc, iCPedOffset + (int)eMemAddress.HealthOffset, "float");
			healthLbl.Text = "Health: " + Math.Floor(Convert.ToDecimal(strHealth)).ToString() + " %";
			
			string strArmor = Mem.ReadMem(pProc, iCPedOffset + (int)eMemAddress.ArmorOffset, "float");
			armorLbl.Text = "Armor: " + strArmor + " %";
			
			string strWanted = Mem.ReadMem(pProc, (int)eMemAddress.WantedLevel, "int");
			wantedLbl.Text = "Wanted level: " + strWanted;
			
			string strFat = Mem.ReadMem(pProc, (int)eMemAddress.FatLevel, "float");
			fatLbl.Text = "Fat level: " + strFat;
		}
		
		private void OnClickMoneyChange(object sender, EventArgs e)
		{
			if (moneyBox.Text.Length > 0 && moneyBox.Text != " ")
			{
				long lMoneyValue = (long)Convert.ToInt64(moneyBox.Text);
				if (lMoneyValue >= 0 && lMoneyValue <= MAX_MONEY)
				{
					Mem.WriteMemInt64(pProc, (int)eMemAddress.Money, lMoneyValue);
					Mem.WriteMemInt64(pProc, (int)eMemAddress.Money + 0x04, lMoneyValue); // write add value for read later
					moneyLbl.Text = "Money: " + lMoneyValue.ToString() + " $";
				}
			}
		}
		
		private void OnClickHealthChange(object sender, EventArgs e)
		{
			if (healthBox.Text.Length > 0 && healthBox.Text != " ")
			{
				float fHealth = (float)Convert.ToSingle(healthBox.Text);
				if (fHealth >= 0 && fHealth <= MAX_HEALTH)
				{
					string strMatchOffset = Mem.ReadMem(pProc, pointer, "int");
					int iOffset = (int)Convert.ToInt32(strMatchOffset);
					
					Mem.WriteMemFloat(pProc, iOffset + (int)eMemAddress.HealthOffset, fHealth);
					healthLbl.Text = "Health: " + fHealth.ToString() + " %";
				}
			}
		}
		
		private void ArmorButtonClick(object sender, EventArgs e)
		{
			if (armorBox.Text.Length > 0 && armorBox.Text != " ")
			{
				float fArmor = (float)Convert.ToSingle(armorBox.Text);
				if (fArmor >= 0 && fArmor <= MAX_ARMOR)
				{
					string strMatchOffset = Mem.ReadMem(pProc, pointer, "int");
					int iOffset = (int)Convert.ToInt32(strMatchOffset);
					
					Mem.WriteMemFloat(pProc, iOffset + (int)eMemAddress.ArmorOffset, fArmor);
					armorLbl.Text = "Armor: " + fArmor.ToString() + " %";
				}
			}
		}
		/* TODO
		void WantedBtnClick(object sender, EventArgs e)
		{
			if (wantedBox.Text.Length > 0 && wantedBox.Text != " ")
			{
				uint iWanted = (uint)Convert.ToUInt16(wantedBox.Text);
				if (iWanted >= 0 && iWanted <= MAX_WANTEDLEVEL)
				{
					
					wantedLbl.Text = "Wanted level: " + iWanted.ToString();
				}
			}
		}*/
		
		void FatBtnClick(object sender, EventArgs e)
		{
			if (fatBox.Text.Length > 0 && fatBox.Text != " ")
			{
				float fFat  = (float)Convert.ToSingle(fatBox.Text);
				if (fFat >= 0 && fFat <= MAX_FAT)
				{
					Mem.WriteMemFloat(pProc, (int)eMemAddress.FatLevel, fFat);
					fatLbl.Text = "Fat level: " + fFat.ToString();
				}
			}
		}
	}
}

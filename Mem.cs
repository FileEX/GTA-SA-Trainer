/*
 *	Author: FileEX
 * 	Class: Memory
 */
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text;

namespace Trainer
{
	public partial class Mem
	{
		// Initalize lib
			[DllImport("kernel32.dll")]
			protected static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);
				
			[DllImport("kernel32.dll")]
   	 		protected static extern bool ReadProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, int bytesRead);
				
			[DllImport("kernel32.dll", SetLastError = true)]
			protected static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress, byte[] lpBuffer, int dwSize, int bytesWrite);
				
			[DllImport("kernel32.dll")]
			protected static extern Int32 CloseHandle(int hProcess);
		//
		public Mem()
		{
			// constructor
		}
		
		private static string convertDataFromType(string type, byte[] buffer)
		{
			string data = "";
			
			switch(type) {
				case "long":
					data = BitConverter.ToInt64(buffer, 0).ToString();
				break;
				case "float":
					data = BitConverter.ToSingle(buffer, 0).ToString();
				break;
				case "int":
					data = BitConverter.ToInt32(buffer, 0).ToString();
				break;
			}
			
			return data;
		}
		
		public static void WriteMemInt64(Process proc, int address, long val)
		{
			var hProc = OpenProcess(0x001F0FFF, false, (int)proc.Id);
			byte[] buff = BitConverter.GetBytes(val);
			
			WriteProcessMemory((int)hProc, address, buff, 8, 0);
			
			CloseHandle((int)hProc);
		}
		
		public static void WriteMemInt32(Process proc, int address, uint val)
		{
			var hProc = OpenProcess(0x001F0FFF, false, (int)proc.Id);
			byte[] buff = BitConverter.GetBytes(val);
			
			WriteProcessMemory((int)hProc, address, buff, 4, 0);
			
			CloseHandle((int)hProc);
		}
		
		public static void WriteMemFloat(Process proc, int address, float val)
		{
			var hProc = OpenProcess(0x001F0FFF, false, (int)proc.Id);
			byte[] buff = BitConverter.GetBytes(val);
			
			WriteProcessMemory((int)hProc, address, buff, 4, 0);
			
			CloseHandle((int)hProc);
		}
		
		public static string ReadMem(Process proc, int address, string readType)
		{
			IntPtr hnd = OpenProcess(0x001F0FFF, false, proc.Id);
			
			byte[] buff = new byte[0];
			
			switch(readType) {
				case "long":
					buff = new byte[8];
				break;
				case "float":
					buff = new byte[4];
				break;
				case "int":
					buff = new byte[4];
				break;
			}
			
			ReadProcessMemory((int)hnd, address, buff, buff.Length, 0);
			
			CloseHandle((int)hnd);
			
			return convertDataFromType(readType, buff);
		}
	}
}

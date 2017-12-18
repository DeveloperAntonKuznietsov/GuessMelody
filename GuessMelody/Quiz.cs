using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace GuessMelody
{
	static class Quiz
	{
		static public List<string> list = new List<string>();
		static public int gameDuration = 60;
		static public int musicDuration = 10;
		static public bool randomStart = false;
		static public string lastFolder = "";
		static public bool allDirectory = false;


		static public void ReadMusic()
		{
			try
			{
				string[] music_files = Directory.GetFiles(lastFolder, "*.mp3", allDirectory ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
				list.Clear();
				list.AddRange(music_files);

			}
			catch
			{
			}
			
		}

		static string regKeyName = "Softeare\\MyCompany\\GuessMelody";

		public static void WriteParam()
		{
			RegistryKey rk = null;
			try
			{
				rk = Registry.CurrentUser.CreateSubKey(regKeyName);
				if (rk == null) return;
				rk.SetValue("LastFolder", lastFolder);
				rk.SetValue("RandomStart", randomStart);
				rk.SetValue("GameDuration", gameDuration);
				rk.SetValue("MusicDurarion", musicDuration);
				rk.SetValue("AllDirectories", allDirectory);
			}
			finally 
			{

				if (rk != null) rk.Close();
			}
		}
		public static void ReadParam()
		{
			RegistryKey rk = null;
			try
			{
				rk = Registry.CurrentUser.OpenSubKey(regKeyName);
				if (rk != null)
				{
					lastFolder = (string)rk.GetValue("LastFolder");
					gameDuration = (int)rk.GetValue("GameDuration");
					randomStart = Convert.ToBoolean(rk.GetValue("RandomStart", false));
					musicDuration = (int)rk.GetValue("MusicDurarion");
					allDirectory = Convert.ToBoolean(rk.GetValue("AllDirectories"));
				}
			}
			finally 
			{

				if (rk != null) rk.Close();
			}
		}

	}
}

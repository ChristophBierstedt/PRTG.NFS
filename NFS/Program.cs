// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

string str;
long avail = 0;
long total = 0;
double prozent = 0;
string value;


		DriveInfo driveInfo = new DriveInfo(args[0]);
		string str1 = args[1];
		if (driveInfo.IsReady)
		{
			avail = driveInfo.AvailableFreeSpace;
			total = driveInfo.TotalSize;
		}
		else Console.WriteLine("2:ERROR CONFIG WRONG");


		prozent = avail / (double)total * 100;
		if (prozent < 5)
		{
			value = "2:FULL DISC:";
			Console.WriteLine(value + Math.Round(prozent, 0));
	
		}
		else if (prozent < 15)
		{
			value = "1:DISC FREE LOW:";
			Console.WriteLine(value + Math.Round(prozent, 0));

		}
		else
		{
			Console.WriteLine ("0:OK:" + Math.Round(prozent, 0));
			
		}

	


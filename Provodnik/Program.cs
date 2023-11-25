using Provodnik;
using System.IO;

DriveInfo[] Drives = DriveInfo.GetDrives();
string[] Drivs = new string[20];
ConsoleKeyInfo click2;
int posit;
string dirName;
do
{
    int maxStrelochka = 3, r = 0;
    Console.Clear();
    Console.WriteLine("                      Этот компьютер");
    Console.WriteLine("-------------------------------------------------------------------------");
    Console.SetCursorPosition(65, 3);
    Console.WriteLine("F10 - Выход из программы");
    Console.SetCursorPosition(65, 4);
    Console.WriteLine("| ----------------------");
    Console.SetCursorPosition(0, 3);
    foreach (DriveInfo drive in Drives)
    {
        Console.WriteLine($"   {drive.Name} {drive.AvailableFreeSpace / 1073741824} ГБ свободно из {drive.TotalSize / 1073741824} ГБ Метка диска: {drive.VolumeLabel}");
        maxStrelochka++;
        Drivs[r] = drive.Name;
        r++;
    }
    Strelka.Show(3, maxStrelochka - 1, out posit, out click2);
    if (click2.Key == ConsoleKey.Enter)
    {
        dirName = Drivs[posit - 3];
        GetDir.Drive(dirName, out click2);
    }
    Console.Clear();
}
while (click2.Key != ConsoleKey.F10);


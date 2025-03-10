using System;
using System.IO;
using System.Runtime.InteropServices;
using IWshRuntimeLibrary;
using UnityEngine;
using File = System.IO.File;

namespace MFramework.UnityApplication
{
    public static class ApplicationUtility
    {
        [DllImport("user32.dll")]
        private static extern IntPtr GetActiveWindow();

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetWindowPos(IntPtr windowHandle, int zOrder, int x, int y, int width, int height,
            uint flags);

        private const int Z_ORDER_TOPMOST = -1;
        private const int Z_ORDER_NO_TOPMOST = -2;
        private const uint WINDOW_NOT_MOVE = 0x0002;
        private const uint WINDOW_NOT_CHANGE_SIZE = 0x0001;


        public static string applicationDirectory => Path.GetDirectoryName(Application.dataPath);
        public static string applicationPath => $"{applicationDirectory}\\{Application.productName}.exe";

        public static string desktopShortcutPath =>
            Path.Combine(desktopPath, $"{Application.productName}.exe - 快捷方式.lnk");

        public static string startupShortcutPath =>
            Path.Combine(startupPath, $"{Application.productName}.exe - 快捷方式.lnk");

        public static string desktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public static string localDesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
        public static string startupPath => Environment.GetFolderPath(Environment.SpecialFolder.Startup);
        public static string programsPath => Environment.GetFolderPath(Environment.SpecialFolder.Programs);
        public static string localPath => Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

        public static string localLowPath =>
            $"{Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)}Low";

        public static string roamingPath => Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        public static string windowsPath => Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        public static string systemPath => Environment.GetFolderPath(Environment.SpecialFolder.System);
        public static string systemX86Path => Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
        public static string programFilesPath => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);

        public static string playerLogPath =>
            $"{localLowPath}\\{Application.companyName}\\{Application.productName}\\Player.log";

        public static string playerLogCollectDirectory => Path.Combine(applicationDirectory, "RuntimeLogs");
        public static string consoleLogPath => Application.consoleLogPath;

        public static string programFilesX86Path => Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);

        public static DirectoryInfo CreateLocalDirectory(string directoryName)
        {
            return Directory.CreateDirectory($"{localPath}\\{directoryName}");
        }

        public static DirectoryInfo CreateLocalLowDirectory(string directoryName)
        {
            return Directory.CreateDirectory($"{localLowPath}\\{directoryName}");
        }

        public static DirectoryInfo CreateRoamingDirectory(string directoryName)
        {
            return Directory.CreateDirectory($"{roamingPath}\\{directoryName}");
        }

        public static DirectoryInfo CreateDesktopDirectory(string directoryName)
        {
            return Directory.CreateDirectory($"{desktopPath}\\{directoryName}");
        }

        public static DirectoryInfo CreateLocalDesktopDirectory(string directoryName)
        {
            return Directory.CreateDirectory($"{localDesktopPath}\\{directoryName}");
        }

        public static DirectoryInfo CreateApplicationDirectory(string directoryName)
        {
            return Directory.CreateDirectory($"{applicationPath}\\{directoryName}");
        }

        public static DirectoryInfo CreateProgramFilesDirectory(string directoryName)
        {
            return Directory.CreateDirectory($"{programFilesPath}\\{directoryName}");
        }

        public static DirectoryInfo CreateProgramFilesX86Directory(string directoryName)
        {
            return Directory.CreateDirectory($"{programFilesX86Path}\\{directoryName}");
        }

        public static string GetSpecialFolder(Environment.SpecialFolder specialFolder)
        {
            return Environment.GetFolderPath(specialFolder);
        }

        public static void CreateDesktopShortcut()
        {
            if (File.Exists(desktopShortcutPath)) return;
            CreateShortcut(applicationPath, desktopShortcutPath);
        }

        public static void DeleteDesktopShortcut()
        {
            if (File.Exists(desktopShortcutPath)) File.Delete(desktopShortcutPath);
        }

        public static void CreateStartupShortcut()
        {
            if (File.Exists(startupShortcutPath)) return;
            CreateShortcut(applicationPath, startupShortcutPath);
        }

        public static void DeleteStartupShortcut()
        {
            if (File.Exists(desktopShortcutPath)) File.Delete(startupShortcutPath);
        }

        public static void CreateShortcut(string targetPath, string shortcutPath)
        {
            IWshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
            shortcut.TargetPath = targetPath;
            shortcut.Save();
        }

        public static void CreateShortcut(string targetPath, DirectoryInfo directory)
        {
            FileInfo targetFileInfo = new FileInfo(targetPath);
            IWshShell shell = new WshShell();
            IWshShortcut shortcut =
                (IWshShortcut)shell.CreateShortcut($"{directory.FullName}\\{targetFileInfo.Name} - 快捷方式.lnk");
            shortcut.TargetPath = targetPath;
            shortcut.Save();
        }

        public static void CreateShortcut(FileInfo targetFileInfo, DirectoryInfo shortcutDirectoryInfo)
        {
            IWshShell shell = new WshShell();
            IWshShortcut shortcut =
                (IWshShortcut)shell.CreateShortcut(
                    $"{shortcutDirectoryInfo.FullName}\\{targetFileInfo.Name} - 快捷方式.lnk");
            shortcut.TargetPath = targetFileInfo.FullName;
            shortcut.Save();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace BusinessLogicLayer
{
    public class FileWorker
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public bool CreateFolder(string path)
        {
            if (!Directory.Exists(path))
            {
                try
                {
                    Directory.CreateDirectory(path);
                }
                catch (IOException ex)
                {
                    throw ex;
                }
                catch (UnauthorizedAccessException ex)
                {
                    throw ex;
                }
            }
            return true;
        }

        /// <summary>
        /// Name of folders with reports.
        /// </summary>
        public enum ReportsFolders
        {
            DeductibleStudent,
            SessionResult,
        }

        /// <summary>
        /// Open folder
        /// </summary>
        /// <param name="path"></param>
        public void OpenFolder(string path)
        {
            Process.Start(new ProcessStartInfo("explorer.exe", "/open, " + path));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public static void DeleteFileIfExists(string path)
        {
            if (File.Exists(path))//Удаляем
            {
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="path"></param>
        public void DeleteFolderIfExists(string path)
        {
            if (Directory.Exists(path))//Удаляем
            {
                try
                {
                    Directory.Delete(path);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

using Study.LogUtil;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study.IOUtil
{
    /// <summary>
    /// 文件帮助类
    /// </summary>
    public class FileHelper
    {
        /// <summary>
        /// 获取文件夹下所有文件
        /// </summary>
        /// <param name="directory">文件件路径</param>
        /// <returns></returns>
        public static FileInfo[] GetAllFile(string directory)
        {
            try
            {
                DirectoryInfo root = new DirectoryInfo(directory);
                FileInfo[] files = root.GetFiles();
                return files;
            }
            catch (DirectoryNotFoundException ex)
            {
                Log4Helper.Error(typeof(FileHelper),ex.Message, ex);
                return null;
            }
        }
        /// <summary>
        /// 创建文件夹
        /// </summary>
        /// <param name="directory">文件夹路径</param>
        /// <returns>是否创建成功</returns>
        public static bool CreateDirectory(string directory)
        {
            try
            {
                if(!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                return true;
            }
            catch (IOException ex)
            {
                Log4Helper.Error(typeof(FileHelper), ex.Message, ex);
                return false;
            }
        }
        /// <summary>
        /// 删除文件夹以及文件夹下所有文件
        /// </summary>
        /// <param name="directory">文件夹路径</param>
        public static void DeleteDirectory(string directory)
        {
            try
            {
                if (Directory.Exists(directory))
                {
                    DirectoryInfo dir = new DirectoryInfo(directory);
                    FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                    foreach (FileSystemInfo i in fileinfo)
                    {
                        if (i is DirectoryInfo)            //判断是否文件夹
                        {
                            DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                            subdir.Delete(true);          //删除子目录和文件
                        }
                        else
                        {
                            File.Delete(i.FullName);      //删除指定文件
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Log4Helper.Error(typeof(FileHelper), ex.Message, ex);
            }
        }
        /// <summary>
        /// 删除文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        public static bool DeleteFile(string filePath)
        {
            try
            {
                if(File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                return true;
            }
            catch (IOException ex)
            {
                Log4Helper.Error(typeof(FileHelper), ex.Message, ex);
                return false;
            }
        }
    }
}

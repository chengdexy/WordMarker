using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WordMarker
{
    //
    // 读写ini文件以保存软件配置信息
    //
    class OperIni
    {
        /// <summary>
        /// 写操作
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string value, string filePath);

        /// <summary>
        /// 读操作
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="defValue">未读取到时的默认值</param>
        /// <param name="retvalue">读取到的值</param>
        /// <param name="size">大小</param>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string defValue, StringBuilder retvalue, int size, string filepath);

        /// <summary>
        /// 读取ini文件
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="filepath">文件路径</param>
        /// <returns></returns>
        public static string ReadIni(string section, string key, string filepath)
        {
            StringBuilder retValue = new StringBuilder(500);
            int i = GetPrivateProfileString(section, key, null, retValue, 500, filepath);
            return retValue.ToString();
        }

        /// <summary>
        /// 写入ini文件
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="value">值</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static long WriteIni(string section, string key, string value, string filePath)
        {
            return WritePrivateProfileString(section, key, value, filePath);
        }

        /// <summary>
        /// 删除节
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static long DeleteSection(string section, string filePath)
        {
            return WritePrivateProfileString(section, null, null, filePath);
        }

        /// <summary>
        /// 删除键
        /// </summary>
        /// <param name="section">节</param>
        /// <param name="key">键</param>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static long DeleteKey(string section, string key, string filePath)
        {
            return WritePrivateProfileString(section, key, null, filePath);
        }


    }
}

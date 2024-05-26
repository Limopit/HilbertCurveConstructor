using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace HilbertCurveConstructor.Logic
{
    public class INIManager
    {
        string path;

        [DllImport("kernel32")]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32")]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal,
            int Size, string FilePath);

        public INIManager(string IniPath)
        {
            path = new FileInfo(IniPath).FullName.ToString();
        }

        public string ReadINI(string Section, string Key)
        {
            var buffer = new StringBuilder(255);
            GetPrivateProfileString(Section, Key, "", buffer, 255, path);
            return buffer.ToString();
        }

        public void Write(string Section, string Key, string Value)
        {
            WritePrivateProfileString(Section, Key, Value, path);
        }
    }
}
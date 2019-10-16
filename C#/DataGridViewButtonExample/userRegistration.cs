using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS20192
{
    public class userRegistration
    {
        FileInfo file;
        public bool register(userInfo userInfo)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\apsImage";
            bool exists = false;
            if (Directory.Exists(path))
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                file = new FileInfo(userInfo.FileName);
                string fileName = path + "\\" + userInfo.Code + ".png";

                foreach (FileInfo files in dirInfo.GetFiles())
                {
                    string fullName = files.Name;
                    string codeName = fullName.Substring(0, 6);

                    if (userInfo.Code == codeName)
                    {
                        exists = true;
                        break;
                    }
                    else
                    {
                        exists = false;
                    }
                }
                if (exists)
                {
                    return true;
                }
                else
                {
                    file.CopyTo(path + "\\" + userInfo.Code + "1" + ".png");
                    return false;
                }
            }
            else
            {
                Directory.CreateDirectory(path);
                register(userInfo);
            }
            return true;     
        }

    }
}

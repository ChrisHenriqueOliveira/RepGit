using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS20192
{
    public class userInfo
    {

        private string name;
        private string code;
        private string accessLevel;
        private string fileName;

        public string Name { get => name; set => name = value; }
        public string Code { get => code; set => code = value; }
        public string FileName { get => fileName; set => fileName = value; }
        public string AccessLevel { get => accessLevel; set => accessLevel = value; }
    }
}

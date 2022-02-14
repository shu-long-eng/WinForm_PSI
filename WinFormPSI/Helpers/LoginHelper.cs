
using System.Collections.Generic;
using System.Linq;
using WinFormPSI.Model;

namespace WinFormPSI.Helpers
{
    class LoginHelper
    {

        static List<LoginInfo> list = new List<LoginInfo>();
        public static bool TryLogin(string Account, string Pwd)
        {
            

            //讀取DB以及檢查帳號密碼是否正確/存在
            using (var context = new PSIsystemModel())
            {

                var query = context.Users
                    .Where(item => item.Account == Account)
                    .Select(item => new {
                        ID = item.ID,
                        Name = item.Name,
                        Level = item.Level,
                        PWD = item.PWD
                    });

              


                if (query.FirstOrDefault() == null ||
                    string.Compare(Pwd.Trim(), query.FirstOrDefault().PWD.Trim(), false) != 0)
                    return false;

                list.Add(new LoginInfo()
                {
                    ID = query.FirstOrDefault().ID.ToString(),
                    Name = query.FirstOrDefault().Name.ToString(),
                    Level = (int)query.FirstOrDefault().Level
                });
            }
            return true;

        }

        public static List<LoginInfo> GetLoginInfo()
        {
            return list;
        }



    }
}

namespace Lab250227_MVC
{
    public class AccountData
    {
        public string UserName { get; set; }
        public string UserSex { get; set; }
        public string UserAddr { get; set; }

        public AccountData()
        {
            UserName = string.Empty;
            UserSex = string.Empty;
            UserAddr = string.Empty;
        }

        public AccountData(string _UserName, string _UserSex,string _UserAddr)
        {
            UserName = _UserName;
            UserSex = _UserSex;
            UserAddr = _UserAddr;
        }
    }
}

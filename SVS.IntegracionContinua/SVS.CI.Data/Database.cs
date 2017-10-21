namespace SVS.CI.Data
{
    public class Database
    {
        public static bool TestConnection(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

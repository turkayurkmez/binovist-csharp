namespace StaticKeyword
{
    public class DataHelper
    {
        public string DataProvider { get; set; }
        public static int InstanceCount { get; set; }
        public DataHelper()
        {
            if (InstanceCount >= 3)
            {
                throw new Exception("Bu nesneden 3'den fazla yapamazsınız!");
            }
            InstanceCount++;
        }
    }
}

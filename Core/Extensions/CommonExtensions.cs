namespace Core.Extensions
{
    public static class CommonExtensions
    {
        public static string GetStaticContentDirectory()
        {
            
            var result = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Uploads");
            if (!Directory.Exists(result))
            {
                Directory.CreateDirectory(result);
            }
            return result;
        }

        public static string GetFilePath(string fileName)
        {
            var getStaticContentDirectory = GetStaticContentDirectory();
            var result = Path.Combine(getStaticContentDirectory, fileName);
            return result;
        }
    }
}

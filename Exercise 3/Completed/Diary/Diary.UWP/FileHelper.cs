namespace Diary.UWP
{
    public class FileHelper
    {
        public static string GetLocalStoragePath()
        {
            return Windows.Storage.ApplicationData.Current.LocalFolder.Path;
        }
    }
}
namespace Batch16InMemoryMVC.Data
{
    public class FileContext 
    {
        string path = @"C:\Users\user\Desktop\Batch16InMemoryMVC\Files";

        public void CreateFolder()
        {
            Directory.CreateDirectory(path);
            var fileName = "Products.txt";
            var file = Path.Combine(path, fileName);
            File.Create(file);
        }
    }
}

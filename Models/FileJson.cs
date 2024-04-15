using System.IO;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public class FileJson
    {
        public string Path { get; set; } // => Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DanePetlaKontrolna\WadyJakoscioweImpact";
        public string JsonFile { get; set; } //@"\MainDeffects.json";


        public bool CheckExistJsonFile(string path, string file)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            if (File.Exists(path + file))
                return true;

            return false;
        }
        public T DeserializeFromFile<T>(string path, string file)
        {
            if (CheckExistJsonFile(path, file))
            {
                var reader = File.ReadAllText(path + file);

                //MemoryStream stream = new MemoryStream(Encoding.ASCII.GetBytes(reader));

                return JsonSerializer.Deserialize<T>(reader);
            }

            return default;
        }

        public async Task<T> DeserializeFromFileAsync<T>(string path, string file)
        {
            if (CheckExistJsonFile(path, file))
            {
                var reader = File.ReadAllText(path + file);

                MemoryStream stream = new MemoryStream(Encoding.ASCII.GetBytes(reader));

                return await JsonSerializer.DeserializeAsync<T>(stream);
            }

            return default;
        }

        public async Task<T> SerializerToFileAsync<T>(T data, string path, string file)
        {
            await SaveJsonFileAsync(path + file, data);
            return data;
        }

        private async Task SaveJsonFileAsync<T>(string pathFile, T data)
        {
            using (var stream = File.Create(pathFile))
            {
                await JsonSerializer.SerializeAsync(stream, data);
                stream.Dispose();
            }
        }
    }
}

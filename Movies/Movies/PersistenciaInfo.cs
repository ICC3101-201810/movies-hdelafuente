using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Movies
{
    static class PersistenciaInfo<T>
    {
        public static void Serialize_Product(string file_name, T lista)
        {
            string file = @"..\..\" + file_name;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
                using (Stream stream = File.Open(path, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, lista);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public static T Deserialize_Product(string file_name)
        {
            T output;
            string file = @"..\..\" + file_name;
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, file);
                using (Stream stream = File.Open(path, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    output = (T)bin.Deserialize(stream);
                }
                return output;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return default(T);
            }

        }
    }
}

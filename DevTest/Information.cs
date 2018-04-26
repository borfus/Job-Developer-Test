using System;
using System.IO;

namespace DevTest
{
    [Serializable]
    public abstract class Information<T>
    {
        static Object typeParameterType = typeof(T);
        public string Id { get; set; }
        static string directory = "Files\\"; // Swap for current directory of files. Current test directory is "DevTest\DevTest\bin\Debug\Files"

        // Searches for object in file directory and returns it if it exists. Returns null if does not exist.
        public static T Find(string id)
        {
            try
            {
                string fileName = directory + id + " " + typeParameterType.ToString();
                if (File.Exists(fileName))
                {
                    return Filing.ReadFromBinaryFile<T>(fileName);
                }
                else
                {
                    return default(T);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Find method failed\n\n" + ex.ToString());
                return default(T);
            }
        }

        // Saves this object into file directory. Assigns Id to this object.
        public void Save()
        {
            try
            {
                id();
                Object t = this;
                string fileName = directory + Id + " " + typeParameterType.ToString();
                if (!File.Exists(fileName))
                {
                    Filing.WriteToBinaryFile<Object>(fileName, t); //TODO: figure out how to save an object that has parameters in the constructor
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Save method failed\n\n" + ex.ToString());
            }
        }

        // Deletes the file from the directory if it exists. Sets Id to null.
        public void Delete()
        {
            string fileName = directory + Id + " " + typeParameterType.ToString();
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            Id = null;
        }

        // Method used to set Id of this object. Searches directory to make sure the current Id is not already in use.
        public void id()
        {
            int fCount = Directory.GetFiles(directory, "*", SearchOption.TopDirectoryOnly).Length;

            int i = 0;
            string fileName = directory + i.ToString() + " " + typeParameterType.ToString();
            while (i < fCount)
            {
                if (!File.Exists(fileName))
                {
                    Id = i.ToString();
                    return;
                }
                i++;
            }
            Id = i.ToString();
        }
    }
}

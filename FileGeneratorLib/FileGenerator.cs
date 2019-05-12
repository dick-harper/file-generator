using System;
using System.IO;

namespace FileGeneratorLib
{
    public class FileGenerator
    {
        string _rootDirectory;
        public FileGenerator(string rootDirectory)
        {
            if(string.IsNullOrWhiteSpace(rootDirectory)){
                throw new Exception("invalid root directory");
            }

            if(Directory.Exists(_rootDirectory)){
                throw new DirectoryNotFoundException(_rootDirectory);
            }

            _rootDirectory = rootDirectory;
        }
    }
}

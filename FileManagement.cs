using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace DbD_MiniMap
{
    static internal class FileManagement
    {
        private static readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\config.ini";
        static public void CreateFile()
        {
            if (!File.Exists(path))
            {
                var f = File.Create(path);
                f.Close();
                DefaultContent();
            }
        }

        static public void DefaultContent()
        {
            if (File.Exists(path))
            {
                string text = "LocationX: 0" + Environment.NewLine + "LocationY: 0" + Environment.NewLine + "Size: 200";

                File.WriteAllText(path, text);
            }
            else
            {
                CreateFile();
            }
        }

        static public string ReadFile()
        {
            if (File.Exists(path))
            {
                return File.ReadAllText(path);
            }
            else
            {
                CreateFile();
                return ReadFile();
            }
        }

        static public string[] ReadAllLinesFile()
        {
            if (File.Exists(path))
            {
                return File.ReadAllLines(path);
            }
            else
            {
                CreateFile();
                return ReadAllLinesFile();
            }
        }

        static public string GetValue(string text)
        {
            for (int i = 0; i < ReadAllLinesFile().Count(); i++)
            {
                if (ReadAllLinesFile()[i].Contains(text))
                {
                    return Regex.Match(ReadAllLinesFile()[i], @"-?\d+").Value;
                }
            }
            return "";
        }

        static public void SaveTextInFile(string text, string value)
        {
            bool exists = false;
            int index = 0;
            for (int i = 0; i < ReadAllLinesFile().Count(); i++)
            {
                if (ReadAllLinesFile()[i].Contains(text))
                {
                    exists = true;
                    index = i;
                }
            }

            if (!exists)
            {
                File.WriteAllText(path, text);
            }
            else
            {
                text = ReadFile().Replace(ReadAllLinesFile()[index], text + value);
                File.WriteAllText(path, text);
            }
        }

        static public void CreateDirectory()
        {
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap") || !Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps");
            }
        }

        static public bool CopyImage(string filePath)
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps"))
            {
                if(!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + GetFileName(filePath)))
                {
                    File.Copy(filePath, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + GetFileName(filePath));
                    return true;
                }
                return false;
            }
            else
            {
                CreateDirectory();
                if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + GetFileName(filePath)))
                {
                    File.Copy(filePath, Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + GetFileName(filePath));
                    return true;
                }
                return false;
            }
        }

        static public bool DeleteImage(string fileName)
        {
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps"))
            {
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + fileName))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + fileName);
                    return true;
                }
                MessageBox.Show(fileName);
                return false;
            }
            else
            {
                CreateDirectory();
                if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + fileName))
                {
                    File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps\" + fileName);
                    return true;
                }
                return false;
            }
        }

        static public string GetFileName(string path)
        {
            int index = 0;
            for (int i = path.Length - 1; i >= 0; i--)
            {
                if (path[i].ToString() == @"\")
                {
                    index = i+1;
                    break;
                }
            }

            string fileName = "";
            for (int i = index; i < path.Length; i++)
            {
                fileName += path[i];
            }
            return fileName;
        }

        static public List<string> GetImages(string path)
        {
            List<string> paths = new List<string>();
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\DbD MiniMap\Maps"))
            {
                List<string> images = new List<string>();
                images = Directory.GetFiles(path).ToList();
                List<string> formats = new(){ ".jpg", ".jpeg", ".png", ".gif", ".tif"};

                foreach (string image in images)
                {
                    foreach(var format in formats)
                    {
                        if(image.ToLower().Contains(format.ToLower()))
                        {
                            paths.Add(image);
                        }
                    }
                }

                return paths;
            }
            else
            {
                CreateDirectory();
                List<string> images = new List<string>();
                images = Directory.GetFiles(path).ToList();

                foreach (string image in images)
                {
                    foreach (var format in Enum.GetValues(typeof(ImageFormat)))
                    {
                        if (Image.FromFile(path).RawFormat.Equals(format))
                        {
                            paths.Add(image);
                        }
                    }
                }

                return paths;
            }
        }
    }
}

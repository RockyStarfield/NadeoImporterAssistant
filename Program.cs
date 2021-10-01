using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;
using System.Diagnostics;

namespace NadeoImporter
{
    public static class Nadeo
    {
        public static List<String> mat_lib = new List<String>();
    }

    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>


        [STAThread]
        static void Main()
        {

            if (File.Exists("NadeoImporterMaterialLib.txt"))
            {
                using (StreamReader mat_file = new StreamReader("NadeoImporterMaterialLib.txt"))
                {
                    string line;
                    while ((line = mat_file.ReadLine()) != null)
                    {
                        if (line.Contains("DMaterial"))
                        {
                            Nadeo.mat_lib.Add(line.Split('(', ')')[1]);
                        }
                    }

                }
            }
            else
            {
                Throw("Cannot find MaterialLib\nMake sure you are running this from the same folder as Nadeo Importer", 1);
                return;
            }


            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }

        public static void SavePreset(List<string[]> mats, string[] props, bool[] props_b)
        {
            SaveFileDialog diag = new SaveFileDialog();

            diag.Filter = "Importer Presets|*.preset";
            diag.RestoreDirectory = true;

            if (diag.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter preset = new StreamWriter(diag.FileName))
                {
                    preset.WriteLine("MatStart");

                    foreach (string[] mat in mats)
                    {
                        preset.WriteLine(mat[0] + "\t" + mat[1] + "\t" + mat[2]);
                    }

                    preset.WriteLine("MatEnd");

                    foreach(bool propb in props_b)
                    {
                        preset.WriteLine(Convert.ToInt32(propb));
                    }

                    foreach (string prop in props)
                    {
                        preset.WriteLine(prop);

                    }

                    preset.Close();


                }
            }
        }
 
        public static List<string[]> LoadPresetMat(string file)
        {
            if (File.Exists(file))    
            {
  
                using (StreamReader preset = new StreamReader(file))
                {
                    List<string[]> mats = new List<string[]>();

                    string line;

                    preset.ReadLine();

                    while ((line = preset.ReadLine()) != "MatEnd")
                    {
                        mats.Add(line.Split('\t'));               
                    }

                    preset.Close();

                    return mats;

                }
            } return null;
        }

        public static List<string> LoadPresetProps(string file)
        {
            if (File.Exists(file))
            {
                using (StreamReader preset = new StreamReader(file))
                {
                    string line = "";
                    List<string> props = new List<string>();

                    while (line != "MatEnd")
                    {
                        line = preset.ReadLine();
                    }

                    while ((line = preset.ReadLine()) != null)
                    {
                        props.Add(line);
                    }

                    preset.Close();

                    return props;

                }

            } return null;
        }


        public static void Throw(string text, int type)
        {
            switch (type)
            {
                case 1:
                    MessageBox.Show(text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                case 2:
                    MessageBox.Show(text, "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                case 3:
                    MessageBox.Show(text, "Nadeo Importer Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

            } 
        } 


        public static void OpenExp(string path)
        {
            Process.Start("explorer.exe", path);
        }


        public static void CreateMeshParams(string path, string file, string scale, List<string[]> mats)
        {

            string filename = Path.GetFileNameWithoutExtension(file);
            string destination = path + "Mesh\\" + filename + ".MeshParams.xml";

            if (File.Exists(destination))
            {
                File.Delete(destination);   
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.Indent = true;
            settings.IndentChars = ("\t");

            using (XmlWriter xml = XmlWriter.Create(destination, settings))
            {
                xml.WriteStartElement("MeshParams");
                xml.WriteAttributeString("MeshType", "Static");
                xml.WriteAttributeString("Collection", "Stadium");
                xml.WriteAttributeString("Scale", scale);

                xml.WriteStartElement("Materials");

                for (int i = 0; i < mats.Count; i++)
                {
                    xml.WriteStartElement("Material");

                    xml.WriteAttributeString("Name", mats[i][0]);
                    xml.WriteAttributeString("Link", mats[i][1]);

                    if (mats[i][2] != "")
                    {
                        xml.WriteAttributeString("Color", mats[i][2]);
                    }

                    xml.WriteEndElement();
                }

                xml.WriteEndElement();
                xml.WriteEndElement();

                xml.Flush();
            }
        }

        public static void CreateItemParams(bool[] prop_b, string[] prop, string path, string file)
        {
            string filename = Path.GetFileNameWithoutExtension(file);
            string destination = path + filename + ".Item.xml";

            if (File.Exists(destination))
            {
                File.Delete(destination);
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.ConformanceLevel = ConformanceLevel.Fragment;
            settings.Indent = true;
            settings.IndentChars = ("\t");

            using (XmlWriter xml = XmlWriter.Create(destination, settings))
            {
                xml.WriteStartElement("Item");
                xml.WriteAttributeString("Type", "StaticObject");
                xml.WriteAttributeString("Collection", "Stadium");
                xml.WriteAttributeString("AuthorName", prop[7]);

                xml.WriteStartElement("MeshParamsLink");
                xml.WriteAttributeString("File", "Mesh/" + filename + ".MeshParams.xml");
                xml.WriteEndElement();

                xml.WriteStartElement("GridSnap");
                xml.WriteAttributeString("HStep", prop[2]);
                xml.WriteAttributeString("HOffset", prop[3]);
                xml.WriteAttributeString("VStep", prop[4]);
                xml.WriteAttributeString("VOffset", prop[5]);
                xml.WriteEndElement();

                xml.WriteStartElement("Levitation");
                xml.WriteAttributeString("VStep", prop[0]);
                xml.WriteAttributeString("VOffset", prop[1]);
                xml.WriteAttributeString("GhostMode", prop_b[1].ToString());
                xml.WriteEndElement();

                if (prop[6] != "" && prop[6] != "0")
                {
                    xml.WriteStartElement("PivotSnap");
                    xml.WriteAttributeString("Distance", prop[6]);
                    xml.WriteEndElement();
                }

                xml.WriteStartElement("Options");
                xml.WriteAttributeString("ManualPivotSwitch", prop_b[0].ToString());
                xml.WriteAttributeString("OneAxisRotation", prop_b[2].ToString());
                xml.WriteAttributeString("NotOnItem", prop_b[3].ToString());
                xml.WriteAttributeString("AutoRotation", prop_b[4].ToString());
                xml.WriteEndElement();

                xml.Flush();

            }
        }

        public static string CreateStructure(string path, string file)
        {
            if (!File.Exists(file))
            {
                Throw("Couldn't find specified FBX file", 1);
                return null;
            }

            string destination = path + "Mesh\\";
            string copy = destination + Path.GetFileName(file);

            if (!(Directory.Exists(destination))) {
                Directory.CreateDirectory(destination);
            }

            if (File.Exists(copy))
            {
                DialogResult result = MessageBox.Show("FBX file that you are trying to import already exists\n\nOverwrite?", "Already Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    File.Delete(copy);
                    File.Copy(file, copy);

                    return copy;
                } 
                else
                {
                    return null;
                }
            } else
            {
                File.Copy(file, copy);
                return copy;
            }


 
        }

        public static string GetWorkFile(string tm_path, string fbx_path, bool itemmode)
        {
            if (itemmode)
            {
                string oneup = Path.GetDirectoryName(fbx_path);
                string name = Path.GetFileNameWithoutExtension(fbx_path);
                string workdir = Path.GetDirectoryName(oneup) + "\\" + name + ".Item.xml";

                return workdir.Replace(tm_path + "\\Work\\", "");
                
            } else
            {
                return fbx_path.Replace(tm_path + "\\Work\\", "");
            }

        }

        public static bool FileExists(string path)
        {
            return (File.Exists(path));
        }

        public static void NadeoImporterRun(bool item_mode, string workfile, bool log)
        {
            if (!(File.Exists("NadeoImporter.exe")))
            {
                Throw("Cannot find NadeoImporter.exe", 1);
                return;
            }

            string args;
            string logcommand = "";

            if (log)
            {
                logcommand = " /LogMeshStats";
            } 

            if (item_mode)
            {
                args = "Item " + workfile + logcommand;
            }

            else
            {
                args = "Mesh " + workfile + logcommand;
            }

            
            Process N = new Process();
            N.StartInfo.FileName = "NadeoImporter.exe";
            N.StartInfo.Arguments = args;
            N.StartInfo.UseShellExecute = false;
            N.StartInfo.RedirectStandardOutput = true;
            N.Start();
            string output = N.StandardOutput.ReadToEnd();
            N.WaitForExit();

            if (output != "")
            {
                Throw(output, 3);
            } else
            {
                Throw("Nadeo Importer encountered unexpected error\n\nNo additional info given\n\nImport failed", 1); 
            }


        }


    }

 
}

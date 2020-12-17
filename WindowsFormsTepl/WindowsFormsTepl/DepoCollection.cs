using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsTepl
{
    class DepoCollection
    {
        readonly Dictionary<string, Depo<Train, TrumpetsTrapeze>> depoStages;
        public List<string> Keys => depoStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public DepoCollection(int pictureWidth, int pictureHeight)
        {
            depoStages = new Dictionary<string, Depo<Train, TrumpetsTrapeze>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddDepo(string name)
        {
            if (depoStages.ContainsKey(name))
            {
                return;
            }
            depoStages.Add(name, new Depo<Train, TrumpetsTrapeze>(pictureWidth, pictureHeight));
        }

        public void DelDepo(string name)
        {
            if (depoStages.ContainsKey(name))
            {
                depoStages.Remove(name);
            }
        }

        public Depo<Train, TrumpetsTrapeze> this[string ind]
        {
            get
            {
                if (depoStages.ContainsKey(ind))
                {
                    return depoStages[ind];
                }
                else
                {
                    return null;
                }
            }
        }
        public Train this[string key, int ind]
        {
            get
            {
                if (depoStages.ContainsKey(key) && ind > -1)
                {
                    return depoStages[key][ind];
                }
                else
                {
                    return null;
                }
            }
        }
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine($"DepoCollection");

                    foreach (var level in depoStages)
                    {
                        sw.WriteLine($"Depo{separator}{level.Key}");
                        ITrain train = null;
                        for (int i = 0; (train = level.Value[i]) != null; i++)
                        {
                            if (train != null)
                            {
                                if (train.GetType().Name == "Locomotive")
                                {
                                    sw.Write($"Locomotive{separator}");

                                }
                                if (train.GetType().Name == "Teplovoz")
                                {
                                    sw.Write($"Teplovoz{separator}");
                                }
                                //Записываемые параметры
                                sw.WriteLine(train);
                            }
                        }
                    }
                }
            }
            return true;
        }
        public bool SaveData(string filename, string dockName)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            if (!depoStages.ContainsKey(dockName))
            {
                throw new FileNotFoundException();
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine($"OnlyOneDepo");

                    sw.WriteLine($"Depo{separator}{dockName}");
                    ITrain train = null;
                    var level = depoStages[dockName];


                    for (int i = 0; (train = level[i]) != null; i++)
                    {
                        if (train != null)
                        {
                            if (train.GetType().Name == "Locomotive")
                            {
                                sw.Write($"Locomotive{separator}");

                            }
                            if (train.GetType().Name == "Teplovoz")
                            {
                                sw.Write($"Teplovoz{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(train);
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadDepoCollection(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
                if (line.Contains("DepoCollection"))
                {
                    //очищаем записи
                    depoStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FileLoadException("Неверный формат файла");
                }
                line = sr.ReadLine();
                Train train = null;
                string key = string.Empty;
                while (line != null && line.Contains("Depo"))
                {
                    key = line.Split(separator)[1];
                    depoStages.Add(key, new Depo<Train, TrumpetsTrapeze>(pictureWidth, pictureHeight));

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Locomotive") || line.Contains("Teplovoz")))
                    {
                        if (line.Split(separator)[0] == "Locomotive")
                        {
                            train = new Locomotive(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Teplovoz")
                        {
                            train = new Teplovoz(line.Split(separator)[1]);
                        }
                        var result = depoStages[key] + train;
                        if (!result)
                        {
                            throw new DepoOverflowException();
                        }
                        line = sr.ReadLine();
                    }
                }
                return true;
            }
        }
        public bool LoadDepo(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();

                if (line.Contains("OnlyOneDepo")) { }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new FileLoadException("Неверный формат файла");
                }
                line = sr.ReadLine();
                Train train = null;
                string key = string.Empty;
                if (line != null && line.Contains("Depo"))
                {
                    key = line.Split(separator)[1];
                    if (depoStages.ContainsKey(key))
                    {
                        depoStages[key].ClearPlaces();
                    }
                    else
                    {
                        depoStages.Add(key, new Depo<Train, TrumpetsTrapeze>(pictureWidth, pictureHeight));
                    }

                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Locomotive") || line.Contains("Teplovoz")))
                    {
                        if (line.Split(separator)[0] == "Locomotive")
                        {
                            train = new Locomotive(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Teplovoz")
                        {
                            train = new Teplovoz(line.Split(separator)[1]);
                        }
                        var result = depoStages[key] + train;
                        if (!result)
                        {
                            throw new DepoOverflowException();
                        }
                        line = sr.ReadLine();
                    }
                }
                else return false;
                return true;
            }
        }
    }
}

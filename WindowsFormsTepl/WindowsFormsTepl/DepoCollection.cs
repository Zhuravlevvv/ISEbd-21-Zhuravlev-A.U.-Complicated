using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsTepl
{
    class DepoCollection
    {
        readonly Dictionary<string, Depo<Train, TrumpetsTrapeze>> depoStages;
        public List<string> Keys => depoStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

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
    }
}

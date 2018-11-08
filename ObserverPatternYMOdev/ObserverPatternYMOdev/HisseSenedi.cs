using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternYMOdev
{
public abstract class HisseSenedi
    {
        protected string sembol;
        protected double deger;
        private ArrayList yatirimcilar = new ArrayList();

        // Constructor 
        public HisseSenedi(string sembol, double deger)
        {
            this.sembol = sembol;
            this.deger = deger;
        }
        public void Attach(Yatirimci yatirimci)
        {
            yatirimcilar.Add(yatirimci);
        }

        public void Detach(Yatirimci yatirimci)
        {
            yatirimcilar.Remove(yatirimci);
        }

        public void Notify()
        {
            foreach (Yatirimci yatirimci in yatirimcilar)
            {
                yatirimci.Update(this);
            }
        }

      // Properties 
        public double Deger
        {
            get { return deger; }
            set
            {
                deger = value;
                Notify();
            }
        }

        public string Sembol
        {
            get { return sembol; }
            set { sembol = value; }
        }

    }

}

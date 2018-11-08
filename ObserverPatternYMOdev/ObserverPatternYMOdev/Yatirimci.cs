using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternYMOdev
{
 public class Yatirimci : IYatirimci
    {
        private string Ad;
        private HisseSenedi hisseSenedi;

        // Constructor 
        public Yatirimci(string Ad)
        {
            this.Ad = Ad;
        }
        public string Update(HisseSenedi hisseSenedi)
        {

            string temp = "";

            temp += (Ad + "," + hisseSenedi.Sembol + "  tarafından" + hisseSenedi.Deger + " olan değer değişikliği ile ilgili bilgilendirildi.");
            return temp;
        }

        // Property 
        public HisseSenedi HisseSenedi
        {
            get { return hisseSenedi; }
            set { hisseSenedi = value; }
        }
    }
}


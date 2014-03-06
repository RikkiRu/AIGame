using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic
{
    class LangGUI
    {
        public string eng;
        public string rus;

        public LangGUI(string eng, string rus)
        {
            this.eng = eng;
            this.rus = rus;
        }

        public string Get(bool IsEng)
        {
            if (IsEng) return eng;
            return rus;
        }
    }
}

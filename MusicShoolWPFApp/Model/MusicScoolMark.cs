using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicShoolWPFApp.Model
{
    class MusicScoolMark
    {
        private string nameOfStudent;
        private int instrumentMark;
        private int solfeggioMark;

        public MusicScoolMark()
        {
            this.nameOfStudent = string.Empty; ;
            this.instrumentMark = 1;
            this.solfeggioMark = 1;
        }

        public MusicScoolMark(string nameOfStudent, int instrumentMark, int solfeggioMark)
        {
            this.nameOfStudent = nameOfStudent;
            this.instrumentMark = instrumentMark;
            this.solfeggioMark = solfeggioMark;
        }

        public string NameOfStudent { get => nameOfStudent; set => nameOfStudent = value; }
        public int InstrumentMark { get => instrumentMark; set => instrumentMark = value; }
        public int SolfeggioMark { get => solfeggioMark; set => solfeggioMark = value; }

        public double MarkAVG
        {
            get
            {
                double result = ((double)instrumentMark + solfeggioMark) / 2;
                return result;
            }
        }

        public string Mark
        {
            get
            {
                if (MarkAVG >= 4.5)
                    return "jeles";
                else if (MarkAVG >= 3.5)
                    return "jó";
                else if (MarkAVG >= 2.5)
                    return "közepes";
                else if (MarkAVG > 1.5)
                    return "elégséges";
                else
                    return "elégtelen";
            }
        }

        public string FullMark
        {
            get
            {
                string result = nameOfStudent + " ";
                if (instrumentMark==1 || solfeggioMark==1)
                    result = "évfolyamot ismétel.";
                else
                    result = "következő évfolyamra léphet.";
                return result;
            }
        }
    }
}

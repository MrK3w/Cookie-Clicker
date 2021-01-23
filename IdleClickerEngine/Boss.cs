using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdleClickerEngine
{
    public class Boss
    {
        //images of bosses
        private readonly string[] _images = { "FirstBossImage","SecondBossImage","ThirdBossImage","FourthBossImage","FinalBossImage"};
        //name of bosses
        private readonly string[] _bossName = {"Jura Brutalita","Terminator Dzancic","Karater bedny","Tuuuuufik","MrK3w"};
        //quotes of bosses
        private readonly string[] _bossText = {"You lost because you are pussy!","Aaaaaaaa","Big kick from otočka","Ajphouuun","Hello there"};

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <param name="image"></param>
        /// <param name="bossName"></param>
        /// <param name="bossText"></param>
        public void GetBossInformation(out string image, out string bossName, out string bossText)
        {
            int i = MyInfo.Level - 1;

            bossName = _bossName[i];
            bossText = _bossText[i];
            image =  _images[i];
        }
    }
}

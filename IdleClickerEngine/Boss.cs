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
        private readonly string[] _images = { "FirstBossImage","SecondBossImage","ThirdBossImage","FourthBossImage","FinalBossImage"};
        private readonly string[] _bossName = {"Jura Brutalita","Terminator Dzancic","Karater bedny","Tuuuuufik","MrK3w"};
        private readonly string[] _bossText = {"You lost because you are pussy!","Aaaaaaaa","Big kick from otočka","Ajphouuun","Hello there"};


        public void GetBossInformation(int i,out string image, out string bossName, out string bossText)
        {
            bossName = _bossName[i];
            bossText = _bossText[i];
            image =  _images[i];
        }
    }
}

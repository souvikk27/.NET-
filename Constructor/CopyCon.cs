using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class CopyCon
    {
        int coin;
        CopyCon(int coin)
        {
            this.coin = coin;
        }
        CopyCon(CopyCon c1)
        {
            this.coin = c1.coin;
        }
        public static void Main(string[] args)
        {
            CopyCon cc1 = new CopyCon(3);
            Console.WriteLine("Coin Count 1 :" + cc1.coin);
            CopyCon cc2 = new CopyCon(cc1);
            Console.WriteLine("Coin Count 2 :" + cc2.coin);
            Console.ReadLine();
        }
    }
}

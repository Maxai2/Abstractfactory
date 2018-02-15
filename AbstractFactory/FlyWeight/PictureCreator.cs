using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------------
namespace FlyWeight
{
    class PictureCreator
    {
        private Dictionary<int, Picture> pictures = new Dictionary<int, Picture>();

        public Picture GetPicture(int num)
        {
            Picture picture = null;

            if (pictures.ContainsKey(num))
                picture = pictures[num];
            else
            {
                switch (num)
                {
                    case 0:
                        picture = new FirstPicture();
                        break;
                    case 1:
                        picture = new SecondPicture();
                        break;
                    case 2:
                        picture = new ThirdPicture();
                        break;
                    case 3:
                        picture = new FourthPicture();
                        break;
                    case 4:
                        picture = new FifthPicture();
                        break;
                }
                pictures.Add(num, picture);
            }

            return picture;
        }
    }
}
//---------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class Class5
        {
            public static void Main6()
            {
                PhotoBook Album = new PhotoBook();
                Console.WriteLine(Album.GetNumberPages());

                PhotoBook Album2 = new PhotoBook(24);
                Console.WriteLine(Album2.GetNumberPages());

                BigPhotoBook BigPhotoAlbum1 = new BigPhotoBook();
                Console.WriteLine(BigPhotoAlbum1.GetNumberPages());
            }
        }

        public class PhotoBook
        {
            protected int numPages;

            public PhotoBook()
            {
                numPages = 16;
            }

            public PhotoBook(int numPages)
            {
                this.numPages = numPages;
            }

            public int GetNumberPages()
            {
                return numPages;
            }
        }

        public class BigPhotoBook : PhotoBook
        {
            public BigPhotoBook()
            {
                numPages = 64;
            }
        }
    }

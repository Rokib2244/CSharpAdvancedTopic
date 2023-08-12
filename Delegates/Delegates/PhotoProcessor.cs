using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class PhotoProcessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler photoFilterHandler)
        {
            var photo = Photo.Load(path); 
            photoFilterHandler(photo);
            photo.Save();
        }
    }
}

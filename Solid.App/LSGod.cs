using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.App.LSPGod
{


    public interface IPhoto
    {
        void TakePhoto();
    }

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapildi");
        }

        //public abstract void TakePhoto();//An instance of the object cannot be created.
    }


    public class IPhone : BasePhone, IPhoto
    {
        //public override void TakePhoto()
        //{
        //    Console.WriteLine("fotogrraf cekildi");
        //}
        public void TakePhoto()
        {
            Console.WriteLine("fotogrraf cekildi");
        }
    }

    public class Nokia3310 : BasePhone
    {
        //public override void TakePhoto()
        //{
        //    throw new NotImplementedException();
        //}
    }
}

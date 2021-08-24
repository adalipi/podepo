using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.IServices
{
    public interface IQRcodeService
    {
        public byte[] GenerateQRcode(string textToQR);
    }
}

using Cz.Project.Domain.Business;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Cz.Project.UI.Helpers
{
    public static class QrHelper
    {
        public static Image GenerateQr(string text, int size)
        {
            var qrGenerator = new QRCodeGenerator();
            var qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            var qrCode = new QRCode(qrCodeData);
            return qrCode.GetGraphic(size);
        }
    }
}

﻿using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System;
using FontAwesome.Sharp;

namespace BRapp.Utiles
{
    public static class ImageManager
    {
        public static string GetBase64Image(byte[] imageData, int targetWidth, int targetHeight, long quality)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                // Carga la imagen desde el arreglo de bytes
                using (Image image = Image.FromStream(ms))
                {
                    // Redimensiona la imagen al tamaño deseado
                    using (Image resizedImage = ResizeImage(image, targetWidth, targetHeight))
                    {
                        // Guarda la imagen en un MemoryStream con la calidad especificada
                        using (MemoryStream msResized = new MemoryStream())
                        {
                            EncoderParameters encoderParams = new EncoderParameters(1);
                            encoderParams.Param[0] = new EncoderParameter(Encoder.Quality, quality);

                            // Guarda la imagen redimensionada en el MemoryStream con la calidad especificada
                            resizedImage.Save(msResized, GetEncoderInfo("image/jpeg"), encoderParams);

                            // Convierte el MemoryStream a una cadena base64
                            return Convert.ToBase64String(msResized.ToArray());
                        }
                    }
                }
            }
        }

        private static Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private static ImageCodecInfo GetEncoderInfo(string mimeType)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.MimeType == mimeType)
                {
                    return codec;
                }
            }
            return null;
        }

        public static Image GetFontAwesomeIconImage(IconChar iconChar, int size, Color color)
        {
            IconPictureBox iconPictureBox = new IconPictureBox
            {
                IconChar = iconChar,
                IconSize = size,
                ForeColor = color,
                BackColor = Color.White, // Fondo blanco
                Width = size,
                Height = size
            };

            Bitmap bitmap = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                iconPictureBox.DrawToBitmap(bitmap, new Rectangle(0, 0, size, size));
            }

            return bitmap;
        }
    }
}

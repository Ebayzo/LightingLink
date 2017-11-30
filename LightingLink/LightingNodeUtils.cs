﻿using HidLibrary;
using RGB.NET.Core;
using System;
using System.Linq;

namespace LightingLink
{
    class LightingNodeUtils
    {

        internal static byte[][] UpdateFourStrips(Color c1, Color c2, Color c3, Color c4)
        {
            byte[] red = new byte[] {0x00,
                   0x32, 0x00, 0x00, 0x28, 0x00, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c2.R,
                   c2.R, c2.R, c2.R, c2.R, c2.R, c2.R, c2.R, c2.R, c2.R, c3.R, c3.R, c3.R, c3.R, c3.R, c3.R, c3.R,
                   c3.R, c3.R, c3.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] green = new byte[] {0x00,
                   0x32, 0x00, 0x00, 0x28, 0x01, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c2.G,
                   c2.G, c2.G, c2.G, c2.G, c2.G, c2.G, c2.G, c2.G, c2.G, c3.G, c3.G, c3.G, c3.G, c3.G, c3.G, c3.G,
                   c3.G, c3.G, c3.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] blue = new byte[] {0x00,
                   0x32, 0x00, 0x00, 0x28, 0x02, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c2.B,
                   c2.B, c2.B, c2.B, c2.B, c2.B, c2.B, c2.B, c2.B, c2.B, c3.B, c3.B, c3.B, c3.B, c3.B, c3.B, c3.B,
                   c3.B, c3.B, c3.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            return new byte[3][] { red, green, blue }; 
        }

        internal static byte[][] UpdateSixFans(Color c1, Color c2, Color c3, Color c4)
        {
            byte[] red1 = new byte[] {0x00,
                   0x32, 0x01, 0x00, 0x32, 0x00, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R,
                   c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c1.R, c2.R, c2.R, c2.R,
                   c2.R, c2.R, c2.R, c2.R, c2.R, c2.R, c2.R, c2.R, c2.R, c3.R, c3.R, c3.R, c3.R, c3.R, c3.R, c3.R,
                   c3.R, c3.R, c3.R, c3.R, c3.R, c4.R, c4.R, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] green1 = new byte[] {0x00,
                   0x32, 0x01, 0x00, 0x32, 0x01, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G,
                   c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c1.G, c2.G, c2.G, c2.G,
                   c2.G, c2.G, c2.G, c2.G, c2.G, c2.G, c2.G, c2.G, c2.G, c3.G, c3.G, c3.G, c3.G, c3.G, c3.G, c3.G,
                   c3.G, c3.G, c3.G, c3.G, c3.G, c4.G, c4.G, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] blue1 = new byte[] {0x00,
                   0x32, 0x01, 0x00, 0x32, 0x02, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B,
                   c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c1.B, c2.B, c2.B, c2.B,
                   c2.B, c2.B, c2.B, c2.B, c2.B, c2.B, c2.B, c2.B, c2.B, c3.B, c3.B, c3.B, c3.B, c3.B, c3.B, c3.B,
                   c3.B, c3.B, c3.B, c3.B, c3.B, c4.B, c4.B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] red2 = new byte[] {0x00,
                   0x32, 0x01, 0x32, 0x16, 0x00, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R,
                   c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, c4.R, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] green2 = new byte[] {0x00,
                   0x32, 0x01, 0x32, 0x16, 0x01, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G,
                   c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, c4.G, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] blue2 = new byte[] {0x00,
                   0x32, 0x01, 0x32, 0x16, 0x02, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B,
                   c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, c4.B, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            return new byte[6][] { red1, green1, blue1, red2, green2, blue2 };
        }

        public static void FirstTransaction(HidDevice device)
        {
            byte[] first1 = new byte[] {0x00,
                   0x38, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] first2 = new byte[] {0x00,
                   0x38, 0x01, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            device.Write(first1);
            device.Write(first2);
        }

        public static void BeignUpdate(HidDevice device)
        {
            byte[] first1 = new byte[] {0x00,
                   0x34, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            byte[] first2 = new byte[] {0x00,
                   0x34, 0x01, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            device.Write(first1);
            device.Write(first2);
        }

        public static void SubmitUpdate(HidDevice device)
        {

            byte[] submit = new byte[] {0x00,
                   0x33, 0xFF, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};

            device.Write(submit);
        }
    }
}
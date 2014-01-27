using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = new MemoryStream(File.ReadAllBytes("TITLEUK.RAW"));
            var output = new MemoryStream();
            var ramREAD = new BinaryReader(file);
            var ramWRITE = new BinaryWriter(file);

            var outREAD = new BinaryReader(output);
            var outWRITE = new BinaryWriter(output);

            var r0 = 0;
            var v0 = 0;
            var a0 = 0;
            var a1 = 0;
            var a2 = 0;
            var a3 = 0;

            var t0 = 0;
            var t1 = 0;
            var t2 = 0;
            var t3 = 0;
            var t4 = 0;
            var t5 = 0;
            var t6 = 0;
            var t7 = 0;



            v0 = a1 + r0;
            t2 = 256 << 16;
            t7 = 32768 << 16;
            a2 = r0 + 9;
            ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            t1 = t1 | t2;
            if (r0 >= 0) { t1 = t1 << 1; goto pc160; }
            t1 = t1 << 1;
        pc11: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc63; }
            t1 = t1 | t2;
        pc17: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc82; }
            t1 = t1 | t2;
        pc23: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc87; }
            t1 = t1 | t2;
        pc29: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc92; }
            t1 = t1 | t2;
        pc35: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc99; }
            t1 = t1 | t2;
        pc41: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc103; }
            t1 = t1 | t2;
        pc47: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc108; }
            t1 = t1 | t2;
        pc53: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc116; }
            t1 = t1 | t2;
        pc59: t4 = r0 + 3;
        pc60: t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc11; }
            t1 = t1 << 1;
        pc63: t5 = t5 << 1;
            t5 = t5 | t0;
            if (t4 != r0) { t4 = t4 + -1; goto pc60; }
            t4 = t4 + -1;
            t4 = t5 + 3;
            t4 = t4 << 2;
            t4 = a0 + t4;
        pc70: ramREAD.BaseStream.Position = a0 + 0; t3 = ramREAD.ReadInt32();

            a0 = a0 + 4;
            outWRITE.BaseStream.Position = a1 + 0; outWRITE.Write(t3);

            if (a0 != t4) { a1 = a1 + 4; goto pc70; }
            a1 = a1 + 4;
            if (r0 >= 0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc161; }
            t0 = (Int32)((UInt32)t1 >> 31);
            t0 = (Int32)((UInt32)t1 >> 31);
        pc80: if (t1 == t7) { t1 = t1 << 1; goto pc17; }
            t1 = t1 << 1;
        pc82: t4 = t4 << 1;
            t4 = t4 | t0;
            t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc23; }
            t1 = t1 << 1;
        pc87: if (t0 == r0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc97; }
            t0 = (Int32)((UInt32)t1 >> 31);
            t4 = t4 + -1;
            if (t1 == t7) { t1 = t1 << 1; goto pc29; }
            t1 = t1 << 1;
        pc92: t4 = t4 << 1;
            t4 = t4 | t0;
            if (t4 == a2) { r0 = r0 << 0; goto pc59; }
            r0 = r0 << 0;
        pc96: t0 = (Int32)((UInt32)t1 >> 31);
        pc97: if (t1 == t7) { t1 = t1 << 1; goto pc35; }
            t1 = t1 << 1;
        pc99: if (t0 == r0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc119; }
            t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc41; }
            t1 = t1 << 1;
        pc103: t5 = t5 << 1;
            t5 = t5 | t0;
            t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc47; }
            t1 = t1 << 1;
        pc108: if (t0 != r0) { r0 = r0 << 0; goto pc194; }
            r0 = r0 << 0;
            if (t5 != r0) { r0 = r0 << 0; goto pc118; }
            r0 = r0 << 0;
            t5 = t5 + 1;
            t0 = (Int32)((UInt32)t1 >> 31);
        pc114: if (t1 == t7) { t1 = t1 << 1; goto pc53; }
            t1 = t1 << 1;
        pc116: t5 = t5 << 1;
            t5 = t5 | t0;
        pc118: t5 = t5 << 8;
        pc119: ramREAD.BaseStream.Position = a0 + 0; t3 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t5 = t5 | t3;
            t3 = a1 - t5;
            t3 = t3 + -1;
            t6 = t4 & 1;
            if (t6 == r0) { t4 = (Int32)((UInt32)t4 >> 1); goto pc131; }
            t4 = (Int32)((UInt32)t4 >> 1);
            outREAD.BaseStream.Position = t3 + 0; t6 = outREAD.ReadByte();
            t3 = t3 + 1;
            outWRITE.BaseStream.Position = a1 + 0; outWRITE.Write((Byte)t6);
            a1 = a1 + 1;
        pc131: t4 = t4 << 1;
            if (t5 != r0) { t4 = a1 + t4; goto pc141; }
            t4 = a1 + t4;
            outREAD.BaseStream.Position = t3 + 0; t5 = outREAD.ReadByte();
        pc135: a1 = a1 + 2;
            outWRITE.BaseStream.Position = a1 + -2; outWRITE.Write((Byte)t5);
            if (a1 != t4) { outWRITE.BaseStream.Position = a1 + -1; outWRITE.Write((Byte)t5); goto pc135; }
            outWRITE.BaseStream.Position = a1 + -1; outWRITE.Write((Byte)t5);
            if (r0 >= 0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc161; }
            t0 = (Int32)((UInt32)t1 >> 31);
        pc141: outREAD.BaseStream.Position = t3 + 0; t6 = outREAD.ReadByte();
            outREAD.BaseStream.Position = t3 + 1; a3 = outREAD.ReadByte();
            outWRITE.BaseStream.Position = a1 + 0; outWRITE.Write((Byte)t6);
            outWRITE.BaseStream.Position = a1 + 1; outWRITE.Write((Byte)a3);
            a1 = a1 + 2;
            if (a1 != t4) { t3 = t3 + 2; goto pc141; }
            t3 = t3 + 2;
            if (r0 >= 0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc161; }
            t0 = (Int32)((UInt32)t1 >> 31);
        pc150: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (t0 != r0) { t1 = t1 | t2; goto pc171; }
            t1 = t1 | t2;
        pc156: ramREAD.BaseStream.Position = a0 + 0; t3 = ramREAD.ReadByte();
            a0 = a0 + 1;
            outWRITE.BaseStream.Position = a1 + 0; outWRITE.Write((Byte)t3);
            a1 = a1 + 1;
        pc160: t0 = (Int32)((UInt32)t1 >> 31);
        pc161: if (t0 != r0) { t1 = t1 << 1; goto pc170; }
            t1 = t1 << 1;
            ramREAD.BaseStream.Position = a0 + 0; t3 = ramREAD.ReadByte();
            a0 = a0 + 1;
            outWRITE.BaseStream.Position = a1 + 0; outWRITE.Write((Byte)t3);
            a1 = a1 + 1;
            t0 = (Int32)((UInt32)t1 >> 31);
            if (t0 == r0) { t1 = t1 << 1; goto pc156; }
            t1 = t1 << 1;
        pc170: if (t1 == r0) { t4 = r0 + 2; goto pc150; }
        pc171: t4 = r0 + 2;
            t5 = r0 + 0;
            t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc207; }
            t1 = t1 << 1;
        pc176: if (t0 == r0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc80; }
            t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc213; }
            t1 = t1 << 1;
        pc180: if (t0 == r0) { r0 = r0 << 0; goto pc119; }
            r0 = r0 << 0;
            t4 = t4 + 1;
            t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc219; }
            t1 = t1 << 1;
        pc186: if (t0 == r0) { r0 = r0 << 0; goto pc96; }
            r0 = r0 << 0;
            ramREAD.BaseStream.Position = a0 + 0; t4 = ramREAD.ReadByte();
            a0 = a0 + 1;
            if (t4 == r0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc239; }
            t0 = (Int32)((UInt32)t1 >> 31);
            if (r0 >= 0) { t4 = t4 + 8; goto pc97; }
            t4 = t4 + 8;
        pc194: t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc225; }
            t1 = t1 << 1;
        pc197: t5 = t5 << 1;
            t5 = t5 | t0;
            t5 = t5 | 4;
            t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 == t7) { t1 = t1 << 1; goto pc231; }
            t1 = t1 << 1;
            if (t0 != r0) { r0 = r0 << 0; goto pc118; }
            r0 = r0 << 0;
            if (r0 >= 0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc114; }
            t0 = (Int32)((UInt32)t1 >> 31);
        pc207: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc176; }
            t1 = t1 | t2;
        pc213: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc180; }
            t1 = t1 | t2;
        pc219: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc186; }
            t1 = t1 | t2;
        pc225: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (r0 >= 0) { t1 = t1 | t2; goto pc197; }
            t1 = t1 | t2;
        pc231: ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            if (t0 != r0) { t1 = t1 | t2; goto pc118; }
            t1 = t1 | t2;
            if (r0 >= 0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc114; }
            t0 = (Int32)((UInt32)t1 >> 31);
        pc239: t0 = (Int32)((UInt32)t1 >> 31);
            if (t1 != t7) { t1 = t1 << 1; goto pc247; }
            t1 = t1 << 1;
            ramREAD.BaseStream.Position = a0 + 0; t1 = ramREAD.ReadByte();
            a0 = a0 + 1;
            t0 = (Int32)((UInt32)t1 >> 7);
            t1 = t1 << 25;
            t1 = t1 | t2;
        pc247: if (t0 != r0) { t0 = (Int32)((UInt32)t1 >> 31); goto pc161; }
            t0 = (Int32)((UInt32)t1 >> 31);

            v0 = a1 - v0;

            File.WriteAllBytes("out.raw", output.ToArray());
        }
    }
}

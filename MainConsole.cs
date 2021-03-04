using System;
using System.IO;

/*  Order of intended operations.
 *  1. Get ROM.
 *  2. Check Current ROM for proper version
 *  3. Copy ROM and write new values
 *  4. Implement or have user get the checksum re-hased for the game.       (Optional byte edit)
 *  5. Save
*/

namespace SnowboardKidsRandomizer
{
    class MainConsole
    {
        static void Main(string[] args)
        {
        RETRY:
            string date = string.Format("{0:yyyyMMdd}", DateTime.Now);
            string endianType = "";
            Console.WriteLine("Please specify the name of the ROM you wish to use with the file extension.\n\nNotice the ROM must be in the same directory as this program,\nand must be named 'Snowboard Kids(USA)' without the quotations.\nYou must use the USA version and not the Japanese Version of the game.\nCase Sensitive. Extension does not matter. Type EXIT to close this program.\n");
            
            string gameName = Console.ReadLine();       //Check user input for ROM. Don't know how dragging and dropping works with coding atm...

            if(gameName == "Snowboard Kids(USA).v64" || gameName == "Snowboard Kids(USA).V64")
            {
                endianType = "V64";
                goto ROMREAD;
            }

            else if(gameName == "Snowboard Kids(USA).n64" || gameName == "Snowboard Kids(USA).N64")
            {
                endianType = "N64";
                goto ROMREAD;
            }

            else if (gameName == "Snowboard Kids(USA).z64" || gameName == "Snowboard Kids(USA).Z64")
            {
                endianType = "Z64";
                goto ROMREAD;
            }

            else if (gameName == "EXIT")
            {
                goto EXIT;
            }

            else
            {
                Console.WriteLine("Name does not match properly. Be sure to type the name correctly and try again. Case sensitive...\n");
                goto RETRY;
            }

        ROMREAD:                                //Checks for the ROM's true Endian Nature and if the user is lying/stupid.

            if (!File.Exists(gameName))
            {
                Console.WriteLine("The ROM with the specified name does not exist. Make sure the ROM is in\nthe same folder as this program and try again.");
                goto EXIT;
            }
            FileStream ROM = new FileStream(gameName, FileMode.Open, FileAccess.Read);

            int bytesToRead = 0x02;
            int bytesRead = 0x00;
            byte[] singleByte = new byte[bytesToRead];
            while (bytesToRead > 0)
            {
            int readByte = ROM.Read(singleByte, bytesRead, bytesToRead);
                if (readByte == 0)
                    break;
                bytesRead += readByte;
                bytesToRead -= readByte;
            }

            Array.Reverse(singleByte);
            int singleInt = BitConverter.ToInt16(singleByte);
            Console.WriteLine(singleInt);
            Console.ReadKey();

            if (singleInt == 0x4012)
            {
                if (endianType == "N64")
                {
                    Console.WriteLine("This ROM is wordswapped, and commonly uses .n64/.N64\n");
                    goto N64;
                }
                else if (endianType == "V64")
                {
                    Console.WriteLine("This ROM extension is not .n64/.N64, but uses the same data format.\nROM will be output as .n64.");
                    goto N64;
                }
                else if (endianType == "Z64")
                {
                    Console.WriteLine("This ROM extension is not .n64/.N64, but uses the same data format.\nROM will be output as .n64.");
                    goto N64;
                }
            }
                
            else if(singleInt == 0x3780)
            {
                if (endianType == "N64")
                {
                    Console.WriteLine("This ROM extension is not .v64/.V64, but uses the same data format.\nROM will be output as .v64.");
                    goto V64;
                }
                else if (endianType == "V64")
                {
                    Console.WriteLine("This ROM is byteswapped, and commonly uses .v64/.V64\n");
                    goto V64;
                }
                else if (endianType == "Z64")
                {
                    Console.WriteLine("This ROM extension is not .v64/.V64, but uses the same data format.\nROM will be output as .v64.");
                    goto V64;
                }
            }

            else if (singleInt == 0x8037)
            {
                if (endianType == "N64")
                {
                    Console.WriteLine("This ROM extension is not .z64/.Z64, but uses the same data format.\nROM will be output as .z64.");
                    goto Z64;
                }
                else if (endianType == "V64")
                {
                    Console.WriteLine("This ROM extension is not .v64/.V64, but uses the same data format.\nROM will be output as .z64.");
                    goto Z64;
                }
                else if (endianType == "Z64")
                {
                    Console.WriteLine("This ROM has no bytes swapped around, and commonly uses .z64/.Z64\n");
                    goto Z64;
                }
            }

            else
            {
                Console.WriteLine("This ROM is either wordswapped and byteswapped, or this is not a proper Nintendo 64 ROM.\nPress any key to exit.");
                goto EXIT;
            }

        N64:                //Do stuff here if .N64/wordswapped.

            Console.ReadKey();
            Console.WriteLine("Creating a new ROM file based on ROM file given...");
            FileStream newN64ROM = new FileStream("Snowboard Kids(USA)" + date + ".n64", FileMode.CreateNew, FileAccess.ReadWrite);
            newN64ROM.Position = 0x3F;
            {
                Console.WriteLine("Writing bytes to new ROM...");
                newN64ROM.WriteByte(0x40);
            }
            Console.WriteLine("Finishing up...");
            newN64ROM.Close();
            goto CLOSE;

        V64:                //Do stuff here if .V64/byteswapped.

            Console.ReadKey();
            Console.WriteLine("Creating a new ROM file based on ROM file given...");
            FileStream newV64ROM = new FileStream("Snowboard Kids(USA)" + date + ".v64", FileMode.CreateNew, FileAccess.ReadWrite);

            newV64ROM.Position = 0x36;      //Temporarily writes a single byte and just closes. Nothing necessary quite yet.
            {
                Console.WriteLine("Writing bytes to new ROM...");
                newV64ROM.WriteByte(0x37);
            }
            Console.WriteLine("Finishing up...");
            newV64ROM.Close();
            goto CLOSE;

        Z64:                //Do stuff here if .Z64/no swapped bytes.

            Console.ReadKey();
            Console.WriteLine("Creating a new ROM file based on ROM file given...");
            FileStream newZ64ROM = new FileStream("Snowboard Kids(USA)" + date + ".z64", FileMode.CreateNew, FileAccess.ReadWrite);
            newZ64ROM.Position = 0x7F;
            {
                Console.WriteLine("Writing bytes to new ROM...");
                newZ64ROM.WriteByte(0x80);
            }
            Console.WriteLine("Finishing up...");
            newZ64ROM.Close();
            goto CLOSE;

        CLOSE:
            ROM.Close();
        EXIT:
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

using System;
using System.IO;

namespace SnowboardKidsRandomizer
{
    class MainConsole
    {
        static void Main(string[] args)
        {
            bool isDotN64 = false;
            bool isDotV64 = false;
            bool isDotZ64 = false;
            Console.WriteLine("Please specify the name of the ROM you wish to use with the file extension.\n\nNotice the ROM must be in the same directory as this program,\nand must be named 'Snowboard Kids(USA)' without the quotations.\nYou must use the USA version and not the Japanese Version of the game.\nCase Sensitive. Extension does not matter. Type EXIT to close this program.");
            Retry:
            string gameName = Console.ReadLine();
            if(gameName == "Snowboard Kids(USA).n64" || gameName == "Snowboard Kids(USA).N64")
            {
                isDotN64 = true;
            }
            else if(gameName == "Snowboard Kids(USA).v64" || gameName == "Snowboard Kids(USA).V64")
            {
                isDotV64 = true;
            }
            else if (gameName == "Snowboard Kids(USA).z64" || gameName == "Snowboard Kids(USA).Z64")
            {
                isDotZ64 = true;
            }
            else if (gameName == "EXIT")
            {
                goto EXIT;
            }
            else
            {
                Console.WriteLine("Name does not match properly. Be sure to type the name correctly and try again. Case sensitive...");
                goto Retry;
            }
            FileStream F = new FileStream(gameName, FileMode.Open, FileAccess.Read);
            F.Position = 0x10;
            if (isDotN64)
            {

            }
            else if (isDotV64)
            {

            }
            else if (isDotZ64)
            {

            }
            else
            {
                Console.WriteLine("I don't know how you got access to this text, but something messed up in the code.\nIf you see this, panic and contact the developer of this program for debugging.\nThe program will now close. Nothing will be saved.");
                F.Close();
                goto EXIT;
            }
            F.Close();
            EXIT:
            Console.ReadKey();
        }
    }
}

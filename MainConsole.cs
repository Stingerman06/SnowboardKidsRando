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
            string endianType = "None";
            Console.WriteLine("Please specify the name of the ROM you wish to use with the file extension.\n\nNotice the ROM must be in the same directory as this program,\nand must be named 'Snowboard Kids(USA)' without the quotations.\nYou must use the USA version and not the Japanese Version of the game.\nCase Sensitive. Extension does not matter. Type EXIT to close this program.");
            Retry:
            string gameName = Console.ReadLine();
            if(gameName == "Snowboard Kids(USA).n64" || gameName == "Snowboard Kids(USA).N64")
            {
                endianType = "SWAP";
            }
            /*else if(gameName == "Snowboard Kids(USA).v64" || gameName == "Snowboard Kids(USA).V64")
            {
                endianType = "BIG";
            }
            else if (gameName == "Snowboard Kids(USA).z64" || gameName == "Snowboard Kids(USA).Z64")
            {
                endianType = "SMOL";
            }*/
            else if (gameName == "EXIT")
            {
                goto EXIT;
            }
            else
            {
                Console.WriteLine("Name does not match properly. Be sure to type the name correctly and try again. Case sensitive...");
                goto Retry;
            }
            FileStream ROM = new FileStream(gameName, FileMode.Open, FileAccess.Read);
            if (endianType == "SWAP")
            {
            }
            /*else if (endianType == "BIG")
            {
            }
            else if (endianType == "SMOL")
            {
            }*/

            else
            {
                Console.WriteLine("I don't know how you got access to this text, but something messed up in the code.\nIf you see this, panic and contact the developer of this program for debugging.\nThe program will now close. Nothing will be saved.");
                //F.Close();
                //goto EXIT;
            }
            ROM.Close();
            EXIT:
            Console.ReadKey();
        }
    }
}

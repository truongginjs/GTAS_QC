using System;
using System.Reflection;
using SINNIKA.Cipher.Tool.Types;
using SINNIKA.Cipher;

namespace SINNIKA.Cipher.Tool
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            // Test();
            // return;
            try
            {
                Tools(args);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("-h,--help \thelp");
            }
        }

        private static void Tools(string[] args)
        {
            var text = string.Empty;
            var password = string.Empty;
            var versionString = Assembly.GetEntryAssembly()
                               .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                               .InformationalVersion
                               .ToString();
            bool isEncrypt = true;
            for (int i = 0; i < args.Length; i++)
            {
                var flat = args[i].GetFlat();
                switch (flat)
                {
                    case FlatType.help:
                        Console.WriteLine(@"
TOOLS:
   _____ _____ _____  _    _ ______ _____  
  / ____|_   _|  __ \| |  | |  ____|  __ \ 
 | |      | | | |__) | |__| | |__  | |__) |
 | |      | | |  ___/|  __  |  __| |  _  / 
 | |____ _| |_| |    | |  | | |____| | \ \ 
  \_____|_____|_|    |_|  |_|______|_|  \_\");
                        Console.WriteLine($"Version: {versionString}");
                        Console.WriteLine("Author: NMTRUONG");
                        Console.WriteLine("=================================\n\n");
                        Console.WriteLine("-h,--help \thelp");
                        Console.WriteLine("-d,--decrypt \tto decrypt");
                        Console.WriteLine("-e,--encrypt \tto encrypt");
                        Console.WriteLine("-t,--text \tinput text");
                        Console.WriteLine("-p,--password \tsalt parth");
                        return;
                    case FlatType.encrypt:
                        isEncrypt = true;
                        break;
                    case FlatType.decrypt:
                        isEncrypt = false;
                        break;
                    case FlatType.text:
                        text = args[++i];
                        break;
                    case FlatType.password:
                        password = args[++i];
                        break;
                    case FlatType.unknown:
                    default:
                        Console.WriteLine("-h,--help \thelp");
                        return;
                }


            }
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("-h,--help \thelp");
                return;
            }

            var result = isEncrypt ? text.Encrypt(password) : text.Decrypt(password);


            Console.WriteLine("Result: ");
            Console.WriteLine(result);
        }

        private static void Test()
        {
            var args = new string[] {"-d", "-t", "gps49HC9/FhneLmy9zWgQ/PjgTvr2cgNl0E1B1HivJ3on0o246aAUBUoaSb1K+gMl4wxnDK8JCWwj65QARR7jQCc0GBFTn/332ha7MHDzL2SRHcqpm7mVgdLF9CdzRoqPNGNEaxoOyVLp7UKKyLAqw==", "-p", "LibrarySerivce" };
            Tools(args);
        }

    }
}
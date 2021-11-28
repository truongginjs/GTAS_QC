using System;
using System.Reflection;
using SINNIKA.Cipher.Tool.Types;
using SINNIKA.Cipher;
using System.Text.Json;

namespace SINNIKA.Cipher.Tool
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //Test();
            //return;
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
            
            bool isEncrypt = true;

            //Console.WriteLine(JsonSerializer.Serialize(args));

            for (int i = 0; i < args.Length; i++)
            {
                var flat = args[i].GetFlat();
                switch (flat)
                {
                    case FlatType.help:
                        LogHelp();
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
            Console.WriteLine(isEncrypt? FlatType.encrypt.ToString() : FlatType.decrypt.ToString());
            Console.WriteLine($"text: {text}");
            Console.WriteLine($"salt: {password}");
            Console.WriteLine("\n");
            Console.WriteLine("================================================");
            var result = isEncrypt ? text.Encrypt(password) : text.Decrypt(password);


            Console.WriteLine("Result: ");
            Console.WriteLine(result);
        }

        private static void LogHelp()
        {
            var versionString = Assembly.GetEntryAssembly()
                               .GetCustomAttribute<AssemblyInformationalVersionAttribute>()
                               .InformationalVersion
                               .ToString();
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
            Console.WriteLine("-p,--password \tsalt string");
        }

        private static void Test()
        {
            var args = new string[] {"-d", "-t", "TYmgvWx2Suu0AO5QVkOWPOkVBZwerMvVPiCq1aB3zCGC86N3lQRf1oBS9TMy//NiPhPztaZEg5hoaWkgyySevMc4VrfMe/nmzJMx9AwCH0QlU6VfkAUoqdCstG+QXubiQrcCib40ky3phrJed6QoVA==", "-p", "QCService" };
            Tools(args);
        }

    }
}
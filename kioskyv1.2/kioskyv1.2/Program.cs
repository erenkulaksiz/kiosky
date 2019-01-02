using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;


namespace kioskyv12
{
    class Program
    {

        static string kiosky_version = "1.2";
        static string kiosky_title = "Kiosky v" + kiosky_version + " - Console";
        static string kiosky_banner = "\n\n  dP       oo                   dP                \n  88                            88                \n  88  .dP  dP .d8888b. .d8888b. 88  .dP  dP    dP \n  88888*   88 88'  `88 Y8ooooo. 88888*   88    88 \n  88  `8b. 88 88.  .88       88 88  `8b. 88.  .88 \n  dP   `YP dP `88888P' `88888P' dP   `YP `8888P88 \n                                              .88 \n                                          d8888P  v" + kiosky_version + "  \n  ____________________________________________________\n";
        static string kiosky_input = String.Empty;
        // komutlar
        static string kiosky_help_str = "help";
        static string kiosky_checkip_str = "checkip";
        static string kiosky_cnscolor_str = "cnscolor";
        static string kiosky_clear_str = "clear";
        static string kiosky_exit_str = "exit";
        static string kiosky_ver_str = "ver";
        static string kiosky_config_str = "kioskyconfig";

        static string kiosky_cnscolor_type_white = "white";
        static string kiosky_cnscolor_type_green = "green";
        static string kiosky_cnscolor_type_cyan = "cyan";
        static string kiosky_cnscolor_type_blue = "blue";
        static string kiosky_cnscolor_type_red = "red";
        static string kiosky_cnscolor_type_yellow = "yellow";

        static string kiosky_cnscolor = "green"; // default value

        static string kiosky_config_input_tmp = "";

        static string kiosky_config_username = "";
        static string kiosky_config_password = "";

        static string kiosky_readfile_username = "";
        static string kiosky_readfile_password = "";


        static void Main(string[] args)
        {

            consoleColor();

            Console.Title = kiosky_title;

            tryLogin();

            Console.WriteLine(kiosky_banner);
            Console.Write("\n  type help for all commands.");

            for (int i = 0; i < 255; i++)
            {
                consoleColor();
                Console.Write("\n  \n > ");
                kiosky_input = Console.ReadLine();
                if (kiosky_input.Contains(kiosky_help_str))
                {
                    consoleInput(kiosky_help_str);
                }
                else if (kiosky_input.Contains(kiosky_checkip_str))
                {
                    consoleInput(kiosky_checkip_str);
                }
                else if (kiosky_input.Contains(kiosky_cnscolor_str))
                {
                    if (kiosky_input.Contains(kiosky_cnscolor_type_white))
                    {
                        kiosky_cnscolor = kiosky_cnscolor_type_white;
                        consoleInput(kiosky_cnscolor_str);
                    }
                    else if (kiosky_input.Contains(kiosky_cnscolor_type_green))
                    {
                        kiosky_cnscolor = kiosky_cnscolor_type_green;
                        consoleInput(kiosky_cnscolor_str);
                    }
                    else if (kiosky_input.Contains(kiosky_cnscolor_type_cyan))
                    {
                        kiosky_cnscolor = kiosky_cnscolor_type_cyan;
                        consoleInput(kiosky_cnscolor_str);
                    }
                    else if (kiosky_input.Contains(kiosky_cnscolor_type_blue))
                    {
                        kiosky_cnscolor = kiosky_cnscolor_type_blue;
                        consoleInput(kiosky_cnscolor_str);
                    }
                    else if (kiosky_input.Contains(kiosky_cnscolor_type_red))
                    {
                        kiosky_cnscolor = kiosky_cnscolor_type_red;
                        consoleInput(kiosky_cnscolor_str);
                    }
                    else if (kiosky_input.Contains(kiosky_cnscolor_type_yellow))
                    {
                        kiosky_cnscolor = kiosky_cnscolor_type_yellow;
                        consoleInput(kiosky_cnscolor_str);
                    }
                    else
                    {
                        Console.Write("\n > Cannot determine color, type help for usage.");
                    }

                }
                else if (kiosky_input.Contains(kiosky_clear_str))
                {
                    consoleInput(kiosky_clear_str);
                }
                else if (kiosky_input.Contains(kiosky_exit_str))
                {
                    consoleInput(kiosky_exit_str);
                }
                else if (kiosky_input.Contains(kiosky_ver_str))
                {
                    consoleInput(kiosky_ver_str);
                }
                else if (kiosky_input.Contains(kiosky_config_str))
                {
                    consoleInput(kiosky_config_str);
                }
                else
                {
                    consoleInput("none");
                }
            }


            Console.ReadKey();

        }

        static void consoleInput(string maininput)
        {
            switch (maininput)
            {
                case "help":
                    Console.Write("\n >> showing help...");
                    Console.Write("\n\n checkip - Checks system ip.\n\n" +
                        " cnscolor - Changes color of console. \n | Available colors: white, green, cyan, blue, red, yellow\n | This setting do not apply on 'cmd' program on Windows operating systems.\n");
                    Console.Write("\n ver - Shows client version and author.\n");
                    Console.Write("\n clear - Clears entire console.\n");
                    Console.Write("\n exit - Exits client.");
                    break;

                case "checkip":
                    string kiosky_dns = Dns.GetHostName(); // recieve DNS
                    string kiosky_ip = Dns.GetHostByName(kiosky_dns).AddressList[0].ToString();
                    Console.Write("\n >> checking ip...\n " + kiosky_ip);

                    break;

                case "cnscolor":
                    Console.Write("\n >> Console color is now " + kiosky_cnscolor + " colored");
                    break;

                case "clear":
                    for (int i = 0; i < 120; i++)
                    {
                        Console.Write("\n");
                    }
                    Console.WriteLine(kiosky_banner);
                    Console.Write("\n  type help for all commands.");
                    break;

                case "exit":
                    Console.Write("\n >> Now exiting kiosky...");
                    Environment.Exit(0);
                    break;

                case "ver":
                    Console.Write("\n >> Kiosky console version: v" + kiosky_version + "\n >> Author: Eren 'royjce' Kulaksız \n >> github.com/royjce/kiosky");
                    break;

                case "kioskyconfig":
                    Console.Write("  ___________________________\n\n  >> Kiosky Configration Tool\n  Please select an option. (0-9)\n  To get back, write 'back'");
                    Console.Write("\n\n  >> 1 - Change kiosky username\n  >> 2 - Change kiosky password");
                    Console.Write("\n\n  >> Your input: ");
                    kiosky_config_input_tmp = Console.ReadLine();
                    try
                    {
                        if (kiosky_config_input_tmp == Convert.ToString(1))
                        {
                            Console.Write("\n    >> kiosky_get_input_temp = 1 username");
                            Console.Write("\n\n    >> New username: ");
                            kiosky_config_username = Console.ReadLine();
                            string kiosky_username_temp = "";
                            kiosky_username_temp += "kiosky_system_username=" + kiosky_config_username;
                            try
                            {
                                System.IO.File.WriteAllText(@".\kiosky_username.txt", kiosky_username_temp);
                            }
                            catch (Exception e) { }
                        }
                        else if (kiosky_config_input_tmp == Convert.ToString(2))
                        {
                            Console.Write("\n    >> kiosky_get_input_temp = 2 password");
                            Console.Write("\n\n    >> New password: ");
                            kiosky_config_password = Console.ReadLine();
                            string kiosky_password_temp = "";
                            kiosky_password_temp += "kiosky_system_password=" + kiosky_config_password;
                            try
                            {
                                System.IO.File.WriteAllText(@".\kiosky_password.txt", kiosky_password_temp);
                            }
                            catch (Exception e) { }
                        }
                        else
                        {
                            Console.Write("\n  >> Please select an option from 0 to 9. ");
                        }
                    }
                    catch (Exception e) { }

                    break;

                case "none":
                    Console.Write("\n >> Cannot found command!");
                    break;

            }
        }

        static void consoleColor()
        {
            if (kiosky_cnscolor == kiosky_cnscolor_type_white)
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (kiosky_cnscolor == kiosky_cnscolor_type_green)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (kiosky_cnscolor == kiosky_cnscolor_type_cyan)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }
            else if (kiosky_cnscolor == kiosky_cnscolor_type_blue)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (kiosky_cnscolor == kiosky_cnscolor_type_red)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (kiosky_cnscolor == kiosky_cnscolor_type_yellow)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        static void tryLogin()
        {
            try
            {
                kiosky_readfile_username = System.IO.File.ReadAllText(@".\kiosky_username.txt");
                kiosky_readfile_password = System.IO.File.ReadAllText(@".\kiosky_password.txt");
                kiosky_readfile_username = kiosky_readfile_username.Substring(23);
                kiosky_readfile_password = kiosky_readfile_password.Substring(23);
            }
            catch (Exception e)
            {
                Console.WriteLine("\n >> Cant start Kiosky. Press any key to exit. \n\n\n >> Error: \n" + e);
                while (true) { Console.ReadKey(); Environment.Exit(0); } 
            }

            Console.Write("\n >> login as: ");

            if (Console.ReadLine() == kiosky_readfile_username)
            {
                Console.Write("\n >> password: ");
                if (Console.ReadLine() == kiosky_readfile_password)
                {
                    Console.Write("\n >> Welcome to Kiosky.");
                }
                else
                {
                    Console.WriteLine("\n >> Wrong password was given. Press any key to exit.");
                    while (true) { Console.ReadKey(); Environment.Exit(0); } 
                }
            }
            else
            {
                Console.WriteLine("\n >>  Wrong username was given. Press any key to exit.");
                while (true) { Console.ReadKey(); Environment.Exit(0); }
            }
        }
    }
}

using Client;
using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Client;

class Program
{
    static void Main(string[] args)
    {
        new Header().CWHeader();
        if (args.Length == 0)
        {
            // TODO: Throw NoArgumentException
            throw new NoArgumentException();
        }

        if (args.Length > 0)
        {
            if (args[0] == "install")
            {
                foreach (string arg in args.Skip(1))
                {
                    Console.WriteLine(arg);

                    
                    
                }

                Console.WriteLine("TEMPORARY: InstallPackage");
            }

            if (args[0] == "remove")
            {
                Console.WriteLine("TEMPORARY: RemovePackage");
            }

            if (args[0] == "search")
            {
                Console.WriteLine("TEMPORARY: SearchPackage");
            }
        }
    }
}

class Header
{
    public void CWHeader()
    {
        Console.WriteLine($"""

            winpack / wp
            https://github.com/ff0044/winpack
            --------------------------------

            """);
    }
}

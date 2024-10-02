using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client;

public class MyCustomException : Exception
{
    public MyCustomException() { }

    public MyCustomException(string message)
        : base(message) { }

    public MyCustomException(string message, Exception inner)
        : base(message, inner) { }
}

public class NoArgumentException : Exception
{
    public NoArgumentException() : base("""

                                        ERROR: 
                                        No arguments have been provided. 
                                        
                                        If you do not know what the command is, do:

                                        wp help
                                       
                                        --------------------------------

                                        """) { }

    public NoArgumentException(string message) : base(message) { }

    public NoArgumentException(string message, Exception inner) : base(message, inner) { }
}

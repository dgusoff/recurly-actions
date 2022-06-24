using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurly_console
{
    public sealed class Settings
    {
        public int KeyOne { get; set; }
        public bool KeyTwo { get; set; }
        public string TestString { get; set; }
        public NestedSettings KeyThree { get; set; } = null!;
    }

    public sealed class NestedSettings
    {
        public string Message { get; set; } = null!;
    }
}

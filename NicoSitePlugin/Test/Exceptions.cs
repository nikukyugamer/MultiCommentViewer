﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicoSitePlugin.Test
{
    [Serializable]
    public class GetPostKeyFailedException : Exception
    {
        public string Response { get; }
        public GetPostKeyFailedException(string res)
        {
            Response = res;
        }
    }
    [Serializable]
    public class ParseException : Exception
    {
        public string Raw { get; }
        public ParseException() { }
        public ParseException(string raw)
        {
            Raw = raw;
        }
        public ParseException(string raw, Exception inner) : base("", inner)
        {
            Raw = raw;
        }
    }
}
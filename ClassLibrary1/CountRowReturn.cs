using System;

namespace DbLib
{
    public class CountRowReturn
    {
        public string Region { get; set; }
        public string Bird { get; set; }
        public string Birder { get; set; }
        public int Count { get; set; }
        public DateTime CountDate { get; set; }
    }
}
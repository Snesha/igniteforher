using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IgniteForHer.Models
{
    public class Instruction
    {
        public int InstructionId { get; set; }
        public string Title { get; set; }
        public string InstructionItem { get; set; }
        public string Hint { get; set; }

        public string Html { get; set; }
        public string Javascript { get; set; }

    }
}
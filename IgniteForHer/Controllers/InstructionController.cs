using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IgniteForHer.Models;

namespace IgniteForHer.Controllers
{
    public class InstructionController : Controller
    {
        public ActionResult Details(int id)
        {
            InstructionContext instructionContext = new InstructionContext();
            Instruction instruction = instructionContext.Instructions.Single(instr => instr.InstructionId == id);

            return View(instruction);
        }
    }
}
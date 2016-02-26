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
        public ActionResult Details()
        {
            InstructionContext instructionContext = new InstructionContext();
            Instruction instruction = instructionContext.Instructions.FirstOrDefault();
            return View(instruction);
        }
        public ActionResult Details2()
        {
            InstructionContext instructionContext = new InstructionContext();
            Instruction instruction = instructionContext.Instructions.Single(inst => inst.InstructionId == 2);
            return View(instruction);
        }

        public ActionResult Instruction1()
        {
            return View();
        }

        public ActionResult Instruction2()
        {
            return View();
        }

        public ActionResult Result1()
        {
            return View();
        }



    }
}
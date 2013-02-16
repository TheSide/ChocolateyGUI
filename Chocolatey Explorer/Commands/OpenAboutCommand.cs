﻿using Chocolatey.Explorer.CommandPattern;
using Chocolatey.Explorer.View.Forms;

namespace Chocolatey.Explorer.Commands
{
    public class OpenAboutCommand : BaseCommand
    {
        public IAbout About { get; set; }

        public override void Execute()
        {
            About.DoShow();
        }
    }
}
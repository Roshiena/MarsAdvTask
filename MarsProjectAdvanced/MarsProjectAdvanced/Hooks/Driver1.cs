using MarsProjectAdvanced.Utitlities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsProjectAdvanced.Hooks
{
    [Binding]
    public sealed class Driver1 : CommonDriver

    {
        [BeforeScenario]
        public void Setup()
        {

            LoginFunction();

        }



        [AfterScenario]

        public void TearDown()
        {

            Close();


        }

    }
}
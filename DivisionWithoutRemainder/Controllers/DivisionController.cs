using DivisionWithoutRemainder.Models;
using DivisionWithoutRemainder.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisionWithoutRemainder.Controllers
{
    public class DivisionController
    {
        Division div = new Division();
        Display disp = new Display();

        public DivisionController()
        {
            disp.Input();

            div.Numbers = disp.Numbers;

            disp.P1 = div.GetP1Value();
            disp.P2 = div.GetP2Value();
            disp.P3 = div.GetP3Value();

            disp.Output();
        }
    }
}

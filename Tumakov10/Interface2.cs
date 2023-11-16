using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov10
{
    interface IColor
    {
        Color ChangeColor(Color color);
    }

    interface IState
    {
        State ChangeState(State state);
    }

    interface Ipok
    {
        Coordinates Vert(int distance);
        Coordinates Horiz(int distance);
    }
}

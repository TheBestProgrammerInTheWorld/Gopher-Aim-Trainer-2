using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gopher_Aim_Trainer_2
{
    class DrawGopherMaybe : DrawingArea
    {
        protected override void OnDraw()
        {
            Image Gopher = global::Gopher_Aim_Trainer_2.Properties.Resources.Goferidle1;

            this.graphics.DrawImage(Gopher, 120, 100);
        }
    }
}

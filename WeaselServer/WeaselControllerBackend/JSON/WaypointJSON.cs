﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaselServer.WeaselControllerBackend.JSON
{
    internal class WaypointJSON
    {
        public int _PointID;
        public bool _Reserved;
        public string _ReservedColorName;

        public WaypointJSON(int PointID1, bool Reserved1, string ReservedColorName1)
        {
            this._PointID = PointID1;
            this._Reserved = Reserved1;
            this._ReservedColorName = ReservedColorName1;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaselServer.WeaselControllerBackend.Map
{
    internal class DestinationInformation
    {
        private string _SendBy;
        private string _ActionBeforeMovement;
        private int _Destination;
        private string _ActionAfterMovement;

        public DestinationInformation(string SendBy, string ActionBeforeMovement, int Destination, string ActionAftermovement)
        {
            this._SendBy = SendBy;
            _ActionBeforeMovement = ActionBeforeMovement;
            _Destination = Destination;
            _ActionAfterMovement = ActionAftermovement;
        }
    }
}
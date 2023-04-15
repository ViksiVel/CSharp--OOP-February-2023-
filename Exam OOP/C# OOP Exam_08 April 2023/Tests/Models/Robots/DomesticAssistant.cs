﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models.Robots
{
    public class DomesticAssistant : Robot
    {
        private const int BatteryCapacity = 20000;
        private const int convertionCapacityIndex = 2000;
        public DomesticAssistant(string model) : base(model, BatteryCapacity, convertionCapacityIndex)
        {
        }
    }
}

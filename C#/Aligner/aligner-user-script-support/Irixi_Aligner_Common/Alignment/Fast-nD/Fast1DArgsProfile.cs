﻿using Irixi_Aligner_Common.Alignment.Base;
using Irixi_Aligner_Common.Classes;
using Irixi_Aligner_Common.Interfaces;

namespace Irixi_Aligner_Common.Alignment.FastND
{
    public class Fast1DArgsProfile : AlignmentProfileBase
    {
        
        public string Axis { get; set; }
        public bool IsEnable { get; set; }
        public double Interval { get; set; }
        public double ScanRange { get; set; }
        public int ScanOrder { get; set; }


        public override void FromArgsInstance(IAlignmentArgs Args)
        {
            var targ = Args as Fast1DArgs;
            this.Axis = targ.Axis.HashString;
            this.IsEnable = targ.IsEnabled;
            this.Interval = targ.Interval;
            this.ScanRange = targ.Range;
            this.ScanOrder = targ.Order;
            this.Speed = targ.MoveSpeed;
            this.HashString = this.GetHashString();
        }


        public override void ToArgsInstance(SystemService Service, IAlignmentArgs Args)
        {
            var targ = Args as Fast1DArgs;
            targ.IsEnabled = this.IsEnable;
            targ.Interval = this.Interval;
            targ.Range = this.ScanRange;
            targ.Order = this.ScanOrder;
            targ.MoveSpeed = this.Speed;
        }
    }
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThermoRawFileParser.XIC
{
    public class XicUnit
    {
        public XicMeta Meta { get; set; }
        public object X { get; set; }
        public object Y { get; set; }
    
    
        public XicUnit()
        {
            
        }
        
        public XicUnit (double mzstart, double mzend, double rtstart, double rtend)
        {
            Meta.MzStart = mzstart;
            Meta.MzEnd = mzend;
            Meta.RtStart = rtstart;
            Meta.RtEnd = rtend;
        }

        public XicUnit(XicUnit copy)
        {
            Meta = new XicMeta(copy.Meta);
            if (copy.X is string)
            {
                X = (string)copy.X;
            }
            else
            {
                ArrayList x = new ArrayList();
                foreach (double d in (ArrayList)copy.X)
                {
                    x.Add(d);
                }
                X = x;
            }
            if (copy.Y is string)
            {
                Y = (string)copy.Y;
            }
            else
            {
                ArrayList y = new ArrayList();
                foreach (double d in (ArrayList)copy.Y)
                {
                    y.Add(d);
                }
                Y = y;
            }
        }
    }
}

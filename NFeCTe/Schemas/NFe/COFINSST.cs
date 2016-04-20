﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Contabil
{
    public class COFINSST
    {
        private double _vBC;
        private double _pCOFINS;
        private double _qBCProd;
        private double _vAliqProd;
        private double _vCOFINS;

        public double vBC { get { return _vBC; } set { _vBC = value; } }
        public double pCOFINS { get { return _pCOFINS; } set { _pCOFINS = value; } }
        public double qBCProd { get { return _qBCProd; } set { _qBCProd = value; } }
        public double vAliqProd { get { return _vAliqProd; } set { _vAliqProd = value; } }
        public double vCOFINS { get { return _vCOFINS; } set { _vCOFINS = value; } }
    }
}

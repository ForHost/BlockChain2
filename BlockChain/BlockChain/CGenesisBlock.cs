﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    class CGenesisBlock : CBlock
    {
        public CGenesisBlock()
        {
            this.Hash = "GENESISBLOCK";
            this.BlockNumber = 0;
            this.Transiction = "";
            this.Nonce = 0;
            this.Timestamp = 0;
            this.Difficutly = 1;
        }
    }
}
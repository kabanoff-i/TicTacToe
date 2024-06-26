﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class FilledCellException: Exception
    {
        public FilledCellException() { }
        public FilledCellException(string message) : base(message) { }
        public FilledCellException(string message, Exception e): base(message, e) { }
    }
}

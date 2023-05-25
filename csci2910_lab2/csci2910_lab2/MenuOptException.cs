/**
*--------------------------------------------------------------------
* File name: MenuOptException.cs
* Project name: csci2910_lab2
*--------------------------------------------------------------------
* Author’s name and email: Tessa Williams williamstm5@etsu.edu
* Course-Section: CSCI-2910
* Creation Date: 05/25/2023
* -------------------------------------------------------------------
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csci2910_lab2
{
    public class MenuOptException : Exception
    {
        public MenuOptException() : base() { }
        public MenuOptException(string message) : base(message) { }
        public MenuOptException(string message, Exception e) : base(message, e) { }
    }
}

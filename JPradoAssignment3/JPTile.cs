/*
 * JPTile.cs
 * Description: a class that inherits from PictureBox
 *   and adds a string Code property.
 * 
 * Revision History:
 *          Jemillee Prado 12-01-2019 : Created
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JPradoAssignment3
{
    public class JPTile : PictureBox
    {
        private string code;

        public string Code { get => code; set => code = value; }                
    }
}

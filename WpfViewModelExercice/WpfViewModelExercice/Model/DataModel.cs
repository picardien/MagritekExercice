using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WpfViewModelExercice.Model
{
    /// <summary>
    /// Data Model
    /// </summary>
    public class DataModel
    {
        /// <summary>
        /// Entry Number A
        /// </summary>
        public double A { get; set; }

        /// <summary>
        /// Entry number B
        /// </summary>
        public double B { get; set; }

        /// <summary>
        /// Result of A + B
        /// </summary>
        public double C { get; set; }

        /// <summary>
        /// Result of A * B
        /// </summary>
        public double D { get; set; }

        public void Operation()
        {
            C = A + B;
            D = A * B;
        }
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_Library
{
    public class Moto : Vehiculo
    {
        public Moto(EMarca marca, string patente, ConsoleColor color)
            : base(patente, marca, color)
        {
        }
        /// <summary>
        /// Las motos tienen 2 ruedas
        /// </summary>
        protected override short CantidadRuedas
        {
            get
            {
                return 2;
            }
        }

        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("MOTO");
            sb.AppendLine(base.Mostrar());

            return sb.ToString();
        }
    }
}

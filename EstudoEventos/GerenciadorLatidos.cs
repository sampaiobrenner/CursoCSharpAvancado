﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoEventos
{
    public class GerenciadorLatidos
    {
        private int _intensidadeLatido;
        //public delegate void ExcessoDecibeisHandler(object sender, EventArgs e);

        public event EventHandler ExcessoDecibeisEvent;

        public GerenciadorLatidos()
        {
            _intensidadeLatido = 0;
        }

        public int Latir()
        {
            if  (_intensidadeLatido <= 90)
            {
                _intensidadeLatido += 10;
            }

            if (_intensidadeLatido > 80)
            {

                ExcessoDecibeisEventsArgs e = new ExcessoDecibeisEventsArgs
                {
                    IntensidadeLatido = _intensidadeLatido
                };
                OnExcessoDecibeis(e);
            }

            return _intensidadeLatido;
        }

        protected virtual void OnExcessoDecibeis(EventArgs e)
        {
            if (ExcessoDecibeisEvent != null)
            {
                ExcessoDecibeisEvent(this, e);

            }

        }





    }
}

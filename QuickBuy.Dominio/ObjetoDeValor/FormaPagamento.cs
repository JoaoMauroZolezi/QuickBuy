﻿using QuickBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public  class FormaPagamento
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool EhBoleto
        {
            get { return id == (int)TipoFormaPagamentoEnum.Boleto; }
        }
        public bool EhCartaoCredito
        {
            get { return id == (int)TipoFormaPagamentoEnum.CartaoCredito; }
        }
        public bool EhDeposito
        {
            get { return id == (int)TipoFormaPagamentoEnum.Deposito; }
        }
        public bool EhNaoDefinido
        {
            get { return id == (int)TipoFormaPagamentoEnum.NaoDefinido; }
        }


    }
}

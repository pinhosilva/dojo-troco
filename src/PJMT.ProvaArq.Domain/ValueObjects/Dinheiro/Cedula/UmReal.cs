﻿namespace PJMT.ProvaArq.Domain.ValueObjects.Dinheiro.Cedula
{
    public class UmReal : ICedula
    {
        public decimal Valor => 1M;

        public override string ToString() => "Um Real";
    }
}

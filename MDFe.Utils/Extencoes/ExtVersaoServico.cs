﻿using ManifestoDocumentoFiscalEletronico.Classes.Servicos.Flags;

namespace MDFe.Utils.Extencoes
{
    public static class ExtVersaoServico
    {
        public static string GetVersaoString(this VersaoServico versaoServico)
        {
            var codigoString = versaoServico.ToString();
            var codigoFormatado = codigoString.Substring(6, 3);
            codigoFormatado = codigoFormatado.Insert(1, ".");
            return codigoFormatado;
        }
    }
}
﻿using QuickBuy.Dominio.Contratos;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace QuickBuy.Repositorio.Repositorio
{
   public class UsuarioRepositorio: BaseRepositorio<Usuario>,IUsuarioRepositorio
    {
        public UsuarioRepositorio()
        {

        }
    }
}
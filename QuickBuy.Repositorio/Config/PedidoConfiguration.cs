﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.PedidoId);

            builder.Property(p => p.DataPedido)
                .IsRequired();
            

            builder.Property(p => p.DataPrevisaoEntrega)
               .IsRequired();

            builder.Property(p => p.Cep)
            .IsRequired();

              builder.Property(p => p.Estado)
            .IsRequired();

            builder.Property(p => p.Cidade)
          .IsRequired();

            builder.Property(p => p.EnderecoCompleto)
         .IsRequired();

            builder.Property(p => p.NumeroEndereco)
         .IsRequired();


          builder.HasOne(p => p.FormaPagamento);       

          

        }
    }
}

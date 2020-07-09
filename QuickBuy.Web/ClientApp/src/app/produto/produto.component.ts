import { Component,OnInit } from "@angular/core";
import { Produto } from "../modelos/Produto";
import { ProdutoServico } from "../servicos/produto/produto.servico"
import { Router } from "@angular/router";
@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]
})

export class ProdutoComponent {
  public produto: Produto;

  constructor(private produtoServico: ProdutoServico) {

  }


  ngOnInit(): void {
    this.produto = new Produto();

  }

  public cadastrar() {
    this.produtoServico.cadastrar(this.produto)
      .subscribe(
        produtoJson => {
          console.log(produtoJson);
        },
        error => {
          console.log(error);
        }
      );

  }

}

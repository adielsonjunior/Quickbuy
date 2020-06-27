import { Component } from "@angular/core";

@Component({
  selector: "app-produto",
  templateUrl: "./produto.component.html",
  styleUrls: ["./produto.component.css"]
})

export class ProdutoComponent {
  public produtoId: number;
  public nome: string;
  public preco: number;


  public obterNome(): string {
    return "Sansung";
  }
} 
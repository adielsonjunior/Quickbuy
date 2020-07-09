import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelos/usuario";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "cadastro-usuario",
  templateUrl: "./cadastro.usuario.component.html",
  styleUrls: ["./cadastro.usuario.component.css"]

})

export class CadastroUsuarioComponent implements OnInit{
  public usuario: Usuario;
  public ativar_spinner: boolean;
  public mensagem: string;
  public usuarioCadastrado: boolean;



  constructor(private usuarioServico: UsuarioServico) {
  }
  
  ngOnInit(): void {
    this.usuario = new Usuario();

  }

  public cadastrar() {
    this.ativar_spinner = true;
     this.usuarioServico.cadastrarUsuario(this.usuario)
      .subscribe(
        usuarioJson => {
          this.usuarioCadastrado = true;
          this.ativar_spinner = false;
        },
        e => {
          this.ativar_spinner = false;
          this.mensagem = e.error;
        }
      );
  }

}

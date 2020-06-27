import { Component } from "@angular/core";
import { Usuario } from "../../modelos/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})

export class LoginComponent {
  public usuario;
  public usuarioAutenticado: boolean; 


  constructor() {

    this.usuario = new Usuario();
  }
  

  entrar() {
    if (this.usuario.email == "adielson") {
      this.usuarioAutenticado = true;
    }

  }


}

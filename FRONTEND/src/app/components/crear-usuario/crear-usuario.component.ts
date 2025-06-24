import { Component } from '@angular/core';
import { Data } from '@angular/router';
import { FormsModule } from '@angular/forms'

interface NuevoUsuarioDTO {
  Nombre: string,
  ApellidoPaterno: string,
  ApellidoMaterno: string,
  FechaNacimiento: string,
  Carnet: string,
  Contrasena: string
}

@Component({
  selector: 'app-crear-usuario',
  imports: [FormsModule],
  templateUrl: './crear-usuario.component.html',
  styleUrl: './crear-usuario.component.css'
})
export class CrearUsuarioComponent {

  arrUsuarios: NuevoUsuarioDTO[] = [];

  private nuevoUsuario: NuevoUsuarioDTO = {
    Nombre: '',
    ApellidoPaterno: '',
    ApellidoMaterno: '',
    FechaNacimiento: '',
    Carnet: '',
    Contrasena: ''
  }

  public getNuevoUsuario() {
    return this.nuevoUsuario;
  }

  public confirmarUsuario() {
    this.arrUsuarios.push(this.nuevoUsuario);
    this.nuevoUsuario = {
      Nombre: '',
      ApellidoPaterno: '',
      ApellidoMaterno: '',
      FechaNacimiento: '',
      Carnet: '',
      Contrasena: ''
    };
    this.arrUsuarios.forEach(function (value) {
      console.log(value);
    });
  }
}

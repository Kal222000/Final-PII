import { Component } from '@angular/core';
import { Data } from '@angular/router';
import { FormsModule } from '@angular/forms'

interface NuevoUsuario {
  nombre: string,
  apellidoPaterno: string,
  apellidoMaterno: string,
  fechaNacimiento: string,
  CI: string,
  contrasena: string
}

@Component({
  selector: 'app-crear-usuario',
  imports: [FormsModule],
  templateUrl: './crear-usuario.component.html',
  styleUrl: './crear-usuario.component.css'
})
export class CrearUsuarioComponent {

  arrUsuarios: NuevoUsuario[] = [];

  private nuevoUsuario: NuevoUsuario = {
    nombre: '',
    apellidoPaterno: '',
    apellidoMaterno: '',
    fechaNacimiento: '',
    CI: '',
    contrasena: ''
  }

  public getNuevoUsuario() {
    return this.nuevoUsuario;
  }

  public confirmarUsuario() {
    this.arrUsuarios.push(this.nuevoUsuario);
    this.nuevoUsuario = {
      nombre: '',
      apellidoPaterno: '',
      apellidoMaterno: '',
      fechaNacimiento: '',
      CI: '',
      contrasena: ''
    };
    this.arrUsuarios.forEach(function (value) {
      console.log(value);
    });
  }
}

import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';

interface Usuario {
  CI: string,
  contrasena: string
}

@Component({
  selector: 'app-log-in',
  imports: [FormsModule, RouterLink],
  templateUrl: './log-in.component.html',
  styleUrl: './log-in.component.css'
})

export class LogInComponent {

  private usuario: Usuario = { CI: '', contrasena: '' };
  private mensaje: string = '';
  private mostrarContrasena: boolean = false;

  public getUsuario() {
    return this.usuario;
  }

  public getMensaje() {
    return this.mensaje;
  }

  public getMostrarContrasena() {
    return this.mostrarContrasena;
  }

  public alternarMostrarContrasena() {
    this.mostrarContrasena = !this.mostrarContrasena;
  }

  public verificarCredenciales() {
    if (this.usuario.CI != "1234" && this.usuario.contrasena != "diego") {
      this.mensaje = "El identificador o contraseña son incorrectos";
    }
    this.usuario.CI = '';
    this.usuario.contrasena = '';
  }
  
}

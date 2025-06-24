import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { Router, RouterLink } from '@angular/router';
import { AutentificacionService, CredencialesDTO } from '../../services/autentificacion.service';

@Component({
  selector: 'app-log-in',
  imports: [FormsModule, RouterLink],
  templateUrl: './log-in.component.html',
  styleUrl: './log-in.component.css'
})

export class LogInComponent {

  private usuario: CredencialesDTO = { Carnet: '', Contrasena: '' };
  private mensaje: string = '';
  private mostrarContrasena: boolean = false;
  constructor(
    private autentificacionService: AutentificacionService,
    private router: Router
  ) { }

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

  
  verificarCredenciales() {
    this.router.navigate(['/pagina-principal']);
    /*
    const credenciales: Credenciales = {
      Carnet: this.usuario.Carnet,
      Contrasena: this.usuario.Contrasena
    };
    //llamamos al metodo login
    //subscribe() se usa por que esperamos una respuesta del backend al usar Observable
    
    this.autentificacionService.login(credenciales).subscribe({
      //subscribe tiene dos posibles respuestas: next o error
      next: (respuesta) => {
        if (respuesta) {
          this.router.navigate(['/pagina-principal']);
        } else {
          this.mensaje = 'CI o contraseña incorrectos';
        }
      },
      error: (err) => {
        console.error(err);
        this.mensaje = 'Error al conectar con el servidor';
      }
    });

    // Limpiar campos después del intento
    this.usuario.Carnet = '';
    this.usuario.Contrasena = '';
    */
  }
  
}

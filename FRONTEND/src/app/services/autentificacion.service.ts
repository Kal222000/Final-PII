import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
export interface CredencialesDTO {
  Carnet: string;
  Contrasena: string;
}

@Injectable({
  providedIn: 'root'
})
export class AutentificacionService {
  private apiUrl = 'http://localhost:5000/api'; // Reemplaza con la URL real de tu backend
  constructor(private http: HttpClient) { }

  // Envía los datos al backend y espera la respuesta
  login(credenciales: CredencialesDTO): Observable<any> {
    return this.http.post(`${this.apiUrl}/usuario/ValidarUsuario`, credenciales);
  }
}

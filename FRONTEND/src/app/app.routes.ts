// src/app/app.routes.ts
import { Routes } from '@angular/router';
import { LogInComponent } from './auntentificacion/pages/log-in/log-in.component';
import { CrearUsuarioComponent } from './crearUsuario/pages/crear-usuario/crear-usuario.component';

export const routes: Routes = [
  { path: '', component: LogInComponent },
  { path: 'crear-usuario', component: CrearUsuarioComponent }
];

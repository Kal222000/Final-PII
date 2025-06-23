import { Component } from '@angular/core';
import { RouterModule, RouterOutlet } from '@angular/router';
import { routes } from './app.routes'
import { LogInComponent } from './auntentificacion/pages/log-in/log-in.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, LogInComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'FrontEnd';
}

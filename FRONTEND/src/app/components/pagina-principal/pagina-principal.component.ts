import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import { CommonModule } from '@angular/common';

interface LibroDTO {
  ID: number;
  Titulo: string;
  Autor: string;
}

@Component({
  selector: 'app-pagina-principal',
  imports: [FormsModule, RouterLink, CommonModule],
  templateUrl: './pagina-principal.component.html',
  styleUrl: './pagina-principal.component.css'
})
export class PaginaPrincipalComponent {
  terminoBusqueda: string = '';

  libros: LibroDTO[] = [];

  librosMostrados: LibroDTO[] = [];

  paginaActual: number = 1;

  librosPorPagina: number = 5;

  paginas: number[] = [];

  carrito: LibroDTO[] = [];

  mensajeAlerta: string = '';

  constructor() {
    this.libros = [
      { ID: 1, Titulo: 'Cien Años de Soledad', Autor: 'Gabriel García Márquez' },
      { ID: 2, Titulo: 'Don Quijote', Autor: 'Miguel de Cervantes' },
      { ID: 3, Titulo: '1984', Autor: 'George Orwell' },
      { ID: 4, Titulo: 'Rayuela', Autor: 'Julio Cortázar' },
      { ID: 5, Titulo: 'El Aleph', Autor: 'Jorge Luis Borges' },
      { ID: 6, Titulo: 'Pedro Páramo', Autor: 'Juan Rulfo' },
      { ID: 7, Titulo: 'Ficciones', Autor: 'Jorge Luis Borges' },
    ];

    this.buscarLibros();
  }

  agregarAlCarrito(libro: LibroDTO) {
    if (this.carrito.length >= 5) {
      this.mensajeAlerta = 'No puedes agregar más de 5 libros al carrito.';
      return;
    }
    this.carrito.push(libro);
    this.mensajeAlerta = '';
    this.paginaActual = 1; // reset página para evitar inconsistencias
    this.buscarLibros();   // actualiza libros mostrados y paginación
  }

  cerrarAlerta() {
    this.mensajeAlerta = '';
  }

  actualizarLibrosMostrados(listaFiltrada: LibroDTO[]) {
    const librosDisponibles = listaFiltrada.filter(libro =>
      !this.carrito.some(c => c.ID === libro.ID)
    );

    const startIndex = (this.paginaActual - 1) * this.librosPorPagina;
    const endIndex = startIndex + this.librosPorPagina;

    this.librosMostrados = librosDisponibles.slice(startIndex, endIndex);

    // Actualizar paginación con los libros disponibles
    const totalPaginas = Math.ceil(librosDisponibles.length / this.librosPorPagina);
    this.paginas = Array.from({ length: totalPaginas }, (_, i) => i + 1);
  }

  buscarLibros() {
    const filtrados = this.libros.filter(libro =>
      libro.Titulo.toLowerCase().includes(this.terminoBusqueda.toLowerCase()) ||
      libro.Autor.toLowerCase().includes(this.terminoBusqueda.toLowerCase())
    );

    this.actualizarLibrosMostrados(filtrados);
  }

  irAPagina(numero: number) {
    if (numero < 1 || numero > this.paginas.length) return;
    this.paginaActual = numero;
    this.buscarLibros();
  }
}

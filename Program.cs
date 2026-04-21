using ConsoleApp1;
using System;

Carrito carrito = new Carrito();

carrito.SetEstrategia(new PagoTarjeta());
carrito.RealizarPago(100);

carrito.SetEstrategia(new PagoEfectivo());
carrito.RealizarPago(50);
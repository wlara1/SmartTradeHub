import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { OrdersList } from './features/orders/pages/orders-list/orders-list';
import { OrderCreate } from './features/orders/pages/order-create/order-create';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, OrdersList, OrderCreate],
  templateUrl: './app.html',
  styleUrl: './app.scss'
})
export class App {
  protected readonly title = signal('smart-trade-hub-front');
}

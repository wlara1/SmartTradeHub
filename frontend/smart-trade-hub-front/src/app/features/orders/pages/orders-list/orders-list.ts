import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Order } from '../../../../core/models/order.model';
import { OrdersService } from '../../../../core/services/orders.service';

@Component({
  selector: 'app-orders-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './orders-list.html',
  styleUrl: './orders-list.scss',
})
export class OrdersList {
  orders: Order[] = [];

  constructor(private ordersService: OrdersService) {}

  ngOnInit(): void {
    this.ordersService.getOrders().subscribe(data => {
      this.orders = data;
    });
  }
}

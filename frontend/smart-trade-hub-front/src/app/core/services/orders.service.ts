import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Order } from '../models/order.model';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {

  private apiUrl = 'https://localhost:5001/api/orders';

  constructor(private http: HttpClient) {}

  getOrder(id: string): Observable<Order> {
    return this.http.get<Order>(`${this.apiUrl}/${id}`);
  }

  createOrder(order: any): Observable<Order> {
    return this.http.post<Order>(this.apiUrl, order);
  }
}

import { Routes } from '@angular/router';
import { OrdersList } from './features/orders/pages/orders-list/orders-list';
import { OrderCreate } from './features/orders/pages/order-create/order-create';

export const routes: Routes = [
    { path: 'orders', component: OrdersList },
    { path: 'orders/create', component: OrderCreate }
];

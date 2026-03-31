export interface OrderLine {
  productId: string;
  unitPrice: number;
  quantity: number;
  tvaRate: number;
}

export interface Order {
  id: string;
  customerId: string;
  status: OrderStatus;
  total: number;
  orderDate: Date;
  lines: OrderLine[];
}

export enum OrderStatus {
  Draft = 0,
  Confirmed = 1,
  Cancelled = 2,
  Shipped = 3,
  Paid = 4
}
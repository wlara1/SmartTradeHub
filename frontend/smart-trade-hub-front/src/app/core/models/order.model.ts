export interface OrderLine {
  productId: string;
  unitPrice: number;
  quantity: number;
}

export interface Order {
  id: string;
  customerId: string;
  status: string;
  total: number;
  lines: OrderLine[];
}

import { Component } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators, ReactiveFormsModule } from '@angular/forms';
import { OrdersService } from '../../../../core/services/orders.service';

@Component({
  selector: 'app-order-create',
  standalone: true,
  imports: [ReactiveFormsModule],
  templateUrl: './order-create.html',
  styleUrl: './order-create.scss',
})
export class OrderCreate {
  orderForm: FormGroup;

  constructor(
    private formBuilder: FormBuilder, 
    private ordersService: OrdersService
  ) {
    this.orderForm = this.formBuilder.group({
      customerId: ['', Validators.required],
      status: [0],
      orderDate: [new Date(), Validators.required],//[new Date().toISOString().substring(0, 10)],
      lines: this.formBuilder.array([])
    });
  }

  get lines(): FormArray {
    return this.orderForm.get('lines') as FormArray;
  }

  addLine() {
    this.lines.push(this.formBuilder.group({
      productId: ['', Validators.required],
      unitPrice: [1, Validators.required],
      quantity: [1, Validators.required],
      tvaRate: [20, Validators.required]
    }));
  }

  removeLine(index: number) {
    this.lines.removeAt(index);
  }

  submit() {
    if (this.orderForm.valid) {
      this.ordersService.createOrder(this.orderForm.value).subscribe(response => {
        console.log('Commande créée :', response);
        // Optionally reset the form or navigate to another page
      });
    }

}
}
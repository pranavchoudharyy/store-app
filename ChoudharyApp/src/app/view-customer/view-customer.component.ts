import { Component, OnInit } from '@angular/core';
import { ICustomer } from 'src/interfaces/customer';
import { CustomerService } from 'src/services/ChoudharyServices/customer.service';

@Component({
  selector: 'app-view-customer',
  templateUrl: './view-customer.component.html',
  styleUrls: ['./view-customer.component.css']
})

export class ViewCustomerComponent implements OnInit 
{
  customers : ICustomer[]
  showMsgDiv: boolean = false;

  constructor(private _customerService : CustomerService) 
  { 
    this.customers =[]
  }

  ngOnInit(): void 
  {
    this.getCustomers()
  }
  getCustomers()
  {
    this._customerService.getCustomers().subscribe
    (
      res=> this.customers = res
    );
  }

}
